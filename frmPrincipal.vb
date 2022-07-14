Public Class frmPrincipal
    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        Me.Hide()
        frmCargaDeProductos.Show()
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Me.Hide()
        frmCargaDeVentas.Show()

    End Sub

    Private Sub btnListados_Click(sender As Object, e As EventArgs) Handles btnListados.Click
        Me.Hide()
        frmListados.Show()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub
End Class
