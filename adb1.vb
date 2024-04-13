Public Class FM

    Private Sub ButtonPP_Click(sender As Object, e As EventArgs) Handles ButtonPP.Click
        Shell("adb.exe shell media dispatch play-pause")
    End Sub

    Private Sub FormMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Shell("adb.exe kill-server")
    End Sub
    Private Sub ButtonE_ClickOrTSMIE_Click(sender As Object, e As EventArgs) Handles ButtonE.Click, TSMIE.Click
        Me.Close()
    End Sub

    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles ButtonM.Click
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
        NI.Visible = True
    End Sub
    Private Sub NI_MouseClick(sender As Object, e As MouseEventArgs) Handles NI.MouseClick
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

    Private Sub ButtonRV_Click(sender As Object, e As EventArgs) Handles ButtonRV.Click
        Shell("adb.exe shell media volume --adj raise", , Wait:=True)
        Dim VRPI As New ProcessStartInfo("adb.exe", "shell media volume --get")
        Dim VRP As New Process()
        VRP.StartInfo = VRPI
        VRP.StartInfo.UseShellExecute = False
        VRP.StartInfo.RedirectStandardOutput = True
        VRP.StartInfo.CreateNoWindow = True
        VRP.Start()
        VRP.WaitForExit()

        Dim VRPO As String
        Using VRPOSR As System.IO.StreamReader = VRP.StandardOutput
            VRPO = VRPOSR.ReadToEnd
        End Using
        Dim VRPSS As String = VRPO.Substring(67, 2)
        TextBoxV.Text = VRPSS
    End Sub

    Private Sub ButtonLV_Click(sender As Object, e As EventArgs) Handles ButtonLV.Click
        Shell("adb.exe shell media volume --adj lower", , Wait:=True)
        Dim VRPI As New ProcessStartInfo("adb.exe", "shell media volume --get")
        Dim VRP As New Process()
        VRP.StartInfo = VRPI
        VRP.StartInfo.UseShellExecute = False
        VRP.StartInfo.RedirectStandardOutput = True
        VRP.StartInfo.CreateNoWindow = True
        VRP.Start()
        VRP.WaitForExit()

        Dim VRPO As String
        Using VRPOSR As System.IO.StreamReader = VRP.StandardOutput
            VRPO = VRPOSR.ReadToEnd
        End Using
        Dim VRPSS As String = VRPO.Substring(67, 2)
        TextBoxV.Text = VRPSS
    End Sub

    Private Sub FM_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        Me.StartPosition = StartPosition.Manual
        Dim FileName1 As String = IO.Path.Combine(Application.StartupPath, "adb.exe")
        Dim FileName2 As String = IO.Path.Combine(Application.StartupPath, "AdbWinApi.dll")

        If My.Computer.FileSystem.FileExists(FileName1) Then
            Shell("adb.exe kill-server", AppWinStyle.Hide, Wait:=True)
        End If
        If My.Computer.FileSystem.FileExists(FileName1) Then
        Else
            Dim BytesToWrite1() As Byte = My.Resources.adbexe
            Dim FileStream1 As New System.IO.FileStream(FileName1, System.IO.FileMode.OpenOrCreate)
            Dim BinaryWriter1 As New System.IO.BinaryWriter(FileStream1)
            BinaryWriter1.Write(BytesToWrite1)
            BinaryWriter1.Close()
            FileStream1.Close()
        End If
        If My.Computer.FileSystem.FileExists(FileName2) Then
        Else
            Dim BytesToWrite2() As Byte = My.Resources.AdbWinApidll
            Dim FileStream2 As New System.IO.FileStream(FileName2, System.IO.FileMode.OpenOrCreate)
            Dim BinaryWriter2 As New System.IO.BinaryWriter(FileStream2)
            BinaryWriter2.Write(BytesToWrite2)
            BinaryWriter2.Close()
            FileStream2.Close()
        End If
        Shell("adb.exe connect 10.0.0.27:5555", AppWinStyle.Hide, Wait:=True)

        Dim VRPI As New ProcessStartInfo("adb.exe", "shell media volume --get")
        Dim VRP As New Process()
        VRP.StartInfo = VRPI
        VRP.StartInfo.UseShellExecute = False
        VRP.StartInfo.RedirectStandardOutput = True
        VRP.Start()
        VRP.WaitForExit()

        Dim VRPO As String
        Using VRPOSR As System.IO.StreamReader = VRP.StandardOutput
            VRPO = VRPOSR.ReadToEnd
        End Using
        If My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\.android\adbkey.pub") Then
            My.Computer.FileSystem.DeleteFile(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\.android\adbkey.pub")
        End If
        Try
            Dim VRPSS As String = VRPO.Substring(67, 2)
            TextBoxV.Text = VRPSS
        Catch f As ArgumentOutOfRangeException
            MsgBox("Please double check the device is active, and accepting ADB TCPIP connections on ""10.0.0.27:5555."", then reconnect by clicking on the icon within the application window.")
        End Try
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height - 40)
    End Sub

    Private Sub ButtonSV_Click(sender As Object, e As EventArgs) Handles ButtonSV.Click
        Shell("adb.exe shell media volume --set " & TextBoxV.Text, , Wait:=True)
        Dim VRPI As New ProcessStartInfo("adb.exe", "shell media volume --get")
        Dim VRP As New Process()
        VRP.StartInfo = VRPI
        VRP.StartInfo.UseShellExecute = False
        VRP.StartInfo.RedirectStandardOutput = True
        VRP.StartInfo.CreateNoWindow = True
        VRP.Start()
        VRP.WaitForExit()

        Dim VRPO As String
        Using VRPOSR As System.IO.StreamReader = VRP.StandardOutput
            VRPO = VRPOSR.ReadToEnd
        End Using
        Dim VRPSS As String = VRPO.Substring(67, 2)
        TextBoxV.Text = VRPSS
    End Sub

    Private Sub ButtonP_Click(sender As Object, e As EventArgs) Handles ButtonP.Click
        Shell("adb shell media dispatch previous")
        Shell("adb shell media dispatch previous")
    End Sub

    Private Sub ButtonN_Click(sender As Object, e As EventArgs) Handles ButtonN.Click
        Shell("adb.exe shell media dispatch next")
    End Sub

    Private Sub PBC_Click(sender As Object, e As EventArgs) Handles PBC.Click
        Shell("adb.exe connect 10.0.0.27:5555")
        Dim VRPI As New ProcessStartInfo("adb.exe", "shell media volume --get")
        Dim VRP As New Process()
        VRP.StartInfo = VRPI
        VRP.StartInfo.UseShellExecute = False
        VRP.StartInfo.RedirectStandardOutput = True
        VRP.StartInfo.CreateNoWindow = True
        VRP.Start()
        VRP.WaitForExit()

        Dim VRPO As String
        Using VRPOSR As System.IO.StreamReader = VRP.StandardOutput
            VRPO = VRPOSR.ReadToEnd
        End Using
        Try
            Dim VRPSS As String = VRPO.Substring(67, 2)
            TextBoxV.Text = VRPSS
        Catch f As ArgumentOutOfRangeException
            MsgBox("Please double check the device is active, and accepting ADB TCPIP connections on ""10.0.0.27:5555."", then reconnect by clicking on the icon within the application window.")
        End Try
    End Sub
End Class
