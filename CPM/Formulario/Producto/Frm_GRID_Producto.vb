Public Class Frm_GRID_Producto
    Public Overrides Function Buscar(busca As String)
        Select Case Cb_Columnas.SelectedIndex
            Case 0
                Return MyBase.Buscar(" AND Codigo Like'%" & Txt_Filtrar.Text & "%'")
            Case 1
                Return MyBase.Buscar(" AND Nombre Like'%" & Txt_Filtrar.Text & "%'")
            Case 2
                Return MyBase.Buscar(" AND Descripcion Like'%" & Txt_Filtrar.Text & "%'")
            Case Else
                MsgBox("La cago en el switch compa xD", MsgBoxStyle.Critical, "Switch-Cliente")
        End Select
    End Function

    Public Overrides Sub CrearInsert()
        If EstaAbierto("Nuevo Producto") Then
        Else
            Dim Nuevo As New Frm_CrearProducto()
            Nuevo.MdiParent = Me.MdiParent
            Nuevo.Text = "Nuevo Producto"
            Nuevo.PADRE = Me
            Nuevo.Show()
            'MyBase.CrearInsert()
        End If
    End Sub

    Public Overrides Function Modificara() As Integer
        Dim Valor As Integer = MyBase.Modificara()
        If EstaAbierto("Detalle de Producto # " & Valor) Then
        Else
            Dim Nuevo As New Frm_EditarProducto()
            Dim tmp As DataTable
            Nuevo.ID = Valor
            Nuevo.MdiParent = Me.MdiParent
            Nuevo.PADRE = Me
            Nuevo.Text = "Detalle de Producto # "
            If Valor <> 0 Then
                tmp = BuscarDatos("idProducto =" & Valor)
                Nuevo.Text += tmp.Rows(0)(0).ToString
                Nuevo.txtCodigo.Text = tmp.Rows(0)(1).ToString
                Nuevo.txtNombre.Text = tmp.Rows(0)(2).ToString
                Nuevo.spinnerPrecio.Value = tmp.Rows(0)(3).ToString
                Nuevo.spinnerISV.Value = (tmp.Rows(0)(4) * 100).ToString
                Nuevo.txtDescripcion.Text = tmp.Rows(0)(5).ToString
                Nuevo.Show()
                Return 1
            End If
        End If
        Return 0
    End Function

    Public Overrides Function Ver() As Integer
        Dim Valor As Integer = MyBase.Ver()
        If EstaAbierto("Detalle de Producto # " & Valor) Then
        Else
            Dim Nuevo As New Frm_MostrarProducto()
            Dim tmp As DataTable
            Nuevo.MdiParent = Me.MdiParent
            Nuevo.Text = "Detalle de Cliente # "
            If Valor <> 0 Then
                tmp = BuscarDatos("idProducto =" & Valor)
                Nuevo.Text += tmp.Rows(0)(0).ToString
                Nuevo.txtCodigo.Text = tmp.Rows(0)(1).ToString
                Nuevo.txtNombre.Text = tmp.Rows(0)(2).ToString
                Nuevo.spinnerPrecio.Value = tmp.Rows(0)(3).ToString
                Nuevo.spinnerISV.Value = (tmp.Rows(0)(4) / 100).ToString
                Nuevo.txtDescripcion.Text = tmp.Rows(0)(5).ToString
                Nuevo.Show()
                Return 1
            End If
            Return 0
        End If
    End Function

    Public Function EstaAbierto(Myform As String) As Boolean
        Dim objForm As Form
        Dim blnAbierto As Boolean = False
        For Each objForm In My.Application.OpenForms
            If (Trim(objForm.Text) = Trim(Myform)) Then
                objForm.BringToFront()
                blnAbierto = True
            End If
        Next
        Return blnAbierto
    End Function

End Class
