

Public Class facture
    Dim prix As Integer

    Private Sub facture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lstboissoin.Items.Add("Café")
        Lstboissoin.Items.Add("Jus d'orange")
        Lstboissoin.Items.Add("Eau minérale")
        Lstboissoin.Items.Add("Citronade")
    End Sub

    Private Sub Btc_Click(sender As Object, e As EventArgs) Handles Btc.Click

        Dim commande As String

        If Rdp.Checked Then
            commande = "Pizza"
            prix = 10
        ElseIf Rdburger.Checked Then
            commande = "Burger"
            prix = 8
        ElseIf Rdpate.Checked Then
            commande = "Pâtes"
            prix = 15
        End If

        For Each ctrl As Control In gpbs.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                If cb.Checked Then
                    commande &= " + " & cb.Text
                    Select Case cb.Text
                        Case "Fromage" : prix += 2
                        Case "Frites" : prix += 3
                        Case "Dessert" : prix += 5
                    End Select
                End If
            End If
        Next


        If Lstboissoin.SelectedItem IsNot Nothing Then
            commande &= " + " & Lstboissoin.SelectedItem.ToString()
            prix += 10
        End If

        Lblf.Text = commande & " | Total : " & prix & " DT"
    End Sub


    Private Sub Bta_Click(sender As Object, e As EventArgs) Handles Bta.Click

        prix = 0


        Rdp.Checked = False
        Rdburger.Checked = False
        Rdpate.Checked = False

        For Each ctrl As Control In gpbs.Controls
            If TypeOf ctrl Is CheckBox Then
                DirectCast(ctrl, CheckBox).Checked = False
            End If
        Next


        Lstboissoin.ClearSelected()


        Lblf.Text = ""
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class