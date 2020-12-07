<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Plantilla_Facturacion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRTN = New System.Windows.Forms.TextBox()
        Me.cmbCli = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grpProducto = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.spnPrecio = New System.Windows.Forms.NumericUpDown()
        Me.spnCantidad = New System.Windows.Forms.NumericUpDown()
        Me.cmbProducto = New System.Windows.Forms.ComboBox()
        Me.cmbCodBarra = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtISV = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnFacturar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.lblIDFact = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Datos = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Detalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbPago = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpProducto.SuspendLayout()
        CType(Me.spnPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(177, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 69)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Facturación"
        '
        'lblFecha
        '
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(633, 33)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(196, 20)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(444, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "RTN"
        '
        'txtRTN
        '
        Me.txtRTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRTN.Location = New System.Drawing.Point(502, 98)
        Me.txtRTN.Name = "txtRTN"
        Me.txtRTN.ReadOnly = True
        Me.txtRTN.Size = New System.Drawing.Size(318, 30)
        Me.txtRTN.TabIndex = 5
        '
        'cmbCli
        '
        Me.cmbCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCli.FormattingEnabled = True
        Me.cmbCli.Location = New System.Drawing.Point(98, 95)
        Me.cmbCli.Name = "cmbCli"
        Me.cmbCli.Size = New System.Drawing.Size(327, 33)
        Me.cmbCli.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Código"
        '
        'grpProducto
        '
        Me.grpProducto.Controls.Add(Me.btnAgregar)
        Me.grpProducto.Controls.Add(Me.spnPrecio)
        Me.grpProducto.Controls.Add(Me.spnCantidad)
        Me.grpProducto.Controls.Add(Me.cmbProducto)
        Me.grpProducto.Controls.Add(Me.cmbCodBarra)
        Me.grpProducto.Controls.Add(Me.Label8)
        Me.grpProducto.Controls.Add(Me.Label7)
        Me.grpProducto.Controls.Add(Me.Label6)
        Me.grpProducto.Controls.Add(Me.Label5)
        Me.grpProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProducto.Location = New System.Drawing.Point(24, 144)
        Me.grpProducto.Name = "grpProducto"
        Me.grpProducto.Size = New System.Drawing.Size(796, 87)
        Me.grpProducto.TabIndex = 8
        Me.grpProducto.TabStop = False
        Me.grpProducto.Text = "Producto"
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(727, 41)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(45, 36)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "+"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'spnPrecio
        '
        Me.spnPrecio.DecimalPlaces = 2
        Me.spnPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spnPrecio.Location = New System.Drawing.Point(533, 46)
        Me.spnPrecio.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.spnPrecio.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spnPrecio.Name = "spnPrecio"
        Me.spnPrecio.Size = New System.Drawing.Size(172, 27)
        Me.spnPrecio.TabIndex = 4
        Me.spnPrecio.Tag = "Producto"
        Me.spnPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.spnPrecio.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'spnCantidad
        '
        Me.spnCantidad.DecimalPlaces = 2
        Me.spnCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spnCantidad.Location = New System.Drawing.Point(407, 47)
        Me.spnCantidad.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.spnCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spnCantidad.Name = "spnCantidad"
        Me.spnCantidad.Size = New System.Drawing.Size(120, 27)
        Me.spnCantidad.TabIndex = 3
        Me.spnCantidad.Tag = "Producto"
        Me.spnCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.spnCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cmbProducto
        '
        Me.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(184, 46)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(217, 28)
        Me.cmbProducto.TabIndex = 2
        Me.cmbProducto.Tag = "Producto"
        '
        'cmbCodBarra
        '
        Me.cmbCodBarra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCodBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCodBarra.FormattingEnabled = True
        Me.cmbCodBarra.Location = New System.Drawing.Point(6, 46)
        Me.cmbCodBarra.Name = "cmbCodBarra"
        Me.cmbCodBarra.Size = New System.Drawing.Size(172, 28)
        Me.cmbCodBarra.TabIndex = 1
        Me.cmbCodBarra.Tag = "Producto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(576, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Precio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(421, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Cantidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(237, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Producto"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(498, 668)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Subtotal: L."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(498, 701)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 20)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "ISV: L."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(498, 734)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(153, 20)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Descuento: L."
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(498, 767)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(153, 20)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Total: L."
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.Location = New System.Drawing.Point(662, 661)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(158, 27)
        Me.txtSubtotal.TabIndex = 15
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtISV
        '
        Me.txtISV.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtISV.Location = New System.Drawing.Point(662, 694)
        Me.txtISV.Name = "txtISV"
        Me.txtISV.ReadOnly = True
        Me.txtISV.Size = New System.Drawing.Size(158, 27)
        Me.txtISV.TabIndex = 16
        Me.txtISV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(662, 760)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(158, 27)
        Me.txtTotal.TabIndex = 18
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDesc
        '
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(662, 727)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.ReadOnly = True
        Me.txtDesc.Size = New System.Drawing.Size(158, 27)
        Me.txtDesc.TabIndex = 17
        Me.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 76)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'btnFacturar
        '
        Me.btnFacturar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacturar.Location = New System.Drawing.Point(24, 745)
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Size = New System.Drawing.Size(123, 31)
        Me.btnFacturar.TabIndex = 21
        Me.btnFacturar.Text = "Facturar"
        Me.btnFacturar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(24, 708)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(123, 31)
        Me.btnLimpiar.TabIndex = 22
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'lblIDFact
        '
        Me.lblIDFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDFact.Location = New System.Drawing.Point(633, 13)
        Me.lblIDFact.Name = "lblIDFact"
        Me.lblIDFact.Size = New System.Drawing.Size(196, 20)
        Me.lblIDFact.TabIndex = 24
        Me.lblIDFact.Text = "Fecha"
        Me.lblIDFact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btncancelar
        '
        Me.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Location = New System.Drawing.Point(153, 708)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(123, 31)
        Me.btncancelar.TabIndex = 25
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(153, 745)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 31)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Datos
        '
        Me.Datos.AllowUserToAddRows = False
        Me.Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Producto, Me.Detalle, Me.Cantidad, Me.Precio, Me.ISV, Me.Total})
        Me.Datos.Location = New System.Drawing.Point(24, 238)
        Me.Datos.Name = "Datos"
        Me.Datos.ReadOnly = True
        Me.Datos.RowHeadersWidth = 51
        Me.Datos.RowTemplate.Height = 24
        Me.Datos.Size = New System.Drawing.Size(796, 417)
        Me.Datos.TabIndex = 27
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.MinimumWidth = 6
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.MinimumWidth = 6
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        '
        'Detalle
        '
        Me.Detalle.HeaderText = "Detalle"
        Me.Detalle.MinimumWidth = 6
        Me.Detalle.Name = "Detalle"
        Me.Detalle.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.MinimumWidth = 6
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'ISV
        '
        Me.ISV.HeaderText = "ISV"
        Me.ISV.MinimumWidth = 6
        Me.ISV.Name = "ISV"
        Me.ISV.ReadOnly = True
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 6
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'cmbPago
        '
        Me.cmbPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPago.FormattingEnabled = True
        Me.cmbPago.Items.AddRange(New Object() {"Credito", "Contado"})
        Me.cmbPago.Location = New System.Drawing.Point(303, 745)
        Me.cmbPago.Name = "cmbPago"
        Me.cmbPago.Size = New System.Drawing.Size(217, 28)
        Me.cmbPago.TabIndex = 11
        Me.cmbPago.Tag = "Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(356, 722)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Tipo de pago"
        '
        'Plantilla_Facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btncancelar
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(841, 793)
        Me.Controls.Add(Me.cmbPago)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Datos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.lblIDFact)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnFacturar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtISV)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.grpProducto)
        Me.Controls.Add(Me.cmbCli)
        Me.Controls.Add(Me.txtRTN)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Plantilla_Facturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas"
        Me.grpProducto.ResumeLayout(False)
        Me.grpProducto.PerformLayout()
        CType(Me.spnPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents lblFecha As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents txtRTN As Windows.Forms.TextBox
    Friend WithEvents cmbCli As Windows.Forms.ComboBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents grpProducto As Windows.Forms.GroupBox
    Friend WithEvents spnPrecio As Windows.Forms.NumericUpDown
    Friend WithEvents spnCantidad As Windows.Forms.NumericUpDown
    Friend WithEvents cmbProducto As Windows.Forms.ComboBox
    Friend WithEvents cmbCodBarra As Windows.Forms.ComboBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents btnAgregar As Windows.Forms.Button
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents txtSubtotal As Windows.Forms.TextBox
    Friend WithEvents txtISV As Windows.Forms.TextBox
    Friend WithEvents txtTotal As Windows.Forms.TextBox
    Friend WithEvents txtDesc As Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents btnFacturar As Windows.Forms.Button
    Friend WithEvents btnLimpiar As Windows.Forms.Button
    Friend WithEvents lblIDFact As Windows.Forms.Label
    Friend WithEvents btncancelar As Windows.Forms.Button
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents Datos As Windows.Forms.DataGridView
    Friend WithEvents Codigo As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Producto As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Detalle As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ISV As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbPago As Windows.Forms.ComboBox
    Friend WithEvents Label2 As Windows.Forms.Label
End Class
