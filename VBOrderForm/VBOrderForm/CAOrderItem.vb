Public Class CAOrderItem
    Inherits OrderItem

    Const CA_RATE_Decimal As Decimal = 0.08D
    Public totTaxDecimal As Decimal

    Sub New(ByVal ProdDescIn As String, ByVal QuantityIn As Integer, ByVal WeightIn As Decimal, ByVal PriceIn As Decimal)
        'Assign property values.

        'Call base-class constructor and pass the property values.
        MyBase.New(ProdDescIn, QuantityIn, WeightIn, PriceIn)
    End Sub

    'Shared ReadOnly Property totTax() As Decimal
    '   Get
    '      Return totTaxDecimal
    ' End Get
    'End Property

    Protected Overrides Sub Calculate()
        'Calculate the extended price and add to the totals.

        totTaxDecimal = Price * CA_RATE_Decimal
        totaldue = Quantity * Price + totTaxDecimal
    End Sub
End Class

