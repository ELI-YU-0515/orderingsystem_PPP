﻿Public Class Form1
    ' Arrays to hold images and prices
    Dim MBitemImages() As Image = {My.Resources.M1pic, My.Resources.M2pic, My.Resources.M3pic, My.Resources.M4pic, My.Resources.M5pic} ' Using the same image for testing
    Dim MBitemPrices() As Decimal = {2500D, 3000D, 5500D, 5500D, 7000D} ' Different prices

    Dim CPUitemImages() As Image = {My.Resources.CPU1pic, My.Resources.CPU2pic, My.Resources.CPU3pic, My.Resources.CPU4pic, My.Resources.CPU5pic} ' Using the same image for testing
    Dim CPUitemPrices() As Decimal = {2700D, 5000D, 7000D, 10000D, 14000D} ' Different prices

    Dim GPUitemImages() As Image = {My.Resources.CPU1pic, My.Resources.CPU2pic, My.Resources.CPU3pic, My.Resources.CPU4pic, My.Resources.CPU5pic} ' Using the same image for testing
    Dim GPUitemPrices() As Decimal = {10000D, 13000D, 20000D, 22000D, 24000D} ' Different prices

    Dim MEMitemImages() As Image = {My.Resources.CPU1pic, My.Resources.CPU2pic, My.Resources.CPU3pic, My.Resources.CPU4pic, My.Resources.CPU5pic, My.Resources.CPU1pic, My.Resources.CPU2pic, My.Resources.CPU3pic, My.Resources.CPU4pic, My.Resources.CPU5pic} ' Using the same image for testing
    Dim MEMitemPrices() As Decimal = {1500D, 1600D, 1800D, 3000D, 3000D, 3200D, 3500D, 3800D, 5000D, 6000D} ' Different prices

    Dim STORitemImages() As Image = {My.Resources.CPU1pic, My.Resources.CPU2pic, My.Resources.CPU3pic, My.Resources.CPU4pic, My.Resources.CPU5pic, My.Resources.CPU1pic, My.Resources.CPU2pic, My.Resources.CPU3pic, My.Resources.CPU4pic, My.Resources.CPU5pic} ' Using the same image for testing
    Dim STORitemPrices() As Decimal = {800D, 1000D, 1500D, 2500D, 3000D, 3500D, 4000D, 4500D, 7500D, 8000D} ' Different prices

    Dim PSitemImages() As Image = {My.Resources.CPU1pic, My.Resources.CPU2pic, My.Resources.CPU3pic, My.Resources.CPU4pic, My.Resources.CPU5pic} ' Using the same image for testing
    Dim PSitemPrices() As Decimal = {800D, 1000D, 1500D, 2500D, 3500D} ' Different prices

    Dim CASEitemImages() As Image = {My.Resources.CPU1pic, My.Resources.CPU2pic, My.Resources.CPU3pic, My.Resources.CPU4pic, My.Resources.CPU5pic} ' Using the same image for testing
    Dim CASEitemPrices() As Decimal = {700D, 1000D, 1500D, 2500D, 3500D} ' Different prices

    Dim COOLitemImages() As Image = {My.Resources.CPU1pic, My.Resources.CPU2pic, My.Resources.CPU3pic, My.Resources.CPU4pic, My.Resources.CPU5pic} ' Using the same image for testing
    Dim COOLitemPrices() As Decimal = {0D, 2500D, 1500D, 2200D, 5000D}  ' Different prices


    Dim selectedMBPrice As Decimal = 0D
    Dim selectedCPUPrice As Decimal = 0D
    Dim selectedGPUPrice As Decimal = 0D
    Dim selectedMEMPrice As Decimal = 0D
    Dim selectedSTORPrice As Decimal = 0D
    Dim selectedPSPrice As Decimal = 0D
    Dim selectedCASEUPrice As Decimal = 0D
    Dim selectedCOOLPrice As Decimal = 0D




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the ComboBox with items
        MB_box.Items.Add("ASUS A320M-K")
        MB_box.Items.Add("MSI B450M PRO-VDH MAX")
        MB_box.Items.Add("MSI B550M PRO-VDH WIFI")
        MB_box.Items.Add("ASUS B550M-A Pro")
        MB_box.Items.Add("ASUS ROG Strix B550-F Gaming")


        CPU_box.Items.Add("AMD Athlon 3000G with Vega 3 Graphics")
        CPU_box.Items.Add("AMD Ryzen 3 3200G with Vega 8 Graphics")
        CPU_box.Items.Add("AMD Ryzen 5 5600G with Vega 7 Graphics")
        CPU_box.Items.Add("AMD Ryzen 5 5600X")
        CPU_box.Items.Add("AMD Ryzen 7 5800X")



        GPU_box.Items.Add("NVIDIA GeForce GTX 1660 Super")
        GPU_box.Items.Add("AMD Radeon RX 6600")
        GPU_box.Items.Add("NVIDIA GeForce RTX 3060")
        GPU_box.Items.Add("NVIDIA GeForce RTX 3060 Ti")
        GPU_box.Items.Add("AMD Radeon RX 6700 XT")


        MEM_box.Items.Add("Corsair Vengeance LPX 8GB DDR4 3200MHz")
        MEM_box.Items.Add("G.Skill Ripjaws V 8GB DDR4 3200MHz ")
        MEM_box.Items.Add("TeamGroup T-Force Delta RGB 8GB DDR4 3200MHz")
        MEM_box.Items.Add("Kingston HyperX Fury 16GB DDR4 3200MHz")
        MEM_box.Items.Add("Corsair Vengeance LPX 16GB DDR4 3200MHz")
        MEM_box.Items.Add("G.Skill Ripjaws V 16GB DDR4 3600MHz")
        MEM_box.Items.Add("Crucial Ballistix 16GB DDR4 3600MHz")
        MEM_box.Items.Add("Corsair Vengeance RGB PRO 16GB DDR4 3600MHz")
        MEM_box.Items.Add("TeamGroup T-Force Dark Za 32GB DDR4 3200MHz")
        MEM_box.Items.Add("Corsair Vengeance LPX 32GB DDR4 3600MHz")


        STOR_box.Items.Add("Kingston 240GB SSD")
        STOR_box.Items.Add("Crucial BX500 240GB SSD")
        STOR_box.Items.Add("Western Digital Blue 500GB SSD")
        STOR_box.Items.Add("Crucial P2 500GB NVMe SSD")
        STOR_box.Items.Add("Samsung 970 EVO Plus 500GB NVMe SSD")
        STOR_box.Items.Add("WD Blue 1TB SSD")
        STOR_box.Items.Add("Samsung 980 1TB NVMe SSD")
        STOR_box.Items.Add("Crucial P3 Plus 1TB NVMe SSD")
        STOR_box.Items.Add("Samsung 970 EVO Plus 2TB NVMe SSD")
        STOR_box.Items.Add("Crucial P5 Plus 2TB NVMe SSD")


        PS_box.Items.Add("Cooler Master MWE 400W 80+ White")
        PS_box.Items.Add("FSP 450W 80+ Bronze")
        PS_box.Items.Add("Thermaltake Litepower 500W 80+ Bronze")
        PS_box.Items.Add("Seasonic S12III 500W 80+ Bronze")
        PS_box.Items.Add("Corsair CV550 550W 80+ Bronze")


        CASE_box.Items.Add("Cooler Master Q300L")
        CASE_box.Items.Add("Deepcool MATREXX 30")
        CASE_box.Items.Add("Fractal Design Meshify C Mini")
        CASE_box.Items.Add("NZXT H510")
        CASE_box.Items.Add("Phanteks Eclipse P400A")


        COOL_box.Items.Add("AMD Wraith Stealth (Stock Cooler) – Included with CPUs")
        COOL_box.Items.Add("Cooler Master Hyper 212 RGB")
        COOL_box.Items.Add("Deepcool Gammaxx 400 ")
        COOL_box.Items.Add("Arctic Freezer 34 eSports DUO")
        COOL_box.Items.Add("Cooler Master MasterLiquid 240mm AIO")

    End Sub

    ' When the ComboBox selection changes
    Private Sub MBBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MB_box.SelectedIndexChanged
        ' Get the selected index
        Dim selectedIndex As Integer = MB_box.SelectedIndex

        ' Check if a valid item is selected
        If selectedIndex >= 0 AndAlso selectedIndex < MBitemImages.Length Then
            ' Update the PictureBox and Label
            MB_pic.Image = MBitemImages(selectedIndex)
            MB_price.Text = "Price: " & MBitemPrices(selectedIndex).ToString() & " php"



        End If

        MB_box.AutoCompleteMode = AutoCompleteMode.SuggestAppend ' Enables suggestion and appending
        MB_box.AutoCompleteSource = AutoCompleteSource.ListItems ' Search within the ComboBox's items
    End Sub

    Private Sub CPUBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CPU_box.SelectedIndexChanged
        ' Get the selected index
        Dim selectedIndex As Integer = CPU_box.SelectedIndex

        ' Check if a valid item is selected
        If selectedIndex >= 0 AndAlso selectedIndex < CPUitemImages.Length Then
            ' Update the PictureBox and Label
            CPU_pic.Image = CPUitemImages(selectedIndex)
            CPU_price.Text = "Price: " & CPUitemPrices(selectedIndex).ToString() & " php"
        End If

        CPU_box.AutoCompleteMode = AutoCompleteMode.SuggestAppend ' Enables suggestion and appending
        CPU_box.AutoCompleteSource = AutoCompleteSource.ListItems ' Search within the ComboBox's items
    End Sub



    Private Sub GPUBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GPU_box.SelectedIndexChanged
        ' Get the selected index
        Dim selectedIndex As Integer = GPU_box.SelectedIndex

        ' Check if a valid item is selected
        If selectedIndex >= 0 AndAlso selectedIndex < GPUitemImages.Length Then
            ' Update the PictureBox and Label
            GPU_pic.Image = GPUitemImages(selectedIndex)
            GPU_price.Text = "Price: " & GPUitemPrices(selectedIndex).ToString() & " php"
        End If

        GPU_box.AutoCompleteMode = AutoCompleteMode.SuggestAppend ' Enables suggestion and appending
        GPU_box.AutoCompleteSource = AutoCompleteSource.ListItems ' Search within the ComboBox's items
    End Sub




    Private Sub MEMBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MEM_box.SelectedIndexChanged
        ' Get the selected index
        Dim selectedIndex As Integer = MEM_box.SelectedIndex

        ' Check if a valid item is selected
        If selectedIndex >= 0 AndAlso selectedIndex < MEMitemImages.Length Then
            ' Update the PictureBox and Label
            MEM_pic.Image = MEMitemImages(selectedIndex)
            MEM_price.Text = "Price: " & MEMitemPrices(selectedIndex).ToString() & " php"
        End If

        MEM_box.AutoCompleteMode = AutoCompleteMode.SuggestAppend ' Enables suggestion and appending
        MEM_box.AutoCompleteSource = AutoCompleteSource.ListItems ' Search within the ComboBox's items
    End Sub

    Private Sub STORBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles STOR_box.SelectedIndexChanged
        ' Get the selected index
        Dim selectedIndex As Integer = STOR_box.SelectedIndex

        ' Check if a valid item is selected
        If selectedIndex >= 0 AndAlso selectedIndex < STORitemImages.Length Then
            ' Update the PictureBox and Label
            STOR_pic.Image = STORitemImages(selectedIndex)
            STOR_price.Text = "Price: " & STORitemPrices(selectedIndex).ToString() & " php"
        End If

        STOR_box.AutoCompleteMode = AutoCompleteMode.SuggestAppend ' Enables suggestion and appending
        STOR_box.AutoCompleteSource = AutoCompleteSource.ListItems ' Search within the ComboBox's items
    End Sub



    Private Sub PSBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PS_box.SelectedIndexChanged
        ' Get the selected index
        Dim selectedIndex As Integer = PS_box.SelectedIndex

        ' Check if a valid item is selected
        If selectedIndex >= 0 AndAlso selectedIndex < PSitemImages.Length Then
            ' Update the PictureBox and Label
            PS_pic.Image = PSitemImages(selectedIndex)
            PS_price.Text = "Price: " & PSitemPrices(selectedIndex).ToString() & " php"
        End If

        PS_box.AutoCompleteMode = AutoCompleteMode.SuggestAppend ' Enables suggestion and appending
        PS_box.AutoCompleteSource = AutoCompleteSource.ListItems ' Search within the ComboBox's items
    End Sub



    Private Sub CASEBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CASE_box.SelectedIndexChanged
        ' Get the selected index
        Dim selectedIndex As Integer = CASE_box.SelectedIndex

        ' Check if a valid item is selected
        If selectedIndex >= 0 AndAlso selectedIndex < CASEitemImages.Length Then
            ' Update the PictureBox and Label
            CASE_pic.Image = CASEitemImages(selectedIndex)
            CASE_price.Text = "Price: " & CASEitemPrices(selectedIndex).ToString() & " php"
        End If

        CASE_box.AutoCompleteMode = AutoCompleteMode.SuggestAppend ' Enables suggestion and appending
        CASE_box.AutoCompleteSource = AutoCompleteSource.ListItems ' Search within the ComboBox's items
    End Sub




    Private Sub COOLBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COOL_box.SelectedIndexChanged
        ' Get the selected index
        Dim selectedIndex As Integer = COOL_box.SelectedIndex

        ' Check if a valid item is selected
        If selectedIndex >= 0 AndAlso selectedIndex < COOLitemImages.Length Then
            ' Update the PictureBox and Label
            COOL_pic.Image = COOLitemImages(selectedIndex)
            COOL_price.Text = "Price: " & COOLitemPrices(selectedIndex).ToString() & " php"
        End If

        COOL_box.AutoCompleteMode = AutoCompleteMode.SuggestAppend ' Enables suggestion and appending
        COOL_box.AutoCompleteSource = AutoCompleteSource.ListItems ' Search within the ComboBox's items
    End Sub



    Private Sub UpdateTotalPrice()
        ' Calculate the total price
        Dim totalPrice As Decimal = selectedCPUPrice + selectedGPUPrice

        ' Update the total price label
        total_price.Text = "Total Price: " & totalPrice.ToString() & " php"
    End Sub



End Class