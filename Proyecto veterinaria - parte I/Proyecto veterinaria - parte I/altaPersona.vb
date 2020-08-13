Public Class altaPersona

    Dim listaTelefonos As New List(Of Integer)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nameP As String
        nameP = inName.Text

        Dim ci As Integer
        ci = CInt(inCi.Text)

        Dim address As String
        address = inAddress.Text

        Dim persona As New classPersona()
        persona.Ci = ci
        persona.Name = nameP
        persona.Dir = address
        persona.Telefonos = listaTelefonos

        Dim logica = New LogicaPersona
        logica.altaPersona(persona)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnPlusTelefono_Click(sender As Object, e As EventArgs) Handles btnPlusTelefono.Click
        Dim telefono As Integer
        telefono = inTell.Text

        listTelefonos.Items.Add(telefono)
        listaTelefonos.Add(telefono)

        inTell.Text = ""
    End Sub
End Class
