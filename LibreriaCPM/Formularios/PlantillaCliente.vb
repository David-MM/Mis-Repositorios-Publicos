Public Class PlantillaCliente
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Len(Trim(txtClienteID.Text)) = 0 Then
            MsgBox("Ingrese un ID", MsgBoxStyle.Exclamation)
            txtClienteID.Focus()
        ElseIf IsNumeric(txtClienteID.Text) Then
            MsgBox("El Id debe ser un numero", MsgBoxStyle.Exclamation)
            txtClienteID.Focus()
        ElseIf Len(Trim(txtRTN.Text)) = 0 Then
            MsgBox("Ingrese el RTN", MsgBoxStyle.Exclamation)
            txtRTN.Focus()
        ElseIf IsNumeric(txtRTN.Text) Then
            MsgBox("El RTN debe ser un numero", MsgBoxStyle.Exclamation)
            txtRTN.Focus()
        ElseIf Len(Trim(txtNombre.Text)) = 0 Then
            MsgBox("Ingrese la razon social o nombre", MsgBoxStyle.Exclamation)
            txtNombre.Focus()
        ElseIf Len(Trim(txtDescuento.Text)) = 0 Then
            MsgBox("Ingrese el descuento", MsgBoxStyle.Exclamation)
            txtDescuento.Focus()
        ElseIf Len(Trim(txtCredito.Text)) = 0 Then
            MsgBox("Ingrese el credito limite del cliente", MsgBoxStyle.Exclamation)
            txtCredito.Focus()
        ElseIf IsNumeric(txtCredito.Text) Then
            MsgBox("El credito debe ser un numero", MsgBoxStyle.Exclamation)
            txtCredito.Focus()
        ElseIf Len(Trim(txtTelefono.Text)) = 0 Then
            MsgBox("Ingrese el numero de telefono del cliente", MsgBoxStyle.Exclamation)
            txtTelefono.Focus()
        ElseIf IsNumeric(txtTelefono.Text) Then
            MsgBox("El numero de telefono debe ser un numero", MsgBoxStyle.Exclamation)
            txtTelefono.Focus()
        ElseIf Len(Trim(txtCorreo.Text)) = 0 Then
            MsgBox("Ingrese el correo del cliente", MsgBoxStyle.Exclamation)
            txtCorreo.Focus()
        ElseIf Len(Trim(txtDireccion.Text)) = 0 Then
            MsgBox("Ingrese la direccion del cliente", MsgBoxStyle.Exclamation)
            txtDireccion.Focus()
        End If

    End Sub
End Class