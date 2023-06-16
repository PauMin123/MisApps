Public Class FrmReporMensual
    Public maxDate As DateTime
    Public MaxFecha As String
    Public formatdate As String
    Private Sub FrmReporMensual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarCostura()
        Dim diaMax As Integer = DateTime.DaysInMonth(Now.Year, Now.Month)
        FechaInicio.Value = "01/" & Now.Month.ToString & "/" & Now.Year
        FechaFin.Value = diaMax & "/" & Now.Month.ToString & "/" & Now.Year
    End Sub
    Sub datosmes()

        Dim rs As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter
        Dim fecha1 As Date
        Dim fecha2 As Date

        If FechaFin.Value >= FechaInicio.Value Then
            fecha1 = FechaInicio.Value
            fecha2 = FechaFin.Value
        Else
            fecha1 = FechaFin.Value
            fecha2 = FechaInicio.Value
        End If

        'Abrimos la conexion y pedimos los registros del mes con esta consulta
        rs.Open("SELECT * FROM planillas.errores_costura WHERE fecha between '" & fecha1.ToString("yyyy/MM/dd") & "' AND  '" & fecha2.ToString("yyyy-MM-dd") & "' order by celula ASC", cnxges, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        MensualDetalle.DataSource = Nothing
        If MensualDetalle.Rows.Count > 0 Then MensualDetalle.Rows.Clear()
        If MensualDetalle.Columns.Count > 0 Then MensualDetalle.Columns.Clear()
        If Not rs.EOF Then

            'Agregamos los datos al data grid y cerramos el ciclo
            da.Fill(ds, rs, "datos")
            MensualDetalle.DataSource = ds.Tables("datos")

            With MensualDetalle

                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).HeaderText = "Célula"
                .Columns(3).HeaderText = "Total Control"
                .Columns(4).HeaderText = "Revisadas"
                .Columns(5).HeaderText = "1a."
                .Columns(6).HeaderText = "Especial"
                .Columns(7).HeaderText = "Irregular"
                .Columns(8).HeaderText = "A"
                .Columns(9).HeaderText = "M"
                .Columns(10).HeaderText = "B"
                .Columns(11).HeaderText = "IH"
                .Columns(12).HeaderText = "FT"
                .Columns(13).HeaderText = "N"
                .Columns(14).HeaderText = "DT"
                .Columns(15).HeaderText = "M"
                .Columns(16).HeaderText = "S"
                .Columns(17).HeaderText = "DE"
                .Columns(18).HeaderText = "DC"
                .Columns(19).HeaderText = "ME"
                .Columns(20).HeaderText = "O"
                .Columns(21).HeaderText = "Calificadora"

            End With
        End If
    End Sub

    Sub sumasmes()

        Dim rs1 As New ADODB.Recordset
        Dim ds1 As New DataSet
        Dim da1 As New System.Data.OleDb.OleDbDataAdapter
        Dim fecha1 As Date
        Dim fecha2 As Date

        If FechaFin.Value >= FechaInicio.Value Then
            fecha1 = FechaInicio.Value
            fecha2 = FechaFin.Value
        Else
            fecha1 = FechaFin.Value
            fecha2 = FechaInicio.Value
        End If

        rs1.Open("Select sum(cantidad) As CANTIDAD, sum(revisadas) As revisadas, sum(primera) As primera, sum(especial) As especial,
        sum(irregular) As irregular, sum(agujero) As agujero, sum(malla) As malla, sum(barrado) As barrado,
        sum(iregularidadhilo) As irreguhilo, sum(filamentostejidos) As filatejido, sum(nudos) As nudos, 
        sum(diferentetono) As tono, sum(manchas) As manchas, sum(suciedad) As suciedad, sum(defectoestampado) As defectestampado,
        sum(defectocostura) As defectcostura, sum(medidas) As medidas, sum(otros) As otros from errores_costura_det 
        WHERE fecha between '" & fecha1.ToString("yyyy/MM/dd") & "' AND  '" & fecha2.ToString("yyyy-MM-dd") & "'", cnxges, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        MensualDetalle.DataSource = Nothing
        If MensualDetalle.Rows.Count > 0 Then MensualDetalle.Rows.Clear()
        If MensualDetalle.Columns.Count > 0 Then MensualDetalle.Columns.Clear()

        If Not rs1.EOF Then
            'Agregamos los datos al data grid y cerramos el ciclo
            da1.Fill(ds1, rs1, "sumas")
            MensualDetalle.DataSource = ds1.Tables("sumas")

            With MensualDetalle
                .Columns(0).HeaderText = "Total Control"
                .Columns(1).HeaderText = "Total Revisadas"
                .Columns(2).HeaderText = "1a."
                .Columns(3).HeaderText = "Especial"
                .Columns(4).HeaderText = "Irregular"
                .Columns(5).HeaderText = "A"
                .Columns(6).HeaderText = "M"
                .Columns(7).HeaderText = "B"
                .Columns(8).HeaderText = "IH"
                .Columns(9).HeaderText = "FT"
                .Columns(10).HeaderText = "N"
                .Columns(11).HeaderText = "DT"
                .Columns(12).HeaderText = "M"
                .Columns(13).HeaderText = "S"
                .Columns(14).HeaderText = "DE"
                .Columns(15).HeaderText = "DC"
                .Columns(16).HeaderText = "ME"
                .Columns(17).HeaderText = "O"
            End With
        End If

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        MsgBox("USUARIOS DE LAS CALIFICADORAS

    s.lopez = Silvia López
    j.gonzalez = Jaquelin Gonzalez
    a.mendez = Angelica Mendez
    s.arana = Sandra Arana
    c.cutz =  Carmen Sucely
    r.deleon = Rosa De Leon", vbInformation)
    End Sub

    Sub ObtenerMaxFecha()
        Dim today As DateTime = FechaInicio.Value.ToString("yyyy-MM-dd")
        'Dim maxDate As DateTime

        Select Case today.Month
            Case 1, 3, 5, 7, 8, 10, 12
                maxDate = New DateTime(today.Year, today.Month, 31)
            Case 4, 6, 9, 11
                maxDate = New DateTime(today.Year, today.Month, 30)
            Case 2
                If DateTime.IsLeapYear(today.Year) Then
                    maxDate = New DateTime(today.Year, today.Month, 29)
                Else
                    maxDate = New DateTime(today.Year, today.Month, 28)
                End If
            Case Else
                Console.WriteLine("MES INVALIDO", vbCritical)
        End Select

        MaxFecha = Format(maxDate, "yyyy-MM-dd")

        MsgBox("La máxima fecha del mes en curso es: " & maxDate.ToString("yyyy-MM-dd"))
    End Sub
    Sub cambio()

        Dim selectedDate As Date
        selectedDate = FechaInicio.Value

        formatdate = Format(selectedDate, "yyyy-MM-dd")
    End Sub

    Private Sub FrmReporMensual_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If cnxges.State = 1 Then cnxges.Close()

    End Sub
    Function ObtenerPrimerFecha() As Date
        Dim fechaActual As Date = Date.Now
        Dim primerFecha As Date = New Date(fechaActual.Year, fechaActual.Month, 1)
        Return primerFecha
    End Function
    Sub primerdia()
        Dim primerFecha As Date = ObtenerPrimerFecha()
        MsgBox(primerFecha.ToString("dd/MM/yyyy"))

    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        datosmes()
    End Sub

    Private Sub BtnSumas_Click(sender As Object, e As EventArgs) Handles BtnSumas.Click
        sumasmes()
    End Sub
End Class