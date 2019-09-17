Public Class Books
    Inherits LibItem
    Private NextBYes As Boolean
    Public Sub New(NextBYes As Boolean)
        MyBase.New()
        Me.NextBYes = NextBYes
    End Sub
    Sub SetNextBYes(NextBYes As Boolean)
        Me.NextBYes = NextBYes
    End Sub
    Function GetNextBYes()
        Return Me.NextBYes
    End Function
End Class
