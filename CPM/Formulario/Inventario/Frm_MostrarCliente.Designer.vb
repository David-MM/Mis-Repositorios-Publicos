<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MostrarCliente
    Inherits LibreriaCPM.PlantillaCliente

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1.SuspendLayout()
        CType(Me.N_Descuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_Credito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frm_MostrarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(475, 453)
        Me.Name = "Frm_MostrarCliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.N_Descuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_Credito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
