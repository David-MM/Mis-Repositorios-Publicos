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
        Dim Nuevo As New Frm_CrearCliente()
        Nuevo.PADRE = Me
        Nuevo.UPDATES = False
        Nuevo.MdiParent = Me.MdiParent
        Nuevo.Text = "Nuevo Cliente"
        Nuevo.Show()
        MyBase.CrearInsert()
    End Sub

    Public Overrides Function Ver() As Integer
        Dim Nuevo As New Frm_MostrarCliente()
        Dim tmp As DataTable
        Nuevo.MdiParent = Me.MdiParent
        Nuevo.Text = "Detalle de Cliente # "
        If MyBase.Ver() <> 0 Then
            tmp = BuscarDatos("idCliente =" & MyBase.Ver())
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
    End Function
End Class
