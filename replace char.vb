Module Module1

    Sub Main()
        Dim str1 As String
        Dim str2 As String
        Dim char1 As Char
        Dim char2 As Char
        Dim char3 As Char
        Dim i As Integer

        str1 = ""
        str2 = ""
        char1 = ""
        char2 = ""
        char3 = ""

        Console.Write("Enter string to process :")
        str1 = Console.ReadLine



        Console.Write("Enter character that should be replaced :")
        char1 = Console.ReadLine

        Console.Write("Enter character that should replace :")
        char3 = Console.ReadLine

        For i = 1 To Len(str1)
            char2 = Mid(str1, i, 1)
            If char1 <> char2 Then
                str2 = str2 & char2
            Else : str2 = str2 & char3
            End If
        Next i
        Console.WriteLine("Enter string that is processed: " & str2)

        Console.ReadKey()

    End Sub

End Module
