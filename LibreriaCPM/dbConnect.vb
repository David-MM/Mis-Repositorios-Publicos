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
    Function Conectar()
        Try
            'Dim url = "Server=" & "localhost" & "; DataBase=" & "CPM" & "; Integrated Security = True"
            Dim url = "Server= 192.168.0.57; DataBase=HCF; UID=ExportacionesUser; pwd=aZLjIilAON" 'Server
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
        Return conexion
    End Function
    Public Sub Insert(TablaColumnas As String, Lts_Datos As ArrayList)
        Dim cadena As String = "insert into " & TablaColumnas & " values ("
        For index = 0 To (Lts_Datos.Count - 1)
            cadena += Lts_Datos(index).ToString & IIf(index = (Lts_Datos.Count - 1), ")", ",")
        Next
        comando = New SqlCommand(cadena, Conectar)
        comando.ExecuteNonQuery()
    End Sub
    Public Sub Update(Tabla As String, Lts_Columnas As ArrayList, Lts_Datos As ArrayList, where As String)
        Dim cadena As String = "update " & Tabla & " set "
        For index = 0 To (Lts_Datos.Count - 1)
            cadena += Lts_Columnas(index).ToString & " = " & Lts_Datos(index).ToString & IIf(index = (Lts_Datos.Count - 1), " " & where, ",")
        Next
        comando = New SqlCommand(cadena, Conectar)
        comando.ExecuteNonQuery()
    End Sub
    Public Sub Delete(Tabla As String, nValor As Integer, where As String)
        Dim cadena As String = "update " & Tabla & " set "
        cadena += "Estado_Delete = " & nValor & " " & where
        comando = New SqlCommand(cadena, Conectar)
        comando.ExecuteNonQuery()
    End Sub
    Public Sub CambiodeEstado(nValor As String, where As String)
        Dim cadena As String = "update Factura set Estado = "
        cadena += nValor & " " & where
        comando = New SqlCommand(cadena, Conectar)
        comando.ExecuteNonQuery()
    End Sub
    Public Function Read(Tabla As String, Lts_Columnas As ArrayList, where As String) As DataTable
        Dim cadena As String = "Select "
        For index = 0 To (Lts_Columnas.Count - 1)
            cadena += Lts_Columnas(index).ToString & IIf(index = (Lts_Columnas.Count - 1), " ", ",")
        Next
        cadena += "From " & Tabla & " " & where
        comando = New SqlCommand(cadena, Conectar)
        Dim adapter As New SqlDataAdapter(comando)
        Dim t As New DataTable
        adapter.Fill(t)
        Return t
    End Function
End Class
