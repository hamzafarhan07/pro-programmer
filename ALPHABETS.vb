Module Module1

    Sub Main()
        Dim str1 As String
        Dim alphabets As String
        Dim char1 As Char
        Dim i As Integer
        Dim containallalphabets As Boolean
        str1 = ""
        alphabets = "abcdefghijklmnopqrstuvwxyz"
        char1 = ""
        i = 0
        containallalphabets = True

        Console.Write("Enter string to process :")
        str1 = Console.ReadLine
        str1 = LCase(str1)

        For i = 1 To Len(str1)
            char1 = Mid(alphabets, i, 1)
            If InStr(str1, char1) = 0 Then
                containallalphabets = False
            End If
            If containallalphabets = False Then
                Exit For
            End If
        Next
        If containallalphabets = True Then
            Console.WriteLine("entered stirng contains all alphabets")
        End If
        If containallalphabets = False Then
            Console.WriteLine("entered string does not contain all alphabets")
        End If
        Console.ReadKey()


    End Sub

End Module
