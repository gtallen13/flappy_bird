Public Class Login
    Dim Conexion As New Conexion
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If (Conexion.admin(txtuser.Text, txtpassword.Text)) Then
            limpiar()
            Me.Hide()
            Admin.Show()
        ElseIf (Conexion.comparar(txtuser.Text, txtpassword.Text)) Then
            limpiar()
            Me.Hide()
            Principal.Show()
        Else
            MsgBox("Usuario o contraseña incorrecto!", MsgBoxStyle.Critical)
        End If
    End Sub

    Public Sub limpiar()
        txtuser.ResetText()
        txtpassword.ResetText()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Conexion.conectar()
    End Sub

    Private Sub btnregresar_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Me.Hide()
        Marcador.Show()
    End Sub
End Class