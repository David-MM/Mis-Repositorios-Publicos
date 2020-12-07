Public Class Frm_CrearFactura
    Private father As Frm_GRID_Factura

    Public Property PADRE As Frm_GRID_Factura
        Get
            Return father
        End Get
        Set(value As Frm_GRID_Factura)
            father = value
        End Set
    End Property

    Public Overrides Sub ActualizarTabla()
        father.CargarDatos()
    End Sub

End Class
