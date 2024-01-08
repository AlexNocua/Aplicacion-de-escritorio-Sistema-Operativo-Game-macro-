Public Class Tienda
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Form2.Coins.Text = "0" Then
            MsgBox("No tienes suficientes Monedas para comprar esta aplicacion")
        ElseIf Form2.Coins.Text = "1" Then
            MsgBox("No tienes suficientes Monedas para comprar esta aplicacion")

        ElseIf Form2.Coins.Text = "2" Then
            MsgBox("No tienes suficientes Monedas para comprar esta aplicacion")
        ElseIf Form2.Coins.Text = "3" Then
            MsgBox("No tienes suficientes Monedas para comprar esta aplicacion")
        ElseIf Form2.Coins.Text = "4" Then
            MsgBox("No tienes suficientes Monedas para comprar esta aplicacion")
        ElseIf Form2.Coins.Text = "5" Then
            MsgBox("No tienes suficientes Monedas para comprar esta aplicacion")
        ElseIf Form2.Coins.Text = "6" Then
            MsgBox("No tienes suficientes Monedas para comprar esta aplicacion")
        ElseIf Form2.Coins.Text = "7" Then
            MsgBox("No tienes suficientes Monedas para comprar esta aplicacion")
        ElseIf Form2.Coins.Text = "8" Then
            MsgBox("No tienes suficientes Monedass para comprar esta aplicacion")
        ElseIf Form2.Coins.Text = "9" Then
            MsgBox("No tienes suficientes Monedas para comprar esta aplicacion")
        ElseIf Form2.Coins.Text = "10" Then
            MsgBox("No tienes suficientes Monedas para comprar esta aplicacion")
        ElseIf Form2.Coins.Text = "11" Then
            MsgBox("No tienes suficientes Monedas para comprar esta aplicacion")
        ElseIf Form2.Coins.Text = "12" Then
            MsgBox("No tienes suficientes Monedas para comprar esta aplicacion")
        ElseIf Form2.Coins.Text = "13" Then
            MsgBox("No tienes suficientes Monedass para comprar esta aplicacion")
        ElseIf Form2.Coins.Text = "14" Then
            MsgBox("No tienes suficientes Monedas para comprar esta aplicacion")
        Else
            Form2.Coins.Text -= 15
            MsgBox("Aplicacion Instalada")
            Form2.Label7.Visible = True
            Form2.Label7.Text = "ColorMax"
            Form2.PictureBox9.Image = My.Resources.Aplicacion

            Form2.PictureBox9.Enabled = True
            Form2.TextBox5.Text = "El mejor brillo para tu pc"
        End If
    End Sub
End Class