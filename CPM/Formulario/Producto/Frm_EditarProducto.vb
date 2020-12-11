Imports System.Data.SqlClient
Public Class Frm_EditarProducto
    Private father As Frm_GRID_Producto
    Private Producto As String
    Private claseConexion As New LibreriaCPM.dbConnect()

    Public Property PADRE As Frm_GRID_Producto
        Get
            Return father
        End Get
        Set(value As Frm_GRID_Producto)
            father = value
        End Set
    End Property

    Public Property ID As String
        Get
            Return Producto
        End Get
        Set(value As String)
            Producto = value
        End Set
    End Property

    Private Sub Frm_EditarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Incio()
    End Sub

    Public Overrides Sub Insersion()
        Dim Columnas As New ArrayList
        Columnas.Add("Codigo")
        Columnas.Add("Nombre")
        Columnas.Add("P_Sugerido")
        Columnas.Add("ISV_Sugerido")
        Columnas.Add("Descripcion")
        Try
            DATOS.RemoveAt(DATOS.Count - 1)
            claseConexion.Update("Producto", Columnas, DATOS, " where idProducto = " & Producto)
            father.CargarDatos()
            MsgBox("¡Los datos fueron actualizados exitosamente!", MsgBoxStyle.Information, "Datos Salvados")
            Me.Dispose()
        Catch ex As SqlException
            If (ex.Number = 2627) Then
                MsgBox("Codigo o Nombre de producto ya existe", MsgBoxStyle.Critical, "Error")
            End If
        End Try
    End Sub
End Class
