
Public Class calculatrise
    Dim A As Double
    Dim B As Double
    Dim s As Double
    Dim ch As String = ""
    Dim test As Boolean = False

    Private Sub Btnplus_Click(sender As Object, e As EventArgs) Handles Btnplus.Click
        A = Val(TextA.Text)
        B = Val(TextB.Text)
        s = A + B
        ch = TextA.Text & " + " & TextB.Text & " =" & s
        test = True
    End Sub

    Private Sub Btnmoins_Click(sender As Object, e As EventArgs) Handles Btnmoins.Click
        A = Val(TextA.Text)
        B = Val(TextB.Text)
        s = A - B
        ch = TextA.Text & " - " & TextB.Text & " =" & s
        test = True
    End Sub

    Private Sub Btnmulti_Click(sender As Object, e As EventArgs) Handles Btnmulti.Click
        A = Val(TextA.Text)
        B = Val(TextB.Text)
        s = A * B
        ch = TextA.Text & " * " & TextB.Text & " =" & s
        test = True
    End Sub

    Private Sub Btnsoustra_Click(sender As Object, e As EventArgs) Handles Btnsoustra.Click
        A = Val(TextA.Text)
        B = Val(TextB.Text)
        s = A / B
        If B = 0 Then
            MessageBox.Show("Div par zero impossible", "erreur")

        End If
        ch = TextA.Text & " / " & TextB.Text & " =" & s
        test = True
    End Sub

    Private Sub Btnegale_Click(sender As Object, e As EventArgs) Handles Btnegale.Click
        If TextA.Text = "" Or TextB.Text = "" Then
            MessageBox.Show("veuillez introduire les valeurs de a et b", "erreur")
            test = False

        End If
        If test Then
            Lblres.Text = ch

        End If
    End Sub

    Private Sub Btnrest_Click(sender As Object, e As EventArgs) Handles Btnrest.Click
        TextA.Text = ""
        TextB.Text = ""
        Lblres.Text = ""
        test = False

    End Sub
End Class


