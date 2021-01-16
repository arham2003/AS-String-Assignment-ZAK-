Module Module1

    Sub Main()
        Dim Str1 As String
        Dim Char1, Char2, Char3, AlphaChar, DigitChar As Char
        Dim n, i, z, AlphaCount, DigitCount, otherCount As Integer

        Str1 = ""
        Char1 = ""
        Char2 = ""
        Char3 = ""
        n = 0
        i = 0
        z = 0
        AlphaCount = 0
        DigitCount = 0
        otherCount = 0
        DigitChar = ""
        AlphaChar = ""

        'Input
        Console.Write("Enter String to process: ")
        Str1 = Console.ReadLine

        'process
        Str1 = UCase(Str1)
        For n = 1 To Len(Str1)
            Char2 = Mid(Str1, n, 1)

            For i = 65 To 90
                AlphaChar = Chr(i)
                Char1 = AlphaChar
                If Char1 = Char2 Then
                    AlphaCount = AlphaCount + 1
                End If
            Next

            For z = 0 To 9
                DigitChar = Chr(z)
                Char3 = DigitChar
                If Char3 = Char2 Then
                    DigitCount = DigitCount + 1
                End If
            Next

            If Char2 <> Char1 AND Char2 <> Char3 Then
                otherCount = otherCount + 1
            End If

        Next


        'Output
        Console.WriteLine("Alphabets in string: " & AlphaCount)
        Console.WriteLine("Digits in string: " & DigitCount)
        Console.WriteLine("Other Character in strings: " & otherCount)

        Console.ReadKey()
    End Sub

End Module
