Public Class Frm_EditarInventario
    Private father As Frm_GRID_Inventario
    Private claseConexion As New LibreriaCPM.dbConnect()
    Private valor As Integer

    Public Property PADRE As Frm_GRID_Inventario
        Get
            Return father
        End Get
        Set(value As Frm_GRID_Inventario)
            father = value
        End Set
    End Property

    Public Property UPDATE As Integer
        Get
            Return valor
        End Get
        Set(value As Integer)
            valor = value
        End Set
    End Property

    Private Sub Frm_EditarInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Incio()
    End Sub

    Public Overrides Sub Insersion()
        Dim columnas As New ArrayList
        columnas.Add("Cantidad")
        claseConexion.Update("Inventario", columnas, DATOS, " where idProducto = " & valor)
        father.CargarDatos()
        Me.Dispose()
    End Sub
End Class
