<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecordPaymentForm
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblInvoice = New System.Windows.Forms.Label()
        Me.gbRPInvoice = New System.Windows.Forms.GroupBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPaid = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblCommWages = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbRPInvoice.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Recording Payment Form"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(12, 50)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(104, 23)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search Invoices"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblInvoice
        '
        Me.lblInvoice.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblInvoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInvoice.Location = New System.Drawing.Point(196, 50)
        Me.lblInvoice.Name = "lblInvoice"
        Me.lblInvoice.Size = New System.Drawing.Size(152, 23)
        Me.lblInvoice.TabIndex = 6
        Me.lblInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbRPInvoice
        '
        Me.gbRPInvoice.Controls.Add(Me.Label5)
        Me.gbRPInvoice.Controls.Add(Me.lblAmount)
        Me.gbRPInvoice.Controls.Add(Me.Label4)
        Me.gbRPInvoice.Controls.Add(Me.lblCustomer)
        Me.gbRPInvoice.Controls.Add(Me.Label2)
        Me.gbRPInvoice.ForeColor = System.Drawing.SystemColors.Desktop
        Me.gbRPInvoice.Location = New System.Drawing.Point(13, 80)
        Me.gbRPInvoice.Name = "gbRPInvoice"
        Me.gbRPInvoice.Size = New System.Drawing.Size(375, 85)
        Me.gbRPInvoice.TabIndex = 7
        Me.gbRPInvoice.TabStop = False
        Me.gbRPInvoice.Text = "Invoice Information"
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
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Amount Due:"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Amount Paid:"
        '
        'txtPaid
        '
        Me.txtPaid.Location = New System.Drawing.Point(260, 169)
        Me.txtPaid.Name = "txtPaid"
        Me.txtPaid.Size = New System.Drawing.Size(88, 20)
        Me.txtPaid.TabIndex = 9
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(285, 204)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(103, 23)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(162, 204)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(103, 23)
        Me.btnSubmit.TabIndex = 13
        Me.btnSubmit.Text = "&Submit Payment"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblCommWages
        '
        Me.lblCommWages.AutoSize = True
        Me.lblCommWages.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommWages.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCommWages.Location = New System.Drawing.Point(235, 167)
        Me.lblCommWages.Name = "lblCommWages"
        Me.lblCommWages.Size = New System.Drawing.Size(19, 20)
        Me.lblCommWages.TabIndex = 22
        Me.lblCommWages.Text = "$"
        Me.lblCommWages.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(222, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "$"
        Me.Label5.Visible = False
        '
        'RecordPaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 240)
        Me.Controls.Add(Me.lblCommWages)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtPaid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gbRPInvoice)
        Me.Controls.Add(Me.lblInvoice)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RecordPaymentForm"
        Me.Text = "Record Payment Form"
        Me.gbRPInvoice.ResumeLayout(False)
        Me.gbRPInvoice.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblInvoice As System.Windows.Forms.Label
    Friend WithEvents gbRPInvoice As System.Windows.Forms.GroupBox
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPaid As System.Windows.Forms.TextBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCommWages As System.Windows.Forms.Label
End Class
