Module Module1

    Sub Main()
        'Dim myNewCar As Car = New Car
        Dim myNewCar As New Car

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
        Console.WriteLine(myNewCar.determineMarketValue())
        Console.ReadLine()


    End Sub


End Module
