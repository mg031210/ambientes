Public Class formPrinc
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub BtnMenu_Click_1(sender As Object, e As EventArgs) Handles BtnMenu.Click
        If (Menu.Width = 50) Then
            Menu.Visible = False
            Menu.Width = 200
            '1070, 573
            Me.Width = 1070
            PanelAni2.ShowSync(Menu)

        Else
            Menu.Visible = False
            Menu.Width = 50
            Me.Width = 1070 - 150
            PanelAni.ShowSync(Menu)
        End If
    End Sub

    Private Sub btnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        Dim venta As New Venta
        venta.TopLevel = False
        Me.PanelPrinc.Controls.Add(venta)
        venta.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelUser.Text = session(4).ToString
    End Sub

    Private Sub btnRenta_Click(sender As Object, e As EventArgs) Handles btnRenta.Click
        Dim renta As New Renta
        renta.TopLevel = False
        Me.PanelPrinc.Controls.Clear()
        Me.PanelPrinc.Controls.Add(renta)
        renta.Show()
    End Sub

    Private Sub btnDevol_Click(sender As Object, e As EventArgs) Handles btnDevol.Click
        Dim devol As New Devolucion
        devol.TopLevel = False
        Me.PanelPrinc.Controls.Clear()
        Me.PanelPrinc.Controls.Add(devol)
        devol.Show()
    End Sub

    Private Sub btnActu_Click(sender As Object, e As EventArgs) Handles btnActu.Click
        esregistro = False
        Dim nuevo As New Intermedio
        nuevo.TopLevel = False
        Me.PanelPrinc.Controls.Clear()
        Me.PanelPrinc.Controls.Add(nuevo)
        nuevo.Show()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        esregistro = True
        Dim nuevo As New Intermedio
        nuevo.TopLevel = False
        Me.PanelPrinc.Controls.Clear()
        Me.PanelPrinc.Controls.Add(nuevo)
        nuevo.Show()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

End Class
