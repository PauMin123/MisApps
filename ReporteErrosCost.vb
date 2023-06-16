Imports Microsoft.Reporting.WinForms
Public Class ReporteErrosCost
    Public Invoice As New List(Of RotafolioDetCab)()
    Public Detail As New List(Of RotafolioDetalleDet)()
    Private Sub ReporteErrosCost_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Limpiemos el DataSource del informe
        ReportViewer1.LocalReport.DataSources.Clear()

        Me.ReportViewer1.LocalReport.EnableExternalImages = True

        'Establezcamos la lista como Datasource del informe
        '
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Cabecera", Invoice))
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Detalle", Detail))
        '
        'Hagamos un refresh al reportViewer
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)

    End Sub
End Class