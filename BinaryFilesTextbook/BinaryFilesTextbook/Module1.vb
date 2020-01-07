Imports System.IO
Module Module1
    Structure Customers
        Dim ID As Integer
        Dim Name As String
        Dim TelephoneNo As String
        Dim OrderValue As Decimal
    End Structure
    Dim CustomerData(999) As Customers
    Function Hash(CustomerID As Integer) As Integer
        Dim Address As Integer
        Address = CustomerID Mod 1000
        Return Address
    End Function
    Sub AddRecord(Customer As Customers)
        Dim Address = Hash(Customer.ID)
        While CustomerData(Address).ID <> 0
            Address = Address + 1
            If Address = 1000 Then
                Address = 0
            End If
        End While
        CustomerData(Address) = Customer
    End Sub
    Function FindRecords(customerID As String) As Integer
        Dim address As Integer
        address = Hash(customerID)
        While CustomerData(address).ID <> customerID
            address = address + 1
        End While
        If address = 1000 Then
            address = 0
        End If
        Return address
    End Function
    Sub Main()

    End Sub

End Module
