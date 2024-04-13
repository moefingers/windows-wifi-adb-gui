Imports System.IO
Imports System.Xml

Public Class FM

    Private Sub ButtonPP_Click(sender As Object, e As EventArgs) Handles ButtonPP.Click
        Shell("adb.exe shell media dispatch play-pause")
    End Sub

    Private Sub FormMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Shell("adb.exe kill-server")
    End Sub
    Private Sub ButtonE_ClickOrTSMIE_Click(sender As Object, e As EventArgs) Handles ButtonE.Click, TSMIE.Click
        Application.Exit()

    End Sub

    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles ButtonM.Click
        Me.WindowState = FormWindowState.Minimized
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
        Shell("adb.exe kill-server", AppWinStyle.Hide, Wait:=True)


        ' check if configtxt exists and write one if it doesn't with default being my local working address/port
        If My.Computer.FileSystem.FileExists(configTxtPath) Then
            Console.WriteLine("config.txt exists")
            Dim configReader = My.Computer.FileSystem.OpenTextFileReader(configTxtPath)
            Dim configLine1 As String = configReader.ReadLine()
            configReader.Close()
            Console.WriteLine($"The first line of {configTxtPath} is {configLine1}")
            TextBoxAddress.Text = configLine1
        Else
            ' create file
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

    Private Sub ButtonRV_Click(sender As Object, e As EventArgs) Handles ButtonRV.Click
        'raise volume for connected device
        Shell("adb.exe shell media volume --adj raise", , Wait:=True)

        'Get and connected device volume and update textbox displaying
        GetConnectedDeviceVolume()
    End Sub

    Private Sub ButtonLV_Click(sender As Object, e As EventArgs) Handles ButtonLV.Click
        'lower volume for connected device
        Shell("adb.exe shell media volume --adj lower", , Wait:=True)

        'Get and connected device volume and update textbox displaying
        GetConnectedDeviceVolume()
    End Sub

    Private Sub ButtonSV_Click(sender As Object, e As EventArgs) Handles ButtonSV.Click
        'Set volume for connected device
        Shell("adb.exe shell media volume --set " & TextBoxV.Text, , Wait:=True)

        'Get and connected device volume and update textbox displaying
        GetConnectedDeviceVolume()
    End Sub

    Private Sub ButtonP_Click(sender As Object, e As EventArgs) Handles ButtonP.Click
        'Double execution media previous because the first previous returns to beginning of song
        Shell("adb shell media dispatch previous")
        Shell("adb shell media dispatch previous")
    End Sub

    Private Sub ButtonN_Click(sender As Object, e As EventArgs) Handles ButtonN.Click
        ' Executes media forward
        Shell("adb.exe shell media dispatch next")
    End Sub

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
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

    Private Sub ButtonPair_Click(sender As Object, e As EventArgs) Handles ButtonPair.Click
        If Application.OpenForms.OfType(Of Form).Contains(adbpair) Then
            ButtonPair.Text = "Pair"
            adbpair.Close()
        Else
            ButtonPair.Text = "Cancel Pairing"
            adbpair.Show()
        End If

    End Sub

    Public Sub Connect()
        Console.WriteLine($"Attempting connection to {TextBoxAddress.Text}")
        Console.WriteLine($"adb.exe connect {TextBoxAddress.Text}")
        Shell($"adb.exe connect {TextBoxAddress.Text}", AppWinStyle.Hide, Wait:=True)

        'Get and connected device volume and update textbox displaying
        GetConnectedDeviceVolume()
    End Sub

    Private Async Function GetConnectedDeviceVolume() As Task
        ' get volume  process
        Dim GetVolumeProcess As New Process()
        GetVolumeProcess.StartInfo = New ProcessStartInfo("adb.exe", "shell media volume --get")
        GetVolumeProcess.StartInfo.UseShellExecute = False
        GetVolumeProcess.StartInfo.RedirectStandardOutput = True
        GetVolumeProcess.StartInfo.RedirectStandardError = True

        'GetVolumeProcess.StartInfo.CreateNoWindow = True 
        ' Haven't found a difference on the above line... 
        GetVolumeProcess.Start()
        ProgressBar.Visible = True
        ProgressBar.Value = 50


        Console.WriteLine("adb.exe shell media volume --get")
        Console.WriteLine("output if any:" + GetVolumeProcess.StandardOutput.ReadToEnd)
        Console.WriteLine("error if any:" + GetVolumeProcess.StandardError.ReadToEnd)
        ' Recognized error list:
        ' "error: no devices/emulators found"

        ' read output
        Dim VolumeProcessOutput As String
        Using GetVolumeOutputStreamReader As System.IO.StreamReader = GetVolumeProcess.StandardOutput
            VolumeProcessOutput = GetVolumeOutputStreamReader.ReadToEnd
        End Using


        ' set volume in textbox for viewing
        Try
            Dim GetVolumeProcessSS As String = VolumeProcessOutput.Substring(67, 2)
            MsgBox(GetVolumeProcessSS)
            TextBoxV.Text = GetVolumeProcessSS
        Catch f As ArgumentOutOfRangeException
            ConnectionErrorMsgBox()
        End Try

    End Function


    'error details stuff
    Private Sub ConnectionErrorMsgBox()
        ErrorDetailsLabel.Visible = True
    End Sub

    Private Sub ErrorDetailsLabel_Click(sender As Object, e As EventArgs) Handles ErrorDetailsLabel.Click
        MsgBox($"Please double check the device is active, and accepting ADB TCPIP connections on {TextBoxAddress.Text}, then try to connect again.")
        ErrorDetailsLabel.Visible = False
    End Sub

    Private Sub ErrorDetailsLabel_Enter(sender As Object, e As EventArgs) Handles ErrorDetailsLabel.MouseEnter
        ErrorDetailsLabel.BackColor = Color.White
        ErrorDetailsLabel.ForeColor = Color.Red
    End Sub
    Private Sub ErrorDetailsLabel_Leave(sender As Object, e As EventArgs) Handles ErrorDetailsLabel.MouseLeave
        ErrorDetailsLabel.BackColor = Color.Red
        ErrorDetailsLabel.ForeColor = Color.White
    End Sub
End Class
