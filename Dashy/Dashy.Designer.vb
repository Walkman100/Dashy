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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DashyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizeToTrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitDashyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblDashy = New System.Windows.Forms.Label()
        Me.imgHarddrive = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblavailvirtualmem = New System.Windows.Forms.Label()
        Me.imgPerformance = New System.Windows.Forms.PictureBox()
        Me.lblPerformance = New System.Windows.Forms.Label()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutDashyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblArch = New System.Windows.Forms.Label()
        Me.imgHardware = New System.Windows.Forms.PictureBox()
        Me.lblHardware = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Monitor_Performance = New System.Windows.Forms.Timer(Me.components)
        Me.lblavailphysicalmem = New System.Windows.Forms.Label()
        Me.lbltotalvirtualmem = New System.Windows.Forms.Label()
        Me.lbltotalphysicalmem = New System.Windows.Forms.Label()
        Me.lblFileSystem = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Monitor_FileSystem = New System.Windows.Forms.Timer(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.imgHarddrive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.imgPerformance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.imgHardware, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashyToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(907, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DashyToolStripMenuItem
        '
        Me.DashyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MinimizeToTrayToolStripMenuItem, Me.QuitDashyToolStripMenuItem})
        Me.DashyToolStripMenuItem.Name = "DashyToolStripMenuItem"
        Me.DashyToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.DashyToolStripMenuItem.Text = "&Dashy"
        '
        'MinimizeToTrayToolStripMenuItem
        '
        Me.MinimizeToTrayToolStripMenuItem.Name = "MinimizeToTrayToolStripMenuItem"
        Me.MinimizeToTrayToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.MinimizeToTrayToolStripMenuItem.Text = "&Minimize to tray"
        '
        'QuitDashyToolStripMenuItem
        '
        Me.QuitDashyToolStripMenuItem.Name = "QuitDashyToolStripMenuItem"
        Me.QuitDashyToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.QuitDashyToolStripMenuItem.Text = "&Quit Dashy"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 532)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(907, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblDashy
        '
        Me.lblDashy.AutoSize = True
        Me.lblDashy.Font = New System.Drawing.Font("Trebuchet MS", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashy.Location = New System.Drawing.Point(12, 24)
        Me.lblDashy.Name = "lblDashy"
        Me.lblDashy.Size = New System.Drawing.Size(115, 46)
        Me.lblDashy.TabIndex = 0
        Me.lblDashy.Text = "Dashy"
        '
        'imgHarddrive
        '
        Me.imgHarddrive.Image = Global.Dashy.My.Resources.Resources._1404236756_harddrive
        Me.imgHarddrive.Location = New System.Drawing.Point(3, 3)
        Me.imgHarddrive.Name = "imgHarddrive"
        Me.imgHarddrive.Size = New System.Drawing.Size(64, 64)
        Me.imgHarddrive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgHarddrive.TabIndex = 2
        Me.imgHarddrive.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblFileSystem)
        Me.Panel1.Controls.Add(Me.imgHarddrive)
        Me.Panel1.Location = New System.Drawing.Point(12, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(252, 293)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.lbltotalphysicalmem)
        Me.Panel2.Controls.Add(Me.lbltotalvirtualmem)
        Me.Panel2.Controls.Add(Me.lblavailphysicalmem)
        Me.Panel2.Controls.Add(Me.lblavailvirtualmem)
        Me.Panel2.Controls.Add(Me.imgPerformance)
        Me.Panel2.Controls.Add(Me.lblPerformance)
        Me.Panel2.Location = New System.Drawing.Point(270, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(252, 293)
        Me.Panel2.TabIndex = 5
        '
        'lblavailvirtualmem
        '
        Me.lblavailvirtualmem.AutoSize = True
        Me.lblavailvirtualmem.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblavailvirtualmem.Location = New System.Drawing.Point(3, 79)
        Me.lblavailvirtualmem.Name = "lblavailvirtualmem"
        Me.lblavailvirtualmem.Size = New System.Drawing.Size(158, 18)
        Me.lblavailvirtualmem.TabIndex = 4
        Me.lblavailvirtualmem.Text = "Available virtual memory:"
        '
        'imgPerformance
        '
        Me.imgPerformance.Image = Global.Dashy.My.Resources.Resources._1404236737_daemons
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
        Me.lblPerformance.Size = New System.Drawing.Size(130, 27)
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
        Me.DocumentationToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.DocumentationToolStripMenuItem.Text = "&Documentation"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "&Check for updates"
        '
        'AboutDashyToolStripMenuItem
        '
        Me.AboutDashyToolStripMenuItem.Name = "AboutDashyToolStripMenuItem"
        Me.AboutDashyToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AboutDashyToolStripMenuItem.Text = "&About Dashy"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Controls.Add(Me.lblArch)
        Me.Panel3.Controls.Add(Me.imgHardware)
        Me.Panel3.Controls.Add(Me.lblHardware)
        Me.Panel3.Location = New System.Drawing.Point(528, 88)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(252, 293)
        Me.Panel3.TabIndex = 6
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
        Me.imgHardware.Image = Global.Dashy.My.Resources.Resources._1404236747_package_utilities
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Monitoring everything"
        '
        'Monitor_Performance
        '
        '
        'lblavailphysicalmem
        '
        Me.lblavailphysicalmem.AutoSize = True
        Me.lblavailphysicalmem.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblavailphysicalmem.Location = New System.Drawing.Point(3, 95)
        Me.lblavailphysicalmem.Name = "lblavailphysicalmem"
        Me.lblavailphysicalmem.Size = New System.Drawing.Size(166, 18)
        Me.lblavailphysicalmem.TabIndex = 5
        Me.lblavailphysicalmem.Text = "Available physical memory:"
        '
        'lbltotalvirtualmem
        '
        Me.lbltotalvirtualmem.AutoSize = True
        Me.lbltotalvirtualmem.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalvirtualmem.Location = New System.Drawing.Point(3, 111)
        Me.lbltotalvirtualmem.Name = "lbltotalvirtualmem"
        Me.lbltotalvirtualmem.Size = New System.Drawing.Size(134, 18)
        Me.lbltotalvirtualmem.TabIndex = 6
        Me.lbltotalvirtualmem.Text = "Total virtual memory:"
        '
        'lbltotalphysicalmem
        '
        Me.lbltotalphysicalmem.AutoSize = True
        Me.lbltotalphysicalmem.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalphysicalmem.Location = New System.Drawing.Point(3, 127)
        Me.lbltotalphysicalmem.Name = "lbltotalphysicalmem"
        Me.lbltotalphysicalmem.Size = New System.Drawing.Size(142, 18)
        Me.lbltotalphysicalmem.TabIndex = 7
        Me.lbltotalphysicalmem.Text = "Total physical memory:"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "List of drives:"
        '
        'Monitor_FileSystem
        '
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(94, 78)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(155, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "No. of drives:"
        '
        'Dashy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 554)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblDashy)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Dashy"
        Me.Text = "Dashy"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.imgHarddrive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.imgPerformance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.imgHardware, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents DashyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MinimizeToTrayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitDashyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblDashy As System.Windows.Forms.Label
    Friend WithEvents imgHarddrive As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
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
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblArch As System.Windows.Forms.Label
    Friend WithEvents imgHardware As System.Windows.Forms.PictureBox
    Friend WithEvents lblHardware As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Monitor_Performance As System.Windows.Forms.Timer
    Friend WithEvents lblFileSystem As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Monitor_FileSystem As System.Windows.Forms.Timer
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
