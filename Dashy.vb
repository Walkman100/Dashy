Public Class Dashy

    Private Sub Dashy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hardware:
        If Environment.Is64BitOperatingSystem = True Then
            HardwareArch.Text = "Architecture: 64-Bit"
        Else
            HardwareArch.Text = "Architecture: 32-Bit"
        End If
        HardwareProcessors.Text = "Processors: " & Environment.ProcessorCount

        'System:
        SystemOS.Text = "OS: " & My.Computer.Info.OSFullName
        SystemOSVersion.Text = "OS Version: " & My.Computer.Info.OSVersion
        SystemLoggedInUser.Text = "Logged in user: " & Environment.UserName

        TimerMonitorFast.Start()
        TimerMonitorSlow_Tick(Nothing, Nothing)
        TimerMonitorSlow.Start()
    End Sub

    Private Sub TimerMonitorSlow_Tick(sender As Object, e As EventArgs) Handles TimerMonitorSlow.Tick
        'FileSystem:
        FileSystemDriveList.Items.Clear()
        For Each drive In My.Computer.FileSystem.Drives
            FileSystemDriveList.Items.Add(drive)
        Next
        FileSystemProgramFilesDirectory.Text = Environment.GetEnvironmentVariable("PROGRAMFILES")
        FileSystemHomePath.Text = Environment.GetEnvironmentVariable("HOMEPATH")

        'Performance:
        PerformanceTotalVirtualMem.Text = "Total virtual memory: " & My.Computer.Info.TotalVirtualMemory
        PerformanceTotalPhysicalMem.Text = "Total physical memory: " & My.Computer.Info.TotalPhysicalMemory

        'Network:    
        If My.Computer.Network.IsAvailable = True Then
            NetworkIsConnected.Text = "Connected to network: Yes"
            NetworkInternetConnection.Text = "Internet connection: Checking..."
            Try
                My.Computer.Network.Ping(My.Settings.SiteToPing)
                NetworkInternetConnection.Text = "Internet connection: Yes"
            Catch ex As Exception
                NetworkInternetConnection.Text = "Internet connection:" & vbNewLine & ex.ToString
            End Try
        Else
            NetworkIsConnected.Text = "Connected to network: No"
            NetworkInternetConnection.Text = "Internet connection: N/A"
        End If
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
        Else
            NetworkIsConnected.Text = "Connected to network: No"
            NetworkInternetConnection.Text = "Internet connection: N/A"
        End If
    End Sub

    Sub AllAvailableVars()
        ' Environment
        Me.Text = Environment.CurrentDirectory
        Me.Text = Environment.GetEnvironmentVariable("")
        'Me.Text = Environment.GetLogicalDrives 'can't convert an array to a string
        Me.Text = Environment.HasShutdownStarted
        Me.Text = Environment.Is64BitOperatingSystem
        Me.Text = Environment.Is64BitProcess
        Me.Text = Environment.MachineName
        Me.Text = Environment.OSVersion.ToString
        Me.Text = Environment.ProcessorCount
        Me.Text = Environment.StackTrace
        Me.Text = Environment.SystemDirectory
        Me.Text = Environment.SystemPageSize
        Me.Text = Environment.TickCount / 1000 'Seconds since startup
        Me.Text = Environment.UserDomainName
        Me.Text = Environment.UserInteractive
        Me.Text = Environment.WorkingSet
        ' My.Computer.[...]
        Me.Text = My.Computer.FileSystem.CurrentDirectory
        Me.Text = My.Computer.FileSystem.Drives.Count
        Me.Text = My.Computer.Info.AvailablePhysicalMemory
        Me.Text = My.Computer.Info.AvailableVirtualMemory
        Me.Text = My.Computer.Info.OSFullName
        Me.Text = My.Computer.Info.OSPlatform
        Me.Text = My.Computer.Info.OSVersion
        Me.Text = My.Computer.Info.TotalPhysicalMemory
        Me.Text = My.Computer.Info.TotalVirtualMemory
        Me.Text = My.Computer.Network.IsAvailable
        'Me.Text = My.Computer.Clipboard.ContainsWhateverTheHellItDoes
        Me.Text = My.Computer.Clock.GmtTime
        Me.Text = My.Computer.Clock.LocalTime
        Me.Text = My.Computer.Clock.TickCount
        Me.Text = My.Computer.Mouse.WheelExists
        Me.Text = My.Computer.Mouse.WheelScrollLines
        Me.Text = My.Computer.Name
        'Me.Text = My.Computer.Ports.SerialPortNames 'can't convert an array to a string
        Me.Text = My.Computer.Screen.BitsPerPixel
        Me.Text = My.Computer.Screen.Bounds.ToString
        Me.Text = My.Computer.Screen.DeviceName
        Me.Text = My.Computer.Screen.Primary
        Me.Text = My.Computer.Screen.WorkingArea.ToString
    End Sub
End Class
