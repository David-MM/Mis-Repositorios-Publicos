﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlantillaReporteria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ReportePrincipal = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'ReportePrincipal
        '
        Me.ReportePrincipal.ActiveViewIndex = -1
        Me.ReportePrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReportePrincipal.Cursor = System.Windows.Forms.Cursors.Default
        Me.ReportePrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportePrincipal.Location = New System.Drawing.Point(0, 0)
        Me.ReportePrincipal.Name = "ReportePrincipal"
        Me.ReportePrincipal.Size = New System.Drawing.Size(800, 450)
        Me.ReportePrincipal.TabIndex = 0
        '
        'PlantillaReporteria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportePrincipal)
        Me.Name = "PlantillaReporteria"
        Me.Text = "Reporteria"
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents ReportePrincipal As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
