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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSig = New System.Windows.Forms.Label()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtHash = New System.Windows.Forms.TextBox()
        Me.lblMD5 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(212, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(193, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Bhedak AntiVirus"
        '
        'lblSig
        '
        Me.lblSig.AutoSize = True
        Me.lblSig.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSig.Location = New System.Drawing.Point(153, 34)
        Me.lblSig.Name = "lblSig"
        Me.lblSig.Size = New System.Drawing.Size(303, 21)
        Me.lblSig.TabIndex = 1
        Me.lblSig.Text = "By, Team 16, Jesal Patel, Ashank and Sayan"
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(326, 63)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(264, 20)
        Me.txtFilePath.TabIndex = 2
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(244, 62)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 3
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtHash
        '
        Me.txtHash.Location = New System.Drawing.Point(54, 160)
        Me.txtHash.Name = "txtHash"
        Me.txtHash.Size = New System.Drawing.Size(218, 20)
        Me.txtHash.TabIndex = 4
        '
        'lblMD5
        '
        Me.lblMD5.AutoSize = True
        Me.lblMD5.Location = New System.Drawing.Point(12, 163)
        Me.lblMD5.Name = "lblMD5"
        Me.lblMD5.Size = New System.Drawing.Size(36, 13)
        Me.lblMD5.TabIndex = 5
        Me.lblMD5.Text = "MD5: "
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(12, 104)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(43, 13)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "Status"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(61, 104)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 13)
        Me.lblResult.TabIndex = 7
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Tutorial.My.Resources.Resources._9r1te0pipg041
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(602, 278)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblMD5)
        Me.Controls.Add(Me.txtHash)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtFilePath)
        Me.Controls.Add(Me.lblSig)
        Me.Controls.Add(Me.lblTitle)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Bhedak v0.1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSig As Label
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtHash As TextBox
    Friend WithEvents lblMD5 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
