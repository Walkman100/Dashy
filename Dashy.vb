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
        End If
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
        EnvVars.Text = "HOMEDRIVE: " & GetVar("HOMEDRIVE") & vbNewLine &
            "SystemDrive: " & GetVar("SystemDrive") & vbNewLine &
            "ProgramFiles: " & GetVar("ProgramFiles") & vbNewLine &
            "ProgramFiles(x86): " & GetVar("ProgramFiles(x86)") & vbNewLine &
            "ProgramW6432: " & GetVar("ProgramW6432") & vbNewLine &
            "ProgramData: " & GetVar("ProgramData") & vbNewLine &
            "ALLUSERSPROFILE: " & GetVar("ALLUSERSPROFILE") & vbNewLine &
            "CommonProgramFiles: " & GetVar("CommonProgramFiles") & vbNewLine &
            "CommonProgramFiles(x86): " & GetVar("CommonProgramFiles(x86)") & vbNewLine &
            "CommonProgramW6432: " & GetVar("CommonProgramW6432") & vbNewLine &
            "SystemRoot: " & GetVar("SystemRoot") & vbNewLine &
            "windir: " & GetVar("windir") & vbNewLine &
            "ComSpec: " & GetVar("ComSpec") & vbNewLine &
            "PSModulePath: " & GetVar("PSModulePath") & vbNewLine &
            "PUBLIC: " & GetVar("PUBLIC") & vbNewLine &
            "HOMEPATH: " & GetVar("HOMEPATH") & vbNewLine &
            "USERPROFILE: " & GetVar("USERPROFILE") & vbNewLine &
            "APPDATA: " & GetVar("APPDATA") & vbNewLine &
            "LOCALAPPDATA: " & GetVar("LOCALAPPDATA") & vbNewLine &
            "TEMP: " & GetVar("TEMP") & vbNewLine &
            "TMP: " & GetVar("TMP") & vbNewLine &
            "USERDOMAIN: " & GetVar("USERDOMAIN") & vbNewLine &
            "COMPUTERNAME: " & GetVar("COMPUTERNAME") & vbNewLine &
            "LOGONSERVER: " & GetVar("LOGONSERVER") & vbNewLine &
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
        HardwareScreenBounds.Text = "Screen Bounds:" & vbNewLine &  My.Computer.Screen.Bounds.ToString

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
            NetworkIPAddrPublic.Text = "Public IP Address: " & GetPublicIP()
        Else
            NetworkIsConnected.Text = "Connected to network: No"
            NetworkInternetConnection.Text = "Internet connection: N/A"
            NetworkIPAddrPublic.Text = "Public IP Address: N/A"
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

        lblWindowSize.Text = "Dashy Window Size:" & vbNewLine & Me.Size.ToString

        'Network:
        If My.Computer.Network.IsAvailable = True Then
            If NetworkIsConnected.Text = "Connected to network: No" Then
                NetworkInternetConnection.Text = "Internet connection: Waiting for SlowTimer..."
                NetworkIPAddrPublic.Text = "Public IP Address: Waiting for SlowTimer..."
            End If
            NetworkIsConnected.Text = "Connected to network: Yes"
        Else
            NetworkIsConnected.Text = "Connected to network: No"
            NetworkInternetConnection.Text = "Internet connection: N/A"
            NetworkIPAddrPublic.Text = "Public IP Address: N/A"
        End If
    End Sub

    Private Sub Dashy_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        FileSystemPanel.Size = New Size(PerformancePanel.Location.X - 18, FileSystemPanel.Height)
        SystemPanel.Size = New Size(NetworkPanel.Location.X - SystemPanel.Location.X - 6, SystemPanel.Height)
    End Sub

    Private Sub FastTimer_SetTick() Handles FastTimerRefreshValue.TextChanged, FastTimerRefreshUnit.TextChanged
        Select Case FastTimerRefreshUnit.SelectedIndex
            Case 0 'Milliseconds
                FastTimer.Interval = FastTimerRefreshValue.Value
            Case 1 'Centiseconds
                FastTimer.Interval = FastTimerRefreshValue.Value * 10
            Case 2 'Seconds
                FastTimer.Interval = FastTimerRefreshValue.Value * 1000
            Case 3 'Minutes
                FastTimer.Interval = FastTimerRefreshValue.Value * 60000
            Case 4 'Hours
                FastTimer.Interval = FastTimerRefreshValue.Value * 3600000
        End Select
    End Sub

    Private Sub SlowTimer_SetTick() Handles SlowTimerRefreshValue.TextChanged, SlowTimerRefreshUnit.TextChanged
        Select Case SlowTimerRefreshUnit.SelectedIndex
            Case 0 'Milliseconds
                SlowTimer.Interval = SlowTimerRefreshValue.Value
            Case 1 'Centiseconds
                SlowTimer.Interval = SlowTimerRefreshValue.Value * 10
            Case 2 'Seconds
                SlowTimer.Interval = SlowTimerRefreshValue.Value * 1000
            Case 3 'Minutes
                SlowTimer.Interval = SlowTimerRefreshValue.Value * 60000
            Case 4 'Hours
                SlowTimer.Interval = SlowTimerRefreshValue.Value * 3600000
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

    Private Sub btnExpand_RightClick(sender As Object, e As MouseEventArgs) Handles btnExpand.MouseUp
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            If btnExpand.Text = "Expand" Then
                Me.Height = 925
                Me.Location = New Size(Me.Location.X, My.Computer.Screen.WorkingArea.Height / 2 - 462.5) ' 462.5 is current height/2
                btnExpand.Text = "Collapse"
            Else
                Me.Height = 459
                Me.Location = New Size(Me.Location.X, My.Computer.Screen.WorkingArea.Height / 2 - 229.5) ' 229.5 is current height/2
                btnExpand.Text = "Expand"
            End If
        End If
    End Sub

    Public Function GetVar(EnvVar As String)
        If Environment.GetEnvironmentVariable("OS") = "Windows_NT" Or chkAllowVars.Checked Then
            Try
                If Environment.GetEnvironmentVariable(EnvVar) <> "" Then
                    Return Environment.GetEnvironmentVariable(EnvVar)
                Else
                    Return "Variable '" & EnvVar & "' is empty!"
                End If
            Catch ex As Exception
                Return "Error getting variable '" & EnvVar & "': " & ex.Message
            End Try
        Else
            Return "Variables disabled"
        End If
    End Function

    Function GetPublicIP() As String
        '  Thanks to https://stackoverflow.com/a/16642279/2999220
        '  (Modified with help of https://stackoverflow.com/a/16369288/2999220)
        Dim request As Net.HttpWebRequest = Net.WebRequest.Create("http://ipecho.net/plain")
        Try
            Using response As Net.HttpWebResponse = request.GetResponse()
                If response.StatusCode = Net.HttpStatusCode.OK Then
                    Using receiveStream As IO.Stream = response.GetResponseStream()
                        If response.CharacterSet Is Nothing Then
                            Using readStream As IO.StreamReader = New IO.StreamReader(receiveStream)
                                Return readStream.ReadToEnd()
                            End Using
                        Else
                            Using readStream As IO.StreamReader = New IO.StreamReader(receiveStream, System.Text.Encoding.GetEncoding(response.CharacterSet))
                                Return readStream.ReadToEnd()
                            End Using
                        End If
                    End Using
                Else
                    Return response.StatusCode
                End If
            End Using
        Catch ex As Net.WebException
            Return ex.Message
        End Try
    End Function

    Private Sub btnStartTimers_Click(sender As Object, e As EventArgs) Handles btnStartTimers.Click
        FastTimer.Start()
        SlowTimer.Start()
        SlowTimer.Interval = 5
        btnStartTimers.Enabled = False
    End Sub
End Class
