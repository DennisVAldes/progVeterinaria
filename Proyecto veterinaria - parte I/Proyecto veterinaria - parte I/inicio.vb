Public Class inicio

    Private Sub MascotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MascotaToolStripMenuItem.Click
        altaMascota.ShowDialog()
    End Sub

    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles altaPersonaMenu.Click
        altaPersona.ShowDialog()
    End Sub

    Private Sub ModificarPersonaMenu_Click(sender As Object, e As EventArgs) Handles ModificarPersonaMenu.Click
        usersList.ShowDialog()
    End Sub
End Class