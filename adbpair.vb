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

    End Sub
End Class