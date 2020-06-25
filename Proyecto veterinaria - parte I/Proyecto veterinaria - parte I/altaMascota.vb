Public Class altaMascota
    Dim ciPersona As String
    Dim nombreMascota As Integer
    Dim fecha As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nombreMascota = inName.Text
        ciPersona = CInt(inCi.Text)
        fecha = CInt(inFecha.Text)

        output.Text = CStr(ciPersona) + ", " + nombreMascota + ", " + CStr(fecha)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class