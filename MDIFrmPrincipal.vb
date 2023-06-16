Public Class MDIFrmPrincipal
    Private Sub MDIFrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized

    End Sub
    Private Sub MDIFrmPrincipal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Ingreso.Close()
    End Sub

    Private Sub PORCELULAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PORCELULAToolStripMenuItem.Click
        FrmCelulas.Show()

    End Sub

    Private Sub MENSUALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MENSUALToolStripMenuItem.Click
        FrmReporMensual.Show()
    End Sub
    Private Sub MDIFrmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
        Application.ExitThread()
    End Sub
End Class