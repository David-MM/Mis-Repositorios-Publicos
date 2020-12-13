Imports System.Data.SqlClient
Imports LibreriaCPM

Public Class Frm_ReporteProducto

    Private claseConexion As New dbConnect
    Public ReadOnly Property DATABASE As dbConnect
        Get
            Return claseConexion
        End Get
    End Property
    Private Sub Frm_ReporteProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dsPc As New DBCPM
        Try
            Dim info As New RPT_Producto
            info.SetDataSource(claseConexion.Reporte("Producto", "", dsPc))
            ReportePrincipal.ReportSource = info
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class
