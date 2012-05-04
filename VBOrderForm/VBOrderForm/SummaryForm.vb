Public Class SummaryForm

    'Declare the new objects.
    Private TheOrderItem As OrderItem
    Private TheCAOrderItem As CAOrderItem

    Private Sub SummaryForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Calculate the extended price for the sale.
        Try
            If VBOrderForm.stateMaskedTextBox.Text.ToUpper() = "CA" Then
                'Instantiate the OrderItem object and set the properties.
                TheCAOrderItem = New CAOrderItem(VBOrderForm.proddescTextBox.Text, Integer.Parse(VBOrderForm.quantityTextBox.Text), Decimal.Parse(VBOrderForm.weightTextBox.Text), Decimal.Parse(VBOrderForm.priceTextBox.Text))
                'Calculate and format the result.
                totalamtTextBox.Text = TheCAOrderItem.totaldue.ToString("C")
            Else
                'Instantiate the OrderItem object and set the properties.
                TheOrderItem = New OrderItem(VBOrderForm.proddescTextBox.Text, Integer.Parse(VBOrderForm.quantityTextBox.Text), Decimal.Parse(VBOrderForm.weightTextBox.Text), Decimal.Parse(VBOrderForm.priceTextBox.Text))
                'Calculate and format the result.
                totalamtTextBox.Text = TheOrderItem.totaldue.ToString("C")
            End If
        Catch
            MessageBox.Show("Error in quantity or price field.", "VB Mail Order", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
End Class