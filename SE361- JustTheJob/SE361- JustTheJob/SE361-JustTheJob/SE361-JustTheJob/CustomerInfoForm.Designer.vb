<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerInfoForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCIBack = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCIEmail = New System.Windows.Forms.Label()
        Me.lblCIPhone = New System.Windows.Forms.Label()
        Me.lblCIAddress = New System.Windows.Forms.Label()
        Me.lblCIName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnCIDelete = New System.Windows.Forms.Button()
        Me.lblCIHeading = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(536, 24)
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
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.BackToolStripMenuItem.Text = "&Back"
        '
        'btnCIBack
        '
        Me.btnCIBack.Location = New System.Drawing.Point(428, 274)
        Me.btnCIBack.Name = "btnCIBack"
        Me.btnCIBack.Size = New System.Drawing.Size(96, 23)
        Me.btnCIBack.TabIndex = 10
        Me.btnCIBack.Text = "&Back"
        Me.btnCIBack.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCIEmail)
        Me.GroupBox1.Controls.Add(Me.lblCIPhone)
        Me.GroupBox1.Controls.Add(Me.lblCIAddress)
        Me.GroupBox1.Controls.Add(Me.lblCIName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Location = New System.Drawing.Point(13, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 176)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contact Info"
        '
        'lblCIEmail
        '
        Me.lblCIEmail.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCIEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCIEmail.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCIEmail.Location = New System.Drawing.Point(269, 128)
        Me.lblCIEmail.Name = "lblCIEmail"
        Me.lblCIEmail.Size = New System.Drawing.Size(206, 23)
        Me.lblCIEmail.TabIndex = 18
        Me.lblCIEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCIPhone
        '
        Me.lblCIPhone.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCIPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCIPhone.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCIPhone.Location = New System.Drawing.Point(293, 96)
        Me.lblCIPhone.Name = "lblCIPhone"
        Me.lblCIPhone.Size = New System.Drawing.Size(182, 23)
        Me.lblCIPhone.TabIndex = 17
        Me.lblCIPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCIAddress
        '
        Me.lblCIAddress.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCIAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCIAddress.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCIAddress.Location = New System.Drawing.Point(266, 63)
        Me.lblCIAddress.Name = "lblCIAddress"
        Me.lblCIAddress.Size = New System.Drawing.Size(209, 23)
        Me.lblCIAddress.TabIndex = 16
        Me.lblCIAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCIName
        '
        Me.lblCIName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCIName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCIName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCIName.Location = New System.Drawing.Point(293, 29)
        Me.lblCIName.Name = "lblCIName"
        Me.lblCIName.Size = New System.Drawing.Size(182, 23)
        Me.lblCIName.TabIndex = 15
        Me.lblCIName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(6, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(6, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(7, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Address:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(7, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(319, 274)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(103, 23)
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnCIDelete
        '
        Me.btnCIDelete.Location = New System.Drawing.Point(22, 271)
        Me.btnCIDelete.Name = "btnCIDelete"
        Me.btnCIDelete.Size = New System.Drawing.Size(103, 23)
        Me.btnCIDelete.TabIndex = 16
        Me.btnCIDelete.Text = "&Delete Customer"
        Me.btnCIDelete.UseVisualStyleBackColor = True
        '
        'lblCIHeading
        '
        Me.lblCIHeading.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCIHeading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCIHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCIHeading.Location = New System.Drawing.Point(148, 54)
        Me.lblCIHeading.Name = "lblCIHeading"
        Me.lblCIHeading.Size = New System.Drawing.Size(260, 23)
        Me.lblCIHeading.TabIndex = 18
        Me.lblCIHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(157, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(236, 25)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Invoice Information For:"
        '
        'CustomerInfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 306)
        Me.Controls.Add(Me.lblCIHeading)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCIDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCIBack)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "CustomerInfoForm"
        Me.Text = "Customer Information"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCIBack As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCIEmail As System.Windows.Forms.Label
    Friend WithEvents lblCIPhone As System.Windows.Forms.Label
    Friend WithEvents lblCIAddress As System.Windows.Forms.Label
    Friend WithEvents lblCIName As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnCIDelete As System.Windows.Forms.Button
    Friend WithEvents lblCIHeading As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
