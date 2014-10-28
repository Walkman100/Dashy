Public Class Dashy

    Private Sub Dashy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Once-off info:

        'Hardware:
        If Environment.Is64BitOperatingSystem = True Then
            HardwareArch.Text = "Architecture: 64-Bit"
        Else
            HardwareArch.Text = "Architecture: 32-Bit"
        End If
        HardwareProcessors.Text = "Processors: " & Environment.ProcessorCount

        'System:
        SystemOS.Text = "OS:" & My.Computer.Info.OSFullName
        SystemOSVersion.Text = "OS Version: " & My.Computer.Info.OSVersion
        SystemLoggedInUser.Text = "Logged in user: " & Environment.UserName

        ' Don't wait for timers to tick before adding first info
        TimerMonitorSlow_Tick(Nothing, Nothing)
        TimerMonitorFast_Tick(Nothing, Nothing)
        TimerMonitorSlow.Start()
        TimerMonitorFast.Start()
    End Sub

    Private Sub TimerMonitorSlow_Tick(sender As Object, e As EventArgs) Handles TimerMonitorSlow.Tick
        'FileSystem:
        FileSystemDriveListCbx.Items.Clear()
        For Each drive In My.Computer.FileSystem.Drives
            FileSystemDriveListCbx.Items.Add(drive)
        Next
        FileSystemProgramFilesDirectory.Text = Environment.GetEnvironmentVariable("PROGRAMFILES")
        FileSystemHomePath.Text = Environment.GetEnvironmentVariable("HOMEPATH")

        'Performance:
        PerformanceTotalVirtualMem.Text = "Total virtual memory: " & My.Computer.Info.TotalVirtualMemory
        PerformanceTotalPhysicalMem.Text = "Total physical memory: " & My.Computer.Info.TotalPhysicalMemory
    End Sub

    Private Sub TimerMonitorFast_Tick(sender As Object, e As EventArgs) Handles TimerMonitorFast.Tick
        'FileSystem:
        FileSystemNumberOfDrives.Text = "No. of drives: " & My.Computer.FileSystem.Drives.Count

        'Performance:
        PerformanceAvailVirtualMem.Text = "Available virtual memory: " & My.Computer.Info.AvailableVirtualMemory
        PerformanceAvailPhysicalMem.Text = "Available physical memory: " & My.Computer.Info.AvailablePhysicalMemory

        'Network:    
        If My.Computer.Network.IsAvailable = True Then
            NetworkIsConnected.Text = "Connected to network: Yes"
            Try
                My.Computer.Network.Ping(My.Settings.SiteToPing)
                NetworkInternetConnection.Text = "Internet connection: Yes"
            Catch ex As Exception
                NetworkInternetConnection.Text = "Internet connection: No"
            End Try
        Else
            NetworkIsConnected.Text = "Connected to network: No"
            NetworkInternetConnection.Text = "Internet connection: N/A"
        End If
    End Sub
End Class
