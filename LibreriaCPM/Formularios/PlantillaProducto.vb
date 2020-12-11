Imports System.Windows.Forms
Public Class PlantillaProducto
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Validaciones() Then
            LlenarDatos()
            Insersion()
        End If
    End Sub

    Public Overridable Sub Insersion()

    End Sub

    Private Sub LlenarDatos()
        Dates.Add("'" & txtCodigo.Text & "'")
        Dates.Add("'" & txtNombre.Text & "'")
        Dates.Add(spinnerPrecio.Value)
        Dates.Add(spinnerISV.Value / 100)
        Dates.Add("'" & txtDescripcion.Text & "'")
        Dates.Add(1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Public Sub Incio()
        Activos_Visibles()
        txtNombre.Select()
    End Sub

    Public Function Validacion_Vacias() As Boolean

        Dim chequeo As Boolean = True

        If Len(Trim(txtNombre.Text)) = 0 Then
            txtNombre.Select()
            lblNombre.ForeColor = Drawing.Color.Red
            chequeo = False
        Else
            lblNombre.ForeColor = Drawing.Color.Black
        End If

        If Len(Trim(txtDescripcion.Text)) = 0 Then
            txtDescripcion.Select()
            lblDescripcion.ForeColor = Drawing.Color.Red
            chequeo = False
        Else
            lblDescripcion.ForeColor = Drawing.Color.Black
        End If

        Return chequeo

    End Function

    Public Overridable Sub Activos_Visibles()

    End Sub

    Public Function Validaciones() As Boolean
        If Validacion_Vacias() Then
            If spinnerPrecio.Value > 0 And spinnerISV.Value >= 0 Then
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