<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_GRID_Padre
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
        Me.Txt_Filtrar = New System.Windows.Forms.TextBox()
        Me.Cb_Columnas = New System.Windows.Forms.ComboBox()
        Me.Btn_Cerrar = New System.Windows.Forms.Button()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.Btn_Ver = New System.Windows.Forms.Button()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.Btn_Crear = New System.Windows.Forms.Button()
        Me.Image = New System.Windows.Forms.PictureBox()
        Me.Tabla = New System.Windows.Forms.DataGridView()
        Me.Titulo = New System.Windows.Forms.Label()
        CType(Me.Image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 82)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Buscar:"
        '
        'Txt_Filtrar
        '
        Me.Txt_Filtrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Filtrar.Location = New System.Drawing.Point(239, 82)
        Me.Txt_Filtrar.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_Filtrar.Name = "Txt_Filtrar"
        Me.Txt_Filtrar.Size = New System.Drawing.Size(376, 19)
        Me.Txt_Filtrar.TabIndex = 31
        '
        'Cb_Columnas
        '
        Me.Cb_Columnas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Columnas.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_Columnas.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Columnas.FormattingEnabled = True
        Me.Cb_Columnas.Location = New System.Drawing.Point(23, 80)
        Me.Cb_Columnas.Margin = New System.Windows.Forms.Padding(2)
        Me.Cb_Columnas.Name = "Cb_Columnas"
        Me.Cb_Columnas.Size = New System.Drawing.Size(145, 21)
        Me.Cb_Columnas.TabIndex = 30
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_Cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cerrar.Location = New System.Drawing.Point(700, 428)
        Me.Btn_Cerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(132, 36)
        Me.Btn_Cerrar.TabIndex = 29
        Me.Btn_Cerrar.Text = "Cerrar"
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Eliminar.Location = New System.Drawing.Point(700, 369)
        Me.Btn_Eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(132, 36)
        Me.Btn_Eliminar.TabIndex = 28
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Btn_Ver
        '
        Me.Btn_Ver.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_Ver.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Ver.Location = New System.Drawing.Point(700, 308)
        Me.Btn_Ver.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Ver.Name = "Btn_Ver"
        Me.Btn_Ver.Size = New System.Drawing.Size(132, 36)
        Me.Btn_Ver.TabIndex = 27
        Me.Btn_Ver.Text = "Ver Detalle"
        Me.Btn_Ver.UseVisualStyleBackColor = True
        '
        'Btn_Modificar
        '
        Me.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modificar.Location = New System.Drawing.Point(700, 247)
        Me.Btn_Modificar.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(132, 36)
        Me.Btn_Modificar.TabIndex = 26
        Me.Btn_Modificar.Text = "Modificar"
        Me.Btn_Modificar.UseVisualStyleBackColor = True
        '
        'Btn_Crear
        '
        Me.Btn_Crear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_Crear.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Crear.Location = New System.Drawing.Point(700, 186)
        Me.Btn_Crear.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_Crear.Name = "Btn_Crear"
        Me.Btn_Crear.Size = New System.Drawing.Size(132, 36)
        Me.Btn_Crear.TabIndex = 25
        Me.Btn_Crear.Text = "Crear"
        Me.Btn_Crear.UseVisualStyleBackColor = True
        '
        'Image
        '
        Me.Image.Location = New System.Drawing.Point(690, 20)
        Me.Image.Margin = New System.Windows.Forms.Padding(2)
        Me.Image.Name = "Image"
        Me.Image.Size = New System.Drawing.Size(154, 116)
        Me.Image.TabIndex = 24
        Me.Image.TabStop = False
        '
        'Tabla
        '
        Me.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla.Location = New System.Drawing.Point(11, 123)
        Me.Tabla.Margin = New System.Windows.Forms.Padding(2)
        Me.Tabla.Name = "Tabla"
        Me.Tabla.RowHeadersWidth = 51
        Me.Tabla.RowTemplate.Height = 24
        Me.Tabla.Size = New System.Drawing.Size(656, 448)
        Me.Tabla.TabIndex = 23
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.Location = New System.Drawing.Point(32, 20)
        Me.Titulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Titulo.Size = New System.Drawing.Size(133, 31)
        Me.Titulo.TabIndex = 22
        Me.Titulo.Text = "Grid-Crud"
        '
        'Frm_GRID_Padre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 602)
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
        Me.Name = "Frm_GRID_Padre"
        Me.Text = "Frm_GRID_Padre"
        CType(Me.Image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Filtrar As TextBox
    Friend WithEvents Cb_Columnas As ComboBox
    Friend WithEvents Btn_Cerrar As Button
    Friend WithEvents Btn_Eliminar As Button
    Friend WithEvents Btn_Ver As Button
    Friend WithEvents Btn_Modificar As Button
    Friend WithEvents Btn_Crear As Button
    Friend WithEvents Image As PictureBox
    Friend WithEvents Tabla As DataGridView
    Friend WithEvents Titulo As Label
End Class
