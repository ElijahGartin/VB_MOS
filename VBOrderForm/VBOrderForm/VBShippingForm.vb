'Program:       VBShippingForm
'Programmer:    Elijah Gartin
'Date:          12MAR2012
'Description:   This form will take a two dimensional table of rates
'               that match weight and zone of the delivery
'               and calculate the shipping cost based off the selection.
'               
'Class:         VBShippingForm

Public Class VBShippingForm
    'Declare structure and module-level variables
    Structure Shipping
        Dim ZoneString As String
        Dim WeightString As String
        Dim PriceDecimal As Decimal
    End Structure

    Private TransactionShipping(20) As Shipping
    Private NumberTransactionsInteger As Integer
    Private PriceDecimal(,) As Decimal =
        {{1D, 1.5D, 1.65D, 1.85D},
         {1.58D, 2D, 2.4D, 3.05D},
         {1.71D, 2.52D, 3.1D, 4D},
         {2.04D, 3.12D, 4D, 5.01D},
         {2.52D, 3.75D, 5.1D, 7.25D}}
    Private SelectedButtonString As String

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        'Remove the selection from the list and clear the price.

        'Select first radio button.
        radio1lb.Checked = True
        'Clear coffee type selection.
        ZoneComboBox.SelectedIndex = -1
        PriceTextBox.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        'Terminate the project.
        Dim ResponseDialogResult As DialogResult

        ResponseDialogResult = MessageBox.Show("Print the report?", "Terminate the Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ResponseDialogResult = Windows.Forms.DialogResult.Yes Then
            btnPrint_Click(sender, e)
        End If
        Me.Close()
    End Sub

    Private Sub btnFindPrice_Click(sender As System.Object, e As System.EventArgs) Handles btnFindPrice.Click
        'Lookup the price using the quantity and type.

        Dim RowInteger, ColumnInteger As Integer
        Dim ShippingPriceDecimal As Decimal

        'Allow only 20 transactions.
        If NumberTransactionsInteger < 20 Then
            ColumnInteger = ZoneComboBox.SelectedIndex
            If ColumnInteger <> -1 Then
                'Coffee selection made, determine quantity selected.
                Select Case SelectedButtonString
                    Case "radio1lb"
                        RowInteger = 0
                        TransactionShipping(NumberTransactionsInteger).WeightString = "Up to 1lb"
                    Case "radio3lb"
                        RowInteger = 1
                        TransactionShipping(NumberTransactionsInteger).WeightString = "Up to 3lb"
                    Case "radio5lb"
                        RowInteger = 2
                        TransactionShipping(NumberTransactionsInteger).WeightString = "Up to 5lb"
                    Case "radio10lb"
                        RowInteger = 3
                        TransactionShipping(NumberTransactionsInteger).WeightString = "Up to 10lb"
                    Case "radio10pluslb"
                        RowInteger = 4
                        TransactionShipping(NumberTransactionsInteger).WeightString = "Greater than 10lbs"
                    Case Else
                        'No selection made; use 1lb.
                        RowInteger = 0
                        TransactionShipping(NumberTransactionsInteger).WeightString = "Up to 1lb"
                End Select

                'Retrieve price of selection.
                ShippingPriceDecimal = PriceDecimal(RowInteger, ColumnInteger)
                PriceTextBox.Text = ShippingPriceDecimal.ToString("C")
                'Save this transaction.
                TransactionShipping(NumberTransactionsInteger).ZoneString = ZoneComboBox.Text
                TransactionShipping(NumberTransactionsInteger).PriceDecimal = ShippingPriceDecimal
                NumberTransactionsInteger += 1
            Else
                MessageBox.Show("Select the Zone.", "Selection Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Sorry, only 20 transactions allowed.")
        End If
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        'Print the report using Print Preview.

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Handles print and print previews

        Dim PrintFont As New Font("Arial", 12)
        Dim HeadingFont As New Font("Arial", 14, FontStyle.Bold)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim Column1HorizontalLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim Column2HorizontalLocationSingle As Single = 300
        Dim Column3HorizontalLocationSingle As Single
        Dim PrintLineString As String
        Dim FontSizeF As New SizeF
        Dim FormattedPriceString As String

        'Set up and display heading lines.
        PrintLineString = "VB Mail Order Shipping Cost"
        e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black, Column2HorizontalLocationSingle, VerticalPrintLocationSingle)
        PrintLineString = "by Elijah Gartin"
        VerticalPrintLocationSingle += LineHeightSingle
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, Column2HorizontalLocationSingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle * 2

        'Loop through the transactions.
        For Each IndividualShippingCost As Shipping In TransactionShipping
            'Don't print if blank.
            If IndividualShippingCost.WeightString <> "" Then
                'Set up a line.

                'Weight.
                e.Graphics.DrawString(IndividualShippingCost.WeightString, PrintFont, Brushes.Black, Column1HorizontalLocationSingle, VerticalPrintLocationSingle)

                'Zone.
                e.Graphics.DrawString(IndividualShippingCost.ZoneString, PrintFont, Brushes.Black, Column2HorizontalLocationSingle, VerticalPrintLocationSingle)

                'Right-align the price.
                FormattedPriceString = FormatNumber(IndividualShippingCost.PriceDecimal)
                'Measure string in this font.
                FontSizeF = e.Graphics.MeasureString(FormattedPriceString, PrintFont)
                'Subtract width of string from column position.
                Column3HorizontalLocationSingle = 550 - FontSizeF.Width
                e.Graphics.DrawString(FormattedPriceString, PrintFont, Brushes.Black, Column3HorizontalLocationSingle, VerticalPrintLocationSingle)

                'Increment the Y position for the next line; Double space.
                VerticalPrintLocationSingle += LineHeightSingle * 2
            End If
        Next
    End Sub

    Private Sub radio1lb_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radio1lb.CheckedChanged, radio3lb.CheckedChanged, radio5lb.CheckedChanged, radio10lb.CheckedChanged, radio10pluslb.CheckedChanged
        'Save the name of the selected radio button.
        'This procedure is executed each time any radio button is seleected.

        SelectedButtonString = CType(sender, RadioButton).Name

    End Sub

    Private Sub VBShippingForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            VisitLink1()
        Catch ex As Exception
            ' The error message
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            VisitLink2()
        Catch ex As Exception
            ' The error message
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Try
            VisitLink3()
        Catch ex As Exception
            ' The error message
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub

    Sub VisitLink1()
        ' Change the color of the link text by setting LinkVisited 
        ' to True.
        LinkLabel1.LinkVisited = True
        ' Call the Process.Start method to open the default browser 
        ' with a URL:
        System.Diagnostics.Process.Start("http://www.fedex.com/")
    End Sub
    Sub VisitLink2()
        ' Change the color of the link text by setting LinkVisited 
        ' to True.
        LinkLabel2.LinkVisited = True
        ' Call the Process.Start method to open the default browser 
        ' with a URL:
        System.Diagnostics.Process.Start("http://www.ups.com/")
    End Sub
    Sub VisitLink3()
        ' Change the color of the link text by setting LinkVisited 
        ' to True.
        LinkLabel3.LinkVisited = True
        ' Call the Process.Start method to open the default browser 
        ' with a URL:
        System.Diagnostics.Process.Start("https://www.usps.com/")
    End Sub

End Class
