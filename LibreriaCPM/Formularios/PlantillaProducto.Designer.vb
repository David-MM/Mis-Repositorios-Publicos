<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlantillaProducto
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblISV = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.spinnerPrecio = New System.Windows.Forms.NumericUpDown()
        Me.spinnerISV = New System.Windows.Forms.NumericUpDown()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        CType(Me.spinnerPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spinnerISV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.lblNombre.Location = New System.Drawing.Point(23, 74)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(68, 20)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.lblPrecio.Location = New System.Drawing.Point(23, 107)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(57, 20)
        Me.lblPrecio.TabIndex = 1
        Me.lblPrecio.Text = "Precio"
        '
        'lblISV
        '
        Me.lblISV.AutoSize = True
        Me.lblISV.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.lblISV.Location = New System.Drawing.Point(23, 140)
        Me.lblISV.Name = "lblISV"
        Me.lblISV.Size = New System.Drawing.Size(67, 20)
        Me.lblISV.TabIndex = 2
        Me.lblISV.Text = "ISV (%)"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.lblDescripcion.Location = New System.Drawing.Point(23, 173)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(99, 20)
        Me.lblDescripcion.TabIndex = 3
        Me.lblDescripcion.Text = "Descripcion"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtNombre.Location = New System.Drawing.Point(215, 71)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(202, 27)
        Me.txtNombre.TabIndex = 4
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtDescripcion.Location = New System.Drawing.Point(215, 170)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(202, 27)
        Me.txtDescripcion.TabIndex = 7
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(69, 223)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(134, 57)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(236, 223)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(134, 57)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'spinnerPrecio
        '
        Me.spinnerPrecio.DecimalPlaces = 2
        Me.spinnerPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.spinnerPrecio.Location = New System.Drawing.Point(215, 105)
        Me.spinnerPrecio.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.spinnerPrecio.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spinnerPrecio.Name = "spinnerPrecio"
        Me.spinnerPrecio.Size = New System.Drawing.Size(202, 27)
        Me.spinnerPrecio.TabIndex = 11
        Me.spinnerPrecio.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'spinnerISV
        '
        Me.spinnerISV.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.spinnerISV.Location = New System.Drawing.Point(215, 138)
        Me.spinnerISV.Name = "spinnerISV"
        Me.spinnerISV.Size = New System.Drawing.Size(202, 27)
        Me.spinnerISV.TabIndex = 12
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.lblCodigo.Location = New System.Drawing.Point(23, 41)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(61, 20)
        Me.lblCodigo.TabIndex = 13
        Me.lblCodigo.Text = "Codigo"
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtCodigo.Location = New System.Drawing.Point(215, 38)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(202, 27)
        Me.txtCodigo.TabIndex = 14
        '
        'PlantillaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 298)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.spinnerISV)
        Me.Controls.Add(Me.spinnerPrecio)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblISV)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "PlantillaProducto"
        Me.Text = "PlantillaProducto"
        CType(Me.spinnerPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spinnerISV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombre As Windows.Forms.Label
    Friend WithEvents lblPrecio As Windows.Forms.Label
    Friend WithEvents lblISV As Windows.Forms.Label
    Friend WithEvents lblDescripcion As Windows.Forms.Label
    Public WithEvents btnGuardar As Windows.Forms.Button
    Public WithEvents btnCancelar As Windows.Forms.Button
    Public WithEvents lblCodigo As Windows.Forms.Label
    Public WithEvents txtCodigo As Windows.Forms.TextBox
    Public WithEvents txtNombre As Windows.Forms.TextBox
    Public WithEvents txtDescripcion As Windows.Forms.TextBox
    Public WithEvents spinnerPrecio As Windows.Forms.NumericUpDown
    Public WithEvents spinnerISV As Windows.Forms.NumericUpDown
End Class
