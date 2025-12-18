Public Class PRES

    Private Sub btnajouter_Click(sender As Object, e As EventArgs) Handles btnajouter.Click
        Dim article As article
        Dim test As Boolean = False

        For Each ctrl In Gpvet.Controls

            If ctrl.checked Then
                article.vetement = ctrl.Text
                test = True
            End If

        Next
        If test = False Then
            ErrorProvider1.SetError(Gpvet, "Veuillez choisir un vêtement")
            Return
        End If

        test = False
        For Each ctrl In Gpsu.Controls
            If ctrl.checked Then
                article.typenettoyage = ctrl.text
                test = True

            End If
        Next
        If test = False Then
            ErrorProvider1.SetError(Gpsu, "Veuillez choisir un type")
            Return
        End If

        Dim nb As Integer
        nb = CInt(Nud_a.Value)
        If nb = 0 Then
            ErrorProvider1.SetError(Nud_a, "Le nombre doit être > 0")
            Return
        End If
        article.nb = nb


        article.initarticle()
        If Chk_f.Checked Then article.supplement(0) = True
        If Chk_a.Checked Then article.supplement(1) = True

        ajouterarticle(article)
        MAJ_DGV()
        supparticle()
    End Sub

    Private Sub MAJ_DGV()
        Dgva.Rows.Clear()
        For Each a As article In listearticle
            Dgva.Rows.Add(a.code, a.vetement, a.typenettoyage, String.Join(",", a.supplement))
        Next
    End Sub

    Private Sub supparticle()

        For Each ctrl As Control In Gpvet.Controls
            If TypeOf ctrl Is RadioButton Then
                DirectCast(ctrl, RadioButton).Checked = False
            End If
        Next
        For Each ctrl As Control In Gpsu.Controls
            If TypeOf ctrl Is RadioButton Then
                DirectCast(ctrl, RadioButton).Checked = False
            End If
        Next
        For Each ctrl As Control In Grtype.Controls
            If TypeOf ctrl Is CheckBox Then
                DirectCast(ctrl, CheckBox).Checked = False
            End If
        Next
        Nud_a.Value = 0
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Gpvet_Enter(sender As Object, e As EventArgs) Handles Gpvet.Enter

    End Sub
End Class

