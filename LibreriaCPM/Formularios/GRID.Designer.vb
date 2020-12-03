<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GRID
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
        Me.Titulo = New System.Windows.Forms.Label()
        Me.Tabla = New System.Windows.Forms.DataGridView()
        Me.Image = New System.Windows.Forms.PictureBox()
        Me.Btn_Crear = New System.Windows.Forms.Button()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.Btn_Ver = New System.Windows.Forms.Button()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.Btn_Cerrar = New System.Windows.Forms.Button()
        Me.Cb_Columnas = New System.Windows.Forms.ComboBox()
        Me.Txt_Filtrar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.Font = New System.Drawing.Font("Modern No. 20", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.Location = New System.Drawing.Point(40, 31)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Titulo.Size = New System.Drawing.Size(152, 34)
        Me.Titulo.TabIndex = 0
        Me.Titulo.Text = "Grid-Crud"
        '
        'Tabla
        '
        Me.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla.Location = New System.Drawing.Point(12, 158)
        Me.Tabla.Name = "Tabla"
        Me.Tabla.RowHeadersWidth = 51
        Me.Tabla.RowTemplate.Height = 24
        Me.Tabla.Size = New System.Drawing.Size(875, 552)
        Me.Tabla.TabIndex = 1
        '
        'Image
        '
        Me.Image.Location = New System.Drawing.Point(917, 31)
        Me.Image.Name = "Image"
        Me.Image.Size = New System.Drawing.Size(206, 143)
        Me.Image.TabIndex = 2
        Me.Image.TabStop = False
        '
        'Btn_Crear
        '
        Me.Btn_Crear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_Crear.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Crear.Location = New System.Drawing.Point(931, 235)
        Me.Btn_Crear.Name = "Btn_Crear"
        Me.Btn_Crear.Size = New System.Drawing.Size(176, 44)
        Me.Btn_Crear.TabIndex = 3
        Me.Btn_Crear.Text = "Crear"
        Me.Btn_Crear.UseVisualStyleBackColor = True
        '
        'Btn_Modificar
        '
        Me.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_Modificar.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modificar.Location = New System.Drawing.Point(931, 310)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(176, 44)
        Me.Btn_Modificar.TabIndex = 4
        Me.Btn_Modificar.Text = "Modificar"
        Me.Btn_Modificar.UseVisualStyleBackColor = True
        '
        'Btn_Ver
        '
        Me.Btn_Ver.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_Ver.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Ver.Location = New System.Drawing.Point(931, 385)
        Me.Btn_Ver.Name = "Btn_Ver"
        Me.Btn_Ver.Size = New System.Drawing.Size(176, 44)
        Me.Btn_Ver.TabIndex = 5
        Me.Btn_Ver.Text = "Ver Detalle"
        Me.Btn_Ver.UseVisualStyleBackColor = True
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_Eliminar.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Eliminar.Location = New System.Drawing.Point(931, 460)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(176, 44)
        Me.Btn_Eliminar.TabIndex = 6
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_Cerrar.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cerrar.Location = New System.Drawing.Point(931, 533)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(176, 44)
        Me.Btn_Cerrar.TabIndex = 7
        Me.Btn_Cerrar.Text = "Cerrar"
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Cb_Columnas
        '
        Me.Cb_Columnas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Columnas.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_Columnas.Font = New System.Drawing.Font("Modern No. 20", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Columnas.FormattingEnabled = True
        Me.Cb_Columnas.Location = New System.Drawing.Point(28, 105)
        Me.Cb_Columnas.Name = "Cb_Columnas"
        Me.Cb_Columnas.Size = New System.Drawing.Size(192, 23)
        Me.Cb_Columnas.TabIndex = 8
        '
        'Txt_Filtrar
        '
        Me.Txt_Filtrar.Font = New System.Drawing.Font("Modern No. 20", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Filtrar.Location = New System.Drawing.Point(312, 107)
        Me.Txt_Filtrar.Name = "Txt_Filtrar"
        Me.Txt_Filtrar.Size = New System.Drawing.Size(500, 21)
        Me.Txt_Filtrar.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(235, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 22)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Buscar:"
        '
        'GRID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 727)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_Filtrar)
        Me.Controls.Add(Me.Cb_Columnas)
        Me.Controls.Add(Me.Btn_Cerrar)
        Me.Controls.Add(Me.Btn_Eliminar)
        Me.Controls.Add(Me.Btn_Ver)
        Me.Controls.Add(Me.Btn_Modificar)
        Me.Controls.Add(Me.Btn_Crear)
        Me.Controls.Add(Me.Image)
        Me.Controls.Add(Me.Tabla)
        Me.Controls.Add(Me.Titulo)
        Me.Name = "GRID"
        Me.Text = "GRID"
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Titulo As Windows.Forms.Label
    Friend WithEvents Tabla As Windows.Forms.DataGridView
    Friend WithEvents Image As Windows.Forms.PictureBox
    Friend WithEvents Btn_Crear As Windows.Forms.Button
    Friend WithEvents Btn_Modificar As Windows.Forms.Button
    Friend WithEvents Btn_Ver As Windows.Forms.Button
    Friend WithEvents Btn_Eliminar As Windows.Forms.Button
    Friend WithEvents Btn_Cerrar As Windows.Forms.Button
    Friend WithEvents Cb_Columnas As Windows.Forms.ComboBox
    Friend WithEvents Txt_Filtrar As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
End Class
