Public Class Form1
    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If (Menu.Width = 50) Then
            Menu.Visible = False
            Menu.Width = 200
            PanelAni2.ShowSync(Menu)
        Else
            Menu.Visible = False
            Menu.Width = 50
            PanelAni.ShowSync(Menu)
        End If
    End Sub

    Private Sub Menu_Paint(sender As Object, e As PaintEventArgs) Handles Menu.Paint

    End Sub
End Class
