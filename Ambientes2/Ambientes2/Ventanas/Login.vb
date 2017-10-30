Imports System.Security.Cryptography

Public Class Login
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub btnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        Dim con As New Conexion
        Dim DT As DataTable
        Dim HashedPass As String = ""

        Using MD5hash As MD5 = MD5.Create()
            HashedPass = Convert.ToBase64String(MD5hash.ComputeHash(System.Text.Encoding.ASCII.GetBytes(txtPass.Text)))
        End Using
        DT = con.selectStr("SELECT * FROM trabajador where numtrabajador='" & txtUser.Text & "' && contrasena='" & HashedPass & "' && estado='A' ;")
        If DT.Rows.Count = 1 Then
            txtUser.Text = "Numero"
            txtPass.Text = "Contrasena"
            session = DT.Rows(0)
            'MessageBox.Show("Bienvenido " & session.Item(4))
            msg.Visible = False
            formPrinc.Show()
            Me.Hide()
        Else
            msg.Visible = True
        End If
        con.close()
    End Sub

    Private Sub txtUser_OnValueChanged(sender As Object, e As EventArgs) Handles txtUser.OnValueChanged

    End Sub
End Class