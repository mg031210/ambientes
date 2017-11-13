Public Class addProvee
    Private Sub BunifuCustomTextbox10_TextChanged(sender As Object, e As EventArgs) Handles txttel1.TextChanged

    End Sub

    Private Sub BunifuCustomTextbox9_TextChanged(sender As Object, e As EventArgs) Handles txtcontacto.TextChanged

    End Sub

    Private Sub txtcodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigo.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtfax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfax.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txttel1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttel1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txttel2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttel2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Dim provee As New ClaseProvee
        provee.inserta(txtnombre.Text, txtrfc.Text, txttel1.Text, txttel2.Text, txtfax.Text, txtdir.Text, txtcodigo.Text, txtemail.Text, txtcontacto.Text)
        limpiar()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        limpiar()
    End Sub
    Private Sub limpiar()
        txtnombre.Text = ""
        txtrfc.Text = ""
        txttel1.Text = ""
        txttel2.Text = ""
        txtfax.Text = ""
        txtdir.Text = ""
        txtcodigo.Text = ""
        txtemail.Text = ""
        txtcontacto.Text = ""
    End Sub

    Private Sub addProvee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class