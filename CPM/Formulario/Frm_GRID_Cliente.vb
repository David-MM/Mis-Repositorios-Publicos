Public Class Frm_GRID_Cliente
    Public contedor As Frm_Principal
    Public Overrides Function Buscar(busca As String) As Object
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
        Nuevo.MdiParent = contedor
        Nuevo.Show()
        MyBase.CrearInsert()
    End Sub
End Class
