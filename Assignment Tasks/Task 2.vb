Module Module1

    Sub Main()
        Dim Str1, Str2 As String
        Dim Char1, Char2, Char3 As Char
        Dim n As Integer

        Str1 = ""
        Str2 = ""
        Char1 = ""
        Char2 = ""
        Char3 = ""
        n = 0

        Console.Write("Enter the string to alter: ")
        Str1 = Console.ReadLine

        Console.Write("Enter the character to alter: ")
        Char1 = Console.ReadLine

        Console.Write("Enter the character to replace with: ")
        Char2 = Console.ReadLine


        For n = 1 To Len(Str1)
            Char3 = Mid(Str1, n, 1)
            If Char1 <> Char3 Then
                Str2 = Str2 & Char3
            ElseIf Char1 = Char3 Then
                Str2 = Str2 & Char2
            End If
        Next

        Console.WriteLine("The altered string is: " & Str2)
        Console.ReadKey()


    End Sub

End Module
