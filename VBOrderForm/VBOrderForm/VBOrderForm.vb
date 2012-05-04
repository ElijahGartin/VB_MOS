﻿' Project:  VBOrderForm
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
        'e.Cancel = False
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

        ErrorProvider1.Clear()
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
        Catch ex As Exception
            'Handle Price Exception
            ErrorProvider1.SetError(btnAddItem, "Price, Quantity, and Weight are required and must be numeric.")
            With priceTextBox
                .Focus()
                .SelectAll()
            End With
        End Try
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''
    ''''             VALIDATION                ''''
    '''''''''''''''''''''''''''''''''''''''''''''''

    Private Sub nameTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles nameTextBox.Validating
        'Validate for a Required Entry

        'Cancel any previous error
        ErrorProvider1.SetError(nameTextBox, "")

        'Check for an empty string
        If nameTextBox.Text = String.Empty Then
            'Cancel the event
            e.Cancel = True
            ErrorProvider1.SetError(nameTextBox, "Required Field.")
        End If

    End Sub

    Private Sub addressTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles addressTextBox.Validating
        'Validate for a Required Entry

        'Cancel any previous error
        ErrorProvider1.SetError(addressTextBox, "")

        'Check for an empty string
        If addressTextBox.Text = String.Empty Then
            'Cancel the event
            e.Cancel = True
            ErrorProvider1.SetError(addressTextBox, "Required Field.")
        End If

    End Sub

    Private Sub cityTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cityTextBox.Validating
        'Validate for a Required Entry

        'Cancel any previous error
        ErrorProvider1.SetError(cityTextBox, "")

        'Check for an empty string
        If cityTextBox.Text = String.Empty Then
            'Cancel the event
            e.Cancel = True
            ErrorProvider1.SetError(cityTextBox, "Required Field.")
        End If

    End Sub

    Private Sub stateMaskedTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles stateMaskedTextBox.Validating
        'Validate for a Required Entry

        'Cancel any previous error
        ErrorProvider1.SetError(stateMaskedTextBox, "")

        'Check for an empty string
        If stateMaskedTextBox.Text = String.Empty Then
            'Cancel the event
            e.Cancel = True
            ErrorProvider1.SetError(stateMaskedTextBox, "Required Field.")
        End If

    End Sub

    Private Sub zipTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles zipTextBox.Validating
        'Validate for a Required Entry

        'Cancel any previous error
        ErrorProvider1.SetError(zipTextBox, "")

        'Check for an empty string
        If zipTextBox.Text = String.Empty Then
            'Cancel the event
            e.Cancel = True
            ErrorProvider1.SetError(zipTextBox, "Required Field.")
        End If

    End Sub

    Private Sub btnLookupShip_Click(sender As System.Object, e As System.EventArgs) Handles btnLookupShip.Click
        VBShippingForm.ShowDialog()
    End Sub
End Class
