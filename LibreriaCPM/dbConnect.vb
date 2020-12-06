Imports System.Data.SqlClient
Public Class dbConnect
    Private conexion As SqlConnection
    Private conexionActiva As Boolean
    Private comando As SqlCommand

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

    Public Sub Insert(conexion As SqlConnection, TablaColumnas As String, Lts_Datos As ArrayList)
        Dim cadena As String = "insert into " & TablaColumnas & " values ("
        For index = 0 To (Lts_Datos.Count - 1)
            'cadena += (IIf(Lts_Datos(index).GetType().Name = "String" Or "Char", "'", "")) & Lts_Datos(index).ToString & (IIf(Lts_Datos(index).GetType().Name = "String" Or "Char", "'", "")) & IIf(index = (Lts_Datos.Count - 1), ")", ",")
            'cadena += (IIf(Lts_Datos(index).GetType().Name = "String" Or Lts_Datos(index).GetType().Name = "Char", "'", "")) & Lts_Datos(index).ToString & (IIf(Lts_Datos(index).GetType().Name = "String" Or Lts_Datos(index).GetType().Name = "Char", "'", "")) & IIf(index = (Lts_Datos.Count - 1), ")", ",")
            cadena += Lts_Datos(index).ToString & IIf(index = (Lts_Datos.Count - 1), ")", ",")
        Next
        comando = New SqlCommand(cadena, conexion)
        comando.ExecuteNonQuery()
    End Sub

    Public Sub Update(conexion As SqlConnection, Tabla As String, Lts_Columnas As ArrayList, Lts_Datos As ArrayList, where As String)
        Dim cadena As String = "update " & Tabla & " set "
        For index = 0 To (Lts_Datos.Count - 1)
            cadena += Lts_Columnas(index).ToString & " = " & Lts_Datos(index).ToString & IIf(index = (Lts_Datos.Count - 1), " " & where, ",")
            'cadena += Lts_Columnas(index).ToString & " = " & (IIf(Lts_Datos(index).GetType().Name = "String" Or Lts_Datos(index).GetType().Name = "Char", "'", "")) & Lts_Datos(index).ToString & (IIf(Lts_Datos(index).GetType().Name = "String" Or Lts_Datos(index).GetType().Name = "Char", "'", "")) & IIf(index = (Lts_Datos.Count - 1), where, ",")
        Next
        comando = New SqlCommand(cadena, conexion)
        comando.ExecuteNonQuery()
    End Sub

    Public Sub Delete(conexion As SqlConnection, Tabla As String, nValor As Integer, where As String)
        Dim cadena As String = "update " & Tabla & " set "
        cadena += "Estado_Delete = " & nValor & " " & where
        'cadena += Lts_Columnas(index).ToString & " = " & (IIf(Lts_Datos(index).GetType().Name = "String" Or Lts_Datos(index).GetType().Name = "Char", "'", "")) & Lts_Datos(index).ToString & (IIf(Lts_Datos(index).GetType().Name = "String" Or Lts_Datos(index).GetType().Name = "Char", "'", "")) & IIf(index = (Lts_Datos.Count - 1), where, ",")
        comando = New SqlCommand(cadena, conexion)
        comando.ExecuteNonQuery()
    End Sub

    Public Sub CambiodeEstado(conexion As SqlConnection, nValor As String, where As String)
        Dim cadena As String = "update Factura set Estado = "
        cadena += nValor & " " & where
        'cadena += Lts_Columnas(index).ToString & " = " & (IIf(Lts_Datos(index).GetType().Name = "String" Or Lts_Datos(index).GetType().Name = "Char", "'", "")) & Lts_Datos(index).ToString & (IIf(Lts_Datos(index).GetType().Name = "String" Or Lts_Datos(index).GetType().Name = "Char", "'", "")) & IIf(index = (Lts_Datos.Count - 1), where, ",")
        comando = New SqlCommand(cadena, conexion)
        comando.ExecuteNonQuery()
    End Sub

    Public Function Read(conexion As SqlConnection, Tabla As String, Lts_Columnas As ArrayList, where As String) As DataTable
        Dim cadena As String = "Select "
        For index = 0 To (Lts_Columnas.Count - 1)
            cadena += Lts_Columnas(index).ToString & IIf(index = (Lts_Columnas.Count - 1), " ", ",")
        Next
        cadena += "From " & Tabla & " " & where
        comando = New SqlCommand(cadena, conexion)
        Dim adapter As New SqlDataAdapter(comando)
        Dim t As New DataTable
        adapter.Fill(t)
        Return t
    End Function
End Class
