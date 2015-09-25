Module Module1

    Sub Main()
        'Dim myNewCar As Car = New Car
        Dim myNewCar As New Car
        'Dim myOtherCar As Car = myNewCar
        'Dim myOtherCar As New Car("BMW,2005,30000)

        CarLot.AddToInventory(myNewCar)

        myNewCar.Make = "Oldsmobile"
        myNewCar.Model = "Cutlas Supreme"
        myNewCar.Year = 1986
        myNewCar.Colour = "Silver"

        'With myNewCar
        '.Make = "Oldsmobile"
        '.Model = "Cutlass Supreme"
        '.Year = "1986"
        '.Colour = "Silver"
        'End With

        'Console.WriteLine("{0} - {1} - {2}", myNewCar.Make, myNewCar.Model, myNewCar.Year, myNewCar.Year.ToString())
        'Console.WriteLine(determineMarketValue(myNewCar))
        'Console.WriteLine(myNewCar.determineMarketValue())

        Console.WriteLine("Before:" & myNewCar.Make)
        doByValue(myNewCar)
        Console.WriteLine("After By Value:" & myNewCar.Make)

        doByReference(myNewCar)
        Console.WriteLine("After By Reference:" & myNewCar.Make)
        Console.ReadLine()

    End Sub
    'Function.determineMarketValue(ByVal myCar as Car) As Double
    'super secret formula

        'Return 100.0

    Sub doByValue(ByVal myCar As Car)
        myCar = New Car
        myCar.Make = "BMW"
    End Sub

    Sub doByReference(ByRef myCar As Car)
        myCar = New Car
        myCar.Make = "BMW"

    End Sub


End Module
