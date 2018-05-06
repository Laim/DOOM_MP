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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picSNAP = New System.Windows.Forms.PictureBox()
        Me.picSP = New System.Windows.Forms.PictureBox()
        Me.picMP = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblCopy = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnSettings = New System.Windows.Forms.Button()
        CType(Me.picSNAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSNAP
        '
        Me.picSNAP.Image = Global.Doom_MP.My.Resources.Resources.SNAP
        Me.picSNAP.Location = New System.Drawing.Point(361, 313)
        Me.picSNAP.Name = "picSNAP"
        Me.picSNAP.Size = New System.Drawing.Size(150, 150)
        Me.picSNAP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSNAP.TabIndex = 3
        Me.picSNAP.TabStop = False
        '
        'picSP
        '
        Me.picSP.Image = Global.Doom_MP.My.Resources.Resources.SP
        Me.picSP.Location = New System.Drawing.Point(39, 313)
        Me.picSP.Name = "picSP"
        Me.picSP.Size = New System.Drawing.Size(150, 150)
        Me.picSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSP.TabIndex = 2
        Me.picSP.TabStop = False
        '
        'picMP
        '
        Me.picMP.Image = Global.Doom_MP.My.Resources.Resources.MP
        Me.picMP.Location = New System.Drawing.Point(205, 313)
        Me.picMP.Name = "picMP"
        Me.picMP.Size = New System.Drawing.Size(150, 150)
        Me.picMP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMP.TabIndex = 1
        Me.picMP.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.Doom_MP.My.Resources.Resources.Logo_doom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(559, 293)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblCopy
        '
        Me.lblCopy.AutoSize = True
        Me.lblCopy.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCopy.Location = New System.Drawing.Point(36, 473)
        Me.lblCopy.Name = "lblCopy"
        Me.lblCopy.Size = New System.Drawing.Size(339, 13)
        Me.lblCopy.TabIndex = 4
        Me.lblCopy.Text = "This program is not afliated with Bethesda Softworks LLC nor indorsed."
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(36, 494)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(100, 13)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "ubiwarestudios.com"
        '
        'btnSettings
        '
        Me.btnSettings.Location = New System.Drawing.Point(436, 484)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(75, 23)
        Me.btnSettings.TabIndex = 6
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(559, 516)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblCopy)
        Me.Controls.Add(Me.picSNAP)
        Me.Controls.Add(Me.picSP)
        Me.Controls.Add(Me.picMP)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doom MP"
        CType(Me.picSNAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picMP As PictureBox
    Friend WithEvents picSP As PictureBox
    Friend WithEvents picSNAP As PictureBox
    Friend WithEvents lblCopy As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btnSettings As Button
End Class
