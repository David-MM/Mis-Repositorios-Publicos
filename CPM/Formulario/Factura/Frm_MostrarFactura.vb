Public Class Frm_MostrarFactura
    Private Dates As DataTable
    Private father As Frm_GRID_Factura
    Public Id As Integer

    Public Property PADRE As Frm_GRID_Factura
        Get
            Return father
        End Get
        Set(value As Frm_GRID_Factura)
            father = value
        End Set
    End Property

    Property DATOS As DataTable
        Get
            Return Dates
        End Get
        Set(value As DataTable)
            Dates = value
        End Set
    End Property

    'Public Overrides Sub LlenarDatos()

    'End Sub


    Public Overrides Sub Visibles_Activos()

    End Sub






End Class
