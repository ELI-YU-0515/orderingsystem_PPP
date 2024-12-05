<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transact_Form
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
        PictureBox2 = New PictureBox()
        customer_label = New Label()
        address_label = New Label()
        customer_input = New TextBox()
        address_input = New TextBox()
        contact_label = New Label()
        installment_btn = New Button()
        downpayment_btn = New Button()
        Label5 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        addID_btn = New Button()
        IDPicture_box = New PictureBox()
        contact_input = New MaskedTextBox()
        date_input = New MaskedTextBox()
        prebuild_checkbox = New CheckBox()
        date_label = New Label()
        Label1 = New Label()
        Label2 = New Label()
        cashamount_input = New MaskedTextBox()
        discount_input = New MaskedTextBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(IDPicture_box, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.LOGO3
        PictureBox2.Location = New Point(12, 203)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(220, 185)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 42
        PictureBox2.TabStop = False
        ' 
        ' customer_label
        ' 
        customer_label.AutoSize = True
        customer_label.Font = New Font("Verdana", 12F)
        customer_label.Location = New Point(29, 31)
        customer_label.Name = "customer_label"
        customer_label.Size = New Size(93, 18)
        customer_label.TabIndex = 43
        customer_label.Text = "Customer:"
        ' 
        ' address_label
        ' 
        address_label.AutoSize = True
        address_label.Font = New Font("Verdana", 12F)
        address_label.Location = New Point(29, 68)
        address_label.Name = "address_label"
        address_label.Size = New Size(80, 18)
        address_label.TabIndex = 44
        address_label.Text = "Address:"
        ' 
        ' customer_input
        ' 
        customer_input.Location = New Point(143, 29)
        customer_input.Name = "customer_input"
        customer_input.Size = New Size(326, 23)
        customer_input.TabIndex = 45
        ' 
        ' address_input
        ' 
        address_input.Location = New Point(143, 68)
        address_input.Name = "address_input"
        address_input.Size = New Size(599, 23)
        address_input.TabIndex = 46
        ' 
        ' contact_label
        ' 
        contact_label.AutoSize = True
        contact_label.Font = New Font("Verdana", 12F)
        contact_label.Location = New Point(29, 94)
        contact_label.Name = "contact_label"
        contact_label.Size = New Size(78, 36)
        contact_label.TabIndex = 50
        contact_label.Text = "Phone " & vbCrLf & "Number:"
        ' 
        ' installment_btn
        ' 
        installment_btn.FlatStyle = FlatStyle.System
        installment_btn.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        installment_btn.Location = New Point(576, 221)
        installment_btn.Name = "installment_btn"
        installment_btn.Size = New Size(166, 34)
        installment_btn.TabIndex = 51
        installment_btn.Text = "INSTALLMENT"
        installment_btn.UseVisualStyleBackColor = True
        ' 
        ' downpayment_btn
        ' 
        downpayment_btn.FlatStyle = FlatStyle.System
        downpayment_btn.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        downpayment_btn.Location = New Point(576, 271)
        downpayment_btn.Name = "downpayment_btn"
        downpayment_btn.Size = New Size(166, 34)
        downpayment_btn.TabIndex = 52
        downpayment_btn.Text = "DOWN PAYMENT"
        downpayment_btn.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Verdana", 12F)
        Label5.Location = New Point(257, 185)
        Label5.Name = "Label5"
        Label5.Size = New Size(135, 18)
        Label5.TabIndex = 53
        Label5.Text = "ID PRESENTED:"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' addID_btn
        ' 
        addID_btn.FlatStyle = FlatStyle.System
        addID_btn.Font = New Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addID_btn.Location = New Point(406, 181)
        addID_btn.Name = "addID_btn"
        addID_btn.Size = New Size(32, 28)
        addID_btn.TabIndex = 54
        addID_btn.Text = "+"
        addID_btn.UseVisualStyleBackColor = True
        ' 
        ' IDPicture_box
        ' 
        IDPicture_box.BorderStyle = BorderStyle.FixedSingle
        IDPicture_box.Location = New Point(257, 221)
        IDPicture_box.Name = "IDPicture_box"
        IDPicture_box.Size = New Size(282, 136)
        IDPicture_box.SizeMode = PictureBoxSizeMode.Zoom
        IDPicture_box.TabIndex = 55
        IDPicture_box.TabStop = False
        ' 
        ' contact_input
        ' 
        contact_input.AllowPromptAsInput = False
        contact_input.InsertKeyMode = InsertKeyMode.Overwrite
        contact_input.Location = New Point(143, 107)
        contact_input.Name = "contact_input"
        contact_input.Size = New Size(326, 23)
        contact_input.TabIndex = 56
        ' 
        ' date_input
        ' 
        date_input.AllowPromptAsInput = False
        date_input.InsertKeyMode = InsertKeyMode.Overwrite
        date_input.Location = New Point(588, 29)
        date_input.Name = "date_input"
        date_input.Size = New Size(154, 23)
        date_input.TabIndex = 57
        date_input.ValidatingType = GetType(Date)
        ' 
        ' prebuild_checkbox
        ' 
        prebuild_checkbox.AutoSize = True
        prebuild_checkbox.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        prebuild_checkbox.Location = New Point(576, 321)
        prebuild_checkbox.Name = "prebuild_checkbox"
        prebuild_checkbox.Size = New Size(107, 22)
        prebuild_checkbox.TabIndex = 58
        prebuild_checkbox.Text = "PRE-BUILD"
        prebuild_checkbox.UseVisualStyleBackColor = True
        ' 
        ' date_label
        ' 
        date_label.AllowDrop = True
        date_label.AutoSize = True
        date_label.Font = New Font("Verdana", 12F)
        date_label.Location = New Point(484, 31)
        date_label.Name = "date_label"
        date_label.Size = New Size(54, 18)
        date_label.TabIndex = 48
        date_label.Text = "Date:"
        ' 
        ' Label1
        ' 
        Label1.AllowDrop = True
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 12F)
        Label1.Location = New Point(484, 107)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 18)
        Label1.TabIndex = 59
        Label1.Text = "Cash Amount"
        ' 
        ' Label2
        ' 
        Label2.AllowDrop = True
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 12F)
        Label2.Location = New Point(484, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 18)
        Label2.TabIndex = 60
        Label2.Text = "Discount (%)"
        ' 
        ' cashamount_input
        ' 
        cashamount_input.AllowPromptAsInput = False
        cashamount_input.InsertKeyMode = InsertKeyMode.Overwrite
        cashamount_input.Location = New Point(607, 107)
        cashamount_input.Name = "cashamount_input"
        cashamount_input.Size = New Size(135, 23)
        cashamount_input.TabIndex = 57
        cashamount_input.ValidatingType = GetType(Date)
        ' 
        ' discount_input
        ' 
        discount_input.AllowPromptAsInput = False
        discount_input.InsertKeyMode = InsertKeyMode.Overwrite
        discount_input.Location = New Point(607, 145)
        discount_input.Name = "discount_input"
        discount_input.Size = New Size(135, 23)
        discount_input.TabIndex = 61
        discount_input.ValidatingType = GetType(Date)
        ' 
        ' Transact_Form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(795, 400)
        Controls.Add(discount_input)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(prebuild_checkbox)
        Controls.Add(cashamount_input)
        Controls.Add(date_input)
        Controls.Add(contact_input)
        Controls.Add(IDPicture_box)
        Controls.Add(addID_btn)
        Controls.Add(Label5)
        Controls.Add(downpayment_btn)
        Controls.Add(installment_btn)
        Controls.Add(contact_label)
        Controls.Add(date_label)
        Controls.Add(address_input)
        Controls.Add(customer_input)
        Controls.Add(address_label)
        Controls.Add(customer_label)
        Controls.Add(PictureBox2)
        Name = "Transact_Form"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Transact_Form"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(IDPicture_box, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents customer_label As Label
    Friend WithEvents address_label As Label
    Friend WithEvents customer_input As TextBox
    Friend WithEvents address_input As TextBox
    Friend WithEvents contact_label As Label
    Friend WithEvents installment_btn As Button
    Friend WithEvents downpayment_btn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents addID_btn As Button
    Friend WithEvents IDPicture_box As PictureBox
    Friend WithEvents contact_input As MaskedTextBox
    Friend WithEvents date_input As MaskedTextBox
    Friend WithEvents prebuild_checkbox As CheckBox
    Friend WithEvents date_label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cashamount_input As MaskedTextBox
    Friend WithEvents discount_input As MaskedTextBox
End Class
