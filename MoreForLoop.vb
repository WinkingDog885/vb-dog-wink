Module Module1

    Sub Main()
        Dim i As Integer = 0
        Dim j As Integer = 0

        For i = 1 To 10
            For j = 1 To i
                Console.Write(j)
            Next
            Console.WriteLine("")

        Next

        For i = 9 To 1 Step -1
            For j = 1 To i
                Console.Write(j)
            Next
            Console.WriteLine("")
        Next

        Console.ReadLine()

    End Sub

End Module
