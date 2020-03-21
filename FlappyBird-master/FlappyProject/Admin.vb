Public Class Admin
    Dim conexion As New Conexion

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        conexion.reset("juego")
        Llenar()
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexion.conectar()
        Llenar()
    End Sub
    Public Sub Llenar()
        conexion.Llenaradmin("flappy_bird")
        DataGridView1.DataSource = conexion.ds.Tables("juego")
        DataGridView1.DataSource = conexion.dv
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Principal.Show()
        Me.Hide()

    End Sub
End Class