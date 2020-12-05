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
            cadena += (IIf(Lts_Datos(index).GetType().Name = "String" Or "Char", "'", "")) & Lts_Datos(index).ToString & (IIf(Lts_Datos(index).GetType().Name = "String" Or "Char", "'", "")) & IIf(index = (Lts_Datos.Count - 1), ")", ",")
            'cadena += (IIf(Lts_Datos(index).GetType().Name = "String" Or Lts_Datos(index).GetType().Name = "Char", "'", "")) & Lts_Datos(index).ToString & (IIf(Lts_Datos(index).GetType().Name = "String" Or Lts_Datos(index).GetType().Name = "Char", "'", "")) & IIf(index = (Lts_Datos.Count - 1), ")", ",")
        Next
        comando = New SqlCommand(cadena, conexion)
        comando.ExecuteNonQuery()
    End Sub

    Public Sub Update(conexion As SqlConnection, Tabla As String, Lts_Columnas As ArrayList, Lts_Datos As ArrayList, where As String)
        Dim cadena As String = "update " & Tabla & " set "
        For index = 0 To (Lts_Datos.Count - 1)
            cadena += Lts_Columnas(index).ToString & " = " & (IIf(Lts_Datos(index).GetType().Name = "String" Or "Char", "'", "")) & Lts_Datos(index).ToString & (IIf(Lts_Datos(index).GetType().Name = "String" Or "Char", "'", "")) & IIf(index = (Lts_Datos.Count - 1), where, ",")
            'cadena += Lts_Columnas(index).ToString & " = " & (IIf(Lts_Datos(index).GetType().Name = "String" Or Lts_Datos(index).GetType().Name = "Char", "'", "")) & Lts_Datos(index).ToString & (IIf(Lts_Datos(index).GetType().Name = "String" Or Lts_Datos(index).GetType().Name = "Char", "'", "")) & IIf(index = (Lts_Datos.Count - 1), where, ",")
        Next
        comando = New SqlCommand(cadena, conexion)
        comando.ExecuteNonQuery()
    End Sub

    Public Sub Delete(conexion As SqlConnection, Tabla As String, nValor As Boolean, where As String)
        Dim cadena As String = "update " & Tabla & " set "
        cadena += "Estado_Delete = " & nValor & " " & where
        'cadena += Lts_Columnas(index).ToString & " = " & (IIf(Lts_Datos(index).GetType().Name = "String" Or Lts_Datos(index).GetType().Name = "Char", "'", "")) & Lts_Datos(index).ToString & (IIf(Lts_Datos(index).GetType().Name = "String" Or Lts_Datos(index).GetType().Name = "Char", "'", "")) & IIf(index = (Lts_Datos.Count - 1), where, ",")
        comando = New SqlCommand(cadena, conexion)
        comando.ExecuteNonQuery()
    End Sub

    Public Sub Delete_F(conexion As SqlConnection, Tabla As String, nValor As Char, where As String)
        Dim cadena As String = "update " & Tabla & " set "
        cadena += "Estado = " & nValor & " " & where
        'cadena += Lts_Columnas(index).ToString & " = " & (IIf(Lts_Datos(index).GetType().Name = "String" Or Lts_Datos(index).GetType().Name = "Char", "'", "")) & Lts_Datos(index).ToString & (IIf(Lts_Datos(index).GetType().Name = "String" Or Lts_Datos(index).GetType().Name = "Char", "'", "")) & IIf(index = (Lts_Datos.Count - 1), where, ",")
        comando = New SqlCommand(cadena, conexion)
        comando.ExecuteNonQuery()
    End Sub

    Public Function Read(conexion As SqlConnection, ByVal nomfun As String, ByVal prm As List(Of SqlParameter)) As Object
        Dim cmd As New SqlCommand("SELECT " & nomfun, conexion)   'Para ejecutar "SELECT <nombrefuncion>
        Dim prm2 As New SqlParameter 'representa cualquier parametro
        cmd.CommandType = CommandType.Text
        For Each prm2 In prm 'se recorre lo parametro del list
            cmd.Parameters.Add(prm2) 'se agrega lo parametros al comando
        Next
        Dim resultado As Object = cmd.ExecuteScalar()
        Return resultado
    End Function
End Class
