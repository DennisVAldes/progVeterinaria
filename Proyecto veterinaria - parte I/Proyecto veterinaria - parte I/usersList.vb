Public Class usersList
    Dim logicaPersona As New LogicaPersona
    Dim listaTelefonos As New List(Of Integer)

    Public Sub LISTAR()
        Dim users = logicaPersona.getPersonas
        Dim array(3) As String
        ListPersonas.Items.Clear()
        For i As Integer = 0 To users.Count - 1
            array(0) = Convert.ToString(users(i).Ci)
            array(1) = users(i).Name
            array(2) = users(i).Dir

            Dim item As New ListViewItem(array)

            ListPersonas.Items.Add(item)
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
            MessageBox.Show(ex.Message)

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

    Private Sub ListPersonas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListPersonas.SelectedIndexChanged
        Dim ciSelected As Integer
        ciSelected = Convert.ToInt32(ListPersonas.FocusedItem.SubItems(0).Text)

        ciModificar.Enabled = True
        nombreModificar.Enabled = True
        direccionModificar.Enabled = True
        inTell.Enabled = True
        btnPlusTelefono.Enabled = True

        Try
            Dim userSelected As New classPersona
            Dim telefonos As New List(Of Integer)

            userSelected = logicaPersona.getPersona(ciSelected)

            ciModificar.Text = userSelected.Ci
            nombreModificar.Text = userSelected.Name
            direccionModificar.Text = userSelected.Dir
            telefonos = userSelected.Telefonos

            listaTelefonos.Clear()
            listTelefonos.Items.Clear()

            Dim i As Integer = 0

            While i < telefonos.Count
                Dim tel As New Integer
                tel = telefonos(i)

                listaTelefonos.Add(tel)
                listTelefonos.Items.Add(tel)

                i += 1
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub resetTelsList_Click(sender As Object, e As EventArgs) Handles resetTelsList.Click
        listaTelefonos.Clear()
        listTelefonos.Items.Clear()
    End Sub

    Private Sub OnLoad(sender As Object, e As EventArgs) Handles Me.Load
        ciModificar.Enabled = False
        nombreModificar.Enabled = False
        direccionModificar.Enabled = False
        inTell.Enabled = False
        btnPlusTelefono.Enabled = False

        LISTAR()
    End Sub

    Private Sub updatePersona_Click(sender As Object, e As EventArgs) Handles updatePersona.Click
        Try
            Dim persona As New classPersona

            persona.Ci = Convert.ToInt32(ciModificar.Text)
            persona.Name = nombreModificar.Text
            persona.Dir = direccionModificar.Text
            persona.Telefonos = listaTelefonos

            logicaPersona.updatePersona(persona)
            LISTAR()
        Catch ex As Exception
            Throw ex

        End Try
    End Sub

    Private Sub deletePersona_Click(sender As Object, e As EventArgs) Handles deletePersona.Click
        Try
            Dim ci As Integer
            ci = Convert.ToInt32(ciModificar.Text)

            logicaPersona.deletePersona(ci)
            LISTAR()

            MessageBox.Show("Persona eliminada correctamente")

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class