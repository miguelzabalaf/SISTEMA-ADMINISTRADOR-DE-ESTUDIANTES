Imports System.Drawing
Imports System.Drawing.Image
Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Public Class Inicio
    Dim a As Byte()
    Private Sub LIDERBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LIDERBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DATABASEDataSet)
    End Sub


    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DATABASEDataSet.ESTUDIANTES' Puede moverla o quitarla según sea necesario.
        Me.ESTUDIANTESTableAdapter.Fill(Me.DATABASEDataSet.ESTUDIANTES)
        'TODO: esta línea de código carga datos en la tabla 'DATABASEDataSet.LIDER' Puede moverla o quitarla según sea necesario.
        Me.LIDERTableAdapter.Fill(Me.DATABASEDataSet.LIDER)
        'TODO: esta línea de código carga datos en la tabla 'ServidorDataSet.LIDER' Puede moverla o quitarla según sea necesario.
    End Sub

    Private Sub Insertar_Click(sender As Object, e As EventArgs) Handles insertar.Click
        Me.LIDERTableAdapter.Insert(TextBox2.Text, TextBox3.Text, ComboBox3.Text, TextBox1.Text, ComboBox1.Text, ComboBox2.Text, TextBox4.Text, TextBox14.Text, a)
        Me.LIDERTableAdapter.Fill(Me.DATABASEDataSet.LIDER)
        mostrarestudiantes.Enabled = True
    End Sub

    Private Sub FotoLider_Click(sender As Object, e As EventArgs) Handles fotoLider.Click
        Try
            OpenFileDialog1.Title = "Seleccione una foto"
            OpenFileDialog1.FileName = "Imágenes"
            OpenFileDialog1.Filter = "All Files | *.*"
            OpenFileDialog1.ShowDialog()
            fotoLider.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        Catch ex As Exception
            'Do Nothing End Try'
        End Try
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles editar.Click
        Me.LIDERTableAdapter.EDITAR(TextBox2.Text, TextBox3.Text, ComboBox3.Text, TextBox1.Text, ComboBox1.Text, ComboBox2.Text, TextBox4.Text, TextBox14.Text, a)
        Me.LIDERTableAdapter.Fill(Me.DATABASEDataSet.LIDER)
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles borrar.Click
        Me.LIDERTableAdapter.BORRAR(TextBox1.Text)
        Me.LIDERTableAdapter.Fill(Me.DATABASEDataSet.LIDER)
    End Sub


    Private Sub Insertar_MouseHover(sender As Object, e As EventArgs) Handles insertar.MouseHover
        insertar.BackColor = Color.Green
    End Sub

    Private Sub Insertar_MouseLeave(sender As Object, e As EventArgs) Handles insertar.MouseLeave
        insertar.BackColor = Color.White
    End Sub

    Private Sub Editar_MouseHover(sender As Object, e As EventArgs) Handles editar.MouseHover
        editar.BackColor = Color.Gold
    End Sub

    Private Sub Editar_MouseLeave(sender As Object, e As EventArgs) Handles editar.MouseLeave
        editar.BackColor = Color.White
    End Sub

    Private Sub Borrar_MouseHover(sender As Object, e As EventArgs) Handles borrar.MouseHover
        borrar.BackColor = Color.DarkRed
    End Sub

    Private Sub Borrar_MouseLeave(sender As Object, e As EventArgs) Handles borrar.MouseLeave
        borrar.BackColor = Color.White
    End Sub

    Private Sub Mostrarestudiantes_Click(sender As Object, e As EventArgs) Handles mostrarestudiantes.Click
        Me.Size = New Size(1298, 702)
        Me.CenterToScreen()
        GroupBox1.Enabled = False
        Label10.Text = ComboBox3.Text
        Label14.Text = TextBox2.Text + " " + TextBox3.Text
        Label15.Text = TextBox1.Text
        Label16.Text = ComboBox2.Text
        Label17.Text = TextBox4.Text
        Label18.Text = TextBox14.Text
        GroupBox2.Visible = True
        GroupBox3.Visible = True
        Me.Text = "Proyecto SAEL - Sistema Administrador de Estudiantes para Líderes"

    End Sub

    Private Sub GuardarToolStripButton_Click(sender As Object, e As EventArgs)
        Me.LIDERTableAdapter.Insert(TextBox2.Text, TextBox3.Text, ComboBox3.Text, TextBox1.Text, ComboBox1.Text, ComboBox2.Text, TextBox4.Text, TextBox14.Text, a)
        Me.LIDERTableAdapter.Fill(Me.DATABASEDataSet.LIDER)
    End Sub

    Private Sub CortarToolStripButton_Click(sender As Object, e As EventArgs)
        Me.LIDERTableAdapter.BORRAR(TextBox1.Text)
        Me.LIDERTableAdapter.Fill(Me.DATABASEDataSet.LIDER)
    End Sub

    Private Sub LIDERBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LIDERBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DATABASEDataSet)

    End Sub

    Private Sub LIDERBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs) Handles LIDERBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LIDERBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DATABASEDataSet)

    End Sub

    Private Sub MasRetrasos_Click(sender As Object, e As EventArgs) Handles masRetrasos.Click
        TextBox10.Text = TextBox10.Text + 1
        Me.ESTUDIANTESTableAdapter.EDITAR(TextBox6.Text, TextBox7.Text, ComboBox4.Text, TextBox8.Text, ComboBox5.Text, ComboBox6.Text, TextBox9.Text, TextBox5.Text, TextBox10.Text, TextBox11.Text, a)
        Me.ESTUDIANTESTableAdapter.Fill(Me.DATABASEDataSet.ESTUDIANTES)
    End Sub

    Private Sub MasInasistencias_Click(sender As Object, e As EventArgs) Handles masInasistencias.Click
        TextBox11.Text = TextBox11.Text + 1
        Inasistencias.Show()
        Me.ESTUDIANTESTableAdapter.EDITAR(TextBox6.Text, TextBox7.Text, ComboBox4.Text, TextBox8.Text, ComboBox5.Text, ComboBox6.Text, TextBox9.Text, TextBox5.Text, TextBox10.Text, TextBox11.Text, a)
        Me.ESTUDIANTESTableAdapter.Fill(Me.DATABASEDataSet.ESTUDIANTES)
    End Sub

    Private Sub AgregarEstudiantes_Click(sender As Object, e As EventArgs) Handles agregarEstudiantes.Click
        Me.ESTUDIANTESTableAdapter.Insert(TextBox6.Text, TextBox7.Text, ComboBox4.Text, TextBox8.Text, ComboBox5.Text, ComboBox6.Text, TextBox9.Text, TextBox5.Text, TextBox10.Text, TextBox11.Text, a)
        Me.ESTUDIANTESTableAdapter.EDITAR(TextBox6.Text, TextBox7.Text, ComboBox4.Text, TextBox8.Text, ComboBox5.Text, ComboBox6.Text, TextBox9.Text, TextBox5.Text, TextBox10.Text, TextBox11.Text, a)

        Me.ESTUDIANTESTableAdapter.Fill(Me.DATABASEDataSet.ESTUDIANTES)
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        TextBox8.Enabled = False
        TextBox10.Enabled = False
        TextBox11.Enabled = False
        ComboBox4.Enabled = False
        ComboBox5.Enabled = False

    End Sub

    Private Sub BorrarEstudiante_Click(sender As Object, e As EventArgs) Handles borrarEstudiante.Click
        Me.ESTUDIANTESTableAdapter.BORRAR(TextBox8.Text)
        Me.ESTUDIANTESTableAdapter.Fill(Me.DATABASEDataSet.ESTUDIANTES)
    End Sub

    Private Sub BuscarNombre_Click(sender As Object, e As EventArgs) Handles buscarNombre.Click
        Me.ESTUDIANTESTableAdapter.FillBy(DATABASEDataSet.ESTUDIANTES, TextBox12.Text)
    End Sub

    Private Sub TextBox12_Click(sender As Object, e As EventArgs)
        TextBox12.Text = ""
        TextBox12.ForeColor = Color.Black
    End Sub

    Private Sub AgregarEstudianteNuevo_Click(sender As Object, e As EventArgs) Handles agregarEstudianteNuevo.Click
        TextBox6.Enabled = True
        TextBox7.Enabled = True
        TextBox8.Enabled = True
        TextBox5.Enabled = True
        ComboBox4.Enabled = True
        ComboBox5.Enabled = True
        TextBox6.Text = ""
        TextBox7.Text = ""
        ComboBox4.Text = ""
        TextBox8.Text = ""
        ComboBox5.Text = ""
        TextBox5.Text = ""
        TextBox10.Text = 0
        TextBox11.Text = 0
        ComboBox6.Text = ComboBox2.Text
        TextBox9.Text = TextBox4.Text
        agregarEstudiantes.Enabled = True
        masInasistencias.Enabled = True
        masRetrasos.Enabled = True
        ToolStripButton3.Enabled = True
        ToolStripButton5.Enabled = True
        borrarEstudiante.Enabled = True
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Me.ESTUDIANTESTableAdapter.Insert(TextBox6.Text, TextBox7.Text, ComboBox4.Text, TextBox8.Text, ComboBox5.Text, ComboBox6.Text, TextBox9.Text, TextBox5.Text, TextBox10.Text, TextBox11.Text, a)
        Me.ESTUDIANTESTableAdapter.Fill(Me.DATABASEDataSet.ESTUDIANTES)
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Me.ESTUDIANTESTableAdapter.BORRAR(TextBox6.Text)
        Me.ESTUDIANTESTableAdapter.Fill(Me.DATABASEDataSet.ESTUDIANTES)
    End Sub

    Private Sub TextBox12_MouseHover(sender As Object, e As EventArgs) Handles TextBox12.MouseHover
        TextBox12.Text = ""
        TextBox12.ForeColor = Color.Black
    End Sub

    Private Sub TextBox12_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox12.KeyDown
        Buscador.Enabled = True
    End Sub

    Private Sub Buscador_Tick(sender As Object, e As EventArgs) Handles Buscador.Tick
        Me.ESTUDIANTESTableAdapter.FillBy(DATABASEDataSet.ESTUDIANTES, TextBox12.Text)
    End Sub

    Private Sub TextBox12_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox12.KeyUp
        Buscador.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ESTUDIANTESTableAdapter.Fill(Me.DATABASEDataSet.ESTUDIANTES)
    End Sub

    Private Sub Verificación_Tick(sender As Object, e As EventArgs) Handles Verificación.Tick
        If TextBox1.Text <> "" Then
            mostrarestudiantes.Enabled = True
        Else
            mostrarestudiantes.Enabled = False
        End If
    End Sub

    Private Sub TextBox13_MouseHover(sender As Object, e As EventArgs)
        TextBox13.Text = ""
        TextBox13.ForeColor = Color.Black
        TextBox13.PasswordChar = "•"
    End Sub

    Private Sub TextBox13_MouseLeave(sender As Object, e As EventArgs)
        TextBox13.Text = "Escribe el PIN aquí para ingresar como lider"
        TextBox13.PasswordChar = ""
        TextBox13.ForeColor = Color.Gray
    End Sub

    Private Sub TextBox13_MouseHover_1(sender As Object, e As EventArgs) Handles TextBox13.MouseHover
        TextBox13.Text = ""
        TextBox13.ForeColor = Color.Black
        TextBox13.PasswordChar = "•"
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox13.Text = "123456" Then
            Panel1.Visible = False
            RichTextBox1.Visible = True
            Label33.Visible = True
            Label34.Visible = True
            Label35.Visible = True
            Label36.Visible = True
        Else
            MsgBox("Si no eres el lider de tu ficha te recomentamos que no intentes ingresar a este sistema de administración de estudiantes.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Inasistencias.Show()
    End Sub
End Class
