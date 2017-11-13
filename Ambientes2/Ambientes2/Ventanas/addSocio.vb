Public Class addSocio

    Private Sub txttel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttel.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtcel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcel.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Dim socio As New ClaseSocio
        socio.inserta(txtSocio.Text, txtnombre.Text, txtapp.Text, txtapm.Text, txtdir.Text, txttel.Text, txtcel.Text)
    End Sub
    Private Sub limpiar()
        txtapm.Text = ""
        txtapp.Text = ""
        txtcel.Text = ""
        txttel.Text = ""
        txtnombre.Text = ""
        txtSocio.Text = ""
        txtdir.Text = ""
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        limpiar()
    End Sub
End Class