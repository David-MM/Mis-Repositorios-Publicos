Imports System.Data.SqlClient

Public Class Frm_ReporteCliente
    Private Sub Frm_ReporteCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlConn As SqlConnection
        Dim sqlDaCLiente As SqlDataAdapter
        Dim dsPc As New DBCPM
        Dim strConn As String = "Server=" & "localhost" & "; DataBase=" & "CPM" & "; Integrated Security = True"
        Dim StrCommCliente As String = "Select * From Cliente"

        Try
            'Crear los DataAdapters
            sqlConn = New SqlConnection(strConn)
            sqlDaCLiente = New SqlDataAdapter(StrCommCliente, sqlConn)

            'Poblar las tablas del dataset desde los dataAdaperts
            sqlDaCLiente.Fill(dsPc, "Cliente")
            'Poblar el informe con el dataSet y mostrarlo
            Dim info As New RPT_Cliente
            info.SetDataSource(dsPc)
            ReportePrincipal.ReportSource = info
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class
