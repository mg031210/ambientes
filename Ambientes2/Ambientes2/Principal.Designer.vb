<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim Animation4 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation3 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Menu = New System.Windows.Forms.Panel()
        Me.Barra = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PanelAni = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.PanelAni2 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuFlatButton7 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton8 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton9 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton10 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton11 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton12 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnMenu = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Menu.SuspendLayout()
        Me.Barra.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Menu.Controls.Add(Me.BtnMenu)
        Me.Menu.Controls.Add(Me.BunifuFlatButton12)
        Me.Menu.Controls.Add(Me.BunifuFlatButton11)
        Me.Menu.Controls.Add(Me.BunifuFlatButton10)
        Me.Menu.Controls.Add(Me.BunifuFlatButton9)
        Me.Menu.Controls.Add(Me.BunifuFlatButton8)
        Me.Menu.Controls.Add(Me.BunifuFlatButton7)
        Me.PanelAni2.SetDecoration(Me.Menu, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAni.SetDecoration(Me.Menu, BunifuAnimatorNS.DecorationType.None)
        Me.Menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Menu.Location = New System.Drawing.Point(0, 40)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(200, 467)
        Me.Menu.TabIndex = 0
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
        Me.Barra.Size = New System.Drawing.Size(990, 40)
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
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.PanelAni2.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAni.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(914, 0)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(35, 35)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuImageButton2.TabIndex = 2
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.PanelAni2.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAni.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(955, 0)
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
        Animation4.AnimateOnlyDifferences = True
        Animation4.BlindCoeff = CType(resources.GetObject("Animation4.BlindCoeff"), System.Drawing.PointF)
        Animation4.LeafCoeff = 0!
        Animation4.MaxTime = 1.0!
        Animation4.MinTime = 0!
        Animation4.MosaicCoeff = CType(resources.GetObject("Animation4.MosaicCoeff"), System.Drawing.PointF)
        Animation4.MosaicShift = CType(resources.GetObject("Animation4.MosaicShift"), System.Drawing.PointF)
        Animation4.MosaicSize = 1
        Animation4.Padding = New System.Windows.Forms.Padding(100, 50, 100, 150)
        Animation4.RotateCoeff = 0!
        Animation4.RotateLimit = 0!
        Animation4.ScaleCoeff = CType(resources.GetObject("Animation4.ScaleCoeff"), System.Drawing.PointF)
        Animation4.SlideCoeff = CType(resources.GetObject("Animation4.SlideCoeff"), System.Drawing.PointF)
        Animation4.TimeCoeff = 2.0!
        Animation4.TransparencyCoeff = 0!
        Me.PanelAni.DefaultAnimation = Animation4
        '
        'PanelAni2
        '
        Me.PanelAni2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.PanelAni2.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(0)
        Animation3.RotateCoeff = 0!
        Animation3.RotateLimit = 0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0!
        Animation3.TransparencyCoeff = 0!
        Me.PanelAni2.DefaultAnimation = Animation3
        '
        'BunifuFlatButton7
        '
        Me.BunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BunifuFlatButton7.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton7.BorderRadius = 0
        Me.BunifuFlatButton7.ButtonText = "          Inicio"
        Me.BunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAni2.SetDecoration(Me.BunifuFlatButton7, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAni.SetDecoration(Me.BunifuFlatButton7, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton7.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.Iconimage = CType(resources.GetObject("BunifuFlatButton7.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton7.Iconimage_right = Nothing
        Me.BunifuFlatButton7.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton7.Iconimage_Selected = Nothing
        Me.BunifuFlatButton7.IconMarginLeft = 0
        Me.BunifuFlatButton7.IconMarginRight = 0
        Me.BunifuFlatButton7.IconRightVisible = True
        Me.BunifuFlatButton7.IconRightZoom = 0R
        Me.BunifuFlatButton7.IconVisible = True
        Me.BunifuFlatButton7.IconZoom = 90.0R
        Me.BunifuFlatButton7.IsTab = True
        Me.BunifuFlatButton7.Location = New System.Drawing.Point(2, 101)
        Me.BunifuFlatButton7.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuFlatButton7.Name = "BunifuFlatButton7"
        Me.BunifuFlatButton7.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BunifuFlatButton7.selected = True
        Me.BunifuFlatButton7.Size = New System.Drawing.Size(223, 48)
        Me.BunifuFlatButton7.TabIndex = 0
        Me.BunifuFlatButton7.Text = "          Inicio"
        Me.BunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton7.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton7.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton8
        '
        Me.BunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BunifuFlatButton8.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton8.BorderRadius = 0
        Me.BunifuFlatButton8.ButtonText = "          Venta"
        Me.BunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAni2.SetDecoration(Me.BunifuFlatButton8, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAni.SetDecoration(Me.BunifuFlatButton8, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton8.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton8.Iconimage = CType(resources.GetObject("BunifuFlatButton8.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton8.Iconimage_right = Nothing
        Me.BunifuFlatButton8.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton8.Iconimage_Selected = Nothing
        Me.BunifuFlatButton8.IconMarginLeft = 0
        Me.BunifuFlatButton8.IconMarginRight = 0
        Me.BunifuFlatButton8.IconRightVisible = True
        Me.BunifuFlatButton8.IconRightZoom = 0R
        Me.BunifuFlatButton8.IconVisible = True
        Me.BunifuFlatButton8.IconZoom = 90.0R
        Me.BunifuFlatButton8.IsTab = True
        Me.BunifuFlatButton8.Location = New System.Drawing.Point(2, 159)
        Me.BunifuFlatButton8.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton8.Name = "BunifuFlatButton8"
        Me.BunifuFlatButton8.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BunifuFlatButton8.selected = False
        Me.BunifuFlatButton8.Size = New System.Drawing.Size(223, 48)
        Me.BunifuFlatButton8.TabIndex = 1
        Me.BunifuFlatButton8.Text = "          Venta"
        Me.BunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton8.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton8.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton9
        '
        Me.BunifuFlatButton9.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BunifuFlatButton9.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BunifuFlatButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton9.BorderRadius = 0
        Me.BunifuFlatButton9.ButtonText = "          Renta"
        Me.BunifuFlatButton9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAni2.SetDecoration(Me.BunifuFlatButton9, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAni.SetDecoration(Me.BunifuFlatButton9, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton9.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BunifuFlatButton9.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton9.Iconimage = CType(resources.GetObject("BunifuFlatButton9.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton9.Iconimage_right = Nothing
        Me.BunifuFlatButton9.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton9.Iconimage_Selected = Nothing
        Me.BunifuFlatButton9.IconMarginLeft = 0
        Me.BunifuFlatButton9.IconMarginRight = 0
        Me.BunifuFlatButton9.IconRightVisible = True
        Me.BunifuFlatButton9.IconRightZoom = 0R
        Me.BunifuFlatButton9.IconVisible = True
        Me.BunifuFlatButton9.IconZoom = 90.0R
        Me.BunifuFlatButton9.IsTab = True
        Me.BunifuFlatButton9.Location = New System.Drawing.Point(2, 217)
        Me.BunifuFlatButton9.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton9.Name = "BunifuFlatButton9"
        Me.BunifuFlatButton9.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BunifuFlatButton9.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BunifuFlatButton9.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BunifuFlatButton9.selected = False
        Me.BunifuFlatButton9.Size = New System.Drawing.Size(223, 48)
        Me.BunifuFlatButton9.TabIndex = 2
        Me.BunifuFlatButton9.Text = "          Renta"
        Me.BunifuFlatButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton9.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton9.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton10
        '
        Me.BunifuFlatButton10.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BunifuFlatButton10.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BunifuFlatButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton10.BorderRadius = 0
        Me.BunifuFlatButton10.ButtonText = "      Devolucion"
        Me.BunifuFlatButton10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAni2.SetDecoration(Me.BunifuFlatButton10, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAni.SetDecoration(Me.BunifuFlatButton10, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton10.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BunifuFlatButton10.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton10.Iconimage = CType(resources.GetObject("BunifuFlatButton10.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton10.Iconimage_right = Nothing
        Me.BunifuFlatButton10.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton10.Iconimage_Selected = Nothing
        Me.BunifuFlatButton10.IconMarginLeft = 0
        Me.BunifuFlatButton10.IconMarginRight = 0
        Me.BunifuFlatButton10.IconRightVisible = True
        Me.BunifuFlatButton10.IconRightZoom = 0R
        Me.BunifuFlatButton10.IconVisible = True
        Me.BunifuFlatButton10.IconZoom = 90.0R
        Me.BunifuFlatButton10.IsTab = True
        Me.BunifuFlatButton10.Location = New System.Drawing.Point(2, 275)
        Me.BunifuFlatButton10.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton10.Name = "BunifuFlatButton10"
        Me.BunifuFlatButton10.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BunifuFlatButton10.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BunifuFlatButton10.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BunifuFlatButton10.selected = False
        Me.BunifuFlatButton10.Size = New System.Drawing.Size(223, 48)
        Me.BunifuFlatButton10.TabIndex = 3
        Me.BunifuFlatButton10.Text = "      Devolucion"
        Me.BunifuFlatButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton10.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton10.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton11
        '
        Me.BunifuFlatButton11.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BunifuFlatButton11.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BunifuFlatButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton11.BorderRadius = 0
        Me.BunifuFlatButton11.ButtonText = "   Configuracion"
        Me.BunifuFlatButton11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAni2.SetDecoration(Me.BunifuFlatButton11, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAni.SetDecoration(Me.BunifuFlatButton11, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton11.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BunifuFlatButton11.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton11.Iconimage = CType(resources.GetObject("BunifuFlatButton11.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton11.Iconimage_right = Nothing
        Me.BunifuFlatButton11.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton11.Iconimage_Selected = Nothing
        Me.BunifuFlatButton11.IconMarginLeft = 0
        Me.BunifuFlatButton11.IconMarginRight = 0
        Me.BunifuFlatButton11.IconRightVisible = True
        Me.BunifuFlatButton11.IconRightZoom = 0R
        Me.BunifuFlatButton11.IconVisible = True
        Me.BunifuFlatButton11.IconZoom = 90.0R
        Me.BunifuFlatButton11.IsTab = True
        Me.BunifuFlatButton11.Location = New System.Drawing.Point(2, 333)
        Me.BunifuFlatButton11.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton11.Name = "BunifuFlatButton11"
        Me.BunifuFlatButton11.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BunifuFlatButton11.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BunifuFlatButton11.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BunifuFlatButton11.selected = False
        Me.BunifuFlatButton11.Size = New System.Drawing.Size(223, 48)
        Me.BunifuFlatButton11.TabIndex = 4
        Me.BunifuFlatButton11.Text = "   Configuracion"
        Me.BunifuFlatButton11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton11.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton11.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton12
        '
        Me.BunifuFlatButton12.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BunifuFlatButton12.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BunifuFlatButton12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton12.BorderRadius = 0
        Me.BunifuFlatButton12.ButtonText = "   Nuevo Registro"
        Me.BunifuFlatButton12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelAni2.SetDecoration(Me.BunifuFlatButton12, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAni.SetDecoration(Me.BunifuFlatButton12, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton12.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BunifuFlatButton12.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton12.Iconimage = CType(resources.GetObject("BunifuFlatButton12.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton12.Iconimage_right = Nothing
        Me.BunifuFlatButton12.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton12.Iconimage_Selected = Nothing
        Me.BunifuFlatButton12.IconMarginLeft = 0
        Me.BunifuFlatButton12.IconMarginRight = 0
        Me.BunifuFlatButton12.IconRightVisible = True
        Me.BunifuFlatButton12.IconRightZoom = 0R
        Me.BunifuFlatButton12.IconVisible = True
        Me.BunifuFlatButton12.IconZoom = 90.0R
        Me.BunifuFlatButton12.IsTab = True
        Me.BunifuFlatButton12.Location = New System.Drawing.Point(2, 391)
        Me.BunifuFlatButton12.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuFlatButton12.Name = "BunifuFlatButton12"
        Me.BunifuFlatButton12.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BunifuFlatButton12.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BunifuFlatButton12.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BunifuFlatButton12.selected = False
        Me.BunifuFlatButton12.Size = New System.Drawing.Size(223, 48)
        Me.BunifuFlatButton12.TabIndex = 5
        Me.BunifuFlatButton12.Text = "   Nuevo Registro"
        Me.BunifuFlatButton12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton12.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton12.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnMenu
        '
        Me.BtnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.PanelAni2.SetDecoration(Me.BtnMenu, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAni.SetDecoration(Me.BtnMenu, BunifuAnimatorNS.DecorationType.None)
        Me.BtnMenu.Image = CType(resources.GetObject("BtnMenu.Image"), System.Drawing.Image)
        Me.BtnMenu.ImageActive = Nothing
        Me.BtnMenu.Location = New System.Drawing.Point(157, 3)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(40, 40)
        Me.BtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnMenu.TabIndex = 6
        Me.BtnMenu.TabStop = False
        Me.BtnMenu.Zoom = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(990, 507)
        Me.Controls.Add(Me.Menu)
        Me.Controls.Add(Me.Barra)
        Me.PanelAni.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAni2.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Menu.ResumeLayout(False)
        Me.Barra.ResumeLayout(False)
        Me.Barra.PerformLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMenu, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BunifuFlatButton12 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton11 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton10 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton9 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton8 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton7 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Menu As Panel
End Class
