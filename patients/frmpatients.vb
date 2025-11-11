Public Class frmpatients

    Private Sub frmpatients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbldate.Text = Date.Today.ToLongDateString()
    End Sub

    Private Sub Btnajouter_Click(sender As Object, e As EventArgs) Handles Btnajouter.Click
        Dim p As patient
        Dim nom As String
        Dim prenom As String
        Dim age As Integer
        If String.IsNullOrWhiteSpace(Txtnom.Text) Then
            ErrorProvider.SetError(Txtnom, "Nom invalide")
            Return
        End If
        If String.IsNullOrWhiteSpace(Txtprenom.Text) Then
            ErrorProvider.SetError(Txtprenom, "prenominvalide")
            Return
        End If

        p.nom = Txtnom.Text
        p.prenom = Txtprenom.Text
        p.age = CInt(txtage.Text)
        ajouterpatient(p)
        init()
        MAJ_DGV()

    End Sub
    Private Sub init()
        txtage.ResetText()
        Txtnom.Clear()
        Txtprenom.Clear()
    End Sub
    Private Sub MAJ_DGV()
        Dgvpatients.Rows.Clear()
        For Each p As patient In listpatients
            Dgvpatients.Rows.Add(p.code, p.nom, p.prenom, p.age)
        Next
    End Sub
    Private Sub Txtnom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtnom.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
    Private Sub Txtnprenom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtprenom.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
End Class

