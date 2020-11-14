Public Class inicio
    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles altaPersonaMenu.Click
        altaPersona.ShowDialog()
    End Sub

    Private Sub ModificarPersonaMenu_Click(sender As Object, e As EventArgs) Handles ModificarPersonaMenu.Click
        usersList.ShowDialog()
    End Sub

    Private Sub AltaToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        altaMascota.ShowDialog()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        modificarMascota.ShowDialog()
    End Sub
End Class