Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports LibreriaCPM

Public Class Frm_GRID_Padre
    Private claseConexion As New dbConnect
    Private nametabla As String
    Private campo_where As String
    Private cuandoiniciar As String
    Private ListaColumnas As New ArrayList
    Private ListaCombo As New ArrayList
    Private factura As Boolean

    Public ReadOnly Property DATABASE As dbConnect
        Get
            Return claseConexion
        End Get
    End Property

    Public Property FACTURAS As Boolean
        Get
            Return factura
        End Get
        Set(value As Boolean)
            factura = value
        End Set
    End Property

    Public Property NOMBRETABLA As String
        Get
            Return nametabla
        End Get
        Set(value As String)
            nametabla = value
        End Set
    End Property
    Public Property ListCombo As ArrayList
        Get
            Return ListaCombo
        End Get
        Set(value As ArrayList)
            ListaCombo = value
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

    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        If factura Then
            'CambiarEstado("'A'", campo_where)
            MsgBox("En Proceso...")
        Else
            Eliminar(nametabla, 0, campo_where)
        End If
        CargarDatos()
    End Sub

    Private Sub Eliminar(ntabla As String, valor As Integer, campo_where As String)
        If Tabla.SelectedRows.Count = 0 Then
            MsgBox("Selecciona una fila para Eliminarla", MsgBoxStyle.Critical, "Warnig")
        Else
            Dim i = Tabla.CurrentRow.Cells(0).Value
            Dim x = MsgBox("¿Seguro que quieres eliminar este registo?", MsgBoxStyle.OkCancel, "**Warnig**")
            If (x.ToString() = "Cancel") Then ' Si Then la variable x devuelver el boton Cancelar
                'MsgBox("Registros no Eliminado.", MsgBoxStyle.Information, "Informacion")
                Return 'Retornaremos y no removeremos nada
            End If
            claseConexion.Delete(ntabla, valor, "where " & campo_where & " = " & i)
        End If
    End Sub

    Private Sub CambiarEstado(valor As String, campo_where As String)
        If Tabla.SelectedRows.Count = 0 Then
            MsgBox("Selecciona una fila para Eliminarla", MsgBoxStyle.Critical, "Warnig")
        Else
            Dim i = Tabla.CurrentRow.Cells(0).Value
            Dim x = MsgBox("¿Seguro que quieres eliminar esta factura?", MsgBoxStyle.OkCancel, "**Warnig**")
            If (x.ToString() = "Cancel") Then ' Si Then la variable x devuelver el boton Cancelar
                MsgBox("Registros no Eliminado.", MsgBoxStyle.Information, "Informacion")
                Return 'Retornaremos y no removeremos nada
            End If
            claseConexion.CambiodeEstado(valor, "where " & campo_where & " = " & i)
        End If
    End Sub

    Public Overridable Function Modificara() As Integer
        If Tabla.SelectedRows.Count = 0 Then
            MsgBox("Selecciona una fila para Modificarla.", MsgBoxStyle.Critical, "Warnig")
            Return 0
        Else
            Dim i = Tabla.CurrentRow.Cells(0).Value
            Dim x = MsgBox("¿Seguro que quieres modificar este registo?", MsgBoxStyle.OkCancel, "Warnig")
            If (x = 1) Then ' Si Then la variable x devuelver el boton Ok
                Return i 'Retornaremos un valor
            Else
                Return 0
            End If
        End If
    End Function

    Public Sub CargarDatos()
        Tabla.DataSource = claseConexion.Read(nametabla, ListaColumnas, "where " & cuandoiniciar)
    End Sub

    Public Function BuscarDatos(where As String) As DataTable
        Return claseConexion.Read(nametabla, ListaColumnas, "where " & where)
    End Function

    Private Sub Frm_GRID_Padre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        factura = False
        Cb_Columnas.DataSource = ListaCombo
        CargarDatos()
    End Sub
    Public Overridable Function Buscar(busca As String)
        Tabla.DataSource = claseConexion.Read(nametabla, ListaColumnas, "where " & cuandoiniciar & busca)
    End Function

    Private Sub Txt_Filtrar_TextChanged(sender As Object, e As EventArgs) Handles Txt_Filtrar.TextChanged
        Buscar(Txt_Filtrar.Text)
    End Sub

    Private Sub Btn_Crear_Click(sender As Object, e As EventArgs) Handles Btn_Crear.Click
        CrearInsert()
    End Sub

    Public Overridable Sub CrearInsert()

    End Sub


    Private Sub Btn_Ver_Click(sender As Object, e As EventArgs) Handles Btn_Ver.Click
        If Ver() = 0 Then
            'MsgBox("No puedes ver el detalle")
        End If
    End Sub

    Public Overridable Function Ver() As Integer
        If Tabla.SelectedRows.Count = 0 Then
            MsgBox("Selecciona una fila para Ver su Detalle.", MsgBoxStyle.Critical, "Warnig")
            Return 0
        Else
            Dim i = Tabla.CurrentRow.Cells(0).Value
            Return i 'Retornaremos un valor
        End If
    End Function

    Private Sub Btn_Modificar_Click(sender As Object, e As EventArgs) Handles Btn_Modificar.Click
        Modificara()
    End Sub
End Class