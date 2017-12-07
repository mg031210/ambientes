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
        If dgvProvee(0, dgvProvee.CurrentRow.Index).Value IsNot DBNull.Value Then
            txtid.Text = dgvProvee(0, dgvProvee.CurrentRow.Index).Value
        Else
            txtid.Text = ""
        End If
        If dgvProvee(1, dgvProvee.CurrentRow.Index).Value IsNot DBNull.Value Then
            txtnombre.Text = dgvProvee(1, dgvProvee.CurrentRow.Index).Value
        Else
            txtnombre.Text = ""
        End If
        If dgvProvee(2, dgvProvee.CurrentRow.Index).Value IsNot DBNull.Value Then
            txtrfc.Text = dgvProvee(2, dgvProvee.CurrentRow.Index).Value
        Else
            txtrfc.Text = ""
        End If
        If dgvProvee(3, dgvProvee.CurrentRow.Index).Value IsNot DBNull.Value Then
            txttel1.Text = dgvProvee(3, dgvProvee.CurrentRow.Index).Value
        Else
            txttel1.Text = ""
        End If
        If dgvProvee(4, dgvProvee.CurrentRow.Index).Value IsNot DBNull.Value Then
            txttel2.Text = dgvProvee(4, dgvProvee.CurrentRow.Index).Value
        Else
            txttel2.Text = ""
        End If
        If dgvProvee(5, dgvProvee.CurrentRow.Index).Value IsNot DBNull.Value Then
            txtfax.Text = dgvProvee(5, dgvProvee.CurrentRow.Index).Value
        Else
            txtfax.Text = ""
        End If
        If dgvProvee(6, dgvProvee.CurrentRow.Index).Value IsNot DBNull.Value Then
            txtdir.Text = dgvProvee(6, dgvProvee.CurrentRow.Index).Value
        Else
            txtdir.Text = ""
        End If
        If dgvProvee(7, dgvProvee.CurrentRow.Index).Value IsNot DBNull.Value Then
            txtcodigo.Text = dgvProvee(7, dgvProvee.CurrentRow.Index).Value
        Else
            txtcodigo.Text = ""
        End If
        If dgvProvee(8, dgvProvee.CurrentRow.Index).Value IsNot DBNull.Value Then
            txtemail.Text = dgvProvee(8, dgvProvee.CurrentRow.Index).Value
        Else
            txtemail.Text = ""
        End If
        If dgvProvee(9, dgvProvee.CurrentRow.Index).Value IsNot DBNull.Value Then
            txtcontacto.Text = dgvProvee(9, dgvProvee.CurrentRow.Index).Value
        Else
            txtcontacto.Text = ""
        End If
    End Sub

    Private Sub limpiar()
        Dim provee As New ClaseProvee
        provee.selectAllmod(dgvProvee)
        txtnombre.Text = ""
        txtrfc.Text = ""
        txttel1.Text = ""
        txttel2.Text = ""
        txtfax.Text = ""
        txtdir.Text = ""
        txtcodigo.Text = ""
        txtemail.Text = ""
        txtcontacto.Text = ""
        txtBId.Text = ""
        txtid.Text = ""
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
        provee.actualiza(txtnombre.Text, txtrfc.Text, txttel1.Text, txttel2.Text, txtfax.Text, txtdir.Text, txtcodigo.Text, txtemail.Text, txtcontacto.Text, txtid.Text)
        limpiar()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Dim provee As New ClaseProvee
        provee.elimina(dgvProvee(0, dgvProvee.CurrentRow.Index).Value)
        limpiar()
    End Sub
    Private Sub txtBId_GotFocus(sender As Object, e As EventArgs) Handles txtBId.GotFocus
        txtBTitulo.Text = ""
    End Sub

    Private Sub txtBTitulo_GotFocus(sender As Object, e As EventArgs) Handles txtBTitulo.GotFocus
        txtBId.Text = ""
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class