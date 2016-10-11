Public Class Form1
    Private db As PeopleDataContext

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        db = New PeopleDataContext

        Dim tableRoles = db.Roles
        Dim query = From r In tableRoles _
            Select r

        dgRole.DataSource = query.ToList()
        dgPerson.DataSource = dgRole.DataSource
        dgPerson.DataMember = "Persons"

    End Sub
End Class
