Public Class Articles


    Private Sub btnajou_Click(sender As Object, e As EventArgs) Handles btnajou.Click
        Dim code As Integer
        Dim prix As Double
        Dim Qte As Integer
        Dim A As Article.article
        Dim test As Boolean = True

        ' Code
        If Integer.TryParse(Txtcode.Text, code) Then
            A.code = code
        Else
            test = False
            MessageBox.Show("Code article erroné !", "Erreur")
        End If

        ' Désignation
        If Txtdes.Text = "" Then
            test = False
            MessageBox.Show("Désignation article erronée !", "Erreur")
        Else
            A.designation = Txtdes.Text
        End If

        ' Prix
        If Double.TryParse(Txtprix.Text, prix) Then
            A.prix = prix
        Else
            test = False
            MessageBox.Show("Prix article erroné !", "Erreur")
        End If

        ' Quantité
        If Integer.TryParse(Txtqte.Text, Qte) Then
            A.quantite = Qte
        Else
            test = False
            MessageBox.Show("Quantité article erronée !", "Erreur")
        End If

        ' Ajout
        If test Then
            ajouterarticle(A)
            MessageBox.Show("Article ajouté avec succès !", "Ajout")
            EffacerChamps()
        End If
    End Sub

    Private Sub Btneff_Click(sender As Object, e As EventArgs) Handles Btneff.Click
        Dim code As Integer
        If Integer.TryParse(Txtcode.Text, code) Then
            SupprimerArticle(code)
            MessageBox.Show("Article supprimé (si existant).", "Suppression")
            EffacerChamps()
        Else
            MessageBox.Show("Code invalide !", "Erreur")
        End If
    End Sub

    Private Sub Btnaffich_Click(sender As Object, e As EventArgs)
        listeArticles.Clear()
        Dim totalStock As Double = 0
        Dim plusCher As Articles = Nothing
        Dim premier = True
    End Sub
    Private Sub EffacerChamps()
        Txtcode.Clear()
        Txtdes.Clear()
        Txtprix.Clear()
        Txtqte.Clear()
    End Sub
End Class