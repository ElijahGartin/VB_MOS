Public Class ProductLookupForm

    Private Sub ProductBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ProductBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VbMailDataSet)

    End Sub

    Private Sub ProductLookupForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VbMailDataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.VbMailDataSet.Product)

    End Sub
End Class