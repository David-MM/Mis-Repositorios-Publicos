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
        Me.lblFecha1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRTN1 = New System.Windows.Forms.TextBox()
        Me.cmbCli1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grpProducto = New System.Windows.Forms.GroupBox()
        Me.btnAgregar1 = New System.Windows.Forms.Button()
        Me.spnPrecio1 = New System.Windows.Forms.NumericUpDown()
        Me.spnCantidad1 = New System.Windows.Forms.NumericUpDown()
        Me.cmbProducto1 = New System.Windows.Forms.ComboBox()
        Me.cmbCodBarra1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSubtotal1 = New System.Windows.Forms.TextBox()
        Me.txtISV1 = New System.Windows.Forms.TextBox()
        Me.txtTotal1 = New System.Windows.Forms.TextBox()
        Me.txtDesc1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnFacturar1 = New System.Windows.Forms.Button()
        Me.btnLimpiar1 = New System.Windows.Forms.Button()
        Me.lblIDFact1 = New System.Windows.Forms.Label()
        Me.btncancelar1 = New System.Windows.Forms.Button()
        Me.Btn_Imprimir = New System.Windows.Forms.Button()
        Me.Datos = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Detalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbPago1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpProducto.SuspendLayout()
        CType(Me.spnPrecio1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnCantidad1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Facturación"
        '
        'lblFecha1
        '
        Me.lblFecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha1.Location = New System.Drawing.Point(475, 27)
        Me.lblFecha1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFecha1.Name = "lblFecha1"
        Me.lblFecha1.Size = New System.Drawing.Size(147, 16)
        Me.lblFecha1.TabIndex = 1
        Me.lblFecha1.Text = "Fecha"
        Me.lblFecha1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 82)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(333, 82)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "RTN"
        '
        'txtRTN1
        '
        Me.txtRTN1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRTN1.Location = New System.Drawing.Point(376, 80)
        Me.txtRTN1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRTN1.Name = "txtRTN1"
        Me.txtRTN1.ReadOnly = True
        Me.txtRTN1.Size = New System.Drawing.Size(240, 26)
        Me.txtRTN1.TabIndex = 5
        '
        'cmbCli1
        '
        Me.cmbCli1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCli1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCli1.FormattingEnabled = True
        Me.cmbCli1.Location = New System.Drawing.Point(74, 77)
        Me.cmbCli1.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCli1.Name = "cmbCli1"
        Me.cmbCli1.Size = New System.Drawing.Size(246, 28)
        Me.cmbCli1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 19)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Código"
        '
        'grpProducto
        '
        Me.grpProducto.Controls.Add(Me.btnAgregar1)
        Me.grpProducto.Controls.Add(Me.spnPrecio1)
        Me.grpProducto.Controls.Add(Me.spnCantidad1)
        Me.grpProducto.Controls.Add(Me.cmbProducto1)
        Me.grpProducto.Controls.Add(Me.cmbCodBarra1)
        Me.grpProducto.Controls.Add(Me.Label8)
        Me.grpProducto.Controls.Add(Me.Label7)
        Me.grpProducto.Controls.Add(Me.Label6)
        Me.grpProducto.Controls.Add(Me.Label5)
        Me.grpProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProducto.Location = New System.Drawing.Point(18, 117)
        Me.grpProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.grpProducto.Name = "grpProducto"
        Me.grpProducto.Padding = New System.Windows.Forms.Padding(2)
        Me.grpProducto.Size = New System.Drawing.Size(597, 71)
        Me.grpProducto.TabIndex = 8
        Me.grpProducto.TabStop = False
        Me.grpProducto.Text = "Producto"
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar1.Location = New System.Drawing.Point(545, 33)
        Me.btnAgregar1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(34, 29)
        Me.btnAgregar1.TabIndex = 5
        Me.btnAgregar1.Text = "+"
        Me.btnAgregar1.UseVisualStyleBackColor = True
        '
        'spnPrecio1
        '
        Me.spnPrecio1.DecimalPlaces = 2
        Me.spnPrecio1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spnPrecio1.Location = New System.Drawing.Point(400, 37)
        Me.spnPrecio1.Margin = New System.Windows.Forms.Padding(2)
        Me.spnPrecio1.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.spnPrecio1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spnPrecio1.Name = "spnPrecio1"
        Me.spnPrecio1.Size = New System.Drawing.Size(129, 23)
        Me.spnPrecio1.TabIndex = 4
        Me.spnPrecio1.Tag = "Producto"
        Me.spnPrecio1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.spnPrecio1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'spnCantidad1
        '
        Me.spnCantidad1.DecimalPlaces = 2
        Me.spnCantidad1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spnCantidad1.Location = New System.Drawing.Point(305, 38)
        Me.spnCantidad1.Margin = New System.Windows.Forms.Padding(2)
        Me.spnCantidad1.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.spnCantidad1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spnCantidad1.Name = "spnCantidad1"
        Me.spnCantidad1.Size = New System.Drawing.Size(90, 23)
        Me.spnCantidad1.TabIndex = 3
        Me.spnCantidad1.Tag = "Producto"
        Me.spnCantidad1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.spnCantidad1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cmbProducto1
        '
        Me.cmbProducto1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProducto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProducto1.FormattingEnabled = True
        Me.cmbProducto1.Location = New System.Drawing.Point(138, 37)
        Me.cmbProducto1.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbProducto1.Name = "cmbProducto1"
        Me.cmbProducto1.Size = New System.Drawing.Size(164, 25)
        Me.cmbProducto1.TabIndex = 2
        Me.cmbProducto1.Tag = "Producto"
        '
        'cmbCodBarra1
        '
        Me.cmbCodBarra1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCodBarra1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCodBarra1.FormattingEnabled = True
        Me.cmbCodBarra1.Location = New System.Drawing.Point(4, 37)
        Me.cmbCodBarra1.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCodBarra1.Name = "cmbCodBarra1"
        Me.cmbCodBarra1.Size = New System.Drawing.Size(130, 25)
        Me.cmbCodBarra1.TabIndex = 1
        Me.cmbCodBarra1.Tag = "Producto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(432, 19)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Precio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(316, 19)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Cantidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(178, 19)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Producto"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(374, 543)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 16)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Subtotal: L."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(374, 570)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 16)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "ISV: L."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(374, 596)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 16)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Descuento: L."
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(374, 623)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 16)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Total: L."
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSubtotal1
        '
        Me.txtSubtotal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal1.Location = New System.Drawing.Point(496, 537)
        Me.txtSubtotal1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSubtotal1.Name = "txtSubtotal1"
        Me.txtSubtotal1.ReadOnly = True
        Me.txtSubtotal1.Size = New System.Drawing.Size(120, 23)
        Me.txtSubtotal1.TabIndex = 15
        Me.txtSubtotal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtISV1
        '
        Me.txtISV1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtISV1.Location = New System.Drawing.Point(496, 564)
        Me.txtISV1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtISV1.Name = "txtISV1"
        Me.txtISV1.ReadOnly = True
        Me.txtISV1.Size = New System.Drawing.Size(120, 23)
        Me.txtISV1.TabIndex = 16
        Me.txtISV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal1
        '
        Me.txtTotal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal1.Location = New System.Drawing.Point(496, 618)
        Me.txtTotal1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotal1.Name = "txtTotal1"
        Me.txtTotal1.ReadOnly = True
        Me.txtTotal1.Size = New System.Drawing.Size(120, 23)
        Me.txtTotal1.TabIndex = 18
        Me.txtTotal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDesc1
        '
        Me.txtDesc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc1.Location = New System.Drawing.Point(496, 591)
        Me.txtDesc1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDesc1.Name = "txtDesc1"
        Me.txtDesc1.ReadOnly = True
        Me.txtDesc1.Size = New System.Drawing.Size(120, 23)
        Me.txtDesc1.TabIndex = 17
        Me.txtDesc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(10, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 62)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'btnFacturar1
        '
        Me.btnFacturar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacturar1.Location = New System.Drawing.Point(18, 605)
        Me.btnFacturar1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFacturar1.Name = "btnFacturar1"
        Me.btnFacturar1.Size = New System.Drawing.Size(92, 25)
        Me.btnFacturar1.TabIndex = 21
        Me.btnFacturar1.Text = "Facturar"
        Me.btnFacturar1.UseVisualStyleBackColor = True
        '
        'btnLimpiar1
        '
        Me.btnLimpiar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar1.Location = New System.Drawing.Point(18, 575)
        Me.btnLimpiar1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLimpiar1.Name = "btnLimpiar1"
        Me.btnLimpiar1.Size = New System.Drawing.Size(92, 25)
        Me.btnLimpiar1.TabIndex = 22
        Me.btnLimpiar1.Text = "Limpiar"
        Me.btnLimpiar1.UseVisualStyleBackColor = True
        '
        'lblIDFact1
        '
        Me.lblIDFact1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDFact1.Location = New System.Drawing.Point(475, 11)
        Me.lblIDFact1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIDFact1.Name = "lblIDFact1"
        Me.lblIDFact1.Size = New System.Drawing.Size(147, 16)
        Me.lblIDFact1.TabIndex = 24
        Me.lblIDFact1.Text = "Fecha"
        Me.lblIDFact1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btncancelar1
        '
        Me.btncancelar1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancelar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar1.Location = New System.Drawing.Point(115, 575)
        Me.btncancelar1.Margin = New System.Windows.Forms.Padding(2)
        Me.btncancelar1.Name = "btncancelar1"
        Me.btncancelar1.Size = New System.Drawing.Size(92, 25)
        Me.btncancelar1.TabIndex = 25
        Me.btncancelar1.Text = "Cancelar"
        Me.btncancelar1.UseVisualStyleBackColor = True
        '
        'Btn_Imprimir
        '
        Me.Btn_Imprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Imprimir.Location = New System.Drawing.Point(115, 605)
        Me.Btn_Imprimir.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Imprimir.Name = "Btn_Imprimir"
        Me.Btn_Imprimir.Size = New System.Drawing.Size(92, 25)
        Me.Btn_Imprimir.TabIndex = 26
        Me.Btn_Imprimir.Text = "Imprimir"
        Me.Btn_Imprimir.UseVisualStyleBackColor = True
        '
        'Datos
        '
        Me.Datos.AllowUserToAddRows = False
        Me.Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Producto, Me.Detalle, Me.Cantidad, Me.Precio, Me.ISV, Me.Total})
        Me.Datos.Location = New System.Drawing.Point(18, 193)
        Me.Datos.Margin = New System.Windows.Forms.Padding(2)
        Me.Datos.Name = "Datos"
        Me.Datos.ReadOnly = True
        Me.Datos.RowHeadersWidth = 51
        Me.Datos.RowTemplate.Height = 24
        Me.Datos.Size = New System.Drawing.Size(597, 339)
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
        'cmbPago1
        '
        Me.cmbPago1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPago1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPago1.FormattingEnabled = True
        Me.cmbPago1.Items.AddRange(New Object() {"Credito", "Contado"})
        Me.cmbPago1.Location = New System.Drawing.Point(227, 605)
        Me.cmbPago1.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbPago1.Name = "cmbPago1"
        Me.cmbPago1.Size = New System.Drawing.Size(164, 25)
        Me.cmbPago1.TabIndex = 11
        Me.cmbPago1.Tag = "Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(267, 587)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Tipo de pago"
        '
        'Plantilla_Facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btncancelar1
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(631, 644)
        Me.Controls.Add(Me.cmbPago1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Datos)
        Me.Controls.Add(Me.Btn_Imprimir)
        Me.Controls.Add(Me.btncancelar1)
        Me.Controls.Add(Me.lblIDFact1)
        Me.Controls.Add(Me.btnLimpiar1)
        Me.Controls.Add(Me.btnFacturar1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtTotal1)
        Me.Controls.Add(Me.txtDesc1)
        Me.Controls.Add(Me.txtISV1)
        Me.Controls.Add(Me.txtSubtotal1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.grpProducto)
        Me.Controls.Add(Me.cmbCli1)
        Me.Controls.Add(Me.txtRTN1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblFecha1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Plantilla_Facturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas"
        Me.grpProducto.ResumeLayout(False)
        Me.grpProducto.PerformLayout()
        CType(Me.spnPrecio1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnCantidad1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents lblFecha1 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents txtRTN1 As Windows.Forms.TextBox
    Friend WithEvents cmbCli1 As Windows.Forms.ComboBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents grpProducto As Windows.Forms.GroupBox
    Friend WithEvents spnPrecio1 As Windows.Forms.NumericUpDown
    Friend WithEvents spnCantidad1 As Windows.Forms.NumericUpDown
    Friend WithEvents cmbProducto1 As Windows.Forms.ComboBox
    Friend WithEvents cmbCodBarra1 As Windows.Forms.ComboBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents btnAgregar1 As Windows.Forms.Button
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents txtSubtotal1 As Windows.Forms.TextBox
    Friend WithEvents txtISV1 As Windows.Forms.TextBox
    Friend WithEvents txtTotal1 As Windows.Forms.TextBox
    Friend WithEvents txtDesc1 As Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents btnFacturar1 As Windows.Forms.Button
    Friend WithEvents btnLimpiar1 As Windows.Forms.Button
    Friend WithEvents lblIDFact1 As Windows.Forms.Label
    Friend WithEvents btncancelar1 As Windows.Forms.Button
    Friend WithEvents Btn_Imprimir As Windows.Forms.Button
    Friend WithEvents Datos As Windows.Forms.DataGridView
    Friend WithEvents Codigo As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Producto As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Detalle As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ISV As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbPago1 As Windows.Forms.ComboBox
    Friend WithEvents Label2 As Windows.Forms.Label
End Class
