Imports System.IO
Module Module1
    Structure StudRecord
        Dim SName As String
        Dim Address As String
        Dim FName As String
    End Structure
    Dim stdArr(5) As StudRecord
    Sub InpArr()
        For i = 1 To 5
            Console.WriteLine("Enter Name")
            stdArr(i).FName = Console.ReadLine()
            Console.WriteLine("Enter Last Name")
            stdArr(i).SName = Console.ReadLine()
            Console.WriteLine("Enter Address")
            stdArr(i).Address = Console.ReadLine()
        Next
    End Sub
    Sub Main()
        InpArr()
        Dim stdFileR As BinaryReader
        Dim stdFileW As BinaryWriter
        Dim stdFile As FileStream
        stdFile = New FileStream("students.dat", FileMode.Create)
        stdFileW = New BinaryWriter(stdFile)
        For i = 1 To 5
            stdFileW.Write(stdArr(i).FName)
            stdFileW.Write(stdArr(i).SName)
            stdFileW.Write(stdArr(i).Address)
        Next
        stdFileW.Close()
        stdFile.Close()
    End Sub
End Module
