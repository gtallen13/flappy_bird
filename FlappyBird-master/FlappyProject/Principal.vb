Public Class Principal

    Private Sub showNewform(ByVal frm As Form)
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.ControlBox = False
        frm.ShowIcon = False
        frm.ShowInTaskbar = False
        frm.Show()
    End Sub
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Jugador.Show()
        Me.Hide()
    End Sub

    Private Sub BtnMarcador_Click(sender As Object, e As EventArgs) Handles BtnMarcador.Click
        Marcador.Show()
        Me.Hide()
    End Sub

End Class