Public Class Dashy

    Private Sub Dashy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerMonitorFast.Start()
        TimerMonitorSlow.Start()

        FastTimerRefreshUnit.SelectedIndex = 2
        SlowTimerRefreshUnit.SelectedIndex = 2
        Me.Width = My.Computer.Screen.WorkingArea.Width
        Me.Location = New Size(0, Me.Location.Y)
    End Sub

    Private Sub TimerMonitorSlow_Tick(sender As Object, e As EventArgs) Handles TimerMonitorSlow.Tick, btnRefresh.Click
        'FileSystem:
        FileSystemProgramFilesDirectory.Text = Environment.GetEnvironmentVariable("PROGRAMFILES")
        FileSystemHomePath.Text = Environment.GetEnvironmentVariable("USERPROFILE")
        FileSystemEnCurrentDir.Text = Environment.CurrentDirectory
        FileSystemFsCurrentDir.Text = My.Computer.FileSystem.CurrentDirectory
        FileSystemSysDir.Text = Environment.SystemDirectory
        FileSystemDriveListFS.Items.Clear()
        For Each drive In My.Computer.FileSystem.Drives
            FileSystemDriveListFS.Items.Add(drive)
        Next
        FileSystemDriveListEN.Items.Clear()
        For Each drive In Environment.GetLogicalDrives
            FileSystemDriveListEN.Items.Add(drive)
        Next
        FileSystemEnvVars.Text = "HOMEDRIVE: " & Environment.GetEnvironmentVariable("HOMEDRIVE") & vbNewLine & _
            "SystemDrive: " & Environment.GetEnvironmentVariable("SystemDrive") & vbNewLine & _
            "ProgramFiles: " & Environment.GetEnvironmentVariable("ProgramFiles") & vbNewLine & _
            "ProgramFiles(x86): " & Environment.GetEnvironmentVariable("ProgramFiles(x86)") & vbNewLine & _
            "ProgramW6432: " & Environment.GetEnvironmentVariable("ProgramW6432") & vbNewLine & _
            "ProgramData: " & Environment.GetEnvironmentVariable("ProgramData") & vbNewLine & _
            "ALLUSERSPROFILE: " & Environment.GetEnvironmentVariable("ALLUSERSPROFILE") & vbNewLine & _
            "CommonProgramFiles: " & Environment.GetEnvironmentVariable("CommonProgramFiles") & vbNewLine & _
            "CommonProgramFiles(x86): " & Environment.GetEnvironmentVariable("CommonProgramFiles(x86)") & vbNewLine & _
            "CommonProgramW6432: " & Environment.GetEnvironmentVariable("CommonProgramW6432") & vbNewLine & _
            "SystemRoot: " & Environment.GetEnvironmentVariable("SystemRoot") & vbNewLine & _
            "windir: " & Environment.GetEnvironmentVariable("windir") & vbNewLine & _
            "ComSpec: " & Environment.GetEnvironmentVariable("ComSpec") & vbNewLine & _
            "PSModulePath: " & Environment.GetEnvironmentVariable("PSModulePath") & vbNewLine & _
            "PUBLIC: " & Environment.GetEnvironmentVariable("PUBLIC") & vbNewLine & _
            "HOMEPATH: " & Environment.GetEnvironmentVariable("HOMEPATH") & vbNewLine & _
            "USERPROFILE: " & Environment.GetEnvironmentVariable("USERPROFILE") & vbNewLine & _
            "APPDATA: " & Environment.GetEnvironmentVariable("APPDATA") & vbNewLine & _
            "LOCALAPPDATA: " & Environment.GetEnvironmentVariable("LOCALAPPDATA") & vbNewLine & _
            "TEMP: " & Environment.GetEnvironmentVariable("TEMP") & vbNewLine & _
            "TMP: " & Environment.GetEnvironmentVariable("TMP") & vbNewLine & _
            "USERDOMAIN: " & Environment.GetEnvironmentVariable("USERDOMAIN") & vbNewLine & _
            "COMPUTERNAME: " & Environment.GetEnvironmentVariable("COMPUTERNAME") & vbNewLine & _
            "LOGONSERVER: " & Environment.GetEnvironmentVariable("LOGONSERVER") & vbNewLine & _
            "USERNAME: " & Environment.GetEnvironmentVariable("USERNAME")

        'Performance:
        PerformanceTotalVirtualMem.Text = "Total virtual memory: " & (My.Computer.Info.TotalVirtualMemory * 1000 \ 1048576) / 1000 & " MB" 'My.Computer.Info.TotalVirtualMemory & " bytes"
        PerformancePagefile.Text = "Pagefile Size: " & Environment.SystemPageSize

        'Hardware:
        HardwareProcessorCount.Text = "Processors: " & Environment.ProcessorCount
        HardwareTotalPhysicalMem.Text = "Total physical memory: " & (My.Computer.Info.TotalPhysicalMemory * 1000 \ 1048576) / 1000 & " MB" 'My.Computer.Info.TotalPhysicalMemory & " bytes"
        If My.Computer.Mouse.WheelExists Then
            HardwareMouseWheel.Text = "Mouse Wheel: Exists"
        Else
            HardwareMouseWheel.Text = "Mouse Wheel: Doesn't exist"
        End If
        HardwareScreenName.Text = "Screen Device Name: " & My.Computer.Screen.DeviceName
        HardwareScreenPrimary.Text = "Primary screen: " & My.Computer.Screen.Primary
        HardwareScreenBounds.Text = "Screen Bounds:" & vbNewLine & My.Computer.Screen.Bounds.ToString

        'System:
        SystemOS.Text = "OS: " & My.Computer.Info.OSFullName
        SystemOSInfoVersion.Text = "OS Version: " & My.Computer.Info.OSVersion
        SystemOSEnvironVersion.Text = "Full OS Name: " & Environment.OSVersion.ToString
        SystemOSPlatform.Text = "OS Platform: " & My.Computer.Info.OSPlatform
        If Environment.Is64BitOperatingSystem Then
            SystemOSArch.Text = "OS Arch: 64-Bit"
        Else
            SystemOSArch.Text = "OS Arch: 32-Bit"
        End If
        SystemNameEN.Text = "ENV.MachineName: " & Environment.MachineName
        SystemNameComputer.Text = "Computer.Name: " & My.Computer.Name
        SystemDomain.Text = "Domain: " & Environment.UserDomainName
        SystemLoggedInUser.Text = "Logged in user: " & Environment.UserName & My.User.Name
        SystemInteractiveMode.Text = "Running in interactive mode: " & Environment.UserInteractive
        SystemShutdownStarted.Text = "Shutdown started: " & Environment.HasShutdownStarted
        If Environment.Is64BitProcess Then
            SystemDashyArch.Text = "Dashy Process Arch: 64-Bit"
        Else
            SystemDashyArch.Text = "Dashy Process Arch: 32-Bit"
        End If
        SystemScrollLines.Text = "Lines to scroll with scroll wheel: " & My.Computer.Mouse.WheelScrollLines
        SystemScreenBitsPerPixel.Text = "Screen Bits per pixel: " & My.Computer.Screen.BitsPerPixel
        SystemWorkingArea.Text = "Screen working area: " & vbNewLine & My.Computer.Screen.WorkingArea.ToString

        'Network:
        If My.Computer.Network.IsAvailable = True Then
            NetworkIsConnected.Text = "Connected to network: Yes"
            NetworkInternetConnection.Text = "Internet connection: Checking..."
            If My.Computer.Network.Ping(My.Settings.SiteToPing) = True Then
                NetworkInternetConnection.Text = "Internet connection: Yes"
            Else
                NetworkInternetConnection.Text = "Internet connection: No"
            End If
        Else
            NetworkIsConnected.Text = "Connected to network: No"
            NetworkInternetConnection.Text = "Internet connection: N/A"
        End If
        NetworkSerialPortNames.Items.Clear()
        For Each PortName In My.Computer.Ports.SerialPortNames
            NetworkSerialPortNames.Items.Add(PortName)
        Next
    End Sub

    Private Sub TimerMonitorFast_Tick(sender As Object, e As EventArgs) Handles TimerMonitorFast.Tick
        'FileSystem
        FileSystemNumberOfDrives.Text = "No. of drives: " & My.Computer.FileSystem.Drives.Count

        'Performance:
        PerformanceAvailPhysicalMem.Text = "Available physical memory: " & (My.Computer.Info.AvailablePhysicalMemory * 1000 \ 1048576) / 1000 & " MB" 'My.Computer.Info.AvailablePhysicalMemory & " bytes"
        PerformanceAvailVirtualMem.Text = "Available virtual memory: " & (My.Computer.Info.AvailableVirtualMemory * 1000 \ 1048576) / 1000 & " MB" 'My.Computer.Info.AvailableVirtualMemory & " bytes"
        PerformanceUptime.Text = "Up-time: " & Environment.TickCount \ 1000 & " Seconds" 'Milliseconds (converted to seconds) since startup
        PerformanceMemoryUsedByDashy.Text = "Physical memory used by Dashy: " & (Environment.WorkingSet * 10 \ 1048576) / 10 & " MB" 'Environment.WorkingSet & " bytes"

        ' Clock
        PerformanceClockGMT.Text = My.Computer.Clock.GmtTime
        PerformanceClockLocal.Text = My.Computer.Clock.LocalTime
        PerformanceClockTick.Text = "Millisecond count: " & My.Computer.Clock.TickCount / 1000 & " (Seconds)"

        ' Clipboard
        PerformanceClipboard.Text = "Clipboard Contents:"
        If My.Computer.Clipboard.ContainsAudio Then
            PerformanceClipboard.Text = PerformanceClipboard.Text & vbNewLine & " Audio"
        End If
        If My.Computer.Clipboard.ContainsFileDropList Then
            PerformanceClipboard.Text = PerformanceClipboard.Text & vbNewLine & " File Drop List"
        End If
        If My.Computer.Clipboard.ContainsImage Then
            PerformanceClipboard.Text = PerformanceClipboard.Text & vbNewLine & " Image"
        End If
        If My.Computer.Clipboard.ContainsText Then
            PerformanceClipboard.Text = PerformanceClipboard.Text & vbNewLine & " Text"
        End If

        'Network:
        If My.Computer.Network.IsAvailable = True Then
            If NetworkIsConnected.Text = "Connected to network: No" Then
                NetworkInternetConnection.Text = "Internet connection: Waiting for SlowTimer..."
            End If
            NetworkIsConnected.Text = "Connected to network: Yes"
        Else
            NetworkIsConnected.Text = "Connected to network: No"
            NetworkInternetConnection.Text = "Internet connection: N/A"
        End If
    End Sub

    Private Sub Dashy_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        FileSystemPanel.Size = New Size(PerformancePanel.Location.X - 18, FileSystemPanel.Height)
        SystemPanel.Size = New Size(NetworkPanel.Location.X - SystemPanel.Location.X - 6, SystemPanel.Height)
    End Sub

    Private Sub FastTimer_SetTick(sender As Object, e As EventArgs) Handles FastTimerRefreshValue.TextChanged, FastTimerRefreshUnit.TextChanged
        Select Case FastTimerRefreshUnit.SelectedIndex
            Case 0 'Milliseconds
                TimerMonitorFast.Interval = FastTimerRefreshValue.Text
            Case 1 'Centiseconds
                TimerMonitorFast.Interval = FastTimerRefreshValue.Text * 10
            Case 2 'Seconds
                TimerMonitorFast.Interval = FastTimerRefreshValue.Text * 1000
            Case 3 'Minutes
                TimerMonitorFast.Interval = FastTimerRefreshValue.Text * 60000
            Case 4 'Hours
                TimerMonitorFast.Interval = FastTimerRefreshValue.Text * 3600000
        End Select
    End Sub

    Private Sub SlowTimer_SetTick(sender As Object, e As EventArgs) Handles SlowTimerRefreshValue.TextChanged, SlowTimerRefreshUnit.TextChanged
        Select Case SlowTimerRefreshUnit.SelectedIndex
            Case 0 'Milliseconds
                TimerMonitorSlow.Interval = SlowTimerRefreshValue.Text
            Case 1 'Centiseconds
                TimerMonitorSlow.Interval = SlowTimerRefreshValue.Text * 10
            Case 2 'Seconds
                TimerMonitorSlow.Interval = SlowTimerRefreshValue.Text * 1000
            Case 3 'Minutes
                TimerMonitorSlow.Interval = SlowTimerRefreshValue.Text * 60000
            Case 4 'Hours
                TimerMonitorSlow.Interval = SlowTimerRefreshValue.Text * 3600000
        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
