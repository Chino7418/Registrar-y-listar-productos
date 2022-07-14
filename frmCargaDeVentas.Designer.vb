<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCargaDeVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargaDeVentas))
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.TabRegistro = New System.Windows.Forms.TabControl()
        Me.tabVentas = New System.Windows.Forms.TabPage()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.cboMarca = New System.Windows.Forms.ComboBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.nudCantidad = New System.Windows.Forms.NumericUpDown()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.cboTipoDeProducto = New System.Windows.Forms.ComboBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblTipoDeProducto = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.tabConsulta = New System.Windows.Forms.TabPage()
        Me.cboDato = New System.Windows.Forms.ComboBox()
        Me.lblTProducto = New System.Windows.Forms.Label()
        Me.dgvGrilla = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnLimpiarGrilla = New System.Windows.Forms.Button()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnFiltro = New System.Windows.Forms.Button()
        Me.TabRegistro.SuspendLayout()
        Me.tabVentas.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabConsulta.SuspendLayout()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(446, 368)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(112, 62)
        Me.btnMenu.TabIndex = 6
        Me.btnMenu.Text = "Volver al menú principal"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'TabRegistro
        '
        Me.TabRegistro.Controls.Add(Me.tabVentas)
        Me.TabRegistro.Controls.Add(Me.tabConsulta)
        Me.TabRegistro.Location = New System.Drawing.Point(12, 35)
        Me.TabRegistro.Name = "TabRegistro"
        Me.TabRegistro.SelectedIndex = 0
        Me.TabRegistro.Size = New System.Drawing.Size(574, 317)
        Me.TabRegistro.TabIndex = 7
        '
        'tabVentas
        '
        Me.tabVentas.BackColor = System.Drawing.Color.Transparent
        Me.tabVentas.Controls.Add(Me.pbxLogo)
        Me.tabVentas.Controls.Add(Me.cboMarca)
        Me.tabVentas.Controls.Add(Me.lblMarca)
        Me.tabVentas.Controls.Add(Me.btnRegistrar)
        Me.tabVentas.Controls.Add(Me.nudCantidad)
        Me.tabVentas.Controls.Add(Me.lblCantidad)
        Me.tabVentas.Controls.Add(Me.cboTipoDeProducto)
        Me.tabVentas.Controls.Add(Me.dtpFecha)
        Me.tabVentas.Controls.Add(Me.txtID)
        Me.tabVentas.Controls.Add(Me.lblTipoDeProducto)
        Me.tabVentas.Controls.Add(Me.lblFecha)
        Me.tabVentas.Controls.Add(Me.lblID)
        Me.tabVentas.Location = New System.Drawing.Point(4, 24)
        Me.tabVentas.Name = "tabVentas"
        Me.tabVentas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabVentas.Size = New System.Drawing.Size(566, 289)
        Me.tabVentas.TabIndex = 0
        Me.tabVentas.Text = "Registro de ventas"
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = CType(resources.GetObject("pbxLogo.Image"), System.Drawing.Image)
        Me.pbxLogo.Location = New System.Drawing.Point(296, 23)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(246, 176)
        Me.pbxLogo.TabIndex = 21
        Me.pbxLogo.TabStop = False
        '
        'cboMarca
        '
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.Location = New System.Drawing.Point(147, 138)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.Size = New System.Drawing.Size(121, 23)
        Me.cboMarca.TabIndex = 20
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Location = New System.Drawing.Point(38, 146)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(95, 15)
        Me.lblMarca.TabIndex = 19
        Me.lblMarca.Text = "Nombre / Marca"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistrar.Location = New System.Drawing.Point(430, 220)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(112, 62)
        Me.btnRegistrar.TabIndex = 8
        Me.btnRegistrar.Text = "Registrar venta"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'nudCantidad
        '
        Me.nudCantidad.Location = New System.Drawing.Point(147, 176)
        Me.nudCantidad.Name = "nudCantidad"
        Me.nudCantidad.Size = New System.Drawing.Size(48, 23)
        Me.nudCantidad.TabIndex = 18
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(38, 184)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(94, 15)
        Me.lblCantidad.TabIndex = 17
        Me.lblCantidad.Text = "Ingrese cantidad"
        '
        'cboTipoDeProducto
        '
        Me.cboTipoDeProducto.FormattingEnabled = True
        Me.cboTipoDeProducto.Location = New System.Drawing.Point(147, 99)
        Me.cboTipoDeProducto.Name = "cboTipoDeProducto"
        Me.cboTipoDeProducto.Size = New System.Drawing.Size(121, 23)
        Me.cboTipoDeProducto.TabIndex = 14
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(147, 54)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(121, 23)
        Me.dtpFecha.TabIndex = 11
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(147, 15)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(121, 23)
        Me.txtID.TabIndex = 9
        '
        'lblTipoDeProducto
        '
        Me.lblTipoDeProducto.AutoSize = True
        Me.lblTipoDeProducto.Location = New System.Drawing.Point(38, 107)
        Me.lblTipoDeProducto.Name = "lblTipoDeProducto"
        Me.lblTipoDeProducto.Size = New System.Drawing.Size(98, 15)
        Me.lblTipoDeProducto.TabIndex = 8
        Me.lblTipoDeProducto.Text = "Tipo de producto"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(38, 62)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(86, 15)
        Me.lblFecha.TabIndex = 7
        Me.lblFecha.Text = "Fecha de venta"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(38, 23)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 15)
        Me.lblID.TabIndex = 6
        Me.lblID.Text = "ID"
        '
        'tabConsulta
        '
        Me.tabConsulta.Controls.Add(Me.cboDato)
        Me.tabConsulta.Controls.Add(Me.lblTProducto)
        Me.tabConsulta.Controls.Add(Me.dgvGrilla)
        Me.tabConsulta.Controls.Add(Me.btnLimpiarGrilla)
        Me.tabConsulta.Controls.Add(Me.btnListar)
        Me.tabConsulta.Controls.Add(Me.btnFiltro)
        Me.tabConsulta.Location = New System.Drawing.Point(4, 24)
        Me.tabConsulta.Name = "tabConsulta"
        Me.tabConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConsulta.Size = New System.Drawing.Size(566, 289)
        Me.tabConsulta.TabIndex = 1
        Me.tabConsulta.Text = "Consulta "
        Me.tabConsulta.UseVisualStyleBackColor = True
        '
        'cboDato
        '
        Me.cboDato.FormattingEnabled = True
        Me.cboDato.Location = New System.Drawing.Point(44, 249)
        Me.cboDato.Name = "cboDato"
        Me.cboDato.Size = New System.Drawing.Size(121, 23)
        Me.cboDato.TabIndex = 9
        '
        'lblTProducto
        '
        Me.lblTProducto.AutoSize = True
        Me.lblTProducto.Location = New System.Drawing.Point(55, 231)
        Me.lblTProducto.Name = "lblTProducto"
        Me.lblTProducto.Size = New System.Drawing.Size(110, 15)
        Me.lblTProducto.TabIndex = 10
        Me.lblTProducto.Text = "Filtro por producto "
        '
        'dgvGrilla
        '
        Me.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.FECHA, Me.TIPO, Me.MARCA, Me.CANTIDAD})
        Me.dgvGrilla.Location = New System.Drawing.Point(3, 6)
        Me.dgvGrilla.Name = "dgvGrilla"
        Me.dgvGrilla.RowTemplate.Height = 25
        Me.dgvGrilla.Size = New System.Drawing.Size(536, 135)
        Me.dgvGrilla.TabIndex = 1
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'FECHA
        '
        Me.FECHA.HeaderText = "FECHA"
        Me.FECHA.Name = "FECHA"
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
        'btnLimpiarGrilla
        '
        Me.btnLimpiarGrilla.Location = New System.Drawing.Point(301, 220)
        Me.btnLimpiarGrilla.Name = "btnLimpiarGrilla"
        Me.btnLimpiarGrilla.Size = New System.Drawing.Size(112, 62)
        Me.btnLimpiarGrilla.TabIndex = 8
        Me.btnLimpiarGrilla.Text = "Limpiar grilla"
        Me.btnLimpiarGrilla.UseVisualStyleBackColor = True
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(419, 220)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(112, 62)
        Me.btnListar.TabIndex = 5
        Me.btnListar.Text = "Listar "
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'btnFiltro
        '
        Me.btnFiltro.Location = New System.Drawing.Point(183, 220)
        Me.btnFiltro.Name = "btnFiltro"
        Me.btnFiltro.Size = New System.Drawing.Size(112, 62)
        Me.btnFiltro.TabIndex = 7
        Me.btnFiltro.Text = "Filtro de ventas mayor a 10"
        Me.btnFiltro.UseVisualStyleBackColor = True
        '
        'frmCargaDeVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(609, 442)
        Me.Controls.Add(Me.TabRegistro)
        Me.Controls.Add(Me.btnMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCargaDeVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga de ventas"
        Me.TabRegistro.ResumeLayout(False)
        Me.tabVentas.ResumeLayout(False)
        Me.tabVentas.PerformLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabConsulta.ResumeLayout(False)
        Me.tabConsulta.PerformLayout()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMenu As Button
    Friend WithEvents TabRegistro As TabControl
    Friend WithEvents tabVentas As TabPage
    Friend WithEvents nudCantidad As NumericUpDown
    Friend WithEvents lblCantidad As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblID As Label
    Friend WithEvents tabConsulta As TabPage
    Friend WithEvents btnListar As Button
    Friend WithEvents dgvGrilla As DataGridView
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents cboTipoDeProducto As ComboBox
    Friend WithEvents lblTipoDeProducto As Label
    Friend WithEvents cboMarca As ComboBox
    Friend WithEvents lblMarca As Label
    Friend WithEvents btnFiltro As Button
    Friend WithEvents btnLimpiarGrilla As Button
    Friend WithEvents btnFiltroComponente As Button
    Friend WithEvents cboDato As ComboBox
    Friend WithEvents lblTProducto As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents FECHA As DataGridViewTextBoxColumn
    Friend WithEvents TIPO As DataGridViewTextBoxColumn
    Friend WithEvents MARCA As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents pbxLogo As PictureBox
End Class
