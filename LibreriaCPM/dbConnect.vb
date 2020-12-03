Imports System.Data.SqlClient
Public Class dbConnect
    Private conexion As SqlConnection
    Private conexionActiva As Boolean

    Public ReadOnly Property ConexionSQLServer As SqlConnection
        Get
            Return conexion
        End Get
    End Property

    Public ReadOnly Property Activa As Boolean
        Get
            Return conexionActiva
        End Get
    End Property

    'Constructor vacio
    Public Sub New()

    End Sub

    'Crea conexion
    Public Sub New(usuario As String, password As String, Servidor As String, BaseDatos As String)
        Try
            'Dim url = "Server=" & "localhost" & "; DataBase=" & BaseDatos & "; UID=" & usuario & "; pwd=" + password
            Dim url = "Server=" & "localhost" & "; DataBase=" & "CPM" & "; Integrated Security = True"
            conexion = New SqlConnection(url)

            conexionActiva = False
            conexion.Open()
            conexionActiva = True
        Catch ex As SqlException
            For Each Err As SqlError In ex.Errors
                If Err.Number = 4060 Then
                    MsgBox("La base de datos no existe", MsgBoxStyle.Critical, "Error")
                End If
                MsgBox(Err.Message, MsgBoxStyle.Critical, "Error -" & Err.Number)
            Next
        End Try
    End Sub
End Class
