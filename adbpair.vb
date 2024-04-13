Public Class adbpair

    Private Sub adbpair_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'positioning
        Me.StartPosition = StartPosition.Manual
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height - 190)

    End Sub

    Private Sub LinkLabelReadme_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelReadme.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/moefingers/windows-wifi-adb-gui/blob/shepherd/README.md")
    End Sub

    Private Sub ButtonPair_Click(sender As Object, e As EventArgs) Handles ButtonPair.Click
        If Len(TextBoxPairCode.Text) = 6 And Len(TextBoxPairAddress.Text) > 8 Then
            FM.ExecuteHiddenProcess("adb.exe", $"pair {TextBoxPairAddress.Text} {TextBoxPairCode.Text}")
        Else
        End If

    End Sub

    Private Sub ButtonPair_MouseDown(sender As Object, e As MouseEventArgs) Handles ButtonPair.MouseDown
        ButtonPair.BackColor = Color.Red
        ButtonPair.Text = "WAIT."
    End Sub

    Private Sub ButtonPair_MouseUp(sender As Object, e As MouseEventArgs) Handles ButtonPair.MouseUp
        ButtonPair.BackColor = Color.Transparent
        ButtonPair.Text = "Attempt Pairing"
    End Sub
End Class