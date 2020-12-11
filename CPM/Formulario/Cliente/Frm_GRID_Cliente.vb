Public Class Frm_GRID_Cliente
    Public Overrides Function Buscar(busca As String)
        Select Case Cb_Columnas.SelectedIndex
            Case 0
                Return MyBase.Buscar(" AND idCliente Like'%" & Txt_Filtrar.Text & "%'")
            Case 1
                Return MyBase.Buscar(" AND RTN Like'%" & Txt_Filtrar.Text & "%'")
            Case 2
                Return MyBase.Buscar(" AND R_Social Like'%" & Txt_Filtrar.Text & "%'")
            Case 3
                Return MyBase.Buscar(" AND Descuento_Sugerido Like'%" & Txt_Filtrar.Text & "%'")
            Case 4
                Return MyBase.Buscar(" AND L_Credito Like'%" & Txt_Filtrar.Text & "%'")
            Case 5
                Return MyBase.Buscar(" AND Telefono Like'%" & Txt_Filtrar.Text & "%'")
            Case 6
                Return MyBase.Buscar(" AND E_Mail Like'%" & Txt_Filtrar.Text & "%'")
            Case 7
                Return MyBase.Buscar(" AND Direccion Like'%" & Txt_Filtrar.Text & "%'")
            Case Else
                MsgBox("La cago en el switch compa xD", MsgBoxStyle.Critical, "Switch-Cliente")
        End Select
    End Function

    Public Overrides Sub CrearInsert()
        If EstaAbierto("Nuevo Cliente") Then
        Else
            Dim Nuevo As New Frm_CrearCliente()
            Nuevo.PADRE = Me
            Nuevo.MdiParent = Me.MdiParent
            Nuevo.Text = "Nuevo Cliente"
            Nuevo.Show()
            MyBase.CrearInsert()
        End If
    End Sub

    Public Overrides Function Ver() As Integer
        Dim Valor As Integer = MyBase.Ver()
        If EstaAbierto("Nuevo Cliente") Then
        Else
            Dim Nuevo As New Frm_MostrarCliente()
            Dim tmp As DataTable
            Nuevo.MdiParent = Me.MdiParent
            Nuevo.Text = "Detalle de Cliente # "
            If Valor <> 0 Then
                tmp = BuscarDatos("idCliente =" & Valor)
                Nuevo.txtClienteID.Text = tmp.Rows(0)(0).ToString
                Nuevo.Text += tmp.Rows(0)(0).ToString
                Nuevo.txtRTN.Text = tmp.Rows(0)(1).ToString
                Nuevo.txtNombre.Text = tmp.Rows(0)(2).ToString
                Nuevo.N_Descuento.Value = (tmp.Rows(0)(3) * 100).ToString
                Nuevo.N_Credito.Value = tmp.Rows(0)(4).ToString
                Nuevo.txtTelefono.Text = tmp.Rows(0)(5).ToString
                Nuevo.txtCorreo.Text = tmp.Rows(0)(6).ToString
                Nuevo.txtDireccion.Text = tmp.Rows(0)(7).ToString
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
