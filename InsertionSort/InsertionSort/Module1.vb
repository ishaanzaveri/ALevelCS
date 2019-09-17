Module Module1

    Sub Main()
        'Instertion Sort 
        Dim InsI As Integer = 1
        Dim Point As Integer = 1
        Dim Arr() As Integer = {1, 8, 5, 3, 21, 5, 77, 2, 66, 9}
        Dim CI As Integer

        For Point = 1 To 9
            CI = Point - 1
            InsI = Arr(Point)
            Do While Arr(CI) > InsI And CI > 0
                Arr(CI + 1) = Arr(CI)
                CI = CI - 1
            Loop
            Arr(CI + 1) = InsI
        Next

        For i = 0 To 9
            Console.WriteLine(Arr(i))
        Next
        Console.ReadLine()
    End Sub

End Module
