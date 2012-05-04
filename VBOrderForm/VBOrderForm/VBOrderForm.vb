' Project:  VBOrderForm
' Date:     20APR2012
' Author:   Elijah Gartin
' Description: This project will calculate dollar amount due of products ordered
'               then calculate sales tax, shipping and handling, and then
'               it will calculate the final total amount due.

Public Class VBOrderForm

    'Declare the new objects.
    Private TheCustomerInformation As CustomerInformation
    Private TheOrderItem As OrderItem
    Private TheCAOrderItem As CAOrderItem



    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        'Print Form to Preview
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Exterminate the Program
        Me.Close()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FontToolStripMenuItem.Click
        'Allow the user to select a new font for the summary totals
        With FontDialog1
            .Font = SummaryForm.totalamtTextBox.Font
            .ShowDialog()
            SummaryForm.totalamtTextBox.Font = .Font
        End With
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        With ColorDialog1
            .Color = SummaryForm.totalamtTextBox.ForeColor
            .ShowDialog()
            SummaryForm.totalamtTextBox.ForeColor = .Color
        End With
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'Display the About message box.
        AboutForm.ShowDialog()
    End Sub

    Private Sub CustomerInformationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CustomerInformationToolStripMenuItem.Click
        CustomerInformationForm.ShowDialog()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click, ClearToolStripMenuItem.Click
        Dim totTax As Decimal

        'Re-Enable Personal Information
        GroupBox1.Enabled = True

        'Clear Order Information and Re-enable Add Item
        proddescTextBox.Clear()
        quantityTextBox.Clear()
        weightTextBox.Clear()
        priceTextBox.Clear()
        btnAddItem.Enabled = True

        'Clear Summary Information
        SummaryForm.dollaramtTextBox.Clear()
        SummaryForm.taxTextBox.Clear()
        totTax = 0
        SummaryForm.shTextBox.Clear()
        SummaryForm.totalamtTextBox.Clear()

    End Sub

    Private Sub btnSummary_Click(sender As System.Object, e As System.EventArgs) Handles btnSummary.Click, SummaryToolStripMenuItem.Click


        SummaryForm.ShowDialog()

        'Disable btnAddItem
        btnAddItem.Enabled = False
    End Sub

    Private Sub btnAddItem_Click(sender As System.Object, e As System.EventArgs) Handles btnAddItem.Click, AddItemToolStripMenuItem.Click
        'Disable Customer Information
        GroupBox1.Enabled = False

        'Calculate the extended price for the sale.
        Try
            If stateMaskedTextBox.Text.ToUpper() = "CA" Then
                'Instantiate the OrderItem object and set the properties.
                TheCAOrderItem = New CAOrderItem(proddescTextBox.Text, Integer.Parse(quantityTextBox.Text), Decimal.Parse(weightTextBox.Text), Decimal.Parse(priceTextBox.Text))

                'Calculate and format the result.
                SummaryForm.dollaramtTextBox.Text = TheCAOrderItem.subtotPrice.ToString("C")
                SummaryForm.shTextBox.Text = TheCAOrderItem.shipnhandle.ToString("C")
                SummaryForm.taxTextBox.Text = TheCAOrderItem.totTaxDecimal.ToString("C")
            Else
                'Instantiate the OrderItem object and set the properties.
                TheOrderItem = New OrderItem(proddescTextBox.Text, Integer.Parse(quantityTextBox.Text), Decimal.Parse(weightTextBox.Text), Decimal.Parse(priceTextBox.Text))
                'Calculate and format the result.
                SummaryForm.dollaramtTextBox.Text = TheOrderItem.subtotPrice.ToString("C")
                SummaryForm.shTextBox.Text = TheOrderItem.shipnhandle.ToString("C")

            End If
        Catch
            MessageBox.Show("Error in quantity or price field.", "VB Mail Order", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

End Class
