<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeEditForm
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
        Me.lblHead = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPhoneEM = New System.Windows.Forms.TextBox()
        Me.txtNameEM = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.txtHome = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblPay = New System.Windows.Forms.Label()
        Me.lblCommWages = New System.Windows.Forms.Label()
        Me.lblHourlyWages = New System.Windows.Forms.Label()
        Me.lblSalaryWages = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtHourly = New System.Windows.Forms.TextBox()
        Me.txtCommWages = New System.Windows.Forms.TextBox()
        Me.radSalary = New System.Windows.Forms.RadioButton()
        Me.radHourly = New System.Windows.Forms.RadioButton()
        Me.radCommission = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHead
        '
        Me.lblHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead.Location = New System.Drawing.Point(56, 46)
        Me.lblHead.Name = "lblHead"
        Me.lblHead.Size = New System.Drawing.Size(374, 29)
        Me.lblHead.TabIndex = 0
        Me.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtMobile)
        Me.GroupBox1.Controls.Add(Me.txtHome)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(463, 282)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label9.Location = New System.Drawing.Point(254, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "(xxx)-xxx-xxxx"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label7.Location = New System.Drawing.Point(254, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 16)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "(xxx)-xxx-xxxx"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtPhoneEM)
        Me.GroupBox2.Controls.Add(Me.txtNameEM)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox2.Location = New System.Drawing.Point(6, 182)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(451, 92)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Emergency Info:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label10.Location = New System.Drawing.Point(248, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "(xxx)-xxx-xxxx"
        '
        'txtPhoneEM
        '
        Me.txtPhoneEM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneEM.Location = New System.Drawing.Point(338, 59)
        Me.txtPhoneEM.Name = "txtPhoneEM"
        Me.txtPhoneEM.Size = New System.Drawing.Size(104, 20)
        Me.txtPhoneEM.TabIndex = 19
        '
        'txtNameEM
        '
        Me.txtNameEM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameEM.Location = New System.Drawing.Point(295, 24)
        Me.txtNameEM.Name = "txtNameEM"
        Me.txtNameEM.Size = New System.Drawing.Size(147, 20)
        Me.txtNameEM.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(9, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Contact Phone:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(9, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Contact Name:"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(313, 148)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(135, 20)
        Me.txtEmail.TabIndex = 17
        '
        'txtMobile
        '
        Me.txtMobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobile.Location = New System.Drawing.Point(344, 119)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(104, 20)
        Me.txtMobile.TabIndex = 16
        '
        'txtHome
        '
        Me.txtHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHome.Location = New System.Drawing.Point(344, 89)
        Me.txtHome.Name = "txtHome"
        Me.txtHome.Size = New System.Drawing.Size(104, 20)
        Me.txtHome.TabIndex = 15
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(254, 58)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(194, 20)
        Me.txtAddress.TabIndex = 14
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(301, 26)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(147, 20)
        Me.txtName.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(15, 151)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(15, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mobile/Cell Phone:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(15, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Home Phone:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(15, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Home Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(15, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Employee Name:"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(356, 503)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(104, 23)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(229, 503)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(104, 23)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(487, 24)
        Me.MenuStrip1.TabIndex = 5
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblPay)
        Me.GroupBox3.Controls.Add(Me.lblCommWages)
        Me.GroupBox3.Controls.Add(Me.lblHourlyWages)
        Me.GroupBox3.Controls.Add(Me.lblSalaryWages)
        Me.GroupBox3.Controls.Add(Me.txtSalary)
        Me.GroupBox3.Controls.Add(Me.txtHourly)
        Me.GroupBox3.Controls.Add(Me.txtCommWages)
        Me.GroupBox3.Controls.Add(Me.radSalary)
        Me.GroupBox3.Controls.Add(Me.radHourly)
        Me.GroupBox3.Controls.Add(Me.radCommission)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtPosition)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox3.Location = New System.Drawing.Point(12, 376)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(463, 121)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pay Information"
        '
        'lblPay
        '
        Me.lblPay.AutoSize = True
        Me.lblPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPay.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPay.Location = New System.Drawing.Point(27, 79)
        Me.lblPay.Name = "lblPay"
        Me.lblPay.Size = New System.Drawing.Size(0, 13)
        Me.lblPay.TabIndex = 30
        '
        'lblCommWages
        '
        Me.lblCommWages.AutoSize = True
        Me.lblCommWages.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommWages.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCommWages.Location = New System.Drawing.Point(63, 75)
        Me.lblCommWages.Name = "lblCommWages"
        Me.lblCommWages.Size = New System.Drawing.Size(19, 20)
        Me.lblCommWages.TabIndex = 29
        Me.lblCommWages.Text = "$"
        Me.lblCommWages.Visible = False
        '
        'lblHourlyWages
        '
        Me.lblHourlyWages.AutoSize = True
        Me.lblHourlyWages.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHourlyWages.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHourlyWages.Location = New System.Drawing.Point(203, 75)
        Me.lblHourlyWages.Name = "lblHourlyWages"
        Me.lblHourlyWages.Size = New System.Drawing.Size(19, 20)
        Me.lblHourlyWages.TabIndex = 28
        Me.lblHourlyWages.Text = "$"
        Me.lblHourlyWages.Visible = False
        '
        'lblSalaryWages
        '
        Me.lblSalaryWages.AutoSize = True
        Me.lblSalaryWages.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalaryWages.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSalaryWages.Location = New System.Drawing.Point(348, 74)
        Me.lblSalaryWages.Name = "lblSalaryWages"
        Me.lblSalaryWages.Size = New System.Drawing.Size(19, 20)
        Me.lblSalaryWages.TabIndex = 27
        Me.lblSalaryWages.Text = "$"
        Me.lblSalaryWages.Visible = False
        '
        'txtSalary
        '
        Me.txtSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(373, 76)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(84, 20)
        Me.txtSalary.TabIndex = 26
        Me.txtSalary.Visible = False
        '
        'txtHourly
        '
        Me.txtHourly.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHourly.Location = New System.Drawing.Point(228, 77)
        Me.txtHourly.Name = "txtHourly"
        Me.txtHourly.Size = New System.Drawing.Size(64, 20)
        Me.txtHourly.TabIndex = 25
        Me.txtHourly.Visible = False
        '
        'txtCommWages
        '
        Me.txtCommWages.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCommWages.Location = New System.Drawing.Point(92, 77)
        Me.txtCommWages.Name = "txtCommWages"
        Me.txtCommWages.Size = New System.Drawing.Size(64, 20)
        Me.txtCommWages.TabIndex = 24
        Me.txtCommWages.Visible = False
        '
        'radSalary
        '
        Me.radSalary.AutoSize = True
        Me.radSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSalary.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radSalary.Location = New System.Drawing.Point(364, 54)
        Me.radSalary.Name = "radSalary"
        Me.radSalary.Size = New System.Drawing.Size(54, 17)
        Me.radSalary.TabIndex = 23
        Me.radSalary.TabStop = True
        Me.radSalary.Text = "Salary"
        Me.radSalary.UseVisualStyleBackColor = True
        '
        'radHourly
        '
        Me.radHourly.AutoSize = True
        Me.radHourly.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radHourly.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radHourly.Location = New System.Drawing.Point(217, 50)
        Me.radHourly.Name = "radHourly"
        Me.radHourly.Size = New System.Drawing.Size(55, 17)
        Me.radHourly.TabIndex = 22
        Me.radHourly.TabStop = True
        Me.radHourly.Text = "Hourly"
        Me.radHourly.UseVisualStyleBackColor = True
        '
        'radCommission
        '
        Me.radCommission.AutoSize = True
        Me.radCommission.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCommission.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radCommission.Location = New System.Drawing.Point(76, 54)
        Me.radCommission.Name = "radCommission"
        Me.radCommission.Size = New System.Drawing.Size(80, 17)
        Me.radCommission.TabIndex = 21
        Me.radCommission.TabStop = True
        Me.radCommission.Text = "Commission"
        Me.radCommission.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(15, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Pay Type:"
        '
        'txtPosition
        '
        Me.txtPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosition.Location = New System.Drawing.Point(301, 25)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(147, 20)
        Me.txtPosition.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(15, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Job Position:"
        '
        'EmployeeEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 547)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblHead)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "EmployeeEditForm"
        Me.Text = "Edit Employee Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHead As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents txtHome As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneEM As System.Windows.Forms.TextBox
    Friend WithEvents txtNameEM As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPay As System.Windows.Forms.Label
    Friend WithEvents lblCommWages As System.Windows.Forms.Label
    Friend WithEvents lblHourlyWages As System.Windows.Forms.Label
    Friend WithEvents lblSalaryWages As System.Windows.Forms.Label
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents txtHourly As System.Windows.Forms.TextBox
    Friend WithEvents txtCommWages As System.Windows.Forms.TextBox
    Friend WithEvents radSalary As System.Windows.Forms.RadioButton
    Friend WithEvents radHourly As System.Windows.Forms.RadioButton
    Friend WithEvents radCommission As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
