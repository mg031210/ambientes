Public Class inventario
    Private Sub inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim renta As New ClaseRenta
        renta.selectAllhoy(dgvrenta)
        Dim venta As New ClaseVenta
        venta.selectAllhoy(dgvventa)
        Dim compra As New ClaseCompra
        compra.selectAllhoy(dgvcompra)
    End Sub
End Class