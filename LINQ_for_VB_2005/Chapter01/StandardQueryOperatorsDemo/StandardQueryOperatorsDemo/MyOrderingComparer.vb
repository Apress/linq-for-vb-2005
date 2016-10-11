Imports System
Imports System.Collections.Generic

Public Class MyOrderingComparer
    Implements IComparer(Of String)

    Public Function Compare(ByVal x As String, ByVal y As String) As Integer Implements System.Collections.Generic.IComparer(Of String).Compare
        x = x.Replace("_", String.Empty)
        y = y.Replace("_", String.Empty)
        Return String.Compare(x, y)

    End Function
End Class


