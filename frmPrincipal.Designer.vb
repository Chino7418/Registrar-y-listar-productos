<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnListados = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnProductos
        '
        Me.btnProductos.Location = New System.Drawing.Point(12, 285)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(130, 70)
        Me.btnProductos.TabIndex = 0
        Me.btnProductos.Text = "Carga de productos"
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'btnVentas
        '
        Me.btnVentas.Location = New System.Drawing.Point(165, 285)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(130, 70)
        Me.btnVentas.TabIndex = 1
        Me.btnVentas.Text = "Carga de ventas"
        Me.btnVentas.UseVisualStyleBackColor = True
        '
        'btnListados
        '
        Me.btnListados.Location = New System.Drawing.Point(312, 285)
        Me.btnListados.Name = "btnListados"
        Me.btnListados.Size = New System.Drawing.Size(130, 70)
        Me.btnListados.TabIndex = 2
        Me.btnListados.Text = "Listados"
        Me.btnListados.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(312, 452)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(130, 70)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir del Sistema"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = CType(resources.GetObject("pbxLogo.Image"), System.Drawing.Image)
        Me.pbxLogo.Location = New System.Drawing.Point(91, 30)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(255, 182)
        Me.pbxLogo.TabIndex = 4
        Me.pbxLogo.TabStop = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(453, 534)
        Me.Controls.Add(Me.pbxLogo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnListados)
        Me.Controls.Add(Me.btnVentas)
        Me.Controls.Add(Me.btnProductos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenido Meroty S.A."
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnProductos As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnListados As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents pbxLogo As PictureBox
End Class
