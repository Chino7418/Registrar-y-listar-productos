Public Class frmListados

    Private Sub dgvGrilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentas.CellContentClick

    End Sub

    Private Sub frmListados_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub




    Private Sub optListadoventas_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub optProductos_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Close()
        frmPrincipal.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDato.SelectedIndexChanged
        varFila = 0

        dgvVentas.Rows.Clear()

        While varFila <= 4
            If matVentas(varFila, 2) = cboDato.Text Then
                dgvVentas.Rows.Add(matVentas(varFila, 0), matVentas(varFila, 1), matVentas(varFila, 2), matVentas(varFila, 3), matVentas(varFila, 4))
            End If
            varFila = varFila + 1
        End While
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        dgvGrilla.Rows.Clear()
        dgvVentas.Rows.Clear()
        cboDato.Items.Clear()
        cboDato.Text = ""


    End Sub

    Private Sub btnListarProducto_Click(sender As Object, e As EventArgs) Handles btnListarProducto.Click
        varFila = 0
        dgvGrilla.Visible = True
        dgvVentas.Visible = False
        While varFila <= 4

            dgvGrilla.Rows.Add(matProductos(varFila, 0), matProductos(varFila, 1), matProductos(varFila, 2), matProductos(varFila, 3), matProductos(varFila, 4))

            varFila = varFila + 1
        End While
    End Sub

    Private Sub btnListarVenta_Click(sender As Object, e As EventArgs) Handles btnListarVenta.Click
        varFila = 0

        dgvVentas.Visible = True
        dgvGrilla.Visible = False

        While varFila <= 4
            If matVentas(varFila, 2) <> "" Then
                dgvVentas.Rows.Add(matVentas(varFila, 0), matVentas(varFila, 1), matVentas(varFila, 2), matVentas(varFila, 3), matVentas(varFila, 4))

                cboDato.Items.Add(matVentas(varFila, 2))

            End If
            varFila = varFila + 1
        End While
    End Sub
End Class