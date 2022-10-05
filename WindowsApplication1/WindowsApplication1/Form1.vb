Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, men As Integer
        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt32(TextBox3.Text)
etiqueta1:
        If a > b Then
            men = b
            b = a
            a = men
        End If
        If b > c Then
            men = c
            c = b
            b = men
            GoTo etiqueta1
        Else
            GoTo salir
        End If
salir:
        TextBox1.Text = Convert.ToString(a)
        TextBox2.Text = Convert.ToString(b)
        TextBox3.Text = Convert.ToString(c)
    End Sub
End Class
