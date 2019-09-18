Module Module1

    Sub Main()
        Dim book(1) As Books
        Dim NextBYes As Boolean
        Dim Creator As String
        Dim Title As String
        Dim RefNo As String
        Dim Loaned As Boolean
        Dim ReturnDate As Date
        For i = 0 To 1
            Console.WriteLine("Enter if the next person is ready to borrow")
            NextBYes = Console.ReadLine()
            Console.WriteLine("Enter Author")
            Creator = Console.ReadLine()
            Console.WriteLine("Enter Title")
            Title = Console.ReadLine()
            Console.WriteLine("Enter Reference Number")
            RefNo = Console.ReadLine()
            Console.WriteLine("Enter Return Date")
            ReturnDate = Console.ReadLine()
            Console.WriteLine("Enter is Loaned")
            Loaned = Console.ReadLine()
            book(i) = New Books(NextBYes, Creator, Title, RefNo, Loaned, ReturnDate)
        Next
        For i = 0 To 1
            book(i).Printer()
            Console.WriteLine()
        Next
        Console.ReadLine()
    End Sub

End Module
