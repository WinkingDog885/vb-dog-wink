Module Module1

    Sub Main()
        Dim userName As String
        Dim userNum As Double
        Dim userNum2 As Double
        Dim userOper As String

        Console.Write("Hello. What is your name?: ")
        userName = Console.ReadLine
        Console.WriteLine("Hello, " & userName & "." & vbCrLf & "Welcome to my First Visual Basic Application" & vbCrLf & "Please Choose 2 Numbers and an Operation")

        Console.Write("First Number: ")
        userNum = Console.ReadLine

        Console.Write("Second Number: ")
        userNum2 = Console.ReadLine

        Console.WriteLine("Select an Operation (Type out the Operation Name)" & vbCrLf & "Add, Subtract, Multiply or Divide")
        Console.Write("Operation: ")
        userOper = Console.ReadLine

        If userOper = "Add" Or userOper = "add" Then
            Console.WriteLine(userNum & "+" & userNum2 & "=" & userNum + userNum2)
            Console.ReadLine()
            End
        End If

        If userOper = "Subtract" Or userOper = "subtract" Then
            Console.WriteLine(userNum & "-" & userNum2 & "=" & userNum - userNum2)
            Console.ReadLine()
            End
        End If

        If userOper = "Multiply" Or userOper = "multiply" Then
            Console.WriteLine(userNum & "*" & userNum2 & "=" & userNum * userNum2)
            Console.ReadLine()
            End
        End If

        If userOper = "Divide" Or userOper = "divide" Then
            Console.WriteLine(userNum & "/" & userNum2 & "=" & userNum / userNum2)
            Console.ReadLine()
            End
        End If

        Console.WriteLine("Sorry, that isn't a valid choice")
        Console.ReadLine()







    End Sub

End Module
