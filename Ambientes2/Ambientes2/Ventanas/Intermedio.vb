Public Class Intermedio

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles Me.Load
        'If (esregistro) Then
        '    btnsocio.Text = "add socio"
        'Else
        '    btnsocio.Text = "modify socio"
        'End If
    End Sub

    Private Sub btnsocio_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If (esregistro) Then
            Dim addSoci As New addSocio
            addSoci.TopLevel = False
            Me.PanelInter.Controls.Clear()
            Me.PanelInter.Controls.Add(addSoci)
            addSoci.Show()
        Else
            Dim modSoci As New modSocio
            modSoci.TopLevel = False
            Me.PanelInter.Controls.Clear()
            Me.PanelInter.Controls.Add(modSoci)
            modSoci.Show()
        End If
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        If (esregistro) Then
            Dim addProv As New addProvee
            addProv.TopLevel = False
            Me.PanelInter.Controls.Clear()
            Me.PanelInter.Controls.Add(addProv)
            addProv.Show()
        Else
            Dim modProv As New modProvee
            modProv.TopLevel = False
            Me.PanelInter.Controls.Clear()
            Me.PanelInter.Controls.Add(modProv)
            modProv.Show()
        End If
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        If (esregistro) Then
            Dim addTrab As New addTraba
            addTrab.TopLevel = False
            Me.PanelInter.Controls.Clear()
            Me.PanelInter.Controls.Add(addTrab)
            addTrab.Show()
        Else
            Dim modTrab As New modTraba
            modTrab.TopLevel = False
            Me.PanelInter.Controls.Clear()
            Me.PanelInter.Controls.Add(modTrab)
            modTrab.Show()
        End If
    End Sub
End Class