Imports System.Query.Sequence
Imports System.Runtime.CompilerServices
Imports QueryArray.Extensions

Module Module1
#Region "Data Samples"
    Dim people As List(Of Person)
    Dim roles As List(Of Role)
#End Region

    Sub Main()
        FillDataSamples()

        ' Listing1_1()

        ' Listing1_2()

        ' Listing1_3()

        ' Listing1_4()

        ' Listing1_5()

        ' Listing1_6()

        ' Listing1_9()
    End Sub

#Region "Fill Data Samples"
    Sub FillDataSamples()
        people = New List(Of Person) { _
            {ID := 1, IDRole := 1, LastName := "Anderson", FirstName := "Brad"}, _
            {ID := 2, IDRole := 2, LastName := "Gray", FirstName := "Tom"} _
        }

        roles = New List(Of Role) { _
            {ID := 1, RoleDescription := "Manager"}, _
            {ID := 2, RoleDescription := "Developer"} _
        }
    End Sub
#End Region

#Region "Listing 1-1"
    Sub Listing1_1()
        Dim query = From p In people _
            Where p.ID = 1 _
            Select p

        ObjectDumper.Write(query)
    End Sub
#End Region

#Region "Listing 1-2"
    Sub Listing1_2()
        Dim query = people.Where(AddressOf F)

        ObjectDumper.Write(query)
    End Sub

    Function F(ByVal people As Person) As Boolean
        Return people.ID = 1
    End Function
#End Region

#Region "Listing 1-3"
    <Extension()> _
    Public Class Extensions

        <Extension()> _
        Public Shared Function SpaceToUnderscore(ByVal source As String) As String
            Dim cArray As Char() = source.ToCharArray()
            Dim result As String = String.Empty

            For Each c As Char In cArray
                If Char.IsWhiteSpace(c) Then
                    result = result & "_"
                Else
                    result = result & c
                End If
            Next

            Return result
        End Function
    End Class

    Sub Listing1_3()
        Dim s As String = "this is a test"
        Console.WriteLine(s.SpaceToUnderscore())
    End Sub
#End Region

#Region "Listing 1-4"
    Sub Listing1_4()
        Dim predicate As New Func(Of Person, Boolean)(AddressOf wherePredicate)
        Dim query = people.Where(predicate)

        ObjectDumper.Write(query)
    End Sub

    Public Function wherePredicate(ByVal p As Person) As Boolean
        Return p.ID = 1
    End Function

#End Region

#Region "Listing 1-5"
    Sub Listing1_5()
        ' The standard object creation and initialization
        Dim p1 As New Person()
        p1.FirstName = "Brad"
        p1.LastName = "Anderson"
        ObjectDumper.Write(p1)

        Dim p2 = New Person {FirstName := "Tom", LastName := "Gray"}
        ObjectDumper.Write(p2)
    End Sub
#End Region

#Region "Listing 1-6"
    Sub Listing1_6()
        Dim query = From p In people _
            Where p.ID = 1 _
            Select New {p.FirstName, p.LastName}

        ObjectDumper.Write(query)
    End Sub
#End Region

#Region "Listing 1-9"
    Sub Listing1_9()
        Dim query = (From p In people _
            Where p.ID = 1 _
            Select New {p.FirstName, p.LastName}).ToArray()

        ObjectDumper.Write(query)

        people(0).FirstName = "Fabio"

        ObjectDumper.Write(query)

    End Sub
#End Region
End Module
