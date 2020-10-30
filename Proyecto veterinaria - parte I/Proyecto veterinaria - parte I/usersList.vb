Public Class usersList
    Dim logicaPersona As New LogicaPersona

    Public Sub LISTAR()
        Dim users = logicaPersona.getPersonas
        Dim array(3) As String
        ListView1.Items.Clear()
        For i As Integer = 0 To users.Count - 1
            array(0) = Convert.ToString(users(i).Ci)
            array(1) = users(i).Name
            array(2) = users(i).Dir

            Dim item As New ListViewItem(array)

            ListView1.Items.Add(item)
        Next

    End Sub

    Private Sub btnSearchUser_Click(sender As Object, e As EventArgs) Handles btnSearchUser.Click
        LISTAR()
    End Sub

    Private Sub onLoad(sender As Object, e As EventArgs) Handles Me.Load
        LISTAR()
    End Sub
End Class