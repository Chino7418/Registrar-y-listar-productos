<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargaDeProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargaDeProductos))
        Me.btnDatos = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.TabProductos = New System.Windows.Forms.TabControl()
        Me.tabRegistro = New System.Windows.Forms.TabPage()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.nudCantidad = New System.Windows.Forms.NumericUpDown()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.cboTipoDeProducto = New System.Windows.Forms.ComboBox()
        Me.cboMarca = New System.Windows.Forms.ComboBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblTipoDeProducto = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.tabConsulta = New System.Windows.Forms.TabPage()
        Me.btnBorrarGrilla = New System.Windows.Forms.Button()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.dgvGrilla = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabProductos.SuspendLayout()
        Me.tabRegistro.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabConsulta.SuspendLayout()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDatos
        '
        Me.btnDatos.Location = New System.Drawing.Point(410, 220)
        Me.btnDatos.Name = "btnDatos"
        Me.btnDatos.Size = New System.Drawing.Size(112, 62)
        Me.btnDatos.TabIndex = 1
        Me.btnDatos.Text = "Registrar Datos"
        Me.btnDatos.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(292, 220)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(112, 62)
        Me.btnBorrar.TabIndex = 2
        Me.btnBorrar.Text = "Borrar Datos"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(426, 357)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(112, 62)
        Me.btnMenu.TabIndex = 3
        Me.btnMenu.Text = "Volver al menú principal"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'TabProductos
        '
        Me.TabProductos.Controls.Add(Me.tabRegistro)
        Me.TabProductos.Controls.Add(Me.tabConsulta)
        Me.TabProductos.Location = New System.Drawing.Point(12, 35)
        Me.TabProductos.Name = "TabProductos"
        Me.TabProductos.SelectedIndex = 0
        Me.TabProductos.Size = New System.Drawing.Size(552, 316)
        Me.TabProductos.TabIndex = 4
        '
        'tabRegistro
        '
        Me.tabRegistro.BackColor = System.Drawing.SystemColors.Control
        Me.tabRegistro.Controls.Add(Me.pbxLogo)
        Me.tabRegistro.Controls.Add(Me.nudCantidad)
        Me.tabRegistro.Controls.Add(Me.lblCantidad)
        Me.tabRegistro.Controls.Add(Me.btnBorrar)
        Me.tabRegistro.Controls.Add(Me.cboTipoDeProducto)
        Me.tabRegistro.Controls.Add(Me.btnDatos)
        Me.tabRegistro.Controls.Add(Me.cboMarca)
        Me.tabRegistro.Controls.Add(Me.lblMarca)
        Me.tabRegistro.Controls.Add(Me.dtpFecha)
        Me.tabRegistro.Controls.Add(Me.txtID)
        Me.tabRegistro.Controls.Add(Me.lblTipoDeProducto)
        Me.tabRegistro.Controls.Add(Me.lblFecha)
        Me.tabRegistro.Controls.Add(Me.lblID)
        Me.tabRegistro.Location = New System.Drawing.Point(4, 24)
        Me.tabRegistro.Name = "tabRegistro"
        Me.tabRegistro.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRegistro.Size = New System.Drawing.Size(544, 288)
        Me.tabRegistro.TabIndex = 0
        Me.tabRegistro.Text = "Registro de productos"
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = CType(resources.GetObject("pbxLogo.Image"), System.Drawing.Image)
        Me.pbxLogo.Location = New System.Drawing.Point(276, 12)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(246, 176)
        Me.pbxLogo.TabIndex = 22
        Me.pbxLogo.TabStop = False
        '
        'nudCantidad
        '
        Me.nudCantidad.Location = New System.Drawing.Point(147, 146)
        Me.nudCantidad.Name = "nudCantidad"
        Me.nudCantidad.Size = New System.Drawing.Size(48, 23)
        Me.nudCantidad.TabIndex = 18
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(34, 148)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(94, 15)
        Me.lblCantidad.TabIndex = 17
        Me.lblCantidad.Text = "Ingrese cantidad"
        '
        'cboTipoDeProducto
        '
        Me.cboTipoDeProducto.FormattingEnabled = True
        Me.cboTipoDeProducto.Items.AddRange(New Object() {"Mouse", "Teclado", "Monitor", "Micropocesador", "Auricular"})
        Me.cboTipoDeProducto.Location = New System.Drawing.Point(147, 55)
        Me.cboTipoDeProducto.Name = "cboTipoDeProducto"
        Me.cboTipoDeProducto.Size = New System.Drawing.Size(121, 23)
        Me.cboTipoDeProducto.TabIndex = 14
        '
        'cboMarca
        '
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.Items.AddRange(New Object() {"Lenovo", "Asus", "Gigabyte", "HP", "Redragon"})
        Me.cboMarca.Location = New System.Drawing.Point(147, 99)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.Size = New System.Drawing.Size(121, 23)
        Me.cboMarca.TabIndex = 13
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Location = New System.Drawing.Point(35, 108)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(95, 15)
        Me.lblMarca.TabIndex = 12
        Me.lblMarca.Text = "Nombre / Marca"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(147, 198)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(121, 23)
        Me.dtpFecha.TabIndex = 11
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(147, 12)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(121, 23)
        Me.txtID.TabIndex = 9
        '
        'lblTipoDeProducto
        '
        Me.lblTipoDeProducto.AutoSize = True
        Me.lblTipoDeProducto.Location = New System.Drawing.Point(34, 63)
        Me.lblTipoDeProducto.Name = "lblTipoDeProducto"
        Me.lblTipoDeProducto.Size = New System.Drawing.Size(98, 15)
        Me.lblTipoDeProducto.TabIndex = 8
        Me.lblTipoDeProducto.Text = "Tipo de producto"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(35, 198)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(97, 15)
        Me.lblFecha.TabIndex = 7
        Me.lblFecha.Text = "Fecha de registro"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(34, 20)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 15)
        Me.lblID.TabIndex = 6
        Me.lblID.Text = "ID"
        '
        'tabConsulta
        '
        Me.tabConsulta.Controls.Add(Me.btnBorrarGrilla)
        Me.tabConsulta.Controls.Add(Me.btnListar)
        Me.tabConsulta.Controls.Add(Me.dgvGrilla)
        Me.tabConsulta.Location = New System.Drawing.Point(4, 24)
        Me.tabConsulta.Name = "tabConsulta"
        Me.tabConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConsulta.Size = New System.Drawing.Size(544, 288)
        Me.tabConsulta.TabIndex = 1
        Me.tabConsulta.Text = "Consulta "
        Me.tabConsulta.UseVisualStyleBackColor = True
        '
        'btnBorrarGrilla
        '
        Me.btnBorrarGrilla.Location = New System.Drawing.Point(292, 220)
        Me.btnBorrarGrilla.Name = "btnBorrarGrilla"
        Me.btnBorrarGrilla.Size = New System.Drawing.Size(112, 62)
        Me.btnBorrarGrilla.TabIndex = 6
        Me.btnBorrarGrilla.Text = "Borrar grilla"
        Me.btnBorrarGrilla.UseVisualStyleBackColor = True
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(410, 220)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(112, 62)
        Me.btnListar.TabIndex = 5
        Me.btnListar.Text = "Listar "
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'dgvGrilla
        '
        Me.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.FECHA})
        Me.dgvGrilla.Location = New System.Drawing.Point(5, 3)
        Me.dgvGrilla.Name = "dgvGrilla"
        Me.dgvGrilla.RowTemplate.Height = 25
        Me.dgvGrilla.Size = New System.Drawing.Size(536, 135)
        Me.dgvGrilla.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "TIPO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "MARCA"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "CANTIDAD"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'FECHA
        '
        Me.FECHA.HeaderText = "FECHA"
        Me.FECHA.Name = "FECHA"
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo de Producto"
        Me.Tipo.Name = "Tipo"
        '
        'Marca
        '
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'frmCargaDeProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(585, 428)
        Me.Controls.Add(Me.TabProductos)
        Me.Controls.Add(Me.btnMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCargaDeProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga de productos"
        Me.TabProductos.ResumeLayout(False)
        Me.tabRegistro.ResumeLayout(False)
        Me.tabRegistro.PerformLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabConsulta.ResumeLayout(False)
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDatos As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents TabProductos As TabControl
    Friend WithEvents tabRegistro As TabPage
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblTipoDeProducto As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblID As Label
    Friend WithEvents tabConsulta As TabPage
    Friend WithEvents cboTipoDeProducto As ComboBox
    Friend WithEvents cboMarca As ComboBox
    Friend WithEvents lblMarca As Label
    Friend WithEvents nudCantidad As NumericUpDown
    Friend WithEvents lblCantidad As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents dgvGrilla As DataGridView
    Friend WithEvents btnListar As Button
    Friend WithEvents btnBorrarGrilla As Button
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents FECHA As DataGridViewTextBoxColumn
End Class
