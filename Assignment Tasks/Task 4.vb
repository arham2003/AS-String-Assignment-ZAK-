Module Module1

    Sub Main()
        Dim s, Str2, first2, last2 As String

        s = ""
        Str2 = ""
        first2 = ""
        last2 = ""

        Console.Write("Enter string to process: ")
        s = Console.ReadLine

        If Len(s) > 2 Then
            first2 = Left(s, 2)
            last2 = Right(s, 2)
            Str2 = Str2 & first2 & last2
            Console.WriteLine("the string is: " & Str2)

        Else
            Console.WriteLine("the string is: " & s)

        End If
        Console.ReadKey()






    End Sub

End Module
