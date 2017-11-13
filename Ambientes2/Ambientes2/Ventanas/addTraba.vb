Imports System.Security.Cryptography

Public Class addTraba

    Private Sub txtcel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcel.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txttel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttel.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Dim trab As New ClaseTrabajador
        Dim HashedPass As String = ""

        Using MD5hash As MD5 = MD5.Create()
            HashedPass = Convert.ToBase64String(MD5hash.ComputeHash(System.Text.Encoding.ASCII.GetBytes(txtpass.Text)))
        End Using

        trab.inserta(txttrab.Text, txtuser.Text, HashedPass, txtnombre.Text, txtapp.Text, txtapm.Text, txttel.Text, txtcel.Text, txtdir.Text)
        limpiar()
    End Sub

    Private Sub limpiar()
        txttrab.Text = ""
        txtuser.Text = ""
        txtpass.Text = ""
        txtnombre.Text = ""
        txtapp.Text = ""
        txtapm.Text = ""
        txttel.Text = ""
        txtcel.Text = ""
        txtdir.Text = ""
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        limpiar()

    End Sub
End Class