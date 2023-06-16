Module Generales
    Public cnxges As New ADODB.Connection
    Public cnxlogin As New ADODB.Connection
    Public cadenages As String = "DRIVER={MySQL ODBC 5.3 ANSI Driver};SERVER=192.9.200.5;
    DATABASE=planillas;UID=odbc;PASSWORD=zeppelin030874;"
    Public cadenalogin As String = "Driver={MySQL ODBC 5.3 ANSI Driver};Server=192.9.200.5;
    Database=generales;User=odbc;Password=zeppelin030874;Option=3;"
    Public usuario As String
    Public clave As String

    'CONEXION PARA INICIO DE SESION
    Public Function ConectarLogin()
        Try
            cnxlogin.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            cnxlogin.Open(cadenalogin)
            Return True
        Catch ex As Exception
            MsgBox("NO FUE POSIBLE CONECTARSE A LA BASE, COMUNIQUESE CON EL DEPARTAMENTO DE SISTEMAS, EXTENSION 158 - PAULO MINERA", vbCritical)
            Return False
        End Try
    End Function
    'CONEXION PARA LA BASE DE DATOS
    Public Function ConectarCostura()
        Try
            cnxges.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            cnxges.Open(cadenages)
            Return True
        Catch ex As Exception
            MsgBox("NO FUE POSIBLE CONECTARSE A LA BASE, COMUNIQUESE CON EL DEPARTAMENTO DE SISTEMAS, EXTENSION 158 - PAULO MINERA", vbCritical)
            Return False
        End Try
    End Function
End Module
