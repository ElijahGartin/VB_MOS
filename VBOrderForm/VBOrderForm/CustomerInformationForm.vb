Public Class CustomerInformationForm

    'Declare the new objects.
    Private TheCustomerInformation As CustomerInformation

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


End Class