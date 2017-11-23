Public Class Compra
    Private temp As String = ""
    Private Sub Compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim peli As New ClasePeli
        dgvPelis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        peli.selectAllcompra(dgvPelis)
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs)
        Dim det As New Detalle
        Dim panel As New Panel
        panel = Me.Parent
        det.TopLevel = False
        panel.Controls.Clear()
        panel.Controls.Add(det)
        det.Show()
    End Sub
    Private Sub BunifuCustomTextbox1_TextChanged(sender As Object, e As EventArgs) Handles txtBId.TextChanged
        Dim peli As New ClasePeli
        peli.consultaIDcompra(txtBId.Text, dgvPelis)
    End Sub

    Private Sub txtBTitulo_TextChanged(sender As Object, e As EventArgs) Handles txtBTitulo.TextChanged
        Dim peli As New ClasePeli
        peli.consultaTitulocompra(txtBTitulo.Text, dgvPelis)
    End Sub
    Private Sub dgvPelis_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvPelis.MouseDoubleClick
        If dgvPelis(0, dgvPelis.CurrentRow.Index).Value IsNot DBNull.Value Then
            Dim codigo, titulo, tipo, clas, cant As String
            Dim existe As Boolean = False
            codigo = dgvPelis(0, dgvPelis.CurrentRow.Index).Value
            titulo = dgvPelis(1, dgvPelis.CurrentRow.Index).Value
            tipo = dgvPelis(2, dgvPelis.CurrentRow.Index).Value
            clas = dgvPelis(3, dgvPelis.CurrentRow.Index).Value
            cant = dgvPelis(4, dgvPelis.CurrentRow.Index).Value
            For Each fila As DataGridViewRow In dgvCompra.Rows
                If fila.Cells("codigo").Value = codigo Then
                    existe = True
                    Exit For
                End If
            Next
            If Not existe Then
                dgvCompra.Rows.Add(codigo, titulo, tipo, clas, 0, 0)
            End If
        End If
        dgvCompra.ClearSelection()
        dgvPelis.ClearSelection()
        'Calcularcosto()
    End Sub
    Private Function buscarCodigo(ByVal codigo) As Integer
        Dim cont As Integer
        For Each fila As DataGridViewRow In dgvCompra.Rows
            cont += 1
            If fila.Cells("codigo").Value = codigo Then
                Return cont
            End If
        Next
        Return 0
    End Function

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        dgvCompra.Rows.Clear()
        Dim peli As New ClasePeli
        peli.selectAll(dgvPelis)
    End Sub

    Private Sub TextBox_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub dgvVenta_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvCompra.EditingControlShowing
        If dgvCompra.CurrentCell.ColumnIndex = 4 Or dgvCompra.CurrentCell.ColumnIndex = 5 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
        End If
    End Sub

    Private Sub btnok_Click_1(sender As Object, e As EventArgs) Handles btnok.Click
        dgvCompra.ClearSelection()
        dgvPelis.ClearSelection()
        For Each row As DataGridViewRow In dgvCompra.Rows
            For Each col As DataGridViewCell In row.Cells
                Dim value As Object = col.Value
                If ((value Is Nothing) OrElse (value Is DBNull.Value)) Then
                    Dim rowIndex As Integer = row.Index
                    Dim columnIndex As Integer = col.ColumnIndex
                    dgvCompra.CurrentCell = dgvCompra.Rows(rowIndex).Cells(columnIndex)
                    MessageBox.Show("Hay celdas vacias")
                    Return
                End If
            Next
        Next
        Dim det As New Detalle
        Dim panel As New Panel
        panel = Me.Parent
        det.TopLevel = False
        For Each row As DataGridViewRow In dgvCompra.Rows
            det.dgvdet.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(4).Value * row.Cells(5).Value)
        Next
        panel.Controls.Clear()
        panel.Controls.Add(det)
        det.Show()
    End Sub

End Class