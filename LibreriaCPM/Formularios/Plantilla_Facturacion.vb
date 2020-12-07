Imports System.Windows.Forms

Public Class Plantilla_Facturacion
    Private claseConexion As New dbConnect
    Private ListaColumnas As ArrayList
    Private dt As DataTable
    Public DescuentoCli As Double
    Public FactN As String

#Region "Eventos de Formulario"
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
        Visibles_Activos()
        LlenarDatos()
    End Sub

    Private Sub cmbCodBarra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCodBarra.SelectedIndexChanged
        SeleccionarCombo(cmbProducto, cmbCodBarra)
    End Sub

    Private Sub cmbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProducto.SelectedIndexChanged
        SeleccionarCombo(cmbCodBarra, cmbProducto)
    End Sub

    Private Sub cmbCli_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCli.SelectedIndexChanged
        If Not (cmbCli.SelectedValue.ToString = "System.Data.DataRowView") And Not (cmbCli.SelectedValue.ToString = "0") Then
            ListaColumnas.RemoveRange(0, ListaColumnas.Count)
            ListaColumnas.Add("RTN")
            ListaColumnas.Add("Descuento_Sugerido")
            txtRTN.Text = claseConexion.Read("Cliente", ListaColumnas, "where idcliente=" & CStr(cmbCli.SelectedValue)).Rows(0)(0).ToString
            DescuentoCli = claseConexion.Read("Cliente", ListaColumnas, "Where idCliente=" & cmbCli.SelectedValue).Rows(0)(1).ToString
            CalcularResultados()
        End If
    End Sub
#End Region

#Region "Funciones herededas sobreescribibles"
    Public Overridable Function Limpiar()
        If (MessageBox.Show("Se borrará toda la data" & vbCrLf & "¿Desea limpiar?", "Limpiar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            cmbCli.Text = ""
            txtRTN.Text = ""
            cmbCodBarra.Text = ""
            cmbProducto.Text = ""
            spnCantidad.Value = spnCantidad.Minimum
            spnPrecio.Value = spnPrecio.Minimum
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
        Dim Validar As Boolean = True
        'Dim Subtotal As Double = 0
        'Dim Impu As Double = 0
        'Dim Descuento As Double = 0
        If Datos.Rows.Count > 0 Then 'Recorre el Grid y compara si el codigo ya esta agregado
            For Each Fila As DataGridViewRow In Datos.Rows
                If Not Fila Is Nothing Then
                    Validar = IIf(Fila.Cells(0).Value = cmbCodBarra.Text, False, Validar)
                End If
            Next
        End If
        If (Validar) Then
            ListaColumnas.RemoveRange(0, ListaColumnas.Count)
            ListaColumnas.Add("Descripcion")
            ListaColumnas.Add("ISV_Sugerido")
            Datos.Rows.Add(cmbCodBarra.Text, cmbProducto.Text, claseConexion.Read("Producto", ListaColumnas, " where idproducto=" & cmbCodBarra.SelectedValue).Rows(0)(0).ToString,
                           spnCantidad.Value, spnPrecio.Value,
                           claseConexion.Read("Producto", ListaColumnas, " where idproducto=" & cmbCodBarra.SelectedValue).Rows(0)(1).ToString * spnCantidad.Value * spnPrecio.Value,
                           claseConexion.Read("Producto", ListaColumnas, " where idproducto=" & cmbCodBarra.SelectedValue).Rows(0)(1).ToString * spnCantidad.Value * spnPrecio.Value + spnCantidad.Value * spnPrecio.Value)

            'For Each Fila As DataGridViewRow In Datos.Rows
            '    If Not Fila Is Nothing Then
            '        Subtotal += Convert.ToDouble(Fila.Cells(4).Value) * Convert.ToDouble(Fila.Cells(3).Value)
            '        Impu += Convert.ToDouble(Fila.Cells(5).Value)
            '    End If
            'Next
            ''ListaColumnas.RemoveRange(0, ListaColumnas.Count)
            ''ListaColumnas.Add("Descuento_Sugerido")
            'Descuento += Subtotal * DescuentoCli 'claseConexion.Read("Cliente", ListaColumnas, "Where idCliente=" & cmbCli.SelectedValue).Rows(0)(0).ToString
            ''DescuentoCli = claseConexion.Read("Cliente", ListaColumnas, "Where idCliente=" & cmbCli.SelectedValue).Rows(0)(0).ToString
            'txtSubtotal.Text = Subtotal
            'txtISV.Text = Impu
            'txtDesc.Text = Descuento
            'txtTotal.Text = Subtotal + Impu - Descuento
            CalcularResultados()
        Else
            MessageBox.Show("Articulo ya añadido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Function

    Public Overridable Function LlenarDatos()
        'Numero de Factura
        ListaColumnas = New ArrayList
        ListaColumnas.Add("max(idFactura)+1 as campo")
        FactN = claseConexion.Read("Factura", ListaColumnas, "").Rows(0)(0).ToString
        lblIDFact.Text = "Factura No. " & claseConexion.Read("Factura", ListaColumnas, "").Rows(0)(0).ToString

        'Numero de Factura
        lblFecha.Text = "Fecha " & DateTime.Now.ToShortDateString

        'RTN
        ListaColumnas.RemoveRange(0, ListaColumnas.Count)
        ListaColumnas.Add("IDcliente")
        ListaColumnas.Add("R_Social")
        LlenarCombo(cmbCli, claseConexion.Read("Cliente", ListaColumnas, "where Estado_Delete = 1 order by R_Social"))
        cmbCli.SelectedIndex = 1
        cmbCli.SelectedIndex = 0
        cmbPago.SelectedIndex = 1

        ListaColumnas.RemoveRange(0, ListaColumnas.Count)
        ListaColumnas.Add("IdProducto")
        ListaColumnas.Add("Codigo")
        LlenarCombo(cmbCodBarra, claseConexion.Read("Producto", ListaColumnas, "where Estado_Delete = 1"))

        ListaColumnas.RemoveRange(0, ListaColumnas.Count)
        ListaColumnas.Add("IdProducto")
        ListaColumnas.Add("Nombre")
        LlenarCombo(cmbProducto, claseConexion.Read("Producto", ListaColumnas, "where Estado_Delete = 1"))
    End Function

    Public Overridable Sub ActualizarTabla()

    End Sub

    Public Overridable Sub Visibles_Activos()

    End Sub

    Public Overridable Function SeleccionarCombo(cmbC As ComboBox, cmb As ComboBox)
        If cmbC.Items.Count > 0 And cmb.Items.Count > 0 Then
            cmbC.SelectedIndex = cmb.SelectedIndex

            ListaColumnas.RemoveRange(0, ListaColumnas.Count)
            ListaColumnas.Add("Cantidad")
            spnCantidad.Maximum = claseConexion.Read("Inventario", ListaColumnas, "where idproducto=" & CStr(cmbCodBarra.SelectedValue)).Rows(0)(0).ToString

            ListaColumnas.RemoveRange(0, ListaColumnas.Count)
            ListaColumnas.Add("P_Sugerido")
            spnPrecio.Minimum = claseConexion.Read("Producto", ListaColumnas, "where idproducto=" & CStr(cmbCodBarra.SelectedValue)).Rows(0)(0).ToString
            spnPrecio.Value = spnPrecio.Minimum
        End If
    End Function

    Public Overridable Function Guardar()
        'Cabecera
        ListaColumnas.RemoveRange(0, ListaColumnas.Count)
        ListaColumnas.Add("1") 'Pendiente
        ListaColumnas.Add("'" & DateTime.Now & "'")
        ListaColumnas.Add(cmbCli.SelectedValue)
        ListaColumnas.Add(DescuentoCli)
        ListaColumnas.Add(IIf(cmbPago.SelectedIndex = 0, "'R'", "'C'"))
        ListaColumnas.Add(IIf(cmbPago.SelectedIndex = 0, "'G'", "'P'"))

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
        ActualizarTabla()
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

    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        Guardar()
    End Sub

    Public Sub CalcularResultados()
        Dim Subtotal As Double = 0
        Dim Impu As Double = 0
        Dim Descuento As Double = 0
        For Each Fila As DataGridViewRow In Datos.Rows
            If Not Fila Is Nothing Then
                Subtotal += Convert.ToDouble(Fila.Cells(4).Value) * Convert.ToDouble(Fila.Cells(3).Value)
                Impu += Convert.ToDouble(Fila.Cells(5).Value)
            End If
        Next
        'ListaColumnas.RemoveRange(0, ListaColumnas.Count)
        'ListaColumnas.Add("Descuento_Sugerido")
        Descuento += Subtotal * DescuentoCli 'claseConexion.Read("Cliente", ListaColumnas, "Where idCliente=" & cmbCli.SelectedValue).Rows(0)(0).ToString
        'DescuentoCli = claseConexion.Read("Cliente", ListaColumnas, "Where idCliente=" & cmbCli.SelectedValue).Rows(0)(0).ToString
        txtSubtotal.Text = Subtotal
        txtISV.Text = Impu
        txtDesc.Text = Descuento
        txtTotal.Text = Subtotal + Impu - Descuento
    End Sub

    Public Function Consultar(Tabla As String, Columnas As ArrayList, where As String) As DataTable
        Return claseConexion.Read(Tabla, Columnas, "where " & where)
    End Function
#End Region

End Class