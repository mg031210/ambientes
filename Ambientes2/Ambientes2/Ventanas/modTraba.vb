Public Class modTraba
    Private Sub txtBId_LostFocus(sender As Object, e As EventArgs) Handles txtBId.LostFocus
        txtBId.Text = ""
    End Sub

    Private Sub txtBTitulo_LostFocus(sender As Object, e As EventArgs) Handles txtBTitulo.LostFocus
        txtBTitulo.Text = ""
    End Sub

End Class