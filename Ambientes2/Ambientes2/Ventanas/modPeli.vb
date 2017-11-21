Public Class modPeli
    Private Sub BunifuCustomTextbox1_TextChanged(sender As Object, e As EventArgs) Handles txtBId.TextChanged
        Dim peli As New ClasePeli
        peli.consultaID(txtBId.Text, dgvPelis)
    End Sub

    Private Sub txtBTitulo_TextChanged(sender As Object, e As EventArgs) Handles txtBTitulo.TextChanged
        Dim peli As New ClasePeli
        peli.consultaTitulo(txtBTitulo.Text, dgvPelis)
    End Sub

    Private Sub dgvPelis_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvPelis.MouseDoubleClick
        If dgvPelis(0, dgvPelis.CurrentRow.Index).Value IsNot DBNull.Value Then
            txtcodigo.Text = dgvPelis(0, dgvPelis.CurrentRow.Index).Value
        Else
            txtcodigo.Text = ""
        End If
        If dgvPelis(3, dgvPelis.CurrentRow.Index).Value IsNot DBNull.Value Then
            txtclas.Text = dgvPelis(3, dgvPelis.CurrentRow.Index).Value
        Else
            txtclas.Text = ""
        End If
        If dgvPelis(4, dgvPelis.CurrentRow.Index).Value IsNot DBNull.Value Then
            txtdur.Text = dgvPelis(4, dgvPelis.CurrentRow.Index).Value
        Else
            txtdur.Text = ""
        End If
        If dgvPelis(1, dgvPelis.CurrentRow.Index).Value IsNot DBNull.Value Then
            txttitulo.Text = dgvPelis(1, dgvPelis.CurrentRow.Index).Value
        Else
            txttitulo.Text = ""
        End If
        If dgvPelis(5, dgvPelis.CurrentRow.Index).Value IsNot DBNull.Value Then
            txtcategoria.Text = dgvPelis(5, dgvPelis.CurrentRow.Index).Value
        Else
            txtcategoria.Text = ""
        End If
        Dim check As String = dgvPelis(2, dgvPelis.CurrentRow.Index).Value
        If check = tipoCat Then
            radiocat.Checked = True
        ElseIf check = tipoEst Then
            radioestreno.Checked = True
        End If
    End Sub

    Private Sub BunifuCustomTextbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdur.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub modPeli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim peli As New ClasePeli
        dgvPelis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        peli.selectAllMod(dgvPelis)
    End Sub
    Private Sub limpiar()
        Dim peli As New ClasePeli
        peli.selectAllMod(dgvPelis)
        txtcodigo.Text = ""
        txtclas.Text = ""
        txtdur.Text = ""
        txttitulo.Text = ""
        txtcategoria.Text = ""
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Dim peli As New ClasePeli
        If radiocat.Checked Then
            peli.actualiza(txtcodigo.Text, txttitulo.Text, txtclas.Text, txtcategoria.Text, txtdur.Text, tipoCat)
        Else
            peli.actualiza(txtcodigo.Text, txttitulo.Text, txtclas.Text, txtcategoria.Text, txtdur.Text, tipoEst)
        End If
        limpiar()

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Dim peli As New ClasePeli
        peli.elimina(dgvPelis(0, dgvPelis.CurrentRow.Index).Value)
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