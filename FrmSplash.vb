Public Class FrmSplash
    Private Sub FrmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rs As New ADODB.Recordset
        If Not cnxlogin.State = 1 Then cnxlogin.Open(cadenalogin)
        rs.Open("Select * from usuarios where login ='" & usuario & "' ", cnxlogin, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not rs.EOF Then
            LblUsuario.Text = rs.Fields("nombre").Value
        End If
        rs.Close()
    End Sub
    Private Sub FrmSplash_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Me.Close()
        MDIFrmPrincipal.Show()
    End Sub
End Class