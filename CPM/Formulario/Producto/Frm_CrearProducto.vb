Imports System.Data.SqlClient
Public Class Frm_CrearProducto
    Private father As Frm_GRID_Producto
    Private claseConexion As New LibreriaCPM.dbConnect()

    Public Property PADRE As Frm_GRID_Producto
        Get
            Return father
        End Get
        Set(value As Frm_GRID_Producto)
            father = value
        End Set
    End Property

    Private Sub Frm_CrearProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Incio()
    End Sub

    Public Overrides Sub Insersion()
        Try
            claseConexion.Insert("Producto", DATOS)
            father.CargarDatos()
            Me.Dispose()
        Catch ex As SqlException
            If (ex.Number = 2627) Then
                MsgBox("Codigo o Nombre de producto ya existe", MsgBoxStyle.Critical, "Error")
            End If
        End Try
    End Sub

    Public Overrides Sub Activos_Visibles()
        'lblProducoId.Visible = False
        'txtProductoId.Visible = False
        'MyBase.Activos_Visibles()
        txt_Precio.Visible = False
        txt_Isv.Visible = False
    End Sub
End Class
