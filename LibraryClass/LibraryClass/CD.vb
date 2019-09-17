Public Class CD
    Inherits LibItem
    Private Genre As String
    Public Sub New(Genre As String)
        MyBase.New
        Me.Genre = Genre
    End Sub
    Sub SetGenre(Genre As String)
        Me.Genre = Genre
    End Sub
    Function GetGenre()
        Return Me.Genre
    End Function
End Class
