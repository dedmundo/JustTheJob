<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoiceForm
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
        Me.btnInvBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gpOneTime = New System.Windows.Forms.GroupBox()
        Me.btnInvShowAll = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblOTShow = New System.Windows.Forms.Label()
        Me.btnInv1TStatus = New System.Windows.Forms.Button()
        Me.btnInv1TShow = New System.Windows.Forms.Button()
        Me.btnNew1TInvoice = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gpOneTime.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnInvBack
        '
        Me.btnInvBack.Location = New System.Drawing.Point(386, 264)
        Me.btnInvBack.Name = "btnInvBack"
        Me.btnInvBack.Size = New System.Drawing.Size(96, 23)
        Me.btnInvBack.TabIndex = 3
        Me.btnInvBack.Text = "&Back"
        Me.btnInvBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Managing Invoices Form"
        '
        'gpOneTime
        '
        Me.gpOneTime.Controls.Add(Me.btnInvShowAll)
        Me.gpOneTime.Controls.Add(Me.lblStatus)
        Me.gpOneTime.Controls.Add(Me.lblOTShow)
        Me.gpOneTime.Controls.Add(Me.btnInv1TStatus)
        Me.gpOneTime.Controls.Add(Me.btnInv1TShow)
        Me.gpOneTime.Controls.Add(Me.btnNew1TInvoice)
        Me.gpOneTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpOneTime.ForeColor = System.Drawing.SystemColors.Desktop
        Me.gpOneTime.Location = New System.Drawing.Point(12, 79)
        Me.gpOneTime.Name = "gpOneTime"
        Me.gpOneTime.Size = New System.Drawing.Size(361, 208)
        Me.gpOneTime.TabIndex = 6
        Me.gpOneTime.TabStop = False
        Me.gpOneTime.Text = "Invoices:"
        '
        'btnInvShowAll
        '
        Me.btnInvShowAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvShowAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnInvShowAll.Location = New System.Drawing.Point(16, 176)
        Me.btnInvShowAll.Name = "btnInvShowAll"
        Me.btnInvShowAll.Size = New System.Drawing.Size(165, 26)
        Me.btnInvShowAll.TabIndex = 8
        Me.btnInvShowAll.Text = "Show All Invoices"
        Me.btnInvShowAll.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblStatus.Location = New System.Drawing.Point(187, 139)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(40, 13)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "Status:"
        Me.lblStatus.Visible = False
        '
        'lblOTShow
        '
        Me.lblOTShow.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblOTShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOTShow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOTShow.Location = New System.Drawing.Point(233, 133)
        Me.lblOTShow.Name = "lblOTShow"
        Me.lblOTShow.Size = New System.Drawing.Size(114, 26)
        Me.lblOTShow.TabIndex = 6
        Me.lblOTShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblOTShow.Visible = False
        '
        'btnInv1TStatus
        '
        Me.btnInv1TStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInv1TStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnInv1TStatus.Location = New System.Drawing.Point(16, 132)
        Me.btnInv1TStatus.Name = "btnInv1TStatus"
        Me.btnInv1TStatus.Size = New System.Drawing.Size(165, 26)
        Me.btnInv1TStatus.TabIndex = 3
        Me.btnInv1TStatus.Text = "Show Invoice Payment Status"
        Me.btnInv1TStatus.UseVisualStyleBackColor = True
        '
        'btnInv1TShow
        '
        Me.btnInv1TShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInv1TShow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnInv1TShow.Location = New System.Drawing.Point(16, 88)
        Me.btnInv1TShow.Name = "btnInv1TShow"
        Me.btnInv1TShow.Size = New System.Drawing.Size(165, 26)
        Me.btnInv1TShow.TabIndex = 2
        Me.btnInv1TShow.Text = "Show Invoice"
        Me.btnInv1TShow.UseVisualStyleBackColor = True
        '
        'btnNew1TInvoice
        '
        Me.btnNew1TInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew1TInvoice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNew1TInvoice.Location = New System.Drawing.Point(16, 40)
        Me.btnNew1TInvoice.Name = "btnNew1TInvoice"
        Me.btnNew1TInvoice.Size = New System.Drawing.Size(165, 26)
        Me.btnNew1TInvoice.TabIndex = 1
        Me.btnNew1TInvoice.Text = "Create Invoice"
        Me.btnNew1TInvoice.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(494, 24)
        Me.MenuStrip1.TabIndex = 8
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
        'InvoiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 299)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.gpOneTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnInvBack)
        Me.Name = "InvoiceForm"
        Me.Text = "Manage Invoice Form"
        Me.gpOneTime.ResumeLayout(False)
        Me.gpOneTime.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnInvBack As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gpOneTime As System.Windows.Forms.GroupBox
    Friend WithEvents btnInv1TStatus As System.Windows.Forms.Button
    Friend WithEvents btnInv1TShow As System.Windows.Forms.Button
    Friend WithEvents btnNew1TInvoice As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblOTShow As System.Windows.Forms.Label
    Friend WithEvents btnInvShowAll As System.Windows.Forms.Button
End Class
