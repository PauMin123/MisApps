Public Class Ingreso
    Private Sub Ingreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUsuario.Focus()

    End Sub
    Function Aceptar()
        Dim rs As New ADODB.Recordset
        Dim rs1 As New ADODB.Recordset
        Dim contador As Integer

        If Trim(TxtUsuario.Text) = "" Then
            MsgBox("Ingrese Usuario...!", vbExclamation)
            TxtUsuario.Focus()
            Return 0
            Exit Function
        End If
        If Trim(TxtPass.Text) = "" Then
            MsgBox("Ingrese Clave...!", vbExclamation)
            TxtPass.Focus()
            Return 0
            Exit Function
        End If

        usuario = TxtUsuario.Text
        ConectarLogin()
        rs.Open("select * from usuarios where login = '" & Trim(TxtUsuario.Text) & "' AND clave ='" & Trim(TxtPass.Text) & "'", cnxlogin, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not rs.EOF Then
            If rs.Fields("conteo").Value > rs.Fields("ingresos").Value Then
                usuario = rs.Fields("login").Value
                FrmCambioClave.Show()
                Me.Hide()
            Else
                If rs.Fields("conteo").Value = 0 Then
                    usuario = rs.Fields("login").Value
                    FrmCambioClave.Show()
                    Me.Hide()
                Else
                    usuario = rs.Fields("login").Value
                    clave = rs.Fields("Clave").Value
                    rs.Fields("conteo").Value = rs.Fields("conteo").Value + 1
                    rs.Update()
                    FrmSplash.Show()
                    Me.Hide()
                End If
            End If
        Else

            TxtUsuario.Text = ""
            TxtPass.Text = ""
            MsgBox("Incorrecto...!", vbInformation)
            contador = contador + 1
            TxtUsuario.Focus()
        End If
        If contador = 3 Then
            MsgBox("Usted ha superado los intentos permitidos para ingresar al sistema...!", vbInformation)
            End
            Exit Function
        End If
        rs.Close()
        cnxlogin.Close()

#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código

    Private Sub TxtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUsuario.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) And TxtUsuario.Text.Length > 0 Then
            TxtPass.Focus()
        End If
    End Sub

    Private Sub TxtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPass.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Call Aceptar()
            e.Handled = True
        End If

    End Sub
    Private Sub FrmSesion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.ExitThread()
        Application.Exit()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()

    End Sub
End Class