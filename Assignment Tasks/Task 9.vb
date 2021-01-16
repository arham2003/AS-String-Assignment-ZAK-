Module Module1

    Sub Main()
        Dim a, b, Str3, Str4, Str5 As String
        Dim Char1, Char2, Char3, Char4 As Char
        Dim n, i As Integer

        a = ""
        b = ""
        Str3 = ""
        Str4 = ""
        Str5 = ""
        Char1 = ""
        Char2 = ""
        Char3 = ""
        Char4 = ""
        n = 0
        i = 0

        Console.Write("Enter String to Process: ")
        a = Console.ReadLine

        Console.Write("Enter String to Process: ")
        b = Console.ReadLine

        If Len(a) >= 2 And Len(b) >= 2 Then
            For n = 1 To 2
                Char1 = Mid(a, n, 1)
                Char2 = Mid(b, n, 1)

                Str3 = Str3 & Char2
                Str4 = Str4 & Char1

            Next

            For i = 3 To Len(a)
                Char3 = Mid(a, i, 1)
                Str3 = Str3 & Char3

            Next

            For z = 3 To Len(b)
                Char4 = Mid(b, z, 1)
                Str4 = Str4 & Char4

            Next

            Str5 = Str5 & Str3 & " " & Str4


        End If

        Console.WriteLine("The mixed up string is: " & Str5)
        Console.ReadKey()


    End Sub

End Module
