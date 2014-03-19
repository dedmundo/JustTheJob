<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerListForm
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
        Me.btnCLBack = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstName = New System.Windows.Forms.ListBox()
        Me.lstAddress = New System.Windows.Forms.ListBox()
        Me.lstPhone = New System.Windows.Forms.ListBox()
        Me.lstEmail = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCLBack
        '
        Me.btnCLBack.Location = New System.Drawing.Point(545, 324)
        Me.btnCLBack.Name = "btnCLBack"
        Me.btnCLBack.Size = New System.Drawing.Size(103, 23)
        Me.btnCLBack.TabIndex = 7
        Me.btnCLBack.Text = "&Back"
        Me.btnCLBack.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(660, 24)
        Me.MenuStrip1.TabIndex = 9
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
        Me.Label1.Location = New System.Drawing.Point(69, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Name"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(223, 38)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(59, 16)
        Me.label10.TabIndex = 11
        Me.label10.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(374, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Phone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(542, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Email"
        '
        'lstName
        '
        Me.lstName.FormattingEnabled = True
        Me.lstName.Location = New System.Drawing.Point(12, 57)
        Me.lstName.Name = "lstName"
        Me.lstName.Size = New System.Drawing.Size(155, 251)
        Me.lstName.TabIndex = 14
        '
        'lstAddress
        '
        Me.lstAddress.FormattingEnabled = True
        Me.lstAddress.Location = New System.Drawing.Point(173, 57)
        Me.lstAddress.Name = "lstAddress"
        Me.lstAddress.Size = New System.Drawing.Size(160, 251)
        Me.lstAddress.TabIndex = 15
        '
        'lstPhone
        '
        Me.lstPhone.FormattingEnabled = True
        Me.lstPhone.Location = New System.Drawing.Point(339, 57)
        Me.lstPhone.Name = "lstPhone"
        Me.lstPhone.Size = New System.Drawing.Size(120, 251)
        Me.lstPhone.TabIndex = 16
        '
        'lstEmail
        '
        Me.lstEmail.FormattingEnabled = True
        Me.lstEmail.Location = New System.Drawing.Point(465, 57)
        Me.lstEmail.Name = "lstEmail"
        Me.lstEmail.Size = New System.Drawing.Size(183, 251)
        Me.lstEmail.TabIndex = 17
        '
        'CustomerListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 358)
        Me.Controls.Add(Me.lstEmail)
        Me.Controls.Add(Me.lstPhone)
        Me.Controls.Add(Me.lstAddress)
        Me.Controls.Add(Me.lstName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCLBack)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CustomerListForm"
        Me.Text = "List of Customers"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCLBack As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstName As System.Windows.Forms.ListBox
    Friend WithEvents lstAddress As System.Windows.Forms.ListBox
    Friend WithEvents lstPhone As System.Windows.Forms.ListBox
    Friend WithEvents lstEmail As System.Windows.Forms.ListBox
End Class
