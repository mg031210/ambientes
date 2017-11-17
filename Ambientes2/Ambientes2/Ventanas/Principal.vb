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
            LabelUser.Visible = True
            Label2.Visible = True
            PanelAni2.ShowSync(Menu)

        Else
            Menu.Visible = False
            Menu.Width = 50
            Me.Width = 1070 - 150
            LabelUser.Visible = False
            Label2.Visible = False
            PanelAni.ShowSync(Menu)
        End If
    End Sub

    Private Sub btnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        Dim compra As New Compra
        compra.TopLevel = False
        Me.PanelPrinc.Controls.Clear()
        Me.PanelPrinc.Controls.Add(compra)
        compra.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelUser.Text = session(5).ToString
        If session(11).ToString = "1" Then
            isadmin = True
            btnActu.Visible = True
            Btninven.Visible = True
        End If
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

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles Btninven.Click
        Dim nuevo As New inventario
        nuevo.TopLevel = False
        Me.PanelPrinc.Controls.Clear()
        Me.PanelPrinc.Controls.Add(nuevo)
        nuevo.Show()
    End Sub

    Private Sub LabelUser_Click(sender As Object, e As EventArgs) Handles LabelUser.Click

    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Dim venta As New Venta
        venta.TopLevel = False
        Me.PanelPrinc.Controls.Add(venta)
        venta.Show()
    End Sub
End Class
