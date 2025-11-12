Public Class Mention
    Private Sub ButtonValider_Click(sender As Object, e As EventArgs) Handles BtnValider.Click
        Dim moyenne As Double
        If Double.TryParse(Txtmoy.Text, moyenne) Then
            If moyenne >= 10 Then
                lblres.Text = "Admis"
            ElseIf moyenne >= 8 Then
                lblres.Text = "Rattrapage"
            Else
                lblres.Text = "Ajourné"
            End If
        Else
            MessageBox.Show("Veuillez entrer une moyenne valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class

