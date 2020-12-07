Public Class Frm_GRID_Inventario
    Public Overrides Function Buscar(busca As String)
        If Cb_Columnas.SelectedIndex = 0 Then
            Return MyBase.Buscar(" AND P.Codigo Like'%" & Txt_Filtrar.Text & "%'")
        Else
            Return MyBase.Buscar(" AND P.Nombre Like'%" & Txt_Filtrar.Text & "%'")
        End If
    End Function

End Class
