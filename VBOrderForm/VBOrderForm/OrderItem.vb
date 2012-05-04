' Project:  VBOrderForm
' Date:     20APR2012
' Author:   Elijah Gartin
' Description: This project will calculate dollar amount due of products ordered
'               then calculate sales tax, shipping and handling, and then
'               it will calculate the final total amount due.

Public Class OrderItem
    Private ProdDescString As String
    Private QuantityInteger As Integer
    Private PriceDecimal, WeightDecimal As Decimal

    'Declare Global Variables
    Private totQuantity As Integer
    Private totWeight, totPrice As Decimal
    Friend totaldue, shipnhandle, subtotPrice As Decimal

    'Declare Global Constants

    Const shippingrate As Decimal = 0.25D

    'Parameterized Constructor.
    Public Sub New(ByVal ProdDescIn As String, ByVal QuantityIn As Integer, ByVal WeightIn As Decimal, ByVal PriceIn As Decimal)
        'Assign Property Values

        ProdDescString = ProdDescIn
        QuantityInteger = QuantityIn
        WeightDecimal = WeightIn
        PriceDecimal = PriceIn
        Input()
        FindShipping()
        Calculate()

    End Sub

    Property ProdDesc() As String
        Get
            Return ProdDescString
        End Get
        Set(value As String)
            ProdDescString = value
        End Set
    End Property

    Property Quantity() As Integer
        Get
            Return QuantityInteger
        End Get
        Set(value As Integer)
            If value >= 0 Then
                QuantityInteger = value
            End If
        End Set
    End Property
    Property Weight() As Decimal
        Get
            Return WeightDecimal
        End Get
        Set(value As Decimal)
            If value >= 0 Then
                WeightDecimal = value
            End If
        End Set
    End Property


    Property Price() As Decimal
        Get
            Return PriceDecimal
        End Get
        Set(value As Decimal)
            If value >= 0 Then
                PriceDecimal = value
            End If
        End Set
    End Property

    Public Sub Input()
        'Find the Quantity, Weight, and Price

        'Calculate the charge and weight for the current item.
        subtotPrice = QuantityInteger * PriceDecimal
        Weight = QuantityInteger * WeightDecimal
        totWeight = totWeight + WeightDecimal
        totPrice = totPrice + subtotPrice

    End Sub

    Protected Sub FindShipping()
        Dim handling, shipping As Decimal
        'Calculate shipping and handling

        'Handling
        If totWeight > 0 And totWeight < 10 Then
            handling = 1
        ElseIf totWeight >= 10 And totWeight <= 100 Then
            handling = 3
        ElseIf totWeight > 100 Then
            handling = 5
        End If

        'Shipping
        shipping = totWeight * shippingrate
        shipnhandle = handling + shipping
    End Sub

    Protected Overridable Sub Calculate()
        'Calculate total amount due
        totaldue = totPrice + shipnhandle

    End Sub


End Class
