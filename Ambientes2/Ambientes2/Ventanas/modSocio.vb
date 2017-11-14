Public Class modSocio

    Private Sub BunifuCustomTextbox1_TextChanged(sender As Object, e As EventArgs) Handles txtBId.TextChanged
        Dim socio As New ClaseSocio
        socio.consultaIDmod(txtBId.Text, dgvSocio)
    End Sub

    Private Sub txtBTitulo_TextChanged(sender As Object, e As EventArgs) Handles txtBTitulo.TextChanged
        Dim socio As New ClaseSocio
        socio.consultaTitulmod(txtBTitulo.Text, dgvSocio)
    End Sub

    Private Sub dgvPelis_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvSocio.MouseDoubleClick
        If dgvSocio(0, dgvSocio.CurrentRow.Index).Value IsNot DBNull.Value Then
            txtSocio.Text = dgvSocio(0, dgvSocio.CurrentRow.Index).Value
        Else
            txtSocio.Text = ""
        End If
        If dgvSocio(3, dgvSocio.CurrentRow.Index).Value IsNot DBNull.Value Then
            txtapm.Text = dgvSocio(3, dgvSocio.CurrentRow.Index).Value
        Else
            txtapm.Text = ""
        End If
        If dgvSocio(2, dgvSocio.CurrentRow.Index).Value IsNot DBNull.Value Then
            txtapp.Text = dgvSocio(2, dgvSocio.CurrentRow.Index).Value
        Else
            txtapp.Text = ""
        End If
        If dgvSocio(5, dgvSocio.CurrentRow.Index).Value IsNot DBNull.Value Then
            txtcel.Text = dgvSocio(5, dgvSocio.CurrentRow.Index).Value
        Else
            txtcel.Text = ""
        End If
        If dgvSocio(4, dgvSocio.CurrentRow.Index).Value IsNot DBNull.Value Then
            txttel.Text = dgvSocio(4, dgvSocio.CurrentRow.Index).Value
        Else
            txttel.Text = ""
        End If
        If dgvSocio(1, dgvSocio.CurrentRow.Index).Value IsNot DBNull.Value Then
            txtnombre.Text = dgvSocio(1, dgvSocio.CurrentRow.Index).Value
        Else
            txtnombre.Text = ""
        End If
        If dgvSocio(6, dgvSocio.CurrentRow.Index).Value IsNot DBNull.Value Then
            txtdir.Text = dgvSocio(6, dgvSocio.CurrentRow.Index).Value
        Else
            txtdir.Text = ""
        End If
    End Sub

    Private Sub modSocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim socio As New ClaseSocio
        dgvSocio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        socio.selectAllmod(dgvSocio)
    End Sub
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

    Private Sub limpiar()
        Dim socio As New ClaseSocio
        socio.selectAllmod(dgvSocio)
        txtapm.Text = ""
        txtapp.Text = ""
        txtcel.Text = ""
        txttel.Text = ""
        txtnombre.Text = ""
        txtSocio.Text = ""
        txtdir.Text = ""
    End Sub

    Private Sub txtBId_GotFocus(sender As Object, e As EventArgs) Handles txtBId.GotFocus
        txtBTitulo.Text = ""
    End Sub

    Private Sub txtBTitulo_GotFocus(sender As Object, e As EventArgs) Handles txtBTitulo.GotFocus
        txtBId.Text = ""
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Dim socio As New ClaseSocio
        socio.elimina(dgvSocio(0, dgvSocio.CurrentRow.Index).Value)
        limpiar()
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Dim socio As New ClaseSocio
        socio.actualiza(txtnombre.Text, txtcel.Text, txtapp.Text, txttel.Text, txtapm.Text, txtdir.Text, txtSocio.Text, dgvSocio(0, dgvSocio.CurrentRow.Index).Value)
        limpiar()

    End Sub
End Class