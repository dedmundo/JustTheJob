<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewEmployee
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNEBack = New System.Windows.Forms.Button()
        Me.btnNESubmit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNEEmail = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNECell = New System.Windows.Forms.TextBox()
        Me.txtNEPhone = New System.Windows.Forms.TextBox()
        Me.txtNEAddress = New System.Windows.Forms.TextBox()
        Me.txtNEName = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNEPhoneEM = New System.Windows.Forms.TextBox()
        Me.txtNENameEM = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblCommWages = New System.Windows.Forms.Label()
        Me.lblHourlyWages = New System.Windows.Forms.Label()
        Me.lblSalaryWages = New System.Windows.Forms.Label()
        Me.txtNESalary = New System.Windows.Forms.TextBox()
        Me.txtNEHourly = New System.Windows.Forms.TextBox()
        Me.txtNECommWages = New System.Windows.Forms.TextBox()
        Me.lblNEPay = New System.Windows.Forms.Label()
        Me.radNESalary = New System.Windows.Forms.RadioButton()
        Me.radNECommission = New System.Windows.Forms.RadioButton()
        Me.radNEHourly = New System.Windows.Forms.RadioButton()
        Me.txtNEPosition = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(165, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Add a New Employee"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(584, 24)
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
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.BackToolStripMenuItem.Text = "&Back"
        '
        'btnNEBack
        '
        Me.btnNEBack.Location = New System.Drawing.Point(469, 524)
        Me.btnNEBack.Name = "btnNEBack"
        Me.btnNEBack.Size = New System.Drawing.Size(103, 23)
        Me.btnNEBack.TabIndex = 17
        Me.btnNEBack.Text = "&Back"
        Me.btnNEBack.UseVisualStyleBackColor = True
        '
        'btnNESubmit
        '
        Me.btnNESubmit.Location = New System.Drawing.Point(360, 524)
        Me.btnNESubmit.Name = "btnNESubmit"
        Me.btnNESubmit.Size = New System.Drawing.Size(103, 23)
        Me.btnNESubmit.TabIndex = 16
        Me.btnNESubmit.Text = "&Submit"
        Me.btnNESubmit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNEEmail)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtNECell)
        Me.GroupBox1.Controls.Add(Me.txtNEPhone)
        Me.GroupBox1.Controls.Add(Me.txtNEAddress)
        Me.GroupBox1.Controls.Add(Me.txtNEName)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Location = New System.Drawing.Point(13, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(559, 260)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'txtNEEmail
        '
        Me.txtNEEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNEEmail.Location = New System.Drawing.Point(285, 139)
        Me.txtNEEmail.Name = "txtNEEmail"
        Me.txtNEEmail.Size = New System.Drawing.Size(184, 20)
        Me.txtNEEmail.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(7, 142)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Email:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label9.Location = New System.Drawing.Point(262, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 16)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "(xxx)-xxx-xxxx"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label7.Location = New System.Drawing.Point(262, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "(xxx)-xxx-xxxx"
        '
        'txtNECell
        '
        Me.txtNECell.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNECell.Location = New System.Drawing.Point(352, 108)
        Me.txtNECell.Name = "txtNECell"
        Me.txtNECell.Size = New System.Drawing.Size(117, 20)
        Me.txtNECell.TabIndex = 4
        '
        'txtNEPhone
        '
        Me.txtNEPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNEPhone.Location = New System.Drawing.Point(352, 81)
        Me.txtNEPhone.Name = "txtNEPhone"
        Me.txtNEPhone.Size = New System.Drawing.Size(117, 20)
        Me.txtNEPhone.TabIndex = 3
        '
        'txtNEAddress
        '
        Me.txtNEAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNEAddress.Location = New System.Drawing.Point(285, 49)
        Me.txtNEAddress.Name = "txtNEAddress"
        Me.txtNEAddress.Size = New System.Drawing.Size(184, 20)
        Me.txtNEAddress.TabIndex = 2
        '
        'txtNEName
        '
        Me.txtNEName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNEName.Location = New System.Drawing.Point(330, 17)
        Me.txtNEName.Name = "txtNEName"
        Me.txtNEName.Size = New System.Drawing.Size(139, 20)
        Me.txtNEName.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtNEPhoneEM)
        Me.GroupBox2.Controls.Add(Me.txtNENameEM)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox2.Location = New System.Drawing.Point(10, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(543, 82)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Emergency Contacts:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label10.Location = New System.Drawing.Point(252, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 16)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "(xxx)-xxx-xxxx"
        '
        'txtNEPhoneEM
        '
        Me.txtNEPhoneEM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNEPhoneEM.Location = New System.Drawing.Point(342, 50)
        Me.txtNEPhoneEM.Name = "txtNEPhoneEM"
        Me.txtNEPhoneEM.Size = New System.Drawing.Size(117, 20)
        Me.txtNEPhoneEM.TabIndex = 7
        '
        'txtNENameEM
        '
        Me.txtNENameEM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNENameEM.Location = New System.Drawing.Point(320, 19)
        Me.txtNENameEM.Name = "txtNENameEM"
        Me.txtNENameEM.Size = New System.Drawing.Size(139, 20)
        Me.txtNENameEM.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(7, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Contact Phone:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(7, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Contact Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(7, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Mobile/Cell Phone:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(7, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Home Phone:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(7, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Home Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(7, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Employee Name:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblCommWages)
        Me.GroupBox3.Controls.Add(Me.lblHourlyWages)
        Me.GroupBox3.Controls.Add(Me.lblSalaryWages)
        Me.GroupBox3.Controls.Add(Me.txtNESalary)
        Me.GroupBox3.Controls.Add(Me.txtNEHourly)
        Me.GroupBox3.Controls.Add(Me.txtNECommWages)
        Me.GroupBox3.Controls.Add(Me.lblNEPay)
        Me.GroupBox3.Controls.Add(Me.radNESalary)
        Me.GroupBox3.Controls.Add(Me.radNECommission)
        Me.GroupBox3.Controls.Add(Me.radNEHourly)
        Me.GroupBox3.Controls.Add(Me.txtNEPosition)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox3.Location = New System.Drawing.Point(13, 343)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(559, 164)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Work Information"
        '
        'lblCommWages
        '
        Me.lblCommWages.AutoSize = True
        Me.lblCommWages.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommWages.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCommWages.Location = New System.Drawing.Point(104, 91)
        Me.lblCommWages.Name = "lblCommWages"
        Me.lblCommWages.Size = New System.Drawing.Size(19, 20)
        Me.lblCommWages.TabIndex = 18
        Me.lblCommWages.Text = "$"
        Me.lblCommWages.Visible = False
        '
        'lblHourlyWages
        '
        Me.lblHourlyWages.AutoSize = True
        Me.lblHourlyWages.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHourlyWages.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHourlyWages.Location = New System.Drawing.Point(231, 89)
        Me.lblHourlyWages.Name = "lblHourlyWages"
        Me.lblHourlyWages.Size = New System.Drawing.Size(19, 20)
        Me.lblHourlyWages.TabIndex = 17
        Me.lblHourlyWages.Text = "$"
        Me.lblHourlyWages.Visible = False
        '
        'lblSalaryWages
        '
        Me.lblSalaryWages.AutoSize = True
        Me.lblSalaryWages.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalaryWages.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSalaryWages.Location = New System.Drawing.Point(393, 91)
        Me.lblSalaryWages.Name = "lblSalaryWages"
        Me.lblSalaryWages.Size = New System.Drawing.Size(19, 20)
        Me.lblSalaryWages.TabIndex = 16
        Me.lblSalaryWages.Text = "$"
        Me.lblSalaryWages.Visible = False
        '
        'txtNESalary
        '
        Me.txtNESalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNESalary.Location = New System.Drawing.Point(418, 93)
        Me.txtNESalary.Name = "txtNESalary"
        Me.txtNESalary.Size = New System.Drawing.Size(84, 20)
        Me.txtNESalary.TabIndex = 15
        Me.txtNESalary.Visible = False
        '
        'txtNEHourly
        '
        Me.txtNEHourly.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNEHourly.Location = New System.Drawing.Point(256, 93)
        Me.txtNEHourly.Name = "txtNEHourly"
        Me.txtNEHourly.Size = New System.Drawing.Size(64, 20)
        Me.txtNEHourly.TabIndex = 14
        Me.txtNEHourly.Visible = False
        '
        'txtNECommWages
        '
        Me.txtNECommWages.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNECommWages.Location = New System.Drawing.Point(129, 93)
        Me.txtNECommWages.Name = "txtNECommWages"
        Me.txtNECommWages.Size = New System.Drawing.Size(64, 20)
        Me.txtNECommWages.TabIndex = 13
        Me.txtNECommWages.Visible = False
        '
        'lblNEPay
        '
        Me.lblNEPay.AutoSize = True
        Me.lblNEPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNEPay.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNEPay.Location = New System.Drawing.Point(31, 96)
        Me.lblNEPay.Name = "lblNEPay"
        Me.lblNEPay.Size = New System.Drawing.Size(0, 13)
        Me.lblNEPay.TabIndex = 10
        '
        'radNESalary
        '
        Me.radNESalary.AutoSize = True
        Me.radNESalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNESalary.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radNESalary.Location = New System.Drawing.Point(442, 68)
        Me.radNESalary.Name = "radNESalary"
        Me.radNESalary.Size = New System.Drawing.Size(54, 17)
        Me.radNESalary.TabIndex = 12
        Me.radNESalary.TabStop = True
        Me.radNESalary.Text = "Salary"
        Me.radNESalary.UseVisualStyleBackColor = True
        '
        'radNECommission
        '
        Me.radNECommission.AutoSize = True
        Me.radNECommission.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNECommission.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radNECommission.Location = New System.Drawing.Point(113, 68)
        Me.radNECommission.Name = "radNECommission"
        Me.radNECommission.Size = New System.Drawing.Size(80, 17)
        Me.radNECommission.TabIndex = 10
        Me.radNECommission.TabStop = True
        Me.radNECommission.Text = "Commission"
        Me.radNECommission.UseVisualStyleBackColor = True
        '
        'radNEHourly
        '
        Me.radNEHourly.AutoSize = True
        Me.radNEHourly.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNEHourly.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radNEHourly.Location = New System.Drawing.Point(265, 68)
        Me.radNEHourly.Name = "radNEHourly"
        Me.radNEHourly.Size = New System.Drawing.Size(55, 17)
        Me.radNEHourly.TabIndex = 11
        Me.radNEHourly.TabStop = True
        Me.radNEHourly.Text = "Hourly"
        Me.radNEHourly.UseVisualStyleBackColor = True
        '
        'txtNEPosition
        '
        Me.txtNEPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNEPosition.Location = New System.Drawing.Point(330, 25)
        Me.txtNEPosition.Name = "txtNEPosition"
        Me.txtNEPosition.Size = New System.Drawing.Size(139, 20)
        Me.txtNEPosition.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(6, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Pay Type:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(6, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Job Position:"
        '
        'NewEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 558)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnNESubmit)
        Me.Controls.Add(Me.btnNEBack)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NewEmployee"
        Me.Text = "Add New Employee Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnNEBack As System.Windows.Forms.Button
    Friend WithEvents btnNESubmit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNEEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNECell As System.Windows.Forms.TextBox
    Friend WithEvents txtNEPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtNEAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtNEName As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNEPhoneEM As System.Windows.Forms.TextBox
    Friend WithEvents txtNENameEM As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNESalary As System.Windows.Forms.TextBox
    Friend WithEvents txtNEHourly As System.Windows.Forms.TextBox
    Friend WithEvents txtNECommWages As System.Windows.Forms.TextBox
    Friend WithEvents lblNEPay As System.Windows.Forms.Label
    Friend WithEvents radNESalary As System.Windows.Forms.RadioButton
    Friend WithEvents radNECommission As System.Windows.Forms.RadioButton
    Friend WithEvents radNEHourly As System.Windows.Forms.RadioButton
    Friend WithEvents txtNEPosition As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblCommWages As System.Windows.Forms.Label
    Friend WithEvents lblHourlyWages As System.Windows.Forms.Label
    Friend WithEvents lblSalaryWages As System.Windows.Forms.Label
End Class
