﻿Public Class Venta
    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim peli As New ClasePeli
        dgvPelis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        peli.selectAll(dgvPelis)
    End Sub

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
        Calcularcosto()
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
    Private Sub dgvVenta_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvVenta.MouseDoubleClick
        If dgvVenta(0, dgvVenta.CurrentRow.Index).Value <> Nothing Then
            Dim codigo, cant As String
            codigo = dgvVenta(0, dgvVenta.CurrentRow.Index).Value
            cant = dgvVenta(4, dgvVenta.CurrentRow.Index).Value
            For Each fila As DataGridViewRow In dgvPelis.Rows
                If fila.Cells("CodigoBarras").Value = codigo Then
                    fila.Selected = True
                    fila.Cells(4).Value += 1
                    dgvVenta(4, dgvVenta.CurrentRow.Index).Value = cant - 1
                End If
            Next
            If cant = "1" Then
                dgvVenta.Rows.RemoveAt(dgvVenta.CurrentRow.Index)
            End If
        End If
        dgvVenta.ClearSelection()
        dgvPelis.ClearSelection()
        Calcularcosto()
    End Sub

    Private Sub Calcularcosto()
        Dim totalval As Integer = 0
        For Each fila As DataGridViewRow In dgvVenta.Rows
            If fila.Cells(2).Value = tipoCat Then
                totalval += (fila.Cells(4).Value * costoCat)
            ElseIf fila.Cells(2).Value = tipoEst Then
                totalval += (fila.Cells(4).Value * costoEst)
            End If
        Next
        total.Text = totalval
    End Sub

    Private Sub pago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pago.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        dgvVenta.Rows.Clear()
        Dim peli As New ClasePeli
        peli.selectAll(dgvPelis)
        total.Text = ""
    End Sub

    Private Sub txtBId_LostFocus(sender As Object, e As EventArgs) Handles txtBId.LostFocus
        txtBId.Text = ""
    End Sub

    Private Sub txtBTitulo_LostFocus(sender As Object, e As EventArgs) Handles txtBTitulo.LostFocus
        txtBTitulo.Text = ""
    End Sub

    Private Sub pago_TextChanged(sender As Object, e As EventArgs) Handles pago.TextChanged
        If pago.Text.ToString <> "" Then
            If CInt(pago.Text.ToString) >= CInt(total.Text.ToString) And dgvVenta.RowCount <> 0 Then
                btnok.Enabled = True
            Else
                btnok.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Dim det As New Detalle
        Dim panel As New Panel
        Dim totalcal, tipodepeli As String
        panel = Me.Parent
        det.TopLevel = False
        For Each row As DataGridViewRow In dgvVenta.Rows
            If row.Cells(2).Value = tipoCat Then
                totalcal = row.Cells(4).Value * costoCat
                tipodepeli = costoCat
            ElseIf row.Cells(2).Value = tipoEst Then
                totalcal = row.Cells(4).Value * costoEst
                tipodepeli = costoEst
            Else
                totalcal = 0
                tipodepeli = 0
            End If
            det.dgvdet.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(4).Value, tipodepeli, totalcal)
        Next
        det.txttotal.Text = total.Text.ToString
        det.txtpago.Text = pago.Text.ToString
        panel.Controls.Clear()
        panel.Controls.Add(det)
        det.Show()
    End Sub
End Class