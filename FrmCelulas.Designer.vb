<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCelulas
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCelulas))
        Me.DetalleCostura = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirF8ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirF12ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.FechaFin = New System.Windows.Forms.DateTimePicker()
        Me.RotafolioDetalleDetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RotafolioDetCabBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label23 = New System.Windows.Forms.Label()
        CType(Me.DetalleCostura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.RotafolioDetalleDetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RotafolioDetCabBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DetalleCostura
        '
        Me.DetalleCostura.AllowUserToAddRows = False
        Me.DetalleCostura.AllowUserToDeleteRows = False
        Me.DetalleCostura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DetalleCostura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DetalleCostura.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DetalleCostura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.NullValue = "0"
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DetalleCostura.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DetalleCostura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DetalleCostura.DefaultCellStyle = DataGridViewCellStyle6
        Me.DetalleCostura.Location = New System.Drawing.Point(12, 104)
        Me.DetalleCostura.Name = "DetalleCostura"
        Me.DetalleCostura.ReadOnly = True
        Me.DetalleCostura.Size = New System.Drawing.Size(731, 381)
        Me.DetalleCostura.StandardTab = True
        Me.DetalleCostura.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16"})
        Me.ComboBox1.Location = New System.Drawing.Point(284, 58)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(134, 28)
        Me.ComboBox1.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ImprimirF8ToolStripMenuItem, Me.SalirF12ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(753, 39)
        Me.MenuStrip1.TabIndex = 4
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
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(36, 4)
        Me.ContextMenuStrip1.Text = "Descripción de Errores"
        '
        'FechaInicio
        '
        Me.FechaInicio.Checked = False
        Me.FechaInicio.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaInicio.Location = New System.Drawing.Point(476, 58)
        Me.FechaInicio.Name = "FechaInicio"
        Me.FechaInicio.Size = New System.Drawing.Size(134, 29)
        Me.FechaInicio.TabIndex = 7
        Me.FechaInicio.Value = New Date(2023, 6, 16, 0, 0, 0, 0)
        '
        'FechaFin
        '
        Me.FechaFin.Checked = False
        Me.FechaFin.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaFin.Location = New System.Drawing.Point(616, 58)
        Me.FechaFin.Name = "FechaFin"
        Me.FechaFin.Size = New System.Drawing.Size(129, 29)
        Me.FechaFin.TabIndex = 8
        Me.FechaFin.Value = New Date(2023, 6, 16, 0, 0, 0, 0)
        '
        'RotafolioDetalleDetBindingSource
        '
        Me.RotafolioDetalleDetBindingSource.DataSource = GetType(Reporte_Costura.RotafolioDetalleDet)
        '
        'RotafolioDetCabBindingSource
        '
        Me.RotafolioDetCabBindingSource.DataSource = GetType(Reporte_Costura.RotafolioDetCab)
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(12, 58)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(255, 20)
        Me.Label23.TabIndex = 51
        Me.Label23.Text = "SELECCIONE UN NUMERO DE CELULA"
        '
        'FrmCelulas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 497)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.FechaFin)
        Me.Controls.Add(Me.FechaInicio)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DetalleCostura)
        Me.Name = "FrmCelulas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmDatos"
        CType(Me.DetalleCostura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.RotafolioDetalleDetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RotafolioDetCabBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DetalleCostura As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ImprimirF8ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirF12ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents RotafolioDetalleDetBindingSource As BindingSource
    Friend WithEvents RotafolioDetCabBindingSource As BindingSource
    Friend WithEvents FechaInicio As DateTimePicker
    Friend WithEvents FechaFin As DateTimePicker
    Friend WithEvents Label23 As Label
End Class
