<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIFrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.REPORTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PORCELULAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MENSUALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REPORTESToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(788, 25)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'REPORTESToolStripMenuItem
        '
        Me.REPORTESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PORCELULAToolStripMenuItem, Me.MENSUALToolStripMenuItem})
        Me.REPORTESToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REPORTESToolStripMenuItem.Name = "REPORTESToolStripMenuItem"
        Me.REPORTESToolStripMenuItem.Size = New System.Drawing.Size(83, 21)
        Me.REPORTESToolStripMenuItem.Text = "REPORTES"
        '
        'PORCELULAToolStripMenuItem
        '
        Me.PORCELULAToolStripMenuItem.Name = "PORCELULAToolStripMenuItem"
        Me.PORCELULAToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PORCELULAToolStripMenuItem.Text = "POR CELULA"
        '
        'MENSUALToolStripMenuItem
        '
        Me.MENSUALToolStripMenuItem.Name = "MENSUALToolStripMenuItem"
        Me.MENSUALToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MENSUALToolStripMenuItem.Text = "MENSUAL"
        '
        'MDIFrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 445)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MDIFrmPrincipal"
        Me.Text = "Reporte Costura - Fábrica El Zeppelín S.A."
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents REPORTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PORCELULAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MENSUALToolStripMenuItem As ToolStripMenuItem
End Class
