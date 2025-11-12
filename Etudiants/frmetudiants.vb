Public Class Frmetudiants
    Private Sub Btnajo_Click(sender As Object, e As EventArgs) Handles Btnajo.Click
        Dim test As Boolean = True
        Dim nom As String = Txtn.Text.Trim()
        Dim prenom As String = Txtp.Text.Trim()
        Dim note As Double
        Dim etu As etudiants.etudiants
        ErrorProvider.Clear()

        If nom = "" Then
            ErrorProvider.SetError(Txtn, "Veuillez indiquer le nom.")
            test = False
        End If

        If prenom = "" Then
            ErrorProvider.SetError(Txtp, "Veuillez indiquer le prénom.")
            test = False
        End If

        If Not Double.TryParse(Txtno.Text, note) Then
            ErrorProvider.SetError(Txtno, "Veuillez entrer une note numérique.")
            test = False
        ElseIf note < 0 OrElse note > 20 Then
            ErrorProvider.SetError(Txtno, "Veuillez indiquer une note entre 0 et 20.")
            test = False
        End If

        If test Then
            etu.nom = nom
            etu.prenom = prenom
            etu.note = note
            ajouter(etu)
        End If
    End Sub

    Private Sub Txtno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtno.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnAfficher_Click(sender As Object, e As EventArgs) Handles BtnAfficher.Click
        dgvetudiants.Rows.Clear()

        If listeetudiants.Count = 0 Then
            MessageBox.Show("Aucun étudiant enregistré.", "Information")
            Exit Sub
        End If

        For Each et As etudiants.etudiants In listeetudiants
            dgvetudiants.Rows.Add(et.nom, et.prenom, et.note)
        Next
    End Sub

    Private Sub Btnsupp_Click(sender As Object, e As EventArgs) Handles Btnsupp.Click
        Txtn.Clear()
        Txtp.Clear()
        Txtno.Clear()
    End Sub
End Class