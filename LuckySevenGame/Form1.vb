Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles value1.Click

    End Sub

    Private Sub value2_Click(sender As Object, e As EventArgs) Handles value2.Click

    End Sub

    Private Sub value3_Click(sender As Object, e As EventArgs) Handles value3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Sair.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Jogar.Click
        ImageResultado.Visible = False
        Randomize()
        value1.Text = CStr(Int(Rnd() * 10))
        value2.Text = CStr(Int(Rnd() * 10))
        value3.Text = CStr(Int(Rnd() * 10))
        If (value1.Text = "7") And (value2.Text = "7") And (value3.Text = "7") Then
            ImageResultado.Image = Image.FromFile("S:\WORKSPACE\UNINTER\C#\workspace\LuckySevenGameSln\maximo.jpeg")
            ImageResultado.Visible = True
            Beep()
        ElseIf (value1.Text = "7") Or (value2.Text = "7") Or (value3.Text = "7") Then
            ImageResultado.Image = Image.FromFile("S:\WORKSPACE\UNINTER\C#\workspace\LuckySevenGameSln\minimo.jpeg")
            ImageResultado.Visible = True
            Beep()
        Else
            ImageResultado.Image = Image.FromFile("S:\WORKSPACE\UNINTER\C#\workspace\LuckySevenGameSln\perdeu.jpeg")
            ImageResultado.Visible = True
            Beep()

        End If

    End Sub

    Private Sub ImageResultado_Click(sender As Object, e As EventArgs) Handles ImageResultado.Click

    End Sub


End Class
