' Project:  VBOrderForm
' Date:     20APR2012
' Author:   Elijah Gartin
' Description: This project will calculate dollar amount due of products ordered
'               then calculate sales tax, shipping and handling, and then
'               it will calculate the final total amount due.

Public Class CustomerInformation
    Private NameString As String
    Private AddressString As String
    Private CityString As String
    Private StateString As String
    Private ZipString As String

    'Declare Global Variables

    'Declare Global Constants

    'Parameterized Constructor.
    Public Sub New(ByVal NameIn As String, ByVal AddressIn As String, ByVal CityIn As String, ByVal StateIn As String, ByVal ZipIn As String)
        'Assign Property Values

        NameString = NameIn
        AddressString = AddressIn
        CityString = CityIn
        StateString = StateIn
        ZipString = ZipIn

    End Sub

    Property Name() As String
        Get
            Return NameString
        End Get
        Set(value As String)
            NameString = value
        End Set
    End Property

    Property Address() As String
        Get
            Return AddressString
        End Get
        Set(value As String)
            AddressString = value
        End Set
    End Property
    Property City() As String
        Get
            Return CityString
        End Get
        Set(value As String)
            CityString = value
        End Set
    End Property


    Property State() As String
        Get
            Return StateString
        End Get
        Set(value As String)
            StateString = value
        End Set
    End Property

    Property Zip() As String
        Get
            Return ZipString
        End Get
        Set(value As String)
            ZipString = value
        End Set
    End Property
End Class
