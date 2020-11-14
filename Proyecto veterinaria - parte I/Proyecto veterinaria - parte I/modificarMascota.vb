Public Class modificarMascota
    Dim logicaMascota As New logicaMascota

    Public Sub LISTAR()
        Dim mascotas As New List(Of classMascota)
        mascotas = logicaMascota.getMascotas
        Dim array(4) As String

        ListMascotas.Items.Clear()
        For i As Integer = 0 To mascotas.Count - 1
            array(0) = Convert.ToString(mascotas(i).id)
            array(1) = mascotas(i).name
            array(2) = Convert.ToString(mascotas(i).añoNacimiento)
            array(3) = Convert.ToString(mascotas(i).dueño.Ci)

            Dim item As New ListViewItem(array)

            ListMascotas.Items.Add(item)
        Next

    End Sub

    Private Sub ListPersonas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListMascotas.SelectedIndexChanged
        Dim idSelected As Integer
        idSelected = Convert.ToInt32(ListMascotas.FocusedItem.SubItems(0).Text)

        nombreModificar.Enabled = True
        añoModificar.Enabled = True
        ciModificar.Enabled = True

        Try
            Dim mascotaSelected As New classMascota

            mascotaSelected = logicaMascota.getMascota(idSelected)

            idMascota.Text = Convert.ToString(mascotaSelected.id)
            nombreModificar.Text = mascotaSelected.name
            añoModificar.Text = Convert.ToString(mascotaSelected.añoNacimiento)
            ciModificar.Text = Convert.ToString(mascotaSelected.dueño.Ci)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub OnLoad(sender As Object, e As EventArgs) Handles Me.Load
        nombreModificar.Enabled = False
        añoModificar.Enabled = False
        ciModificar.Enabled = False

        LISTAR()
    End Sub

    Private Sub updateMascota_Click(sender As Object, e As EventArgs) Handles updateMascota.Click
        Try
            Dim mascota As New classMascota
            Dim logicaPersona As New LogicaPersona

            Dim persona As New classPersona
            If logicaPersona.checkIfPersonExists(Convert.ToInt32(ciModificar.Text)) Then
                persona = logicaPersona.getPersona(Convert.ToInt32(ciModificar.Text))

                mascota.id = Convert.ToInt32(idMascota.Text)
                mascota.name = nombreModificar.Text
                mascota.añoNacimiento = Convert.ToInt32(añoModificar.Text)
                mascota.dueño = persona

                logicaMascota.updateMascota(mascota)
                LISTAR()
            Else
                MessageBox.Show("Esta CI no esta registrada")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub deleteMascota_Click(sender As Object, e As EventArgs) Handles deleteMascota.Click
        Try
            Dim id As Integer
            id = Convert.ToInt32(idMascota.Text)

            logicaMascota.deleteMascota(id)
            LISTAR()

            MessageBox.Show("Mascota eliminada correctamente")

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class