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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_Crear = New System.Windows.Forms.Button()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.Btn_Ver = New System.Windows.Forms.Button()
        Me.Btn_Anular = New System.Windows.Forms.Button()
        Me.Btn_Cerrar = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Titulo.Text = "Gird-Crud"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 158)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(875, 552)
        Me.DataGridView1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(917, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(206, 143)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
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
        'Btn_Anular
        '
        Me.Btn_Anular.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_Anular.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Anular.Location = New System.Drawing.Point(931, 460)
        Me.Btn_Anular.Name = "Btn_Anular"
        Me.Btn_Anular.Size = New System.Drawing.Size(176, 44)
        Me.Btn_Anular.TabIndex = 6
        Me.Btn_Anular.Text = "Anular"
        Me.Btn_Anular.UseVisualStyleBackColor = True
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
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBox1.Font = New System.Drawing.Font("Modern No. 20", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(28, 105)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(192, 23)
        Me.ComboBox1.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Modern No. 20", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(241, 107)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(580, 21)
        Me.TextBox1.TabIndex = 9
        '
        'GRID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 727)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Btn_Cerrar)
        Me.Controls.Add(Me.Btn_Anular)
        Me.Controls.Add(Me.Btn_Ver)
        Me.Controls.Add(Me.Btn_Modificar)
        Me.Controls.Add(Me.Btn_Crear)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Titulo)
        Me.Name = "GRID"
        Me.Text = "GRID"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Titulo As Windows.Forms.Label
    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents Btn_Crear As Windows.Forms.Button
    Friend WithEvents Btn_Modificar As Windows.Forms.Button
    Friend WithEvents Btn_Ver As Windows.Forms.Button
    Friend WithEvents Btn_Anular As Windows.Forms.Button
    Friend WithEvents Btn_Cerrar As Windows.Forms.Button
    Friend WithEvents ComboBox1 As Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
End Class
