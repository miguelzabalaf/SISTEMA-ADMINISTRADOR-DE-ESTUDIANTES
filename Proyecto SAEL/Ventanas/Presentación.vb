Public Class Presentación
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Presentación_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login.Enabled = True
    End Sub

    Private Sub Login_Tick(sender As Object, e As EventArgs) Handles Login.Tick
        Label1.Text = Label1.Text + 1
        If Label1.Text = 8 Then
            Me.Hide()
            Inicio.Show()
        End If
    End Sub
End Class