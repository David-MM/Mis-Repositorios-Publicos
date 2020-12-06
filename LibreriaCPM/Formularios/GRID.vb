Imports System.Data.SqlClient

Public Class GRID
    Private claseConexion As dbConnect

    Public Sub New(db As dbConnect)
        claseConexion = db
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Vamosaprobartodo(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datos As New ArrayList
        datos.Add("RTN")
        datos.Add("R_Social")
        datos.Add("Descuento_Sugerido")
        datos.Add("L_Credito")
        datos.Add("Telefono")
        datos.Add("E_Mail")
        datos.Add("Direccion")
        datos.Add("Estado_Delete")

        Dim datos2 As New ArrayList
        datos2.Add("'0001-77777-06666-555555'")
        datos2.Add("'Ja Perro'")
        datos2.Add(0.5)
        datos2.Add(5000)
        datos2.Add("'9658-3698'")
        datos2.Add("'tu@mama.com'")
        datos2.Add("'Col. Servilleta'")
        datos2.Add(0)
        claseConexion.Update(claseConexion.ConexionSQLServer, "Cliente", datos, datos2, " where idCliente = 2")
    End Sub
End Class