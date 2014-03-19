<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JobEditForm
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtJEDescription = New System.Windows.Forms.TextBox()
        Me.txtDeadline = New System.Windows.Forms.TextBox()
        Me.txtJEStart = New System.Windows.Forms.TextBox()
        Me.txtJELocation = New System.Windows.Forms.TextBox()
        Me.txtJEClient = New System.Windows.Forms.TextBox()
        Me.txtJEName = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtJETitle3 = New System.Windows.Forms.TextBox()
        Me.txtJETitle2 = New System.Windows.Forms.TextBox()
        Me.txtJETitle1 = New System.Windows.Forms.TextBox()
        Me.txtJETitleLead = New System.Windows.Forms.TextBox()
        Me.txtJEEmployee3 = New System.Windows.Forms.TextBox()
        Me.txtJEEmployee2 = New System.Windows.Forms.TextBox()
        Me.txtJEEmployee1 = New System.Windows.Forms.TextBox()
        Me.txtJELead = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblJEDeadline = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnJEBack = New System.Windows.Forms.Button()
        Me.lblJEName = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(566, 24)
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
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BackToolStripMenuItem.Text = "&Back"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtJEDescription)
        Me.GroupBox1.Controls.Add(Me.txtDeadline)
        Me.GroupBox1.Controls.Add(Me.txtJEStart)
        Me.GroupBox1.Controls.Add(Me.txtJELocation)
        Me.GroupBox1.Controls.Add(Me.txtJEClient)
        Me.GroupBox1.Controls.Add(Me.txtJEName)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblJEDeadline)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Location = New System.Drawing.Point(12, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 455)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Job Information"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Location = New System.Drawing.Point(340, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "mm/dd/yyyy"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(340, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "mm/dd/yyyy"
        '
        'txtJEDescription
        '
        Me.txtJEDescription.Location = New System.Drawing.Point(95, 174)
        Me.txtJEDescription.Multiline = True
        Me.txtJEDescription.Name = "txtJEDescription"
        Me.txtJEDescription.Size = New System.Drawing.Size(410, 88)
        Me.txtJEDescription.TabIndex = 25
        '
        'txtDeadline
        '
        Me.txtDeadline.Location = New System.Drawing.Point(411, 144)
        Me.txtDeadline.Name = "txtDeadline"
        Me.txtDeadline.Size = New System.Drawing.Size(94, 22)
        Me.txtDeadline.TabIndex = 24
        '
        'txtJEStart
        '
        Me.txtJEStart.Location = New System.Drawing.Point(411, 111)
        Me.txtJEStart.Name = "txtJEStart"
        Me.txtJEStart.Size = New System.Drawing.Size(94, 22)
        Me.txtJEStart.TabIndex = 23
        '
        'txtJELocation
        '
        Me.txtJELocation.Location = New System.Drawing.Point(324, 81)
        Me.txtJELocation.Name = "txtJELocation"
        Me.txtJELocation.Size = New System.Drawing.Size(181, 22)
        Me.txtJELocation.TabIndex = 22
        '
        'txtJEClient
        '
        Me.txtJEClient.Location = New System.Drawing.Point(382, 53)
        Me.txtJEClient.Name = "txtJEClient"
        Me.txtJEClient.Size = New System.Drawing.Size(123, 22)
        Me.txtJEClient.TabIndex = 21
        '
        'txtJEName
        '
        Me.txtJEName.Location = New System.Drawing.Point(382, 25)
        Me.txtJEName.Name = "txtJEName"
        Me.txtJEName.Size = New System.Drawing.Size(123, 22)
        Me.txtJEName.TabIndex = 20
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(10, 429)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(138, 13)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "* - Not Required Information"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(6, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Job Location:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtJETitle3)
        Me.GroupBox2.Controls.Add(Me.txtJETitle2)
        Me.GroupBox2.Controls.Add(Me.txtJETitle1)
        Me.GroupBox2.Controls.Add(Me.txtJETitleLead)
        Me.GroupBox2.Controls.Add(Me.txtJEEmployee3)
        Me.GroupBox2.Controls.Add(Me.txtJEEmployee2)
        Me.GroupBox2.Controls.Add(Me.txtJEEmployee1)
        Me.GroupBox2.Controls.Add(Me.txtJELead)
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
        Me.GroupBox2.Location = New System.Drawing.Point(13, 273)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(507, 153)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Assigned Employees:"
        '
        'txtJETitle3
        '
        Me.txtJETitle3.Location = New System.Drawing.Point(355, 104)
        Me.txtJETitle3.Name = "txtJETitle3"
        Me.txtJETitle3.Size = New System.Drawing.Size(123, 20)
        Me.txtJETitle3.TabIndex = 33
        '
        'txtJETitle2
        '
        Me.txtJETitle2.Location = New System.Drawing.Point(355, 75)
        Me.txtJETitle2.Name = "txtJETitle2"
        Me.txtJETitle2.Size = New System.Drawing.Size(123, 20)
        Me.txtJETitle2.TabIndex = 32
        '
        'txtJETitle1
        '
        Me.txtJETitle1.Location = New System.Drawing.Point(355, 48)
        Me.txtJETitle1.Name = "txtJETitle1"
        Me.txtJETitle1.Size = New System.Drawing.Size(123, 20)
        Me.txtJETitle1.TabIndex = 31
        '
        'txtJETitleLead
        '
        Me.txtJETitleLead.Location = New System.Drawing.Point(355, 22)
        Me.txtJETitleLead.Name = "txtJETitleLead"
        Me.txtJETitleLead.Size = New System.Drawing.Size(123, 20)
        Me.txtJETitleLead.TabIndex = 30
        '
        'txtJEEmployee3
        '
        Me.txtJEEmployee3.Location = New System.Drawing.Point(114, 104)
        Me.txtJEEmployee3.Name = "txtJEEmployee3"
        Me.txtJEEmployee3.Size = New System.Drawing.Size(123, 20)
        Me.txtJEEmployee3.TabIndex = 29
        '
        'txtJEEmployee2
        '
        Me.txtJEEmployee2.Location = New System.Drawing.Point(114, 75)
        Me.txtJEEmployee2.Name = "txtJEEmployee2"
        Me.txtJEEmployee2.Size = New System.Drawing.Size(123, 20)
        Me.txtJEEmployee2.TabIndex = 28
        '
        'txtJEEmployee1
        '
        Me.txtJEEmployee1.Location = New System.Drawing.Point(114, 48)
        Me.txtJEEmployee1.Name = "txtJEEmployee1"
        Me.txtJEEmployee1.Size = New System.Drawing.Size(123, 20)
        Me.txtJEEmployee1.TabIndex = 27
        '
        'txtJELead
        '
        Me.txtJELead.Location = New System.Drawing.Point(114, 22)
        Me.txtJELead.Name = "txtJELead"
        Me.txtJELead.Size = New System.Drawing.Size(123, 20)
        Me.txtJELead.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(292, 108)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "*Job Title: "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(292, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "*Job Title: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(292, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "*Job Title: "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(296, 25)
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
        Me.Label10.Location = New System.Drawing.Point(9, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "*Employee:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(9, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "*Employee:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(9, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "*Employee: "
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(6, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Client:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(6, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Job Description:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(6, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Start Date:"
        '
        'lblJEDeadline
        '
        Me.lblJEDeadline.AutoSize = True
        Me.lblJEDeadline.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJEDeadline.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblJEDeadline.Location = New System.Drawing.Point(5, 149)
        Me.lblJEDeadline.Name = "lblJEDeadline"
        Me.lblJEDeadline.Size = New System.Drawing.Size(72, 13)
        Me.lblJEDeadline.TabIndex = 1
        Me.lblJEDeadline.Text = "Job Deadline:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Project Name:"
        '
        'btnJEBack
        '
        Me.btnJEBack.Location = New System.Drawing.Point(438, 553)
        Me.btnJEBack.Name = "btnJEBack"
        Me.btnJEBack.Size = New System.Drawing.Size(103, 23)
        Me.btnJEBack.TabIndex = 14
        Me.btnJEBack.Text = "&Back"
        Me.btnJEBack.UseVisualStyleBackColor = True
        '
        'lblJEName
        '
        Me.lblJEName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJEName.Location = New System.Drawing.Point(103, 34)
        Me.lblJEName.Name = "lblJEName"
        Me.lblJEName.Size = New System.Drawing.Size(377, 25)
        Me.lblJEName.TabIndex = 17
        Me.lblJEName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(320, 553)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(103, 23)
        Me.btnSubmit.TabIndex = 18
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'JobEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 599)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblJEName)
        Me.Controls.Add(Me.btnJEBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "JobEditForm"
        Me.Text = "Edit Job Information"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblJEDeadline As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnJEBack As System.Windows.Forms.Button
    Friend WithEvents txtJEDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtDeadline As System.Windows.Forms.TextBox
    Friend WithEvents txtJEStart As System.Windows.Forms.TextBox
    Friend WithEvents txtJELocation As System.Windows.Forms.TextBox
    Friend WithEvents txtJEClient As System.Windows.Forms.TextBox
    Friend WithEvents txtJEName As System.Windows.Forms.TextBox
    Friend WithEvents lblJEName As System.Windows.Forms.Label
    Friend WithEvents txtJETitle1 As System.Windows.Forms.TextBox
    Friend WithEvents txtJETitleLead As System.Windows.Forms.TextBox
    Friend WithEvents txtJEEmployee3 As System.Windows.Forms.TextBox
    Friend WithEvents txtJEEmployee2 As System.Windows.Forms.TextBox
    Friend WithEvents txtJEEmployee1 As System.Windows.Forms.TextBox
    Friend WithEvents txtJELead As System.Windows.Forms.TextBox
    Friend WithEvents txtJETitle3 As System.Windows.Forms.TextBox
    Friend WithEvents txtJETitle2 As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
