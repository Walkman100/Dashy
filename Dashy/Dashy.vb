Public Class Dashy

    Private Sub QuitDashyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitDashyToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub MinimizeToTrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizeToTrayToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub Monitor_Performance_Tick(sender As Object, e As EventArgs) Handles Monitor_Performance.Tick
        lblavailvirtualmem.Text = "Available virtual memory: " & My.Computer.Info.AvailableVirtualMemory
        lblavailphysicalmem.Text = "Available physical memory: " & My.Computer.Info.AvailablePhysicalMemory
    End Sub

    Private Sub Dashy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetStaticData()
        Monitor_FileSystem.Start()
        Monitor_Performance.Start()
    End Sub

    Sub GetStaticData()
        'FileSystem
        For Each item In My.Computer.FileSystem.Drives
            ComboBox1.Items.Add(item)
        Next
        'Performance
        lbltotalvirtualmem.Text = "Total virtual memory: " & My.Computer.Info.TotalVirtualMemory
        lbltotalphysicalmem.Text = "Total physical memory: " & My.Computer.Info.TotalPhysicalMemory
        'Hardware
        If Environment.Is64BitOperatingSystem = True Then
            lblArch.Text = "Architecture: 64-Bit"
        Else
            lblArch.Text = "Architecture: 32-Bit"
        End If
    End Sub

    Private Sub Monitor_FileSystem_Tick(sender As Object, e As EventArgs) Handles Monitor_FileSystem.Tick
        Label2.Text = "No. of drives: " & My.Computer.FileSystem.Drives.Count
    End Sub
End Class
