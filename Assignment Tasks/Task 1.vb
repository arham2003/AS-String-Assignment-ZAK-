Module Module1

    Sub Main()
        Dim Str1, Str2, Str3 As String
        Dim char1, char2 As Char
        Dim n, i As Integer
        Dim isSame As Boolean

        Str1 = ""
        Str2 = ""
        Str3 = ""
        char1 = ""
        char2 = ""
        n = 0
        i = 0
        isSame = True

        Console.Write("enter string to process: ")
        Str1 = Console.ReadLine

        For n = 1 To Len(Str1)
            char1 = Mid(Str1, n, 1)
            Str2 = Str2 & char1
        Next
        Str2 = LCase(Str2)

        If Str1 <> Str2 Then isSame = False

        For i = 1 To Len(Str1)
            char2 = Mid(Str1, i, 1)
            Str3 = Str3 & char2
        Next

        Str3 = UCase(Str3)

        If isSame = True Then
            Console.WriteLine(Str1 & " " & "is all small")
            Console.ReadKey()
        End If
        If Str1 <> Str3 Then
            Console.WriteLine(Str1 & " " & "is all capital")
            Console.ReadKey()
        End If
        If isSame = False Or Str1 <> Str3 Then
            Console.WriteLine(Str1 & " " & "String is not all same.")
            Console.ReadKey()

        End If
    End Sub

End Module
