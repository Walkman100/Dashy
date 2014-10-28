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
        Me.pnlFileSystemPanel = New System.Windows.Forms.Panel()
        Me.lblHomePathValue = New System.Windows.Forms.Label()
        Me.lblHomePath = New System.Windows.Forms.Label()
        Me.lblProgramFilesDirectoryValue = New System.Windows.Forms.Label()
        Me.lblProgramFilesDirectory = New System.Windows.Forms.Label()
        Me.lblNumberofDrives = New System.Windows.Forms.Label()
        Me.cbListofDrivesValue = New System.Windows.Forms.ComboBox()
        Me.lblListofDrives = New System.Windows.Forms.Label()
        Me.lblFileSystem = New System.Windows.Forms.Label()
        Me.imgHarddrive = New System.Windows.Forms.PictureBox()
        Me.pnlPerformancePanel = New System.Windows.Forms.Panel()
        Me.lbltotalphysicalmem = New System.Windows.Forms.Label()
        Me.lbltotalvirtualmem = New System.Windows.Forms.Label()
        Me.lblavailphysicalmem = New System.Windows.Forms.Label()
        Me.lblavailvirtualmem = New System.Windows.Forms.Label()
        Me.imgPerformance = New System.Windows.Forms.PictureBox()
        Me.lblPerformance = New System.Windows.Forms.Label()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutDashyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlHardwarePanel = New System.Windows.Forms.Panel()
        Me.lblProcessors = New System.Windows.Forms.Label()
        Me.lblArch = New System.Windows.Forms.Label()
        Me.imgHardware = New System.Windows.Forms.PictureBox()
        Me.lblHardware = New System.Windows.Forms.Label()
        Me.Monitor_Performance = New System.Windows.Forms.Timer(Me.components)
        Me.Monitor_FileSystem = New System.Windows.Forms.Timer(Me.components)
        Me.pnlSystemPanel = New System.Windows.Forms.Panel()
        Me.lblLoggedInUser = New System.Windows.Forms.Label()
        Me.lblOSVersion = New System.Windows.Forms.Label()
        Me.lblOperatingSystem = New System.Windows.Forms.Label()
        Me.imgSystem = New System.Windows.Forms.PictureBox()
        Me.lblSystem = New System.Windows.Forms.Label()
        Me.pnlNetworkPanel = New System.Windows.Forms.Panel()
        Me.lblInternetConnection = New System.Windows.Forms.Label()
        Me.lblNetworkConnected = New System.Windows.Forms.Label()
        Me.imgNetwork = New System.Windows.Forms.PictureBox()
        Me.lblNetwork = New System.Windows.Forms.Label()
        Me.Monitor_Network = New System.Windows.Forms.Timer(Me.components)
        Me.KeyChecker = New System.Windows.Forms.Timer(Me.components)
        Me.pnlFileSystemPanel.SuspendLayout()
        CType(Me.imgHarddrive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPerformancePanel.SuspendLayout()
        CType(Me.imgPerformance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHardwarePanel.SuspendLayout()
        CType(Me.imgHardware, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSystemPanel.SuspendLayout()
        CType(Me.imgSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNetworkPanel.SuspendLayout()
        CType(Me.imgNetwork, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlFileSystemPanel
        '
        Me.pnlFileSystemPanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlFileSystemPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFileSystemPanel.Controls.Add(Me.lblHomePathValue)
        Me.pnlFileSystemPanel.Controls.Add(Me.lblHomePath)
        Me.pnlFileSystemPanel.Controls.Add(Me.lblProgramFilesDirectoryValue)
        Me.pnlFileSystemPanel.Controls.Add(Me.lblProgramFilesDirectory)
        Me.pnlFileSystemPanel.Controls.Add(Me.lblNumberofDrives)
        Me.pnlFileSystemPanel.Controls.Add(Me.cbListofDrivesValue)
        Me.pnlFileSystemPanel.Controls.Add(Me.lblListofDrives)
        Me.pnlFileSystemPanel.Controls.Add(Me.lblFileSystem)
        Me.pnlFileSystemPanel.Controls.Add(Me.imgHarddrive)
        Me.pnlFileSystemPanel.Location = New System.Drawing.Point(12, 92)
        Me.pnlFileSystemPanel.Name = "pnlFileSystemPanel"
        Me.pnlFileSystemPanel.Size = New System.Drawing.Size(252, 293)
        Me.pnlFileSystemPanel.TabIndex = 4
        '
        'lblHomePathValue
        '
        Me.lblHomePathValue.AutoSize = True
        Me.lblHomePathValue.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomePathValue.Location = New System.Drawing.Point(5, 183)
        Me.lblHomePathValue.Name = "lblHomePathValue"
        Me.lblHomePathValue.Size = New System.Drawing.Size(31, 18)
        Me.lblHomePathValue.TabIndex = 14
        Me.lblHomePathValue.Text = "N/A"
        '
        'lblHomePath
        '
        Me.lblHomePath.AutoSize = True
        Me.lblHomePath.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomePath.Location = New System.Drawing.Point(5, 165)
        Me.lblHomePath.Name = "lblHomePath"
        Me.lblHomePath.Size = New System.Drawing.Size(77, 18)
        Me.lblHomePath.TabIndex = 13
        Me.lblHomePath.Text = "Home path:"
        '
        'lblProgramFilesDirectoryValue
        '
        Me.lblProgramFilesDirectoryValue.AutoSize = True
        Me.lblProgramFilesDirectoryValue.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgramFilesDirectoryValue.Location = New System.Drawing.Point(5, 147)
        Me.lblProgramFilesDirectoryValue.Name = "lblProgramFilesDirectoryValue"
        Me.lblProgramFilesDirectoryValue.Size = New System.Drawing.Size(31, 18)
        Me.lblProgramFilesDirectoryValue.TabIndex = 12
        Me.lblProgramFilesDirectoryValue.Text = "N/A"
        '
        'lblProgramFilesDirectory
        '
        Me.lblProgramFilesDirectory.AutoSize = True
        Me.lblProgramFilesDirectory.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgramFilesDirectory.Location = New System.Drawing.Point(5, 129)
        Me.lblProgramFilesDirectory.Name = "lblProgramFilesDirectory"
        Me.lblProgramFilesDirectory.Size = New System.Drawing.Size(149, 18)
        Me.lblProgramFilesDirectory.TabIndex = 11
        Me.lblProgramFilesDirectory.Text = "Program Files directory:"
        '
        'lblNumberofDrives
        '
        Me.lblNumberofDrives.AutoSize = True
        Me.lblNumberofDrives.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberofDrives.Location = New System.Drawing.Point(4, 111)
        Me.lblNumberofDrives.Name = "lblNumberofDrives"
        Me.lblNumberofDrives.Size = New System.Drawing.Size(89, 18)
        Me.lblNumberofDrives.TabIndex = 10
        Me.lblNumberofDrives.Text = "No. of drives:"
        '
        'cbListofDrivesValue
        '
        Me.cbListofDrivesValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbListofDrivesValue.FormattingEnabled = True
        Me.cbListofDrivesValue.Location = New System.Drawing.Point(100, 79)
        Me.cbListofDrivesValue.Name = "cbListofDrivesValue"
        Me.cbListofDrivesValue.Size = New System.Drawing.Size(149, 21)
        Me.cbListofDrivesValue.TabIndex = 9
        '
        'lblListofDrives
        '
        Me.lblListofDrives.AutoSize = True
        Me.lblListofDrives.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListofDrives.Location = New System.Drawing.Point(3, 79)
        Me.lblListofDrives.Name = "lblListofDrives"
        Me.lblListofDrives.Size = New System.Drawing.Size(91, 18)
        Me.lblListofDrives.TabIndex = 8
        Me.lblListofDrives.Text = "List of drives:"
        '
        'lblFileSystem
        '
        Me.lblFileSystem.AutoSize = True
        Me.lblFileSystem.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileSystem.Location = New System.Drawing.Point(70, 18)
        Me.lblFileSystem.Name = "lblFileSystem"
        Me.lblFileSystem.Size = New System.Drawing.Size(110, 27)
        Me.lblFileSystem.TabIndex = 8
        Me.lblFileSystem.Text = "FileSystem"
        '
        'imgHarddrive
        '
        Me.imgHarddrive.Image = CType(resources.GetObject("imgHarddrive.Image"), System.Drawing.Image)
        Me.imgHarddrive.Location = New System.Drawing.Point(3, 3)
        Me.imgHarddrive.Name = "imgHarddrive"
        Me.imgHarddrive.Size = New System.Drawing.Size(64, 64)
        Me.imgHarddrive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgHarddrive.TabIndex = 2
        Me.imgHarddrive.TabStop = False
        '
        'pnlPerformancePanel
        '
        Me.pnlPerformancePanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlPerformancePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPerformancePanel.Controls.Add(Me.lbltotalphysicalmem)
        Me.pnlPerformancePanel.Controls.Add(Me.lbltotalvirtualmem)
        Me.pnlPerformancePanel.Controls.Add(Me.lblavailphysicalmem)
        Me.pnlPerformancePanel.Controls.Add(Me.lblavailvirtualmem)
        Me.pnlPerformancePanel.Controls.Add(Me.imgPerformance)
        Me.pnlPerformancePanel.Controls.Add(Me.lblPerformance)
        Me.pnlPerformancePanel.Location = New System.Drawing.Point(270, 92)
        Me.pnlPerformancePanel.Name = "pnlPerformancePanel"
        Me.pnlPerformancePanel.Size = New System.Drawing.Size(252, 293)
        Me.pnlPerformancePanel.TabIndex = 5
        '
        'lbltotalphysicalmem
        '
        Me.lbltotalphysicalmem.AutoSize = True
        Me.lbltotalphysicalmem.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalphysicalmem.Location = New System.Drawing.Point(3, 127)
        Me.lbltotalphysicalmem.Name = "lbltotalphysicalmem"
        Me.lbltotalphysicalmem.Size = New System.Drawing.Size(144, 18)
        Me.lbltotalphysicalmem.TabIndex = 7
        Me.lbltotalphysicalmem.Text = "Total physical memory:"
        '
        'lbltotalvirtualmem
        '
        Me.lbltotalvirtualmem.AutoSize = True
        Me.lbltotalvirtualmem.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalvirtualmem.Location = New System.Drawing.Point(3, 111)
        Me.lbltotalvirtualmem.Name = "lbltotalvirtualmem"
        Me.lbltotalvirtualmem.Size = New System.Drawing.Size(136, 18)
        Me.lbltotalvirtualmem.TabIndex = 6
        Me.lbltotalvirtualmem.Text = "Total virtual memory:"
        '
        'lblavailphysicalmem
        '
        Me.lblavailphysicalmem.AutoSize = True
        Me.lblavailphysicalmem.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblavailphysicalmem.Location = New System.Drawing.Point(3, 95)
        Me.lblavailphysicalmem.Name = "lblavailphysicalmem"
        Me.lblavailphysicalmem.Size = New System.Drawing.Size(167, 18)
        Me.lblavailphysicalmem.TabIndex = 5
        Me.lblavailphysicalmem.Text = "Available physical memory:"
        '
        'lblavailvirtualmem
        '
        Me.lblavailvirtualmem.AutoSize = True
        Me.lblavailvirtualmem.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblavailvirtualmem.Location = New System.Drawing.Point(3, 79)
        Me.lblavailvirtualmem.Name = "lblavailvirtualmem"
        Me.lblavailvirtualmem.Size = New System.Drawing.Size(159, 18)
        Me.lblavailvirtualmem.TabIndex = 4
        Me.lblavailvirtualmem.Text = "Available virtual memory:"
        '
        'imgPerformance
        '
        Me.imgPerformance.Image = CType(resources.GetObject("imgPerformance.Image"), System.Drawing.Image)
        Me.imgPerformance.Location = New System.Drawing.Point(3, 3)
        Me.imgPerformance.Name = "imgPerformance"
        Me.imgPerformance.Size = New System.Drawing.Size(64, 64)
        Me.imgPerformance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgPerformance.TabIndex = 2
        Me.imgPerformance.TabStop = False
        '
        'lblPerformance
        '
        Me.lblPerformance.AutoSize = True
        Me.lblPerformance.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerformance.Location = New System.Drawing.Point(70, 18)
        Me.lblPerformance.Name = "lblPerformance"
        Me.lblPerformance.Size = New System.Drawing.Size(131, 27)
        Me.lblPerformance.TabIndex = 3
        Me.lblPerformance.Text = "Performance"
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
        'pnlHardwarePanel
        '
        Me.pnlHardwarePanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlHardwarePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHardwarePanel.Controls.Add(Me.lblProcessors)
        Me.pnlHardwarePanel.Controls.Add(Me.lblArch)
        Me.pnlHardwarePanel.Controls.Add(Me.imgHardware)
        Me.pnlHardwarePanel.Controls.Add(Me.lblHardware)
        Me.pnlHardwarePanel.Location = New System.Drawing.Point(528, 92)
        Me.pnlHardwarePanel.Name = "pnlHardwarePanel"
        Me.pnlHardwarePanel.Size = New System.Drawing.Size(252, 293)
        Me.pnlHardwarePanel.TabIndex = 6
        '
        'lblProcessors
        '
        Me.lblProcessors.AutoSize = True
        Me.lblProcessors.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessors.Location = New System.Drawing.Point(3, 97)
        Me.lblProcessors.Name = "lblProcessors"
        Me.lblProcessors.Size = New System.Drawing.Size(75, 18)
        Me.lblProcessors.TabIndex = 5
        Me.lblProcessors.Text = "Processors:"
        '
        'lblArch
        '
        Me.lblArch.AutoSize = True
        Me.lblArch.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArch.Location = New System.Drawing.Point(3, 79)
        Me.lblArch.Name = "lblArch"
        Me.lblArch.Size = New System.Drawing.Size(85, 18)
        Me.lblArch.TabIndex = 4
        Me.lblArch.Text = "Architecture:"
        '
        'imgHardware
        '
        Me.imgHardware.Image = CType(resources.GetObject("imgHardware.Image"), System.Drawing.Image)
        Me.imgHardware.Location = New System.Drawing.Point(3, 3)
        Me.imgHardware.Name = "imgHardware"
        Me.imgHardware.Size = New System.Drawing.Size(64, 64)
        Me.imgHardware.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgHardware.TabIndex = 2
        Me.imgHardware.TabStop = False
        '
        'lblHardware
        '
        Me.lblHardware.AutoSize = True
        Me.lblHardware.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHardware.Location = New System.Drawing.Point(70, 18)
        Me.lblHardware.Name = "lblHardware"
        Me.lblHardware.Size = New System.Drawing.Size(105, 27)
        Me.lblHardware.TabIndex = 3
        Me.lblHardware.Text = "Hardware"
        '
        'Monitor_Performance
        '
        Me.Monitor_Performance.Interval = 1000
        '
        'Monitor_FileSystem
        '
        Me.Monitor_FileSystem.Interval = 1000
        '
        'pnlSystemPanel
        '
        Me.pnlSystemPanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlSystemPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSystemPanel.Controls.Add(Me.lblLoggedInUser)
        Me.pnlSystemPanel.Controls.Add(Me.lblOSVersion)
        Me.pnlSystemPanel.Controls.Add(Me.lblOperatingSystem)
        Me.pnlSystemPanel.Controls.Add(Me.imgSystem)
        Me.pnlSystemPanel.Controls.Add(Me.lblSystem)
        Me.pnlSystemPanel.Location = New System.Drawing.Point(786, 92)
        Me.pnlSystemPanel.Name = "pnlSystemPanel"
        Me.pnlSystemPanel.Size = New System.Drawing.Size(252, 293)
        Me.pnlSystemPanel.TabIndex = 7
        '
        'lblLoggedInUser
        '
        Me.lblLoggedInUser.AutoSize = True
        Me.lblLoggedInUser.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoggedInUser.Location = New System.Drawing.Point(3, 115)
        Me.lblLoggedInUser.Name = "lblLoggedInUser"
        Me.lblLoggedInUser.Size = New System.Drawing.Size(99, 18)
        Me.lblLoggedInUser.TabIndex = 6
        Me.lblLoggedInUser.Text = "Logged in user:"
        '
        'lblOSVersion
        '
        Me.lblOSVersion.AutoSize = True
        Me.lblOSVersion.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSVersion.Location = New System.Drawing.Point(3, 97)
        Me.lblOSVersion.Name = "lblOSVersion"
        Me.lblOSVersion.Size = New System.Drawing.Size(76, 18)
        Me.lblOSVersion.TabIndex = 5
        Me.lblOSVersion.Text = "OS Version:"
        '
        'lblOperatingSystem
        '
        Me.lblOperatingSystem.AutoSize = True
        Me.lblOperatingSystem.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperatingSystem.Location = New System.Drawing.Point(3, 79)
        Me.lblOperatingSystem.Name = "lblOperatingSystem"
        Me.lblOperatingSystem.Size = New System.Drawing.Size(29, 18)
        Me.lblOperatingSystem.TabIndex = 4
        Me.lblOperatingSystem.Text = "OS:"
        '
        'imgSystem
        '
        Me.imgSystem.Image = Global.Dashy.My.Resources.Resources._1404236744_kservices
        Me.imgSystem.Location = New System.Drawing.Point(3, 3)
        Me.imgSystem.Name = "imgSystem"
        Me.imgSystem.Size = New System.Drawing.Size(64, 64)
        Me.imgSystem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgSystem.TabIndex = 2
        Me.imgSystem.TabStop = False
        '
        'lblSystem
        '
        Me.lblSystem.AutoSize = True
        Me.lblSystem.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystem.Location = New System.Drawing.Point(70, 18)
        Me.lblSystem.Name = "lblSystem"
        Me.lblSystem.Size = New System.Drawing.Size(76, 27)
        Me.lblSystem.TabIndex = 3
        Me.lblSystem.Text = "System"
        '
        'pnlNetworkPanel
        '
        Me.pnlNetworkPanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlNetworkPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlNetworkPanel.Controls.Add(Me.lblInternetConnection)
        Me.pnlNetworkPanel.Controls.Add(Me.lblNetworkConnected)
        Me.pnlNetworkPanel.Controls.Add(Me.imgNetwork)
        Me.pnlNetworkPanel.Controls.Add(Me.lblNetwork)
        Me.pnlNetworkPanel.Location = New System.Drawing.Point(1044, 92)
        Me.pnlNetworkPanel.Name = "pnlNetworkPanel"
        Me.pnlNetworkPanel.Size = New System.Drawing.Size(252, 293)
        Me.pnlNetworkPanel.TabIndex = 8
        '
        'lblInternetConnection
        '
        Me.lblInternetConnection.AutoSize = True
        Me.lblInternetConnection.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInternetConnection.Location = New System.Drawing.Point(3, 97)
        Me.lblInternetConnection.Name = "lblInternetConnection"
        Me.lblInternetConnection.Size = New System.Drawing.Size(154, 18)
        Me.lblInternetConnection.TabIndex = 5
        Me.lblInternetConnection.Text = "Internet connection: N/A"
        '
        'lblNetworkConnected
        '
        Me.lblNetworkConnected.AutoSize = True
        Me.lblNetworkConnected.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetworkConnected.Location = New System.Drawing.Point(3, 79)
        Me.lblNetworkConnected.Name = "lblNetworkConnected"
        Me.lblNetworkConnected.Size = New System.Drawing.Size(168, 18)
        Me.lblNetworkConnected.TabIndex = 4
        Me.lblNetworkConnected.Text = "Connected to network: N/A"
        '
        'imgNetwork
        '
        Me.imgNetwork.Image = Global.Dashy.My.Resources.Resources._1404314626_Globe
        Me.imgNetwork.Location = New System.Drawing.Point(3, 3)
        Me.imgNetwork.Name = "imgNetwork"
        Me.imgNetwork.Size = New System.Drawing.Size(64, 64)
        Me.imgNetwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgNetwork.TabIndex = 2
        Me.imgNetwork.TabStop = False
        '
        'lblNetwork
        '
        Me.lblNetwork.AutoSize = True
        Me.lblNetwork.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetwork.Location = New System.Drawing.Point(70, 18)
        Me.lblNetwork.Name = "lblNetwork"
        Me.lblNetwork.Size = New System.Drawing.Size(91, 27)
        Me.lblNetwork.TabIndex = 3
        Me.lblNetwork.Text = "Network"
        '
        'Monitor_Network
        '
        Me.Monitor_Network.Interval = 1000
        '
        'KeyChecker
        '
        Me.KeyChecker.Interval = 1000
        '
        'Dashy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 414)
        Me.Controls.Add(Me.pnlNetworkPanel)
        Me.Controls.Add(Me.pnlSystemPanel)
        Me.Controls.Add(Me.pnlHardwarePanel)
        Me.Controls.Add(Me.pnlPerformancePanel)
        Me.Controls.Add(Me.pnlFileSystemPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Dashy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashy"
        Me.pnlFileSystemPanel.ResumeLayout(False)
        Me.pnlFileSystemPanel.PerformLayout()
        CType(Me.imgHarddrive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPerformancePanel.ResumeLayout(False)
        Me.pnlPerformancePanel.PerformLayout()
        CType(Me.imgPerformance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHardwarePanel.ResumeLayout(False)
        Me.pnlHardwarePanel.PerformLayout()
        CType(Me.imgHardware, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSystemPanel.ResumeLayout(False)
        Me.pnlSystemPanel.PerformLayout()
        CType(Me.imgSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNetworkPanel.ResumeLayout(False)
        Me.pnlNetworkPanel.PerformLayout()
        CType(Me.imgNetwork, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgHarddrive As System.Windows.Forms.PictureBox
    Friend WithEvents pnlFileSystemPanel As System.Windows.Forms.Panel
    Friend WithEvents pnlPerformancePanel As System.Windows.Forms.Panel
    Friend WithEvents lbltotalphysicalmem As System.Windows.Forms.Label
    Friend WithEvents lbltotalvirtualmem As System.Windows.Forms.Label
    Friend WithEvents lblavailphysicalmem As System.Windows.Forms.Label
    Friend WithEvents lblavailvirtualmem As System.Windows.Forms.Label
    Friend WithEvents imgPerformance As System.Windows.Forms.PictureBox
    Friend WithEvents lblPerformance As System.Windows.Forms.Label
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocumentationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutDashyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlHardwarePanel As System.Windows.Forms.Panel
    Friend WithEvents lblArch As System.Windows.Forms.Label
    Friend WithEvents imgHardware As System.Windows.Forms.PictureBox
    Friend WithEvents lblHardware As System.Windows.Forms.Label
    Friend WithEvents Monitor_Performance As System.Windows.Forms.Timer
    Friend WithEvents lblFileSystem As System.Windows.Forms.Label
    Friend WithEvents lblListofDrives As System.Windows.Forms.Label
    Friend WithEvents Monitor_FileSystem As System.Windows.Forms.Timer
    Friend WithEvents lblNumberofDrives As System.Windows.Forms.Label
    Friend WithEvents cbListofDrivesValue As System.Windows.Forms.ComboBox
    Friend WithEvents pnlSystemPanel As System.Windows.Forms.Panel
    Friend WithEvents lblOperatingSystem As System.Windows.Forms.Label
    Friend WithEvents imgSystem As System.Windows.Forms.PictureBox
    Friend WithEvents lblSystem As System.Windows.Forms.Label
    Friend WithEvents lblOSVersion As System.Windows.Forms.Label
    Friend WithEvents lblProgramFilesDirectoryValue As System.Windows.Forms.Label
    Friend WithEvents lblProgramFilesDirectory As System.Windows.Forms.Label
    Friend WithEvents lblProcessors As System.Windows.Forms.Label
    Friend WithEvents lblLoggedInUser As System.Windows.Forms.Label
    Friend WithEvents pnlNetworkPanel As System.Windows.Forms.Panel
    Friend WithEvents lblInternetConnection As System.Windows.Forms.Label
    Friend WithEvents lblNetworkConnected As System.Windows.Forms.Label
    Friend WithEvents imgNetwork As System.Windows.Forms.PictureBox
    Friend WithEvents lblNetwork As System.Windows.Forms.Label
    Friend WithEvents Monitor_Network As System.Windows.Forms.Timer
    Friend WithEvents KeyChecker As System.Windows.Forms.Timer
    Friend WithEvents lblHomePathValue As System.Windows.Forms.Label
    Friend WithEvents lblHomePath As System.Windows.Forms.Label

End Class
