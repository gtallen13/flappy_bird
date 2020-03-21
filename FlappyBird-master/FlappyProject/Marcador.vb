Public Class Marcador
    Dim conexion As New Conexion
    Public Sub Llenar()
        conexion.Llenar("flappy_bird")
        DataGridView1.DataSource = conexion.ds.Tables("juego")
        DataGridView1.DataSource = conexion.dv
    End Sub
    Private Sub Marcador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        Llenar()
    End Sub

    Private Sub btnatras_Click(sender As Object, e As EventArgs) Handles btnatras.Click
        Principal.Show()
        Close()


    End Sub

    Private Sub btnadmin1_Click(sender As Object, e As EventArgs) Handles btnadmin1.Click
        Login.Show()
        Me.Close()
    End Sub
End Class