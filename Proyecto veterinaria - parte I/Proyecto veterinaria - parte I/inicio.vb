Public Class inicio
    Private Sub PersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonaToolStripMenuItem.Click
        altaPersona.ShowDialog()
    End Sub

    Private Sub MascotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MascotaToolStripMenuItem.Click
        altaMascota.ShowDialog()
    End Sub
End Class