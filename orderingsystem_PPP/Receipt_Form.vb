Imports System.IO
Imports System.Reflection.Metadata

Public Class Receipt_Form
    Private customerName As String
    Private customerAddress As String
    Private contactNumber As String
    Private transactionDate As String
    Private paymentMethod As String
    Private totalPrice As Decimal
    Private discountPrice As Decimal
    Private wholepriceTotal As Decimal
    Private changePrice As Decimal
    Private CASHAmount As Decimal

    Private uploadedImage As Image


    ' Constructor to accept values
    Public Sub New(name As String, address As String, contact As String, dateValue As String, payment As String, MBItem As String, MBPrice As Decimal, CPUItem As String, CPUPrice As Decimal, GPUItem As String, GPUPrice As Decimal, MEMItem As String, MEMPrice As Decimal, STORItem As String, STORPrice As Decimal, PSItem As String, PSPrice As Decimal, CASEItem As String, CASEPrice As Decimal, COOLItem As String, COOLPrice As Decimal, totalPrice As Decimal, cash_Amount As Decimal, assemblyFee As Decimal, discountPrice As Decimal, wholepriceTotal As Decimal, changePrice As Decimal, discountPercentage As Decimal)
        InitializeComponent()

        ' Assign the values to the class variables
        customerName = name
        customerAddress = address
        contactNumber = contact
        transactionDate = dateValue
        paymentMethod = payment
        CASHAmount = cash_Amount
        Me.totalPrice = totalPrice ' Store the total price
        discountPrice = (totalPrice * discountPercentage)
        wholepriceTotal = (totalPrice + assemblyFee - discountPrice)


        MBItemLabel.Text = ": " + MBItem
        MBPriceLabel.Text = ": " + MBPrice.ToString("C")

        CPUItemLabel.Text = ": " + CPUItem
        CPUPriceLabel.Text = ": " + CPUPrice.ToString("C")

        GPUItemLabel.Text = ": " + GPUItem
        GPUPriceLabel.Text = ": " + GPUPrice.ToString("C")

        MEMItemLabel.Text = ": " + MEMItem
        MEMPriceLabel.Text = ": " + MEMPrice.ToString("C")

        STORItemLabel.Text = ": " + STORItem
        STORPriceLabel.Text = ": " + STORPrice.ToString("C")

        PSItemLabel.Text = ": " + PSItem
        PSPriceLabel.Text = ": " + PSPrice.ToString("C")

        CASEItemLabel.Text = ": " + CASEItem
        CASEPriceLabel.Text = ": " + CASEPrice.ToString("C")

        COOLItemLabel.Text = ": " + COOLItem
        CoolPriceLabel.Text = ": " + COOLPrice.ToString("C")

        subtotal_price.Text = totalPrice.ToString("C")
        cashamount_price.Text = cash_Amount.ToString("C")
        discount_price.Text = ": " & discountPrice.ToString("C")
        PCAssemblyFee.Text = ": " + assemblyFee.ToString("C")
        wholeprice_total.Text = ": " & wholepriceTotal.ToString("C")
        change_price.Text = ": " & (cash_Amount - (wholepriceTotal)).ToString("C")




        DisplayReceipt()
    End Sub

    Private Sub DisplayReceipt()
        ' Use the class variables to display the information on the receipt
        customerNameLabel.Text = ": " + customerName
        customerAddressLabel.Text = ": " + customerAddress
        contactNumberLabel.Text = ": " + contactNumber
        dateLabel.Text = ": " + transactionDate
        payment_method_Label.Text = ": " + paymentMethod
    End Sub

End Class
