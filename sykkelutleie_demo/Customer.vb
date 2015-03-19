Public Class Customer
    Inherits Person

    Private customerID As String

    Sub New(fn As String, ln As String, phone As String, email As String)
        MyBase.New(fn, ln, phone, email)
    End Sub

    'Testkonstruktør
    Sub New()
        MyBase.New()
    End Sub

    Public Function getCustomerID() As String
        Return customerID
    End Function
End Class
