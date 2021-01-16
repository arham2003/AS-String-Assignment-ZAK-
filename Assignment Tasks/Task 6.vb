Module Module1

    Sub Main()
        Dim intCount As Integer

        Console.Write("Enter number of donuts: ")
        intCount = Console.ReadLine

        If intCount < 10 Then
            Console.WriteLine("Donuts: " & intCount)
        Else
            Console.WriteLine("Donuts: many")

        End If
        Console.ReadKey()

    End Sub

End Module
