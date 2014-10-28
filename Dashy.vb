Public Class Dashy

    Private Sub Dashy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListOfAppliedVars()

        TimerMonitorFast.Start()
        TimerMonitorSlow_Tick(Nothing, Nothing)
        TimerMonitorSlow.Start()
    End Sub

    Private Sub TimerMonitorSlow_Tick(sender As Object, e As EventArgs) Handles TimerMonitorSlow.Tick

    End Sub

    Private Sub TimerMonitorFast_Tick(sender As Object, e As EventArgs) Handles TimerMonitorFast.Tick

    End Sub

    Sub ListOfAppliedVars()
        'FileSystem:
        FileSystemProgramFilesDirectory.Text = Environment.GetEnvironmentVariable("PROGRAMFILES")
        FileSystemHomePath.Text = Environment.GetEnvironmentVariable("HOMEPATH")
        Me.Text = Environment.CurrentDirectory
        Me.Text = My.Computer.FileSystem.CurrentDirectory
        Me.Text = Environment.SystemDirectory
        FileSystemNumberOfDrives.Text = "No. of drives: " & My.Computer.FileSystem.Drives.Count
        FileSystemDriveListFS.Items.Clear()
        For Each drive In My.Computer.FileSystem.Drives
            FileSystemDriveListFS.Items.Add(drive)
        Next
        FileSystemDriveListEN.Items.Clear()
        For Each drive In Environment.GetLogicalDrives
            FileSystemDriveListEN.Items.Add(drive)
        Next

        'Performance:
        PerformanceAvailVirtualMem.Text = "Available virtual memory: " & My.Computer.Info.AvailableVirtualMemory
        PerformanceAvailPhysicalMem.Text = "Available physical memory: " & My.Computer.Info.AvailablePhysicalMemory
        PerformanceTotalVirtualMem.Text = "Total virtual memory: " & My.Computer.Info.TotalVirtualMemory
        Me.Text = Environment.SystemPageSize
        Me.Text = Environment.TickCount / 1000 'Seconds since startup
        Me.Text = Environment.WorkingSet
        ' Clock
        Me.Text = My.Computer.Clock.GmtTime
        Me.Text = My.Computer.Clock.LocalTime
        Me.Text = My.Computer.Clock.TickCount
        ' Clipboard
        'Me.Text = My.Computer.Clipboard.ContainsWhateverTheHellItDoes
        
        'Hardware:
        HardwareProcessorCount.Text = "Processors: " & Environment.ProcessorCount
        HardwareTotalPhysicalMem.Text = "Total physical memory: " & My.Computer.Info.TotalPhysicalMemory
        Me.Text = My.Computer.Mouse.WheelExists
        Me.Text = My.Computer.Screen.Bounds.ToString
        Me.Text = My.Computer.Screen.DeviceName
        Me.Text = My.Computer.Screen.Primary

        'System:
        SystemOS.Text = "OS: " & My.Computer.Info.OSFullName
        SystemOSInfoVersion.Text = "OS Version: " & My.Computer.Info.OSVersion
        Me.Text = Environment.OSVersion.ToString
        Me.Text = My.Computer.Info.OSPlatform
        If Environment.Is64BitOperatingSystem = True Then
            SystemOSArch.Text = "Architecture: 64-Bit"
        Else
            SystemOSArch.Text = "Architecture: 32-Bit"
        End If
        Me.Text = Environment.MachineName
        Me.Text = My.Computer.Name
        Me.Text = Environment.UserDomainName
        SystemLoggedInUser.Text = "Logged in user: " & Environment.UserName
        Me.Text = Environment.UserInteractive
        Me.Text = Environment.HasShutdownStarted
        Me.Text = Environment.Is64BitProcess
        Me.Text = My.Computer.Mouse.WheelScrollLines
        Me.Text = My.Computer.Screen.BitsPerPixel
        Me.Text = My.Computer.Screen.WorkingArea.ToString

        'Network:
        If My.Computer.Network.IsAvailable = True Then
            NetworkIsConnected.Text = "Connected to network: Yes"
            NetworkInternetConnection.Text = "Internet connection: Checking..."
            Try
                My.Computer.Network.Ping(My.Settings.SiteToPing)
                NetworkInternetConnection.Text = "Internet connection: Yes"
            Catch ex As Exception
                NetworkInternetConnection.Text = "Internet connection:" & vbNewLine & ex.ToString
                If NetworkSplitContainer.SplitterDistance = 121 Then
                    NetworkSplitContainer.SplitterDistance = 160
                End If
            End Try
        Else
            NetworkIsConnected.Text = "Connected to network: No"
            NetworkInternetConnection.Text = "Internet connection: N/A"
        End If
        For Each PortName In My.Computer.Ports.SerialPortNames
            NetworkSerialPortNames.Items.Add(PortName)
        Next
    End Sub
End Class
