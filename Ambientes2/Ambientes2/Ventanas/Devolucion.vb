Public Class Devolucion
    Dim hoy As Date = DateTime.Now.ToString("yyyy/MM/dd")
    Private Sub txtBId_TextChanged(sender As Object, e As EventArgs) Handles txtBId.TextChanged
        txtPago.Text = "0"
        txtRentas.Text = "0"
        txtTotal.Text = "0"
        Dim socio As New ClaseSocio
        Dim fechavigencia As Date
        socio.consultaID(txtBId.Text, dgvSocio)
        socio.consultaVigencia(txtBId.Text, dgvvigencia)
        If dgvvigencia.Rows.Count <> 0 Then
            fechavigencia = CType(dgvvigencia.Rows(0).Cells(0).Value, Date)
        End If
        If socio.consultaDevol(txtBId.Text, dgvDevol) Then
            Dim contC, contE As Integer
            For Each fila As DataGridViewRow In dgvDevol.Rows
                'If fila.Index = dgvDevol.Rows.Count - 1 Then
                '    Exit For
                'End If
                'fila.Cells("Hoy").Value = DateTime.Now.ToString("yyyy/MM/dd")
                If fila.Cells("TipoPel").Value = tipoCat Then
                    contC += 1
                ElseIf fila.Cells("TipoPel").Value = tipoEst Then
                    contE += 1
                End If
            Next
            txtRentas.Text = calcularRenta(contC, contE)
        End If
        'fechavigencia = CType(dgvvigencia.Rows(0).Cells(0).Value, Date)
        If fechavigencia > DateTime.Now.ToString("yyyy/MM/dd") Then
            Btncheck.Visible = True
            BtnRenovar.Enabled = False
            checarpago()
            txtMembre.Text = "0"
        ElseIf fechavigencia = "1/1/0001 12:00:00 AM" Then
            BtnRenovar.Enabled = False
            Btncheck.Visible = False
            btnok.Enabled = False
            txtMembre.Text = "0"
        Else
            BtnRenovar.Enabled = True
            Btncheck.Visible = False
            btnok.Enabled = False
        End If
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        txtBId.Text = ""
        txtPago.Text = "0"
        txtRentas.Text = "0"
        txtTotal.Text = "0"
    End Sub

    Private Sub BtnRenovar_Click(sender As Object, e As EventArgs) Handles BtnRenovar.Click
        txtMembre.Text = CostoMembresia
        checarpago()
    End Sub

    Private Sub Devolucion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim socio As New ClaseSocio
        socio.consultaID(txtBId.Text, dgvSocio)
        socio.consultaVigencia(txtBId.Text, dgvvigencia)
        socio.consultaDevol(txtBId.Text, dgvDevol)
    End Sub

    Private Sub pago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPago.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtRentas_TextChanged(sender As Object, e As EventArgs) Handles txtRentas.TextChanged
        calculartotal()
    End Sub

    Private Sub txtMembre_TextChanged(sender As Object, e As EventArgs) Handles txtMembre.TextChanged
        calculartotal()
    End Sub

    Private Sub calculartotal()
        Try
            txtTotal.Text = Integer.Parse(txtMembre.Text) + Integer.Parse(txtRentas.Text)
        Catch ex As Exception
            txtTotal.Text = "0"
        End Try
    End Sub

    Private Function calcularRenta(ByVal contC As Integer, ByVal contE As Integer)
        Dim total As Integer = 0
        For Each fila As DataGridViewRow In dgvDevol.Rows
            If fila.Cells(1).Value < hoy Then
                'por cada dia se carga el costo de tipo
                Dim diff As Integer = 0
                diff = CInt(DateDiff(DateInterval.Day, fila.Cells(1).Value, hoy))
                'MsgBox(diff)
                If fila.Cells(5).Value = tipoCat Then
                    total = total + (costoCat * diff)
                ElseIf fila.Cells(5).Value = tipoEst Then
                    total = total + (costoEst * diff)
                End If
                'Else
                '   no se carga nada por lo que estan entro del plazo
                '    If fila.Cells(5).Value = tipoCat Then
                '        total = total + costoCat
                '    ElseIf fila.Cells(5).Value = tipoEst Then
                '        total = total + costoEst
                '    End If
            End If
        Next
        Return total
    End Function

    Private Sub checarpago()
        Try
            If txtPago.Text <> "" And Integer.Parse(txtPago.Text) >= Integer.Parse(txtTotal.Text) Then
                btnok.Enabled = True
            Else
                btnok.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPago_TextChanged(sender As Object, e As EventArgs) Handles txtPago.TextChanged
        checarpago()
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        txtMembre.Text = "0"
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        'Dim det As New Detalle
        'Dim panel As New Panel
        'panel = Me.Parent
        'det.TopLevel = False
        'panel.Controls.Clear()
        'panel.Controls.Add(det)
        'det.Show()
        Dim det As New Detalle
        Dim panel As New Panel
        Dim totalcal As String = 0
        Dim tipodepeli As String
        panel = Me.Parent
        det.TopLevel = False

        For Each fila As DataGridViewRow In dgvDevol.Rows
            Dim diff As Integer = 0
            diff = CInt(DateDiff(DateInterval.Day, fila.Cells(1).Value, hoy))
            If diff > 0 Then
                If fila.Cells(5).Value = tipoCat Then
                    totalcal = (costoCat * diff)
                    tipodepeli = costoCat
                ElseIf fila.Cells(5).Value = tipoEst Then
                    totalcal = (costoEst * diff)
                    tipodepeli = costoEst
                Else
                    totalcal = 0
                    tipodepeli = 0
                End If
                det.dgvdet.Rows.Add(fila.Cells(2).Value, fila.Cells(4).Value, 1, tipodepeli, totalcal)
            ElseIf diff <= 0 Then
                If fila.Cells(5).Value = tipoCat Then
                    totalcal = costoCat
                    tipodepeli = costoCat
                ElseIf fila.Cells(5).Value = tipoEst Then
                    totalcal = costoEst
                    tipodepeli = costoEst
                Else
                    totalcal = 0
                    tipodepeli = 0
                End If
                det.dgvdet.Rows.Add(fila.Cells(2).Value, fila.Cells(4).Value, 1, tipodepeli, totalcal)
            End If

            'revisar id columna 1
        Next
        det.txttotal.Text = txtTotal.Text.ToString
        det.txtpago.Text = txtPago.Text.ToString
        panel.Controls.Clear()
        panel.Controls.Add(det)
        det.Show()
    End Sub

    Private Sub dgvDevol_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDevol.CellContentClick

    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        If txtTotal.Text = "0" Then
            txtPago.Text = "0"
        End If
    End Sub
End Class