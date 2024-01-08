Public Class Registro
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Usuario = TextBox1.Text
        My.Settings.Contraseña = TextBox2.Text

        My.Settings.Save()

        Form1.Show()
        Me.Hide()










    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = TextBox2.Text Then
            Button1.Enabled = True
        ElseIf TextBox1.Text = "" Then
            Button1.Enabled = False

        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class