<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlantillaCliente
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtClienteID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRTN = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.N_Descuento = New System.Windows.Forms.NumericUpDown()
        Me.N_Credito = New System.Windows.Forms.NumericUpDown()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtLimite = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.N_Descuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_Credito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label1.Location = New System.Drawing.Point(27, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ClienteID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCorreo)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 198)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(421, 149)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion de Contacto"
        '
        'txtCorreo
        '
        Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(224, 65)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(176, 27)
        Me.txtCorreo.TabIndex = 12
        '
        'txtTelefono
        '
        Me.txtTelefono.BeepOnError = True
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(224, 32)
        Me.txtTelefono.Mask = "0000-0000"
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(176, 27)
        Me.txtTelefono.TabIndex = 11
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtDireccion.Location = New System.Drawing.Point(224, 98)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(176, 27)
        Me.txtDireccion.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label6.Location = New System.Drawing.Point(24, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Direccion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label7.Location = New System.Drawing.Point(24, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Correo Electronico"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label8.Location = New System.Drawing.Point(24, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Telefono"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(85, 353)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 43)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtClienteID
        '
        Me.txtClienteID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtClienteID.Location = New System.Drawing.Point(227, 20)
        Me.txtClienteID.Name = "txtClienteID"
        Me.txtClienteID.ReadOnly = True
        Me.txtClienteID.Size = New System.Drawing.Size(215, 27)
        Me.txtClienteID.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label2.Location = New System.Drawing.Point(27, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "RTN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label3.Location = New System.Drawing.Point(27, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Razon Social / Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label4.Location = New System.Drawing.Point(27, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Descuento (&%)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label5.Location = New System.Drawing.Point(27, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Limite de Credito (L.)"
        '
        'txtRTN
        '
        Me.txtRTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtRTN.Location = New System.Drawing.Point(227, 53)
        Me.txtRTN.Name = "txtRTN"
        Me.txtRTN.Size = New System.Drawing.Size(215, 27)
        Me.txtRTN.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtNombre.Location = New System.Drawing.Point(227, 86)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(215, 27)
        Me.txtNombre.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(245, 353)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(145, 43)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'N_Descuento
        '
        Me.N_Descuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.N_Descuento.Location = New System.Drawing.Point(229, 119)
        Me.N_Descuento.Maximum = New Decimal(New Integer() {70, 0, 0, 0})
        Me.N_Descuento.Name = "N_Descuento"
        Me.N_Descuento.Size = New System.Drawing.Size(214, 27)
        Me.N_Descuento.TabIndex = 3
        Me.N_Descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'N_Credito
        '
        Me.N_Credito.DecimalPlaces = 2
        Me.N_Credito.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.N_Credito.Location = New System.Drawing.Point(229, 152)
        Me.N_Credito.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.N_Credito.Name = "N_Credito"
        Me.N_Credito.Size = New System.Drawing.Size(214, 27)
        Me.N_Credito.TabIndex = 4
        Me.N_Credito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.N_Credito.ThousandsSeparator = True
        '
        'Button3
        '
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(85, 402)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(305, 33)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Estado de cuentas"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtDescuento
        '
        Me.txtDescuento.Enabled = False
        Me.txtDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuento.Location = New System.Drawing.Point(227, 118)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(215, 27)
        Me.txtDescuento.TabIndex = 12
        Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLimite
        '
        Me.txtLimite.Enabled = False
        Me.txtLimite.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimite.Location = New System.Drawing.Point(227, 151)
        Me.txtLimite.Name = "txtLimite"
        Me.txtLimite.Size = New System.Drawing.Size(215, 27)
        Me.txtLimite.TabIndex = 13
        Me.txtLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PlantillaCliente
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(475, 453)
        Me.Controls.Add(Me.txtLimite)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.N_Credito)
        Me.Controls.Add(Me.N_Descuento)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtRTN)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtClienteID)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PlantillaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PlantillaCliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.N_Descuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_Credito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Public WithEvents Label1 As Windows.Forms.Label
    Public WithEvents GroupBox1 As Windows.Forms.GroupBox
    Public WithEvents Button1 As Windows.Forms.Button
    Public WithEvents txtClienteID As Windows.Forms.TextBox
    Public WithEvents Label2 As Windows.Forms.Label
    Public WithEvents Label3 As Windows.Forms.Label
    Public WithEvents Label4 As Windows.Forms.Label
    Public WithEvents Label5 As Windows.Forms.Label
    Public WithEvents txtRTN As Windows.Forms.TextBox
    Public WithEvents txtNombre As Windows.Forms.TextBox
    Public WithEvents Button2 As Windows.Forms.Button
    Public WithEvents N_Descuento As Windows.Forms.NumericUpDown
    Public WithEvents N_Credito As Windows.Forms.NumericUpDown
    Public WithEvents Button3 As Windows.Forms.Button
    Public WithEvents txtDireccion As Windows.Forms.TextBox
    Public WithEvents txtCorreo As Windows.Forms.TextBox
    Public WithEvents txtTelefono As Windows.Forms.MaskedTextBox
    Public WithEvents txtDescuento As Windows.Forms.TextBox
    Public WithEvents txtLimite As Windows.Forms.TextBox
End Class
