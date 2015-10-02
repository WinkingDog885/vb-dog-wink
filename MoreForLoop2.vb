Module Module1

    Sub Main()
        Dim i As Integer
        Dim j As Integer

        For i = 1 To 10
            For j = 1 To i

                Console.Write("1")
            Next
            Console.WriteLine("")

        Next

        For i = 9 To 1 Step -1
            For j = 1 To i
                Console.Write(1)
            Next
            Console.WriteLine("")
        Next
        Console.ReadLine()

    End Sub

End Module
