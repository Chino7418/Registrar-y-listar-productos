Public Class frmCargaDeVentas
    Dim varFilaVenta As Integer = 0

    Private Sub frmCargaDeVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        varColumna = 0
        varFila = 0

        While varFila <= 4

            If matProductos(varFila, 0) <> "" Then
                cboTipoDeProducto.Items.Add(matProductos(varFila, 1))
                cboMarca.Items.Add(matProductos(varFila, 2))
            End If

            varFila = varFila + 1
        End While
    End Sub

    Private Sub tabVentas_Click(sender As Object, e As EventArgs) Handles tabVentas.Click

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click


        If MessageBox.Show("¿Desea registrar la venta ?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            MessageBox.Show("Venta registrada", "Confirmación")
            If varFilaVenta <= 4 Then

                matVentas(varFilaVenta, 0) = txtID.Text
                matVentas(varFilaVenta, 1) = dtpFecha.Value
                matVentas(varFilaVenta, 2) = cboTipoDeProducto.Text
                matVentas(varFilaVenta, 3) = cboMarca.Text
                matVentas(varFilaVenta, 4) = nudCantidad.Value

                varFilaVenta = varFilaVenta + 1
            Else
                btnRegistrar.Enabled = False
                MessageBox.Show("Registro completo" & vbCrLf & "No se puede seguir cargando mas datos ", "Aclaración ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If


    End Sub
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        varFila = 0



        While varFila <= 4
            If matVentas(varFila, 2) <> "" Then
                dgvGrilla.Rows.Add(matVentas(varFila, 0), matVentas(varFila, 1), matVentas(varFila, 2), matVentas(varFila, 3), matVentas(varFila, 4))

                cboDato.Items.Add(matVentas(varFila, 2))

            End If
            varFila = varFila + 1
        End While
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Close()
        frmPrincipal.Show()
    End Sub

    Private Sub BtnFiltro_Click(sender As Object, e As EventArgs) Handles btnFiltro.Click
        varFilaVenta = 0

        While varFilaVenta <= 4
            If matVentas(varFilaVenta, 4) > 10 Then
                dgvGrilla.Rows.Add(matVentas(varFilaVenta, 0), matVentas(varFilaVenta, 1), matVentas(varFilaVenta, 2), matVentas(varFilaVenta, 3), matVentas(varFilaVenta, 4))

            End If
            varFilaVenta = varFilaVenta + 1
        End While
    End Sub

    Private Sub btnLimpiarGrilla_Click(sender As Object, e As EventArgs) Handles btnLimpiarGrilla.Click
        dgvGrilla.Rows.Clear()
        cboDato.Items.Clear()
        cboDato.Text = ""
    End Sub

    Private Sub btnFiltroComponente_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboDato_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDato.SelectedIndexChanged
        varFilaVenta = 0

        dgvGrilla.Rows.Clear()

        While varFilaVenta <= 4
            If matVentas(varFilaVenta, 2) = cboDato.Text Then
                dgvGrilla.Rows.Add(matVentas(varFilaVenta, 0), matVentas(varFilaVenta, 1), matVentas(varFilaVenta, 2), matVentas(varFilaVenta, 3), matVentas(varFilaVenta, 4))
            End If
            varFilaVenta = varFilaVenta + 1
        End While
    End Sub
    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class