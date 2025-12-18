Public Class Trajetbus
    Private Sub Trajetbus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BtnAjouter_Click(sender As Object, e As EventArgs) Handles BtnAjouter.Click
        Dim r As Reservations
        If lstLigne.SelectedIndex = -1 Then
            ErrorProvider1.SetError(lstLigne, "Veuillez selectionner une ligne.")
            Return
        End If
        r.ligne = lstLigne.Text
        If lstVilleDep.SelectedIndex = -1 Then
            ErrorProvider1.SetError(lstVilleDep, "Veuillez selectionner la ville de depart.")
            Return
        End If
        r.villeDepart = lstVilleDep.Text
        If lstVilleArrivee.SelectedIndex = -1 Then
            ErrorProvider1.SetError(lstVilleArrivee, "Veuillez selectionner la ville d'arrivée .")
            Return
        End If
        If lstVilleArrivee.Text = lstVilleDep.Text Then
            ErrorProvider1.SetError(lstVilleArrivee, " Veuillez selectionner une ville different de ville de départ. ")
            Return
        End If
        r.villeArrivee = lstVilleArrivee.Text
        If DTP_dep.Value < DateTime.Now.AddSeconds(-30) Then
            ErrorProvider1.SetError(DTP_dep, "Veuillez selectionner une date valide.")
            Return
        End If
        r.h_debut = DTP_dep.Value.ToString()
        If DTP_arri.Value <= DTP_dep.Value Then
            ErrorProvider1.SetError(DTP_arri, "Veuillez selectionner un date valide supérieur à " & DTP_dep.Value)
            Return
        End If
        r.h_fin = DTP_arri.Value.ToString()
        If NUD_places.Value <= 0 Then
            ErrorProvider1.SetError(NUD_places, "Veuillez saisie nombre de places a reserver.")
            Return
        End If
        r.places = CInt(NUD_places.Value)
        r.initReservation()
        If Chk_Clima.Checked Then
            r.Options.Add("Climatisation")
        End If
        If Chk_wifi.Checked Then
            r.Options.Add("Wifi")
        End If
        If Chk_bus.Checked Then
            r.Options.Add("Bus à étage")
        End If
        Dim test As Boolean = False
        For Each ctrl In GB_type.Controls
            If ctrl.checked Then
                r.type = ctrl.Text
                test = True
            End If
        Next
        If test = False Then
            ErrorProvider1.SetError(GB_type, "Veuillez selectionner un type de trajet.")
            Return
        End If
        If ajouterReservation(r) = False Then
            MessageBox.Show("Nombre de places insuffisants", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        DGV()
        Init()
    End Sub
    Private Sub DGV()
        dgvReservation.Rows.Clear()
        For Each r In listeReservation
            Dim optText As String = ""
            If r.Options.Count > 0 Then
                For Each opt As String In r.Options
                    If optText = "" Then
                        optText = opt
                    Else
                        optText &= "," & opt
                    End If
                Next
            Else
                optText = "__"
            End If
            dgvReservation.Rows.Add(r.ligne, r.villeDepart, r.villeArrivee, r.h_debut, r.h_fin, r.places, optText, r.type)
        Next
    End Sub
    Private Sub Init()
        lstLigne.SelectedIndex = -1
        lstVilleDep.SelectedIndex = -1
        lstVilleArrivee.SelectedIndex = -1
        NUD_places.Value = 0
        DTP_dep.Value = DateTime.Now
        DTP_arri.Value = DateTime.Now
        For Each ctrl In GB_type.Controls
            ctrl.checked = False
        Next
        ErrorProvider1.Clear()
        Chk_Clima.Checked = False
        Chk_wifi.Checked = False
        Chk_bus.Checked = False
    End Sub
    Private Sub Btnvider_Click(sender As Object, e As EventArgs) Handles Btnvider.Click
        Init()
    End Sub

    Private Sub Btnannuler_Click(sender As Object, e As EventArgs) Handles Btnannuller.Click
        If DGVReservation.CurrentRow IsNot Nothing Then
            Dim index As Integer = DGVReservation.CurrentRow.Index
            If index >= 0 AndAlso index < listeReservation.Count Then
                listeReservation.RemoveAt(index)
                DGV()
            End If
        Else
            MessageBox.Show("Veuillez sélectionner une réservation à supprimer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class

