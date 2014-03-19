<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeesForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEmpShow = New System.Windows.Forms.Button()
        Me.btnEmpList = New System.Windows.Forms.Button()
        Me.btnNewEmployee = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEmpBack = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEmpShow)
        Me.GroupBox1.Controls.Add(Me.btnEmpList)
        Me.GroupBox1.Controls.Add(Me.btnNewEmployee)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(482, 135)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "What Would You Like to do?"
        '
        'btnEmpShow
        '
        Me.btnEmpShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpShow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEmpShow.Location = New System.Drawing.Point(18, 89)
        Me.btnEmpShow.Name = "btnEmpShow"
        Me.btnEmpShow.Size = New System.Drawing.Size(157, 26)
        Me.btnEmpShow.TabIndex = 3
        Me.btnEmpShow.Text = "Show Employee Info"
        Me.btnEmpShow.UseVisualStyleBackColor = True
        '
        'btnEmpList
        '
        Me.btnEmpList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpList.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEmpList.Location = New System.Drawing.Point(282, 45)
        Me.btnEmpList.Name = "btnEmpList"
        Me.btnEmpList.Size = New System.Drawing.Size(151, 26)
        Me.btnEmpList.TabIndex = 2
        Me.btnEmpList.Text = "List of Employees"
        Me.btnEmpList.UseVisualStyleBackColor = True
        '
        'btnNewEmployee
        '
        Me.btnNewEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewEmployee.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNewEmployee.Location = New System.Drawing.Point(18, 45)
        Me.btnNewEmployee.Name = "btnNewEmployee"
        Me.btnNewEmployee.Size = New System.Drawing.Size(157, 26)
        Me.btnNewEmployee.TabIndex = 0
        Me.btnNewEmployee.Text = "Add New Employee"
        Me.btnNewEmployee.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(151, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Managing Employees Form"
        '
        'btnEmpBack
        '
        Me.btnEmpBack.Location = New System.Drawing.Point(520, 176)
        Me.btnEmpBack.Name = "btnEmpBack"
        Me.btnEmpBack.Size = New System.Drawing.Size(103, 23)
        Me.btnEmpBack.TabIndex = 3
        Me.btnEmpBack.Text = "&Back"
        Me.btnEmpBack.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(650, 24)
        Me.MenuStrip1.TabIndex = 8
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
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.BackToolStripMenuItem.Text = "&Back"
        '
        'EmployeesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 227)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnEmpBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "EmployeesForm"
        Me.Text = "Manage Employees Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEmpShow As System.Windows.Forms.Button
    Friend WithEvents btnEmpList As System.Windows.Forms.Button
    Friend WithEvents btnNewEmployee As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEmpBack As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
