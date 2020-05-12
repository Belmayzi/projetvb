Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nbr_1 As Double
        Dim nbr_2 As Double
        Dim nbr_3 As Double
        Dim resultat As Double
        nbr_1 = TextBox1.Text
        nbr_2 = TextBox2.Text
        nbr_3 = TextBox3.Text

        If RadioButton1.Checked = True Then
            resultat = nbr_1 + nbr_2 + nbr_3
            MsgBox("résultat = " & resultat)
        ElseIf RadioButton2.Checked = True Then
            resultat = nbr_3 - nbr_2 - nbr_1
            MsgBox("résultat = " & resultat)
        ElseIf RadioButton3.Checked = True Then
            resultat = nbr_1 * nbr_2 * nbr_3
            MsgBox("résultat = " & resultat)
        ElseIf RadioButton4.Checked = True Then
            resultat = nbr_3 / nbr_2
            MsgBox("résultat = " & resultat)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


End Class

