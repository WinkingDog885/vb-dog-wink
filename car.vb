Public Class Car

    Public Make As String
    Public Model As String
    Public Year As Integer
    Public Colour As String
    Public Amount As Double
    Public Surcharge As Double
    Public Sub New()

    End Sub
    Public Sub New(ByVal _Make As String, ByVal _Year As Integer, ByVal _Amount As Double)
        Me.Make = _Make
        Me.Year = _Year
        Me.Amount = _Amount
        Me.Surcharge = _Amount * 1.025


    End Sub

    Public Function determineMarketValue(ByVal myCar As Car) As Double
        Return 100.0


    End Function

    Public Sub myMethod(ByVal myParameter As String)

    End Sub

    Public Sub myMethod(ByVal anotherVersion As String, ByVal myParameter As String)

    End Sub

    Public Sub myMethod(ByVal myParameter As Integer)
        'body of the method goes here
    End Sub

End Class

Public Class CarLot
    Public Shared Sub AddToInventory(ByVal newCar As Car)

    End Sub

End Class
