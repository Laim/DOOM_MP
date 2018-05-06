<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class doom_Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(doom_Settings))
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.lblDoomDir = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(101, 12)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(187, 20)
        Me.txtDir.TabIndex = 0
        Me.txtDir.Text = "D:\Program Files\Steam\Steam.exe"
        '
        'lblDoomDir
        '
        Me.lblDoomDir.AutoSize = True
        Me.lblDoomDir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDoomDir.Location = New System.Drawing.Point(12, 15)
        Me.lblDoomDir.Name = "lblDoomDir"
        Me.lblDoomDir.Size = New System.Drawing.Size(85, 13)
        Me.lblDoomDir.TabIndex = 1
        Me.lblDoomDir.Text = "Steam Directory:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(101, 38)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(239, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(294, 12)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(46, 20)
        Me.btnFind.TabIndex = 3
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'doom_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(361, 78)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblDoomDir)
        Me.Controls.Add(Me.txtDir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "doom_Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doom_MP - Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDir As TextBox
    Friend WithEvents lblDoomDir As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnFind As Button
End Class
