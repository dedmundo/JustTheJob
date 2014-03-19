<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JobListForm
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
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowHideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompletedJobsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PendingJobsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllJobsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbJLCompleted = New System.Windows.Forms.GroupBox()
        Me.lstCompletedLead = New System.Windows.Forms.ListBox()
        Me.lstCompletedDeadline = New System.Windows.Forms.ListBox()
        Me.lstCompletedStart = New System.Windows.Forms.ListBox()
        Me.lstCompletedClient = New System.Windows.Forms.ListBox()
        Me.lstCompletedName = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbJLPending = New System.Windows.Forms.GroupBox()
        Me.lstPendingLead = New System.Windows.Forms.ListBox()
        Me.lstPendingName = New System.Windows.Forms.ListBox()
        Me.lstPendingClient = New System.Windows.Forms.ListBox()
        Me.lstPendingStart = New System.Windows.Forms.ListBox()
        Me.lstPendingDeadline = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnJLBack = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.gbJLCompleted.SuspendLayout()
        Me.gbJLPending.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ShowHideToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(833, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.BackToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(96, 6)
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.BackToolStripMenuItem.Text = "&Back"
        '
        'ShowHideToolStripMenuItem
        '
        Me.ShowHideToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompletedJobsToolStripMenuItem, Me.PendingJobsToolStripMenuItem, Me.AllJobsToolStripMenuItem})
        Me.ShowHideToolStripMenuItem.Name = "ShowHideToolStripMenuItem"
        Me.ShowHideToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.ShowHideToolStripMenuItem.Text = "Show/Hide"
        '
        'CompletedJobsToolStripMenuItem
        '
        Me.CompletedJobsToolStripMenuItem.Name = "CompletedJobsToolStripMenuItem"
        Me.CompletedJobsToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.CompletedJobsToolStripMenuItem.Text = "Completed Jobs"
        '
        'PendingJobsToolStripMenuItem
        '
        Me.PendingJobsToolStripMenuItem.Name = "PendingJobsToolStripMenuItem"
        Me.PendingJobsToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.PendingJobsToolStripMenuItem.Text = "Pending Jobs"
        '
        'AllJobsToolStripMenuItem
        '
        Me.AllJobsToolStripMenuItem.Name = "AllJobsToolStripMenuItem"
        Me.AllJobsToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.AllJobsToolStripMenuItem.Text = "All Jobs"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(337, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "View Job Lists"
        '
        'gbJLCompleted
        '
        Me.gbJLCompleted.Controls.Add(Me.lstCompletedLead)
        Me.gbJLCompleted.Controls.Add(Me.lstCompletedDeadline)
        Me.gbJLCompleted.Controls.Add(Me.lstCompletedStart)
        Me.gbJLCompleted.Controls.Add(Me.lstCompletedClient)
        Me.gbJLCompleted.Controls.Add(Me.lstCompletedName)
        Me.gbJLCompleted.Controls.Add(Me.Label6)
        Me.gbJLCompleted.Controls.Add(Me.Label5)
        Me.gbJLCompleted.Controls.Add(Me.Label4)
        Me.gbJLCompleted.Controls.Add(Me.Label3)
        Me.gbJLCompleted.Controls.Add(Me.Label2)
        Me.gbJLCompleted.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbJLCompleted.ForeColor = System.Drawing.SystemColors.Desktop
        Me.gbJLCompleted.Location = New System.Drawing.Point(13, 65)
        Me.gbJLCompleted.Name = "gbJLCompleted"
        Me.gbJLCompleted.Size = New System.Drawing.Size(809, 269)
        Me.gbJLCompleted.TabIndex = 13
        Me.gbJLCompleted.TabStop = False
        Me.gbJLCompleted.Text = "Completed Jobs"
        '
        'lstCompletedLead
        '
        Me.lstCompletedLead.FormattingEnabled = True
        Me.lstCompletedLead.ItemHeight = 16
        Me.lstCompletedLead.Location = New System.Drawing.Point(655, 46)
        Me.lstCompletedLead.Name = "lstCompletedLead"
        Me.lstCompletedLead.Size = New System.Drawing.Size(118, 212)
        Me.lstCompletedLead.TabIndex = 9
        '
        'lstCompletedDeadline
        '
        Me.lstCompletedDeadline.FormattingEnabled = True
        Me.lstCompletedDeadline.ItemHeight = 16
        Me.lstCompletedDeadline.Location = New System.Drawing.Point(507, 46)
        Me.lstCompletedDeadline.Name = "lstCompletedDeadline"
        Me.lstCompletedDeadline.Size = New System.Drawing.Size(118, 212)
        Me.lstCompletedDeadline.TabIndex = 8
        '
        'lstCompletedStart
        '
        Me.lstCompletedStart.FormattingEnabled = True
        Me.lstCompletedStart.ItemHeight = 16
        Me.lstCompletedStart.Location = New System.Drawing.Point(369, 46)
        Me.lstCompletedStart.Name = "lstCompletedStart"
        Me.lstCompletedStart.Size = New System.Drawing.Size(118, 212)
        Me.lstCompletedStart.TabIndex = 7
        '
        'lstCompletedClient
        '
        Me.lstCompletedClient.FormattingEnabled = True
        Me.lstCompletedClient.ItemHeight = 16
        Me.lstCompletedClient.Location = New System.Drawing.Point(188, 46)
        Me.lstCompletedClient.Name = "lstCompletedClient"
        Me.lstCompletedClient.Size = New System.Drawing.Size(165, 212)
        Me.lstCompletedClient.TabIndex = 6
        '
        'lstCompletedName
        '
        Me.lstCompletedName.FormattingEnabled = True
        Me.lstCompletedName.ItemHeight = 16
        Me.lstCompletedName.Location = New System.Drawing.Point(6, 46)
        Me.lstCompletedName.Name = "lstCompletedName"
        Me.lstCompletedName.Size = New System.Drawing.Size(163, 212)
        Me.lstCompletedName.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(249, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Client"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(657, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Job Lead"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(525, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Job Deadline"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(383, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Job Start Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(53, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Job Name"
        '
        'gbJLPending
        '
        Me.gbJLPending.Controls.Add(Me.lstPendingLead)
        Me.gbJLPending.Controls.Add(Me.lstPendingName)
        Me.gbJLPending.Controls.Add(Me.lstPendingClient)
        Me.gbJLPending.Controls.Add(Me.lstPendingStart)
        Me.gbJLPending.Controls.Add(Me.lstPendingDeadline)
        Me.gbJLPending.Controls.Add(Me.Label7)
        Me.gbJLPending.Controls.Add(Me.Label8)
        Me.gbJLPending.Controls.Add(Me.Label9)
        Me.gbJLPending.Controls.Add(Me.Label10)
        Me.gbJLPending.Controls.Add(Me.Label11)
        Me.gbJLPending.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbJLPending.ForeColor = System.Drawing.SystemColors.Desktop
        Me.gbJLPending.Location = New System.Drawing.Point(13, 340)
        Me.gbJLPending.Name = "gbJLPending"
        Me.gbJLPending.Size = New System.Drawing.Size(809, 269)
        Me.gbJLPending.TabIndex = 14
        Me.gbJLPending.TabStop = False
        Me.gbJLPending.Text = "Pending Jobs"
        '
        'lstPendingLead
        '
        Me.lstPendingLead.FormattingEnabled = True
        Me.lstPendingLead.ItemHeight = 16
        Me.lstPendingLead.Location = New System.Drawing.Point(655, 51)
        Me.lstPendingLead.Name = "lstPendingLead"
        Me.lstPendingLead.Size = New System.Drawing.Size(118, 212)
        Me.lstPendingLead.TabIndex = 15
        '
        'lstPendingName
        '
        Me.lstPendingName.FormattingEnabled = True
        Me.lstPendingName.ItemHeight = 16
        Me.lstPendingName.Location = New System.Drawing.Point(6, 51)
        Me.lstPendingName.Name = "lstPendingName"
        Me.lstPendingName.Size = New System.Drawing.Size(163, 212)
        Me.lstPendingName.TabIndex = 14
        '
        'lstPendingClient
        '
        Me.lstPendingClient.FormattingEnabled = True
        Me.lstPendingClient.ItemHeight = 16
        Me.lstPendingClient.Location = New System.Drawing.Point(188, 51)
        Me.lstPendingClient.Name = "lstPendingClient"
        Me.lstPendingClient.Size = New System.Drawing.Size(165, 212)
        Me.lstPendingClient.TabIndex = 13
        '
        'lstPendingStart
        '
        Me.lstPendingStart.FormattingEnabled = True
        Me.lstPendingStart.ItemHeight = 16
        Me.lstPendingStart.Location = New System.Drawing.Point(369, 51)
        Me.lstPendingStart.Name = "lstPendingStart"
        Me.lstPendingStart.Size = New System.Drawing.Size(118, 212)
        Me.lstPendingStart.TabIndex = 12
        '
        'lstPendingDeadline
        '
        Me.lstPendingDeadline.FormattingEnabled = True
        Me.lstPendingDeadline.ItemHeight = 16
        Me.lstPendingDeadline.Location = New System.Drawing.Point(507, 51)
        Me.lstPendingDeadline.Name = "lstPendingDeadline"
        Me.lstPendingDeadline.Size = New System.Drawing.Size(118, 212)
        Me.lstPendingDeadline.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(249, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Client"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(657, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Job Lead"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(525, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Job Deadline"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(383, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 16)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Job Start Date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(53, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Job Name"
        '
        'btnJLBack
        '
        Me.btnJLBack.Location = New System.Drawing.Point(705, 624)
        Me.btnJLBack.Name = "btnJLBack"
        Me.btnJLBack.Size = New System.Drawing.Size(103, 23)
        Me.btnJLBack.TabIndex = 15
        Me.btnJLBack.Text = "&Back"
        Me.btnJLBack.UseVisualStyleBackColor = True
        '
        'JobListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 669)
        Me.Controls.Add(Me.btnJLBack)
        Me.Controls.Add(Me.gbJLPending)
        Me.Controls.Add(Me.gbJLCompleted)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "JobListForm"
        Me.Text = "List of Completed and Pending Jobs"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbJLCompleted.ResumeLayout(False)
        Me.gbJLCompleted.PerformLayout()
        Me.gbJLPending.ResumeLayout(False)
        Me.gbJLPending.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbJLCompleted As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowHideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompletedJobsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PendingJobsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gbJLPending As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnJLBack As System.Windows.Forms.Button
    Friend WithEvents lstCompletedDeadline As System.Windows.Forms.ListBox
    Friend WithEvents lstCompletedStart As System.Windows.Forms.ListBox
    Friend WithEvents lstCompletedClient As System.Windows.Forms.ListBox
    Friend WithEvents lstCompletedName As System.Windows.Forms.ListBox
    Friend WithEvents lstPendingName As System.Windows.Forms.ListBox
    Friend WithEvents lstPendingClient As System.Windows.Forms.ListBox
    Friend WithEvents lstPendingStart As System.Windows.Forms.ListBox
    Friend WithEvents lstPendingDeadline As System.Windows.Forms.ListBox
    Friend WithEvents lstCompletedLead As System.Windows.Forms.ListBox
    Friend WithEvents lstPendingLead As System.Windows.Forms.ListBox
    Friend WithEvents AllJobsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
