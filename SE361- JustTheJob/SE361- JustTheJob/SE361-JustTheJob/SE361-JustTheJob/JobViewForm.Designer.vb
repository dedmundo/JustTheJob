<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JobViewForm
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnChangeStatus = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTitle3 = New System.Windows.Forms.Label()
        Me.lblTitle2 = New System.Windows.Forms.Label()
        Me.lblTitle1 = New System.Windows.Forms.Label()
        Me.lblLeadTitle = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.lblLeadName = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblDeadline = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblJEDeadline = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnJEDelete = New System.Windows.Forms.Button()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(542, 24)
        Me.MenuStrip1.TabIndex = 1
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.lblDescription)
        Me.GroupBox1.Controls.Add(Me.lblDeadline)
        Me.GroupBox1.Controls.Add(Me.lblStart)
        Me.GroupBox1.Controls.Add(Me.lblLocation)
        Me.GroupBox1.Controls.Add(Me.lblClient)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblJEDeadline)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Location = New System.Drawing.Point(12, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 485)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Job Information"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnChangeStatus)
        Me.GroupBox3.Controls.Add(Me.lblStatus)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox3.Location = New System.Drawing.Point(6, 403)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(506, 72)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Change Job Status"
        '
        'btnChangeStatus
        '
        Me.btnChangeStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnChangeStatus.Location = New System.Drawing.Point(203, 24)
        Me.btnChangeStatus.Name = "btnChangeStatus"
        Me.btnChangeStatus.Size = New System.Drawing.Size(124, 23)
        Me.btnChangeStatus.TabIndex = 26
        Me.btnChangeStatus.Text = "Change Job Status"
        Me.btnChangeStatus.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStatus.Location = New System.Drawing.Point(89, 24)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(99, 23)
        Me.lblStatus.TabIndex = 25
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Current Status:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTitle3)
        Me.GroupBox2.Controls.Add(Me.lblTitle2)
        Me.GroupBox2.Controls.Add(Me.lblTitle1)
        Me.GroupBox2.Controls.Add(Me.lblLeadTitle)
        Me.GroupBox2.Controls.Add(Me.lblEmployee3)
        Me.GroupBox2.Controls.Add(Me.lblEmployee2)
        Me.GroupBox2.Controls.Add(Me.lblEmployee1)
        Me.GroupBox2.Controls.Add(Me.lblLeadName)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox2.Location = New System.Drawing.Point(6, 263)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(506, 134)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Assigned Employees:"
        '
        'lblTitle3
        '
        Me.lblTitle3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblTitle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTitle3.Location = New System.Drawing.Point(364, 101)
        Me.lblTitle3.Name = "lblTitle3"
        Me.lblTitle3.Size = New System.Drawing.Size(123, 23)
        Me.lblTitle3.TabIndex = 41
        Me.lblTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTitle2
        '
        Me.lblTitle2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblTitle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTitle2.Location = New System.Drawing.Point(364, 73)
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Size = New System.Drawing.Size(123, 23)
        Me.lblTitle2.TabIndex = 40
        Me.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTitle1
        '
        Me.lblTitle1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblTitle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTitle1.Location = New System.Drawing.Point(364, 46)
        Me.lblTitle1.Name = "lblTitle1"
        Me.lblTitle1.Size = New System.Drawing.Size(123, 23)
        Me.lblTitle1.TabIndex = 39
        Me.lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLeadTitle
        '
        Me.lblLeadTitle.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblLeadTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeadTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLeadTitle.Location = New System.Drawing.Point(364, 20)
        Me.lblLeadTitle.Name = "lblLeadTitle"
        Me.lblLeadTitle.Size = New System.Drawing.Size(123, 23)
        Me.lblLeadTitle.TabIndex = 38
        Me.lblLeadTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmployee3
        '
        Me.lblEmployee3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblEmployee3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEmployee3.Location = New System.Drawing.Point(114, 101)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(123, 23)
        Me.lblEmployee3.TabIndex = 37
        Me.lblEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmployee2
        '
        Me.lblEmployee2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblEmployee2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEmployee2.Location = New System.Drawing.Point(114, 73)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(123, 23)
        Me.lblEmployee2.TabIndex = 36
        Me.lblEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmployee1
        '
        Me.lblEmployee1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblEmployee1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEmployee1.Location = New System.Drawing.Point(114, 46)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(123, 23)
        Me.lblEmployee1.TabIndex = 35
        Me.lblEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLeadName
        '
        Me.lblLeadName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblLeadName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeadName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLeadName.Location = New System.Drawing.Point(114, 20)
        Me.lblLeadName.Name = "lblLeadName"
        Me.lblLeadName.Size = New System.Drawing.Size(123, 23)
        Me.lblLeadName.TabIndex = 34
        Me.lblLeadName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(292, 108)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Job Title: "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(292, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Job Title: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(292, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Job Title: "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(292, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Job Title: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(11, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Employee:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(9, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Employee:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(9, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Employee: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(9, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Project Lead: "
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescription.Location = New System.Drawing.Point(110, 179)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(383, 72)
        Me.lblDescription.TabIndex = 22
        '
        'lblDeadline
        '
        Me.lblDeadline.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblDeadline.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeadline.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDeadline.Location = New System.Drawing.Point(400, 147)
        Me.lblDeadline.Name = "lblDeadline"
        Me.lblDeadline.Size = New System.Drawing.Size(93, 23)
        Me.lblDeadline.TabIndex = 21
        Me.lblDeadline.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblStart
        '
        Me.lblStart.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStart.Location = New System.Drawing.Point(403, 115)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(90, 23)
        Me.lblStart.TabIndex = 20
        Me.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLocation
        '
        Me.lblLocation.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLocation.Location = New System.Drawing.Point(291, 86)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(202, 23)
        Me.lblLocation.TabIndex = 19
        Me.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblClient
        '
        Me.lblClient.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClient.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblClient.Location = New System.Drawing.Point(355, 56)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(138, 23)
        Me.lblClient.TabIndex = 18
        Me.lblClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblName.Location = New System.Drawing.Point(336, 25)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(157, 23)
        Me.lblName.TabIndex = 17
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(6, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Job Description:"
        '
        'lblJEDeadline
        '
        Me.lblJEDeadline.AutoSize = True
        Me.lblJEDeadline.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJEDeadline.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblJEDeadline.Location = New System.Drawing.Point(6, 152)
        Me.lblJEDeadline.Name = "lblJEDeadline"
        Me.lblJEDeadline.Size = New System.Drawing.Size(72, 13)
        Me.lblJEDeadline.TabIndex = 15
        Me.lblJEDeadline.Text = "Job Deadline:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(6, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Start Date:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(6, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Job Location:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(6, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Client:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Project Name:"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(426, 587)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(98, 27)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(313, 587)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(98, 27)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnJEDelete
        '
        Me.btnJEDelete.Location = New System.Drawing.Point(18, 587)
        Me.btnJEDelete.Name = "btnJEDelete"
        Me.btnJEDelete.Size = New System.Drawing.Size(103, 23)
        Me.btnJEDelete.TabIndex = 17
        Me.btnJEDelete.Text = "&Delete Job"
        Me.btnJEDelete.UseVisualStyleBackColor = True
        '
        'lblHeading
        '
        Me.lblHeading.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblHeading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(151, 61)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(260, 23)
        Me.lblHeading.TabIndex = 19
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(165, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 25)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Invoice Information For:"
        '
        'JobViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 626)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnJEDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "JobViewForm"
        Me.Text = "Job Information"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblJEDeadline As System.Windows.Forms.Label
    Friend WithEvents lblClient As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblDeadline As System.Windows.Forms.Label
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLeadName As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTitle3 As System.Windows.Forms.Label
    Friend WithEvents lblTitle2 As System.Windows.Forms.Label
    Friend WithEvents lblTitle1 As System.Windows.Forms.Label
    Friend WithEvents lblLeadTitle As System.Windows.Forms.Label
    Friend WithEvents lblEmployee3 As System.Windows.Forms.Label
    Friend WithEvents lblEmployee2 As System.Windows.Forms.Label
    Friend WithEvents lblEmployee1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnChangeStatus As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnJEDelete As System.Windows.Forms.Button
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
