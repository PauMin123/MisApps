<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReporMensual
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReporMensual))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirF8ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirF12ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MensualDetalle = New System.Windows.Forms.DataGridView()
        Me.FechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.FechaFin = New System.Windows.Forms.DateTimePicker()
        Me.BtnReporte = New System.Windows.Forms.Button()
        Me.BtnSumas = New System.Windows.Forms.Button()
        Me.RotafolioDetalleDetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.MensualDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RotafolioDetalleDetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ImprimirF8ToolStripMenuItem, Me.SalirF12ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(738, 39)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "Descripcion de Errores"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(101, 35)
        Me.ToolStripMenuItem1.Text = "Informacion F2"
        Me.ToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ImprimirF8ToolStripMenuItem
        '
        Me.ImprimirF8ToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImprimirF8ToolStripMenuItem.Image = CType(resources.GetObject("ImprimirF8ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImprimirF8ToolStripMenuItem.Name = "ImprimirF8ToolStripMenuItem"
        Me.ImprimirF8ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.ImprimirF8ToolStripMenuItem.Size = New System.Drawing.Size(120, 35)
        Me.ImprimirF8ToolStripMenuItem.Text = "Generar Reporte F5"
        Me.ImprimirF8ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SalirF12ToolStripMenuItem
        '
        Me.SalirF12ToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirF12ToolStripMenuItem.Image = CType(resources.GetObject("SalirF12ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirF12ToolStripMenuItem.Name = "SalirF12ToolStripMenuItem"
        Me.SalirF12ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.SalirF12ToolStripMenuItem.Size = New System.Drawing.Size(63, 35)
        Me.SalirF12ToolStripMenuItem.Text = "Salir F12"
        Me.SalirF12ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MensualDetalle
        '
        Me.MensualDetalle.AllowUserToAddRows = False
        Me.MensualDetalle.AllowUserToDeleteRows = False
        Me.MensualDetalle.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MensualDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MensualDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MensualDetalle.Location = New System.Drawing.Point(12, 107)
        Me.MensualDetalle.Name = "MensualDetalle"
        Me.MensualDetalle.ReadOnly = True
        Me.MensualDetalle.Size = New System.Drawing.Size(714, 348)
        Me.MensualDetalle.TabIndex = 11
        '
        'FechaInicio
        '
        Me.FechaInicio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaInicio.Location = New System.Drawing.Point(12, 57)
        Me.FechaInicio.Name = "FechaInicio"
        Me.FechaInicio.Size = New System.Drawing.Size(196, 29)
        Me.FechaInicio.TabIndex = 12
        Me.FechaInicio.Value = New Date(2023, 6, 16, 0, 0, 0, 0)
        '
        'FechaFin
        '
        Me.FechaFin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaFin.Location = New System.Drawing.Point(220, 57)
        Me.FechaFin.Name = "FechaFin"
        Me.FechaFin.Size = New System.Drawing.Size(209, 29)
        Me.FechaFin.TabIndex = 14
        Me.FechaFin.Value = New Date(2023, 6, 16, 0, 0, 0, 0)
        '
        'BtnReporte
        '
        Me.BtnReporte.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReporte.Location = New System.Drawing.Point(496, 46)
        Me.BtnReporte.Name = "BtnReporte"
        Me.BtnReporte.Size = New System.Drawing.Size(112, 57)
        Me.BtnReporte.TabIndex = 16
        Me.BtnReporte.Text = "REPORTE MENSUAL"
        Me.BtnReporte.UseVisualStyleBackColor = True
        '
        'BtnSumas
        '
        Me.BtnSumas.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSumas.Location = New System.Drawing.Point(614, 44)
        Me.BtnSumas.Name = "BtnSumas"
        Me.BtnSumas.Size = New System.Drawing.Size(112, 59)
        Me.BtnSumas.TabIndex = 15
        Me.BtnSumas.Text = "SUMAS TOTALES"
        Me.BtnSumas.UseVisualStyleBackColor = True
        '
        'RotafolioDetalleDetBindingSource
        '
        Me.RotafolioDetalleDetBindingSource.DataSource = GetType(Reporte_Costura.RotafolioDetalleDet)
        '
        'FrmReporMensual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 467)
        Me.Controls.Add(Me.BtnReporte)
        Me.Controls.Add(Me.BtnSumas)
        Me.Controls.Add(Me.FechaFin)
        Me.Controls.Add(Me.FechaInicio)
        Me.Controls.Add(Me.MensualDetalle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FrmReporMensual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Mensual"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.MensualDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RotafolioDetalleDetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ImprimirF8ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirF12ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MensualDetalle As DataGridView
    Friend WithEvents FechaInicio As DateTimePicker
    Friend WithEvents RotafolioDetalleDetBindingSource As BindingSource
    Friend WithEvents FechaFin As DateTimePicker
    Friend WithEvents BtnReporte As Button
    Friend WithEvents BtnSumas As Button
End Class
