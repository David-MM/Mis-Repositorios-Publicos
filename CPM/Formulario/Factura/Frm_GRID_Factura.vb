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
            Case 4
                Return MyBase.Buscar(" AND Tipo Like'%" & Txt_Filtrar.Text & "%'") 'Falta arreglar
            Case Else
                MsgBox("La cago en el switch compa xD", MsgBoxStyle.Critical, "Switch-Cliente")
        End Select
    End Function

    Public Overrides Sub CrearInsert()
        If EstaAbierto("Nueva Factura") Then
        Else
            Dim Nuevo As New Frm_CrearFactura()
            Nuevo.MdiParent = Me.MdiParent
            Nuevo.Text = "Nueva Factura"
            Nuevo.PADRE = Me
            Nuevo.Show()
            'MyBase.CrearInsert()
        End If
    End Sub

    Public Overrides Function Ver() As Integer
        MsgBox("En Proceso...")
        'Dim Nuevo As New Frm_MostrarFactura()
        'Dim tmp As DataTable
        'Nuevo.MdiParent = Me.MdiParent
        'Nuevo.Text = "Factura # "
        'If MyBase.Ver() <> 0 Then
        '    tmp = BuscarDatos("idFactura =" & MyBase.Ver())
        '    Nuevo.DATOS = tmp
        '    Nuevo.Show()
        '    Return 1
        'End If
        'Return 0
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
