Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        While Val(InputBox("entrer la val ")) <> 0
            ListBox1.Items.Add(InputBox("entrer la val "))
        End While
    End Sub
End Class