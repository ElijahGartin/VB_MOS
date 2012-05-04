Public Class CustomerInformationForm

    'Declare the new objects.
    Private TheCustomerInformation As CustomerInformation

    Private Sub CustomerInformationForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TheCustomerInformation = New CustomerInformation(VBOrderForm.nameTextBox.Text, VBOrderForm.addressTextBox.Text, VBOrderForm.cityTextBox.Text, VBOrderForm.stateMaskedTextBox.Text, VBOrderForm.zipTextBox.Text)
        nameTextBox.Text = TheCustomerInformation.Name
        addressTextBox.Text = TheCustomerInformation.Address
        cityTextBox.Text = TheCustomerInformation.City
        stateMaskedTextBox.Text = TheCustomerInformation.State
        zipTextBox.Text = TheCustomerInformation.Zip

    End Sub

 
End Class