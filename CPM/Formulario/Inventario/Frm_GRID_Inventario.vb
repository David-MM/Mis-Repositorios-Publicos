Public Class Frm_GRID_Inventario
    Public Overrides Function Buscar(busca As String)
        If Cb_Columnas.SelectedIndex = 0 Then
            Return MyBase.Buscar(" AND P.Codigo Like'%" & Txt_Filtrar.Text & "%'")
        Else
            Return MyBase.Buscar(" AND P.Nombre Like'%" & Txt_Filtrar.Text & "%'")
        End If
    End Function

    Public Overrides Function Modificara() As Integer
        Dim Valor As Integer = MyBase.Modificara()
        Dim Nuevo As New Frm_EditarInventario()
        Nuevo.PADRE = Me
        Dim tmp As DataTable
        Nuevo.MdiParent = Me.MdiParent
        Nuevo.UPDATE = Valor
        Nuevo.Text = "Producto # "
        If Valor <> 0 Then
            tmp = BuscarDatos("I.idProducto = " & Valor)
            Nuevo.Text += tmp.Rows(0)(0).ToString
            Nuevo.txtCodigo.Text = tmp.Rows(0)(1).ToString
            Nuevo.txtProducto.Text = tmp.Rows(0)(2).ToString
            Nuevo.Existencias.Value = tmp.Rows(0)(3).ToString
            Nuevo.Existencias.Minimum = tmp.Rows(0)(3).ToString
            Nuevo.Show()
            Return 1
        End If
        Return 0
    End Function

End Class
