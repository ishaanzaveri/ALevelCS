Module Module1

    Sub Main()
        Console.WriteLine("Enter number")
        Console.WriteLine(Factorial(Console.ReadLine()))
        Console.WriteLine(Fibonacci(Console.ReadLine()))
        Console.ReadLine()
    End Sub

    Function Factorial(i As Integer)
        If i = 1 Then
            Return 1
        Else
            Return i * Factorial(i - 1)
        End If
    End Function

    Function Fibonacci(i As Integer)
        If i = 1 Or i = 2 Then
            Return 1
        Else
            Return Fibonacci(i - 1) + Fibonacci(i - 2)
        End If
    End Function


End Module
