<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPrinc
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation3 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPrinc))
        Dim Animation4 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Menu = New System.Windows.Forms.Panel()
        Me.BtnMenu = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnNuevo = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnActu = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnDevol = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnRenta = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnVenta = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnInicio = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Barra = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PanelAni = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.PanelPrinc = New System.Windows.Forms.Panel()
        Me.PanelAni2 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelUser = New System.Windows.Forms.Label()
        Me.Menu.SuspendLayout()
        CType(Me.BtnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Barra.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Menu
        '
        Me.Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Menu.Controls.Add(Me.LabelUser)
        Me.Menu.Controls.Add(Me.Label2)
        Me.Menu.Controls.Add(Me.BtnMenu)
        Me.Menu.Controls.Add(Me.btnNuevo)
        Me.Menu.Controls.Add(Me.btnActu)
        Me.Menu.Controls.Add(Me.btnDevol)
        Me.Menu.Controls.Add(Me.btnRenta)
        Me.Menu.Controls.Add(Me.btnVenta)
        Me.Menu.Controls.Add(Me.btnInicio)
        Me.PanelAni2.SetDecoration(Me.Menu, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAni.SetDecoration(Me.Menu, BunifuAnimatorNS.DecorationType.None)
        Me.Menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Menu.Location = New System.Drawing.Point(0, 40)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(200, 533)
        Me.Menu.TabIndex = 0
        '
        'BtnMenu
        '
        Me.BtnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.PanelAni2.SetDecoration(Me.BtnMenu, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAni.SetDecoration(Me.BtnMenu, BunifuAnimatorNS.DecorationType.None)
        Me.BtnMenu.Image = Global.Ambientes2.My.Resources.Resources.icons8_Menu_96px_3
        Me.BtnMenu.ImageActive = Nothing
        Me.BtnMenu.Location = New System.Drawing.Point(157, 3)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(40, 40)
        Me.BtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnMenu.TabIndex = 6
        Me.BtnMenu.TabStop = False
        Me.BtnMenu.Zoom = 10
        '
        'btnNuevo
        '
        Me.btnNuevo.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.BorderRadius = 0
        Me.btnNuevo.ButtonText = "   Nuevo Registro"
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAni2.SetDecoration(Me.btnNuevo, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAni.SetDecoration(Me.btnNuevo, BunifuAnimatorNS.DecorationType.None)
        Me.btnNuevo.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnNuevo.Iconcolor = System.Drawing.Color.Transparent
        Me.btnNuevo.Iconimage = Global.Ambientes2.My.Resources.Resources.icons8_Add_User_Male_96px
        Me.btnNuevo.Iconimage_right = Nothing
        Me.btnNuevo.Iconimage_right_Selected = Nothing
        Me.btnNuevo.Iconimage_Selected = Nothing
        Me.btnNuevo.IconMarginLeft = 0
        Me.btnNuevo.IconMarginRight = 0
        Me.btnNuevo.IconRightVisible = True
        Me.btnNuevo.IconRightZoom = 0R
        Me.btnNuevo.IconVisible = True
        Me.btnNuevo.IconZoom = 90.0R
        Me.btnNuevo.IsTab = True
        Me.btnNuevo.Location = New System.Drawing.Point(2, 443)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(5)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnNuevo.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnNuevo.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnNuevo.selected = False
        Me.btnNuevo.Size = New System.Drawing.Size(223, 48)
        Me.btnNuevo.TabIndex = 5
        Me.btnNuevo.Text = "   Nuevo Registro"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Textcolor = System.Drawing.Color.White
        Me.btnNuevo.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnActu
        '
        Me.btnActu.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnActu.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnActu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnActu.BorderRadius = 0
        Me.btnActu.ButtonText = "       Actualizar"
        Me.btnActu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAni2.SetDecoration(Me.btnActu, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAni.SetDecoration(Me.btnActu, BunifuAnimatorNS.DecorationType.None)
        Me.btnActu.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnActu.Iconcolor = System.Drawing.Color.Transparent
        Me.btnActu.Iconimage = Global.Ambientes2.My.Resources.Resources.icons8_Settings_96px_1
        Me.btnActu.Iconimage_right = Nothing
        Me.btnActu.Iconimage_right_Selected = Nothing
        Me.btnActu.Iconimage_Selected = Nothing
        Me.btnActu.IconMarginLeft = 0
        Me.btnActu.IconMarginRight = 0
        Me.btnActu.IconRightVisible = True
        Me.btnActu.IconRightZoom = 0R
        Me.btnActu.IconVisible = True
        Me.btnActu.IconZoom = 90.0R
        Me.btnActu.IsTab = True
        Me.btnActu.Location = New System.Drawing.Point(2, 385)
        Me.btnActu.Margin = New System.Windows.Forms.Padding(5)
        Me.btnActu.Name = "btnActu"
        Me.btnActu.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnActu.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnActu.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnActu.selected = False
        Me.btnActu.Size = New System.Drawing.Size(223, 48)
        Me.btnActu.TabIndex = 4
        Me.btnActu.Text = "       Actualizar"
        Me.btnActu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActu.Textcolor = System.Drawing.Color.White
        Me.btnActu.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnDevol
        '
        Me.btnDevol.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnDevol.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnDevol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDevol.BorderRadius = 0
        Me.btnDevol.ButtonText = "      Devolucion"
        Me.btnDevol.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAni2.SetDecoration(Me.btnDevol, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAni.SetDecoration(Me.btnDevol, BunifuAnimatorNS.DecorationType.None)
        Me.btnDevol.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnDevol.Iconcolor = System.Drawing.Color.Transparent
        Me.btnDevol.Iconimage = Global.Ambientes2.My.Resources.Resources.icons8_Restart_96px_1
        Me.btnDevol.Iconimage_right = Nothing
        Me.btnDevol.Iconimage_right_Selected = Nothing
        Me.btnDevol.Iconimage_Selected = Nothing
        Me.btnDevol.IconMarginLeft = 0
        Me.btnDevol.IconMarginRight = 0
        Me.btnDevol.IconRightVisible = True
        Me.btnDevol.IconRightZoom = 0R
        Me.btnDevol.IconVisible = True
        Me.btnDevol.IconZoom = 90.0R
        Me.btnDevol.IsTab = True
        Me.btnDevol.Location = New System.Drawing.Point(2, 327)
        Me.btnDevol.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDevol.Name = "btnDevol"
        Me.btnDevol.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnDevol.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnDevol.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnDevol.selected = False
        Me.btnDevol.Size = New System.Drawing.Size(223, 48)
        Me.btnDevol.TabIndex = 3
        Me.btnDevol.Text = "      Devolucion"
        Me.btnDevol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDevol.Textcolor = System.Drawing.Color.White
        Me.btnDevol.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnRenta
        '
        Me.btnRenta.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnRenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnRenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRenta.BorderRadius = 0
        Me.btnRenta.ButtonText = "          Renta"
        Me.btnRenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAni2.SetDecoration(Me.btnRenta, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAni.SetDecoration(Me.btnRenta, BunifuAnimatorNS.DecorationType.None)
        Me.btnRenta.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnRenta.Iconcolor = System.Drawing.Color.Transparent
        Me.btnRenta.Iconimage = Global.Ambientes2.My.Resources.Resources.icons8_Right_Arrow_96px
        Me.btnRenta.Iconimage_right = Nothing
        Me.btnRenta.Iconimage_right_Selected = Nothing
        Me.btnRenta.Iconimage_Selected = Nothing
        Me.btnRenta.IconMarginLeft = 0
        Me.btnRenta.IconMarginRight = 0
        Me.btnRenta.IconRightVisible = True
        Me.btnRenta.IconRightZoom = 0R
        Me.btnRenta.IconVisible = True
        Me.btnRenta.IconZoom = 90.0R
        Me.btnRenta.IsTab = True
        Me.btnRenta.Location = New System.Drawing.Point(2, 269)
        Me.btnRenta.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRenta.Name = "btnRenta"
        Me.btnRenta.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnRenta.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnRenta.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnRenta.selected = False
        Me.btnRenta.Size = New System.Drawing.Size(223, 48)
        Me.btnRenta.TabIndex = 2
        Me.btnRenta.Text = "          Renta"
        Me.btnRenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRenta.Textcolor = System.Drawing.Color.White
        Me.btnRenta.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnVenta
        '
        Me.btnVenta.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVenta.BorderRadius = 0
        Me.btnVenta.ButtonText = "          Venta"
        Me.btnVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAni2.SetDecoration(Me.btnVenta, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAni.SetDecoration(Me.btnVenta, BunifuAnimatorNS.DecorationType.None)
        Me.btnVenta.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnVenta.Iconcolor = System.Drawing.Color.Transparent
        Me.btnVenta.Iconimage = Global.Ambientes2.My.Resources.Resources.icons8_Paper_Money_96px
        Me.btnVenta.Iconimage_right = Nothing
        Me.btnVenta.Iconimage_right_Selected = Nothing
        Me.btnVenta.Iconimage_Selected = Nothing
        Me.btnVenta.IconMarginLeft = 0
        Me.btnVenta.IconMarginRight = 0
        Me.btnVenta.IconRightVisible = True
        Me.btnVenta.IconRightZoom = 0R
        Me.btnVenta.IconVisible = True
        Me.btnVenta.IconZoom = 90.0R
        Me.btnVenta.IsTab = True
        Me.btnVenta.Location = New System.Drawing.Point(2, 211)
        Me.btnVenta.Margin = New System.Windows.Forms.Padding(5)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnVenta.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnVenta.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnVenta.selected = False
        Me.btnVenta.Size = New System.Drawing.Size(223, 48)
        Me.btnVenta.TabIndex = 1
        Me.btnVenta.Text = "          Venta"
        Me.btnVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVenta.Textcolor = System.Drawing.Color.White
        Me.btnVenta.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnInicio
        '
        Me.btnInicio.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInicio.BorderRadius = 0
        Me.btnInicio.ButtonText = "          Inicio"
        Me.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAni2.SetDecoration(Me.btnInicio, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAni.SetDecoration(Me.btnInicio, BunifuAnimatorNS.DecorationType.None)
        Me.btnInicio.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnInicio.Iconcolor = System.Drawing.Color.Transparent
        Me.btnInicio.Iconimage = Global.Ambientes2.My.Resources.Resources.icons8_Home_96px_1
        Me.btnInicio.Iconimage_right = Nothing
        Me.btnInicio.Iconimage_right_Selected = Nothing
        Me.btnInicio.Iconimage_Selected = Nothing
        Me.btnInicio.IconMarginLeft = 0
        Me.btnInicio.IconMarginRight = 0
        Me.btnInicio.IconRightVisible = True
        Me.btnInicio.IconRightZoom = 0R
        Me.btnInicio.IconVisible = True
        Me.btnInicio.IconZoom = 90.0R
        Me.btnInicio.IsTab = True
        Me.btnInicio.Location = New System.Drawing.Point(2, 153)
        Me.btnInicio.Margin = New System.Windows.Forms.Padding(5)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnInicio.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnInicio.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnInicio.selected = True
        Me.btnInicio.Size = New System.Drawing.Size(223, 48)
        Me.btnInicio.TabIndex = 0
        Me.btnInicio.Text = "          Inicio"
        Me.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicio.Textcolor = System.Drawing.Color.White
        Me.btnInicio.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Barra
        '
        Me.Barra.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Barra.Controls.Add(Me.Label1)
        Me.Barra.Controls.Add(Me.BunifuImageButton2)
        Me.Barra.Controls.Add(Me.BunifuImageButton1)
        Me.PanelAni2.SetDecoration(Me.Barra, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAni.SetDecoration(Me.Barra, BunifuAnimatorNS.DecorationType.None)
        Me.Barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.Barra.Location = New System.Drawing.Point(0, 0)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(1070, 40)
        Me.Barra.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.PanelAni.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAni2.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
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
        Me.PanelAni2.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAni.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton2.Image = Global.Ambientes2.My.Resources.Resources.icons8_Minimize_Window_96px_1
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(994, 0)
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
        Me.PanelAni2.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAni.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton1.Image = Global.Ambientes2.My.Resources.Resources.icons8_Delete_96px_1
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(1035, 0)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(35, 35)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuImageButton1.TabIndex = 2
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Barra
        Me.BunifuDragControl1.Vertical = True
        '
        'PanelAni
        '
        Me.PanelAni.AnimationType = BunifuAnimatorNS.AnimationType.Particles
        Me.PanelAni.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 1
        Animation3.Padding = New System.Windows.Forms.Padding(100, 50, 100, 150)
        Animation3.RotateCoeff = 0!
        Animation3.RotateLimit = 0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 2.0!
        Animation3.TransparencyCoeff = 0!
        Me.PanelAni.DefaultAnimation = Animation3
        '
        'PanelPrinc
        '
        Me.PanelAni2.SetDecoration(Me.PanelPrinc, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAni.SetDecoration(Me.PanelPrinc, BunifuAnimatorNS.DecorationType.None)
        Me.PanelPrinc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPrinc.Location = New System.Drawing.Point(200, 40)
        Me.PanelPrinc.Name = "PanelPrinc"
        Me.PanelPrinc.Size = New System.Drawing.Size(870, 533)
        Me.PanelPrinc.TabIndex = 2
        '
        'PanelAni2
        '
        Me.PanelAni2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.PanelAni2.Cursor = Nothing
        Animation4.AnimateOnlyDifferences = True
        Animation4.BlindCoeff = CType(resources.GetObject("Animation4.BlindCoeff"), System.Drawing.PointF)
        Animation4.LeafCoeff = 0!
        Animation4.MaxTime = 1.0!
        Animation4.MinTime = 0!
        Animation4.MosaicCoeff = CType(resources.GetObject("Animation4.MosaicCoeff"), System.Drawing.PointF)
        Animation4.MosaicShift = CType(resources.GetObject("Animation4.MosaicShift"), System.Drawing.PointF)
        Animation4.MosaicSize = 0
        Animation4.Padding = New System.Windows.Forms.Padding(0)
        Animation4.RotateCoeff = 0!
        Animation4.RotateLimit = 0!
        Animation4.ScaleCoeff = CType(resources.GetObject("Animation4.ScaleCoeff"), System.Drawing.PointF)
        Animation4.SlideCoeff = CType(resources.GetObject("Animation4.SlideCoeff"), System.Drawing.PointF)
        Animation4.TimeCoeff = 0!
        Animation4.TransparencyCoeff = 0!
        Me.PanelAni2.DefaultAnimation = Animation4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.PanelAni.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAni2.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 20.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 33)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Bienvenido"
        '
        'LabelUser
        '
        Me.LabelUser.AutoSize = True
        Me.PanelAni.SetDecoration(Me.LabelUser, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAni2.SetDecoration(Me.LabelUser, BunifuAnimatorNS.DecorationType.None)
        Me.LabelUser.Font = New System.Drawing.Font("Century Gothic", 20.0!)
        Me.LabelUser.ForeColor = System.Drawing.SystemColors.Window
        Me.LabelUser.Location = New System.Drawing.Point(12, 88)
        Me.LabelUser.Name = "LabelUser"
        Me.LabelUser.Size = New System.Drawing.Size(108, 33)
        Me.LabelUser.TabIndex = 7
        Me.LabelUser.Text = "Usuario"
        '
        'formPrinc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1070, 573)
        Me.Controls.Add(Me.PanelPrinc)
        Me.Controls.Add(Me.Menu)
        Me.Controls.Add(Me.Barra)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelAni.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAni2.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formPrinc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        CType(Me.BtnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Barra.ResumeLayout(False)
        Me.Barra.PerformLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Barra As Panel
    Protected Friend WithEvents Label1 As Label
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents PanelAni As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents PanelAni2 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BtnMenu As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnNuevo As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnActu As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnDevol As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnRenta As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnVenta As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnInicio As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Menu As Panel
    Friend WithEvents PanelPrinc As Panel
    Protected Friend WithEvents LabelUser As Label
    Protected Friend WithEvents Label2 As Label
End Class
