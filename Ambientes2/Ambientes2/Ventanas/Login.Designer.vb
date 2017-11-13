<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Barra1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtUser = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtPass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnVenta = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.msg = New System.Windows.Forms.Label()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.Barra1.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Barra1
        '
        Me.Barra1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Barra1.Controls.Add(Me.Label1)
        Me.Barra1.Controls.Add(Me.BunifuImageButton2)
        Me.Barra1.Controls.Add(Me.BunifuImageButton1)
        Me.Barra1.Location = New System.Drawing.Point(0, 0)
        Me.Barra1.Name = "Barra1"
        Me.Barra1.Size = New System.Drawing.Size(332, 40)
        Me.Barra1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(3, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "VideoClub Bullet"
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuImageButton2.Image = Global.Ambientes2.My.Resources.Resources.icons8_Minimize_Window_96px_1
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(256, 0)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(35, 35)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuImageButton2.TabIndex = 2
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuImageButton1.Image = Global.Ambientes2.My.Resources.Resources.icons8_Delete_96px_1
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(297, 0)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(35, 35)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuImageButton1.TabIndex = 2
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BunifuFlatButton1.AutoSize = True
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = ""
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Global.Ambientes2.My.Resources.Resources.icons8_Name_104px
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 200.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(114, 65)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(113, 113)
        Me.BunifuFlatButton1.TabIndex = 3
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtUser
        '
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUser.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtUser.ForeColor = System.Drawing.Color.White
        Me.txtUser.HintForeColor = System.Drawing.Color.Empty
        Me.txtUser.HintText = ""
        Me.txtUser.isPassword = False
        Me.txtUser.LineFocusedColor = System.Drawing.Color.White
        Me.txtUser.LineIdleColor = System.Drawing.Color.Gray
        Me.txtUser.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txtUser.LineThickness = 3
        Me.txtUser.Location = New System.Drawing.Point(13, 185)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(306, 33)
        Me.txtUser.TabIndex = 4
        Me.txtUser.Text = "Numero"
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtPass
        '
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPass.ForeColor = System.Drawing.Color.White
        Me.txtPass.HintForeColor = System.Drawing.Color.Empty
        Me.txtPass.HintText = ""
        Me.txtPass.isPassword = True
        Me.txtPass.LineFocusedColor = System.Drawing.Color.White
        Me.txtPass.LineIdleColor = System.Drawing.Color.Gray
        Me.txtPass.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txtPass.LineThickness = 3
        Me.txtPass.Location = New System.Drawing.Point(13, 252)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(306, 33)
        Me.txtPass.TabIndex = 4
        Me.txtPass.Text = "Hola"
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Numero de trabajador"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Contraseña"
        '
        'btnVenta
        '
        Me.btnVenta.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVenta.BorderRadius = 0
        Me.btnVenta.ButtonText = "Iniciar Sesion"
        Me.btnVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVenta.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnVenta.Iconcolor = System.Drawing.Color.Transparent
        Me.btnVenta.Iconimage = Global.Ambientes2.My.Resources.Resources.icons8_Password_100px
        Me.btnVenta.Iconimage_right = Nothing
        Me.btnVenta.Iconimage_right_Selected = Nothing
        Me.btnVenta.Iconimage_Selected = Nothing
        Me.btnVenta.IconMarginLeft = 0
        Me.btnVenta.IconMarginRight = 0
        Me.btnVenta.IconRightVisible = True
        Me.btnVenta.IconRightZoom = 0R
        Me.btnVenta.IconVisible = True
        Me.btnVenta.IconZoom = 70.0R
        Me.btnVenta.IsTab = True
        Me.btnVenta.Location = New System.Drawing.Point(150, 333)
        Me.btnVenta.Margin = New System.Windows.Forms.Padding(5)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnVenta.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnVenta.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnVenta.selected = False
        Me.btnVenta.Size = New System.Drawing.Size(169, 48)
        Me.btnVenta.TabIndex = 7
        Me.btnVenta.Text = "Iniciar Sesion"
        Me.btnVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVenta.Textcolor = System.Drawing.Color.White
        Me.btnVenta.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'msg
        '
        Me.msg.AutoSize = True
        Me.msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msg.ForeColor = System.Drawing.Color.White
        Me.msg.Location = New System.Drawing.Point(42, 303)
        Me.msg.Name = "msg"
        Me.msg.Size = New System.Drawing.Size(257, 16)
        Me.msg.TabIndex = 8
        Me.msg.Text = "Usuario o Contraseña Equivocado!"
        Me.msg.Visible = False
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Barra1
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me.Label1
        Me.BunifuDragControl2.Vertical = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(332, 398)
        Me.Controls.Add(Me.msg)
        Me.Controls.Add(Me.btnVenta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.Barra1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Barra1.ResumeLayout(False)
        Me.Barra1.PerformLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Barra1 As Panel
    Protected Friend WithEvents Label1 As Label
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtUser As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnVenta As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents msg As Label
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
End Class
