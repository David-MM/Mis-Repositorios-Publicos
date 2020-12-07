Imports System.Windows.Forms

Public Class Plantilla_Facturacion
    Private claseConexion As New dbConnect
    Private ListaColumnas As ArrayList
    Private dt As DataTable
    Public DescuentoCli As Double
    Public FactN As String

#Region "Eventos de Formulario"
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar1.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar1.Click
        Limpiar()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        ValidarInsercionProducto()
    End Sub

    Private Sub Plantilla_Facturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarDatos()
    End Sub

    Private Sub cmbCodBarra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCodBarra1.SelectedIndexChanged
        SeleccionarCombo(cmbProducto1, cmbCodBarra1)
    End Sub

    Private Sub cmbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProducto1.SelectedIndexChanged
        SeleccionarCombo(cmbCodBarra1, cmbProducto1)
    End Sub

    Private Sub cmbCli_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCli1.SelectedIndexChanged
        If Not (cmbCli1.SelectedValue.ToString = "System.Data.DataRowView") And Not (cmbCli1.SelectedValue.ToString = "0") Then
            ListaColumnas.RemoveRange(0, ListaColumnas.Count)
            ListaColumnas.Add("RTN")
            txtRTN1.Text = claseConexion.Read("Cliente", ListaColumnas, "where idcliente=" & CStr(cmbCli1.SelectedValue)).Rows(0)(0).ToString
        End If
    End Sub
#End Region

#Region "Funciones herededas sobreescribibles"
    Public Overridable Function Limpiar()
        If (MessageBox.Show("Se borrará toda la data" & vbCrLf & "¿Desea limpiar?", "Limpiar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            cmbCli1.Text = ""
            txtRTN1.Text = ""
            cmbCodBarra1.Text = ""
            cmbProducto1.Text = ""
            spnCantidad1.Value = spnCantidad1.Minimum
            spnPrecio1.Value = spnPrecio1.Minimum
            txtSubtotal1.Text = ""
            txtISV1.Text = ""
            txtDesc1.Text = ""
            txtTotal1.Text = ""
            cmbCli1.Focus()
        End If
    End Function

    Public Overridable Function LlenarCombo(cmb As ComboBox, dt As DataTable)
        cmb.DataSource = dt
        cmb.DisplayMember = dt.Columns(1).ColumnName
        cmb.ValueMember = dt.Columns(0).ColumnName
    End Function

    Public Overridable Function ValidarInsercionProducto()
        Dim Validar As Boolean = True
        Dim Subtotal As Double = 0
        Dim Impu As Double = 0
        Dim Descuento As Double = 0
        If Datos.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In Datos.Rows
                If Not Fila Is Nothing Then
                    Validar = IIf(Fila.Cells(1).Value = cmbCodBarra1.Text, False, Validar)
                End If
            Next
        End If
        If (Validar) Then
            ListaColumnas.RemoveRange(0, ListaColumnas.Count)
            ListaColumnas.Add("Descripcion")
            ListaColumnas.Add("ISV_Sugerido")
            Datos.Rows.Add(cmbCodBarra1.Text, cmbProducto1.Text, claseConexion.Read("Producto", ListaColumnas, " where idproducto=" & cmbCodBarra1.SelectedValue).Rows(0)(0).ToString,
                           spnCantidad1.Value, spnPrecio1.Value,
                           claseConexion.Read("Producto", ListaColumnas, " where idproducto=" & cmbCodBarra1.SelectedValue).Rows(0)(1).ToString * spnCantidad1.Value * spnPrecio1.Value,
                           claseConexion.Read("Producto", ListaColumnas, " where idproducto=" & cmbCodBarra1.SelectedValue).Rows(0)(1).ToString * spnCantidad1.Value * spnPrecio1.Value + spnCantidad1.Value * spnPrecio1.Value)

            For Each Fila As DataGridViewRow In Datos.Rows
                If Not Fila Is Nothing Then
                    Subtotal += Convert.ToDouble(Fila.Cells(4).Value) * Convert.ToDouble(Fila.Cells(3).Value)
                    Impu += Convert.ToDouble(Fila.Cells(5).Value)
                End If
            Next
            ListaColumnas.RemoveRange(0, ListaColumnas.Count)
            ListaColumnas.Add("Descuento_Sugerido")
            Descuento += Subtotal * claseConexion.Read("Cliente", ListaColumnas, "Where idCliente=" & cmbCli1.SelectedValue).Rows(0)(0).ToString
            DescuentoCli = claseConexion.Read("Cliente", ListaColumnas, "Where idCliente=" & cmbCli1.SelectedValue).Rows(0)(0).ToString
            txtSubtotal1.Text = Subtotal
            txtISV1.Text = Impu
            txtDesc1.Text = Descuento
            txtTotal1.Text = Subtotal + Impu - Descuento
        Else
            MessageBox.Show("Articulo ya añadido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Function

    Public Overridable Function LlenarDatos()
        'Numero de Factura
        ListaColumnas = New ArrayList
        ListaColumnas.Add("max(idFactura)+1 as campo")
        FactN = claseConexion.Read("Factura", ListaColumnas, "").Rows(0)(0).ToString
        lblIDFact1.Text = "Factura No. " & claseConexion.Read("Factura", ListaColumnas, "").Rows(0)(0).ToString

        'Numero de Factura
        lblFecha1.Text = "Fecha " & DateTime.Now.ToShortDateString

        'RTN
        ListaColumnas.RemoveRange(0, ListaColumnas.Count)
        ListaColumnas.Add("IDcliente")
        ListaColumnas.Add("R_Social")
        LlenarCombo(cmbCli1, claseConexion.Read("Cliente", ListaColumnas, "where Estado_Delete = 1 order by R_Social"))
        cmbCli1.SelectedIndex = 1
        cmbCli1.SelectedIndex = 0
        cmbPago1.SelectedIndex = 1

        ListaColumnas.RemoveRange(0, ListaColumnas.Count)
        ListaColumnas.Add("IdProducto")
        ListaColumnas.Add("Codigo")
        LlenarCombo(cmbCodBarra1, claseConexion.Read("Producto", ListaColumnas, "where Estado_Delete = 1"))

        ListaColumnas.RemoveRange(0, ListaColumnas.Count)
        ListaColumnas.Add("IdProducto")
        ListaColumnas.Add("Nombre")
        LlenarCombo(cmbProducto1, claseConexion.Read("Producto", ListaColumnas, "where Estado_Delete = 1"))
    End Function

    Public Overridable Function SeleccionarCombo(cmbC As ComboBox, cmb As ComboBox)
        If cmbC.Items.Count > 0 And cmb.Items.Count > 0 Then
            cmbC.SelectedIndex = cmb.SelectedIndex

            ListaColumnas.RemoveRange(0, ListaColumnas.Count)
            ListaColumnas.Add("Cantidad")
            spnCantidad1.Maximum = claseConexion.Read("Inventario", ListaColumnas, "where idproducto=" & CStr(cmbCodBarra1.SelectedValue)).Rows(0)(0).ToString

            ListaColumnas.RemoveRange(0, ListaColumnas.Count)
            ListaColumnas.Add("P_Sugerido")
            spnPrecio1.Minimum = claseConexion.Read("Producto", ListaColumnas, "where idproducto=" & CStr(cmbCodBarra1.SelectedValue)).Rows(0)(0).ToString
            spnPrecio1.Value = spnPrecio1.Minimum
        End If
    End Function

    Public Overridable Function Guardar()
        'Cabecera
        ListaColumnas.RemoveRange(0, ListaColumnas.Count)
        ListaColumnas.Add("1") 'Pendiente
        ListaColumnas.Add("'" & DateTime.Now & "'")
        ListaColumnas.Add(cmbCli1.SelectedValue)
        ListaColumnas.Add(DescuentoCli)
        ListaColumnas.Add(IIf(cmbPago1.SelectedIndex = 0, "'R'", "'C'"))
        ListaColumnas.Add(IIf(cmbPago1.SelectedIndex = 0, "'G'", "'P'"))

        claseConexion.Insert("Factura ", ListaColumnas)

        'Detalle
        For Each Fila As DataGridViewRow In Datos.Rows
            If Not Fila Is Nothing Then
                ListaColumnas.RemoveRange(0, ListaColumnas.Count)
                ListaColumnas.Add(FactN)    'Pendiente
                Dim A As New ArrayList
                A.Add("idProducto")
                A.Add("ISV_Sugerido")
                ListaColumnas.Add(claseConexion.Read("Producto", A, "where Codigo='" & Fila.Cells(0).Value & "'").Rows(0)(0).ToString)
                ListaColumnas.Add(Fila.Cells(4).Value)
                ListaColumnas.Add(Fila.Cells(5).Value)
                ListaColumnas.Add(claseConexion.Read("Producto", A, "where Codigo='" & Fila.Cells(0).Value & "'").Rows(0)(1).ToString)

                claseConexion.Insert("FacturaDetalle ", ListaColumnas)
            End If
        Next
        MessageBox.Show("Datos almacenados con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Datos.Rows.Clear()
        LlenarDatos()
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

    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar1.Click
        Guardar()
    End Sub
#End Region

End Class