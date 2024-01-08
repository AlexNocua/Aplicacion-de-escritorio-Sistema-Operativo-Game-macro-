Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.Usuario And TextBox2.Text = My.Settings.Contraseña Then
            Form2.Show()
            Me.Hide()

        Else
            MsgBox("Usuario o Contraseña Incorrecta")


        End If
    End Sub
End Class