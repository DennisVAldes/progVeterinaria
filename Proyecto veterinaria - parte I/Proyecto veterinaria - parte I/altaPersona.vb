Public Class altaPersona

    Dim listaTelefonos As New List(Of Integer)

    Private Sub submitUser_Click(sender As Object, e As EventArgs) Handles submitUser.Click
        Try
            Dim nameP As String
            nameP = inName.Text

            Dim ci As Integer
            ci = inCi.Text

            Dim address As String
            address = inAddress.Text

            Dim persona As New classPersona()
            persona.Ci = ci
            persona.Name = nameP
            persona.Dir = address
            persona.Telefonos = listaTelefonos

            Dim logica = New LogicaPersona
            logica.altaPersona(persona)

            MessageBox.Show("Usuario y telefonos ingresados correctamente!")

            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub closeWindow_Click(sender As Object, e As EventArgs) Handles closeWindow.Click
        Me.Close()
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

    Private Sub inCi_TextChanged(sender As Object, e As EventArgs) Handles inCi.TextChanged
        Try
            Dim logica As New LogicaPersona

            Dim personaExists = logica.checkIfPersonExists(inCi.Text)

            If personaExists Then
                inAddress.Enabled = False
                inTell.Enabled = False
                inName.Enabled = False
                submitUser.Enabled = False
                MessageBox.Show("Ya existe un usuario registrado con esta ci, intente nuevamente")
                inCi.Text = ""
            Else
                inAddress.Enabled = True
                inTell.Enabled = True
                inName.Enabled = True
                submitUser.Enabled = True
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub onLoad(sender As Object, e As EventArgs) Handles Me.Load
        inAddress.Enabled = False
        inTell.Enabled = False
        inName.Enabled = False
        submitUser.Enabled = False
    End Sub
End Class
