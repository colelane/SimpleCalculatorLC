Option Strict On
Option Explicit On
Option Compare Text
'Lane Coleman
'RCET0265
'Fall 2020
'Simple Calculator
'https://github.com/colelane/SimpleCalculatorLC.git

Module SimpleCalculatorLC

    Sub Main()
        Dim firstInput, secondInput, userResponse As String
        Dim firstNumber, secondNumber As Double
        Dim goodData As Boolean
        Do
            Console.WriteLine("Enter q at any time to quit." & vbNewLine)
            Do
                Try
                    'try catch looks for errors. goodData is a flag that is used to tell the do to loop until goodData is true.
                    'loops back if there is a catch because goodData = false.
                    Console.WriteLine("Give me a number")
                    firstInput = Console.ReadLine()
                    firstNumber = CDbl(firstInput)
                    Console.WriteLine("Give me another number")
                    secondInput = Console.ReadLine()
                    secondNumber = CDbl(secondInput)
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
                'computation loop.
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
        'loops until q is entered, so that calculator can be looped continuously.
    End Sub

End Module
