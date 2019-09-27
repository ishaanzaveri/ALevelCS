Module Module1
    Public ArrNum(9) As Integer
    Sub BinarySearch(Number As Integer, Start As Integer, EndL As Integer)
        Dim found = False
        If Number = ArrNum(CInt((Start + EndL) / 2)) Then
            Console.WriteLine("found at " & (Start + EndL) / 2)
            found = True
        ElseIf Number > ArrNum(CInt((Start + EndL) / 2)) Then
            BinarySearch(Number, Start, (CInt((Start + EndL) / 2)) - 1)
        Else
            BinarySearch(Number, (CInt((Start + EndL) / 2)) + 1, EndL)
        End If
        'Return found
    End Sub
    Sub Main()
        For i = 0 To 9
            Console.Write("Enter a Number  ")
            ArrNum(i) = Console.ReadLine()
        Next
        BinarySearch(4, 0, 9)
        Console.ReadLine()
    End Sub

End Module
