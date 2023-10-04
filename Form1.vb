Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim PI As Double
        Dim A As Double
        Dim r As Double
        PI = 3.14
        A = PI * r * r
        r = Val(TextBox1.Text)

        TextBox2.Text = A

    End Sub
End Class
