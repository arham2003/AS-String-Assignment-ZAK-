Module Module1

    Sub Main()
        
        Dim Str1, Str2 As String
        Dim cons As Char
        Dim Char1, Char2 As Char
        Dim n As Integer


        'Initialize
        Str1 = ""
        Str2 = ""
        Char1 = ""
        Char2 = ""
        cons = "*"
        n = 0

        Console.Write("Enter string to process: ")
        Str1 = Console.ReadLine

        Char1 = Left(Str1, 1)
        Str2 = Str2 + Char1
        If Len(Str1) >= 2 Then

            For n = 2 To Len(Str1)


                Char2 = Mid(Str1, n, 1)
                If Char2 = Char1 Then
                    Str2 = Str2 & cons
                Else
                    Str2 = Str2 & Char2
                End If
            Next

        End If



        Console.Write("The Processed String is: " & Str2)
        Console.ReadKey()



    End Sub

End Module
