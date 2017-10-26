Public Class Form1
    Public frm As New Form2()
    Public dlg As New Form9()
    Private Sub Nombre_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub SocioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SocioToolStripMenuItem.Click

    End Sub

    Private Sub InsertarToolStripMenuItem2_Click(sender As Object, e As EventArgs)

        frm.Show()
        frm.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click

    End Sub

    Private Sub ProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedorToolStripMenuItem.Click
        dlg.MdiParent = dlg.MdiParent
        dlg.Show()

    End Sub
End Class
