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

    End Sub
End Class