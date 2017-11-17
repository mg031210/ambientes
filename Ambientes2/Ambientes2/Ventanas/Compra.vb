Public Class Compra
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
            codigo = dgvPelis(0, dgvPelis.CurrentRow.Index).Value
            titulo = dgvPelis(1, dgvPelis.CurrentRow.Index).Value
            tipo = dgvPelis(2, dgvPelis.CurrentRow.Index).Value
            clas = dgvPelis(3, dgvPelis.CurrentRow.Index).Value
            cant = dgvPelis(4, dgvPelis.CurrentRow.Index).Value

            Dim row As Integer = buscarCodigo(codigo)
            If cant <> 0 Then
                If row <> 0 Then
                    dgvVenta.Rows(row - 1).Cells(4).Value += 1
                    dgvPelis(4, dgvPelis.CurrentRow.Index).Value = cant - 1
                Else
                    dgvVenta.Rows.Add(codigo, titulo, tipo, clas, 1)
                    dgvPelis(4, dgvPelis.CurrentRow.Index).Value = cant - 1
                End If
            End If
        End If
        dgvVenta.ClearSelection()
        dgvPelis.ClearSelection()
        'Calcularcosto()
    End Sub
    Private Function buscarCodigo(ByVal codigo) As Integer
        Dim cont As Integer
        For Each fila As DataGridViewRow In dgvVenta.Rows
            cont += 1
            If fila.Cells("codigo").Value = codigo Then
                Return cont
            End If
        Next
        Return 0
    End Function
End Class