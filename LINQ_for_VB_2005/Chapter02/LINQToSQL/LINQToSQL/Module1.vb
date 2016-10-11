Imports System.Transactions
Imports System.Expressions
Imports System.Reflection

Module Module1

    Sub Main()
        ' Listing2_2()

        ' Listing2_3()

        ' Listing2_4()

        ' Listing2_5()

        ' --- Listing 2-6
        'Dim p As New UpdateExample()
        'p.Listing2_6()
        ' --- End of Listing 2-6

        ' Listing2_7()

        ' Listing2_10()

        ' --- Listing 2-11
        'Dim p As New AddExample()
        'p.Listing2_11()
        ' --- End of Listing 2-11

        ' --- Listing 2-12
        'Dim p As New DeleteExample()
        'p.Listing2_12()
        ' --- End of Listing 2-12

        ' --- Listing 2-13
        'Dim p As New OptimisticConcurrencyExample()
        'p.Listing2_13()
        ' --- End of Listing 2-13

        ' --- Listing 2-14
        'Dim p As New OptimisticConcurrencyExample2()
        'p.Listing2_14()
        ' --- End of Listing 2-14

        ' --- Listing 2-15
        'Dim p As New TransactionExample()
        'p.Listing2_15()
        ' --- End of Listing 2-15

        ' Listing2_16()

        ' Listing2_17()

        ' --- Listing 2-18
        'Dim p As New UpdateBySPExample()
        'p.Listing2_18()
        ' --- End of Listing 2-18

        ' Listing2_19()

        ' Listing2_20()

        ' Listing2_21()

        ' Listing2_22()

        ' Listing2_23()

        ' Listing2_24()

        ' Listing2_26()

    End Sub

#Region "Listing 2-2"
    Sub Listing2_2()
        Dim people = New PeopleDataContext()
        Dim tablePeople = people.People
        Dim tableSalaries = people.Salaries

        Dim query = From p In tablePeople, s In tableSalaries _
            Where p.ID = s.ID _
            Select New {p.LastName, p.FirstName, s.Year, s.SalaryYear}

        For Each Dim record In query
            Console.WriteLine("Name: {0}, {1} - Year: {2}", record.LastName, record.FirstName, record.Year)
            Console.WriteLine("Salary: {0}", record.SalaryYear)
        Next
    End Sub
#End Region

#Region "Listing 2-3"
    Sub Listing2_3()
        Dim people = New PeopleDataContext()
        Dim tablePeople = people.People
        Dim tableSalaries = people.Salaries

        people.Log = Console.Out

        Dim query = From p In tablePeople, s In tableSalaries _
            Where p.ID = s.ID _
            Select New {p.LastName, p.FirstName, s.Year, s.SalaryYear}

        For Each Dim record In query
            Console.WriteLine("Name: {0}, {1} - Year: {2}", record.LastName, record.FirstName, record.Year)
            Console.WriteLine("Salary: {0}", record.SalaryYear)
        Next
    End Sub
#End Region

#Region "Listing 2-4"
    Sub Listing2_4()
        Dim people = New PeopleDataContext()
        Dim tablePeople = people.People
        Dim tableSalaries = people.Salaries

        Dim query = From p In tablePeople, s In tableSalaries _
            Where p.ID = s.ID _
            Select New {p.LastName, p.FirstName, s.Year, s.SalaryYear}

        Console.WriteLine(people.GetQueryText(query))
        Console.WriteLine()

        For Each Dim record In query
            Console.WriteLine("Name: {0}, {1} - Year: {2}", record.LastName, record.FirstName, record.Year)
            Console.WriteLine("Salary: {0}", record.SalaryYear)
        Next

        Dim person As New Person()
        Person.IDRole = 1
        Person.FirstName = "From"
        Person.LastName = "Code"

        people.People.Add(Person)

        Console.WriteLine()
        Console.WriteLine(people.GetChangeText())

    End Sub
#End Region

#Region "Listing 2-5"
    Sub Listing2_5()
        Dim people = New PeopleDataContext()

        Dim person As New Person()
        Person.IDRole = 1
        Person.FirstName = "From"
        Person.LastName = "Code"
        people.People.Add(Person)

        people.SubmitChanges()

        Dim query = From p In people.People _
            Select p

        For Each Dim record In query
            Console.WriteLine("Name: {0}, {1}", record.LastName, record.FirstName)
        Next
    End Sub
#End Region

#Region "Listing 2-7"
    Sub Listing2_7()
        Dim people = New PeopleDataContext()

        Dim person As New Person()
        person.ID = 5

        people.People.Remove(person)

        Console.WriteLine(people.GetChangeText())

        people.SubmitChanges()
    End Sub
#End Region

#Region "Listing 2-10"
    Sub Listing2_10()
        Dim people = New PeopleDataContext()

        people.Log = Console.Out

        Dim query = From p In people.People _
            Where p.ID = 1 _
            Select p

        For Each Dim row In query
            Console.WriteLine( _
                "Full Name: {0} {1} Role: {2}", _
                row.FirstName, _
                row.LastName, _
               row.Role.RoleDescription)

        Next
    End Sub
#End Region

#Region "Listing 2-16"
    Sub Listing2_16()
        Dim people As New PeopleDataContext()
        people.Log = Console.Out

        Dim r As New Role()
        r.RoleDescription = "Integration with old ADO.NET apps"
        people.Roles.Add(r)

        people.Connection.Open()
        people.LocalTransaction = people.Connection.BeginTransaction()

        Try
            people.SubmitChanges()
            people.LocalTransaction.Commit()
            people.AcceptChanges()
        Catch ex As Exception
            people.LocalTransaction.Rollback()
            people.RejectChanges()
            Throw ex
        Finally
            If people.Connection.State = System.Data.ConnectionState.Open Then
                people.Connection.Close()
            End If

            people.LocalTransaction = Nothing
        End Try
    End Sub

#End Region

#Region "Listing 2-17"
    Sub Listing2_17()
        Dim people As New PeopleDataContext()
        people.Log = Console.Out

        Dim r As New Role()
        r.RoleDescription = "By SP"
        people.Roles.Add(r)

        people.SubmitChanges()

    End Sub
#End Region

#Region "Listing 2-19"
    Sub Listing2_19()
        Dim people As New PeopleDataContext()
        people.Log = Console.Out

        Dim query = From r In people.Roles _
            Where r.RoleDescription = "By SP" _
            Select r

        For Each Dim r As Role In query
            people.Roles.Remove(r)
        Next

        people.SubmitChanges()

    End Sub
#End Region

#Region "Listing 2-20"
    Sub Listing2_20()
        Dim people As New PeopleDataContext()

        Console.WriteLine("Person count = {0}", people.UspCountPerson())
    End Sub
#End Region

#Region "Listing 2-21"
    Sub Listing2_21()
        Dim people As New PeopleDataContext()

        For Each Dim r As Role In people.UspGetRoleDescription("M%")
            Console.WriteLine("Role: {0} {1}", r.ID.ToString(), _
                        r.RoleDescription)
        Next
    End Sub
#End Region

#Region "Listing 2-22"
    Sub Listing2_22()
        Dim people As New PeopleDataContext()

        Dim results As StoredProcedureMultipleResult = people.UspGetRolesAndPeople()

        Dim query = From p In results.GetResults(Of Person)(), r In results.GetResults(Of Role)() _
            Where p.IDRole = r.ID AndAlso p.ID = 1 _
            Select New {p.FirstName, p.LastName, r.RoleDescription}

        For Each Dim row In query
            Console.WriteLine("Person: {0} {1} - Role: {2}", row.FirstName, _
                    row.LastName, _
                    row.RoleDescription)
        Next

    End Sub
#End Region

#Region "Listing 2-23"
    Sub Listing2_23()
        Dim people As New PeopleDataContext()

        Dim total As Nullable(Of Decimal) = 0
        Dim year As Integer = 2004

        people.UspGetTotalSalaryAmountPerYear(year, total)

        Console.WriteLine(total.ToString())
    End Sub
#End Region

#Region "Listing 2-24"
    Sub Listing2_24()
        Dim people As New PeopleDataContext()

        people.Log = Console.Out

        Dim query = From p In people.People _
            Select New {p.ID, Initials := people.UdfGetInitials(p.ID)}

        For Each Dim row In query
            Console.WriteLine("PersonID: {0} - Initials: {1}", row.ID, row.Initials)
        Next
    End Sub
#End Region

#Region "Listing 2-25"
    Sub Listing2_25()
        Dim people = New PeopleDataContext("Data Source=.;Initial Catalog=PeopleFromCode;Integrated Security=True")

        If people.DatabaseExists() Then
            people.DeleteDatabase()
        End If

        people.CreateDatabase()
    End Sub
#End Region

#Region "Listing 2-26"
    Sub Listing2_26()
        Dim people As New PeopleDataContext()
        people.Log = Console.Out

        Dim query = From r In people.Roles _
            Select r

        For Each Dim role In query
            For Each Dim person In role.People
                Console.WriteLine("Person: {0} {1}", person.FirstName, _
                        person.LastName)
            Next
        Next
    End Sub
#End Region

End Module

#Region "Listing 2-6"
Public Class UpdateExample
    Public Shared Function whereCondition(ByVal p As Person) As Boolean
        Return p.ID = 5
    End Function

    Sub Listing2_6()
        Dim people = New PeopleDataContext()
        Dim predicateDelegate As New Func(Of Person, Boolean)(AddressOf whereCondition)

        Dim person = people.People.Single(predicateDelegate)

        person.FirstName = "Name"
        person.LastName = "Modified"

        Console.WriteLine(people.GetChangeText())

        people.SubmitChanges()

    End Sub
End Class
#End Region

#Region "Listing 2-11"
Public Class AddExample
    Public Shared Function whereCondition(ByVal p As Role) As Boolean
        Return p.ID = 1
    End Function

    Sub Listing2_11()
        Dim people = New PeopleDataContext()
        Dim predicateDelegate As New Func(Of Role, Boolean)(AddressOf whereCondition)

        people.Log = Console.Out

        Dim role = people.Roles.Single(predicateDelegate)

        Dim person As New Person()
        person.FirstName = "From"
        person.LastName = "Relationship"
        role.People.Add(person)

        people.SubmitChanges()

    End Sub
End Class
#End Region

#Region "Listing 2-12"
Public Class DeleteExample
    Public Shared newID As Integer

    Public Shared Function whereCondition(ByVal p As Role) As Boolean
        Return p.ID = newID
    End Function

    Sub Listing2_12()
        Dim people = New PeopleDataContext()
        Dim predicateDelegate As New Func(Of Role, Boolean)(AddressOf whereCondition)

        people.Log = Console.Out

        Dim role As New Role()
        role.RoleDescription = "Administrator"

        Dim person As New Person()
        person.FirstName = "From"
        person.LastName = "Code"

        role.People.Add(person)
        people.Roles.Add(role)

        people.SubmitChanges()

        newID = role.ID

        Dim admin = people.Roles.Single(predicateDelegate)
        people.Roles.Remove(admin)
        people.SubmitChanges()
    End Sub
End Class
#End Region

#Region "Listing 2-13"
Public Class OptimisticConcurrencyExample
    Public Shared Function whereCondition(ByVal p As Person) As Boolean
        Return p.ID = 1
    End Function

    Sub Listing2_13()
        Dim people = New PeopleDataContext()
        Dim predicateDelegate As New Func(Of Person, Boolean)(AddressOf whereCondition)

        Dim person = people.People.Single(predicateDelegate)

        person.FirstName = "Optimistic"
        person.LastName = "Concurrency"

        Console.ReadLine()

        people.SubmitChanges()
    End Sub
End Class
#End Region

#Region "Listing 2-14"
Public Class OptimisticConcurrencyExample2
    Public Shared Function whereCondition(ByVal p As Person) As Boolean
        Return p.ID = 1
    End Function

    Sub Listing2_14()
        Dim people = New PeopleDataContext()
        Dim predicateDelegate As New Func(Of Person, Boolean)(AddressOf whereCondition)

        Dim person = people.People.Single(predicateDelegate)

        person.FirstName = "Optimistic"
        person.LastName = "Concurrency"

        Try
            people.SubmitChanges(ConflictMode.ContinueOnConflict)
        Catch oce As OptimisticConcurrencyException
            oce.Resolve(RefreshMode.KeepChanges)
        End Try
    End Sub
End Class
#End Region

#Region "Listing 2-15"
Public Class TransactionExample
    Public Shared Function whereCondition(ByVal p As Person) As Boolean
        Return p.ID = 1
    End Function

    Sub Listing2_15()
        Dim people = New PeopleDataContext()
        Dim predicateDelegate As New Func(Of Person, Boolean)(AddressOf whereCondition)

        Using t As New TransactionScope()
            Dim person = people.People.Single(predicateDelegate)

            person.FirstName = "Optimistic"
            person.LastName = "Concurrency"

            Console.ReadLine()

            people.SubmitChanges()

            t.Complete()
        End Using
    End Sub
End Class
#End Region

#Region "Listing 2-18"
Public Class UpdateBySPExample
    Public Shared Function whereCondition(ByVal r As Role) As Boolean
        Return r.ID = 1
    End Function

    Sub Listing2_18()
        Dim people = New PeopleDataContext()
        Dim predicateDelegate As New Func(Of Role, Boolean)(AddressOf whereCondition)

        people.Log = Console.Out

        Dim role = people.Roles.Single(predicateDelegate)
        role.RoleDescription = "By Update stored procedure"

        people.SubmitChanges()

    End Sub
End Class
#End Region