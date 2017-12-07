Public Class modTraba
    Private Sub BunifuCustomTextbox1_TextChanged(sender As Object, e As EventArgs) Handles txtBId.TextChanged
        Dim trab As New ClaseTrabajador
        trab.consultaID(txtBId.Text, dgvTrab)
    End Sub

    Private Sub txtBTitulo_TextChanged(sender As Object, e As EventArgs) Handles txtBTitulo.TextChanged
        Dim trab As New ClaseTrabajador
        trab.consultaTitulo(txtBTitulo.Text, dgvTrab)
    End Sub
    Private Sub txtBId_GotFocus(sender As Object, e As EventArgs) Handles txtBId.GotFocus
        txtBTitulo.Text = ""
    End Sub

    Private Sub txtBTitulo_GotFocus(sender As Object, e As EventArgs) Handles txtBTitulo.GotFocus
        txtBId.Text = ""
    End Sub
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
    Private Sub limpiar()
        Dim trab As New ClaseTrabajador
        trab.selectAll(dgvTrab)
        txtid.Text = ""
        txtuser.Text = ""
        txtpass.Text = ""
        txtnombre.Text = ""
        txtapp.Text = ""
        txtapm.Text = ""
        txttel.Text = ""
        txtcel.Text = ""
        txtdir.Text = ""
    End Sub


    Private Sub modTraba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim trab As New ClaseTrabajador
        dgvTrab.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        trab.selectAll(dgvTrab)
    End Sub



    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Dim trab As New ClaseTrabajador
        trab.actualiza(txtid.Text, txtuser.Text, txtapp.Text, txtnombre.Text, txtpass.Text, txtdir.Text, txtcel.Text, txtapm.Text, txttel.Text, txtid.Text)
        limpiar()
    End Sub

    Private Sub dgvTrab_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvTrab.MouseDoubleClick
        If dgvTrab(0, dgvTrab.CurrentRow.Index).Value IsNot DBNull.Value Then
            txtid.Text = dgvTrab(0, dgvTrab.CurrentRow.Index).Value
        Else
            txtid.Text = ""
        End If
        If dgvTrab(1, dgvTrab.CurrentRow.Index).Value IsNot DBNull.Value Then
            txtuser.Text = dgvTrab(1, dgvTrab.CurrentRow.Index).Value
        Else
            txtuser.Text = ""
        End If
        If dgvTrab(2, dgvTrab.CurrentRow.Index).Value IsNot DBNull.Value Then
            txtpass.Text = dgvTrab(2, dgvTrab.CurrentRow.Index).Value
        Else
            txtpass.Text = ""
        End If
        If dgvTrab(3, dgvTrab.CurrentRow.Index).Value IsNot DBNull.Value Then
            txtnombre.Text = dgvTrab(3, dgvTrab.CurrentRow.Index).Value
        Else
            txtnombre.Text = ""
        End If
        If dgvTrab(4, dgvTrab.CurrentRow.Index).Value IsNot DBNull.Value Then
            txtapp.Text = dgvTrab(4, dgvTrab.CurrentRow.Index).Value
        Else
            txtapp.Text = ""
        End If
        If dgvTrab(5, dgvTrab.CurrentRow.Index).Value IsNot DBNull.Value Then
            txtapm.Text = dgvTrab(5, dgvTrab.CurrentRow.Index).Value
        Else
            txtapm.Text = ""
        End If
        If dgvTrab(6, dgvTrab.CurrentRow.Index).Value IsNot DBNull.Value Then
            txttel.Text = dgvTrab(6, dgvTrab.CurrentRow.Index).Value
        Else
            txttel.Text = ""
        End If
        If dgvTrab(7, dgvTrab.CurrentRow.Index).Value IsNot DBNull.Value Then
            txtcel.Text = dgvTrab(7, dgvTrab.CurrentRow.Index).Value
        Else
            txtcel.Text = ""
        End If
        If dgvTrab(8, dgvTrab.CurrentRow.Index).Value IsNot DBNull.Value Then
            txtdir.Text = dgvTrab(8, dgvTrab.CurrentRow.Index).Value
        Else
            txtdir.Text = ""
        End If
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Dim trab As New ClaseTrabajador
        trab.elimina(dgvTrab(0, dgvTrab.CurrentRow.Index).Value)
        limpiar()
    End Sub
End Class