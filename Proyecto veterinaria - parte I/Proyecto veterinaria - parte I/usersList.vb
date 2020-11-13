Public Class usersList
    Dim logicaPersona As New LogicaPersona
    Dim listaTelefonos As New List(Of Integer)

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

    Private Sub btnPlusTelefono_Click(sender As Object, e As EventArgs) Handles btnPlusTelefono.Click
        Try
            Dim telefono As Integer
            telefono = inTell.Text

            listTelefonos.Items.Add(telefono)
            listaTelefonos.Add(telefono)

            inTell.Text = ""
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub listTelefonos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listTelefonos.SelectedIndexChanged
        Try
            Dim telefonoEscrito As String
            Dim telefonoEliminado As String

            telefonoEscrito = listTelefonos.SelectedItems(0).SubItems(0).Text
            telefonoEliminado = Convert.ToInt32(telefonoEscrito)

            Dim i As Integer = 0

            While i < listaTelefonos.Count
                If listaTelefonos.Item(i) = telefonoEliminado Then
                    listaTelefonos.Remove(telefonoEliminado)
                    i = listaTelefonos.Count
                End If
                i = i + 1
            End While

            listTelefonos.Clear()
            i = 0

            While listaTelefonos.Count > i
                listTelefonos.Items.Add(listaTelefonos.Item(i))
                i = i + 1
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Dim ciSelected As Integer
        ciSelected = Convert.ToInt32(ListView1.FocusedItem.SubItems(0).Text)
        ciModificar.Enabled = True
        nombreModificar.Enabled = True
        direccionModificar.Enabled = True
        inTell.Enabled = True
        btnPlusTelefono.Enabled = True

        Try
            Dim userSelected As New classPersona

            userSelected = logicaPersona.getPersona(ciSelected)

            ciModificar.Text = userSelected.Ci
            nombreModificar.Text = userSelected.Name
            direccionModificar.Text = userSelected.Dir

            System.Console.WriteLine(userSelected.Telefonos)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub onLoad(sender As Object, e As EventArgs) Handles Me.Load
        ciModificar.Enabled = False
        nombreModificar.Enabled = False
        direccionModificar.Enabled = False
        inTell.Enabled = False
        btnPlusTelefono.Enabled = False

        LISTAR()
    End Sub
End Class