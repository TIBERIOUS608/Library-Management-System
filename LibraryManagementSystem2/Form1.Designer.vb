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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnBooks = New System.Windows.Forms.Button()
        Me.btnMembers = New System.Windows.Forms.Button()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.grpTheme = New System.Windows.Forms.GroupBox()
        Me.radDark = New System.Windows.Forms.RadioButton()
        Me.radLight = New System.Windows.Forms.RadioButton()
        Me.btnCustomColor = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.grpTheme.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(346, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(570, 33)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Welcome to Library Management System"
        '
        'btnBooks
        '
        Me.btnBooks.Location = New System.Drawing.Point(352, 66)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Size = New System.Drawing.Size(200, 40)
        Me.btnBooks.TabIndex = 1
        Me.btnBooks.Text = "Manage Books"
        Me.btnBooks.UseVisualStyleBackColor = True
        '
        'btnMembers
        '
        Me.btnMembers.Location = New System.Drawing.Point(352, 161)
        Me.btnMembers.Name = "btnMembers"
        Me.btnMembers.Size = New System.Drawing.Size(200, 40)
        Me.btnMembers.TabIndex = 2
        Me.btnMembers.Text = "Manage Members"
        Me.btnMembers.UseVisualStyleBackColor = True
        '
        'btnBorrow
        '
        Me.btnBorrow.Location = New System.Drawing.Point(352, 249)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(200, 40)
        Me.btnBorrow.TabIndex = 3
        Me.btnBorrow.Text = "Borrow/Return Books"
        Me.btnBorrow.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(352, 348)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(200, 40)
        Me.btnReport.TabIndex = 4
        Me.btnReport.Text = "View Overdue Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'grpTheme
        '
        Me.grpTheme.Controls.Add(Me.radDark)
        Me.grpTheme.Controls.Add(Me.radLight)
        Me.grpTheme.Location = New System.Drawing.Point(857, 66)
        Me.grpTheme.Name = "grpTheme"
        Me.grpTheme.Size = New System.Drawing.Size(200, 80)
        Me.grpTheme.TabIndex = 5
        Me.grpTheme.TabStop = False
        Me.grpTheme.Text = "Theme"
        '
        'radDark
        '
        Me.radDark.AutoSize = True
        Me.radDark.Location = New System.Drawing.Point(3, 50)
        Me.radDark.Name = "radDark"
        Me.radDark.Size = New System.Drawing.Size(121, 24)
        Me.radDark.TabIndex = 6
        Me.radDark.TabStop = True
        Me.radDark.Text = "Dark Theme"
        Me.radDark.UseVisualStyleBackColor = True
        '
        'radLight
        '
        Me.radLight.AutoSize = True
        Me.radLight.Location = New System.Drawing.Point(3, 22)
        Me.radLight.Name = "radLight"
        Me.radLight.Size = New System.Drawing.Size(122, 24)
        Me.radLight.TabIndex = 0
        Me.radLight.TabStop = True
        Me.radLight.Text = "Light Theme"
        Me.radLight.UseVisualStyleBackColor = True
        '
        'btnCustomColor
        '
        Me.btnCustomColor.Location = New System.Drawing.Point(857, 166)
        Me.btnCustomColor.Name = "btnCustomColor"
        Me.btnCustomColor.Size = New System.Drawing.Size(120, 30)
        Me.btnCustomColor.TabIndex = 7
        Me.btnCustomColor.Text = "Custom Color"
        Me.btnCustomColor.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.Location = New System.Drawing.Point(12, 6)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(100, 100)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 8
        Me.picLogo.TabStop = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1255, 480)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.btnCustomColor)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.grpTheme)
        Me.Controls.Add(Me.btnBorrow)
        Me.Controls.Add(Me.btnMembers)
        Me.Controls.Add(Me.btnBooks)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library Management System"
        Me.grpTheme.ResumeLayout(False)
        Me.grpTheme.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnBooks As Button
    Friend WithEvents btnMembers As Button
    Friend WithEvents btnBorrow As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents grpTheme As GroupBox
    Friend WithEvents radLight As RadioButton
    Friend WithEvents radDark As RadioButton
    Friend WithEvents btnCustomColor As Button
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
