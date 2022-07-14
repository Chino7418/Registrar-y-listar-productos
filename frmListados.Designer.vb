<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListados))
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.dgvGrilla = New System.Windows.Forms.DataGridView()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.lblFiltroProducto = New System.Windows.Forms.Label()
        Me.cboDato = New System.Windows.Forms.ComboBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnListarVenta = New System.Windows.Forms.Button()
        Me.btnListarProducto = New System.Windows.Forms.Button()
        Me.COLUMNAID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLUMNAFECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLUMNATIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLUMNAMARCA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLUMNACANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvVentas
        '
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COLUMNAID, Me.COLUMNAFECHA, Me.COLUMNATIPO, Me.COLUMNAMARCA, Me.COLUMNACANTIDAD})
        Me.dgvVentas.Location = New System.Drawing.Point(23, 12)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.RowTemplate.Height = 25
        Me.dgvVentas.Size = New System.Drawing.Size(536, 135)
        Me.dgvVentas.TabIndex = 2
        '
        'dgvGrilla
        '
        Me.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.TIPO, Me.MARCA, Me.CANTIDAD, Me.FECHA})
        Me.dgvGrilla.Location = New System.Drawing.Point(23, 12)
        Me.dgvGrilla.Name = "dgvGrilla"
        Me.dgvGrilla.RowTemplate.Height = 25
        Me.dgvGrilla.Size = New System.Drawing.Size(536, 135)
        Me.dgvGrilla.TabIndex = 3
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(428, 269)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(112, 62)
        Me.btnMenu.TabIndex = 4
        Me.btnMenu.Text = "Volver al menú principal"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'lblFiltroProducto
        '
        Me.lblFiltroProducto.AutoSize = True
        Me.lblFiltroProducto.Location = New System.Drawing.Point(49, 173)
        Me.lblFiltroProducto.Name = "lblFiltroProducto"
        Me.lblFiltroProducto.Size = New System.Drawing.Size(107, 15)
        Me.lblFiltroProducto.TabIndex = 5
        Me.lblFiltroProducto.Text = "Filtro por producto"
        '
        'cboDato
        '
        Me.cboDato.FormattingEnabled = True
        Me.cboDato.Location = New System.Drawing.Point(49, 209)
        Me.cboDato.Name = "cboDato"
        Me.cboDato.Size = New System.Drawing.Size(121, 23)
        Me.cboDato.TabIndex = 6
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(428, 173)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(112, 59)
        Me.btnLimpiar.TabIndex = 7
        Me.btnLimpiar.Text = "Limpiar Grilla"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnListarVenta
        '
        Me.btnListarVenta.Location = New System.Drawing.Point(192, 173)
        Me.btnListarVenta.Name = "btnListarVenta"
        Me.btnListarVenta.Size = New System.Drawing.Size(112, 59)
        Me.btnListarVenta.TabIndex = 8
        Me.btnListarVenta.Text = "Listar Venta"
        Me.btnListarVenta.UseVisualStyleBackColor = True
        '
        'btnListarProducto
        '
        Me.btnListarProducto.Location = New System.Drawing.Point(310, 173)
        Me.btnListarProducto.Name = "btnListarProducto"
        Me.btnListarProducto.Size = New System.Drawing.Size(112, 59)
        Me.btnListarProducto.TabIndex = 9
        Me.btnListarProducto.Text = "Listar Producto"
        Me.btnListarProducto.UseVisualStyleBackColor = True
        '
        'COLUMNAID
        '
        Me.COLUMNAID.HeaderText = "ID"
        Me.COLUMNAID.Name = "COLUMNAID"
        '
        'COLUMNAFECHA
        '
        Me.COLUMNAFECHA.HeaderText = "FECHA"
        Me.COLUMNAFECHA.Name = "COLUMNAFECHA"
        '
        'COLUMNATIPO
        '
        Me.COLUMNATIPO.HeaderText = "TIPO"
        Me.COLUMNATIPO.Name = "COLUMNATIPO"
        '
        'COLUMNAMARCA
        '
        Me.COLUMNAMARCA.HeaderText = "MARCA"
        Me.COLUMNAMARCA.Name = "COLUMNAMARCA"
        '
        'COLUMNACANTIDAD
        '
        Me.COLUMNACANTIDAD.HeaderText = "CANTIDAD"
        Me.COLUMNACANTIDAD.Name = "COLUMNACANTIDAD"
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'TIPO
        '
        Me.TIPO.HeaderText = "TIPO"
        Me.TIPO.Name = "TIPO"
        '
        'MARCA
        '
        Me.MARCA.HeaderText = "MARCA"
        Me.MARCA.Name = "MARCA"
        '
        'CANTIDAD
        '
        Me.CANTIDAD.HeaderText = "CANTIDAD"
        Me.CANTIDAD.Name = "CANTIDAD"
        '
        'FECHA
        '
        Me.FECHA.HeaderText = "FECHA"
        Me.FECHA.Name = "FECHA"
        '
        'frmListados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(582, 376)
        Me.Controls.Add(Me.btnListarProducto)
        Me.Controls.Add(Me.btnListarVenta)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.cboDato)
        Me.Controls.Add(Me.lblFiltroProducto)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.dgvGrilla)
        Me.Controls.Add(Me.dgvVentas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listados"
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents dgvGrilla As DataGridView
    Friend WithEvents btnMenu As Button
    Friend WithEvents lblFiltroProducto As Label
    Friend WithEvents cboDato As ComboBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnListarVenta As Button
    Friend WithEvents btnListarProducto As Button
    Friend WithEvents COLUMNAID As DataGridViewTextBoxColumn
    Friend WithEvents COLUMNAFECHA As DataGridViewTextBoxColumn
    Friend WithEvents COLUMNATIPO As DataGridViewTextBoxColumn
    Friend WithEvents COLUMNAMARCA As DataGridViewTextBoxColumn
    Friend WithEvents COLUMNACANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents TIPO As DataGridViewTextBoxColumn
    Friend WithEvents MARCA As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents FECHA As DataGridViewTextBoxColumn
End Class
