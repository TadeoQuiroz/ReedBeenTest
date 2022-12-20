Public Class Registro_de_Articulos
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height

        Me.Height = screenHeight - 63
        Me.Width = screenWidth - 241

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button1.Click


    End Sub

End Class