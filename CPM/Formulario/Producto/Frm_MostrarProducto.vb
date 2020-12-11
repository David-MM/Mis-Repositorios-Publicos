Public Class Frm_MostrarProducto

    Public Overrides Sub Activos_Visibles()
        txtCodigo.ReadOnly = True
        txtNombre.ReadOnly = True
        txtDescripcion.ReadOnly = True
        spinnerISV.Visible = False
        spinnerPrecio.Visible = False
        btnCancelar.Visible = False
        btnGuardar.Visible = False
        txt_Isv.ReadOnly = True
        txt_Precio.ReadOnly = True
    End Sub

    Private Sub Frm_MostrarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Incio()
    End Sub
End Class
