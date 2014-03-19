<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerForm
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
        Me.btnCustShow = New System.Windows.Forms.Button()
        Me.btnCustList = New System.Windows.Forms.Button()
        Me.btnCustAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCustBack = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCustShow)
        Me.GroupBox1.Controls.Add(Me.btnCustList)
        Me.GroupBox1.Controls.Add(Me.btnCustAdd)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Location = New System.Drawing.Point(12, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 145)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "What Would You Like to do?"
        '
        'btnCustShow
        '
        Me.btnCustShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustShow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCustShow.Location = New System.Drawing.Point(28, 92)
        Me.btnCustShow.Name = "btnCustShow"
        Me.btnCustShow.Size = New System.Drawing.Size(147, 26)
        Me.btnCustShow.TabIndex = 3
        Me.btnCustShow.Text = "Show Customer Info"
        Me.btnCustShow.UseVisualStyleBackColor = True
        '
        'btnCustList
        '
        Me.btnCustList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustList.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCustList.Location = New System.Drawing.Point(282, 45)
        Me.btnCustList.Name = "btnCustList"
        Me.btnCustList.Size = New System.Drawing.Size(147, 26)
        Me.btnCustList.TabIndex = 2
        Me.btnCustList.Text = "List of Customers"
        Me.btnCustList.UseVisualStyleBackColor = True
        '
        'btnCustAdd
        '
        Me.btnCustAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCustAdd.Location = New System.Drawing.Point(28, 45)
        Me.btnCustAdd.Name = "btnCustAdd"
        Me.btnCustAdd.Size = New System.Drawing.Size(147, 26)
        Me.btnCustAdd.TabIndex = 0
        Me.btnCustAdd.Text = "Add New Customer"
        Me.btnCustAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(151, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Managing Customers Home"
        '
        'btnCustBack
        '
        Me.btnCustBack.Location = New System.Drawing.Point(512, 201)
        Me.btnCustBack.Name = "btnCustBack"
        Me.btnCustBack.Size = New System.Drawing.Size(96, 23)
        Me.btnCustBack.TabIndex = 2
        Me.btnCustBack.Text = "&Back"
        Me.btnCustBack.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(632, 24)
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
        'CustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 248)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnCustBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CustomerForm"
        Me.Text = "Manage Customers Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCustShow As System.Windows.Forms.Button
    Friend WithEvents btnCustList As System.Windows.Forms.Button
    Friend WithEvents btnCustAdd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCustBack As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
