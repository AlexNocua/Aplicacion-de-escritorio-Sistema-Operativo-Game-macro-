Public Class Canje_de_monedas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.Codigo1 Then
            MsgBox("Ya has introduciodo este codigo")
            TextBox1.Text = ""
        ElseIf TextBox1.Text = My.Settings.Codigo2 Then
            MsgBox("Ya has introduciodo este codigo")
            TextBox1.Text = ""
        ElseIf TextBox1.Text = My.Settings.Codigo3 Then
            MsgBox("Ya has introduciodo este codigo")
            TextBox1.Text = ""
        ElseIf TextBox1.Text = "44444" Then
            My.Settings.Codigo1 = TextBox1.Text
            My.Settings.Save()
            ProgressBar1.Visible = True
            CheckBox1.Checked = True
            Timer1.Start()
        ElseIf TextBox1.Text = "55555" Then
            My.Settings.Codigo2 = TextBox1.Text
            My.Settings.Save()
            ProgressBar1.Visible = True
            CheckBox1.Checked = True
            Timer1.Start()
        ElseIf TextBox1.Text = "66666" Then
            My.Settings.Codigo3 = TextBox1.Text
            My.Settings.Save()
            ProgressBar1.Visible = True
            CheckBox1.Checked = True
            Timer1.Start()
        ElseIf TextBox1.Text = "" Then
            MsgBox("No has introducido ningun codigo porfavor verificate bien!")

        Else
            MsgBox("Codigo Incorrecto")
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = +5
        ProgressBar1.Value = +10
        ProgressBar1.Value = +20
        ProgressBar1.Value = +25
        ProgressBar1.Value = +40
        ProgressBar1.Value = +60
        ProgressBar1.Value = +64
        ProgressBar1.Value = +65
        ProgressBar1.Value = +66
        ProgressBar1.Value = +67
        ProgressBar1.Value = +68
        ProgressBar1.Value = +69
        ProgressBar1.Value = +70
        ProgressBar1.Value = +80
        ProgressBar1.Value = +90
        ProgressBar1.Value = +100
        Timer1.Stop()
        If ProgressBar1.Value = +100 Then
            Form2.Coins.Text += 30
            MsgBox("Codigo Canjeado Correctamente!")
            ProgressBar1.Visible = False
            Me.Hide()
            TextBox1.Text = ""
            CheckBox1.Checked = False

        Else
            MsgBox("Codigo Incorrecto!")
        End If

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
        If CheckBox1.Checked = True Then
            Timer1.Start()
        Else
            MsgBox("Error del sistema favor de intentarlo masta tarde!")
        End If

    End Sub


End Class