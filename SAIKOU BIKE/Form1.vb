Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim lang As String
        lang = Language.Text
        Language.DropDownStyle = AutoCompleteMode.SuggestAppend
    End Sub

    Private Sub Language_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Language.SelectedIndexChanged

    End Sub
End Class
