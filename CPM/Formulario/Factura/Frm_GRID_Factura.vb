Public Class Frm_GRID_Factura
    Public Overrides Function Buscar(busca As String)
        Select Case Cb_Columnas.SelectedIndex
            Case 0
                Return MyBase.Buscar(" AND F.idFactura Like'%" & Txt_Filtrar.Text & "%'")
            Case 1
                Return MyBase.Buscar(" AND F.Fecha Like'%" & Txt_Filtrar.Text & "%'")
            Case 2
                Return MyBase.Buscar(" AND (SELECT C.RTN FROM Cliente as C WHERE C.idCliente=F.ClientesID) Like'%" & Txt_Filtrar.Text & "%'")
            Case 3
                Return MyBase.Buscar(" AND (SELECT C.R_Social FROM Cliente as C WHERE C.idCliente=F.ClientesID) Like'%" & Txt_Filtrar.Text & "%'")
            Case 4
                If (Txt_Filtrar.Text.ToLower.Substring(0, Txt_Filtrar.Text.Length).Contains("co")) Then
                    Return MyBase.Buscar(" AND Tipo Like'%C%'")
                ElseIf (Txt_Filtrar.Text.ToLower.Substring(0, Txt_Filtrar.Text.Length).Contains("cr")) Then
                    Return MyBase.Buscar(" AND Tipo like'%R%'")
                Else
                    Return MyBase.Buscar("")
                End If
            Case Else
                MsgBox("Error", MsgBoxStyle.Critical, "Switch-Cliente")
        End Select
    End Function

    Public Overrides Sub CrearInsert()
        If EstaAbierto("Nueva Factura") Then
        Else
            Dim Nuevo As New Frm_CrearFactura()
            Nuevo.MdiParent = Me.MdiParent
            Nuevo.Text = "Nueva Factura"
            Nuevo.PADRE = Me
            Nuevo.Show()
        End If
    End Sub

    Public Overrides Function Ver() As Integer
        MsgBox("Selecconaste. " & Tabla.CurrentRow.Cells(0).Value)
        If EstaAbierto("Ver Factura") Then
        Else
            Dim Nuevo As New Frm_MostrarFactura()
            Nuevo.MdiParent = Me.MdiParent
            Nuevo.Text = "Nueva Factura"
            Nuevo.PADRE = Me
            Nuevo.Id = Tabla.CurrentRow.Cells(0).Value
            Nuevo.Show()
        End If


    End Function

    Public Function EstaAbierto(Myform As String) As Boolean
        Dim objForm As Form
        Dim blnAbierto As Boolean = False
        For Each objForm In My.Application.OpenForms
            If (Trim(objForm.Text) = Trim(Myform)) Then
                objForm.BringToFront()
                blnAbierto = True
            End If
        Next
        Return blnAbierto
    End Function
    Public Sub Frm_GRID_Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
