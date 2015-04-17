Public Class Dashy

    Private Sub Dashy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FastTimerRefreshUnit.SelectedIndex = 2
        SlowTimerRefreshUnit.SelectedIndex = 2
        If Environment.GetEnvironmentVariable("OS") = "Windows_NT" Then
            FastTimer.Start()
            SlowTimer.Start()
            
            SlowTimer.Interval = 5
            chkAllowVars.Checked = True
            Me.Width = My.Computer.Screen.WorkingArea.Width
            Me.Location = New Size(0, Me.Location.Y)
        Else
            chkAllowVars.Visible = True
            btnStartTimers.Visible = True
        End if
    End Sub

    Private Sub SlowTimer_Tick(sender As Object, e As EventArgs) Handles SlowTimer.Tick, btnRefresh.Click
        SlowTimer_SetTick()
        'FileSystem:
        FileSystemProgramFilesDirectory.Text = GetVar("PROGRAMFILES")
        FileSystemHomePath.Text = GetVar("USERPROFILE")
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
        EnvVars.Text = "HOMEDRIVE: " & GetVar("HOMEDRIVE") & vbNewLine & _
            "SystemDrive: " & GetVar("SystemDrive") & vbNewLine & _
            "ProgramFiles: " & GetVar("ProgramFiles") & vbNewLine & _
            "ProgramFiles(x86): " & GetVar("ProgramFiles(x86)") & vbNewLine & _
            "ProgramW6432: " & GetVar("ProgramW6432") & vbNewLine & _
            "ProgramData: " & GetVar("ProgramData") & vbNewLine & _
            "ALLUSERSPROFILE: " & GetVar("ALLUSERSPROFILE") & vbNewLine & _
            "CommonProgramFiles: " & GetVar("CommonProgramFiles") & vbNewLine & _
            "CommonProgramFiles(x86): " & GetVar("CommonProgramFiles(x86)") & vbNewLine & _
            "CommonProgramW6432: " & GetVar("CommonProgramW6432") & vbNewLine & _
            "SystemRoot: " & GetVar("SystemRoot") & vbNewLine & _
            "windir: " & GetVar("windir") & vbNewLine & _
            "ComSpec: " & GetVar("ComSpec") & vbNewLine & _
            "PSModulePath: " & GetVar("PSModulePath") & vbNewLine & _
            "PUBLIC: " & GetVar("PUBLIC") & vbNewLine & _
            "HOMEPATH: " & GetVar("HOMEPATH") & vbNewLine & _
            "USERPROFILE: " & GetVar("USERPROFILE") & vbNewLine & _
            "APPDATA: " & GetVar("APPDATA") & vbNewLine & _
            "LOCALAPPDATA: " & GetVar("LOCALAPPDATA") & vbNewLine & _
            "TEMP: " & GetVar("TEMP") & vbNewLine & _
            "TMP: " & GetVar("TMP") & vbNewLine & _
            "USERDOMAIN: " & GetVar("USERDOMAIN") & vbNewLine & _
            "COMPUTERNAME: " & GetVar("COMPUTERNAME") & vbNewLine & _
            "LOGONSERVER: " & GetVar("LOGONSERVER") & vbNewLine & _
            "USERNAME: " & GetVar("USERNAME")

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
        SystemLoggedInUser.Text = "Logged in user: " & Environment.UserName
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

    Private Sub FastTimer_Tick(sender As Object, e As EventArgs) Handles FastTimer.Tick
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

    Private Sub FastTimer_SetTick() Handles FastTimerRefreshValue.TextChanged, FastTimerRefreshUnit.TextChanged
        Select Case FastTimerRefreshUnit.SelectedIndex
            Case 0 'Milliseconds
                FastTimer.Interval = FastTimerRefreshValue.Text
            Case 1 'Centiseconds
                FastTimer.Interval = FastTimerRefreshValue.Text * 10
            Case 2 'Seconds
                FastTimer.Interval = FastTimerRefreshValue.Text * 1000
            Case 3 'Minutes
                FastTimer.Interval = FastTimerRefreshValue.Text * 60000
            Case 4 'Hours
                FastTimer.Interval = FastTimerRefreshValue.Text * 3600000
        End Select
    End Sub

    Private Sub SlowTimer_SetTick() Handles SlowTimerRefreshValue.TextChanged, SlowTimerRefreshUnit.TextChanged
        Select Case SlowTimerRefreshUnit.SelectedIndex
            Case 0 'Milliseconds
                SlowTimer.Interval = SlowTimerRefreshValue.Text
            Case 1 'Centiseconds
                SlowTimer.Interval = SlowTimerRefreshValue.Text * 10
            Case 2 'Seconds
                SlowTimer.Interval = SlowTimerRefreshValue.Text * 1000
            Case 3 'Minutes
                SlowTimer.Interval = SlowTimerRefreshValue.Text * 60000
            Case 4 'Hours
                SlowTimer.Interval = SlowTimerRefreshValue.Text * 3600000
        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnExpand_Click(sender As Object, e As EventArgs) Handles btnExpand.Click
        If btnExpand.Text = "Expand" Then
            Me.Height = 925
            btnExpand.Text = "Collapse"
        Else
            Me.Height = 459
            btnExpand.Text = "Expand"
        End If
    End Sub

    Public Function GetVar(EnvVar as string)
      If Environment.GetEnvironmentVariable("OS") = "Windows_NT" or chkAllowVars.Checked Then
        Try
            If Environment.GetEnvironmentVariable(EnvVar) <> "" Then
                Return Environment.GetEnvironmentVariable(EnvVar)
            Else
                Return "Variable is empty!"
            End If
        Catch ex As Exception
            Return "Error getting variable: " & ex.Message
        End Try
      else
        return "Variables disabled"
      End if
    End Function
    
    Private Sub btnStartTimers_Click(sender As Object, e As EventArgs) Handles btnStartTimers.Click
        FastTimer.Start()
        SlowTimer.Start()
        SlowTimer.Interval = 5
        btnStartTimers.Enabled = False
    End Sub
End Class
