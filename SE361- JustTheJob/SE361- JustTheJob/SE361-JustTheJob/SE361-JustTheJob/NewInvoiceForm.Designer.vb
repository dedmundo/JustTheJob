<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewInvoiceForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtNIWeek = New System.Windows.Forms.TextBox()
        Me.lblNIWeek = New System.Windows.Forms.Label()
        Me.txtNIPaid = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNIComplete = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.txtNIPay = New System.Windows.Forms.TextBox()
        Me.txtNIEmployee = New System.Windows.Forms.TextBox()
        Me.txtNIName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.radNIOneTime = New System.Windows.Forms.RadioButton()
        Me.radNIRegular = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNIBack = New System.Windows.Forms.Button()
        Me.btnNISubmit = New System.Windows.Forms.Button()
        Me.lblCommWages = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(572, 24)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(180, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 31)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "New Invoice Form"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lblCommWages)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.txtNIWeek)
        Me.GroupBox1.Controls.Add(Me.lblNIWeek)
        Me.GroupBox1.Controls.Add(Me.txtNIPaid)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtNIComplete)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbPaymentMethod)
        Me.GroupBox1.Controls.Add(Me.txtNIPay)
        Me.GroupBox1.Controls.Add(Me.txtNIEmployee)
        Me.GroupBox1.Controls.Add(Me.txtNIName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.radNIOneTime)
        Me.GroupBox1.Controls.Add(Me.radNIRegular)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Location = New System.Drawing.Point(13, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(545, 284)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Provide the Following Information:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(8, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Invoice ID"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(412, 53)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(61, 20)
        Me.txtID.TabIndex = 2
        '
        'txtNIWeek
        '
        Me.txtNIWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNIWeek.Location = New System.Drawing.Point(387, 81)
        Me.txtNIWeek.Name = "txtNIWeek"
        Me.txtNIWeek.Size = New System.Drawing.Size(86, 20)
        Me.txtNIWeek.TabIndex = 3
        '
        'lblNIWeek
        '
        Me.lblNIWeek.AutoSize = True
        Me.lblNIWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNIWeek.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNIWeek.Location = New System.Drawing.Point(8, 86)
        Me.lblNIWeek.Name = "lblNIWeek"
        Me.lblNIWeek.Size = New System.Drawing.Size(33, 13)
        Me.lblNIWeek.TabIndex = 15
        Me.lblNIWeek.Text = "Date:"
        '
        'txtNIPaid
        '
        Me.txtNIPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNIPaid.Location = New System.Drawing.Point(387, 193)
        Me.txtNIPaid.Name = "txtNIPaid"
        Me.txtNIPaid.ReadOnly = True
        Me.txtNIPaid.Size = New System.Drawing.Size(86, 20)
        Me.txtNIPaid.TabIndex = 7
        Me.txtNIPaid.Text = "0"
        Me.txtNIPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(8, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Amount Paid:"
        '
        'txtNIComplete
        '
        Me.txtNIComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNIComplete.Location = New System.Drawing.Point(364, 251)
        Me.txtNIComplete.Name = "txtNIComplete"
        Me.txtNIComplete.Size = New System.Drawing.Size(109, 20)
        Me.txtNIComplete.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(8, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Job Completion Date:"
        '
        'cmbPaymentMethod
        '
        Me.cmbPaymentMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPaymentMethod.FormattingEnabled = True
        Me.cmbPaymentMethod.Items.AddRange(New Object() {"Cash", "Credit", "Debit"})
        Me.cmbPaymentMethod.Location = New System.Drawing.Point(352, 221)
        Me.cmbPaymentMethod.Name = "cmbPaymentMethod"
        Me.cmbPaymentMethod.Size = New System.Drawing.Size(121, 21)
        Me.cmbPaymentMethod.TabIndex = 8
        '
        'txtNIPay
        '
        Me.txtNIPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNIPay.Location = New System.Drawing.Point(387, 165)
        Me.txtNIPay.Name = "txtNIPay"
        Me.txtNIPay.Size = New System.Drawing.Size(86, 20)
        Me.txtNIPay.TabIndex = 6
        '
        'txtNIEmployee
        '
        Me.txtNIEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNIEmployee.Location = New System.Drawing.Point(341, 137)
        Me.txtNIEmployee.Name = "txtNIEmployee"
        Me.txtNIEmployee.Size = New System.Drawing.Size(132, 20)
        Me.txtNIEmployee.TabIndex = 5
        '
        'txtNIName
        '
        Me.txtNIName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNIName.Location = New System.Drawing.Point(341, 109)
        Me.txtNIName.Name = "txtNIName"
        Me.txtNIName.Size = New System.Drawing.Size(132, 20)
        Me.txtNIName.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(8, 226)
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
        Me.Label5.Location = New System.Drawing.Point(8, 170)
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
        Me.Label4.Location = New System.Drawing.Point(8, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Employee:"
        '
        'radNIOneTime
        '
        Me.radNIOneTime.AutoSize = True
        Me.radNIOneTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNIOneTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radNIOneTime.Location = New System.Drawing.Point(84, 29)
        Me.radNIOneTime.Name = "radNIOneTime"
        Me.radNIOneTime.Size = New System.Drawing.Size(109, 17)
        Me.radNIOneTime.TabIndex = 0
        Me.radNIOneTime.TabStop = True
        Me.radNIOneTime.Text = "One-Time Invoice"
        Me.radNIOneTime.UseVisualStyleBackColor = True
        '
        'radNIRegular
        '
        Me.radNIRegular.AutoSize = True
        Me.radNIRegular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNIRegular.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radNIRegular.Location = New System.Drawing.Point(199, 29)
        Me.radNIRegular.Name = "radNIRegular"
        Me.radNIRegular.Size = New System.Drawing.Size(100, 17)
        Me.radNIRegular.TabIndex = 1
        Me.radNIRegular.TabStop = True
        Me.radNIRegular.Text = "Regular Invoice"
        Me.radNIRegular.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(6, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Invoice Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Customer Name:"
        '
        'btnNIBack
        '
        Me.btnNIBack.Location = New System.Drawing.Point(455, 374)
        Me.btnNIBack.Name = "btnNIBack"
        Me.btnNIBack.Size = New System.Drawing.Size(103, 23)
        Me.btnNIBack.TabIndex = 13
        Me.btnNIBack.Text = "&Back"
        Me.btnNIBack.UseVisualStyleBackColor = True
        '
        'btnNISubmit
        '
        Me.btnNISubmit.Location = New System.Drawing.Point(310, 374)
        Me.btnNISubmit.Name = "btnNISubmit"
        Me.btnNISubmit.Size = New System.Drawing.Size(103, 23)
        Me.btnNISubmit.TabIndex = 10
        Me.btnNISubmit.Text = "&Submit"
        Me.btnNISubmit.UseVisualStyleBackColor = True
        '
        'lblCommWages
        '
        Me.lblCommWages.AutoSize = True
        Me.lblCommWages.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommWages.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCommWages.Location = New System.Drawing.Point(362, 163)
        Me.lblCommWages.Name = "lblCommWages"
        Me.lblCommWages.Size = New System.Drawing.Size(19, 20)
        Me.lblCommWages.TabIndex = 21
        Me.lblCommWages.Text = "$"
        Me.lblCommWages.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(362, 191)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 20)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "$"
        Me.Label12.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label13.Location = New System.Drawing.Point(294, 254)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "mm/dd/yyyy"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label11.Location = New System.Drawing.Point(316, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "mm/dd/yyyy"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label10.Location = New System.Drawing.Point(379, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "(xxxx)"
        '
        'NewInvoiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 405)
        Me.Controls.Add(Me.btnNISubmit)
        Me.Controls.Add(Me.btnNIBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "NewInvoiceForm"
        Me.Text = "Add New Invoice"
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbPaymentMethod As System.Windows.Forms.ComboBox
    Friend WithEvents txtNIPay As System.Windows.Forms.TextBox
    Friend WithEvents txtNIEmployee As System.Windows.Forms.TextBox
    Friend WithEvents txtNIName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents radNIOneTime As System.Windows.Forms.RadioButton
    Friend WithEvents radNIRegular As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNIComplete As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnNIBack As System.Windows.Forms.Button
    Friend WithEvents btnNISubmit As System.Windows.Forms.Button
    Friend WithEvents txtNIPaid As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblNIWeek As System.Windows.Forms.Label
    Friend WithEvents txtNIWeek As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblCommWages As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
