Public Class addPeli
    Private Sub BunifuCustomTextbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdur.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        limpiar()
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Dim peli As New ClasePeli
        If radiocat.Checked Then
            peli.inserta(txtcodigo.Text, txtclas.Text, txtdur.Text, txttitulo.Text, txtcategoria.Text, tipoCat)
        Else
            peli.inserta(txtcodigo.Text, txtclas.Text, txtdur.Text, txttitulo.Text, txtcategoria.Text, tipoEst)
        End If
        limpiar()
    End Sub

    Private Sub limpiar()
        txtcodigo.Text = ""
        txtclas.Text = ""
        txtdur.Text = ""
        txttitulo.Text = ""
        txtcategoria.Text = ""
    End Sub
End Class