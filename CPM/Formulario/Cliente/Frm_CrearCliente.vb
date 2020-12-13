Public Class Frm_CrearCliente
    Private father As Frm_GRID_Cliente
    Private claseConexion As New LibreriaCPM.dbConnect()

    Public Property PADRE As Frm_GRID_Cliente
        Get
            Return father
        End Get
        Set(value As Frm_GRID_Cliente)
            father = value
        End Set
    End Property

    Private Sub Frm_CrearCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Incio()
    End Sub

    Public Overrides Sub Insersion()
        Try
            claseConexion.Insert("Cliente", DATOS)
            father.CargarDatos()
            Me.Dispose()
        Catch ex As Exception
            MsgBox("Ahh manco, no podes insertar")
        End Try
    End Sub

    Public Overrides Sub Activos_Visibles()
        Label1.Visible = False
        txtClienteID.Visible = False
        Button3.Visible = False
        txtDescuento.Visible = False
        txtLimite.Visible = False
        'MyBase.Activos_Visibles()
    End Sub
End Class
