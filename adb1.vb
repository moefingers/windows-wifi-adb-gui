Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Runtime.Remoting.Channels
Imports System.Security.Cryptography.X509Certificates
Imports System.Text.RegularExpressions
Imports System.Xml


Public Class FM
    Dim ErrorMessage As String
    'Exit, minimize, on close
    Private Sub FormMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ExecuteHiddenProcess("adb.exe", "kill-server")
    End Sub
    Private Sub ButtonE_ClickOrTSMIE_Click(sender As Object, e As EventArgs) Handles ButtonE.Click, TSMIE.Click
        Application.Exit()
    End Sub
    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles ButtonM.Click
        Me.WindowState = FormWindowState.Minimized
        adbpair.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
        NI.Visible = True
    End Sub
    Private Sub NI_MouseClickOrDoubleClick(sender As Object, e As MouseEventArgs) Handles NI.MouseClick, NI.MouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            CMSE.Show(Cursor.Position)
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.WindowState = FormWindowState.Normal
            Me.Focus()
            Me.ShowInTaskbar = True
            NI.Visible = False
        End If
    End Sub


    'on main form load
    Private Sub FM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Delete key to coerce recreation of said key
        If My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\.android\adbkey.pub") Then
            Console.WriteLine("ADB key already exists, deleting to coerce recreation of key")
            My.Computer.FileSystem.DeleteFile(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\.android\adbkey.pub")
        End If

        ' window positioning
        Me.StartPosition = StartPosition.Manual
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height - 40)

        ' initialize file paths to check and write
        Dim adbExePath As String = IO.Path.Combine(Application.StartupPath, "adb.exe")
        Dim adbDllPath As String = IO.Path.Combine(Application.StartupPath, "AdbWinApi.dll")
        Dim configTxtPath As String = IO.Path.Combine(Application.StartupPath, "config.txt")

        ' check file exists adb exe and write if doesn't exist
        If My.Computer.FileSystem.FileExists(adbExePath) Then
            Console.WriteLine("adb.exe already exists")
        Else
            Console.WriteLine("writing adb.exe because it doesn't exist")
            Dim BytesToWriteExeResource() As Byte = My.Resources.adbexe
            Dim FileStreamAdbExe As New System.IO.FileStream(adbExePath, System.IO.FileMode.OpenOrCreate)
            Dim BinaryWriterAdbExe As New System.IO.BinaryWriter(FileStreamAdbExe)
            BinaryWriterAdbExe.Write(BytesToWriteExeResource)
            BinaryWriterAdbExe.Close()
            FileStreamAdbExe.Close()
        End If

        ' check file exists adb dll and write if doesn't exist
        If My.Computer.FileSystem.FileExists(adbDllPath) Then
            Console.WriteLine("AdbWinApi.dll already exists")
        Else
            Console.WriteLine("writing AdbWinApi.dll because it doesn't exist")
            Dim BytesToWriteDllResource() As Byte = My.Resources.AdbWinApidll
            Dim FileStreamAdbDll As New System.IO.FileStream(adbDllPath, System.IO.FileMode.OpenOrCreate)
            Dim BinaryWriterAdbDll As New System.IO.BinaryWriter(FileStreamAdbDll)
            BinaryWriterAdbDll.Write(BytesToWriteDllResource)
            BinaryWriterAdbDll.Close()
            FileStreamAdbDll.Close()
        End If

        ' now that we have the exe,kill server regardless of if it's running or not
        ExecuteHiddenProcess("adb.exe", "kill-server")


        ' check if configtxt exists and write one if it doesn't with default being my local working address/port
        If My.Computer.FileSystem.FileExists(configTxtPath) Then
            Console.WriteLine("config.txt exists")
            Dim configReader = My.Computer.FileSystem.OpenTextFileReader(configTxtPath)
            Dim configLine1 As String = configReader.ReadLine()
            configReader.Close()
            Console.WriteLine($"The first line of {configTxtPath} is {configLine1}")
            TextBoxAddress.Text = configLine1
        Else
            ' create config file if doesnt exist
            File.Create(configTxtPath).Dispose()
            ' write to file and second parameter is for append (false means overwrite)
            Console.WriteLine("created config.txt because it didn't exist")
            Dim configFileWriter = My.Computer.FileSystem.OpenTextFileWriter(configTxtPath, False)
            configFileWriter.WriteLine("10.0.0.162:38829")
            configFileWriter.Close()
            Console.WriteLine("Wrote default 10.0.0.162:38829")
        End If
        ' and finallly read contents of config.txt
        Console.WriteLine($"Reading contents of {configTxtPath}")
        Dim WrittenConfigReader = My.Computer.FileSystem.OpenTextFileReader(configTxtPath)
        Dim WrittenConfigLine1 As String = WrittenConfigReader.ReadLine()
        WrittenConfigReader.Close()

        Console.WriteLine($"Result is {WrittenConfigLine1}")
        TextBoxAddress.Text = WrittenConfigLine1
    End Sub

    'pair button
    Private Sub ButtonPair_Click(sender As Object, e As EventArgs) Handles ButtonPair.Click

        If Application.OpenForms.OfType(Of Form).Contains(adbpair) Then
            ButtonPair.Text = "Pair"
            adbpair.Close()
        Else
            ButtonPair.Text = "Cancel Pairing"
            adbpair.Show()
        End If

    End Sub

    'media controls
    Private Sub ButtonPP_Click(sender As Object, e As EventArgs) Handles ButtonPP.Click
        ExecuteHiddenProcess("adb.exe", "shell input keyevent 85")
    End Sub
    Private Sub ButtonRV_Click(sender As Object, e As EventArgs) Handles ButtonRV.Click
        'raise volume for connected device and update volume in text box with GetConnectedDeviceVolume()
        ExecuteHiddenProcess("adb.exe", "shell input keyevent 24")
        GetConnectedDeviceVolume()
    End Sub

    Private Sub ButtonLV_Click(sender As Object, e As EventArgs) Handles ButtonLV.Click
        'lower volume for connected device and update volume in text box with GetConnectedDeviceVolume()
        ExecuteHiddenProcess("adb.exe", "shell input keyevent 25")
        GetConnectedDeviceVolume()
    End Sub

    Private Sub ButtonSV_Click(sender As Object, e As EventArgs) Handles ButtonSV.Click
        'Set volume for connected device and update volume in text box with GetConnectedDeviceVolume()
        ExecuteHiddenProcess("adb.exe", $"shell cmd media_session volume --set {TextBoxV.Text}")
        GetConnectedDeviceVolume()
    End Sub

    Private Sub ButtonP_Click(sender As Object, e As EventArgs) Handles ButtonP.Click
        'Double execution media previous because the first previous returns to beginning of song
        ExecuteHiddenProcess("adb.exe", "shell input keyevent 88")
        ExecuteHiddenProcess("adb.exe", "shell input keyevent 88")
    End Sub

    Private Sub ButtonN_Click(sender As Object, e As EventArgs) Handles ButtonN.Click
        ExecuteHiddenProcess("adb.exe", "shell input keyevent 87")
    End Sub

    'Connection
    Private Async Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click

        ' Write/save  new adddress/port to config
        '
        'initialize path for config
        Dim configTxtPath As String = IO.Path.Combine(Application.StartupPath, "config.txt")
        'if exists then overwrite
        If My.Computer.FileSystem.FileExists(configTxtPath) Then 'if file exists
            Console.WriteLine("config.txt exists")

        Else ' file doesn't exist
            ' create file
            File.Create(configTxtPath).Dispose()

        End If
        ' and then write to config file, second paramter is for append (false means overwrite)
        Console.WriteLine($"overwriting config file to {TextBoxAddress.Text}")
        Dim configFileWriter = My.Computer.FileSystem.OpenTextFileWriter(configTxtPath, False)
        configFileWriter.WriteLine(TextBoxAddress.Text)
        configFileWriter.Close()

        'Attempt connection
        Connect()

    End Sub


    Private Sub ButtonConnect_MouseDown(sender As Object, e As MouseEventArgs) Handles ButtonConnect.MouseDown
        ButtonConnect.BackColor = Color.Red
        ButtonConnect.Text = "WAIT."
    End Sub

    Private Sub ButtonConnect_MouseUp(sender As Object, e As MouseEventArgs) Handles ButtonConnect.MouseUp
        ButtonConnect.BackColor = Color.Transparent
        ButtonConnect.Text = "Connect"
    End Sub

    Public Sub Connect()

        'invoke hidden process function with standard hidden properties
        'return is array of standardoutput and standard error
        ExecuteHiddenProcess("adb.exe", $"connect {TextBoxAddress.Text}")

        GetConnectedDeviceVolume()
    End Sub

    Private Async Function GetConnectedDeviceVolume() As Task

        'invoke hidden process function with standard hidden properties
        'return is array of standardoutput and standard error
        Dim VolumeProcessOutput = Await ExecuteHiddenProcess("adb.exe", "shell cmd media_session volume --get")


        ' display volume in textbox

        'Dim RegExpMatchOutput As Match = Regex.Match(VolumeProcessOutput(0), ".*\[(\d+)\.+(\d+)\]") - for range
        Dim RegExpMatchOutput As Match = Regex.Match(VolumeProcessOutput(0), ".*volume is (\d+).*")
        Try
            TextBoxV.Text = RegExpMatchOutput.Groups(1).Value
        Catch f As ArgumentOutOfRangeException
            ConnectionErrorMsgBox($"{VolumeProcessOutput(0)} ||||||||||| {VolumeProcessOutput(1)}")
        End Try

    End Function


    'error details stuff
    Public Sub ConnectionErrorMsgBox(Message As String)
        Me.ErrorMessage = Message
        ErrorDetailsLabel.Visible = True
        ShortStatusLabel.Text = ""
    End Sub

    Private Sub ErrorDetailsLabel_Click(sender As Object, e As EventArgs) Handles ErrorDetailsLabel.Click
        MsgBox(Me.ErrorMessage)
        ErrorDetailsLabel.Visible = False

    End Sub
    'hover over color changes so user can feel that it's a button
    Private Sub ErrorDetailsLabel_Enter(sender As Object, e As EventArgs) Handles ErrorDetailsLabel.MouseEnter
        ErrorDetailsLabel.BackColor = Color.White
        ErrorDetailsLabel.ForeColor = Color.Red
    End Sub
    Private Sub ErrorDetailsLabel_Leave(sender As Object, e As EventArgs) Handles ErrorDetailsLabel.MouseLeave
        ErrorDetailsLabel.BackColor = Color.Red
        ErrorDetailsLabel.ForeColor = Color.White
    End Sub

    'execute any function as hidden
    Public Async Function ExecuteHiddenProcess(FileName As String, Parameters As String) As Task(Of Array)


        Console.WriteLine($"EXECUTING {FileName} {Parameters}")
        Dim HiddenProcess As New Process()
        HiddenProcess.StartInfo = New ProcessStartInfo(FileName, Parameters)
        HiddenProcess.StartInfo.UseShellExecute = False
        HiddenProcess.StartInfo.RedirectStandardOutput = True
        HiddenProcess.StartInfo.RedirectStandardError = True
        HiddenProcess.StartInfo.CreateNoWindow = True
        HiddenProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        HiddenProcess.StartInfo.RedirectStandardInput = False

        HiddenProcess.Start()

        Dim StandardResult = {HiddenProcess.StandardOutput.ReadToEnd, HiddenProcess.StandardError.ReadToEnd}

        Dim RegExpMatchOutput As Match = Regex.Match(StandardResult(0), "(.*): (.*)")
        Dim RegExpMatchError As Match = Regex.Match(StandardResult(1), "(.*): (.*)")

        Dim RegExpMatchOutputSuccess As Boolean = Regex.IsMatch(StandardResult(0), ".*Successful.*")
        Dim RegExpMatchVolumeNormal As Boolean = Regex.IsMatch(StandardResult(0), ".*volume.*")
        Dim RegExpConnected As Boolean = Regex.IsMatch(StandardResult(0), ".*connected.*")

        'Console.WriteLine($"RegExpMatch: {RegExpMatchOutput.Groups(0).Value}")
        'Console.WriteLine($"RegExpMatch: {RegExpMatchOutput.Groups(1).Value}")
        'Console.WriteLine($"RegExpMatch: {RegExpMatchError.Groups(0).Value}")
        'Console.WriteLine($"RegExpMatch: {RegExpMatchError.Groups(1).Value}")

        'If RegExpMatchOutput.Groups(1).Value = "No connection could be made because the target machine actively refused it. (10061)" Then
        '    MsgBox($"Check Address and port... {RegExpMatchOutput.Groups(0).Value} {RegExpMatchOutput.Groups(1).Value}")
        'End If

        Console.WriteLine($"{StandardResult(0)} || {StandardResult(1)}")

        If RegExpMatchOutputSuccess = True Then
            ShortStatusLabel.Text = "Pairing successful."
        ElseIf RegExpConnected = True Then
            ShortStatusLabel.Text = "Connected. Ready."
        Else
            If Not Parameters = "kill-server" And
                RegExpMatchVolumeNormal = False And
                RegExpConnected = False And
                Not StandardResult(0) = "" Then
                ConnectionErrorMsgBox($"Check ADDRESS and PORT... {StandardResult(0)} || {StandardResult(1)}")
            End If

        End If


        Return StandardResult
    End Function


End Class

