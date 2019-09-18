Module Module1

    Sub Main()
        Dim book(2) As Books
        Dim NextBYes As Boolean
        For i = 0 To 2
            Console.WriteLine("Enter if the next person is ready to borrow")
            NextBYes = Console.ReadLine()
            book(i) = New Books(NextBYes)
            Console.WriteLine("Enter Author")
            book(i).SetCreator(Console.ReadLine())
            Console.WriteLine("Enter Title")
            book(i).SetTitle(Console.ReadLine())
            Console.WriteLine("Enter Reference Number")
            book(i).SetRefNo(Console.ReadLine())
            Console.WriteLine("Enter Return Date")
            book(i).SetReturnDate(Console.ReadLine())
        Next
        For i = 0 To 2
            book(i).Printer()
        Next
        Console.ReadLine()
    End Sub

End Module
