Module Module1

    Sub Main()
        Dim st As New Stack()
        Dim website As String = ""
        Do
            Console.WriteLine("Enter Exit to exit a website to add in Stack a and -1 to go back")
            website = Console.ReadLine()
            If website = "-1" Then
                st.Pop()
            ElseIf website <> "Exit" Then
                st.Push(website)
            End If
        Loop Until website = "Exit"
        Console.ReadLine()
    End Sub

End Module
