<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBorrow
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbBooks = New System.Windows.Forms.ComboBox()
        Me.cmbMembers = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpBorrow = New System.Windows.Forms.DateTimePicker()
        Me.dtpDue = New System.Windows.Forms.DateTimePicker()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Book:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select Member:"
        '
        'cmbBooks
        '
        Me.cmbBooks.FormattingEnabled = True
        Me.cmbBooks.Location = New System.Drawing.Point(157, 0)
        Me.cmbBooks.Name = "cmbBooks"
        Me.cmbBooks.Size = New System.Drawing.Size(121, 28)
        Me.cmbBooks.TabIndex = 2
        '
        'cmbMembers
        '
        Me.cmbMembers.FormattingEnabled = True
        Me.cmbMembers.Location = New System.Drawing.Point(157, 69)
        Me.cmbMembers.Name = "cmbMembers"
        Me.cmbMembers.Size = New System.Drawing.Size(121, 28)
        Me.cmbMembers.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Due Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Borrow Date:"
        '
        'dtpBorrow
        '
        Me.dtpBorrow.Location = New System.Drawing.Point(157, 133)
        Me.dtpBorrow.Name = "dtpBorrow"
        Me.dtpBorrow.Size = New System.Drawing.Size(200, 26)
        Me.dtpBorrow.TabIndex = 6
        '
        'dtpDue
        '
        Me.dtpDue.Location = New System.Drawing.Point(157, 195)
        Me.dtpDue.Name = "dtpDue"
        Me.dtpDue.Size = New System.Drawing.Size(200, 26)
        Me.dtpDue.TabIndex = 7
        '
        'btnBorrow
        '
        Me.btnBorrow.Location = New System.Drawing.Point(4, 244)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(150, 35)
        Me.btnBorrow.TabIndex = 8
        Me.btnBorrow.Text = "Borrow Book"
        Me.btnBorrow.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(4, 292)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(150, 35)
        Me.btnReturn.TabIndex = 9
        Me.btnReturn.Text = "Return Book"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'FormBorrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 344)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnBorrow)
        Me.Controls.Add(Me.dtpDue)
        Me.Controls.Add(Me.dtpBorrow)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbMembers)
        Me.Controls.Add(Me.cmbBooks)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormBorrow"
        Me.Text = "Borrow/Return Books"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbBooks As ComboBox
    Friend WithEvents cmbMembers As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpBorrow As DateTimePicker
    Friend WithEvents dtpDue As DateTimePicker
    Friend WithEvents btnBorrow As Button
    Friend WithEvents btnReturn As Button
End Class
