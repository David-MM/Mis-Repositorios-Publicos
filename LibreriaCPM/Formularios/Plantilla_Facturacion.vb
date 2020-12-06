Imports System.Windows.Forms

Public Class Plantilla_Facturacion
    Private claseConexion As New dbConnect
    Private ListaColumnas As ArrayList
    Private dt As DataTable
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ValidarInsercionProducto()
    End Sub

    Private Sub Plantilla_Facturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaColumnas = New ArrayList
        ListaColumnas.Add("IDcliente")
        ListaColumnas.Add("R_Social")
        LlenarCombo(cmbCli, claseConexion.Read("CPM.Cliente", ListaColumnas, "where Estado_Delete = 1 "))

        'Dim ListaColumnas2 As New ArrayList
        ListaColumnas.RemoveRange(0, ListaColumnas.Count)
        ListaColumnas.Add("IdProducto")
        ListaColumnas.Add("Codigo")
        LlenarCombo(cmbCodBarra, claseConexion.Read("CPM.Produto", ListaColumnas, "where Estado_Delete = 1 "))

    End Sub

#Region "Funciones herededas sobreescribibles"
    Public Overridable Function Limpiar()
        If (MessageBox.Show("Se borrará toda la data" & vbCrLf & "¿Desea limpiar?", "Limpiar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            cmbCli.Text = ""
            txtRTN.Text = ""
            cmbCodBarra.Text = ""
            cmbProducto.Text = ""
            spnCantidad.Value = 1
            spnPrecio.Value = 1
            txtSubtotal.Text = ""
            txtISV.Text = ""
            txtDesc.Text = ""
            txtTotal.Text = ""
            cmbCli.Focus()
        End If
    End Function

    Public Overridable Function LlenarCombo(cmb As ComboBox, dt As DataTable)
        cmb.DataSource = dt
        cmb.DisplayMember = dt.Columns(1).ColumnName
        cmb.ValueMember = dt.Columns(0).ColumnName
    End Function

    Public Overridable Function ValidarInsercionProducto()
        'Busca en todos los controles dentro de un grupo y valida no esten vacios 
        Dim Obj As Object
        Dim Validar As Boolean = True
        For Each Obj In Me.grpProducto.Controls
            If Obj.Tag = "Producto" And Trim(Obj.Text) = "" Then
                Validar = False
            End If
        Next
        If Validar Then
            'Agreagr al Grid
        Else
            MsgBox("Error datos en blanco")
        End If
    End Function
#End Region

#Region "Funciones Varias"
    Function valida() As Boolean
        'Esta funcion busca todos los controles del form y valida que esten llenos_
        'La propiedad TAG permite seleccionar solo X objetos 
        Dim Obj As Object
        For Each Obj In Me.Controls
            If Obj.Tag = "Producto" Then
                If Trim(Obj.Text) = "" Then
                    MessageBox.Show(Obj.GetType.Name)
                    Obj.SetFocus
                    valida = False
                    Exit For
                Else
                    valida = True
                End If
            End If
        Next
    End Function
#End Region

End Class