Public Class Salida
    Dim conexion As New Conexion

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Form1.Close()
        conexion.agregar_puntos(Jugador.txtjugador.Text, Form1.Label2.Text, Jugador.cbescuela.Text)
        Llenar()
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Principal.Show()
        conexion.agregar_puntos(Jugador.txtjugador.Text, Form1.Label2.Text, Jugador.cbescuela.Text)
        Llenar()
        Jugador.txtjugador.ResetText()
        Jugador.cbescuela.ResetText()
        Form1.Close()
        Close()
    End Sub


    Private Sub Salida_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexion.conectar()
        Label3.Text = Form1.Label2.Text

    End Sub


    Public Sub Llenar()
        conexion.Llenar("flappy_bird")
        Marcador.DataGridView1.DataSource = conexion.ds.Tables("juego")
        Marcador.DataGridView1.DataSource = conexion.dv

    End Sub
End Class