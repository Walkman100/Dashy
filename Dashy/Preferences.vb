Public Class Preferences

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        My.Settings.Dashy_UI_HideOnStartup = CheckBox1.Checked
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        My.Settings.Dashy_INT_DoubleClickCopy = CheckBox9.Checked
    End Sub
End Class