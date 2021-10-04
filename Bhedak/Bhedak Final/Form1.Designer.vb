<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.btnToolBox = New System.Windows.Forms.Button()
        Me.btnCleanUp = New System.Windows.Forms.Button()
        Me.btnSpeedUp = New System.Windows.Forms.Button()
        Me.btnVirusScan = New System.Windows.Forms.Button()
        Me.btnFull_Check = New System.Windows.Forms.Button()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.SmallPanel = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTrialVersion = New System.Windows.Forms.Button()
        Me.btnPreium = New System.Windows.Forms.Button()
        Me.btnQuickScan = New System.Windows.Forms.Button()
        Me.lblSmart = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Close1 = New Smart_Protector_2019.close()
        Me.Full_check1 = New Smart_Protector_2019.full_check()
        Me.Scan1 = New Smart_Protector_2019.scan()
        Me.Speedup1 = New Smart_Protector_2019.speedup()
        Me.Settings1 = New Smart_Protector_2019.settings()
        Me.Cleanup1 = New Smart_Protector_2019.cleanup()
        Me.Welcome1 = New Smart_Protector_2019.welcome()
        Me.SidePanel.SuspendLayout()
        Me.HeaderPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.Blue
        Me.SidePanel.Controls.Add(Me.btnToolBox)
        Me.SidePanel.Controls.Add(Me.btnCleanUp)
        Me.SidePanel.Controls.Add(Me.btnSpeedUp)
        Me.SidePanel.Controls.Add(Me.btnVirusScan)
        Me.SidePanel.Controls.Add(Me.btnFull_Check)
        Me.SidePanel.Location = New System.Drawing.Point(0, 146)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(210, 350)
        Me.SidePanel.TabIndex = 0
        '
        'btnToolBox
        '
        Me.btnToolBox.BackColor = System.Drawing.Color.DarkBlue
        Me.btnToolBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnToolBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnToolBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToolBox.ForeColor = System.Drawing.Color.White
        Me.btnToolBox.Image = Global.Smart_Protector_2019.My.Resources.Resources.full_tool_storage_box__filled_50px
        Me.btnToolBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnToolBox.Location = New System.Drawing.Point(-3, 280)
        Me.btnToolBox.Name = "btnToolBox"
        Me.btnToolBox.Size = New System.Drawing.Size(223, 57)
        Me.btnToolBox.TabIndex = 4
        Me.btnToolBox.Text = "            ToolBox"
        Me.btnToolBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnToolBox.UseVisualStyleBackColor = False
        '
        'btnCleanUp
        '
        Me.btnCleanUp.BackColor = System.Drawing.Color.DarkBlue
        Me.btnCleanUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCleanUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCleanUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCleanUp.ForeColor = System.Drawing.Color.White
        Me.btnCleanUp.Image = Global.Smart_Protector_2019.My.Resources.Resources.waste_filled_50px
        Me.btnCleanUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCleanUp.Location = New System.Drawing.Point(-2, 212)
        Me.btnCleanUp.Name = "btnCleanUp"
        Me.btnCleanUp.Size = New System.Drawing.Size(223, 57)
        Me.btnCleanUp.TabIndex = 3
        Me.btnCleanUp.Text = "            CleanUp"
        Me.btnCleanUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCleanUp.UseVisualStyleBackColor = False
        '
        'btnSpeedUp
        '
        Me.btnSpeedUp.BackColor = System.Drawing.Color.DarkBlue
        Me.btnSpeedUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSpeedUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSpeedUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpeedUp.ForeColor = System.Drawing.Color.White
        Me.btnSpeedUp.Image = Global.Smart_Protector_2019.My.Resources.Resources.running_filled_50px
        Me.btnSpeedUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSpeedUp.Location = New System.Drawing.Point(-2, 144)
        Me.btnSpeedUp.Name = "btnSpeedUp"
        Me.btnSpeedUp.Size = New System.Drawing.Size(223, 57)
        Me.btnSpeedUp.TabIndex = 2
        Me.btnSpeedUp.Text = "            SpeedUp"
        Me.btnSpeedUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSpeedUp.UseVisualStyleBackColor = False
        '
        'btnVirusScan
        '
        Me.btnVirusScan.BackColor = System.Drawing.Color.DarkBlue
        Me.btnVirusScan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVirusScan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVirusScan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVirusScan.ForeColor = System.Drawing.Color.White
        Me.btnVirusScan.Image = Global.Smart_Protector_2019.My.Resources.Resources.antivirus_scanner_filled_50px
        Me.btnVirusScan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVirusScan.Location = New System.Drawing.Point(-1, 78)
        Me.btnVirusScan.Name = "btnVirusScan"
        Me.btnVirusScan.Size = New System.Drawing.Size(223, 57)
        Me.btnVirusScan.TabIndex = 1
        Me.btnVirusScan.Text = "            Virus Scan"
        Me.btnVirusScan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVirusScan.UseVisualStyleBackColor = False
        '
        'btnFull_Check
        '
        Me.btnFull_Check.BackColor = System.Drawing.Color.DarkBlue
        Me.btnFull_Check.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFull_Check.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFull_Check.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFull_Check.ForeColor = System.Drawing.Color.White
        Me.btnFull_Check.Image = Global.Smart_Protector_2019.My.Resources.Resources.monitor_filled_50px
        Me.btnFull_Check.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFull_Check.Location = New System.Drawing.Point(-4, 12)
        Me.btnFull_Check.Name = "btnFull_Check"
        Me.btnFull_Check.Size = New System.Drawing.Size(217, 57)
        Me.btnFull_Check.TabIndex = 0
        Me.btnFull_Check.Text = "            Full Check"
        Me.btnFull_Check.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFull_Check.UseVisualStyleBackColor = False
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.Blue
        Me.HeaderPanel.Controls.Add(Me.SmallPanel)
        Me.HeaderPanel.Controls.Add(Me.Label5)
        Me.HeaderPanel.Controls.Add(Me.Label4)
        Me.HeaderPanel.Controls.Add(Me.Label3)
        Me.HeaderPanel.Controls.Add(Me.btnTrialVersion)
        Me.HeaderPanel.Controls.Add(Me.btnPreium)
        Me.HeaderPanel.Controls.Add(Me.btnQuickScan)
        Me.HeaderPanel.Controls.Add(Me.lblSmart)
        Me.HeaderPanel.Controls.Add(Me.Label2)
        Me.HeaderPanel.Location = New System.Drawing.Point(4, 29)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(799, 111)
        Me.HeaderPanel.TabIndex = 1
        '
        'SmallPanel
        '
        Me.SmallPanel.BackColor = System.Drawing.Color.Blue
        Me.SmallPanel.Location = New System.Drawing.Point(-2, 95)
        Me.SmallPanel.Name = "SmallPanel"
        Me.SmallPanel.Size = New System.Drawing.Size(119, 16)
        Me.SmallPanel.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(204, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(199, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Your Computer is Protected"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(123, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "STATUS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(639, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "30 Days Remaining"
        '
        'btnTrialVersion
        '
        Me.btnTrialVersion.BackColor = System.Drawing.Color.Red
        Me.btnTrialVersion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTrialVersion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTrialVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrialVersion.ForeColor = System.Drawing.Color.White
        Me.btnTrialVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTrialVersion.Location = New System.Drawing.Point(261, 46)
        Me.btnTrialVersion.Name = "btnTrialVersion"
        Me.btnTrialVersion.Size = New System.Drawing.Size(125, 34)
        Me.btnTrialVersion.TabIndex = 7
        Me.btnTrialVersion.Text = "TRIAL VERSION"
        Me.btnTrialVersion.UseVisualStyleBackColor = False
        '
        'btnPreium
        '
        Me.btnPreium.BackColor = System.Drawing.Color.Green
        Me.btnPreium.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPreium.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPreium.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreium.ForeColor = System.Drawing.Color.White
        Me.btnPreium.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreium.Location = New System.Drawing.Point(118, 46)
        Me.btnPreium.Name = "btnPreium"
        Me.btnPreium.Size = New System.Drawing.Size(145, 34)
        Me.btnPreium.TabIndex = 6
        Me.btnPreium.Text = "BUY PREMIUM"
        Me.btnPreium.UseVisualStyleBackColor = False
        '
        'btnQuickScan
        '
        Me.btnQuickScan.BackColor = System.Drawing.Color.Red
        Me.btnQuickScan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuickScan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnQuickScan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuickScan.ForeColor = System.Drawing.Color.White
        Me.btnQuickScan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuickScan.Location = New System.Drawing.Point(670, 6)
        Me.btnQuickScan.Name = "btnQuickScan"
        Me.btnQuickScan.Size = New System.Drawing.Size(133, 41)
        Me.btnQuickScan.TabIndex = 5
        Me.btnQuickScan.Text = "QUICK SCAN"
        Me.btnQuickScan.UseVisualStyleBackColor = False
        '
        'lblSmart
        '
        Me.lblSmart.AutoSize = True
        Me.lblSmart.BackColor = System.Drawing.Color.Red
        Me.lblSmart.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSmart.ForeColor = System.Drawing.Color.White
        Me.lblSmart.Location = New System.Drawing.Point(116, 0)
        Me.lblSmart.Name = "lblSmart"
        Me.lblSmart.Size = New System.Drawing.Size(134, 45)
        Me.lblSmart.TabIndex = 0
        Me.lblSmart.Text = "Bhedak"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(255, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(409, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PROTECTOR, BY Jesal, Ashank,Sayan and Maharshi"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.Full_check1)
        Me.Panel3.Controls.Add(Me.Scan1)
        Me.Panel3.Controls.Add(Me.Speedup1)
        Me.Panel3.Controls.Add(Me.Settings1)
        Me.Panel3.Controls.Add(Me.Cleanup1)
        Me.Panel3.Controls.Add(Me.Welcome1)
        Me.Panel3.Location = New System.Drawing.Point(210, 146)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(592, 350)
        Me.Panel3.TabIndex = 8
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 10
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(4, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(221, 19)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Team 16 Anti Virus Software" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Image = Global.Smart_Protector_2019.My.Resources.Resources.manager_filled_50px
        Me.PictureBox6.Location = New System.Drawing.Point(669, 5)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 7
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = Global.Smart_Protector_2019.My.Resources.Resources.menu_filled_50px
        Me.PictureBox5.Location = New System.Drawing.Point(697, 5)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 6
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.Smart_Protector_2019.My.Resources.Resources.minus_50px
        Me.PictureBox4.Location = New System.Drawing.Point(723, 5)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.Smart_Protector_2019.My.Resources.Resources.maximize_window_50px
        Me.PictureBox3.Location = New System.Drawing.Point(748, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Smart_Protector_2019.My.Resources.Resources.cancel_50px
        Me.PictureBox2.Location = New System.Drawing.Point(773, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Smart_Protector_2019.My.Resources.Resources.scanning
        Me.PictureBox1.Location = New System.Drawing.Point(4, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btnTimer
        '
        Me.btnTimer.Enabled = True
        '
        'Close1
        '
        Me.Close1.Location = New System.Drawing.Point(213, 203)
        Me.Close1.Name = "Close1"
        Me.Close1.Size = New System.Drawing.Size(374, 135)
        Me.Close1.TabIndex = 13
        Me.Close1.Visible = False
        '
        'Full_check1
        '
        Me.Full_check1.BackColor = System.Drawing.Color.Black
        Me.Full_check1.Location = New System.Drawing.Point(-2, -8)
        Me.Full_check1.Name = "Full_check1"
        Me.Full_check1.Size = New System.Drawing.Size(592, 350)
        Me.Full_check1.TabIndex = 1
        '
        'Scan1
        '
        Me.Scan1.BackColor = System.Drawing.Color.Black
        Me.Scan1.Location = New System.Drawing.Point(-6, -2)
        Me.Scan1.Name = "Scan1"
        Me.Scan1.Size = New System.Drawing.Size(592, 350)
        Me.Scan1.TabIndex = 2
        '
        'Speedup1
        '
        Me.Speedup1.BackColor = System.Drawing.Color.Black
        Me.Speedup1.Location = New System.Drawing.Point(-5, -2)
        Me.Speedup1.Name = "Speedup1"
        Me.Speedup1.Size = New System.Drawing.Size(592, 350)
        Me.Speedup1.TabIndex = 3
        '
        'Settings1
        '
        Me.Settings1.BackColor = System.Drawing.Color.Black
        Me.Settings1.Location = New System.Drawing.Point(0, 0)
        Me.Settings1.Name = "Settings1"
        Me.Settings1.Size = New System.Drawing.Size(592, 350)
        Me.Settings1.TabIndex = 5
        '
        'Cleanup1
        '
        Me.Cleanup1.BackColor = System.Drawing.Color.Black
        Me.Cleanup1.Location = New System.Drawing.Point(-2, -4)
        Me.Cleanup1.Name = "Cleanup1"
        Me.Cleanup1.Size = New System.Drawing.Size(592, 350)
        Me.Cleanup1.TabIndex = 4
        '
        'Welcome1
        '
        Me.Welcome1.BackColor = System.Drawing.Color.Black
        Me.Welcome1.Location = New System.Drawing.Point(0, -3)
        Me.Welcome1.Name = "Welcome1"
        Me.Welcome1.Size = New System.Drawing.Size(592, 350)
        Me.Welcome1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 491)
        Me.Controls.Add(Me.Close1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SidePanel)
        Me.Controls.Add(Me.HeaderPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Smart Protector 2019"
        Me.SidePanel.ResumeLayout(False)
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SidePanel As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblSmart As System.Windows.Forms.Label
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents btnFull_Check As System.Windows.Forms.Button
    Friend WithEvents btnToolBox As System.Windows.Forms.Button
    Friend WithEvents btnCleanUp As System.Windows.Forms.Button
    Friend WithEvents btnSpeedUp As System.Windows.Forms.Button
    Friend WithEvents btnVirusScan As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnTrialVersion As System.Windows.Forms.Button
    Friend WithEvents btnPreium As System.Windows.Forms.Button
    Friend WithEvents btnQuickScan As System.Windows.Forms.Button
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents SmallPanel As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Welcome1 As Smart_Protector_2019.welcome
    Friend WithEvents Full_check1 As Smart_Protector_2019.full_check
    Friend WithEvents Scan1 As Smart_Protector_2019.scan
    Friend WithEvents Speedup1 As Smart_Protector_2019.speedup
    Friend WithEvents Cleanup1 As Smart_Protector_2019.cleanup
    Friend WithEvents Settings1 As Smart_Protector_2019.settings
    Friend WithEvents Close1 As Smart_Protector_2019.close
    Friend WithEvents btnTimer As System.Windows.Forms.Timer

End Class
