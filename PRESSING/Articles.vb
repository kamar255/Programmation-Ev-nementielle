
Module Articles

    Public Structure article
        Dim code As String
        Dim vetement As String
        Dim typenettoyage As String
        Dim nb As Integer
        Dim supplement As List(Of Boolean)

        Public Sub initarticle()
            supplement = New List(Of Boolean)({False, False})
        End Sub
    End Structure

    Public listearticle As New List(Of article)

    Public Sub ajouterarticle(a As article)
        a.code = a.vetement.Substring(0, 1) & listearticle.Count.ToString()
        listearticle.Add(a)
    End Sub

End Module