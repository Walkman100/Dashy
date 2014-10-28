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
        FileSystemEnCurrentDir.Text = Environment.CurrentDirectory
        FileSystemFsCurrentDir.Text = My.Computer.FileSystem.CurrentDirectory
        FileSystemSysDir.Text = Environment.SystemDirectory
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
        PerformancePagefile.Text = Environment.SystemPageSize
        PerformanceUptime.Text = Environment.TickCount / 1000 'Seconds since startup
        PerformanceMemoryUsedByDashy.Text = Environment.WorkingSet
        ' Clock
        PerformanceClockGMT.Text = My.Computer.Clock.GmtTime
        PerformanceClockLocal.Text = My.Computer.Clock.LocalTime
        PerformanceClockTick.Text = My.Computer.Clock.TickCount
        ' Clipboard
        PerformanceClipboard.Text = "Clipboard Contents:"
        If My.Computer.Clipboard.ContainsAudio Then
            PerformanceClipboard.Text = PerformanceClipboard.Text & vbNewLine & " Audio: Yes"
        Else
            PerformanceClipboard.Text = PerformanceClipboard.Text & vbNewLine & " Audio: No"
        End If
        If My.Computer.Clipboard.ContainsFileDropList Then
            PerformanceClipboard.Text = PerformanceClipboard.Text & vbNewLine & " File Drop List: Yes"
        Else
            PerformanceClipboard.Text = PerformanceClipboard.Text & vbNewLine & " File Drop List: No"
        End If
        If My.Computer.Clipboard.ContainsImage Then
            PerformanceClipboard.Text = PerformanceClipboard.Text & vbNewLine & " Image: Yes"
        Else
            PerformanceClipboard.Text = PerformanceClipboard.Text & vbNewLine & " Image: No"
        End If
        If My.Computer.Clipboard.ContainsText Then
            PerformanceClipboard.Text = PerformanceClipboard.Text & vbNewLine & " Text: Yes"
        Else
            PerformanceClipboard.Text = PerformanceClipboard.Text & vbNewLine & " Text: No"
        End If

        'Hardware:
        HardwareProcessorCount.Text = "Processors: " & Environment.ProcessorCount
        HardwareTotalPhysicalMem.Text = "Total physical memory: " & My.Computer.Info.TotalPhysicalMemory
        HardwareMouseWheel.Text = My.Computer.Mouse.WheelExists
        HardwareScreenBounds.Text = My.Computer.Screen.Bounds.ToString
        HardwareScreenName.Text = My.Computer.Screen.DeviceName
        HardwareScreenPrimary.Text = My.Computer.Screen.Primary

        'System:
        SystemOS.Text = "OS: " & My.Computer.Info.OSFullName
        SystemOSInfoVersion.Text = "OS Version: " & My.Computer.Info.OSVersion
        SystemOSEnvironVersion.Text = Environment.OSVersion.ToString
        SystemOSPlatform.Text = My.Computer.Info.OSPlatform
        If Environment.Is64BitOperatingSystem = True Then
            SystemOSArch.Text = "OS Arch: 64-Bit"
        Else
            SystemOSArch.Text = "OS Arch: 32-Bit"
        End If
        SystemNameEN.Text = Environment.MachineName
        SystemNameComputer.Text = My.Computer.Name
        SystemDomain.Text = Environment.UserDomainName
        SystemLoggedInUser.Text = "Logged in user: " & Environment.UserName
        SystemInteractiveMode.Text = Environment.UserInteractive
        SystemShutdownStarted.Text = Environment.HasShutdownStarted
        SystemDashyArch.Text = Environment.Is64BitProcess
        SystemScrollLines.Text = My.Computer.Mouse.WheelScrollLines
        SystemScreenBitsPerPixel.Text = My.Computer.Screen.BitsPerPixel
        SystemWorkingArea.Text = My.Computer.Screen.WorkingArea.ToString

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

    Private Sub Dashy_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        FileSystemPanel.Size = New Size(PerformancePanel.Location.X - 18, FileSystemPanel.Height)
        SystemPanel.Size = New Size(NetworkPanel.Location.X - SystemPanel.Location.X - 6, SystemPanel.Height)
    End Sub
End Class
