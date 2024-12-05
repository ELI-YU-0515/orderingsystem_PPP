Imports System.Reflection.Metadata
Imports System.Security.Cryptography.X509Certificates

Public Class Transact_Form



    ' Variables to store input values
    Private customerName As String
    Private customerAddress As String
    Private contactNumber As Int128
    Private transactionDate As Int128
    Private paymentMethod As String
    Private assemblyFee As Decimal
    Private discountPrice As Decimal
    Private wholepriceTotal As Decimal
    Private changePrice As Decimal
    Private discountPercentage As Decimal


    Private Sub addID_btn_Click(sender As Object, e As EventArgs) Handles addID_btn.Click

        ' Create an instance of OpenFileDialog
        Using openFileDialog As New OpenFileDialog()
            ' Set filter for the file types
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*"
            openFileDialog.Title = "Select an Image"

            ' Show the dialog and get the result
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Load the selected image into the PictureBox
                Dim selectedImage As Image = Image.FromFile(openFileDialog.FileName)
                IDPicture_box.Image = selectedImage ' Assuming your PictureBox is named PictureBox1
            End If
        End Using




    End Sub





    Private Sub installment_btn_Click(sender As Object, e As EventArgs) Handles installment_btn.Click
        Dim customerName As String = customer_input.Text.ToUpper()
        Dim customerAddress As String = address_input.Text.ToUpper()
        Dim contactNumber As String = contact_input.Text
        Dim transactionDate As String = date_input.Text
        Dim cash_Amount As Decimal = cashamount_input.Text
        Dim paymentMethod As String = "Installment (PENDING)"

        ' Get the selected items and prices from Form1
        Dim selectedIndex As Integer = Form1.GPU_box.SelectedIndex
        Dim MBItem As String = Form1.MB_box.SelectedItem.ToString()
        Dim MBPrice As Decimal = Form1.MBitemPrices(Form1.MB_box.SelectedIndex)
        Dim CPUItem As String = Form1.CPU_box.SelectedItem.ToString()
        Dim CPUPrice As Decimal = Form1.CPUitemPrices(Form1.CPU_box.SelectedIndex)
        Dim GPUItem As String = Form1.GPU_box.SelectedItem.ToString()
        Dim GPUPrice As Decimal = Form1.GPUitemPrices(Form1.GPU_box.SelectedIndex)
        Dim MEMItem As String = Form1.MEM_box.SelectedItem.ToString()
        Dim MEMPrice As Decimal = Form1.MEMitemPrices(Form1.MEM_box.SelectedIndex)
        Dim STORItem As String = Form1.STOR_box.SelectedItem.ToString()
        Dim STORPrice As Decimal = Form1.STORitemPrices(Form1.STOR_box.SelectedIndex)
        Dim PSItem As String = Form1.PS_box.SelectedItem.ToString()
        Dim PSPrice As Decimal = Form1.PSitemPrices(Form1.PS_box.SelectedIndex)
        Dim CASEItem As String = Form1.CASE_box.SelectedItem.ToString()
        Dim CASEPrice As Decimal = Form1.CASEitemPrices(Form1.CASE_box.SelectedIndex)
        Dim COOLItem As String = Form1.COOL_box.SelectedItem.ToString()
        Dim COOLPrice As Decimal = Form1.COOLitemPrices(Form1.COOL_box.SelectedIndex)

        ' Get the total price from Form1
        Dim totalPrice As Decimal = Form1.UpdateTotalPrice()

        Dim discountPercentage As Decimal
        If Decimal.TryParse(discount_input.Text, discountPercentage) Then
            ' Convert to decimal percentage format (e.g. 5% -> 0.05)
            discountPercentage = discountPercentage / 100D
        Else
            ' Handle invalid input (e.g. default to no discount)
            discountPercentage = 0D
        End If

        ' Create the Receipt_Form and pass the total price
        Dim receiptForm As New Receipt_Form(customerName, customerAddress, contactNumber, transactionDate, paymentMethod, MBItem, MBPrice, CPUItem, CPUPrice, GPUItem, GPUPrice, MEMItem, MEMPrice, STORItem, STORPrice, PSItem, PSPrice, CASEItem, CASEPrice, COOLItem, COOLPrice, totalPrice, cash_Amount, assemblyFee, discountPrice, wholepriceTotal, changePrice, discountPercentage)
        receiptForm.Show()
    End Sub


    Private Sub downpayment_btn_Click(sender As Object, e As EventArgs) Handles downpayment_btn.Click
        Dim customerName As String = customer_input.Text.ToUpper()
        Dim customerAddress As String = address_input.Text.ToUpper()
        Dim contactNumber As String = contact_input.Text
        Dim transactionDate As String = date_input.Text
        Dim cash_Amount As Decimal = cashamount_input.Text
        Dim paymentMethod = "Down Payment(FULL)"

        Dim selectedIndex = Form1.MB_box.SelectedIndex

        Dim MBItem = Form1.MB_box.SelectedItem.ToString
        Dim MBPrice = Form1.MBitemPrices(selectedIndex) ' Access the price using the selected index

        Dim CPUItem = Form1.CPU_box.SelectedItem.ToString
        Dim CPUPrice = Form1.CPUitemPrices(selectedIndex) ' Access the price using the selected index

        Dim GPUItem = Form1.GPU_box.SelectedItem.ToString
        Dim GPUPrice = Form1.GPUitemPrices(selectedIndex) ' Access the price using the selected index

        Dim MEMItem = Form1.MEM_box.SelectedItem.ToString
        Dim MEMPrice = Form1.MEMitemPrices(selectedIndex) ' Access the price using the selected index

        Dim STORItem = Form1.STOR_box.SelectedItem.ToString
        Dim STORPrice = Form1.STORitemPrices(selectedIndex) ' Access the price using the selected index

        Dim PSItem = Form1.PS_box.SelectedItem.ToString
        Dim PSPrice = Form1.PSitemPrices(selectedIndex) ' Access the price using the selected index

        Dim CASEItem = Form1.CASE_box.SelectedItem.ToString
        Dim CASEPrice = Form1.CASEitemPrices(selectedIndex) ' Access the price using the selected index

        Dim COOLItem = Form1.COOL_box.SelectedItem.ToString
        Dim COOLPrice = Form1.COOLitemPrices(selectedIndex) ' Access the price using the selected index


        Dim totalPrice = Form1.UpdateTotalPrice

        Dim discountPercentage As Decimal
        If Decimal.TryParse(discount_input.Text, discountPercentage) Then
            ' Convert to decimal percentage format (e.g. 5% -> 0.05)
            discountPercentage = discountPercentage / 100D
        Else
            ' Handle invalid input (e.g. default to no discount)
            discountPercentage = 0D
        End If

        ' Validate contact number format
        ' Proceed with the rest of your code to create the receipt form
        Dim receiptForm As New Receipt_Form(customerName, customerAddress, contactNumber, transactionDate, paymentMethod, MBItem, MBPrice, CPUItem, CPUPrice, GPUItem, GPUPrice, MEMItem, MEMPrice, STORItem, STORPrice, PSItem, PSPrice, CASEItem, CASEPrice, COOLItem, COOLPrice, totalPrice, cash_Amount, assemblyFee, discountPrice, wholepriceTotal, changePrice, discountPercentage)
        receiptForm.Show()
    End Sub




    Private Sub contact_input_Enter(sender As Object, e As EventArgs) Handles contact_input.Enter
        ' Clear the text when the textbox gains focus
        If contact_input.Text = "+63 ___-___-____" Then
            contact_input.Clear() ' or contact_input.Text = String.Empty
        End If
    End Sub

    Private Sub date_input_Enter(sender As Object, e As EventArgs) Handles date_input.Enter
        ' Clear the text when the textbox gains focus
        If date_input.Text = "__/__ /__" Then
            date_input.Clear() ' or date_input.Text = String.Empty
        End If
    End Sub

    Private Sub prebuild_checkbox_CheckedChanged(sender As Object, e As EventArgs) Handles prebuild_checkbox.CheckedChanged
        ' Check if the checkbox is selected
        If prebuild_checkbox.Checked Then
            assemblyFee = 400D ' Assign assembly fee if checked
        Else
            assemblyFee = 0D ' No fee if unchecked
        End If
    End Sub

    Private Sub discount_input_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles discount_input.MaskInputRejected

    End Sub
End Class