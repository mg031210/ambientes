Public Class modProvee
    Private Sub BunifuCustomTextbox1_TextChanged(sender As Object, e As EventArgs) Handles txtBId.TextChanged
        Dim provee As New ClaseProvee
        provee.consultaID(txtBId.Text, dgvProvee)
    End Sub

    Private Sub txtBTitulo_TextChanged(sender As Object, e As EventArgs) Handles txtBTitulo.TextChanged
        Dim provee As New ClaseProvee
        provee.consultaTitulo(txtBTitulo.Text, dgvProvee)
    End Sub

    Private Sub modProvee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim provee As New ClaseProvee
        dgvProvee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        provee.selectAllmod(dgvProvee)
    End Sub

    Private Sub dgvProvee_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProvee.CellContentDoubleClick
        txtnombre.Text = dgvProvee(0, dgvProvee.CurrentRow.Index).Value
        txtrfc.Text = dgvProvee(1, dgvProvee.CurrentRow.Index).Value
        txttel1.Text = dgvProvee(2, dgvProvee.CurrentRow.Index).Value
        txttel2.Text = dgvProvee(3, dgvProvee.CurrentRow.Index).Value
        txtfax.Text = dgvProvee(4, dgvProvee.CurrentRow.Index).Value
        txtdir.Text = dgvProvee(5, dgvProvee.CurrentRow.Index).Value
        txtcodigo.Text = dgvProvee(6, dgvProvee.CurrentRow.Index).Value
        txtemail.Text = dgvProvee(7, dgvProvee.CurrentRow.Index).Value
        txtcontacto.Text = dgvProvee(8, dgvProvee.CurrentRow.Index).Value
    End Sub

    Private Sub limpiar()
        Dim provee As New ClaseProvee
        provee.consultaID(txtBId.Text, dgvProvee)
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
    Private Sub txtBId_LostFocus(sender As Object, e As EventArgs) Handles txtBId.LostFocus
        txtBId.Text = ""
    End Sub

    Private Sub txtBTitulo_LostFocus(sender As Object, e As EventArgs) Handles txtBTitulo.LostFocus
        txtBTitulo.Text = ""
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Dim provee As New ClaseProvee
        provee.actualiza(txtnombre.Text, txtrfc.Text, txttel1.Text, txttel2.Text, txtfax.Text, txtdir.Text, txtcodigo.Text, txtemail.Text, txtcontacto.Text, dgvProvee(1, dgvProvee.CurrentRow.Index).Value)
        limpiar()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        ''elminar
    End Sub
End Class