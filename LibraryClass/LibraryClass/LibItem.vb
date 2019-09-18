Public Class LibItem
    Private Creator As String
    Private Title As String
    Private RefNo As String
    Private Loaned As Boolean
    Private ReturnDate As Date
    Public Sub New()

    End Sub
    Public Sub New(Creator As String, Title As String, RefNo As String, Loaned As Boolean, ReturnDate As Date)
        Me.Creator = Creator
        Me.Title = Title
        Me.RefNo = RefNo
        Me.Loaned = Loaned
        Me.ReturnDate = ReturnDate
    End Sub
    Sub SetCreator(Creator As String)
        Me.Creator = Creator
    End Sub
    Sub SetTitle(Title As String)
        Me.Title = Title
    End Sub
    Sub SetRefNo(RefNo As String)
        Me.RefNo = RefNo
    End Sub
    Sub SetLoaned(Loaned As Boolean)
        Me.Loaned = Loaned
    End Sub
    Sub SetReturnDate(ReturnDate As Date)
        Me.ReturnDate = ReturnDate
    End Sub
    Function GetCreator()
        Return Me.Creator
    End Function
    Function GetTitle()
        Return Me.Title
    End Function
    Function GetRefNo()
        Return Me.RefNo
    End Function
    Function GetLoaned()
        Return Me.Loaned
    End Function
    Function GetReturnDate()
        Return Me.ReturnDate
    End Function
    Public Overridable Sub Printer()
        Console.WriteLine("Creator: " & Creator)
        Console.WriteLine("Title: " & Title)
        Console.WriteLine("Reference Number: " & RefNo)
        Console.WriteLine("is Loaned: " & Loaned)
        Console.WriteLine("Return Date: " & ReturnDate)
    End Sub
End Class
