Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class GRID
    Private claseConexion As dbConnect
    Private nametabla As String
    Private campo_where As String
    Private cuandoiniciar As String
    Private ListaColumnas As ArrayList

    Public Sub New(db As dbConnect)
        claseConexion = db
        ListaColumnas = New ArrayList()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public ReadOnly Property DATABASE As dbConnect
        Get
            Return claseConexion
        End Get
    End Property

    Public Property NOMBRETABLA As String
        Get
            Return nametabla
        End Get
        Set(value As String)
            nametabla = value
        End Set
    End Property

    Public Property CAMPODELETE As String
        Get
            Return campo_where
        End Get
        Set(value As String)
            campo_where = value
        End Set
    End Property

    Public Property WHERELOAD As String
        Get
            Return cuandoiniciar
        End Get
        Set(value As String)
            cuandoiniciar = value
        End Set
    End Property

    Public Property LISTA As ArrayList 'Por esta propiedad le pasaremos cuales son las listas de columnas a usar
        Get
            Return ListaColumnas
        End Get
        Set(value As ArrayList)
            ListaColumnas = value
        End Set
    End Property

    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        Me.Dispose()
    End Sub

    Public Overridable Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        Eliminar(nametabla, 0, campo_where)
        CargarDatos()
    End Sub

    Private Sub Eliminar(ntabla As String, valor As Integer, campo_where As String)
        If Tabla.SelectedRows.Count = 0 Then
            MsgBox("Selecciona una fila para Eliminarla", MsgBoxStyle.Critical, "Warnig")
        Else
            Dim i = Tabla.CurrentRow.Cells(0).Value
            Dim x = MsgBox("¿Seguro que quieres eliminar este registo?", MsgBoxStyle.Question, "Warnig")
            If (x.ToString() = "Cancel") Then ' Si Then la variable x devuelver el boton Cancelar
                MsgBox("Registros no Eliminado.", MsgBoxStyle.Information, "Informacion")
                Return 'Retornaremos y no removeremos nada
            End If
            claseConexion.Delete(claseConexion.ConexionSQLServer, ntabla, valor, "where " & campo_where & " = " & i)
        End If
    End Sub

    Public Overridable Sub Btn_Crear_Click(sender As Object, e As EventArgs) Handles Btn_Crear.Click

    End Sub

    Public Overridable Sub Btn_Modificar_Click(sender As Object, e As EventArgs) Handles Btn_Modificar.Click

    End Sub

    Public Function Modificara() As Integer
        If Tabla.SelectedRows.Count = 0 Then
            MsgBox("Selecciona una fila para Modificarla.", MsgBoxStyle.Critical, "Warnig")
            Return 0
        Else
            Dim i = Tabla.CurrentRow.Cells(0).Value
            Dim x = MsgBox("¿Seguro que quieres modificar este registo?", MsgBoxStyle.Question, "Warnig")
            If (x.ToString() = "OK") Then ' Si Then la variable x devuelver el boton Ok
                Return i 'Retornaremos un valor
            Else
                Return 0
            End If
        End If
    End Function

    Public Overridable Sub Btn_Ver_Click(sender As Object, e As EventArgs) Handles Btn_Ver.Click

    End Sub

    Private Sub CargarInterfaz(sender As Object, e As EventArgs) Handles MyBase.Load
        Cb_Columnas.DataSource = ListaColumnas
        CargarDatos()
    End Sub

    Public Sub CargarDatos()
        Tabla.DataSource = claseConexion.Read(claseConexion.ConexionSQLServer, nametabla, ListaColumnas, "where Estado_Delete = 1 " & cuandoiniciar)
    End Sub
End Class