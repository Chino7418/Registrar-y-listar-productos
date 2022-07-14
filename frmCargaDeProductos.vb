Public Class frmCargaDeProductos


    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDatos_Click(sender As Object, e As EventArgs) Handles btnDatos.Click


        If MessageBox.Show("¿Desea cargar los datos ingresados?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            If varFila <= 4 Then
                matProductos(varFila, 0) = txtID.Text
                matProductos(varFila, 1) = cboTipoDeProducto.Text
                matProductos(varFila, 2) = cboMarca.Text
                matProductos(varFila, 3) = nudCantidad.Value
                matProductos(varFila, 4) = dtpFecha.Value

                varFila = varFila + 1
            Else
                btnDatos.Enabled = False
                MessageBox.Show("Registro completo" & vbCrLf & "No se puede seguir cargando mas datos ", "Aclaración ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If MessageBox.Show("¿Desea ingresar nuevos datos ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            txtID.Text = ""
            cboTipoDeProducto.Text = ""
            cboMarca.Text = ""
            nudCantidad.Value = 0
            dtpFecha.Text = ""
            txtID.Focus()
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Close()
        frmPrincipal.Show()

    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs)


    End Sub
    Private Sub frmCargaDeProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        varFila = 0
        varColumna = 0



    End Sub

    Private Sub Productos_Click(sender As Object, e As EventArgs) Handles tabRegistro.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        varFila = 0

        While varFila <= 4

            dgvGrilla.Rows.Add(matProductos(varFila, 0), matProductos(varFila, 1), matProductos(varFila, 2), matProductos(varFila, 3), matProductos(varFila, 4))

            varFila = varFila + 1
        End While
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBorrarGrilla.Click
        dgvGrilla.Rows.Clear()
    End Sub



    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class