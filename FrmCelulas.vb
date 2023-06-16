Public Class FrmCelulas
    Dim num As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarCostura()
        Dim diaMax As Integer = DateTime.DaysInMonth(Now.Year, Now.Month)
        FechaInicio.Value = "01/" & Now.Month.ToString & "/" & Now.Year
        FechaFin.Value = diaMax & "/" & Now.Month.ToString & "/" & Now.Year
    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        Dim rs As New ADODB.Recordset
        Dim rs1 As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter
        Dim sql As String

        rs.Open("SELECT * from planillas.errores_costura_det where iderrores_costura= " & ComboBox1.SelectedItem, cnxges, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not rs.EOF Then

            sql = "SELECT sum(cantidad), sum(revisadas), sum(primera) as 1a, sum(especial), sum(irregular) from planillas.errores_costura_det
 where iderrores_costura = "
            'rs1.Open()
            num = ComboBox1.SelectedItem

            da.Fill(ds, rs, "datos")
            DetalleCostura.DataSource = ds.Tables("datos")

            With DetalleCostura
                .Columns(0).HeaderText = "CELULA"
                .Columns(2).HeaderText = "Fecha Cierre De Control"
                .Columns(3).HeaderText = "Referencia"
                .Columns(4).HeaderText = "No. de Control"
                .Columns(5).HeaderText = "Total de Control"
                .Columns(6).HeaderText = "Revisadas"
                .Columns(7).HeaderText = "1a."
                .Columns(8).HeaderText = "Especial"
                .Columns(9).HeaderText = "Irregular"
                .Columns(10).HeaderText = "A"
                .Columns(11).HeaderText = "M"
                .Columns(12).HeaderText = "B"
                .Columns(13).HeaderText = "IH"
                .Columns(14).HeaderText = "FT"
                .Columns(15).HeaderText = "N"
                .Columns(16).HeaderText = "DT"
                .Columns(17).HeaderText = "M"
                .Columns(18).HeaderText = "S"
                .Columns(19).HeaderText = "DE"
                .Columns(20).HeaderText = "DC"
                .Columns(21).HeaderText = "ME"
                .Columns(22).HeaderText = "O"


                '.Columns(0).Width = 60


                .Columns(1).Visible = False
                '.Columns(5).Visible = False
            End With

        End If
    End Sub

    Private Sub InvoiceGenerate()
        Dim rfaced As New ADODB.Recordset
        Dim rs As New ADODB.Recordset
        Dim sql As String

        Dim invoice As New RotafolioDetCab()

        rs.Open("SELECT distinct det.iderrores_costura, det.fecha, err.usuario from errores_costura_det as det, errores_costura as err where det.iderrores_costura= " & num, cnxges, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not rs.EOF Then
            invoice.CELULA = rs.Fields("iderrores_costura").Value
            invoice.FECHA = Now
            'invoice.FECHA = rs.Fields("fecha").Value
            invoice.USUARIO = rs.Fields("usuario").Value
        End If

        sql = "SELECT sum(cantidad) as CANTIDAD, sum(revisadas) as revisadas, sum(primera) as primera, sum(especial) as especial,
        sum(irregular) as irregular, sum(agujero) as agujero, sum(malla) as malla, sum(barrado) as barrado,
        sum(iregularidadhilo) as irreguhilo, sum(filamentostejidos) as filatejido, sum(nudos) as nudos, 
        sum(diferentetono) as tono, sum(manchas) as manchas, sum(suciedad) as suciedad, sum(defectoestampado) as defectestampado,
        sum(defectocostura) as defectcostura, sum(medidas) as medidas, sum(otros) as otros from errores_costura_det where iderrores_costura=" & num


        rfaced.Open(sql, cnxges, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        While Not rfaced.EOF

            Dim article As New RotafolioDetalleDet()
            article.CANTIDAD = rfaced.Fields("cantidad").Value
            article.REVISADAS = rfaced.Fields("revisadas").Value
            article.PRIMERA = rfaced.Fields("primera").Value
            article.ESPECIAL = rfaced.Fields("especial").Value
            article.IRREGULAR = rfaced.Fields("irregular").Value
            article.AGUJERO = rfaced.Fields("agujero").Value
            article.MALLA = rfaced.Fields("malla").Value
            article.BARRADO = rfaced.Fields("barrado").Value
            article.IRREHILOS = rfaced.Fields("irreguhilo").Value
            article.FILATEJIDOS = rfaced.Fields("filatejido").Value
            article.NUDOS = rfaced.Fields("nudos").Value
            article.TONO = rfaced.Fields("tono").Value
            article.MANCHAS = rfaced.Fields("manchas").Value
            article.SUCIEDAD = rfaced.Fields("suciedad").Value
            article.DEFECTESTAM = rfaced.Fields("defectestampado").Value
            article.DEFECTCOST = rfaced.Fields("defectcostura").Value
            article.MEDIDAS = rfaced.Fields("medidas").Value
            article.OTROS = rfaced.Fields("otros").Value
            invoice.DETAIL.Add(article)
            rfaced.MoveNext()
        End While
        rs.Close()
        rfaced.Close()


        Dim frm As New ReporteErrosCost()

        frm.Invoice.Add(invoice)

        frm.Detail = invoice.DETAIL
        frm.WindowState = FormWindowState.Maximized
        frm.Show()

    End Sub
    Private Sub ImprimirF8ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirF8ToolStripMenuItem.Click
        InvoiceGenerate()

    End Sub

    Private Sub SalirF12ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirF12ToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim mensaje As String

        mensaje = "                   A = AGUJERO
                   M = MALLA
                   B = BARRADO
                   IH = IRREGULARIDAD DE HILOS
                   FT = FILAMENTOS TEJIDOS
                   N = NUDOS
                   DT = DIFERENTE TONO
                   M = MANCHAS
                   S = SUCIEDAD
                   DE = DEFECTO ESTAMPADO
                   DC = DEFECTO COSTURA
                   ME = MEDIDAS
                   O = OTROS"

        MsgBox(mensaje, vbInformation)
    End Sub

    Private Sub FrmCelulas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        cnxges.Close()

    End Sub
End Class
