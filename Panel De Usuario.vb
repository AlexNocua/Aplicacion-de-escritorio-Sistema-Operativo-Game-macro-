Public Class Panel_De_Usuario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("No has ingresado ningun nombre")
        Else
            Form2.Label1.Text = TextBox1.Text
            Label4.Visible = True





        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False

    End Sub




    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form2.PictureBox4.Image = My.Resources.de_viaje
        Label5.Visible = True

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form2.PictureBox4.Image = My.Resources.carro_deportivo
        Label5.Visible = True
    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form2.PictureBox4.Image = My.Resources.assassin_avatar_114347
        Label5.Visible = True
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Form2.PictureBox4.Image = My.Resources.encabezamiento
        Label5.Visible = True
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Form2.PictureBox4.Image = My.Resources.diver_avatar_114346
        Label5.Visible = True
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Form2.PictureBox4.Image = My.Resources.fireman_avatar_114351
        Label5.Visible = True
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Form2.PictureBox4.Image = My.Resources.robot01_90832
        Label5.Visible = True
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Form2.PictureBox4.Image = My.Resources.soldier_avatar_114340
        Label5.Visible = True
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Form2.PictureBox4.Image = My.Resources.pelear
        Label5.Visible = True
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Form2.PictureBox1.Image = My.Resources.minecraft_6923660_1920
        Label6.Visible = True
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Form2.PictureBox1.Image = My.Resources.tunnel_3233082_1920
        Label6.Visible = True
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Form2.PictureBox1.Image = My.Resources.car_5161457_1920
        Label6.Visible = True
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Form2.PictureBox1.Image = My.Resources.spartan_1751249_1920
        Label6.Visible = True
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class