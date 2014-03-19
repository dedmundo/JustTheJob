<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeListForm
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
        Me.btnNLBack = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstName = New System.Windows.Forms.ListBox()
        Me.lstPhone = New System.Windows.Forms.ListBox()
        Me.lstPosition = New System.Windows.Forms.ListBox()
        Me.lstWages = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNLBack
        '
        Me.btnNLBack.Location = New System.Drawing.Point(489, 415)
        Me.btnNLBack.Name = "btnNLBack"
        Me.btnNLBack.Size = New System.Drawing.Size(103, 23)
        Me.btnNLBack.TabIndex = 7
        Me.btnNLBack.Text = "&Back"
        Me.btnNLBack.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(607, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BackToolStripMenuItem.Text = "&Back"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(181, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(265, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Just-The-Job's Employees"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(228, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Cell Phone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(519, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Wages"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(364, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Job Position"
        '
        'lstName
        '
        Me.lstName.FormattingEnabled = True
        Me.lstName.Location = New System.Drawing.Point(12, 89)
        Me.lstName.Name = "lstName"
        Me.lstName.Size = New System.Drawing.Size(176, 303)
        Me.lstName.TabIndex = 17
        '
        'lstPhone
        '
        Me.lstPhone.FormattingEnabled = True
        Me.lstPhone.Location = New System.Drawing.Point(205, 89)
        Me.lstPhone.Name = "lstPhone"
        Me.lstPhone.Size = New System.Drawing.Size(119, 303)
        Me.lstPhone.TabIndex = 18
        '
        'lstPosition
        '
        Me.lstPosition.FormattingEnabled = True
        Me.lstPosition.Location = New System.Drawing.Point(339, 89)
        Me.lstPosition.Name = "lstPosition"
        Me.lstPosition.Size = New System.Drawing.Size(142, 303)
        Me.lstPosition.TabIndex = 19
        '
        'lstWages
        '
        Me.lstWages.FormattingEnabled = True
        Me.lstWages.Location = New System.Drawing.Point(496, 89)
        Me.lstWages.Name = "lstWages"
        Me.lstWages.Size = New System.Drawing.Size(96, 303)
        Me.lstWages.TabIndex = 20
        '
        'EmployeeListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 453)
        Me.Controls.Add(Me.lstWages)
        Me.Controls.Add(Me.lstPosition)
        Me.Controls.Add(Me.lstPhone)
        Me.Controls.Add(Me.lstName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnNLBack)
        Me.Name = "EmployeeListForm"
        Me.Text = "List of Employees"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNLBack As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lstName As System.Windows.Forms.ListBox
    Friend WithEvents lstPhone As System.Windows.Forms.ListBox
    Friend WithEvents lstPosition As System.Windows.Forms.ListBox
    Friend WithEvents lstWages As System.Windows.Forms.ListBox
End Class
