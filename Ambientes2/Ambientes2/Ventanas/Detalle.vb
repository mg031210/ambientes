Public Class Detalle
    Public socio As String
    Dim hoy As Date = DateTime.Now.ToString("yyyy/MM/dd")
    Private Sub Detalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txtpago.Text.ToString <> "" Then
            If CInt(txtpago.Text.ToString) - CInt(txttotal.Text.ToString) >= 0 Then
                txtcambio.Text = CInt(txtpago.Text.ToString) - CInt(txttotal.Text.ToString)
            Else
                txtcambio.Text = ""
            End If
        Else

        End If

    End Sub

    Private Sub txtpago_TextChanged(sender As Object, e As EventArgs) Handles txtpago.TextChanged
        'If txtpago.Text.ToString <> "" And CInt(txtpago.Text.ToString) - CInt(txttotal.Text.ToString) >= 0 Then
        '    txtcambio.Text = CInt(txtpago.Text.ToString) - CInt(txttotal.Text.ToString)
        'Else
        '    txtcambio.Text = ""
        'End If
        If txtpago.Text.ToString <> "" Then
            If CInt(txtpago.Text.ToString) - CInt(txttotal.Text.ToString) >= 0 Then
                txtcambio.Text = CInt(txtpago.Text.ToString) - CInt(txttotal.Text.ToString)
            Else
                txtcambio.Text = ""
            End If
        Else

        End If
    End Sub

    Private Sub txtcambio_TextChanged(sender As Object, e As EventArgs) Handles txtcambio.TextChanged
        If txtcambio.Text.ToString = "" Then
            btnok.Enabled = False
        Else
            btnok.Enabled = True
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        limpiar()
    End Sub

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged

    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Dim mensaje As Boolean = False
        If isventa Then
            Dim peli As New ClasePeli
            Dim venta As New ClaseVenta
            For Each row As DataGridViewRow In dgvdet.Rows
                peli.stockout(row.Cells(2).Value, row.Cells(0).Value)
                Dim cont As Integer = 0
                While (cont < row.Cells(2).Value)
                    cont += 1
                    venta.inserta(row.Cells(3).Value, row.Cells(0).Value)
                End While
            Next
            mensaje = True
        ElseIf isrenta Then
            Dim peli As New ClasePeli
            Dim renta As New ClaseRenta
            For Each row As DataGridViewRow In dgvdet.Rows
                peli.stockout(row.Cells(2).Value, row.Cells(0).Value)
                Dim cont As Integer = 0
                While (cont < row.Cells(2).Value)
                    cont += 1
                    If row.Cells(3).Value = costoCat Then
                        renta.inserta(row.Cells(3).Value, row.Cells(0).Value, socio, hoy.AddDays(diasCatalogo).ToString("yyyy/MM/dd"))
                    ElseIf row.Cells(3).Value = costoEst Then
                        renta.inserta(row.Cells(3).Value, row.Cells(0).Value, socio, hoy.AddDays(diasEstreno).ToString("yyyy/MM/dd"))
                    End If

                End While
            Next
            mensaje = True
        ElseIf isdevol Then
            Dim peli As New ClasePeli
            Dim renta As New ClaseRenta
            For Each row As DataGridViewRow In dgvdet.Rows
                peli.stockintrenta(row.Cells(2).Value, row.Cells(0).Value)
                renta.insertadevol(row.Cells(0).Value, row.Cells(4).Value, hoy.ToString("yyyy/MM/dd"))
            Next
            mensaje = True
        ElseIf iscompra Then
            Dim peli As New ClasePeli
            Dim compra As New ClaseCompra
            For Each row As DataGridViewRow In dgvdet.Rows
                peli.stockin(row.Cells(2).Value, row.Cells(0).Value)
                Dim cont As Integer = 0
                While (cont < row.Cells(2).Value)
                    cont += 1
                    compra.inserta(row.Cells(3).Value, row.Cells(0).Value)
                End While
            Next
            mensaje = True
        End If
        If mensaje Then
            MsgBox("transferencia terminada")
        Else
            MsgBox("Hubo un error")
        End If
        limpiar()
    End Sub

    Private Sub dgvdet_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdet.CellContentClick

    End Sub
    Public Sub limpiar()
        Dim panel As New Panel
        panel = Me.Parent
        panel.Controls.Clear()
        isventa = False
        isrenta = False
        isdevol = False
    End Sub
    Private Sub pago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpago.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class