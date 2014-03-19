<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CancelPaymentForm
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
        Me.lblInvoice = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstPayments = New System.Windows.Forms.ListBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInvoice
        '
        Me.lblInvoice.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblInvoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInvoice.Location = New System.Drawing.Point(203, 50)
        Me.lblInvoice.Name = "lblInvoice"
        Me.lblInvoice.Size = New System.Drawing.Size(152, 23)
        Me.lblInvoice.TabIndex = 9
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(19, 50)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(104, 23)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search Invoices"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Cancel a Payment"
        '
        'lstPayments
        '
        Me.lstPayments.FormattingEnabled = True
        Me.lstPayments.Location = New System.Drawing.Point(19, 80)
        Me.lstPayments.Name = "lstPayments"
        Me.lstPayments.Size = New System.Drawing.Size(336, 121)
        Me.lstPayments.TabIndex = 10
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(279, 208)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(19, 207)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 23)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel Payment"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'CancelPaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 242)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lstPayments)
        Me.Controls.Add(Me.lblInvoice)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CancelPaymentForm"
        Me.Text = "Cancel A Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInvoice As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstPayments As System.Windows.Forms.ListBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
