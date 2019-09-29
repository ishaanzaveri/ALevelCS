Public Class Stack
    Private Arr(19) As String
    Private TOS As Integer
    Public Sub New()
        TOS = -1
        For i = 0 To 19
            Arr(i) = " "
        Next
    End Sub
    Public Function getTOS() As Integer
        Return TOS
    End Function
    Public Function isStackFull() As Boolean
        If TOS = 19 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub Push(n As String)
        If isStackFull() Then
            Console.WriteLine("Error Stack is full")
        Else
            TOS = TOS + 1
            Arr(TOS) = n
        End If
    End Sub
    Public Sub Pop()
        If isStackEmpty() Then
            Console.WriteLine("Stack empty cant pop")
        Else
            Console.WriteLine(Arr(TOS))
            TOS = TOS - 1
        End If
    End Sub
    Public Function isStackEmpty() As Boolean
        If TOS = -1 Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
