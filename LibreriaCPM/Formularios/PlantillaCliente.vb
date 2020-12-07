Imports System.Windows.Forms

Public Class PlantillaCliente
    Private Dates As New ArrayList
    Private Table As String

    Public Property TABLA As String
        Get
            Return Table
        End Get
        Set(value As String)
            Table = value
        End Set
    End Property

    Public Property DATOS As ArrayList
        Get
            Return Dates
        End Get
        Set(value As ArrayList)
            Dates = value
        End Set
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Validaciones() Then
            LlenarDatos()
            Insersion()
        End If
    End Sub

    Public Overridable Sub Insersion()

    End Sub

    Private Sub LlenarDatos()
        Dates.Add("'" & txtRTN.Text & "'")
        Dates.Add("'" & txtNombre.Text & "'")
        Dates.Add(N_Descuento.Value / 100)
        Dates.Add(N_Credito.Value)
        Dates.Add("'" & txtTelefono.Text & "'")
        Dates.Add("'" & txtCorreo.Text & "'")
        Dates.Add("'" & txtDireccion.Text & "'")
        Dates.Add(1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Public Sub Incio()
        Activos_Visibles()
        txtRTN.Select()
    End Sub

    Public Function Validacion_Vacias() As Boolean

        Dim chequeo As Boolean = True

        If Len(Trim(txtRTN.Text)) = 0 Then
            txtRTN.Select()
            Label2.ForeColor = Drawing.Color.Red
            chequeo = False
        Else
            Label2.ForeColor = Drawing.Color.Black
        End If

        If Len(Trim(txtNombre.Text)) = 0 Then
            txtNombre.Select()
            Label3.ForeColor = Drawing.Color.Red
            chequeo = False
        Else
            Label3.ForeColor = Drawing.Color.Black
        End If

        If Len(Trim(txtTelefono.Text)) = 0 Then
            txtTelefono.Select()
            Label8.ForeColor = Drawing.Color.Red
            chequeo = False
        Else
            Label8.ForeColor = Drawing.Color.Black
        End If

        If Len(Trim(txtCorreo.Text)) = 0 Then
            txtCorreo.Select()
            Label7.ForeColor = Drawing.Color.Red
            chequeo = False
        Else
            Label7.ForeColor = Drawing.Color.Black
        End If

        If Len(Trim(txtDireccion.Text)) = 0 Then
            txtDireccion.Select()
            Label6.ForeColor = Drawing.Color.Red
            chequeo = False
        Else
            Label6.ForeColor = Drawing.Color.Black
        End If

        Return chequeo

    End Function

    Public Overridable Sub Activos_Visibles()

    End Sub

    Public Function Validaciones() As Boolean
        If Validacion_Vacias() Then
            If N_Descuento.Value <= 70 And N_Descuento.Value >= 0 And N_Credito.Value >= 0 And N_Credito.Value <= 10000 Then
                Return True
            Else
                Return False
            End If
        Else
            MsgBox("Imposible Guardar los Datos.\nTiene Campos Vacios.", MsgBoxStyle.Exclamation, "Warnig")
            Return False
        End If
    End Function

End Class