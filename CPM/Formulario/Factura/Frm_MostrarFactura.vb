Public Class Frm_MostrarFactura
    Private Dates As DataTable

    Property DATOS As DataTable
        Get
            Return Dates
        End Get
        Set(value As DataTable)
            Dates = value
        End Set
    End Property

    'Public Overrides Function LlenarDatos()
    '    'Label25.Text = "Factura No. " & Dates.Rows(0)(0).ToString
    '    'Text += Dates.Rows(0)(0).ToString
    '    'Label14.Text = "Fecha " & Dates.Rows(0)(1).ToString
    '    'TextBox1.Text = Dates.Rows(0)(2).ToString
    '    'Dim Cliente As New ArrayList
    '    'Cliente.Add(Dates.Rows(0)(3).ToString)
    '    'ComboBox1.DataSource = Cliente
    '    'ComboBox1.SelectedIndex = 0

    'End Function

    Public Overrides Sub Visibles_Activos()

    End Sub
End Class
