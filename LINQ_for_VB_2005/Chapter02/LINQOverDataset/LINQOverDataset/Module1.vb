Module Module1

    Sub Main()
        ' Listing2_27()

        ' Listing2_29()
    End Sub

#Region "Listing 2-27"
    Sub Listing2_27()
        Dim ds As New dsPeople()
        Dim people As New PeopleDataContext()

        Dim q = From r In people.Roles _
            Select r

        ds.Role.LoadSequence(q)

        Listing2_28(ds)
    End Sub
#End Region

#Region "Listing 2-28"
    Sub Listing2_28(ByVal ds As dsPeople)
        Dim query = From r In ds.Role _
            Where r.ID = 1 _
            Select r

        For Each Dim row In query
            Console.WriteLine("Role: {0} {1}", row.ID, row.RoleDescription)
        Next
    End Sub
#End Region

#Region "Listing 2-29"
    Sub Listing2_29()
        Dim people As New PeopleDataContext()

        Dim q = From p In people.People _
            Select p

        Dim ds As New DataSet("People")
        ds.Tables.Add(q.ToDataTable())

        Listing2_30(ds)
    End Sub
#End Region

#Region "Listing2-30"
    Sub Listing2_30(ByVal ds As DataSet)
        Dim dtPerson As DataTable = ds.Tables(0)

        Dim person = dtPerson.ToQueryable()

        Dim query = From p In person _
            Where p.Field(Of String)("LastName") = "Grant" _
            Select p

        For Each Dim row In query
            Console.WriteLine("Person: {0} {1}", _
                                                row.Field(Of String)("FirstName"), _
                                                row.Field(Of String)("LastName"))

        Next

    End Sub
#End Region
End Module
