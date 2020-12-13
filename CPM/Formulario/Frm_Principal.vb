Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports LibreriaCPM
Imports System.IO

Public Class Frm_Principal

    Private cnx As SqlConnection
    Private db As New dbConnect()

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub


    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub PruebasEnElGridToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim grid As New Frm_GRID_Producto()
        grid.MdiParent = Me
        grid.LISTA.Add("*")
        grid.NOMBRETABLA = "Produto"
        grid.CAMPODELETE = "idProducto"
        grid.WHERELOAD = "Estado_Delete=1"
        grid.Show()
    End Sub

    Private Sub Facturacion_Click(sender As Object, e As EventArgs) Handles Facturacion.Click
        Dim grid As Frm_GRID_Factura
        If EstaAbierto("Factura") Then
        Else
            grid = New Frm_GRID_Factura()
            grid.Image.Image = CPM.My.Resources.factura
            grid.Text = "Factura"
            grid.Titulo.Text = "Listado de Facturas"
            grid.MdiParent = Me
            grid.LISTA.Add("F.idFactura As '# Factura'")
            grid.LISTA.Add("F.Fecha")
            grid.LISTA.Add("(SELECT C.RTN FROM Cliente as C WHERE C.idCliente=F.ClientesID) AS RTN")
            grid.LISTA.Add("(SELECT C.R_Social FROM Cliente as C WHERE C.idCliente=F.ClientesID) AS Cliente")
            grid.LISTA.Add("(SELECT ROUND(sum(FD.Precio*FD.Cantidad),2) FROM FacturaDetalle AS FD WHERE F.idFactura=FD.FacturaID) as SubTotal")
            grid.LISTA.Add("(SELECT ROUND(sum((FD.Precio*FD.Cantidad)*FD.Isv),2) FROM FacturaDetalle AS FD WHERE F.idFactura=FD.FacturaID) as ISV")
            grid.LISTA.Add("(F.Descuento)*(SELECT ROUND(sum(FD.Precio*FD.Cantidad),2) FROM FacturaDetalle AS FD WHERE F.idFactura=FD.FacturaID) as Descuento")
            grid.LISTA.Add("(SELECT ROUND(sum(FD.Cantidad*FD.Precio) +sum(FD.Cantidad*FD.Precio*FD.Isv)-sum(FD.Cantidad*FD.Precio)*F.Descuento,2) FROM FacturaDetalle AS FD WHERE F.idFactura=FD.FacturaID) as Total")
            grid.LISTA.Add("(case when Tipo='C' then 'Contado' when Tipo='R' then 'Credito' end) as Tipo")

            grid.ListCombo.Add("# Factura")
            grid.ListCombo.Add("Fecha")
            grid.ListCombo.Add("RTN")
            grid.ListCombo.Add("Cliente")
            grid.ListCombo.Add("Tipo")
            grid.NOMBRETABLA = "Factura AS F"
            grid.WHERELOAD = " F.Estado <> 'A'"
            grid.Btn_Modificar.Visible = False
            grid.Btn_Eliminar.Text = "Anular"
            grid.CAMPODELETE = "idFactura"
            grid.Show()
            grid.FACTURAS = True
        End If
    End Sub

    Private Sub CrearFacturasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CrearFacturasToolStripMenuItem1.Click
        Dim grid As Frm_GRID_Cliente
        If EstaAbierto("Clientes") Then
        Else
            grid = New Frm_GRID_Cliente()
            grid.Text = "Clientes"
            grid.Titulo.Text = "Listado de Clientes"
            grid.Image.Image = CPM.My.Resources.Clientes2version2
            grid.MdiParent = Me
            grid.LISTA.Add("idCliente As '# Cliente'")
            grid.LISTA.Add("RTN")
            grid.LISTA.Add("R_Social As Nombre")
            grid.LISTA.Add("Descuento_Sugerido As Descuento")
            grid.LISTA.Add("L_Credito As 'Limite-Credito'")
            grid.LISTA.Add("Telefono")
            grid.LISTA.Add("E_Mail")
            grid.LISTA.Add("Direccion")
            grid.ListCombo.Add("# Cliente")
            grid.ListCombo.Add("RTN")
            grid.ListCombo.Add("Nombre")
            grid.ListCombo.Add("Descuento")
            grid.ListCombo.Add("Limite-Credito")
            grid.ListCombo.Add("Telefono")
            grid.ListCombo.Add("E_Mail")
            grid.ListCombo.Add("Direccion")
            grid.NOMBRETABLA = "Cliente"
            grid.CAMPODELETE = "idCliente"
            grid.WHERELOAD = "Estado_Delete=1"
            grid.Show()
        End If
    End Sub

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

    Private Sub Inicio_Inventario(sender As Object, e As EventArgs) Handles InventarioMenuItem.Click
        Dim grid As Frm_GRID_Inventario
        If EstaAbierto("Inventario") Then
        Else
            grid = New Frm_GRID_Inventario()
            grid.Text = "Inventario"
            grid.Titulo.Text = "Inventario de Productos"
            grid.Btn_Crear.Visible = False
            grid.Btn_Eliminar.Visible = False
            grid.Btn_Ver.Visible = False
            grid.Btn_Modificar.Text = "Aumentar Existencias"
            Dim size As Size
            size.Height = 70
            size.Width = 176
            grid.Btn_Modificar.Size = size
            grid.MdiParent = Me
            grid.Image.Image = CPM.My.Resources.Resources.inventario
            grid.LISTA.Add("I.idProducto As '#'")
            grid.LISTA.Add("P.Codigo As 'Codigo Barra'")
            grid.LISTA.Add("P.Nombre As Producto")
            grid.LISTA.Add("I.Cantidad AS Existencia")
            grid.ListCombo.Add("Codigo de Barra")
            grid.ListCombo.Add("Nombre Producto")
            grid.NOMBRETABLA = "Inventario AS I INNER JOIN Producto AS P ON P.idProducto=I.idProducto"
            grid.CAMPODELETE = "I.idInventario"
            grid.WHERELOAD = "I.Estado_Delete=1"
            grid.Show()
        End If
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        Dim grid As Frm_GRID_Producto
        If EstaAbierto("Productos") Then
        Else
            grid = New Frm_GRID_Producto()
            grid.Text = "Productos"
            grid.Titulo.Text = "Listado de Producto"
            grid.Image.Image = CPM.My.Resources.paquete
            grid.MdiParent = Me
            grid.LISTA.Add("idProducto As '#'")
            grid.LISTA.Add("Codigo As '# Codigo'")
            grid.LISTA.Add("Nombre")
            grid.LISTA.Add("P_Sugerido As Precio")
            grid.LISTA.Add("ISV_Sugerido As ISV")
            grid.LISTA.Add("Descripcion")
            grid.ListCombo.Add("# Codigo")
            grid.ListCombo.Add("Nombre")
            grid.ListCombo.Add("Precio")
            grid.ListCombo.Add("ISV")
            grid.ListCombo.Add("Descripcion")
            grid.NOMBRETABLA = "Producto"
            grid.CAMPODELETE = "idProducto"
            grid.WHERELOAD = "Estado_Delete=1"
            grid.Show()
        End If
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        Dim rptCliente As Frm_ReporteCliente
        If EstaAbierto("Reporte General") Then
        Else
            rptCliente = New Frm_ReporteCliente()
            Dim Reporte As New RPT_Cliente
            rptCliente.Text = "Reporte General"
            rptCliente.ReportePrincipal.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            rptCliente.ReportePrincipal.ReportSource = Reporte
            rptCliente.Show()
        End If
    End Sub

    Private Sub ProductoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem1.Click
        Dim rptCliente As Frm_ReporteProducto
        If EstaAbierto("Reporte General Producto") Then
        Else
            rptCliente = New Frm_ReporteProducto
            Dim Reporte As New RPT_Producto
            rptCliente.Text = "Reporte General Producto"
            rptCliente.ReportePrincipal.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            rptCliente.ReportePrincipal.ReportSource = Reporte
            rptCliente.Show()
        End If
    End Sub
End Class
