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
        Me.Tabla = New System.Windows.Forms.DataGridView()
        Me.Titulo = New System.Windows.Forms.Label()
        Me.Botones = New System.Windows.Forms.Panel()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.Btn_Ver = New System.Windows.Forms.Button()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.Btn_Crear = New System.Windows.Forms.Button()
        Me.Image = New System.Windows.Forms.PictureBox()
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Botones.SuspendLayout()
        CType(Me.Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(232, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 25)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Buscar:"
        '
        'Txt_Filtrar
        '
        Me.Txt_Filtrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Filtrar.Location = New System.Drawing.Point(319, 81)
        Me.Txt_Filtrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Filtrar.Name = "Txt_Filtrar"
        Me.Txt_Filtrar.Size = New System.Drawing.Size(686, 34)
        Me.Txt_Filtrar.TabIndex = 1
        '
        'Cb_Columnas
        '
        Me.Cb_Columnas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Columnas.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cb_Columnas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Columnas.FormattingEnabled = True
        Me.Cb_Columnas.Location = New System.Drawing.Point(19, 78)
        Me.Cb_Columnas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cb_Columnas.Name = "Cb_Columnas"
        Me.Cb_Columnas.Size = New System.Drawing.Size(207, 37)
        Me.Cb_Columnas.TabIndex = 2
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_Cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cerrar.Location = New System.Drawing.Point(1028, 628)
        Me.Btn_Cerrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(235, 54)
        Me.Btn_Cerrar.TabIndex = 8
        Me.Btn_Cerrar.Text = "Cerrar"
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Tabla
        '
        Me.Tabla.AllowUserToAddRows = False
        Me.Tabla.AllowUserToDeleteRows = False
        Me.Tabla.AllowUserToResizeRows = False
        Me.Tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla.Location = New System.Drawing.Point(19, 122)
        Me.Tabla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Tabla.Name = "Tabla"
        Me.Tabla.ReadOnly = True
        Me.Tabla.RowHeadersWidth = 51
        Me.Tabla.RowTemplate.Height = 24
        Me.Tabla.Size = New System.Drawing.Size(986, 561)
        Me.Tabla.TabIndex = 3
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.Location = New System.Drawing.Point(19, 11)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Titulo.Size = New System.Drawing.Size(222, 38)
        Me.Titulo.TabIndex = 22
        Me.Titulo.Text = "GRID PADRE"
        '
        'Botones
        '
        Me.Botones.Controls.Add(Me.Btn_Eliminar)
        Me.Botones.Controls.Add(Me.Btn_Ver)
        Me.Botones.Controls.Add(Me.Btn_Modificar)
        Me.Botones.Controls.Add(Me.Btn_Crear)
        Me.Botones.Location = New System.Drawing.Point(1025, 220)
        Me.Botones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Botones.Name = "Botones"
        Me.Botones.Size = New System.Drawing.Size(250, 402)
        Me.Botones.TabIndex = 33
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Eliminar.Location = New System.Drawing.Point(3, 316)
        Me.Btn_Eliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(235, 54)
        Me.Btn_Eliminar.TabIndex = 7
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Btn_Ver
        '
        Me.Btn_Ver.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_Ver.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Ver.Location = New System.Drawing.Point(3, 204)
        Me.Btn_Ver.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Ver.Name = "Btn_Ver"
        Me.Btn_Ver.Size = New System.Drawing.Size(235, 54)
        Me.Btn_Ver.TabIndex = 6
        Me.Btn_Ver.Text = "Ver Detalle"
        Me.Btn_Ver.UseVisualStyleBackColor = True
        '
        'Btn_Modificar
        '
        Me.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modificar.Location = New System.Drawing.Point(3, 112)
        Me.Btn_Modificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(235, 54)
        Me.Btn_Modificar.TabIndex = 5
        Me.Btn_Modificar.Text = "Modificar"
        Me.Btn_Modificar.UseVisualStyleBackColor = True
        '
        'Btn_Crear
        '
        Me.Btn_Crear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_Crear.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Crear.Location = New System.Drawing.Point(3, 10)
        Me.Btn_Crear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Crear.Name = "Btn_Crear"
        Me.Btn_Crear.Size = New System.Drawing.Size(235, 67)
        Me.Btn_Crear.TabIndex = 4
        Me.Btn_Crear.Text = "Crear"
        '
        'Image
        '
        Me.Image.Location = New System.Drawing.Point(1025, 25)
        Me.Image.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Image.Name = "Image"
        Me.Image.Size = New System.Drawing.Size(250, 190)
        Me.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image.TabIndex = 24
        Me.Image.TabStop = False
        '
        'Frm_GRID_Padre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Btn_Cerrar
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1287, 697)
        Me.Controls.Add(Me.Txt_Filtrar)
        Me.Controls.Add(Me.Botones)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cb_Columnas)
        Me.Controls.Add(Me.Btn_Cerrar)
        Me.Controls.Add(Me.Image)
        Me.Controls.Add(Me.Tabla)
        Me.Controls.Add(Me.Titulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Frm_GRID_Padre"
        Me.Text = "Frm_GRID_Padre"
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Botones.ResumeLayout(False)
        CType(Me.Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Filtrar As TextBox
    Friend WithEvents Cb_Columnas As ComboBox
    Friend WithEvents Btn_Cerrar As Button
    Friend WithEvents Image As PictureBox
    Friend WithEvents Tabla As DataGridView
    Friend WithEvents Titulo As Label
    Friend WithEvents Botones As Panel
    Friend WithEvents Btn_Eliminar As Button
    Friend WithEvents Btn_Ver As Button
    Friend WithEvents Btn_Modificar As Button
    Friend WithEvents Btn_Crear As Button
End Class
