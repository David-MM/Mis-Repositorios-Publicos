Public Class Frm_GRID_Factura

    Public Overrides Function Buscar(busca As String) As Object
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
        Dim Nuevo As New LibreriaCPM.Plantilla_Facturacion()
        Nuevo.MdiParent = Me.MdiParent
        Nuevo.Show()
        MyBase.CrearInsert()
    End Sub
End Class
