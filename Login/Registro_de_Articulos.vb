Public Class Registro_de_Articulos
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim box = New Registro_de_Ventas()
        Registro_de_Ventas.Show()

    End Sub
End Class