Public Class Inasistencias
    Private Sub RichTextBox1_Click(sender As Object, e As EventArgs) Handles RichTextBox1.Click
        RichTextBox1.Text = ""
        RichTextBox1.ForeColor = Color.Black
    End Sub

    Private Sub Inasistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'INASISTENCIASDataSet.INASISTENCIAS' Puede moverla o quitarla según sea necesario.
        Me.INASISTENCIASTableAdapter.Fill(Me.INASISTENCIASDataSet.INASISTENCIAS)
        TextBox1.Text = Inicio.TextBox6.Text + " " + Inicio.TextBox7.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.INASISTENCIASTableAdapter.Insert(TextBox1.Text, DateTimePicker1.Value, RichTextBox1.Text)
        Me.INASISTENCIASTableAdapter.Fill(Me.INASISTENCIASDataSet.INASISTENCIAS)
        Me.Close()
    End Sub

    Private Sub TextBox12_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox12.KeyDown
        Buscador.Enabled = True
    End Sub

    Private Sub TextBox12_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox12.KeyUp
        Buscador.Enabled = False
    End Sub

    Private Sub Buscador_Tick(sender As Object, e As EventArgs) Handles Buscador.Tick
        Me.INASISTENCIASTableAdapter.FillBy(INASISTENCIASDataSet.INASISTENCIAS, TextBox12.Text)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.INASISTENCIASTableAdapter.Fill(Me.INASISTENCIASDataSet.INASISTENCIAS)
    End Sub

    Private Sub TextBox12_MouseHover(sender As Object, e As EventArgs) Handles TextBox12.MouseHover
        TextBox12.Text = ""
    End Sub
End Class