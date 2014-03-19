<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoiceInfoForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblIIWeek = New System.Windows.Forms.Label()
        Me.lblIIWeekText = New System.Windows.Forms.Label()
        Me.lblIIAmountPaid = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblIICompleteDate = New System.Windows.Forms.Label()
        Me.lblIIMethod = New System.Windows.Forms.Label()
        Me.lblIIPayment = New System.Windows.Forms.Label()
        Me.lblIIEmployee = New System.Windows.Forms.Label()
        Me.lblIIName = New System.Windows.Forms.Label()
        Me.lblIIType = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblIIHeading = New System.Windows.Forms.Label()
        Me.btnIIBack = New System.Windows.Forms.Button()
        Me.btnIIDelete = New System.Windows.Forms.Button()
        Me.btnIIEdit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(531, 24)
        Me.MenuStrip1.TabIndex = 11
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.lblIIWeek)
        Me.GroupBox1.Controls.Add(Me.lblIIWeekText)
        Me.GroupBox1.Controls.Add(Me.lblIIAmountPaid)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblIICompleteDate)
        Me.GroupBox1.Controls.Add(Me.lblIIMethod)
        Me.GroupBox1.Controls.Add(Me.lblIIPayment)
        Me.GroupBox1.Controls.Add(Me.lblIIEmployee)
        Me.GroupBox1.Controls.Add(Me.lblIIName)
        Me.GroupBox1.Controls.Add(Me.lblIIType)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Location = New System.Drawing.Point(12, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 313)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Provide the Following Information:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(8, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Invoice ID:"
        '
        'lblID
        '
        Me.lblID.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblID.Location = New System.Drawing.Point(402, 23)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(71, 23)
        Me.lblID.TabIndex = 23
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIIWeek
        '
        Me.lblIIWeek.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblIIWeek.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIIWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIIWeek.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIIWeek.Location = New System.Drawing.Point(341, 85)
        Me.lblIIWeek.Name = "lblIIWeek"
        Me.lblIIWeek.Size = New System.Drawing.Size(132, 23)
        Me.lblIIWeek.TabIndex = 22
        Me.lblIIWeek.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIIWeekText
        '
        Me.lblIIWeekText.AutoSize = True
        Me.lblIIWeekText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIIWeekText.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIIWeekText.Location = New System.Drawing.Point(8, 90)
        Me.lblIIWeekText.Name = "lblIIWeekText"
        Me.lblIIWeekText.Size = New System.Drawing.Size(114, 13)
        Me.lblIIWeekText.TabIndex = 21
        Me.lblIIWeekText.Text = "Date (DD/MM/YYYY):"
        '
        'lblIIAmountPaid
        '
        Me.lblIIAmountPaid.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblIIAmountPaid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIIAmountPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIIAmountPaid.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIIAmountPaid.Location = New System.Drawing.Point(402, 214)
        Me.lblIIAmountPaid.Name = "lblIIAmountPaid"
        Me.lblIIAmountPaid.Size = New System.Drawing.Size(71, 23)
        Me.lblIIAmountPaid.TabIndex = 20
        Me.lblIIAmountPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Amount Paid:"
        '
        'lblIICompleteDate
        '
        Me.lblIICompleteDate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblIICompleteDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIICompleteDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIICompleteDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIICompleteDate.Location = New System.Drawing.Point(388, 278)
        Me.lblIICompleteDate.Name = "lblIICompleteDate"
        Me.lblIICompleteDate.Size = New System.Drawing.Size(85, 23)
        Me.lblIICompleteDate.TabIndex = 18
        Me.lblIICompleteDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIIMethod
        '
        Me.lblIIMethod.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblIIMethod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIIMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIIMethod.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIIMethod.Location = New System.Drawing.Point(388, 246)
        Me.lblIIMethod.Name = "lblIIMethod"
        Me.lblIIMethod.Size = New System.Drawing.Size(85, 23)
        Me.lblIIMethod.TabIndex = 17
        Me.lblIIMethod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIIPayment
        '
        Me.lblIIPayment.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblIIPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIIPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIIPayment.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIIPayment.Location = New System.Drawing.Point(402, 182)
        Me.lblIIPayment.Name = "lblIIPayment"
        Me.lblIIPayment.Size = New System.Drawing.Size(71, 23)
        Me.lblIIPayment.TabIndex = 16
        Me.lblIIPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIIEmployee
        '
        Me.lblIIEmployee.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblIIEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIIEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIIEmployee.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIIEmployee.Location = New System.Drawing.Point(341, 149)
        Me.lblIIEmployee.Name = "lblIIEmployee"
        Me.lblIIEmployee.Size = New System.Drawing.Size(132, 23)
        Me.lblIIEmployee.TabIndex = 15
        Me.lblIIEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIIName
        '
        Me.lblIIName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblIIName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIIName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIIName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIIName.Location = New System.Drawing.Point(341, 117)
        Me.lblIIName.Name = "lblIIName"
        Me.lblIIName.Size = New System.Drawing.Size(132, 23)
        Me.lblIIName.TabIndex = 14
        Me.lblIIName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIIType
        '
        Me.lblIIType.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblIIType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIIType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIIType.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIIType.Location = New System.Drawing.Point(341, 53)
        Me.lblIIType.Name = "lblIIType"
        Me.lblIIType.Size = New System.Drawing.Size(132, 23)
        Me.lblIIType.TabIndex = 13
        Me.lblIIType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(6, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Job Completion Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(6, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Payment Method:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(8, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Total Payment Due:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(11, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Employee:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Invoice Type:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(6, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Customer Name:"
        '
        'lblIIHeading
        '
        Me.lblIIHeading.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblIIHeading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIIHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIIHeading.Location = New System.Drawing.Point(137, 49)
        Me.lblIIHeading.Name = "lblIIHeading"
        Me.lblIIHeading.Size = New System.Drawing.Size(260, 23)
        Me.lblIIHeading.TabIndex = 1
        Me.lblIIHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnIIBack
        '
        Me.btnIIBack.Location = New System.Drawing.Point(423, 402)
        Me.btnIIBack.Name = "btnIIBack"
        Me.btnIIBack.Size = New System.Drawing.Size(96, 23)
        Me.btnIIBack.TabIndex = 13
        Me.btnIIBack.Text = "&Back"
        Me.btnIIBack.UseVisualStyleBackColor = True
        '
        'btnIIDelete
        '
        Me.btnIIDelete.Location = New System.Drawing.Point(14, 402)
        Me.btnIIDelete.Name = "btnIIDelete"
        Me.btnIIDelete.Size = New System.Drawing.Size(96, 23)
        Me.btnIIDelete.TabIndex = 15
        Me.btnIIDelete.Text = "&Delete Invoice"
        Me.btnIIDelete.UseVisualStyleBackColor = True
        '
        'btnIIEdit
        '
        Me.btnIIEdit.Location = New System.Drawing.Point(301, 402)
        Me.btnIIEdit.Name = "btnIIEdit"
        Me.btnIIEdit.Size = New System.Drawing.Size(96, 23)
        Me.btnIIEdit.TabIndex = 16
        Me.btnIIEdit.Text = "&Edit Invoice"
        Me.btnIIEdit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(146, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Invoice Information For:"
        '
        'InvoiceInfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 437)
        Me.Controls.Add(Me.btnIIEdit)
        Me.Controls.Add(Me.btnIIDelete)
        Me.Controls.Add(Me.btnIIBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblIIHeading)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InvoiceInfoForm"
        Me.Text = "Invoice Information"
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblIICompleteDate As System.Windows.Forms.Label
    Friend WithEvents lblIIMethod As System.Windows.Forms.Label
    Friend WithEvents lblIIPayment As System.Windows.Forms.Label
    Friend WithEvents lblIIEmployee As System.Windows.Forms.Label
    Friend WithEvents lblIIName As System.Windows.Forms.Label
    Friend WithEvents lblIIType As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblIIHeading As System.Windows.Forms.Label
    Friend WithEvents btnIIBack As System.Windows.Forms.Button
    Friend WithEvents btnIIDelete As System.Windows.Forms.Button
    Friend WithEvents lblIIAmountPaid As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblIIWeek As System.Windows.Forms.Label
    Friend WithEvents lblIIWeekText As System.Windows.Forms.Label
    Friend WithEvents btnIIEdit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
End Class
