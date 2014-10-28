Public Class Dashy

    Private Sub Monitor_Performance_Tick(sender As Object, e As EventArgs) Handles Monitor_Performance.Tick
        PerformanceAvailVirtualMem.Text = "Available virtual memory: " & My.Computer.Info.AvailableVirtualMemory
        PerformanceAvailPhysicalMem.Text = "Available physical memory: " & My.Computer.Info.AvailablePhysicalMemory
    End Sub

    Private Sub Dashy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Dashy_UI_HideOnStartup = True Then Me.Visible = False
        GetStaticData()
        Monitor_FileSystem.Start()
        Monitor_Performance.Start()
        Monitor_Network.Start()
    End Sub

    Sub GetStaticData()
        'FileSystem
        For Each drive In My.Computer.FileSystem.Drives
            FileSystemDriveListCbx.Items.Add(drive)
        Next
        FileSystemProgramFilesDirectory.Text = Environment.GetEnvironmentVariable("PROGRAMFILES")
        FileSystemHomePath.Text = Environment.GetEnvironmentVariable("HOMEPATH")
        'Performance
        PerformanceTotalVirtualMem.Text = "Total virtual memory: " & My.Computer.Info.TotalVirtualMemory
        PerformanceTotalPhysicalMem.Text = "Total physical memory: " & My.Computer.Info.TotalPhysicalMemory
        'Hardware
        If Environment.Is64BitOperatingSystem = True Then
            HardwareArch.Text = "Architecture: 64-Bit"
        Else
            HardwareArch.Text = "Architecture: 32-Bit"
        End If
        HardwareProcessors.Text = "Processors: " & Environment.ProcessorCount
        'System
        SystemOS.Text = "OS:" & My.Computer.Info.OSFullName
        SystemOSVersion.Text = "OS Version: " & My.Computer.Info.OSVersion
        SystemLoggedInUser.Text = "Logged in user: " & Environment.UserName
    End Sub

    Private Sub Monitor_FileSystem_Tick(sender As Object, e As EventArgs) Handles Monitor_FileSystem.Tick
        FileSystemNumberOfDrives.Text = "No. of drives: " & My.Computer.FileSystem.Drives.Count
    End Sub

    Private Sub Monitor_Network_Tick(sender As Object, e As EventArgs) Handles Monitor_Network.Tick
        If My.Computer.Network.IsAvailable = True Then
            NetworkIsConnected.Text = "Connected to network: Yes"
        Else
            NetworkIsConnected.Text = "Connected to network: No"
        End If
        Try
            My.Computer.Network.Ping(My.Settings.Dashy_SiteToPing)
            NetworkInternetConnection.Text = "Internet connection: Yes"
        Catch ex As Exception
            NetworkInternetConnection.Text = "Internet connection: No"
        End Try
    End Sub
End Class
