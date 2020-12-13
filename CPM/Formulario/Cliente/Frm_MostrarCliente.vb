Public Class Frm_MostrarCliente

    Public Overrides Sub Activos_Visibles()
        txtClienteID.ReadOnly = True
        txtNombre.ReadOnly = True
        txtRTN.ReadOnly = True
        N_Credito.Visible = False
        N_Descuento.Visible = False
        txtTelefono.ReadOnly = True
        txtDireccion.ReadOnly = True
        txtCorreo.ReadOnly = True
        Button1.Visible = False
        Button2.Visible = False
    End Sub

    Private Sub InicioVer(sender As Object, e As EventArgs) Handles MyBase.Load
        Incio()
    End Sub
End Class
