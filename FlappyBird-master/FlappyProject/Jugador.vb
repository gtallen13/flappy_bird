Public Class Jugador
    Dim Conexion As New Conexion
    Private Sub Jugar_Click(sender As Object, e As EventArgs) Handles registrarse.Click
        If cbescuela.Text = "" Or txtjugador.Text = "" Then
            MsgBox("Favor Ingresar todos los datos!", MsgBoxStyle.Information)
        ElseIf Conexion.agregar(txtjugador.Text, cbescuela.Text) Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Public Sub llenarcb()
        Conexion.llenar_escuela()
        cbescuela.DataSource = Conexion.datos2.Tables("escuelas")
        cbescuela.DisplayMember = "Escuela"
    End Sub

    Private Sub Jugador_Load(sender As Object, e As EventArgs) Handles Me.Load
        Conexion.conectar()
        llenarcb()
        txtjugador.ResetText()
        cbescuela.ResetText()
    End Sub

    Private Sub cbescuela_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbescuela.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnregresar_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        Principal.Show()
        Me.Close()
    End Sub
End Class