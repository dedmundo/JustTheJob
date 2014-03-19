<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoiceListForm
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
        Me.lstPaid = New System.Windows.Forms.ListBox()
        Me.lstPayment = New System.Windows.Forms.ListBox()
        Me.lstCustomerName = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCLBack = New System.Windows.Forms.Button()
        Me.lstComplete = New System.Windows.Forms.ListBox()
        Me.lstMethod = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.radOne = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstID = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstPaid
        '
        Me.lstPaid.FormattingEnabled = True
        Me.lstPaid.Location = New System.Drawing.Point(466, 89)
        Me.lstPaid.Name = "lstPaid"
        Me.lstPaid.Size = New System.Drawing.Size(133, 251)
        Me.lstPaid.TabIndex = 27
        '
        'lstPayment
        '
        Me.lstPayment.FormattingEnabled = True
        Me.lstPayment.Location = New System.Drawing.Point(340, 88)
        Me.lstPayment.Name = "lstPayment"
        Me.lstPayment.Size = New System.Drawing.Size(120, 251)
        Me.lstPayment.TabIndex = 26
        '
        'lstCustomerName
        '
        Me.lstCustomerName.FormattingEnabled = True
        Me.lstCustomerName.Location = New System.Drawing.Point(179, 89)
        Me.lstCustomerName.Name = "lstCustomerName"
        Me.lstCustomerName.Size = New System.Drawing.Size(155, 251)
        Me.lstCustomerName.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(483, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Amount Paid"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(337, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Total Payment Due"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(45, 69)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(72, 16)
        Me.label10.TabIndex = 21
        Me.label10.Text = "ID Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(205, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Customer Name"
        '
        'btnCLBack
        '
        Me.btnCLBack.Location = New System.Drawing.Point(786, 358)
        Me.btnCLBack.Name = "btnCLBack"
        Me.btnCLBack.Size = New System.Drawing.Size(103, 23)
        Me.btnCLBack.TabIndex = 18
        Me.btnCLBack.Text = "&Back"
        Me.btnCLBack.UseVisualStyleBackColor = True
        '
        'lstComplete
        '
        Me.lstComplete.FormattingEnabled = True
        Me.lstComplete.Location = New System.Drawing.Point(771, 88)
        Me.lstComplete.Name = "lstComplete"
        Me.lstComplete.Size = New System.Drawing.Size(120, 251)
        Me.lstComplete.TabIndex = 32
        '
        'lstMethod
        '
        Me.lstMethod.FormattingEnabled = True
        Me.lstMethod.Location = New System.Drawing.Point(605, 88)
        Me.lstMethod.Name = "lstMethod"
        Me.lstMethod.Size = New System.Drawing.Size(160, 251)
        Me.lstMethod.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(783, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Completion Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(631, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 16)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Payment Method"
        '
        'radOne
        '
        Me.radOne.AutoSize = True
        Me.radOne.Location = New System.Drawing.Point(8, 37)
        Me.radOne.Name = "radOne"
        Me.radOne.Size = New System.Drawing.Size(71, 17)
        Me.radOne.TabIndex = 33
        Me.radOne.TabStop = True
        Me.radOne.Text = "One Time"
        Me.radOne.UseVisualStyleBackColor = True
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Location = New System.Drawing.Point(85, 37)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(62, 17)
        Me.radRegular.TabIndex = 34
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "Regular"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(909, 24)
        Me.MenuStrip1.TabIndex = 35
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'lstID
        '
        Me.lstID.FormattingEnabled = True
        Me.lstID.Location = New System.Drawing.Point(12, 88)
        Me.lstID.Name = "lstID"
        Me.lstID.Size = New System.Drawing.Size(155, 251)
        Me.lstID.TabIndex = 36
        '
        'InvoiceListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 393)
        Me.Controls.Add(Me.lstID)
        Me.Controls.Add(Me.radRegular)
        Me.Controls.Add(Me.radOne)
        Me.Controls.Add(Me.lstComplete)
        Me.Controls.Add(Me.lstMethod)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lstPaid)
        Me.Controls.Add(Me.lstPayment)
        Me.Controls.Add(Me.lstCustomerName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCLBack)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "InvoiceListForm"
        Me.Text = "InvoiceListForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstPaid As System.Windows.Forms.ListBox
    Friend WithEvents lstPayment As System.Windows.Forms.ListBox
    Friend WithEvents lstCustomerName As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCLBack As System.Windows.Forms.Button
    Friend WithEvents lstComplete As System.Windows.Forms.ListBox
    Friend WithEvents lstMethod As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents radOne As System.Windows.Forms.RadioButton
    Friend WithEvents radRegular As System.Windows.Forms.RadioButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstID As System.Windows.Forms.ListBox
End Class
