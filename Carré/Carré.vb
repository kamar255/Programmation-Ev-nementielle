Public Class Carré
    Function Carre(x As Double) As Double
        Return x * x
    End Function
    Private Sub ButtonCalcul_Click(sender As Object, e As EventArgs) Handles Buttoncalcul.Click
        Dim saisie As String = Txtnb.Text
        Dim nombre As Double

        If Double.TryParse(saisie, nombre) Then
            Dim resultat As Double = Carre(nombre)
            LabelResultat.Text = "Le carré de " & nombre & " est " & resultat
        Else
            MessageBox.Show("Veuillez entrer un nombre valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
