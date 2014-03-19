<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentForm
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
        Me.btnPayBack = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPayCredit = New System.Windows.Forms.Button()
        Me.btnPayCancel = New System.Windows.Forms.Button()
        Me.btnPayRecord = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Managing Payments Form"
        '
        'btnPayBack
        '
        Me.btnPayBack.Location = New System.Drawing.Point(265, 195)
        Me.btnPayBack.Name = "btnPayBack"
        Me.btnPayBack.Size = New System.Drawing.Size(103, 23)
        Me.btnPayBack.TabIndex = 4
        Me.btnPayBack.Text = "&Back"
        Me.btnPayBack.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPayCredit)
        Me.GroupBox1.Controls.Add(Me.btnPayCancel)
        Me.GroupBox1.Controls.Add(Me.btnPayRecord)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Location = New System.Drawing.Point(12, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(233, 159)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "What Would You Like to do?"
        '
        'btnPayCredit
        '
        Me.btnPayCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayCredit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPayCredit.Location = New System.Drawing.Point(38, 77)
        Me.btnPayCredit.Name = "btnPayCredit"
        Me.btnPayCredit.Size = New System.Drawing.Size(157, 26)
        Me.btnPayCredit.TabIndex = 7
        Me.btnPayCredit.Text = "Credit Account"
        Me.btnPayCredit.UseVisualStyleBackColor = True
        '
        'btnPayCancel
        '
        Me.btnPayCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPayCancel.Location = New System.Drawing.Point(38, 119)
        Me.btnPayCancel.Name = "btnPayCancel"
        Me.btnPayCancel.Size = New System.Drawing.Size(157, 26)
        Me.btnPayCancel.TabIndex = 3
        Me.btnPayCancel.Text = "Cancel Payment"
        Me.btnPayCancel.UseVisualStyleBackColor = True
        '
        'btnPayRecord
        '
        Me.btnPayRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayRecord.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPayRecord.Location = New System.Drawing.Point(38, 35)
        Me.btnPayRecord.Name = "btnPayRecord"
        Me.btnPayRecord.Size = New System.Drawing.Size(157, 26)
        Me.btnPayRecord.TabIndex = 1
        Me.btnPayRecord.Text = "Record Payment"
        Me.btnPayRecord.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(393, 24)
        Me.MenuStrip1.TabIndex = 7
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
        'PaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 245)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPayBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PaymentForm"
        Me.Text = "Manage Payments Home"
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPayBack As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPayRecord As System.Windows.Forms.Button
    Friend WithEvents btnPayCredit As System.Windows.Forms.Button
    Friend WithEvents btnPayCancel As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
