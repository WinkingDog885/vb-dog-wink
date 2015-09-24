Module Module1

    Sub Main()
        'Dim myValue = As Date = Now()
        'Console.WriteLine(myValue.ToShortDateString())
        'Console.WriteLine(myValue.ToShortTimeString())
        'Console.WriteLine(myValue.AddDays(3).ToShortDateString())
        'Console.WriteLine(myValue.AddHours(-3).ToShortTimeString())
        'Console.WriteLine(myValue.DayOfWeek)
        'Console.WriteLine(myValue.Month)

        'Dim myBirthdate As New Date(1969, 12, 7)
        'myBirthDate = Date.Parse("12/7/1969"))
        Dim myBirthdate = #12/7/1969#

        Dim myAge = Date.Now.Subtract(myBirthdate)
        Console.WriteLine(myAge.TotalDays.ToString())
        Console.WriteLine(myBirthdate)
        Console.ReadLine()


    End Sub

End Module

