Public Class Frm_MostrarProducto

    Public Overrides Sub Activos_Visibles()
        txtCodigo.ReadOnly = True
        txtNombre.ReadOnly = True
        txtDescripcion.ReadOnly = True
        spinnerISV.ReadOnly = True
        spinnerPrecio.ReadOnly = True
        btnCancelar.Visible = False
        btnGuardar.Visible = False
    End Sub

    Private Sub Frm_MostrarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Incio()
    End Sub
End Class
