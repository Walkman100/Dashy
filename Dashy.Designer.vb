<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashy
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashy))
        Me.FileSystemPanel = New System.Windows.Forms.Panel()
        Me.FileSystemDrivesTabControl = New System.Windows.Forms.TabControl()
        Me.FileSystemDrivesTabFS = New System.Windows.Forms.TabPage()
        Me.FileSystemDriveListFS = New System.Windows.Forms.ListBox()
        Me.FileSystemDrivesTabEN = New System.Windows.Forms.TabPage()
        Me.FileSystemDriveListEN = New System.Windows.Forms.ListBox()
        Me.FileSystemFsCurrentDir = New System.Windows.Forms.Label()
        Me.FileSystemFsCurrentDirLBL = New System.Windows.Forms.Label()
        Me.FileSystemSysDir = New System.Windows.Forms.Label()
        Me.FileSystemSysDirLBL = New System.Windows.Forms.Label()
        Me.FileSystemEnCurrentDir = New System.Windows.Forms.Label()
        Me.FileSystemEnCurrentDirLBL = New System.Windows.Forms.Label()
        Me.FileSystemHomePath = New System.Windows.Forms.Label()
        Me.FileSystemHomePathLBL = New System.Windows.Forms.Label()
        Me.FileSystemProgramFilesDirectory = New System.Windows.Forms.Label()
        Me.FileSystemProgramFilesDirectoryLBL = New System.Windows.Forms.Label()
        Me.FileSystemNumberOfDrives = New System.Windows.Forms.Label()
        Me.FileSystemDriveListLBL = New System.Windows.Forms.Label()
        Me.FileSystemLbl = New System.Windows.Forms.Label()
        Me.FileSystemImg = New System.Windows.Forms.PictureBox()
        Me.PerformancePanel = New System.Windows.Forms.Panel()
        Me.PerformanceClockLocal = New System.Windows.Forms.Label()
        Me.PerformanceClockLocalLBL = New System.Windows.Forms.Label()
        Me.PerformanceClockGMT = New System.Windows.Forms.Label()
        Me.PerformanceClockGMTLBL = New System.Windows.Forms.Label()
        Me.PerformanceClockTick = New System.Windows.Forms.Label()
        Me.PerformanceClipboard = New System.Windows.Forms.Label()
        Me.PerformancePagefile = New System.Windows.Forms.Label()
        Me.PerformanceUptime = New System.Windows.Forms.Label()
        Me.PerformanceMemoryUsedByDashy = New System.Windows.Forms.Label()
        Me.PerformanceTotalVirtualMem = New System.Windows.Forms.Label()
        Me.PerformanceAvailPhysicalMem = New System.Windows.Forms.Label()
        Me.PerformanceAvailVirtualMem = New System.Windows.Forms.Label()
        Me.PerformanceImg = New System.Windows.Forms.PictureBox()
        Me.PerformanceLbl = New System.Windows.Forms.Label()
        Me.HardwareTotalPhysicalMem = New System.Windows.Forms.Label()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutDashyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HardwarePanel = New System.Windows.Forms.Panel()
        Me.HardwareScreenPrimary = New System.Windows.Forms.Label()
        Me.HardwareScreenName = New System.Windows.Forms.Label()
        Me.HardwareScreenBounds = New System.Windows.Forms.Label()
        Me.HardwareMouseWheel = New System.Windows.Forms.Label()
        Me.HardwareProcessorCount = New System.Windows.Forms.Label()
        Me.HardwareImg = New System.Windows.Forms.PictureBox()
        Me.HardwareLbl = New System.Windows.Forms.Label()
        Me.SystemOSArch = New System.Windows.Forms.Label()
        Me.SystemPanel = New System.Windows.Forms.Panel()
        Me.SystemWorkingArea = New System.Windows.Forms.Label()
        Me.SystemScreenBitsPerPixel = New System.Windows.Forms.Label()
        Me.SystemScrollLines = New System.Windows.Forms.Label()
        Me.SystemDashyArch = New System.Windows.Forms.Label()
        Me.SystemShutdownStarted = New System.Windows.Forms.Label()
        Me.SystemInteractiveMode = New System.Windows.Forms.Label()
        Me.SystemDomain = New System.Windows.Forms.Label()
        Me.SystemNameComputer = New System.Windows.Forms.Label()
        Me.SystemNameEN = New System.Windows.Forms.Label()
        Me.SystemOSPlatform = New System.Windows.Forms.Label()
        Me.SystemOSEnvironVersion = New System.Windows.Forms.Label()
        Me.SystemLoggedInUser = New System.Windows.Forms.Label()
        Me.SystemOSInfoVersion = New System.Windows.Forms.Label()
        Me.SystemOS = New System.Windows.Forms.Label()
        Me.SystemImg = New System.Windows.Forms.PictureBox()
        Me.SystemLbl = New System.Windows.Forms.Label()
        Me.NetworkPanel = New System.Windows.Forms.Panel()
        Me.NetworkSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.NetworkImg = New System.Windows.Forms.PictureBox()
        Me.NetworkInternetConnection = New System.Windows.Forms.Label()
        Me.NetworkLbl = New System.Windows.Forms.Label()
        Me.NetworkIsConnected = New System.Windows.Forms.Label()
        Me.NetworkSerialPortNamesLBL = New System.Windows.Forms.Label()
        Me.NetworkSerialPortNames = New System.Windows.Forms.ListBox()
        Me.TimerMonitorFast = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMonitorSlow = New System.Windows.Forms.Timer(Me.components)
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SlowTimerRefreshLabel = New System.Windows.Forms.Label()
        Me.SlowTimerRefreshValue = New System.Windows.Forms.DomainUpDown()
        Me.SlowTimerRefreshUnit = New System.Windows.Forms.ComboBox()
        Me.FastTimerRefreshUnit = New System.Windows.Forms.ComboBox()
        Me.FastTimerRefreshValue = New System.Windows.Forms.DomainUpDown()
        Me.FastTimerRefreshLabel = New System.Windows.Forms.Label()
        Me.FileSystemPanel.SuspendLayout()
        Me.FileSystemDrivesTabControl.SuspendLayout()
        Me.FileSystemDrivesTabFS.SuspendLayout()
        Me.FileSystemDrivesTabEN.SuspendLayout()
        CType(Me.FileSystemImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PerformancePanel.SuspendLayout()
        CType(Me.PerformanceImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HardwarePanel.SuspendLayout()
        CType(Me.HardwareImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SystemPanel.SuspendLayout()
        CType(Me.SystemImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NetworkPanel.SuspendLayout()
        CType(Me.NetworkSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NetworkSplitContainer.Panel1.SuspendLayout()
        Me.NetworkSplitContainer.Panel2.SuspendLayout()
        Me.NetworkSplitContainer.SuspendLayout()
        CType(Me.NetworkImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FileSystemPanel
        '
        Me.FileSystemPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FileSystemPanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.FileSystemPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FileSystemPanel.Controls.Add(Me.FileSystemDrivesTabControl)
        Me.FileSystemPanel.Controls.Add(Me.FileSystemFsCurrentDir)
        Me.FileSystemPanel.Controls.Add(Me.FileSystemFsCurrentDirLBL)
        Me.FileSystemPanel.Controls.Add(Me.FileSystemSysDir)
        Me.FileSystemPanel.Controls.Add(Me.FileSystemSysDirLBL)
        Me.FileSystemPanel.Controls.Add(Me.FileSystemEnCurrentDir)
        Me.FileSystemPanel.Controls.Add(Me.FileSystemEnCurrentDirLBL)
        Me.FileSystemPanel.Controls.Add(Me.FileSystemHomePath)
        Me.FileSystemPanel.Controls.Add(Me.FileSystemHomePathLBL)
        Me.FileSystemPanel.Controls.Add(Me.FileSystemProgramFilesDirectory)
        Me.FileSystemPanel.Controls.Add(Me.FileSystemProgramFilesDirectoryLBL)
        Me.FileSystemPanel.Controls.Add(Me.FileSystemNumberOfDrives)
        Me.FileSystemPanel.Controls.Add(Me.FileSystemDriveListLBL)
        Me.FileSystemPanel.Controls.Add(Me.FileSystemLbl)
        Me.FileSystemPanel.Controls.Add(Me.FileSystemImg)
        Me.FileSystemPanel.Location = New System.Drawing.Point(12, 12)
        Me.FileSystemPanel.Name = "FileSystemPanel"
        Me.FileSystemPanel.Size = New System.Drawing.Size(252, 397)
        Me.FileSystemPanel.TabIndex = 4
        '
        'FileSystemDrivesTabControl
        '
        Me.FileSystemDrivesTabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FileSystemDrivesTabControl.Controls.Add(Me.FileSystemDrivesTabFS)
        Me.FileSystemDrivesTabControl.Controls.Add(Me.FileSystemDrivesTabEN)
        Me.FileSystemDrivesTabControl.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemDrivesTabControl.Location = New System.Drawing.Point(3, 289)
        Me.FileSystemDrivesTabControl.Name = "FileSystemDrivesTabControl"
        Me.FileSystemDrivesTabControl.SelectedIndex = 0
        Me.FileSystemDrivesTabControl.Size = New System.Drawing.Size(244, 103)
        Me.FileSystemDrivesTabControl.TabIndex = 22
        '
        'FileSystemDrivesTabFS
        '
        Me.FileSystemDrivesTabFS.Controls.Add(Me.FileSystemDriveListFS)
        Me.FileSystemDrivesTabFS.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemDrivesTabFS.Location = New System.Drawing.Point(4, 25)
        Me.FileSystemDrivesTabFS.Name = "FileSystemDrivesTabFS"
        Me.FileSystemDrivesTabFS.Padding = New System.Windows.Forms.Padding(3)
        Me.FileSystemDrivesTabFS.Size = New System.Drawing.Size(236, 74)
        Me.FileSystemDrivesTabFS.TabIndex = 0
        Me.FileSystemDrivesTabFS.Text = "FileSystem.Drives"
        Me.FileSystemDrivesTabFS.UseVisualStyleBackColor = True
        '
        'FileSystemDriveListFS
        '
        Me.FileSystemDriveListFS.ColumnWidth = 40
        Me.FileSystemDriveListFS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FileSystemDriveListFS.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemDriveListFS.FormattingEnabled = True
        Me.FileSystemDriveListFS.IntegralHeight = False
        Me.FileSystemDriveListFS.ItemHeight = 16
        Me.FileSystemDriveListFS.Items.AddRange(New Object() {"Checking..."})
        Me.FileSystemDriveListFS.Location = New System.Drawing.Point(3, 3)
        Me.FileSystemDriveListFS.MultiColumn = True
        Me.FileSystemDriveListFS.Name = "FileSystemDriveListFS"
        Me.FileSystemDriveListFS.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.FileSystemDriveListFS.Size = New System.Drawing.Size(230, 68)
        Me.FileSystemDriveListFS.TabIndex = 15
        '
        'FileSystemDrivesTabEN
        '
        Me.FileSystemDrivesTabEN.Controls.Add(Me.FileSystemDriveListEN)
        Me.FileSystemDrivesTabEN.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemDrivesTabEN.Location = New System.Drawing.Point(4, 25)
        Me.FileSystemDrivesTabEN.Name = "FileSystemDrivesTabEN"
        Me.FileSystemDrivesTabEN.Padding = New System.Windows.Forms.Padding(3)
        Me.FileSystemDrivesTabEN.Size = New System.Drawing.Size(236, 74)
        Me.FileSystemDrivesTabEN.TabIndex = 1
        Me.FileSystemDrivesTabEN.Text = "Environment.Drives"
        Me.FileSystemDrivesTabEN.UseVisualStyleBackColor = True
        '
        'FileSystemDriveListEN
        '
        Me.FileSystemDriveListEN.ColumnWidth = 40
        Me.FileSystemDriveListEN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FileSystemDriveListEN.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemDriveListEN.FormattingEnabled = True
        Me.FileSystemDriveListEN.IntegralHeight = False
        Me.FileSystemDriveListEN.ItemHeight = 16
        Me.FileSystemDriveListEN.Items.AddRange(New Object() {"Checking..."})
        Me.FileSystemDriveListEN.Location = New System.Drawing.Point(3, 3)
        Me.FileSystemDriveListEN.MultiColumn = True
        Me.FileSystemDriveListEN.Name = "FileSystemDriveListEN"
        Me.FileSystemDriveListEN.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.FileSystemDriveListEN.Size = New System.Drawing.Size(230, 68)
        Me.FileSystemDriveListEN.TabIndex = 16
        '
        'FileSystemFsCurrentDir
        '
        Me.FileSystemFsCurrentDir.AutoSize = True
        Me.FileSystemFsCurrentDir.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemFsCurrentDir.Location = New System.Drawing.Point(3, 196)
        Me.FileSystemFsCurrentDir.Name = "FileSystemFsCurrentDir"
        Me.FileSystemFsCurrentDir.Size = New System.Drawing.Size(76, 18)
        Me.FileSystemFsCurrentDir.TabIndex = 21
        Me.FileSystemFsCurrentDir.Text = "Checking..."
        '
        'FileSystemFsCurrentDirLBL
        '
        Me.FileSystemFsCurrentDirLBL.AutoSize = True
        Me.FileSystemFsCurrentDirLBL.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemFsCurrentDirLBL.Location = New System.Drawing.Point(3, 178)
        Me.FileSystemFsCurrentDirLBL.Name = "FileSystemFsCurrentDirLBL"
        Me.FileSystemFsCurrentDirLBL.Size = New System.Drawing.Size(133, 18)
        Me.FileSystemFsCurrentDirLBL.TabIndex = 20
        Me.FileSystemFsCurrentDirLBL.Text = "FS.Current Directory:"
        '
        'FileSystemSysDir
        '
        Me.FileSystemSysDir.AutoSize = True
        Me.FileSystemSysDir.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemSysDir.Location = New System.Drawing.Point(3, 232)
        Me.FileSystemSysDir.Name = "FileSystemSysDir"
        Me.FileSystemSysDir.Size = New System.Drawing.Size(76, 18)
        Me.FileSystemSysDir.TabIndex = 19
        Me.FileSystemSysDir.Text = "Checking..."
        '
        'FileSystemSysDirLBL
        '
        Me.FileSystemSysDirLBL.AutoSize = True
        Me.FileSystemSysDirLBL.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemSysDirLBL.Location = New System.Drawing.Point(3, 214)
        Me.FileSystemSysDirLBL.Name = "FileSystemSysDirLBL"
        Me.FileSystemSysDirLBL.Size = New System.Drawing.Size(112, 18)
        Me.FileSystemSysDirLBL.TabIndex = 18
        Me.FileSystemSysDirLBL.Text = "System Directory:"
        '
        'FileSystemEnCurrentDir
        '
        Me.FileSystemEnCurrentDir.AutoSize = True
        Me.FileSystemEnCurrentDir.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemEnCurrentDir.Location = New System.Drawing.Point(3, 160)
        Me.FileSystemEnCurrentDir.Name = "FileSystemEnCurrentDir"
        Me.FileSystemEnCurrentDir.Size = New System.Drawing.Size(76, 18)
        Me.FileSystemEnCurrentDir.TabIndex = 17
        Me.FileSystemEnCurrentDir.Text = "Checking..."
        '
        'FileSystemEnCurrentDirLBL
        '
        Me.FileSystemEnCurrentDirLBL.AutoSize = True
        Me.FileSystemEnCurrentDirLBL.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemEnCurrentDirLBL.Location = New System.Drawing.Point(3, 142)
        Me.FileSystemEnCurrentDirLBL.Name = "FileSystemEnCurrentDirLBL"
        Me.FileSystemEnCurrentDirLBL.Size = New System.Drawing.Size(134, 18)
        Me.FileSystemEnCurrentDirLBL.TabIndex = 16
        Me.FileSystemEnCurrentDirLBL.Text = "EN.Current Directory:"
        '
        'FileSystemHomePath
        '
        Me.FileSystemHomePath.AutoSize = True
        Me.FileSystemHomePath.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemHomePath.Location = New System.Drawing.Point(3, 124)
        Me.FileSystemHomePath.Name = "FileSystemHomePath"
        Me.FileSystemHomePath.Size = New System.Drawing.Size(76, 18)
        Me.FileSystemHomePath.TabIndex = 14
        Me.FileSystemHomePath.Text = "Checking..."
        '
        'FileSystemHomePathLBL
        '
        Me.FileSystemHomePathLBL.AutoSize = True
        Me.FileSystemHomePathLBL.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemHomePathLBL.Location = New System.Drawing.Point(3, 106)
        Me.FileSystemHomePathLBL.Name = "FileSystemHomePathLBL"
        Me.FileSystemHomePathLBL.Size = New System.Drawing.Size(77, 18)
        Me.FileSystemHomePathLBL.TabIndex = 13
        Me.FileSystemHomePathLBL.Text = "Home path:"
        '
        'FileSystemProgramFilesDirectory
        '
        Me.FileSystemProgramFilesDirectory.AutoSize = True
        Me.FileSystemProgramFilesDirectory.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemProgramFilesDirectory.Location = New System.Drawing.Point(3, 88)
        Me.FileSystemProgramFilesDirectory.Name = "FileSystemProgramFilesDirectory"
        Me.FileSystemProgramFilesDirectory.Size = New System.Drawing.Size(76, 18)
        Me.FileSystemProgramFilesDirectory.TabIndex = 12
        Me.FileSystemProgramFilesDirectory.Text = "Checking..."
        '
        'FileSystemProgramFilesDirectoryLBL
        '
        Me.FileSystemProgramFilesDirectoryLBL.AutoSize = True
        Me.FileSystemProgramFilesDirectoryLBL.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemProgramFilesDirectoryLBL.Location = New System.Drawing.Point(3, 70)
        Me.FileSystemProgramFilesDirectoryLBL.Name = "FileSystemProgramFilesDirectoryLBL"
        Me.FileSystemProgramFilesDirectoryLBL.Size = New System.Drawing.Size(149, 18)
        Me.FileSystemProgramFilesDirectoryLBL.TabIndex = 11
        Me.FileSystemProgramFilesDirectoryLBL.Text = "Program Files directory:"
        '
        'FileSystemNumberOfDrives
        '
        Me.FileSystemNumberOfDrives.AutoSize = True
        Me.FileSystemNumberOfDrives.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemNumberOfDrives.Location = New System.Drawing.Point(3, 250)
        Me.FileSystemNumberOfDrives.Name = "FileSystemNumberOfDrives"
        Me.FileSystemNumberOfDrives.Size = New System.Drawing.Size(161, 18)
        Me.FileSystemNumberOfDrives.TabIndex = 10
        Me.FileSystemNumberOfDrives.Text = "No. of drives: Checking..."
        '
        'FileSystemDriveListLBL
        '
        Me.FileSystemDriveListLBL.AutoSize = True
        Me.FileSystemDriveListLBL.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemDriveListLBL.Location = New System.Drawing.Point(3, 268)
        Me.FileSystemDriveListLBL.Name = "FileSystemDriveListLBL"
        Me.FileSystemDriveListLBL.Size = New System.Drawing.Size(91, 18)
        Me.FileSystemDriveListLBL.TabIndex = 8
        Me.FileSystemDriveListLBL.Text = "List of drives:"
        '
        'FileSystemLbl
        '
        Me.FileSystemLbl.AutoSize = True
        Me.FileSystemLbl.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemLbl.Location = New System.Drawing.Point(70, 18)
        Me.FileSystemLbl.Name = "FileSystemLbl"
        Me.FileSystemLbl.Size = New System.Drawing.Size(110, 27)
        Me.FileSystemLbl.TabIndex = 8
        Me.FileSystemLbl.Text = "FileSystem"
        '
        'FileSystemImg
        '
        Me.FileSystemImg.Image = CType(resources.GetObject("FileSystemImg.Image"), System.Drawing.Image)
        Me.FileSystemImg.Location = New System.Drawing.Point(3, 3)
        Me.FileSystemImg.Name = "FileSystemImg"
        Me.FileSystemImg.Size = New System.Drawing.Size(64, 64)
        Me.FileSystemImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FileSystemImg.TabIndex = 2
        Me.FileSystemImg.TabStop = False
        '
        'PerformancePanel
        '
        Me.PerformancePanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.PerformancePanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PerformancePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PerformancePanel.Controls.Add(Me.PerformanceClockLocal)
        Me.PerformancePanel.Controls.Add(Me.PerformanceClockLocalLBL)
        Me.PerformancePanel.Controls.Add(Me.PerformanceClockGMT)
        Me.PerformancePanel.Controls.Add(Me.PerformanceClockGMTLBL)
        Me.PerformancePanel.Controls.Add(Me.PerformanceClockTick)
        Me.PerformancePanel.Controls.Add(Me.PerformanceClipboard)
        Me.PerformancePanel.Controls.Add(Me.PerformancePagefile)
        Me.PerformancePanel.Controls.Add(Me.PerformanceUptime)
        Me.PerformancePanel.Controls.Add(Me.PerformanceMemoryUsedByDashy)
        Me.PerformancePanel.Controls.Add(Me.PerformanceTotalVirtualMem)
        Me.PerformancePanel.Controls.Add(Me.PerformanceAvailPhysicalMem)
        Me.PerformancePanel.Controls.Add(Me.PerformanceAvailVirtualMem)
        Me.PerformancePanel.Controls.Add(Me.PerformanceImg)
        Me.PerformancePanel.Controls.Add(Me.PerformanceLbl)
        Me.PerformancePanel.Location = New System.Drawing.Point(270, 12)
        Me.PerformancePanel.Name = "PerformancePanel"
        Me.PerformancePanel.Size = New System.Drawing.Size(252, 397)
        Me.PerformancePanel.TabIndex = 5
        '
        'PerformanceClockLocal
        '
        Me.PerformanceClockLocal.AutoSize = True
        Me.PerformanceClockLocal.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerformanceClockLocal.Location = New System.Drawing.Point(3, 241)
        Me.PerformanceClockLocal.Name = "PerformanceClockLocal"
        Me.PerformanceClockLocal.Size = New System.Drawing.Size(76, 18)
        Me.PerformanceClockLocal.TabIndex = 20
        Me.PerformanceClockLocal.Text = "Checking..."
        '
        'PerformanceClockLocalLBL
        '
        Me.PerformanceClockLocalLBL.AutoSize = True
        Me.PerformanceClockLocalLBL.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerformanceClockLocalLBL.Location = New System.Drawing.Point(3, 223)
        Me.PerformanceClockLocalLBL.Name = "PerformanceClockLocalLBL"
        Me.PerformanceClockLocalLBL.Size = New System.Drawing.Size(112, 18)
        Me.PerformanceClockLocalLBL.TabIndex = 19
        Me.PerformanceClockLocalLBL.Text = "Clock Local Time:"
        '
        'PerformanceClockGMT
        '
        Me.PerformanceClockGMT.AutoSize = True
        Me.PerformanceClockGMT.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerformanceClockGMT.Location = New System.Drawing.Point(3, 205)
        Me.PerformanceClockGMT.Name = "PerformanceClockGMT"
        Me.PerformanceClockGMT.Size = New System.Drawing.Size(76, 18)
        Me.PerformanceClockGMT.TabIndex = 18
        Me.PerformanceClockGMT.Text = "Checking..."
        '
        'PerformanceClockGMTLBL
        '
        Me.PerformanceClockGMTLBL.AutoSize = True
        Me.PerformanceClockGMTLBL.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerformanceClockGMTLBL.Location = New System.Drawing.Point(3, 187)
        Me.PerformanceClockGMTLBL.Name = "PerformanceClockGMTLBL"
        Me.PerformanceClockGMTLBL.Size = New System.Drawing.Size(109, 18)
        Me.PerformanceClockGMTLBL.TabIndex = 17
        Me.PerformanceClockGMTLBL.Text = "Clock GMT Time:"
        '
        'PerformanceClockTick
        '
        Me.PerformanceClockTick.AutoSize = True
        Me.PerformanceClockTick.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerformanceClockTick.Location = New System.Drawing.Point(3, 259)
        Me.PerformanceClockTick.Name = "PerformanceClockTick"
        Me.PerformanceClockTick.Size = New System.Drawing.Size(185, 18)
        Me.PerformanceClockTick.TabIndex = 13
        Me.PerformanceClockTick.Text = "Millisecond count: Checking..."
        '
        'PerformanceClipboard
        '
        Me.PerformanceClipboard.AutoSize = True
        Me.PerformanceClipboard.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerformanceClipboard.Location = New System.Drawing.Point(3, 286)
        Me.PerformanceClipboard.Name = "PerformanceClipboard"
        Me.PerformanceClipboard.Size = New System.Drawing.Size(196, 18)
        Me.PerformanceClipboard.TabIndex = 10
        Me.PerformanceClipboard.Text = "Clipboard Contents: Checking..."
        '
        'PerformancePagefile
        '
        Me.PerformancePagefile.AutoSize = True
        Me.PerformancePagefile.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerformancePagefile.Location = New System.Drawing.Point(3, 124)
        Me.PerformancePagefile.Name = "PerformancePagefile"
        Me.PerformancePagefile.Size = New System.Drawing.Size(160, 18)
        Me.PerformancePagefile.TabIndex = 9
        Me.PerformancePagefile.Text = "Pagefile Size: Checking..."
        '
        'PerformanceUptime
        '
        Me.PerformanceUptime.AutoSize = True
        Me.PerformanceUptime.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerformanceUptime.Location = New System.Drawing.Point(3, 142)
        Me.PerformanceUptime.Name = "PerformanceUptime"
        Me.PerformanceUptime.Size = New System.Drawing.Size(132, 18)
        Me.PerformanceUptime.TabIndex = 8
        Me.PerformanceUptime.Text = "Up-time: Checking..."
        '
        'PerformanceMemoryUsedByDashy
        '
        Me.PerformanceMemoryUsedByDashy.AutoSize = True
        Me.PerformanceMemoryUsedByDashy.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerformanceMemoryUsedByDashy.Location = New System.Drawing.Point(3, 160)
        Me.PerformanceMemoryUsedByDashy.Name = "PerformanceMemoryUsedByDashy"
        Me.PerformanceMemoryUsedByDashy.Size = New System.Drawing.Size(268, 18)
        Me.PerformanceMemoryUsedByDashy.TabIndex = 7
        Me.PerformanceMemoryUsedByDashy.Text = "Physical memory used by Dashy: Checking..."
        '
        'PerformanceTotalVirtualMem
        '
        Me.PerformanceTotalVirtualMem.AutoSize = True
        Me.PerformanceTotalVirtualMem.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerformanceTotalVirtualMem.Location = New System.Drawing.Point(3, 70)
        Me.PerformanceTotalVirtualMem.Name = "PerformanceTotalVirtualMem"
        Me.PerformanceTotalVirtualMem.Size = New System.Drawing.Size(208, 18)
        Me.PerformanceTotalVirtualMem.TabIndex = 6
        Me.PerformanceTotalVirtualMem.Text = "Total virtual memory: Checking..."
        '
        'PerformanceAvailPhysicalMem
        '
        Me.PerformanceAvailPhysicalMem.AutoSize = True
        Me.PerformanceAvailPhysicalMem.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerformanceAvailPhysicalMem.Location = New System.Drawing.Point(3, 88)
        Me.PerformanceAvailPhysicalMem.Name = "PerformanceAvailPhysicalMem"
        Me.PerformanceAvailPhysicalMem.Size = New System.Drawing.Size(239, 18)
        Me.PerformanceAvailPhysicalMem.TabIndex = 5
        Me.PerformanceAvailPhysicalMem.Text = "Available physical memory: Checking..."
        '
        'PerformanceAvailVirtualMem
        '
        Me.PerformanceAvailVirtualMem.AutoSize = True
        Me.PerformanceAvailVirtualMem.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerformanceAvailVirtualMem.Location = New System.Drawing.Point(3, 106)
        Me.PerformanceAvailVirtualMem.Name = "PerformanceAvailVirtualMem"
        Me.PerformanceAvailVirtualMem.Size = New System.Drawing.Size(231, 18)
        Me.PerformanceAvailVirtualMem.TabIndex = 4
        Me.PerformanceAvailVirtualMem.Text = "Available virtual memory: Checking..."
        '
        'PerformanceImg
        '
        Me.PerformanceImg.Image = CType(resources.GetObject("PerformanceImg.Image"), System.Drawing.Image)
        Me.PerformanceImg.Location = New System.Drawing.Point(3, 3)
        Me.PerformanceImg.Name = "PerformanceImg"
        Me.PerformanceImg.Size = New System.Drawing.Size(64, 64)
        Me.PerformanceImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PerformanceImg.TabIndex = 2
        Me.PerformanceImg.TabStop = False
        '
        'PerformanceLbl
        '
        Me.PerformanceLbl.AutoSize = True
        Me.PerformanceLbl.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerformanceLbl.Location = New System.Drawing.Point(70, 18)
        Me.PerformanceLbl.Name = "PerformanceLbl"
        Me.PerformanceLbl.Size = New System.Drawing.Size(131, 27)
        Me.PerformanceLbl.TabIndex = 3
        Me.PerformanceLbl.Text = "Performance"
        '
        'HardwareTotalPhysicalMem
        '
        Me.HardwareTotalPhysicalMem.AutoSize = True
        Me.HardwareTotalPhysicalMem.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HardwareTotalPhysicalMem.Location = New System.Drawing.Point(3, 88)
        Me.HardwareTotalPhysicalMem.Name = "HardwareTotalPhysicalMem"
        Me.HardwareTotalPhysicalMem.Size = New System.Drawing.Size(216, 18)
        Me.HardwareTotalPhysicalMem.TabIndex = 7
        Me.HardwareTotalPhysicalMem.Text = "Total physical memory: Checking..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DocumentationToolStripMenuItem, Me.CheckForUpdatesToolStripMenuItem, Me.AboutDashyToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'DocumentationToolStripMenuItem
        '
        Me.DocumentationToolStripMenuItem.Name = "DocumentationToolStripMenuItem"
        Me.DocumentationToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.DocumentationToolStripMenuItem.Text = "&Documentation"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "&Check for updates"
        '
        'AboutDashyToolStripMenuItem
        '
        Me.AboutDashyToolStripMenuItem.Name = "AboutDashyToolStripMenuItem"
        Me.AboutDashyToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.AboutDashyToolStripMenuItem.Text = "&About Dashy"
        '
        'HardwarePanel
        '
        Me.HardwarePanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.HardwarePanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.HardwarePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HardwarePanel.Controls.Add(Me.HardwareScreenPrimary)
        Me.HardwarePanel.Controls.Add(Me.HardwareScreenName)
        Me.HardwarePanel.Controls.Add(Me.HardwareScreenBounds)
        Me.HardwarePanel.Controls.Add(Me.HardwareMouseWheel)
        Me.HardwarePanel.Controls.Add(Me.HardwareTotalPhysicalMem)
        Me.HardwarePanel.Controls.Add(Me.HardwareProcessorCount)
        Me.HardwarePanel.Controls.Add(Me.HardwareImg)
        Me.HardwarePanel.Controls.Add(Me.HardwareLbl)
        Me.HardwarePanel.Location = New System.Drawing.Point(528, 12)
        Me.HardwarePanel.Name = "HardwarePanel"
        Me.HardwarePanel.Size = New System.Drawing.Size(252, 290)
        Me.HardwarePanel.TabIndex = 6
        '
        'HardwareScreenPrimary
        '
        Me.HardwareScreenPrimary.AutoSize = True
        Me.HardwareScreenPrimary.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HardwareScreenPrimary.Location = New System.Drawing.Point(3, 142)
        Me.HardwareScreenPrimary.Name = "HardwareScreenPrimary"
        Me.HardwareScreenPrimary.Size = New System.Drawing.Size(172, 18)
        Me.HardwareScreenPrimary.TabIndex = 11
        Me.HardwareScreenPrimary.Text = "Primary screen: Checking..."
        '
        'HardwareScreenName
        '
        Me.HardwareScreenName.AutoSize = True
        Me.HardwareScreenName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HardwareScreenName.Location = New System.Drawing.Point(3, 124)
        Me.HardwareScreenName.Name = "HardwareScreenName"
        Me.HardwareScreenName.Size = New System.Drawing.Size(204, 18)
        Me.HardwareScreenName.TabIndex = 10
        Me.HardwareScreenName.Text = "Screen Device Name: Checking..."
        '
        'HardwareScreenBounds
        '
        Me.HardwareScreenBounds.AutoSize = True
        Me.HardwareScreenBounds.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HardwareScreenBounds.Location = New System.Drawing.Point(3, 160)
        Me.HardwareScreenBounds.Name = "HardwareScreenBounds"
        Me.HardwareScreenBounds.Size = New System.Drawing.Size(169, 18)
        Me.HardwareScreenBounds.TabIndex = 9
        Me.HardwareScreenBounds.Text = "Screen Bounds: Checking..."
        '
        'HardwareMouseWheel
        '
        Me.HardwareMouseWheel.AutoSize = True
        Me.HardwareMouseWheel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HardwareMouseWheel.Location = New System.Drawing.Point(3, 106)
        Me.HardwareMouseWheel.Name = "HardwareMouseWheel"
        Me.HardwareMouseWheel.Size = New System.Drawing.Size(162, 18)
        Me.HardwareMouseWheel.TabIndex = 8
        Me.HardwareMouseWheel.Text = "Mouse Wheel: Checking..."
        '
        'HardwareProcessorCount
        '
        Me.HardwareProcessorCount.AutoSize = True
        Me.HardwareProcessorCount.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HardwareProcessorCount.Location = New System.Drawing.Point(3, 70)
        Me.HardwareProcessorCount.Name = "HardwareProcessorCount"
        Me.HardwareProcessorCount.Size = New System.Drawing.Size(147, 18)
        Me.HardwareProcessorCount.TabIndex = 5
        Me.HardwareProcessorCount.Text = "Processors: Checking..."
        '
        'HardwareImg
        '
        Me.HardwareImg.Image = CType(resources.GetObject("HardwareImg.Image"), System.Drawing.Image)
        Me.HardwareImg.Location = New System.Drawing.Point(3, 3)
        Me.HardwareImg.Name = "HardwareImg"
        Me.HardwareImg.Size = New System.Drawing.Size(64, 64)
        Me.HardwareImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HardwareImg.TabIndex = 2
        Me.HardwareImg.TabStop = False
        '
        'HardwareLbl
        '
        Me.HardwareLbl.AutoSize = True
        Me.HardwareLbl.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HardwareLbl.Location = New System.Drawing.Point(70, 18)
        Me.HardwareLbl.Name = "HardwareLbl"
        Me.HardwareLbl.Size = New System.Drawing.Size(105, 27)
        Me.HardwareLbl.TabIndex = 3
        Me.HardwareLbl.Text = "Hardware"
        '
        'SystemOSArch
        '
        Me.SystemOSArch.AutoSize = True
        Me.SystemOSArch.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemOSArch.Location = New System.Drawing.Point(3, 151)
        Me.SystemOSArch.Name = "SystemOSArch"
        Me.SystemOSArch.Size = New System.Drawing.Size(131, 18)
        Me.SystemOSArch.TabIndex = 4
        Me.SystemOSArch.Text = "OS Arch: Checking..."
        '
        'SystemPanel
        '
        Me.SystemPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.SystemPanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SystemPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SystemPanel.Controls.Add(Me.SystemWorkingArea)
        Me.SystemPanel.Controls.Add(Me.SystemScreenBitsPerPixel)
        Me.SystemPanel.Controls.Add(Me.SystemScrollLines)
        Me.SystemPanel.Controls.Add(Me.SystemDashyArch)
        Me.SystemPanel.Controls.Add(Me.SystemShutdownStarted)
        Me.SystemPanel.Controls.Add(Me.SystemInteractiveMode)
        Me.SystemPanel.Controls.Add(Me.SystemDomain)
        Me.SystemPanel.Controls.Add(Me.SystemNameComputer)
        Me.SystemPanel.Controls.Add(Me.SystemNameEN)
        Me.SystemPanel.Controls.Add(Me.SystemOSPlatform)
        Me.SystemPanel.Controls.Add(Me.SystemOSEnvironVersion)
        Me.SystemPanel.Controls.Add(Me.SystemLoggedInUser)
        Me.SystemPanel.Controls.Add(Me.SystemOSArch)
        Me.SystemPanel.Controls.Add(Me.SystemOSInfoVersion)
        Me.SystemPanel.Controls.Add(Me.SystemOS)
        Me.SystemPanel.Controls.Add(Me.SystemImg)
        Me.SystemPanel.Controls.Add(Me.SystemLbl)
        Me.SystemPanel.Location = New System.Drawing.Point(786, 12)
        Me.SystemPanel.Name = "SystemPanel"
        Me.SystemPanel.Size = New System.Drawing.Size(252, 397)
        Me.SystemPanel.TabIndex = 7
        '
        'SystemWorkingArea
        '
        Me.SystemWorkingArea.AutoSize = True
        Me.SystemWorkingArea.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemWorkingArea.Location = New System.Drawing.Point(3, 350)
        Me.SystemWorkingArea.Name = "SystemWorkingArea"
        Me.SystemWorkingArea.Size = New System.Drawing.Size(204, 18)
        Me.SystemWorkingArea.TabIndex = 17
        Me.SystemWorkingArea.Text = "Screen working area: Checking..."
        '
        'SystemScreenBitsPerPixel
        '
        Me.SystemScreenBitsPerPixel.AutoSize = True
        Me.SystemScreenBitsPerPixel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemScreenBitsPerPixel.Location = New System.Drawing.Point(3, 332)
        Me.SystemScreenBitsPerPixel.Name = "SystemScreenBitsPerPixel"
        Me.SystemScreenBitsPerPixel.Size = New System.Drawing.Size(205, 18)
        Me.SystemScreenBitsPerPixel.TabIndex = 16
        Me.SystemScreenBitsPerPixel.Text = "Screen Bits per pixel: Checking..."
        '
        'SystemScrollLines
        '
        Me.SystemScrollLines.AutoSize = True
        Me.SystemScrollLines.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemScrollLines.Location = New System.Drawing.Point(3, 314)
        Me.SystemScrollLines.Name = "SystemScrollLines"
        Me.SystemScrollLines.Size = New System.Drawing.Size(266, 18)
        Me.SystemScrollLines.TabIndex = 15
        Me.SystemScrollLines.Text = "Lines to scroll with scroll wheel: Checking..."
        '
        'SystemDashyArch
        '
        Me.SystemDashyArch.AutoSize = True
        Me.SystemDashyArch.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemDashyArch.Location = New System.Drawing.Point(3, 286)
        Me.SystemDashyArch.Name = "SystemDashyArch"
        Me.SystemDashyArch.Size = New System.Drawing.Size(159, 18)
        Me.SystemDashyArch.TabIndex = 14
        Me.SystemDashyArch.Text = "Process Arch: Checking..."
        '
        'SystemShutdownStarted
        '
        Me.SystemShutdownStarted.AutoSize = True
        Me.SystemShutdownStarted.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemShutdownStarted.Location = New System.Drawing.Point(3, 268)
        Me.SystemShutdownStarted.Name = "SystemShutdownStarted"
        Me.SystemShutdownStarted.Size = New System.Drawing.Size(187, 18)
        Me.SystemShutdownStarted.TabIndex = 13
        Me.SystemShutdownStarted.Text = "Shutdown started: Checking..."
        '
        'SystemInteractiveMode
        '
        Me.SystemInteractiveMode.AutoSize = True
        Me.SystemInteractiveMode.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemInteractiveMode.Location = New System.Drawing.Point(3, 250)
        Me.SystemInteractiveMode.Name = "SystemInteractiveMode"
        Me.SystemInteractiveMode.Size = New System.Drawing.Size(251, 18)
        Me.SystemInteractiveMode.TabIndex = 12
        Me.SystemInteractiveMode.Text = "Running in interactive mode: Checking..."
        '
        'SystemDomain
        '
        Me.SystemDomain.AutoSize = True
        Me.SystemDomain.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemDomain.Location = New System.Drawing.Point(3, 214)
        Me.SystemDomain.Name = "SystemDomain"
        Me.SystemDomain.Size = New System.Drawing.Size(129, 18)
        Me.SystemDomain.TabIndex = 11
        Me.SystemDomain.Text = "Domain: Checking..."
        '
        'SystemNameComputer
        '
        Me.SystemNameComputer.AutoSize = True
        Me.SystemNameComputer.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemNameComputer.Location = New System.Drawing.Point(3, 196)
        Me.SystemNameComputer.Name = "SystemNameComputer"
        Me.SystemNameComputer.Size = New System.Drawing.Size(180, 18)
        Me.SystemNameComputer.TabIndex = 10
        Me.SystemNameComputer.Text = "Computer.Name: Checking..."
        '
        'SystemNameEN
        '
        Me.SystemNameEN.AutoSize = True
        Me.SystemNameEN.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemNameEN.Location = New System.Drawing.Point(3, 178)
        Me.SystemNameEN.Name = "SystemNameEN"
        Me.SystemNameEN.Size = New System.Drawing.Size(186, 18)
        Me.SystemNameEN.TabIndex = 9
        Me.SystemNameEN.Text = "EN.MachineName: Checking..."
        '
        'SystemOSPlatform
        '
        Me.SystemOSPlatform.AutoSize = True
        Me.SystemOSPlatform.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemOSPlatform.Location = New System.Drawing.Point(3, 133)
        Me.SystemOSPlatform.Name = "SystemOSPlatform"
        Me.SystemOSPlatform.Size = New System.Drawing.Size(155, 18)
        Me.SystemOSPlatform.TabIndex = 8
        Me.SystemOSPlatform.Text = "OS Platform: Checking..."
        '
        'SystemOSEnvironVersion
        '
        Me.SystemOSEnvironVersion.AutoSize = True
        Me.SystemOSEnvironVersion.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemOSEnvironVersion.Location = New System.Drawing.Point(3, 115)
        Me.SystemOSEnvironVersion.Name = "SystemOSEnvironVersion"
        Me.SystemOSEnvironVersion.Size = New System.Drawing.Size(162, 18)
        Me.SystemOSEnvironVersion.TabIndex = 7
        Me.SystemOSEnvironVersion.Text = "Full OS Name: Checking..."
        '
        'SystemLoggedInUser
        '
        Me.SystemLoggedInUser.AutoSize = True
        Me.SystemLoggedInUser.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemLoggedInUser.Location = New System.Drawing.Point(3, 232)
        Me.SystemLoggedInUser.Name = "SystemLoggedInUser"
        Me.SystemLoggedInUser.Size = New System.Drawing.Size(171, 18)
        Me.SystemLoggedInUser.TabIndex = 6
        Me.SystemLoggedInUser.Text = "Logged in user: Checking..."
        '
        'SystemOSInfoVersion
        '
        Me.SystemOSInfoVersion.AutoSize = True
        Me.SystemOSInfoVersion.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemOSInfoVersion.Location = New System.Drawing.Point(3, 97)
        Me.SystemOSInfoVersion.Name = "SystemOSInfoVersion"
        Me.SystemOSInfoVersion.Size = New System.Drawing.Size(148, 18)
        Me.SystemOSInfoVersion.TabIndex = 5
        Me.SystemOSInfoVersion.Text = "OS Version: Checking..."
        '
        'SystemOS
        '
        Me.SystemOS.AutoSize = True
        Me.SystemOS.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemOS.Location = New System.Drawing.Point(3, 79)
        Me.SystemOS.Name = "SystemOS"
        Me.SystemOS.Size = New System.Drawing.Size(101, 18)
        Me.SystemOS.TabIndex = 4
        Me.SystemOS.Text = "OS: Checking..."
        '
        'SystemImg
        '
        Me.SystemImg.Image = Global.Dashy.My.Resources.Resources._1404236744_kservices
        Me.SystemImg.Location = New System.Drawing.Point(3, 3)
        Me.SystemImg.Name = "SystemImg"
        Me.SystemImg.Size = New System.Drawing.Size(64, 64)
        Me.SystemImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SystemImg.TabIndex = 2
        Me.SystemImg.TabStop = False
        '
        'SystemLbl
        '
        Me.SystemLbl.AutoSize = True
        Me.SystemLbl.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemLbl.Location = New System.Drawing.Point(70, 18)
        Me.SystemLbl.Name = "SystemLbl"
        Me.SystemLbl.Size = New System.Drawing.Size(76, 27)
        Me.SystemLbl.TabIndex = 3
        Me.SystemLbl.Text = "System"
        '
        'NetworkPanel
        '
        Me.NetworkPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NetworkPanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.NetworkPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NetworkPanel.Controls.Add(Me.NetworkSplitContainer)
        Me.NetworkPanel.Location = New System.Drawing.Point(1044, 12)
        Me.NetworkPanel.Name = "NetworkPanel"
        Me.NetworkPanel.Size = New System.Drawing.Size(252, 397)
        Me.NetworkPanel.TabIndex = 8
        '
        'NetworkSplitContainer
        '
        Me.NetworkSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NetworkSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NetworkSplitContainer.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetworkSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.NetworkSplitContainer.Name = "NetworkSplitContainer"
        Me.NetworkSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'NetworkSplitContainer.Panel1
        '
        Me.NetworkSplitContainer.Panel1.Controls.Add(Me.NetworkImg)
        Me.NetworkSplitContainer.Panel1.Controls.Add(Me.NetworkInternetConnection)
        Me.NetworkSplitContainer.Panel1.Controls.Add(Me.NetworkLbl)
        Me.NetworkSplitContainer.Panel1.Controls.Add(Me.NetworkIsConnected)
        Me.NetworkSplitContainer.Panel1MinSize = 121
        '
        'NetworkSplitContainer.Panel2
        '
        Me.NetworkSplitContainer.Panel2.Controls.Add(Me.NetworkSerialPortNamesLBL)
        Me.NetworkSplitContainer.Panel2.Controls.Add(Me.NetworkSerialPortNames)
        Me.NetworkSplitContainer.Panel2MinSize = 50
        Me.NetworkSplitContainer.Size = New System.Drawing.Size(250, 395)
        Me.NetworkSplitContainer.SplitterDistance = 121
        Me.NetworkSplitContainer.TabIndex = 18
        '
        'NetworkImg
        '
        Me.NetworkImg.Image = Global.Dashy.My.Resources.Resources._1404314626_Globe
        Me.NetworkImg.Location = New System.Drawing.Point(3, 3)
        Me.NetworkImg.Name = "NetworkImg"
        Me.NetworkImg.Size = New System.Drawing.Size(64, 64)
        Me.NetworkImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.NetworkImg.TabIndex = 2
        Me.NetworkImg.TabStop = False
        '
        'NetworkInternetConnection
        '
        Me.NetworkInternetConnection.AutoSize = True
        Me.NetworkInternetConnection.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetworkInternetConnection.Location = New System.Drawing.Point(3, 97)
        Me.NetworkInternetConnection.Name = "NetworkInternetConnection"
        Me.NetworkInternetConnection.Size = New System.Drawing.Size(154, 18)
        Me.NetworkInternetConnection.TabIndex = 5
        Me.NetworkInternetConnection.Text = "Internet connection: N/A"
        '
        'NetworkLbl
        '
        Me.NetworkLbl.AutoSize = True
        Me.NetworkLbl.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetworkLbl.Location = New System.Drawing.Point(70, 18)
        Me.NetworkLbl.Name = "NetworkLbl"
        Me.NetworkLbl.Size = New System.Drawing.Size(91, 27)
        Me.NetworkLbl.TabIndex = 3
        Me.NetworkLbl.Text = "Network"
        '
        'NetworkIsConnected
        '
        Me.NetworkIsConnected.AutoSize = True
        Me.NetworkIsConnected.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetworkIsConnected.Location = New System.Drawing.Point(3, 79)
        Me.NetworkIsConnected.Name = "NetworkIsConnected"
        Me.NetworkIsConnected.Size = New System.Drawing.Size(213, 18)
        Me.NetworkIsConnected.TabIndex = 4
        Me.NetworkIsConnected.Text = "Connected to network: Checking..."
        '
        'NetworkSerialPortNamesLBL
        '
        Me.NetworkSerialPortNamesLBL.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NetworkSerialPortNamesLBL.AutoSize = True
        Me.NetworkSerialPortNamesLBL.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetworkSerialPortNamesLBL.Location = New System.Drawing.Point(2, 3)
        Me.NetworkSerialPortNamesLBL.Name = "NetworkSerialPortNamesLBL"
        Me.NetworkSerialPortNamesLBL.Size = New System.Drawing.Size(117, 18)
        Me.NetworkSerialPortNamesLBL.TabIndex = 17
        Me.NetworkSerialPortNamesLBL.Text = "Serial Port Names:"
        '
        'NetworkSerialPortNames
        '
        Me.NetworkSerialPortNames.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NetworkSerialPortNames.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetworkSerialPortNames.FormattingEnabled = True
        Me.NetworkSerialPortNames.IntegralHeight = False
        Me.NetworkSerialPortNames.ItemHeight = 16
        Me.NetworkSerialPortNames.Location = New System.Drawing.Point(3, 24)
        Me.NetworkSerialPortNames.Name = "NetworkSerialPortNames"
        Me.NetworkSerialPortNames.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.NetworkSerialPortNames.Size = New System.Drawing.Size(242, 240)
        Me.NetworkSerialPortNames.TabIndex = 16
        '
        'TimerMonitorFast
        '
        Me.TimerMonitorFast.Interval = 2000
        '
        'TimerMonitorSlow
        '
        Me.TimerMonitorSlow.Interval = 30000
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRefresh.AutoSize = True
        Me.btnRefresh.Location = New System.Drawing.Point(528, 386)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(159, 23)
        Me.btnRefresh.TabIndex = 9
        Me.btnRefresh.Text = "Refresh SlowTimer Now"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Location = New System.Drawing.Point(693, 386)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit Dashy"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'SlowTimerRefreshLabel
        '
        Me.SlowTimerRefreshLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SlowTimerRefreshLabel.AutoSize = True
        Me.SlowTimerRefreshLabel.Location = New System.Drawing.Point(528, 344)
        Me.SlowTimerRefreshLabel.Name = "SlowTimerRefreshLabel"
        Me.SlowTimerRefreshLabel.Size = New System.Drawing.Size(154, 13)
        Me.SlowTimerRefreshLabel.TabIndex = 11
        Me.SlowTimerRefreshLabel.Text = "SlowTimer Refresh time: Every:"
        '
        'SlowTimerRefreshValue
        '
        Me.SlowTimerRefreshValue.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SlowTimerRefreshValue.Items.Add("200")
        Me.SlowTimerRefreshValue.Items.Add("199")
        Me.SlowTimerRefreshValue.Items.Add("198")
        Me.SlowTimerRefreshValue.Items.Add("197")
        Me.SlowTimerRefreshValue.Items.Add("196")
        Me.SlowTimerRefreshValue.Items.Add("195")
        Me.SlowTimerRefreshValue.Items.Add("194")
        Me.SlowTimerRefreshValue.Items.Add("193")
        Me.SlowTimerRefreshValue.Items.Add("192")
        Me.SlowTimerRefreshValue.Items.Add("191")
        Me.SlowTimerRefreshValue.Items.Add("190")
        Me.SlowTimerRefreshValue.Items.Add("189")
        Me.SlowTimerRefreshValue.Items.Add("188")
        Me.SlowTimerRefreshValue.Items.Add("187")
        Me.SlowTimerRefreshValue.Items.Add("186")
        Me.SlowTimerRefreshValue.Items.Add("185")
        Me.SlowTimerRefreshValue.Items.Add("184")
        Me.SlowTimerRefreshValue.Items.Add("183")
        Me.SlowTimerRefreshValue.Items.Add("182")
        Me.SlowTimerRefreshValue.Items.Add("181")
        Me.SlowTimerRefreshValue.Items.Add("180")
        Me.SlowTimerRefreshValue.Items.Add("179")
        Me.SlowTimerRefreshValue.Items.Add("178")
        Me.SlowTimerRefreshValue.Items.Add("177")
        Me.SlowTimerRefreshValue.Items.Add("176")
        Me.SlowTimerRefreshValue.Items.Add("175")
        Me.SlowTimerRefreshValue.Items.Add("174")
        Me.SlowTimerRefreshValue.Items.Add("173")
        Me.SlowTimerRefreshValue.Items.Add("172")
        Me.SlowTimerRefreshValue.Items.Add("171")
        Me.SlowTimerRefreshValue.Items.Add("170")
        Me.SlowTimerRefreshValue.Items.Add("169")
        Me.SlowTimerRefreshValue.Items.Add("168")
        Me.SlowTimerRefreshValue.Items.Add("167")
        Me.SlowTimerRefreshValue.Items.Add("166")
        Me.SlowTimerRefreshValue.Items.Add("165")
        Me.SlowTimerRefreshValue.Items.Add("164")
        Me.SlowTimerRefreshValue.Items.Add("163")
        Me.SlowTimerRefreshValue.Items.Add("162")
        Me.SlowTimerRefreshValue.Items.Add("161")
        Me.SlowTimerRefreshValue.Items.Add("160")
        Me.SlowTimerRefreshValue.Items.Add("159")
        Me.SlowTimerRefreshValue.Items.Add("158")
        Me.SlowTimerRefreshValue.Items.Add("157")
        Me.SlowTimerRefreshValue.Items.Add("156")
        Me.SlowTimerRefreshValue.Items.Add("155")
        Me.SlowTimerRefreshValue.Items.Add("154")
        Me.SlowTimerRefreshValue.Items.Add("153")
        Me.SlowTimerRefreshValue.Items.Add("152")
        Me.SlowTimerRefreshValue.Items.Add("151")
        Me.SlowTimerRefreshValue.Items.Add("150")
        Me.SlowTimerRefreshValue.Items.Add("149")
        Me.SlowTimerRefreshValue.Items.Add("148")
        Me.SlowTimerRefreshValue.Items.Add("147")
        Me.SlowTimerRefreshValue.Items.Add("146")
        Me.SlowTimerRefreshValue.Items.Add("145")
        Me.SlowTimerRefreshValue.Items.Add("144")
        Me.SlowTimerRefreshValue.Items.Add("143")
        Me.SlowTimerRefreshValue.Items.Add("142")
        Me.SlowTimerRefreshValue.Items.Add("141")
        Me.SlowTimerRefreshValue.Items.Add("140")
        Me.SlowTimerRefreshValue.Items.Add("139")
        Me.SlowTimerRefreshValue.Items.Add("138")
        Me.SlowTimerRefreshValue.Items.Add("137")
        Me.SlowTimerRefreshValue.Items.Add("136")
        Me.SlowTimerRefreshValue.Items.Add("135")
        Me.SlowTimerRefreshValue.Items.Add("134")
        Me.SlowTimerRefreshValue.Items.Add("133")
        Me.SlowTimerRefreshValue.Items.Add("132")
        Me.SlowTimerRefreshValue.Items.Add("131")
        Me.SlowTimerRefreshValue.Items.Add("130")
        Me.SlowTimerRefreshValue.Items.Add("129")
        Me.SlowTimerRefreshValue.Items.Add("128")
        Me.SlowTimerRefreshValue.Items.Add("127")
        Me.SlowTimerRefreshValue.Items.Add("126")
        Me.SlowTimerRefreshValue.Items.Add("125")
        Me.SlowTimerRefreshValue.Items.Add("124")
        Me.SlowTimerRefreshValue.Items.Add("123")
        Me.SlowTimerRefreshValue.Items.Add("122")
        Me.SlowTimerRefreshValue.Items.Add("121")
        Me.SlowTimerRefreshValue.Items.Add("120")
        Me.SlowTimerRefreshValue.Items.Add("119")
        Me.SlowTimerRefreshValue.Items.Add("118")
        Me.SlowTimerRefreshValue.Items.Add("117")
        Me.SlowTimerRefreshValue.Items.Add("116")
        Me.SlowTimerRefreshValue.Items.Add("115")
        Me.SlowTimerRefreshValue.Items.Add("114")
        Me.SlowTimerRefreshValue.Items.Add("113")
        Me.SlowTimerRefreshValue.Items.Add("112")
        Me.SlowTimerRefreshValue.Items.Add("111")
        Me.SlowTimerRefreshValue.Items.Add("110")
        Me.SlowTimerRefreshValue.Items.Add("109")
        Me.SlowTimerRefreshValue.Items.Add("108")
        Me.SlowTimerRefreshValue.Items.Add("107")
        Me.SlowTimerRefreshValue.Items.Add("106")
        Me.SlowTimerRefreshValue.Items.Add("105")
        Me.SlowTimerRefreshValue.Items.Add("104")
        Me.SlowTimerRefreshValue.Items.Add("103")
        Me.SlowTimerRefreshValue.Items.Add("102")
        Me.SlowTimerRefreshValue.Items.Add("101")
        Me.SlowTimerRefreshValue.Items.Add("100")
        Me.SlowTimerRefreshValue.Items.Add("99")
        Me.SlowTimerRefreshValue.Items.Add("98")
        Me.SlowTimerRefreshValue.Items.Add("97")
        Me.SlowTimerRefreshValue.Items.Add("96")
        Me.SlowTimerRefreshValue.Items.Add("95")
        Me.SlowTimerRefreshValue.Items.Add("94")
        Me.SlowTimerRefreshValue.Items.Add("93")
        Me.SlowTimerRefreshValue.Items.Add("92")
        Me.SlowTimerRefreshValue.Items.Add("91")
        Me.SlowTimerRefreshValue.Items.Add("90")
        Me.SlowTimerRefreshValue.Items.Add("89")
        Me.SlowTimerRefreshValue.Items.Add("88")
        Me.SlowTimerRefreshValue.Items.Add("87")
        Me.SlowTimerRefreshValue.Items.Add("86")
        Me.SlowTimerRefreshValue.Items.Add("85")
        Me.SlowTimerRefreshValue.Items.Add("84")
        Me.SlowTimerRefreshValue.Items.Add("83")
        Me.SlowTimerRefreshValue.Items.Add("82")
        Me.SlowTimerRefreshValue.Items.Add("81")
        Me.SlowTimerRefreshValue.Items.Add("80")
        Me.SlowTimerRefreshValue.Items.Add("79")
        Me.SlowTimerRefreshValue.Items.Add("78")
        Me.SlowTimerRefreshValue.Items.Add("77")
        Me.SlowTimerRefreshValue.Items.Add("76")
        Me.SlowTimerRefreshValue.Items.Add("75")
        Me.SlowTimerRefreshValue.Items.Add("74")
        Me.SlowTimerRefreshValue.Items.Add("73")
        Me.SlowTimerRefreshValue.Items.Add("72")
        Me.SlowTimerRefreshValue.Items.Add("71")
        Me.SlowTimerRefreshValue.Items.Add("70")
        Me.SlowTimerRefreshValue.Items.Add("69")
        Me.SlowTimerRefreshValue.Items.Add("68")
        Me.SlowTimerRefreshValue.Items.Add("67")
        Me.SlowTimerRefreshValue.Items.Add("66")
        Me.SlowTimerRefreshValue.Items.Add("65")
        Me.SlowTimerRefreshValue.Items.Add("64")
        Me.SlowTimerRefreshValue.Items.Add("63")
        Me.SlowTimerRefreshValue.Items.Add("62")
        Me.SlowTimerRefreshValue.Items.Add("61")
        Me.SlowTimerRefreshValue.Items.Add("60")
        Me.SlowTimerRefreshValue.Items.Add("59")
        Me.SlowTimerRefreshValue.Items.Add("58")
        Me.SlowTimerRefreshValue.Items.Add("57")
        Me.SlowTimerRefreshValue.Items.Add("56")
        Me.SlowTimerRefreshValue.Items.Add("55")
        Me.SlowTimerRefreshValue.Items.Add("54")
        Me.SlowTimerRefreshValue.Items.Add("53")
        Me.SlowTimerRefreshValue.Items.Add("52")
        Me.SlowTimerRefreshValue.Items.Add("51")
        Me.SlowTimerRefreshValue.Items.Add("50")
        Me.SlowTimerRefreshValue.Items.Add("49")
        Me.SlowTimerRefreshValue.Items.Add("48")
        Me.SlowTimerRefreshValue.Items.Add("47")
        Me.SlowTimerRefreshValue.Items.Add("46")
        Me.SlowTimerRefreshValue.Items.Add("45")
        Me.SlowTimerRefreshValue.Items.Add("44")
        Me.SlowTimerRefreshValue.Items.Add("43")
        Me.SlowTimerRefreshValue.Items.Add("42")
        Me.SlowTimerRefreshValue.Items.Add("41")
        Me.SlowTimerRefreshValue.Items.Add("40")
        Me.SlowTimerRefreshValue.Items.Add("39")
        Me.SlowTimerRefreshValue.Items.Add("38")
        Me.SlowTimerRefreshValue.Items.Add("37")
        Me.SlowTimerRefreshValue.Items.Add("36")
        Me.SlowTimerRefreshValue.Items.Add("35")
        Me.SlowTimerRefreshValue.Items.Add("34")
        Me.SlowTimerRefreshValue.Items.Add("33")
        Me.SlowTimerRefreshValue.Items.Add("32")
        Me.SlowTimerRefreshValue.Items.Add("31")
        Me.SlowTimerRefreshValue.Items.Add("30")
        Me.SlowTimerRefreshValue.Items.Add("29")
        Me.SlowTimerRefreshValue.Items.Add("28")
        Me.SlowTimerRefreshValue.Items.Add("27")
        Me.SlowTimerRefreshValue.Items.Add("26")
        Me.SlowTimerRefreshValue.Items.Add("25")
        Me.SlowTimerRefreshValue.Items.Add("24")
        Me.SlowTimerRefreshValue.Items.Add("23")
        Me.SlowTimerRefreshValue.Items.Add("22")
        Me.SlowTimerRefreshValue.Items.Add("21")
        Me.SlowTimerRefreshValue.Items.Add("20")
        Me.SlowTimerRefreshValue.Items.Add("19")
        Me.SlowTimerRefreshValue.Items.Add("18")
        Me.SlowTimerRefreshValue.Items.Add("17")
        Me.SlowTimerRefreshValue.Items.Add("16")
        Me.SlowTimerRefreshValue.Items.Add("15")
        Me.SlowTimerRefreshValue.Items.Add("14")
        Me.SlowTimerRefreshValue.Items.Add("13")
        Me.SlowTimerRefreshValue.Items.Add("12")
        Me.SlowTimerRefreshValue.Items.Add("11")
        Me.SlowTimerRefreshValue.Items.Add("10")
        Me.SlowTimerRefreshValue.Items.Add("9")
        Me.SlowTimerRefreshValue.Items.Add("8")
        Me.SlowTimerRefreshValue.Items.Add("7")
        Me.SlowTimerRefreshValue.Items.Add("6")
        Me.SlowTimerRefreshValue.Items.Add("5")
        Me.SlowTimerRefreshValue.Items.Add("4")
        Me.SlowTimerRefreshValue.Items.Add("3")
        Me.SlowTimerRefreshValue.Items.Add("2")
        Me.SlowTimerRefreshValue.Items.Add("1")
        Me.SlowTimerRefreshValue.Location = New System.Drawing.Point(641, 360)
        Me.SlowTimerRefreshValue.Name = "SlowTimerRefreshValue"
        Me.SlowTimerRefreshValue.Size = New System.Drawing.Size(46, 20)
        Me.SlowTimerRefreshValue.TabIndex = 12
        Me.SlowTimerRefreshValue.Text = "30"
        '
        'SlowTimerRefreshUnit
        '
        Me.SlowTimerRefreshUnit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SlowTimerRefreshUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SlowTimerRefreshUnit.FormattingEnabled = True
        Me.SlowTimerRefreshUnit.Items.AddRange(New Object() {"Millisecond(s)", "Centisecond(s)", "Second(s)", "Minute(s)", "Hour(s)"})
        Me.SlowTimerRefreshUnit.Location = New System.Drawing.Point(693, 359)
        Me.SlowTimerRefreshUnit.Name = "SlowTimerRefreshUnit"
        Me.SlowTimerRefreshUnit.Size = New System.Drawing.Size(87, 21)
        Me.SlowTimerRefreshUnit.TabIndex = 13
        '
        'FastTimerRefreshUnit
        '
        Me.FastTimerRefreshUnit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.FastTimerRefreshUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FastTimerRefreshUnit.FormattingEnabled = True
        Me.FastTimerRefreshUnit.Items.AddRange(New Object() {"Millisecond(s)", "Centisecond(s)", "Second(s)", "Minute(s)", "Hour(s)"})
        Me.FastTimerRefreshUnit.Location = New System.Drawing.Point(693, 320)
        Me.FastTimerRefreshUnit.Name = "FastTimerRefreshUnit"
        Me.FastTimerRefreshUnit.Size = New System.Drawing.Size(87, 21)
        Me.FastTimerRefreshUnit.TabIndex = 16
        '
        'FastTimerRefreshValue
        '
        Me.FastTimerRefreshValue.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.FastTimerRefreshValue.Items.Add("200")
        Me.FastTimerRefreshValue.Items.Add("199")
        Me.FastTimerRefreshValue.Items.Add("198")
        Me.FastTimerRefreshValue.Items.Add("197")
        Me.FastTimerRefreshValue.Items.Add("196")
        Me.FastTimerRefreshValue.Items.Add("195")
        Me.FastTimerRefreshValue.Items.Add("194")
        Me.FastTimerRefreshValue.Items.Add("193")
        Me.FastTimerRefreshValue.Items.Add("192")
        Me.FastTimerRefreshValue.Items.Add("191")
        Me.FastTimerRefreshValue.Items.Add("190")
        Me.FastTimerRefreshValue.Items.Add("189")
        Me.FastTimerRefreshValue.Items.Add("188")
        Me.FastTimerRefreshValue.Items.Add("187")
        Me.FastTimerRefreshValue.Items.Add("186")
        Me.FastTimerRefreshValue.Items.Add("185")
        Me.FastTimerRefreshValue.Items.Add("184")
        Me.FastTimerRefreshValue.Items.Add("183")
        Me.FastTimerRefreshValue.Items.Add("182")
        Me.FastTimerRefreshValue.Items.Add("181")
        Me.FastTimerRefreshValue.Items.Add("180")
        Me.FastTimerRefreshValue.Items.Add("179")
        Me.FastTimerRefreshValue.Items.Add("178")
        Me.FastTimerRefreshValue.Items.Add("177")
        Me.FastTimerRefreshValue.Items.Add("176")
        Me.FastTimerRefreshValue.Items.Add("175")
        Me.FastTimerRefreshValue.Items.Add("174")
        Me.FastTimerRefreshValue.Items.Add("173")
        Me.FastTimerRefreshValue.Items.Add("172")
        Me.FastTimerRefreshValue.Items.Add("171")
        Me.FastTimerRefreshValue.Items.Add("170")
        Me.FastTimerRefreshValue.Items.Add("169")
        Me.FastTimerRefreshValue.Items.Add("168")
        Me.FastTimerRefreshValue.Items.Add("167")
        Me.FastTimerRefreshValue.Items.Add("166")
        Me.FastTimerRefreshValue.Items.Add("165")
        Me.FastTimerRefreshValue.Items.Add("164")
        Me.FastTimerRefreshValue.Items.Add("163")
        Me.FastTimerRefreshValue.Items.Add("162")
        Me.FastTimerRefreshValue.Items.Add("161")
        Me.FastTimerRefreshValue.Items.Add("160")
        Me.FastTimerRefreshValue.Items.Add("159")
        Me.FastTimerRefreshValue.Items.Add("158")
        Me.FastTimerRefreshValue.Items.Add("157")
        Me.FastTimerRefreshValue.Items.Add("156")
        Me.FastTimerRefreshValue.Items.Add("155")
        Me.FastTimerRefreshValue.Items.Add("154")
        Me.FastTimerRefreshValue.Items.Add("153")
        Me.FastTimerRefreshValue.Items.Add("152")
        Me.FastTimerRefreshValue.Items.Add("151")
        Me.FastTimerRefreshValue.Items.Add("150")
        Me.FastTimerRefreshValue.Items.Add("149")
        Me.FastTimerRefreshValue.Items.Add("148")
        Me.FastTimerRefreshValue.Items.Add("147")
        Me.FastTimerRefreshValue.Items.Add("146")
        Me.FastTimerRefreshValue.Items.Add("145")
        Me.FastTimerRefreshValue.Items.Add("144")
        Me.FastTimerRefreshValue.Items.Add("143")
        Me.FastTimerRefreshValue.Items.Add("142")
        Me.FastTimerRefreshValue.Items.Add("141")
        Me.FastTimerRefreshValue.Items.Add("140")
        Me.FastTimerRefreshValue.Items.Add("139")
        Me.FastTimerRefreshValue.Items.Add("138")
        Me.FastTimerRefreshValue.Items.Add("137")
        Me.FastTimerRefreshValue.Items.Add("136")
        Me.FastTimerRefreshValue.Items.Add("135")
        Me.FastTimerRefreshValue.Items.Add("134")
        Me.FastTimerRefreshValue.Items.Add("133")
        Me.FastTimerRefreshValue.Items.Add("132")
        Me.FastTimerRefreshValue.Items.Add("131")
        Me.FastTimerRefreshValue.Items.Add("130")
        Me.FastTimerRefreshValue.Items.Add("129")
        Me.FastTimerRefreshValue.Items.Add("128")
        Me.FastTimerRefreshValue.Items.Add("127")
        Me.FastTimerRefreshValue.Items.Add("126")
        Me.FastTimerRefreshValue.Items.Add("125")
        Me.FastTimerRefreshValue.Items.Add("124")
        Me.FastTimerRefreshValue.Items.Add("123")
        Me.FastTimerRefreshValue.Items.Add("122")
        Me.FastTimerRefreshValue.Items.Add("121")
        Me.FastTimerRefreshValue.Items.Add("120")
        Me.FastTimerRefreshValue.Items.Add("119")
        Me.FastTimerRefreshValue.Items.Add("118")
        Me.FastTimerRefreshValue.Items.Add("117")
        Me.FastTimerRefreshValue.Items.Add("116")
        Me.FastTimerRefreshValue.Items.Add("115")
        Me.FastTimerRefreshValue.Items.Add("114")
        Me.FastTimerRefreshValue.Items.Add("113")
        Me.FastTimerRefreshValue.Items.Add("112")
        Me.FastTimerRefreshValue.Items.Add("111")
        Me.FastTimerRefreshValue.Items.Add("110")
        Me.FastTimerRefreshValue.Items.Add("109")
        Me.FastTimerRefreshValue.Items.Add("108")
        Me.FastTimerRefreshValue.Items.Add("107")
        Me.FastTimerRefreshValue.Items.Add("106")
        Me.FastTimerRefreshValue.Items.Add("105")
        Me.FastTimerRefreshValue.Items.Add("104")
        Me.FastTimerRefreshValue.Items.Add("103")
        Me.FastTimerRefreshValue.Items.Add("102")
        Me.FastTimerRefreshValue.Items.Add("101")
        Me.FastTimerRefreshValue.Items.Add("100")
        Me.FastTimerRefreshValue.Items.Add("99")
        Me.FastTimerRefreshValue.Items.Add("98")
        Me.FastTimerRefreshValue.Items.Add("97")
        Me.FastTimerRefreshValue.Items.Add("96")
        Me.FastTimerRefreshValue.Items.Add("95")
        Me.FastTimerRefreshValue.Items.Add("94")
        Me.FastTimerRefreshValue.Items.Add("93")
        Me.FastTimerRefreshValue.Items.Add("92")
        Me.FastTimerRefreshValue.Items.Add("91")
        Me.FastTimerRefreshValue.Items.Add("90")
        Me.FastTimerRefreshValue.Items.Add("89")
        Me.FastTimerRefreshValue.Items.Add("88")
        Me.FastTimerRefreshValue.Items.Add("87")
        Me.FastTimerRefreshValue.Items.Add("86")
        Me.FastTimerRefreshValue.Items.Add("85")
        Me.FastTimerRefreshValue.Items.Add("84")
        Me.FastTimerRefreshValue.Items.Add("83")
        Me.FastTimerRefreshValue.Items.Add("82")
        Me.FastTimerRefreshValue.Items.Add("81")
        Me.FastTimerRefreshValue.Items.Add("80")
        Me.FastTimerRefreshValue.Items.Add("79")
        Me.FastTimerRefreshValue.Items.Add("78")
        Me.FastTimerRefreshValue.Items.Add("77")
        Me.FastTimerRefreshValue.Items.Add("76")
        Me.FastTimerRefreshValue.Items.Add("75")
        Me.FastTimerRefreshValue.Items.Add("74")
        Me.FastTimerRefreshValue.Items.Add("73")
        Me.FastTimerRefreshValue.Items.Add("72")
        Me.FastTimerRefreshValue.Items.Add("71")
        Me.FastTimerRefreshValue.Items.Add("70")
        Me.FastTimerRefreshValue.Items.Add("69")
        Me.FastTimerRefreshValue.Items.Add("68")
        Me.FastTimerRefreshValue.Items.Add("67")
        Me.FastTimerRefreshValue.Items.Add("66")
        Me.FastTimerRefreshValue.Items.Add("65")
        Me.FastTimerRefreshValue.Items.Add("64")
        Me.FastTimerRefreshValue.Items.Add("63")
        Me.FastTimerRefreshValue.Items.Add("62")
        Me.FastTimerRefreshValue.Items.Add("61")
        Me.FastTimerRefreshValue.Items.Add("60")
        Me.FastTimerRefreshValue.Items.Add("59")
        Me.FastTimerRefreshValue.Items.Add("58")
        Me.FastTimerRefreshValue.Items.Add("57")
        Me.FastTimerRefreshValue.Items.Add("56")
        Me.FastTimerRefreshValue.Items.Add("55")
        Me.FastTimerRefreshValue.Items.Add("54")
        Me.FastTimerRefreshValue.Items.Add("53")
        Me.FastTimerRefreshValue.Items.Add("52")
        Me.FastTimerRefreshValue.Items.Add("51")
        Me.FastTimerRefreshValue.Items.Add("50")
        Me.FastTimerRefreshValue.Items.Add("49")
        Me.FastTimerRefreshValue.Items.Add("48")
        Me.FastTimerRefreshValue.Items.Add("47")
        Me.FastTimerRefreshValue.Items.Add("46")
        Me.FastTimerRefreshValue.Items.Add("45")
        Me.FastTimerRefreshValue.Items.Add("44")
        Me.FastTimerRefreshValue.Items.Add("43")
        Me.FastTimerRefreshValue.Items.Add("42")
        Me.FastTimerRefreshValue.Items.Add("41")
        Me.FastTimerRefreshValue.Items.Add("40")
        Me.FastTimerRefreshValue.Items.Add("39")
        Me.FastTimerRefreshValue.Items.Add("38")
        Me.FastTimerRefreshValue.Items.Add("37")
        Me.FastTimerRefreshValue.Items.Add("36")
        Me.FastTimerRefreshValue.Items.Add("35")
        Me.FastTimerRefreshValue.Items.Add("34")
        Me.FastTimerRefreshValue.Items.Add("33")
        Me.FastTimerRefreshValue.Items.Add("32")
        Me.FastTimerRefreshValue.Items.Add("31")
        Me.FastTimerRefreshValue.Items.Add("30")
        Me.FastTimerRefreshValue.Items.Add("29")
        Me.FastTimerRefreshValue.Items.Add("28")
        Me.FastTimerRefreshValue.Items.Add("27")
        Me.FastTimerRefreshValue.Items.Add("26")
        Me.FastTimerRefreshValue.Items.Add("25")
        Me.FastTimerRefreshValue.Items.Add("24")
        Me.FastTimerRefreshValue.Items.Add("23")
        Me.FastTimerRefreshValue.Items.Add("22")
        Me.FastTimerRefreshValue.Items.Add("21")
        Me.FastTimerRefreshValue.Items.Add("20")
        Me.FastTimerRefreshValue.Items.Add("19")
        Me.FastTimerRefreshValue.Items.Add("18")
        Me.FastTimerRefreshValue.Items.Add("17")
        Me.FastTimerRefreshValue.Items.Add("16")
        Me.FastTimerRefreshValue.Items.Add("15")
        Me.FastTimerRefreshValue.Items.Add("14")
        Me.FastTimerRefreshValue.Items.Add("13")
        Me.FastTimerRefreshValue.Items.Add("12")
        Me.FastTimerRefreshValue.Items.Add("11")
        Me.FastTimerRefreshValue.Items.Add("10")
        Me.FastTimerRefreshValue.Items.Add("9")
        Me.FastTimerRefreshValue.Items.Add("8")
        Me.FastTimerRefreshValue.Items.Add("7")
        Me.FastTimerRefreshValue.Items.Add("6")
        Me.FastTimerRefreshValue.Items.Add("5")
        Me.FastTimerRefreshValue.Items.Add("4")
        Me.FastTimerRefreshValue.Items.Add("3")
        Me.FastTimerRefreshValue.Items.Add("2")
        Me.FastTimerRefreshValue.Items.Add("1")
        Me.FastTimerRefreshValue.Location = New System.Drawing.Point(641, 321)
        Me.FastTimerRefreshValue.Name = "FastTimerRefreshValue"
        Me.FastTimerRefreshValue.Size = New System.Drawing.Size(46, 20)
        Me.FastTimerRefreshValue.TabIndex = 15
        Me.FastTimerRefreshValue.Text = "2"
        '
        'FastTimerRefreshLabel
        '
        Me.FastTimerRefreshLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.FastTimerRefreshLabel.AutoSize = True
        Me.FastTimerRefreshLabel.Location = New System.Drawing.Point(528, 305)
        Me.FastTimerRefreshLabel.Name = "FastTimerRefreshLabel"
        Me.FastTimerRefreshLabel.Size = New System.Drawing.Size(151, 13)
        Me.FastTimerRefreshLabel.TabIndex = 14
        Me.FastTimerRefreshLabel.Text = "FastTimer Refresh time: Every:"
        '
        'Dashy
        '
        Me.AcceptButton = Me.btnRefresh
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1310, 421)
        Me.Controls.Add(Me.FastTimerRefreshUnit)
        Me.Controls.Add(Me.FastTimerRefreshValue)
        Me.Controls.Add(Me.FastTimerRefreshLabel)
        Me.Controls.Add(Me.SlowTimerRefreshUnit)
        Me.Controls.Add(Me.SlowTimerRefreshValue)
        Me.Controls.Add(Me.SlowTimerRefreshLabel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.NetworkPanel)
        Me.Controls.Add(Me.SystemPanel)
        Me.Controls.Add(Me.HardwarePanel)
        Me.Controls.Add(Me.PerformancePanel)
        Me.Controls.Add(Me.FileSystemPanel)
        Me.Name = "Dashy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashy (GUI Revamped)"
        Me.FileSystemPanel.ResumeLayout(False)
        Me.FileSystemPanel.PerformLayout()
        Me.FileSystemDrivesTabControl.ResumeLayout(False)
        Me.FileSystemDrivesTabFS.ResumeLayout(False)
        Me.FileSystemDrivesTabEN.ResumeLayout(False)
        CType(Me.FileSystemImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PerformancePanel.ResumeLayout(False)
        Me.PerformancePanel.PerformLayout()
        CType(Me.PerformanceImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HardwarePanel.ResumeLayout(False)
        Me.HardwarePanel.PerformLayout()
        CType(Me.HardwareImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SystemPanel.ResumeLayout(False)
        Me.SystemPanel.PerformLayout()
        CType(Me.SystemImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NetworkPanel.ResumeLayout(False)
        Me.NetworkSplitContainer.Panel1.ResumeLayout(False)
        Me.NetworkSplitContainer.Panel1.PerformLayout()
        Me.NetworkSplitContainer.Panel2.ResumeLayout(False)
        Me.NetworkSplitContainer.Panel2.PerformLayout()
        CType(Me.NetworkSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NetworkSplitContainer.ResumeLayout(False)
        CType(Me.NetworkImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FileSystemImg As System.Windows.Forms.PictureBox
    Friend WithEvents FileSystemPanel As System.Windows.Forms.Panel
    Friend WithEvents PerformancePanel As System.Windows.Forms.Panel
    Friend WithEvents HardwareTotalPhysicalMem As System.Windows.Forms.Label
    Friend WithEvents PerformanceTotalVirtualMem As System.Windows.Forms.Label
    Friend WithEvents PerformanceAvailPhysicalMem As System.Windows.Forms.Label
    Friend WithEvents PerformanceAvailVirtualMem As System.Windows.Forms.Label
    Friend WithEvents PerformanceImg As System.Windows.Forms.PictureBox
    Friend WithEvents PerformanceLbl As System.Windows.Forms.Label
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocumentationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutDashyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HardwarePanel As System.Windows.Forms.Panel
    Friend WithEvents SystemOSArch As System.Windows.Forms.Label
    Friend WithEvents HardwareImg As System.Windows.Forms.PictureBox
    Friend WithEvents HardwareLbl As System.Windows.Forms.Label
    Friend WithEvents FileSystemLbl As System.Windows.Forms.Label
    Friend WithEvents FileSystemDriveListLBL As System.Windows.Forms.Label
    Friend WithEvents FileSystemNumberOfDrives As System.Windows.Forms.Label
    Friend WithEvents SystemPanel As System.Windows.Forms.Panel
    Friend WithEvents SystemOS As System.Windows.Forms.Label
    Friend WithEvents SystemImg As System.Windows.Forms.PictureBox
    Friend WithEvents SystemLbl As System.Windows.Forms.Label
    Friend WithEvents SystemOSInfoVersion As System.Windows.Forms.Label
    Friend WithEvents FileSystemProgramFilesDirectory As System.Windows.Forms.Label
    Friend WithEvents FileSystemProgramFilesDirectoryLBL As System.Windows.Forms.Label
    Friend WithEvents HardwareProcessorCount As System.Windows.Forms.Label
    Friend WithEvents SystemLoggedInUser As System.Windows.Forms.Label
    Friend WithEvents NetworkPanel As System.Windows.Forms.Panel
    Friend WithEvents NetworkInternetConnection As System.Windows.Forms.Label
    Friend WithEvents NetworkIsConnected As System.Windows.Forms.Label
    Friend WithEvents NetworkImg As System.Windows.Forms.PictureBox
    Friend WithEvents NetworkLbl As System.Windows.Forms.Label
    Friend WithEvents FileSystemHomePath As System.Windows.Forms.Label
    Friend WithEvents FileSystemHomePathLBL As System.Windows.Forms.Label
    Friend WithEvents TimerMonitorFast As System.Windows.Forms.Timer
    Friend WithEvents TimerMonitorSlow As System.Windows.Forms.Timer
    Friend WithEvents FileSystemDriveListFS As System.Windows.Forms.ListBox
    Friend WithEvents HardwareScreenPrimary As System.Windows.Forms.Label
    Friend WithEvents HardwareScreenName As System.Windows.Forms.Label
    Friend WithEvents HardwareScreenBounds As System.Windows.Forms.Label
    Friend WithEvents HardwareMouseWheel As System.Windows.Forms.Label
    Friend WithEvents FileSystemFsCurrentDir As System.Windows.Forms.Label
    Friend WithEvents FileSystemFsCurrentDirLBL As System.Windows.Forms.Label
    Friend WithEvents FileSystemSysDir As System.Windows.Forms.Label
    Friend WithEvents FileSystemSysDirLBL As System.Windows.Forms.Label
    Friend WithEvents FileSystemEnCurrentDir As System.Windows.Forms.Label
    Friend WithEvents FileSystemEnCurrentDirLBL As System.Windows.Forms.Label
    Friend WithEvents FileSystemDrivesTabControl As System.Windows.Forms.TabControl
    Friend WithEvents FileSystemDrivesTabFS As System.Windows.Forms.TabPage
    Friend WithEvents FileSystemDrivesTabEN As System.Windows.Forms.TabPage
    Friend WithEvents FileSystemDriveListEN As System.Windows.Forms.ListBox
    Friend WithEvents PerformancePagefile As System.Windows.Forms.Label
    Friend WithEvents PerformanceUptime As System.Windows.Forms.Label
    Friend WithEvents PerformanceMemoryUsedByDashy As System.Windows.Forms.Label
    Friend WithEvents SystemOSPlatform As System.Windows.Forms.Label
    Friend WithEvents SystemOSEnvironVersion As System.Windows.Forms.Label
    Friend WithEvents SystemDashyArch As System.Windows.Forms.Label
    Friend WithEvents SystemShutdownStarted As System.Windows.Forms.Label
    Friend WithEvents SystemInteractiveMode As System.Windows.Forms.Label
    Friend WithEvents SystemDomain As System.Windows.Forms.Label
    Friend WithEvents SystemNameComputer As System.Windows.Forms.Label
    Friend WithEvents SystemNameEN As System.Windows.Forms.Label
    Friend WithEvents SystemWorkingArea As System.Windows.Forms.Label
    Friend WithEvents SystemScreenBitsPerPixel As System.Windows.Forms.Label
    Friend WithEvents SystemScrollLines As System.Windows.Forms.Label
    Friend WithEvents NetworkSerialPortNames As System.Windows.Forms.ListBox
    Friend WithEvents NetworkSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents NetworkSerialPortNamesLBL As System.Windows.Forms.Label
    Friend WithEvents PerformanceClockTick As System.Windows.Forms.Label
    Friend WithEvents PerformanceClipboard As System.Windows.Forms.Label
    Friend WithEvents PerformanceClockLocal As System.Windows.Forms.Label
    Friend WithEvents PerformanceClockLocalLBL As System.Windows.Forms.Label
    Friend WithEvents PerformanceClockGMT As System.Windows.Forms.Label
    Friend WithEvents PerformanceClockGMTLBL As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents SlowTimerRefreshLabel As System.Windows.Forms.Label
    Friend WithEvents SlowTimerRefreshValue As System.Windows.Forms.DomainUpDown
    Friend WithEvents SlowTimerRefreshUnit As System.Windows.Forms.ComboBox
    Friend WithEvents FastTimerRefreshUnit As System.Windows.Forms.ComboBox
    Friend WithEvents FastTimerRefreshValue As System.Windows.Forms.DomainUpDown
    Friend WithEvents FastTimerRefreshLabel As System.Windows.Forms.Label

End Class
