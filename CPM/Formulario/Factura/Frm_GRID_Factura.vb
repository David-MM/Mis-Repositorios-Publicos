Public Class Frm_GRID_Factura
    Public Overrides Function Buscar(busca As String)
        Select Case Cb_Columnas.SelectedIndex
            Case 0
                Return MyBase.Buscar(" AND F.idFactura Like'%" & Txt_Filtrar.Text & "%'")
            Case 1
                Return MyBase.Buscar(" AND F.Fecha Like'%" & Txt_Filtrar.Text & "%'")
            Case 2
                Return MyBase.Buscar(" AND (SELECT C.RTN FROM Cliente as C WHERE C.idCliente=F.ClientesID) Like'%" & Txt_Filtrar.Text & "%'")
            Case 3
                Return MyBase.Buscar(" AND (SELECT C.R_Social FROM Cliente as C WHERE C.idCliente=F.ClientesID) Like'%" & Txt_Filtrar.Text & "%'")
            Case Else
                MsgBox("La cago en el switch compa xD", MsgBoxStyle.Critical, "Switch-Cliente")
        End Select
    End Function

    Public Overrides Sub CrearInsert()
        Dim Nuevo As New Frm_CrearFactura()
        Nuevo.MdiParent = Me.MdiParent
        Nuevo.Text = "Nueva Factura"
        Nuevo.Show()
        MyBase.CrearInsert()
    End Sub

    Public Overrides Function Ver() As Integer
        Dim Nuevo As New Frm_MostrarCliente()
        Dim tmp As DataTable
        Nuevo.MdiParent = Me.MdiParent
        Nuevo.Text = "Detalle de Factura # "
        'If MyBase.Ver() <> 0 Then
        '    tmp = BuscarDatos("idFactura =" & MyBase.Ver())
        '    Nuevo.txtClienteID.Text = tmp.Rows(0)(0).ToString
        '    Nuevo.Text += tmp.Rows(0)(0).ToString
        '    Nuevo.txtRTN.Text = tmp.Rows(0)(1).ToString
        '    Nuevo.txtNombre.Text = tmp.Rows(0)(2).ToString
        '    Nuevo.N_Descuento.Value = (tmp.Rows(0)(3) * 100).ToString
        '    Nuevo.N_Credito.Value = tmp.Rows(0)(4).ToString
        '    Nuevo.txtTelefono.Text = tmp.Rows(0)(5).ToString
        '    Nuevo.txtCorreo.Text = tmp.Rows(0)(6).ToString
        '    Nuevo.txtDireccion.Text = tmp.Rows(0)(7).ToString
        '    Nuevo.Show()
        '    Return 1
        'End If
        Return 0
    End Function
End Class
