Public Class Books
    Inherits LibItem
    Private NextBYes As Boolean
    Public Sub New(NextBYes As Boolean, Creator As String, Title As String, RefNo As String, Loaned As Boolean, ReturnDate As Date)
        MyBase.New(Creator, Title, RefNo, Loaned, ReturnDate)
        Me.NextBYes = NextBYes
    End Sub
    Sub SetNextBYes(NextBYes As Boolean)
        Me.NextBYes = NextBYes
    End Sub
    Function GetNextBYes()
        Return Me.NextBYes
    End Function
    Public Overrides Sub Printer()
        MyBase.Printer()
        Console.WriteLine("Has the next borrower requested: " & NextBYes)
    End Sub
End Class
