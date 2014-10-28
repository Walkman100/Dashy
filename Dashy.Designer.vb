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
        Me.FileSystemHomePath = New System.Windows.Forms.Label()
        Me.FileSystemHomePathLBL = New System.Windows.Forms.Label()
        Me.FileSystemProgramFilesDirectory = New System.Windows.Forms.Label()
        Me.FileSystemProgramFilesDirectoryLBL = New System.Windows.Forms.Label()
        Me.FileSystemNumberOfDrives = New System.Windows.Forms.Label()
        Me.FileSystemDriveListLBL = New System.Windows.Forms.Label()
        Me.FileSystemLbl = New System.Windows.Forms.Label()
        Me.FileSystemImg = New System.Windows.Forms.PictureBox()
        Me.PerformancePanel = New System.Windows.Forms.Panel()
        Me.HardwareTotalPhysicalMem = New System.Windows.Forms.Label()
        Me.PerformanceTotalVirtualMem = New System.Windows.Forms.Label()
        Me.PerformanceAvailPhysicalMem = New System.Windows.Forms.Label()
        Me.PerformanceAvailVirtualMem = New System.Windows.Forms.Label()
        Me.PerformanceImg = New System.Windows.Forms.PictureBox()
        Me.PerformanceLbl = New System.Windows.Forms.Label()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutDashyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HardwarePanel = New System.Windows.Forms.Panel()
        Me.HardwareProcessorCount = New System.Windows.Forms.Label()
        Me.SystemOSArch = New System.Windows.Forms.Label()
        Me.HardwareImg = New System.Windows.Forms.PictureBox()
        Me.HardwareLbl = New System.Windows.Forms.Label()
        Me.SystemPanel = New System.Windows.Forms.Panel()
        Me.SystemLoggedInUser = New System.Windows.Forms.Label()
        Me.SystemOSInfoVersion = New System.Windows.Forms.Label()
        Me.SystemOS = New System.Windows.Forms.Label()
        Me.SystemImg = New System.Windows.Forms.PictureBox()
        Me.SystemLbl = New System.Windows.Forms.Label()
        Me.NetworkPanel = New System.Windows.Forms.Panel()
        Me.NetworkInternetConnection = New System.Windows.Forms.Label()
        Me.NetworkIsConnected = New System.Windows.Forms.Label()
        Me.NetworkImg = New System.Windows.Forms.PictureBox()
        Me.NetworkLbl = New System.Windows.Forms.Label()
        Me.KeyChecker = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMonitorFast = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMonitorSlow = New System.Windows.Forms.Timer(Me.components)
        Me.FileSystemDriveListFS = New System.Windows.Forms.ListBox()
        Me.HardwareMouseWheel = New System.Windows.Forms.Label()
        Me.HardwareScreenBounds = New System.Windows.Forms.Label()
        Me.HardwareScreenName = New System.Windows.Forms.Label()
        Me.HardwareScreenPrimary = New System.Windows.Forms.Label()
        Me.FileSystemSysDir = New System.Windows.Forms.Label()
        Me.FileSystemSysDirLBL = New System.Windows.Forms.Label()
        Me.FileSystemEnCurrentDir = New System.Windows.Forms.Label()
        Me.FileSystemEnCurrentDirLBL = New System.Windows.Forms.Label()
        Me.FileSystemFsCurrentDir = New System.Windows.Forms.Label()
        Me.FileSystemFsCurrentDirLBL = New System.Windows.Forms.Label()
        Me.FileSystemDrivesTabControl = New System.Windows.Forms.TabControl()
        Me.FileSystemDrivesTabFS = New System.Windows.Forms.TabPage()
        Me.FileSystemDrivesTabEN = New System.Windows.Forms.TabPage()
        Me.FileSystemDriveListEN = New System.Windows.Forms.ListBox()
        Me.PerformanceMemoryUsedByDashy = New System.Windows.Forms.Label()
        Me.PerformanceUptime = New System.Windows.Forms.Label()
        Me.PerformancePagefile = New System.Windows.Forms.Label()
        Me.SystemOSEnvironVersion = New System.Windows.Forms.Label()
        Me.SystemOSPlatform = New System.Windows.Forms.Label()
        Me.SystemNameEN = New System.Windows.Forms.Label()
        Me.SystemNameComputer = New System.Windows.Forms.Label()
        Me.SystemDomain = New System.Windows.Forms.Label()
        Me.SystemInteractiveMode = New System.Windows.Forms.Label()
        Me.SystemShutdownStarted = New System.Windows.Forms.Label()
        Me.SystemDashyArch = New System.Windows.Forms.Label()
        Me.SystemScrollLines = New System.Windows.Forms.Label()
        Me.SystemScreenBitsPerPixel = New System.Windows.Forms.Label()
        Me.SystemWorkingArea = New System.Windows.Forms.Label()
        Me.NetworkSerialPortNames = New System.Windows.Forms.ListBox()
        Me.NetworkSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.NetworkSerialPortNamesLBL = New System.Windows.Forms.Label()
        Me.PerformanceClipboard = New System.Windows.Forms.Label()
        Me.PerformanceClockGMT = New System.Windows.Forms.Label()
        Me.PerformanceClockLocal = New System.Windows.Forms.Label()
        Me.PerformanceClockTick = New System.Windows.Forms.Label()
        Me.FileSystemPanel.SuspendLayout()
        CType(Me.FileSystemImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PerformancePanel.SuspendLayout()
        CType(Me.PerformanceImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HardwarePanel.SuspendLayout()
        CType(Me.HardwareImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SystemPanel.SuspendLayout()
        CType(Me.SystemImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NetworkPanel.SuspendLayout()
        CType(Me.NetworkImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FileSystemDrivesTabControl.SuspendLayout()
        Me.FileSystemDrivesTabFS.SuspendLayout()
        Me.FileSystemDrivesTabEN.SuspendLayout()
        CType(Me.NetworkSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NetworkSplitContainer.Panel1.SuspendLayout()
        Me.NetworkSplitContainer.Panel2.SuspendLayout()
        Me.NetworkSplitContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileSystemPanel
        '
        Me.FileSystemPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
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
        Me.FileSystemPanel.Size = New System.Drawing.Size(252, 443)
        Me.FileSystemPanel.TabIndex = 4
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
        Me.PerformancePanel.Controls.Add(Me.PerformanceClockTick)
        Me.PerformancePanel.Controls.Add(Me.PerformanceClockLocal)
        Me.PerformancePanel.Controls.Add(Me.PerformanceClockGMT)
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
        Me.PerformancePanel.Size = New System.Drawing.Size(252, 443)
        Me.PerformancePanel.TabIndex = 5
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
        Me.HardwarePanel.Size = New System.Drawing.Size(252, 443)
        Me.HardwarePanel.TabIndex = 6
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
        Me.SystemPanel.Size = New System.Drawing.Size(252, 443)
        Me.SystemPanel.TabIndex = 7
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
        Me.SystemOSInfoVersion.Size = New System.Drawing.Size(176, 18)
        Me.SystemOSInfoVersion.TabIndex = 5
        Me.SystemOSInfoVersion.Text = "Info.OS Version: Checking..."
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
        Me.NetworkPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.NetworkPanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.NetworkPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NetworkPanel.Controls.Add(Me.NetworkSplitContainer)
        Me.NetworkPanel.Location = New System.Drawing.Point(1044, 12)
        Me.NetworkPanel.Name = "NetworkPanel"
        Me.NetworkPanel.Size = New System.Drawing.Size(252, 443)
        Me.NetworkPanel.TabIndex = 8
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
        'KeyChecker
        '
        Me.KeyChecker.Interval = 1000
        '
        'TimerMonitorFast
        '
        Me.TimerMonitorFast.Interval = 1000
        '
        'TimerMonitorSlow
        '
        Me.TimerMonitorSlow.Interval = 60000
        '
        'FileSystemDriveListFS
        '
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
        Me.FileSystemDriveListFS.Size = New System.Drawing.Size(230, 114)
        Me.FileSystemDriveListFS.TabIndex = 15
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
        'HardwareScreenBounds
        '
        Me.HardwareScreenBounds.AutoSize = True
        Me.HardwareScreenBounds.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HardwareScreenBounds.Location = New System.Drawing.Point(3, 124)
        Me.HardwareScreenBounds.Name = "HardwareScreenBounds"
        Me.HardwareScreenBounds.Size = New System.Drawing.Size(169, 18)
        Me.HardwareScreenBounds.TabIndex = 9
        Me.HardwareScreenBounds.Text = "Screen Bounds: Checking..."
        '
        'HardwareScreenName
        '
        Me.HardwareScreenName.AutoSize = True
        Me.HardwareScreenName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HardwareScreenName.Location = New System.Drawing.Point(3, 142)
        Me.HardwareScreenName.Name = "HardwareScreenName"
        Me.HardwareScreenName.Size = New System.Drawing.Size(161, 18)
        Me.HardwareScreenName.TabIndex = 10
        Me.HardwareScreenName.Text = "Screen Name: Checking..."
        '
        'HardwareScreenPrimary
        '
        Me.HardwareScreenPrimary.AutoSize = True
        Me.HardwareScreenPrimary.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HardwareScreenPrimary.Location = New System.Drawing.Point(3, 160)
        Me.HardwareScreenPrimary.Name = "HardwareScreenPrimary"
        Me.HardwareScreenPrimary.Size = New System.Drawing.Size(172, 18)
        Me.HardwareScreenPrimary.TabIndex = 11
        Me.HardwareScreenPrimary.Text = "Primary screen: Checking..."
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
        Me.FileSystemDrivesTabControl.Size = New System.Drawing.Size(244, 149)
        Me.FileSystemDrivesTabControl.TabIndex = 22
        '
        'FileSystemDrivesTabFS
        '
        Me.FileSystemDrivesTabFS.Controls.Add(Me.FileSystemDriveListFS)
        Me.FileSystemDrivesTabFS.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemDrivesTabFS.Location = New System.Drawing.Point(4, 25)
        Me.FileSystemDrivesTabFS.Name = "FileSystemDrivesTabFS"
        Me.FileSystemDrivesTabFS.Padding = New System.Windows.Forms.Padding(3)
        Me.FileSystemDrivesTabFS.Size = New System.Drawing.Size(236, 120)
        Me.FileSystemDrivesTabFS.TabIndex = 0
        Me.FileSystemDrivesTabFS.Text = "FileSystem.Drives"
        Me.FileSystemDrivesTabFS.UseVisualStyleBackColor = True
        '
        'FileSystemDrivesTabEN
        '
        Me.FileSystemDrivesTabEN.Controls.Add(Me.FileSystemDriveListEN)
        Me.FileSystemDrivesTabEN.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemDrivesTabEN.Location = New System.Drawing.Point(4, 25)
        Me.FileSystemDrivesTabEN.Name = "FileSystemDrivesTabEN"
        Me.FileSystemDrivesTabEN.Padding = New System.Windows.Forms.Padding(3)
        Me.FileSystemDrivesTabEN.Size = New System.Drawing.Size(236, 120)
        Me.FileSystemDrivesTabEN.TabIndex = 1
        Me.FileSystemDrivesTabEN.Text = "Environment.Drives"
        Me.FileSystemDrivesTabEN.UseVisualStyleBackColor = True
        '
        'FileSystemDriveListEN
        '
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
        Me.FileSystemDriveListEN.Size = New System.Drawing.Size(230, 114)
        Me.FileSystemDriveListEN.TabIndex = 16
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
        'SystemOSEnvironVersion
        '
        Me.SystemOSEnvironVersion.AutoSize = True
        Me.SystemOSEnvironVersion.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemOSEnvironVersion.Location = New System.Drawing.Point(3, 115)
        Me.SystemOSEnvironVersion.Name = "SystemOSEnvironVersion"
        Me.SystemOSEnvironVersion.Size = New System.Drawing.Size(168, 18)
        Me.SystemOSEnvironVersion.TabIndex = 7
        Me.SystemOSEnvironVersion.Text = "EN.OS Version: Checking..."
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
        Me.NetworkSerialPortNames.Size = New System.Drawing.Size(242, 286)
        Me.NetworkSerialPortNames.TabIndex = 16
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
        Me.NetworkSplitContainer.Size = New System.Drawing.Size(250, 441)
        Me.NetworkSplitContainer.SplitterDistance = 121
        Me.NetworkSplitContainer.TabIndex = 18
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
        'PerformanceClipboard
        '
        Me.PerformanceClipboard.AutoSize = True
        Me.PerformanceClipboard.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerformanceClipboard.Location = New System.Drawing.Point(3, 250)
        Me.PerformanceClipboard.Name = "PerformanceClipboard"
        Me.PerformanceClipboard.Size = New System.Drawing.Size(196, 18)
        Me.PerformanceClipboard.TabIndex = 10
        Me.PerformanceClipboard.Text = "Clipboard Contents: Checking..."
        '
        'PerformanceClockGMT
        '
        Me.PerformanceClockGMT.AutoSize = True
        Me.PerformanceClockGMT.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerformanceClockGMT.Location = New System.Drawing.Point(3, 187)
        Me.PerformanceClockGMT.Name = "PerformanceClockGMT"
        Me.PerformanceClockGMT.Size = New System.Drawing.Size(181, 18)
        Me.PerformanceClockGMT.TabIndex = 11
        Me.PerformanceClockGMT.Text = "Clock GMT Time: Checking..."
        '
        'PerformanceClockLocal
        '
        Me.PerformanceClockLocal.AutoSize = True
        Me.PerformanceClockLocal.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerformanceClockLocal.Location = New System.Drawing.Point(3, 205)
        Me.PerformanceClockLocal.Name = "PerformanceClockLocal"
        Me.PerformanceClockLocal.Size = New System.Drawing.Size(184, 18)
        Me.PerformanceClockLocal.TabIndex = 12
        Me.PerformanceClockLocal.Text = "Clock Local Time: Checking..."
        '
        'PerformanceClockTick
        '
        Me.PerformanceClockTick.AutoSize = True
        Me.PerformanceClockTick.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerformanceClockTick.Location = New System.Drawing.Point(3, 223)
        Me.PerformanceClockTick.Name = "PerformanceClockTick"
        Me.PerformanceClockTick.Size = New System.Drawing.Size(185, 18)
        Me.PerformanceClockTick.TabIndex = 13
        Me.PerformanceClockTick.Text = "Millisecond count: Checking..."
        '
        'Dashy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1310, 462)
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
        CType(Me.NetworkImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FileSystemDrivesTabControl.ResumeLayout(False)
        Me.FileSystemDrivesTabFS.ResumeLayout(False)
        Me.FileSystemDrivesTabEN.ResumeLayout(False)
        Me.NetworkSplitContainer.Panel1.ResumeLayout(False)
        Me.NetworkSplitContainer.Panel1.PerformLayout()
        Me.NetworkSplitContainer.Panel2.ResumeLayout(False)
        Me.NetworkSplitContainer.Panel2.PerformLayout()
        CType(Me.NetworkSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NetworkSplitContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

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
    Friend WithEvents KeyChecker As System.Windows.Forms.Timer
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
    Friend WithEvents PerformanceClockLocal As System.Windows.Forms.Label
    Friend WithEvents PerformanceClockGMT As System.Windows.Forms.Label
    Friend WithEvents PerformanceClipboard As System.Windows.Forms.Label

End Class
