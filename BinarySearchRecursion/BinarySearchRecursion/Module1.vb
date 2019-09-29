Module Module1
    Public ArrNum(9) As Integer
    Public found = False
    Sub BinarySearch(Number As Integer, Start As Integer, EndL As Integer)
        Dim mid = CInt((Start + EndL) / 2)
        If Number = ArrNum(mid) Then
            Console.WriteLine("found at " & (Start + EndL) / 2)
            found = True
        ElseIf Number < ArrNum(mid) Then
            BinarySearch(Number, Start, mid - 1)
        Else
            BinarySearch(Number, mid + 1, EndL)
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
