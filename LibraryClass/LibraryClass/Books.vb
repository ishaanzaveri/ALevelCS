Public Class Books
    Inherits LibItem
    Private NextBYes As Boolean
    Public Sub New()
        MyBase.New()
        Dim Creator As String
        Dim Title As String
        Dim RefNo As String
        Dim Loaned As Boolean
        Dim ReturnDate As Date
        Dim NextBYes As Boolean
        Console.WriteLine("Enter Creator")
        Creator = Console.ReadLine()
        Console.WriteLine("Enter Title")
        Title = Console.ReadLine()
        Console.WriteLine("Enter RefNo")
        RefNo = Console.ReadLine()
        Console.WriteLine("Enter Loaned")
        Loaned = Console.ReadLine()
        Console.WriteLine("Enter Return Date")
        ReturnDate = Console.ReadLine()
        Console.WriteLine("Enter if the next borower has requested")
        NextBYes = Console.ReadLine()
        MyBase.New(Creator, Title, RefNo, Loaned, ReturnDate)
    End Sub
End Class
