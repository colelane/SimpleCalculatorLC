Option Strict On
Option Explicit On
Option Compare Text
'Lane Coleman
'RCET0265
'Fall 2020
'Simple Calculator
'

Module SimpleCalculatorLC

    Sub Main()
        Dim firstInput, secondInput, userResponse As String
        Dim firstNumber, secondNumber As Integer
        Dim goodData As Boolean
        Do
            Console.WriteLine("Enter q at any time to quit." & vbNewLine)
            Do
                Try
                    Console.WriteLine("Give me a number")
                    firstInput = Console.ReadLine()
                    firstNumber = CInt(firstInput)
                    Console.WriteLine("Give me another number")
                    secondInput = Console.ReadLine()
                    secondNumber = CInt(secondInput)
                    goodData = True
                Catch ex As Exception
                    If firstInput = "q" Or secondInput = "q" Then
                        Exit Sub
                    End If
                    Console.WriteLine("I asked for a number! Try again.")
                    goodData = False
                End Try

            Loop Until goodData = True

            Do
                Console.WriteLine("add or multiply?")
                userResponse = Console.ReadLine()
                If userResponse = "q" Then
                    Exit Sub
                ElseIf userResponse = "add" Then
                    Console.WriteLine(firstNumber + secondNumber)

                ElseIf userResponse = "multiply" Then
                    Console.WriteLine(firstNumber * secondNumber)

                ElseIf userResponse <> "multiply" And userResponse <> "add" Then
                    Console.WriteLine("Only multiply or add will work")



                End If
            Loop Until userResponse = "add" Or userResponse = "multiply"
            Console.ReadLine()
            Console.Clear()

        Loop

    End Sub

End Module
