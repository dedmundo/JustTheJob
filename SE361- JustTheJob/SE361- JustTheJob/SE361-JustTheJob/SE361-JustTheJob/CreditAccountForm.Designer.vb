<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreditAccountForm
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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtCredit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbRPInvoice = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblInvoice = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gbRPInvoice.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(158, 228)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(103, 23)
        Me.btnSubmit.TabIndex = 21
        Me.btnSubmit.Text = "&Credit Account"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(284, 228)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(103, 23)
        Me.btnBack.TabIndex = 20
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtCredit
        '
        Me.txtCredit.Location = New System.Drawing.Point(259, 182)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(88, 20)
        Me.txtCredit.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Credit Amount:"
        '
        'gbRPInvoice
        '
        Me.gbRPInvoice.Controls.Add(Me.Label5)
        Me.gbRPInvoice.Controls.Add(Me.lblAmount)
        Me.gbRPInvoice.Controls.Add(Me.Label4)
        Me.gbRPInvoice.Controls.Add(Me.lblCustomer)
        Me.gbRPInvoice.Controls.Add(Me.Label2)
        Me.gbRPInvoice.ForeColor = System.Drawing.SystemColors.Desktop
        Me.gbRPInvoice.Location = New System.Drawing.Point(11, 88)
        Me.gbRPInvoice.Name = "gbRPInvoice"
        Me.gbRPInvoice.Size = New System.Drawing.Size(375, 85)
        Me.gbRPInvoice.TabIndex = 17
        Me.gbRPInvoice.TabStop = False
        Me.gbRPInvoice.Text = "Invoice Information"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(223, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "$"
        Me.Label5.Visible = False
        '
        'lblAmount
        '
        Me.lblAmount.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAmount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAmount.Location = New System.Drawing.Point(247, 49)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(88, 23)
        Me.lblAmount.TabIndex = 9
        Me.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(7, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total Amount Due:"
        '
        'lblCustomer
        '
        Me.lblCustomer.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCustomer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCustomer.Location = New System.Drawing.Point(210, 19)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(125, 23)
        Me.lblCustomer.TabIndex = 7
        Me.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(7, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Customer Name:"
        '
        'lblInvoice
        '
        Me.lblInvoice.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblInvoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInvoice.Location = New System.Drawing.Point(195, 59)
        Me.lblInvoice.Name = "lblInvoice"
        Me.lblInvoice.Size = New System.Drawing.Size(152, 23)
        Me.lblInvoice.TabIndex = 16
        Me.lblInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(11, 59)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(104, 23)
        Me.btnSearch.TabIndex = 15
        Me.btnSearch.Text = "Search Invoices"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(129, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Credit Account"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(404, 24)
        Me.MenuStrip1.TabIndex = 22
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(234, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 20)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "$"
        Me.Label10.Visible = False
        '
        'CreditAccountForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 263)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtCredit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gbRPInvoice)
        Me.Controls.Add(Me.lblInvoice)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CreditAccountForm"
        Me.Text = "Credit an Account"
        Me.gbRPInvoice.ResumeLayout(False)
        Me.gbRPInvoice.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents txtCredit As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbRPInvoice As System.Windows.Forms.GroupBox
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblInvoice As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
