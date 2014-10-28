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
        Me.PerformanceTotalPhysicalMem = New System.Windows.Forms.Label()
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
        Me.HardwareProcessors = New System.Windows.Forms.Label()
        Me.HardwareArch = New System.Windows.Forms.Label()
        Me.HardwareImg = New System.Windows.Forms.PictureBox()
        Me.HardwareLbl = New System.Windows.Forms.Label()
        Me.SystemPanel = New System.Windows.Forms.Panel()
        Me.SystemLoggedInUser = New System.Windows.Forms.Label()
        Me.SystemOSVersion = New System.Windows.Forms.Label()
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
        Me.FileSystemDriveList = New System.Windows.Forms.ListBox()
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
        Me.SuspendLayout()
        '
        'FileSystemPanel
        '
        Me.FileSystemPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.FileSystemPanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.FileSystemPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FileSystemPanel.Controls.Add(Me.FileSystemDriveList)
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
        Me.FileSystemPanel.Size = New System.Drawing.Size(252, 293)
        Me.FileSystemPanel.TabIndex = 4
        '
        'FileSystemHomePath
        '
        Me.FileSystemHomePath.AutoSize = True
        Me.FileSystemHomePath.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemHomePath.Location = New System.Drawing.Point(3, 142)
        Me.FileSystemHomePath.Name = "FileSystemHomePath"
        Me.FileSystemHomePath.Size = New System.Drawing.Size(76, 18)
        Me.FileSystemHomePath.TabIndex = 14
        Me.FileSystemHomePath.Text = "Checking..."
        '
        'FileSystemHomePathLBL
        '
        Me.FileSystemHomePathLBL.AutoSize = True
        Me.FileSystemHomePathLBL.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemHomePathLBL.Location = New System.Drawing.Point(3, 124)
        Me.FileSystemHomePathLBL.Name = "FileSystemHomePathLBL"
        Me.FileSystemHomePathLBL.Size = New System.Drawing.Size(77, 18)
        Me.FileSystemHomePathLBL.TabIndex = 13
        Me.FileSystemHomePathLBL.Text = "Home path:"
        '
        'FileSystemProgramFilesDirectory
        '
        Me.FileSystemProgramFilesDirectory.AutoSize = True
        Me.FileSystemProgramFilesDirectory.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemProgramFilesDirectory.Location = New System.Drawing.Point(3, 106)
        Me.FileSystemProgramFilesDirectory.Name = "FileSystemProgramFilesDirectory"
        Me.FileSystemProgramFilesDirectory.Size = New System.Drawing.Size(76, 18)
        Me.FileSystemProgramFilesDirectory.TabIndex = 12
        Me.FileSystemProgramFilesDirectory.Text = "Checking..."
        '
        'FileSystemProgramFilesDirectoryLBL
        '
        Me.FileSystemProgramFilesDirectoryLBL.AutoSize = True
        Me.FileSystemProgramFilesDirectoryLBL.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemProgramFilesDirectoryLBL.Location = New System.Drawing.Point(3, 88)
        Me.FileSystemProgramFilesDirectoryLBL.Name = "FileSystemProgramFilesDirectoryLBL"
        Me.FileSystemProgramFilesDirectoryLBL.Size = New System.Drawing.Size(149, 18)
        Me.FileSystemProgramFilesDirectoryLBL.TabIndex = 11
        Me.FileSystemProgramFilesDirectoryLBL.Text = "Program Files directory:"
        '
        'FileSystemNumberOfDrives
        '
        Me.FileSystemNumberOfDrives.AutoSize = True
        Me.FileSystemNumberOfDrives.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemNumberOfDrives.Location = New System.Drawing.Point(3, 70)
        Me.FileSystemNumberOfDrives.Name = "FileSystemNumberOfDrives"
        Me.FileSystemNumberOfDrives.Size = New System.Drawing.Size(161, 18)
        Me.FileSystemNumberOfDrives.TabIndex = 10
        Me.FileSystemNumberOfDrives.Text = "No. of drives: Checking..."
        '
        'FileSystemDriveListLBL
        '
        Me.FileSystemDriveListLBL.AutoSize = True
        Me.FileSystemDriveListLBL.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemDriveListLBL.Location = New System.Drawing.Point(3, 160)
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
        Me.PerformancePanel.Controls.Add(Me.PerformanceTotalPhysicalMem)
        Me.PerformancePanel.Controls.Add(Me.PerformanceTotalVirtualMem)
        Me.PerformancePanel.Controls.Add(Me.PerformanceAvailPhysicalMem)
        Me.PerformancePanel.Controls.Add(Me.PerformanceAvailVirtualMem)
        Me.PerformancePanel.Controls.Add(Me.PerformanceImg)
        Me.PerformancePanel.Controls.Add(Me.PerformanceLbl)
        Me.PerformancePanel.Location = New System.Drawing.Point(270, 12)
        Me.PerformancePanel.Name = "PerformancePanel"
        Me.PerformancePanel.Size = New System.Drawing.Size(252, 293)
        Me.PerformancePanel.TabIndex = 5
        '
        'PerformanceTotalPhysicalMem
        '
        Me.PerformanceTotalPhysicalMem.AutoSize = True
        Me.PerformanceTotalPhysicalMem.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerformanceTotalPhysicalMem.Location = New System.Drawing.Point(3, 127)
        Me.PerformanceTotalPhysicalMem.Name = "PerformanceTotalPhysicalMem"
        Me.PerformanceTotalPhysicalMem.Size = New System.Drawing.Size(216, 18)
        Me.PerformanceTotalPhysicalMem.TabIndex = 7
        Me.PerformanceTotalPhysicalMem.Text = "Total physical memory: Checking..."
        '
        'PerformanceTotalVirtualMem
        '
        Me.PerformanceTotalVirtualMem.AutoSize = True
        Me.PerformanceTotalVirtualMem.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerformanceTotalVirtualMem.Location = New System.Drawing.Point(3, 111)
        Me.PerformanceTotalVirtualMem.Name = "PerformanceTotalVirtualMem"
        Me.PerformanceTotalVirtualMem.Size = New System.Drawing.Size(208, 18)
        Me.PerformanceTotalVirtualMem.TabIndex = 6
        Me.PerformanceTotalVirtualMem.Text = "Total virtual memory: Checking..."
        '
        'PerformanceAvailPhysicalMem
        '
        Me.PerformanceAvailPhysicalMem.AutoSize = True
        Me.PerformanceAvailPhysicalMem.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerformanceAvailPhysicalMem.Location = New System.Drawing.Point(3, 95)
        Me.PerformanceAvailPhysicalMem.Name = "PerformanceAvailPhysicalMem"
        Me.PerformanceAvailPhysicalMem.Size = New System.Drawing.Size(239, 18)
        Me.PerformanceAvailPhysicalMem.TabIndex = 5
        Me.PerformanceAvailPhysicalMem.Text = "Available physical memory: Checking..."
        '
        'PerformanceAvailVirtualMem
        '
        Me.PerformanceAvailVirtualMem.AutoSize = True
        Me.PerformanceAvailVirtualMem.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerformanceAvailVirtualMem.Location = New System.Drawing.Point(3, 79)
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
        Me.HardwarePanel.Controls.Add(Me.HardwareProcessors)
        Me.HardwarePanel.Controls.Add(Me.HardwareArch)
        Me.HardwarePanel.Controls.Add(Me.HardwareImg)
        Me.HardwarePanel.Controls.Add(Me.HardwareLbl)
        Me.HardwarePanel.Location = New System.Drawing.Point(528, 12)
        Me.HardwarePanel.Name = "HardwarePanel"
        Me.HardwarePanel.Size = New System.Drawing.Size(252, 293)
        Me.HardwarePanel.TabIndex = 6
        '
        'HardwareProcessors
        '
        Me.HardwareProcessors.AutoSize = True
        Me.HardwareProcessors.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HardwareProcessors.Location = New System.Drawing.Point(3, 97)
        Me.HardwareProcessors.Name = "HardwareProcessors"
        Me.HardwareProcessors.Size = New System.Drawing.Size(147, 18)
        Me.HardwareProcessors.TabIndex = 5
        Me.HardwareProcessors.Text = "Processors: Checking..."
        '
        'HardwareArch
        '
        Me.HardwareArch.AutoSize = True
        Me.HardwareArch.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HardwareArch.Location = New System.Drawing.Point(3, 79)
        Me.HardwareArch.Name = "HardwareArch"
        Me.HardwareArch.Size = New System.Drawing.Size(157, 18)
        Me.HardwareArch.TabIndex = 4
        Me.HardwareArch.Text = "Architecture: Checking..."
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
        Me.SystemPanel.Controls.Add(Me.SystemLoggedInUser)
        Me.SystemPanel.Controls.Add(Me.SystemOSVersion)
        Me.SystemPanel.Controls.Add(Me.SystemOS)
        Me.SystemPanel.Controls.Add(Me.SystemImg)
        Me.SystemPanel.Controls.Add(Me.SystemLbl)
        Me.SystemPanel.Location = New System.Drawing.Point(786, 12)
        Me.SystemPanel.Name = "SystemPanel"
        Me.SystemPanel.Size = New System.Drawing.Size(252, 293)
        Me.SystemPanel.TabIndex = 7
        '
        'SystemLoggedInUser
        '
        Me.SystemLoggedInUser.AutoSize = True
        Me.SystemLoggedInUser.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemLoggedInUser.Location = New System.Drawing.Point(3, 115)
        Me.SystemLoggedInUser.Name = "SystemLoggedInUser"
        Me.SystemLoggedInUser.Size = New System.Drawing.Size(171, 18)
        Me.SystemLoggedInUser.TabIndex = 6
        Me.SystemLoggedInUser.Text = "Logged in user: Checking..."
        '
        'SystemOSVersion
        '
        Me.SystemOSVersion.AutoSize = True
        Me.SystemOSVersion.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystemOSVersion.Location = New System.Drawing.Point(3, 97)
        Me.SystemOSVersion.Name = "SystemOSVersion"
        Me.SystemOSVersion.Size = New System.Drawing.Size(148, 18)
        Me.SystemOSVersion.TabIndex = 5
        Me.SystemOSVersion.Text = "OS Version: Checking..."
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
        Me.NetworkPanel.Controls.Add(Me.NetworkInternetConnection)
        Me.NetworkPanel.Controls.Add(Me.NetworkIsConnected)
        Me.NetworkPanel.Controls.Add(Me.NetworkImg)
        Me.NetworkPanel.Controls.Add(Me.NetworkLbl)
        Me.NetworkPanel.Location = New System.Drawing.Point(1044, 12)
        Me.NetworkPanel.Name = "NetworkPanel"
        Me.NetworkPanel.Size = New System.Drawing.Size(252, 293)
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
        'FileSystemDriveList
        '
        Me.FileSystemDriveList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FileSystemDriveList.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileSystemDriveList.FormattingEnabled = True
        Me.FileSystemDriveList.IntegralHeight = False
        Me.FileSystemDriveList.ItemHeight = 16
        Me.FileSystemDriveList.Location = New System.Drawing.Point(3, 181)
        Me.FileSystemDriveList.MultiColumn = True
        Me.FileSystemDriveList.Name = "FileSystemDriveList"
        Me.FileSystemDriveList.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.FileSystemDriveList.Size = New System.Drawing.Size(244, 107)
        Me.FileSystemDriveList.TabIndex = 15
        '
        'Dashy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1310, 312)
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
        Me.NetworkPanel.PerformLayout()
        CType(Me.NetworkImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FileSystemImg As System.Windows.Forms.PictureBox
    Friend WithEvents FileSystemPanel As System.Windows.Forms.Panel
    Friend WithEvents PerformancePanel As System.Windows.Forms.Panel
    Friend WithEvents PerformanceTotalPhysicalMem As System.Windows.Forms.Label
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
    Friend WithEvents HardwareArch As System.Windows.Forms.Label
    Friend WithEvents HardwareImg As System.Windows.Forms.PictureBox
    Friend WithEvents HardwareLbl As System.Windows.Forms.Label
    Friend WithEvents FileSystemLbl As System.Windows.Forms.Label
    Friend WithEvents FileSystemDriveListLBL As System.Windows.Forms.Label
    Friend WithEvents FileSystemNumberOfDrives As System.Windows.Forms.Label
    Friend WithEvents SystemPanel As System.Windows.Forms.Panel
    Friend WithEvents SystemOS As System.Windows.Forms.Label
    Friend WithEvents SystemImg As System.Windows.Forms.PictureBox
    Friend WithEvents SystemLbl As System.Windows.Forms.Label
    Friend WithEvents SystemOSVersion As System.Windows.Forms.Label
    Friend WithEvents FileSystemProgramFilesDirectory As System.Windows.Forms.Label
    Friend WithEvents FileSystemProgramFilesDirectoryLBL As System.Windows.Forms.Label
    Friend WithEvents HardwareProcessors As System.Windows.Forms.Label
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
    Friend WithEvents FileSystemDriveList As System.Windows.Forms.ListBox

End Class
