<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewScheduleForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblVSStart = New System.Windows.Forms.Label()
        Me.lblVSEnd = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lsvSchedule = New System.Windows.Forms.ListView()
        Me.lblDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblLocation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblLength = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblAgenda = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnVSBack = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnView = New System.Windows.Forms.Button()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(722, 24)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(223, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Manager's Weekly Schedule"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(537, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "From:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(551, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "To:"
        '
        'lblVSStart
        '
        Me.lblVSStart.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblVSStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVSStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVSStart.Location = New System.Drawing.Point(585, 62)
        Me.lblVSStart.Name = "lblVSStart"
        Me.lblVSStart.Size = New System.Drawing.Size(91, 16)
        Me.lblVSStart.TabIndex = 15
        '
        'lblVSEnd
        '
        Me.lblVSEnd.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblVSEnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVSEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVSEnd.Location = New System.Drawing.Point(585, 78)
        Me.lblVSEnd.Name = "lblVSEnd"
        Me.lblVSEnd.Size = New System.Drawing.Size(91, 16)
        Me.lblVSEnd.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lsvSchedule)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Location = New System.Drawing.Point(13, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(697, 354)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "This Week's Schedule"
        '
        'lsvSchedule
        '
        Me.lsvSchedule.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lblDate, Me.lblName, Me.lblLocation, Me.lblTime, Me.lblLength, Me.lblAgenda})
        Me.lsvSchedule.FullRowSelect = True
        Me.lsvSchedule.Location = New System.Drawing.Point(6, 21)
        Me.lsvSchedule.MultiSelect = False
        Me.lsvSchedule.Name = "lsvSchedule"
        Me.lsvSchedule.Scrollable = False
        Me.lsvSchedule.Size = New System.Drawing.Size(681, 327)
        Me.lsvSchedule.TabIndex = 4
        Me.lsvSchedule.UseCompatibleStateImageBehavior = False
        Me.lsvSchedule.View = System.Windows.Forms.View.Details
        '
        'lblDate
        '
        Me.lblDate.Text = "Date"
        Me.lblDate.Width = 83
        '
        'lblName
        '
        Me.lblName.Text = "Name"
        Me.lblName.Width = 110
        '
        'lblLocation
        '
        Me.lblLocation.Text = "Location"
        Me.lblLocation.Width = 171
        '
        'lblTime
        '
        Me.lblTime.Text = "Time"
        Me.lblTime.Width = 70
        '
        'lblLength
        '
        Me.lblLength.Text = "Length"
        '
        'lblAgenda
        '
        Me.lblAgenda.Text = "Agenda"
        Me.lblAgenda.Width = 247
        '
        'btnVSBack
        '
        Me.btnVSBack.Location = New System.Drawing.Point(597, 464)
        Me.btnVSBack.Name = "btnVSBack"
        Me.btnVSBack.Size = New System.Drawing.Size(103, 23)
        Me.btnVSBack.TabIndex = 18
        Me.btnVSBack.Text = "&Back"
        Me.btnVSBack.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(13, 56)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 20
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(461, 464)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(103, 23)
        Me.btnView.TabIndex = 21
        Me.btnView.Text = "&View Appointment"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'ViewScheduleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 499)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnVSBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblVSEnd)
        Me.Controls.Add(Me.lblVSStart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "ViewScheduleForm"
        Me.Text = "Manager's Weekly Schedule"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblVSStart As System.Windows.Forms.Label
    Friend WithEvents lblVSEnd As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnVSBack As System.Windows.Forms.Button
    Friend WithEvents lsvSchedule As System.Windows.Forms.ListView
    Friend WithEvents lblDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblLocation As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblAgenda As System.Windows.Forms.ColumnHeader
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents lblLength As System.Windows.Forms.ColumnHeader
End Class
