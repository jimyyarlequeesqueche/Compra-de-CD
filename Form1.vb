Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Informacion del Artista
        Dim precio As Double = 15.5
        Dim Impor As Double = 2%
        Dim Can As String = "Remix Sasha Grey"
        Dim Art As String = "Sasha Grey"
        Dim Año As String = "2016"
        'llamar a la imagen 

        'PictureBox1.Image = Image.FromFile("" + CStr("Sashaimag") + ".jpg")
        ' LLamar a los laves
        L_Can.Text = Can.ToString() : L_Art.Text = Art.ToString() : L_Añ.Text = Año.ToString()
        L_preSasha.Text = precio.ToString : L_impSasha.Text = Impor.ToString

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'codgo de la compra para el primer artista
        Dim precio As Double = 15.5
        Dim imp As Double = precio * 0.2
        Dim total As Double = precio + imp
        'hbsand

        L_Tot.Text = total.ToString

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Informacion del Artista
        Dim Can As String = "Bohemian Rhapsody"
        Dim Art As String = "The Queen"
        Dim Año As String = "1980"
        ' LLamar a los laves
        L_Can.Text = Can.ToString() : L_Art.Text = Art.ToString() : L_Añ.Text = Año.ToString()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Informacion del Artista
        Dim Can As String = "Night Fever"
        Dim Art As String = "Bee Gees"
        Dim Año As String = "1977"
        ' LLamar a los laves
        L_Can.Text = Can.ToString() : L_Art.Text = Art.ToString() : L_Añ.Text = Año.ToString()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub
End Class
