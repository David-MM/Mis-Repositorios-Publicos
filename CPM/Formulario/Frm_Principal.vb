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

    Private Sub PruebasEnElGridToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PruebasEnElGridToolStripMenuItem.Click
        Dim grid As New Frm_GRID_Producto()
        grid.MdiParent = Me
        grid.LISTA.Add("*")
        grid.NOMBRETABLA = "CPM.Produto"
        grid.CAMPODELETE = "idProducto"
        grid.WHERELOAD = "Estado_Delete=1"
        grid.Show()
    End Sub

    Private Sub Facturacion_Click(sender As Object, e As EventArgs) Handles Facturacion.Click
        Dim f As New Plantilla_Facturacion()
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub WindowsMenu_Click(sender As Object, e As EventArgs) Handles WindowsMenu.Click
        Dim grid As New Frm_GRID_Inventario()
        grid.Text = "Inventario"
        grid.Titulo.Text = "Inventario de Productos"
        grid.Botones.Visible = False
        grid.MdiParent = Me
        grid.Image.Image = CPM.My.Resources.Resources.inventario1
        grid.LISTA.Add("P.Codigo As 'Codigo Barra'")
        grid.LISTA.Add("P.Nombre As Producto")
        grid.LISTA.Add("I.Cantidad AS Existencia")
        grid.ListCombo.Add("Codigo de Barra")
        grid.ListCombo.Add("Nombre Producto")
        grid.NOMBRETABLA = "CPM.Inventario AS I INNER JOIN CPM.Produto AS P ON P.idProducto=I.idProducto"
        grid.CAMPODELETE = "I.idInventario"
        grid.WHERELOAD = "I.Estado_Delete=1"
        grid.Show()
    End Sub
End Class
