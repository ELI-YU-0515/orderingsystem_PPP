<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MB_box = New ComboBox()
        CPU_box = New ComboBox()
        GPU_box = New ComboBox()
        MEM_box = New ComboBox()
        STOR_box = New ComboBox()
        PS_box = New ComboBox()
        CASE_box = New ComboBox()
        COOL_box = New ComboBox()
        MB_pic = New PictureBox()
        CPU_pic = New PictureBox()
        GPU_pic = New PictureBox()
        MEM_pic = New PictureBox()
        STOR_pic = New PictureBox()
        PS_pic = New PictureBox()
        CASE_pic = New PictureBox()
        COOL_pic = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        PictureBox9 = New PictureBox()
        PictureBox10 = New PictureBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        COOL_price = New Label()
        CASE_price = New Label()
        PS_price = New Label()
        STOR_price = New Label()
        MEM_price = New Label()
        GPU_price = New Label()
        CPU_price = New Label()
        MB_price = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        total_price = New Label()
        CType(MB_pic, ComponentModel.ISupportInitialize).BeginInit()
        CType(CPU_pic, ComponentModel.ISupportInitialize).BeginInit()
        CType(GPU_pic, ComponentModel.ISupportInitialize).BeginInit()
        CType(MEM_pic, ComponentModel.ISupportInitialize).BeginInit()
        CType(STOR_pic, ComponentModel.ISupportInitialize).BeginInit()
        CType(PS_pic, ComponentModel.ISupportInitialize).BeginInit()
        CType(CASE_pic, ComponentModel.ISupportInitialize).BeginInit()
        CType(COOL_pic, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MB_box
        ' 
        MB_box.BackColor = SystemColors.Window
        MB_box.FlatStyle = FlatStyle.Popup
        MB_box.ForeColor = Color.Black
        MB_box.FormattingEnabled = True
        MB_box.Location = New Point(348, 188)
        MB_box.Name = "MB_box"
        MB_box.Size = New Size(556, 23)
        MB_box.TabIndex = 0
        ' 
        ' CPU_box
        ' 
        CPU_box.FlatStyle = FlatStyle.Popup
        CPU_box.FormattingEnabled = True
        CPU_box.Location = New Point(348, 263)
        CPU_box.Name = "CPU_box"
        CPU_box.Size = New Size(556, 23)
        CPU_box.TabIndex = 1
        ' 
        ' GPU_box
        ' 
        GPU_box.FlatStyle = FlatStyle.Popup
        GPU_box.FormattingEnabled = True
        GPU_box.Location = New Point(348, 338)
        GPU_box.Name = "GPU_box"
        GPU_box.Size = New Size(556, 23)
        GPU_box.TabIndex = 2
        ' 
        ' MEM_box
        ' 
        MEM_box.FlatStyle = FlatStyle.Popup
        MEM_box.FormattingEnabled = True
        MEM_box.Location = New Point(348, 413)
        MEM_box.Name = "MEM_box"
        MEM_box.Size = New Size(556, 23)
        MEM_box.TabIndex = 3
        ' 
        ' STOR_box
        ' 
        STOR_box.FlatStyle = FlatStyle.Popup
        STOR_box.FormattingEnabled = True
        STOR_box.Location = New Point(348, 488)
        STOR_box.Name = "STOR_box"
        STOR_box.Size = New Size(556, 23)
        STOR_box.TabIndex = 4
        ' 
        ' PS_box
        ' 
        PS_box.FlatStyle = FlatStyle.Popup
        PS_box.FormattingEnabled = True
        PS_box.Location = New Point(348, 563)
        PS_box.Name = "PS_box"
        PS_box.Size = New Size(556, 23)
        PS_box.TabIndex = 5
        ' 
        ' CASE_box
        ' 
        CASE_box.FlatStyle = FlatStyle.Popup
        CASE_box.FormattingEnabled = True
        CASE_box.Location = New Point(348, 638)
        CASE_box.Name = "CASE_box"
        CASE_box.Size = New Size(556, 23)
        CASE_box.TabIndex = 6
        ' 
        ' COOL_box
        ' 
        COOL_box.FlatStyle = FlatStyle.Popup
        COOL_box.FormattingEnabled = True
        COOL_box.Location = New Point(348, 713)
        COOL_box.Name = "COOL_box"
        COOL_box.Size = New Size(556, 23)
        COOL_box.TabIndex = 7
        ' 
        ' MB_pic
        ' 
        MB_pic.BorderStyle = BorderStyle.Fixed3D
        MB_pic.Location = New Point(235, 188)
        MB_pic.Name = "MB_pic"
        MB_pic.Size = New Size(60, 60)
        MB_pic.SizeMode = PictureBoxSizeMode.Zoom
        MB_pic.TabIndex = 9
        MB_pic.TabStop = False
        MB_pic.WaitOnLoad = True
        ' 
        ' CPU_pic
        ' 
        CPU_pic.BorderStyle = BorderStyle.Fixed3D
        CPU_pic.Location = New Point(235, 263)
        CPU_pic.Name = "CPU_pic"
        CPU_pic.Size = New Size(60, 60)
        CPU_pic.SizeMode = PictureBoxSizeMode.Zoom
        CPU_pic.TabIndex = 10
        CPU_pic.TabStop = False
        CPU_pic.WaitOnLoad = True
        ' 
        ' GPU_pic
        ' 
        GPU_pic.BorderStyle = BorderStyle.Fixed3D
        GPU_pic.Location = New Point(235, 338)
        GPU_pic.Name = "GPU_pic"
        GPU_pic.Size = New Size(60, 60)
        GPU_pic.SizeMode = PictureBoxSizeMode.Zoom
        GPU_pic.TabIndex = 11
        GPU_pic.TabStop = False
        GPU_pic.WaitOnLoad = True
        ' 
        ' MEM_pic
        ' 
        MEM_pic.BorderStyle = BorderStyle.Fixed3D
        MEM_pic.Location = New Point(235, 413)
        MEM_pic.Name = "MEM_pic"
        MEM_pic.Size = New Size(60, 60)
        MEM_pic.SizeMode = PictureBoxSizeMode.Zoom
        MEM_pic.TabIndex = 12
        MEM_pic.TabStop = False
        MEM_pic.WaitOnLoad = True
        ' 
        ' STOR_pic
        ' 
        STOR_pic.BorderStyle = BorderStyle.Fixed3D
        STOR_pic.Location = New Point(235, 488)
        STOR_pic.Name = "STOR_pic"
        STOR_pic.Size = New Size(60, 60)
        STOR_pic.SizeMode = PictureBoxSizeMode.Zoom
        STOR_pic.TabIndex = 13
        STOR_pic.TabStop = False
        STOR_pic.WaitOnLoad = True
        ' 
        ' PS_pic
        ' 
        PS_pic.BorderStyle = BorderStyle.Fixed3D
        PS_pic.Location = New Point(235, 563)
        PS_pic.Name = "PS_pic"
        PS_pic.Size = New Size(60, 60)
        PS_pic.SizeMode = PictureBoxSizeMode.Zoom
        PS_pic.TabIndex = 14
        PS_pic.TabStop = False
        PS_pic.WaitOnLoad = True
        ' 
        ' CASE_pic
        ' 
        CASE_pic.BorderStyle = BorderStyle.Fixed3D
        CASE_pic.Location = New Point(235, 638)
        CASE_pic.Name = "CASE_pic"
        CASE_pic.Size = New Size(60, 60)
        CASE_pic.SizeMode = PictureBoxSizeMode.Zoom
        CASE_pic.TabIndex = 15
        CASE_pic.TabStop = False
        CASE_pic.WaitOnLoad = True
        ' 
        ' COOL_pic
        ' 
        COOL_pic.BorderStyle = BorderStyle.Fixed3D
        COOL_pic.Location = New Point(235, 713)
        COOL_pic.Name = "COOL_pic"
        COOL_pic.Size = New Size(60, 60)
        COOL_pic.SizeMode = PictureBoxSizeMode.Zoom
        COOL_pic.TabIndex = 16
        COOL_pic.TabStop = False
        COOL_pic.WaitOnLoad = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(837, 794)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 18)
        Label1.TabIndex = 17
        Label1.Text = "TOTAL:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(233, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 18)
        Label2.TabIndex = 18
        Label2.Text = "SELECTION"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(54, 129)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 18)
        Label3.TabIndex = 19
        Label3.Text = "COMPONENTS"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(978, 129)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 18)
        Label4.TabIndex = 20
        Label4.Text = "PRICE"
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackColor = Color.SlateBlue
        PictureBox9.Image = My.Resources.Resources.PC
        PictureBox9.Location = New Point(1205, -2)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(239, 239)
        PictureBox9.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox9.TabIndex = 21
        PictureBox9.TabStop = False
        ' 
        ' PictureBox10
        ' 
        PictureBox10.BackColor = Color.SlateBlue
        PictureBox10.Location = New Point(1205, 234)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(239, 650)
        PictureBox10.TabIndex = 22
        PictureBox10.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Verdana", 9.75F)
        Label5.Location = New Point(54, 188)
        Label5.Name = "Label5"
        Label5.Size = New Size(106, 16)
        Label5.TabIndex = 23
        Label5.Text = "MOTHERBOARD"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Verdana", 9.75F)
        Label6.Location = New Point(54, 263)
        Label6.Name = "Label6"
        Label6.Size = New Size(33, 16)
        Label6.TabIndex = 24
        Label6.Text = "CPU"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Verdana", 9.75F)
        Label7.Location = New Point(54, 338)
        Label7.Name = "Label7"
        Label7.Size = New Size(33, 16)
        Label7.TabIndex = 25
        Label7.Text = "GPU"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Verdana", 9.75F)
        Label8.Location = New Point(54, 413)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 16)
        Label8.TabIndex = 26
        Label8.Text = "MEMORY"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Verdana", 9.75F)
        Label9.Location = New Point(54, 488)
        Label9.Name = "Label9"
        Label9.Size = New Size(69, 16)
        Label9.TabIndex = 27
        Label9.Text = "STORAGE"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Verdana", 9.75F)
        Label10.Location = New Point(54, 563)
        Label10.Name = "Label10"
        Label10.Size = New Size(108, 16)
        Label10.TabIndex = 28
        Label10.Text = "POWER SUPPLY"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Verdana", 9.75F)
        Label11.Location = New Point(54, 638)
        Label11.Name = "Label11"
        Label11.Size = New Size(42, 16)
        Label11.TabIndex = 29
        Label11.Text = "CASE"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Verdana", 9.75F)
        Label12.Location = New Point(54, 713)
        Label12.Name = "Label12"
        Label12.Size = New Size(59, 16)
        Label12.TabIndex = 30
        Label12.Text = "COOLER"
        ' 
        ' COOL_price
        ' 
        COOL_price.AutoSize = True
        COOL_price.Font = New Font("Verdana", 9.75F)
        COOL_price.Location = New Point(978, 713)
        COOL_price.Name = "COOL_price"
        COOL_price.Size = New Size(59, 16)
        COOL_price.TabIndex = 38
        COOL_price.Text = "COOLER"
        ' 
        ' CASE_price
        ' 
        CASE_price.AutoSize = True
        CASE_price.Font = New Font("Verdana", 9.75F)
        CASE_price.Location = New Point(978, 638)
        CASE_price.Name = "CASE_price"
        CASE_price.Size = New Size(42, 16)
        CASE_price.TabIndex = 37
        CASE_price.Text = "CASE"
        ' 
        ' PS_price
        ' 
        PS_price.AutoSize = True
        PS_price.Font = New Font("Verdana", 9.75F)
        PS_price.Location = New Point(978, 563)
        PS_price.Name = "PS_price"
        PS_price.Size = New Size(108, 16)
        PS_price.TabIndex = 36
        PS_price.Text = "POWER SUPPLY"
        ' 
        ' STOR_price
        ' 
        STOR_price.AutoSize = True
        STOR_price.Font = New Font("Verdana", 9.75F)
        STOR_price.Location = New Point(978, 488)
        STOR_price.Name = "STOR_price"
        STOR_price.Size = New Size(69, 16)
        STOR_price.TabIndex = 35
        STOR_price.Text = "STORAGE"
        ' 
        ' MEM_price
        ' 
        MEM_price.AutoSize = True
        MEM_price.Font = New Font("Verdana", 9.75F)
        MEM_price.Location = New Point(978, 413)
        MEM_price.Name = "MEM_price"
        MEM_price.Size = New Size(64, 16)
        MEM_price.TabIndex = 34
        MEM_price.Text = "MEMORY"
        ' 
        ' GPU_price
        ' 
        GPU_price.AutoSize = True
        GPU_price.Font = New Font("Verdana", 9.75F)
        GPU_price.Location = New Point(978, 338)
        GPU_price.Name = "GPU_price"
        GPU_price.Size = New Size(33, 16)
        GPU_price.TabIndex = 33
        GPU_price.Text = "GPU"
        ' 
        ' CPU_price
        ' 
        CPU_price.AutoSize = True
        CPU_price.Font = New Font("Verdana", 9.75F)
        CPU_price.Location = New Point(978, 263)
        CPU_price.Name = "CPU_price"
        CPU_price.Size = New Size(33, 16)
        CPU_price.TabIndex = 32
        CPU_price.Text = "CPU"
        ' 
        ' MB_price
        ' 
        MB_price.AutoSize = True
        MB_price.Font = New Font("Verdana", 9.75F)
        MB_price.Location = New Point(978, 188)
        MB_price.Name = "MB_price"
        MB_price.Size = New Size(26, 16)
        MB_price.TabIndex = 31
        MB_price.Text = "MB"
        ' 
        ' total_price
        ' 
        total_price.AutoSize = True
        total_price.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        total_price.Location = New Point(978, 794)
        total_price.Name = "total_price"
        total_price.Size = New Size(0, 18)
        total_price.TabIndex = 39
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1444, 881)
        Controls.Add(total_price)
        Controls.Add(COOL_price)
        Controls.Add(CASE_price)
        Controls.Add(PS_price)
        Controls.Add(STOR_price)
        Controls.Add(MEM_price)
        Controls.Add(GPU_price)
        Controls.Add(CPU_price)
        Controls.Add(MB_price)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(PictureBox9)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(COOL_pic)
        Controls.Add(CASE_pic)
        Controls.Add(PS_pic)
        Controls.Add(STOR_pic)
        Controls.Add(MEM_pic)
        Controls.Add(GPU_pic)
        Controls.Add(CPU_pic)
        Controls.Add(MB_pic)
        Controls.Add(COOL_box)
        Controls.Add(CASE_box)
        Controls.Add(PS_box)
        Controls.Add(STOR_box)
        Controls.Add(MEM_box)
        Controls.Add(GPU_box)
        Controls.Add(CPU_box)
        Controls.Add(MB_box)
        Controls.Add(PictureBox10)
        Name = "Form1"
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        CType(MB_pic, ComponentModel.ISupportInitialize).EndInit()
        CType(CPU_pic, ComponentModel.ISupportInitialize).EndInit()
        CType(GPU_pic, ComponentModel.ISupportInitialize).EndInit()
        CType(MEM_pic, ComponentModel.ISupportInitialize).EndInit()
        CType(STOR_pic, ComponentModel.ISupportInitialize).EndInit()
        CType(PS_pic, ComponentModel.ISupportInitialize).EndInit()
        CType(CASE_pic, ComponentModel.ISupportInitialize).EndInit()
        CType(COOL_pic, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MB_box As ComboBox
    Friend WithEvents CPU_box As ComboBox
    Friend WithEvents GPU_box As ComboBox
    Friend WithEvents MEM_box As ComboBox
    Friend WithEvents STOR_box As ComboBox
    Friend WithEvents PS_box As ComboBox
    Friend WithEvents CASE_box As ComboBox
    Friend WithEvents COOL_box As ComboBox
    Friend WithEvents MB_pic As PictureBox
    Friend WithEvents CPU_pic As PictureBox
    Friend WithEvents GPU_pic As PictureBox
    Friend WithEvents MEM_pic As PictureBox
    Friend WithEvents STOR_pic As PictureBox
    Friend WithEvents PS_pic As PictureBox
    Friend WithEvents CASE_pic As PictureBox
    Friend WithEvents COOL_pic As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents COOL_price As Label
    Friend WithEvents CASE_price As Label
    Friend WithEvents PS_price As Label
    Friend WithEvents STOR_price As Label
    Friend WithEvents MEM_price As Label
    Friend WithEvents GPU_price As Label
    Friend WithEvents CPU_price As Label
    Friend WithEvents MB_price As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents total_price As Label


End Class
