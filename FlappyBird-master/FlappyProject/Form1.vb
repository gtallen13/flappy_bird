Public Class Form1
    Dim conexion As New Conexion
    Dim jumping As Boolean
    'Dim yspeed As Integer 
    Dim gravedad As Integer = 5
    Dim pipes(1) As PictureBox
    Dim toppipes(1) As PictureBox
    Dim pipespeed As Single = 4
    Dim cont As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Timer1.Enabled = True
        CreatePipes(1)
        CreateTopPipes(1)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        logoicc.Top += gravedad
        For i = 0 To 1
            pipes(i).Left -= pipespeed
            toppipes(i).Left -= pipespeed
            If Collision(pipes(i), logoicc) = True Or Collision(toppipes(i), logoicc) = True Then
                Timer1.Enabled = False
                Me.Hide()
                Salida.Show()
                Llenar()
            End If
            If (logoicc.Location.Y >= 272) Or (logoicc.Location.Y <= 0) Then
                Timer1.Enabled = False
                Me.Hide()
                Salida.Show()
                Llenar()
            End If

            If pipes(i).Left < 0 Then
                pipes(i).Left += 400
                toppipes(i).Left += 400
                pipes(i).Top = 70 + 290 * Rnd()
                toppipes(i).Top = pipes(i).Top - 480
                cont = cont + 1
                Label2.Text = cont
                If cont Mod 5 = 0 Then
                    Me.BackgroundImage = Image.FromFile(Application.StartupPath & "\sprites\night.png")
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                End If
                If cont Mod 10 = 0 Then
                    Me.BackgroundImage = Image.FromFile(Application.StartupPath & "\sprites\day.png")
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                End If


            End If
        Next
    End Sub

    Private Sub CreatePipes(ByVal number As Integer)
        Dim i As Integer = 0
        For i = 0 To number
            Dim temp As New PictureBox
            Me.Controls.Add(temp)
            temp.Width = 70
            temp.Height = 350
            temp.BackgroundImage = Image.FromFile(Application.StartupPath & "\sprites\Columna-larga abajo.png")
            temp.BackgroundImageLayout = ImageLayout.Stretch
            temp.BackColor = Color.Transparent
            temp.Top = 70 + 290 * Rnd()
            temp.Left = (i * 200) + 300
            pipes(i) = temp
            pipes(i).Visible = True
        Next
    End Sub

    Private Sub CreateTopPipes(ByVal number As Integer)
        Dim i As Integer = 0
        For i = 0 To number
            Dim temp As New PictureBox
            Me.Controls.Add(temp)
            temp.Width = 70
            temp.Height = 350
            temp.BackgroundImage = Image.FromFile(Application.StartupPath & "\sprites\Columna-larga arriba.png")
            temp.BackgroundImageLayout = ImageLayout.Stretch
            temp.BackColor = Color.Transparent
            temp.Top = pipes(i).Top - 472
            temp.Left = (i * 200) + 300
            toppipes(i) = temp
            toppipes(i).Visible = True
        Next
    End Sub



    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If (e.KeyCode = Keys.Space) Then
            gravedad = 5

        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Space) Then
            gravedad = -8

        End If
    End Sub

    Public Function Collision(ByVal Object1 As Object, ByVal Object2 As Object) As Boolean
        Dim collided As Boolean = False
        If Object1.Top + Object1.Height >= Object2.Top And
           Object2.Top + Object2.Height >= Object1.Top And
           Object1.Left + Object1.Width >= Object2.left And
           Object2.Left + Object2.Width >= Object1.left And Object1.visible = True And Object2.visible = True Then
            collided = True
        End If
        Return collided
    End Function

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        Principal.Show()
        Close()
    End Sub
    Public Sub Llenar()
        Conexion.Llenar("flappy_bird")
        Marcador.DataGridView1.DataSource = Conexion.ds.Tables("juego")
        Marcador.DataGridView1.DataSource = Conexion.dv
    End Sub


End Class
