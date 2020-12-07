Public Class Frm_GRID_Cliente

    Public Overrides Function Buscar(busca As String) As Object
        Select Case Cb_Columnas.SelectedIndex
            Case 0
                Return MyBase.Buscar(" AND '# Cliente' Like'%" & Txt_Filtrar.Text & "%'")
            Case 1
                Return MyBase.Buscar(" AND RTN Like'%" & Txt_Filtrar.Text & "%'")
            Case 2
                Return MyBase.Buscar(" AND Nombre Like'%" & Txt_Filtrar.Text & "%'")
            Case 3
                Return MyBase.Buscar(" AND Descuento Like'%" & Txt_Filtrar.Text & "%'")
            Case 4
                Return MyBase.Buscar(" AND 'Limite-Credito' Like'%" & Txt_Filtrar.Text & "%'")
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
        Nuevo.Show()
        MyBase.CrearInsert()
    End Sub
End Class
