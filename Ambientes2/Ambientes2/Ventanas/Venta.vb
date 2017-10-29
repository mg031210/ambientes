Public Class Venta

    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim peli As New ClasePeli
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

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class