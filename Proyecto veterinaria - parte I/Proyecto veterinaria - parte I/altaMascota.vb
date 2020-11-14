Public Class altaMascota

    Private Sub submitMascota_Click(sender As Object, e As EventArgs) Handles submitMascota.Click
        Try
            Dim logicaPersona As New LogicaPersona
            Dim persistenciaPersona As New persistenciaPersona
            Dim logicaMascota As New logicaMascota

            Dim mascota As New classMascota
            Dim persona As New classPersona
            Dim ciPersona = CInt(inCi.Text)

            If logicaPersona.checkIfPersonExists(ciPersona) Then
                persona = persistenciaPersona.getUserByCi(ciPersona)

                mascota.name = inName.Text
                mascota.dueño = persona
                mascota.añoNacimiento = Convert.ToInt32(inFecha.Text)

                logicaMascota.altaMascota(mascota)

                MessageBox.Show("Mascota registrada")
                inName.Text = ""
                inFecha.Text = ""
                inCi.Text = ""
            Else
                MessageBox.Show("No hay persona relacionada a la ci ingresada")
                inName.Text = ""
                inFecha.Text = ""
                inCi.Text = ""
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles closeWindow.Click
        Me.Close()
    End Sub
End Class