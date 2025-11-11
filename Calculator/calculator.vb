Public Class calculator
    Dim old As Integer
    Dim opera As String

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        TxtRes.Text = TxtRes.Text & "1"
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        TxtRes.Text = TxtRes.Text & "2"
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        TxtRes.Text = TxtRes.Text & "3"
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        TxtRes.Text = TxtRes.Text & "4"
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        TxtRes.Text = TxtRes.Text & "5"
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        TxtRes.Text = TxtRes.Text & "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        TxtRes.Text = TxtRes.Text & "7"
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        TxtRes.Text = TxtRes.Text & "8"
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        TxtRes.Text = TxtRes.Text & "9"
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs)
        Txtres.Text = Txtres.Text & "0"
    End Sub

    Private Sub btnplus_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim text1 As String = TxtRes.Text
        old = Val(text1)
        TxtRes.Clear()
        opera = "+"
    End Sub

    Private Sub Btnmoin_Click(sender As Object, e As EventArgs) Handles BtnSub.Click
        Dim text1 As String = TxtRes.Text
        old = Val(text1)
        TxtRes.Clear()
        opera = "-"
    End Sub

    Private Sub Bntfoi_Click(sender As Object, e As EventArgs) Handles BtnMulti.Click
        Dim text1 As String = TxtRes.Text
        old = Val(text1)
        TxtRes.Clear()
        opera = "*"
    End Sub

    Private Sub btnsur_Click(sender As Object, e As EventArgs) Handles BtnDiv.Click
        Dim text1 As String = TxtRes.Text
        old = Val(text1)
        TxtRes.Clear()
        opera = "%"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnclear.Click
        old = 0
        opera = ""
        TxtRes.Text = ""
    End Sub

    Private Sub egale_Click(sender As Object, e As EventArgs) Handles Btnequals.Click
        Dim text2 As String
        Dim neww As Integer
        Dim res As Integer

        text2 = TxtRes.Text
        neww = Val(text2)

        If opera = "+" Then
            res = old + neww
        ElseIf opera = "-" Then
            res = old - neww
        ElseIf opera = "*" Then
            res = old * neww
        ElseIf opera = "%" Then
            If neww <> 0 Then
                res = old / neww
            Else
                TxtRes.Text = "Erreur"
                Exit Sub
            End If
        Else
            TxtRes.Text = "Erreur"
            Exit Sub
        End If

        TxtRes.Text = res
    End Sub

    Private Sub calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
