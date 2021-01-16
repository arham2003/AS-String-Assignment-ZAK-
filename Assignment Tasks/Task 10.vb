Module Module1

    Sub Main()
        Dim Str1, Str2, Word1 As String
        Dim Char2 As Char
        Dim z As Integer

        Str1 = ""
        Str2 = ""
        Word1 = "ing"
        Char2 = ""
        z = 0

        Console.Write("Enter string to process: ")
        Str1 = Console.ReadLine

        'Process
        If Len(Str1) >= 3 Then
            For z = 1 To Len(Str1)
                Char2 = Mid(Str1, z, 1)
                Str2 = Str2 + Char2

            Next


            If InStr(Str1, Word1) = 0 Then
                Str2 = Str2 & "ing"
            ElseIf InStr(Str1, Word1) > 0 Then
                Str2 = Str2 & "ly"

            End If

        End If

        'output
        If Len(Str1) < 3 Then
            Console.WriteLine("The processed string is : " & Str1)
        Else
            Console.WriteLine("The processed string is : " & Str2)
        End If

        Console.ReadKey()

    End Sub

End Module
