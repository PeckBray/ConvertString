'Brayden Peck
'RCET0625
'Spring 2021
'Convert String
'
Module ConvertString

    Sub Main()
        Dim userInput1 As String
        Dim integerReturn As Integer
        Dim message As String

        userInput1 = Console.ReadLine()

        message = ConvertString(userInput1, integerReturn)
        Console.WriteLine($"{message}")
        Console.Read()
    End Sub

    Function ConvertString(input As String, integerInput As Integer)
        Dim message As String
        Try
            integerInput = CInt(input)
        Catch ex As Exception
            If input = "" Then
                message = ("There was no input")
            Else
                message = ("input must contain a number")
            End If
        End Try

        Return (message)

    End Function



End Module
