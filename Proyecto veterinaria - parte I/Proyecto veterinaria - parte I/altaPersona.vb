Public Class altaPersona

    Dim nameP As String
    Dim ci As Integer
    Dim address As String
    Dim tell As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nameP = inName.Text
        ci = CInt(inCi.Text)
        address = inAddress.Text
        tell = CInt(inTell.Text)

        output.Text = CStr(ci) + ", " + nameP + ", " + address + ", " + CStr(tell)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
