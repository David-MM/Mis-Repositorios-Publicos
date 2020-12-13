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
        Me.Precio = New System.Windows.Forms.Label()
        Me.ISV = New System.Windows.Forms.Label()
        Me.txt_Precio = New System.Windows.Forms.TextBox()
        Me.txt_Isv = New System.Windows.Forms.TextBox()
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
        Me.btnGuardar.Location = New System.Drawing.Point(79, 225)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(134, 55)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(255, 225)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(134, 55)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'spinnerPrecio
        '
        Me.spinnerPrecio.DecimalPlaces = 2
        Me.spinnerPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.spinnerPrecio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.spinnerPrecio.Location = New System.Drawing.Point(215, 105)
        Me.spinnerPrecio.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.spinnerPrecio.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spinnerPrecio.Name = "spinnerPrecio"
        Me.spinnerPrecio.Size = New System.Drawing.Size(202, 27)
        Me.spinnerPrecio.TabIndex = 11
        Me.spinnerPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.spinnerPrecio.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'spinnerISV
        '
        Me.spinnerISV.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.spinnerISV.Location = New System.Drawing.Point(215, 137)
        Me.spinnerISV.Name = "spinnerISV"
        Me.spinnerISV.Size = New System.Drawing.Size(202, 27)
        Me.spinnerISV.TabIndex = 12
        Me.spinnerISV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'Precio
        '
        Me.Precio.AutoSize = True
        Me.Precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Precio.Location = New System.Drawing.Point(225, 107)
        Me.Precio.Name = "Precio"
        Me.Precio.Size = New System.Drawing.Size(0, 20)
        Me.Precio.TabIndex = 16
        Me.Precio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ISV
        '
        Me.ISV.AutoSize = True
        Me.ISV.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.ISV.Location = New System.Drawing.Point(122, 19)
        Me.ISV.Name = "ISV"
        Me.ISV.Size = New System.Drawing.Size(0, 20)
        Me.ISV.TabIndex = 17
        Me.ISV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Precio
        '
        Me.txt_Precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Precio.Location = New System.Drawing.Point(216, 104)
        Me.txt_Precio.Name = "txt_Precio"
        Me.txt_Precio.Size = New System.Drawing.Size(200, 27)
        Me.txt_Precio.TabIndex = 18
        Me.txt_Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Isv
        '
        Me.txt_Isv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Isv.Location = New System.Drawing.Point(216, 136)
        Me.txt_Isv.Name = "txt_Isv"
        Me.txt_Isv.Size = New System.Drawing.Size(200, 27)
        Me.txt_Isv.TabIndex = 19
        Me.txt_Isv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PlantillaProducto
        '
        Me.AcceptButton = Me.btnGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(469, 304)
        Me.Controls.Add(Me.txt_Isv)
        Me.Controls.Add(Me.txt_Precio)
        Me.Controls.Add(Me.ISV)
        Me.Controls.Add(Me.Precio)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Public WithEvents Precio As Windows.Forms.Label
    Public WithEvents ISV As Windows.Forms.Label
    Public WithEvents txt_Precio As Windows.Forms.TextBox
    Public WithEvents txt_Isv As Windows.Forms.TextBox
End Class
