Imports System.Data.SqlClient
Public Class Frm_CrearProducto
    Private father As Frm_GRID_Producto
    Private claseConexion As New LibreriaCPM.dbConnect()
    Private modificar As Boolean

    Public Property UPDATES As Boolean
        Get
            Return modificar
        End Get
        Set(ByVal value As Boolean)
            modificar = value
        End Set
    End Property

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
        If modificar Then

        Else
            Try
                claseConexion.Insert("Producto", DATOS)
                father.CargarDatos()
                Me.Dispose()
            Catch ex As SqlException
                If (ex.Number = 2627) Then
                    MsgBox("Codigo o Nombre de producto ya existe", MsgBoxStyle.Critical, "Error")
                End If
            End Try
        End If
    End Sub

    Public Overrides Sub Activos_Visibles()
        'lblProducoId.Visible = False
        'txtProductoId.Visible = False
        'MyBase.Activos_Visibles()
    End Sub
End Class
