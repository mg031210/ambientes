<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addProvee
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
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvVista = New System.Windows.Forms.DataGridView()
        Me.txttel1 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtdir = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txttel2 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtrfc = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtnombre = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtcontacto = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtemail = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcodigo = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtfax = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton5 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvVista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvVista)
        Me.GroupBox1.Controls.Add(Me.txttel1)
        Me.GroupBox1.Controls.Add(Me.txtdir)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txttel2)
        Me.GroupBox1.Controls.Add(Me.txtrfc)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtcontacto)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtfax)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BunifuFlatButton3)
        Me.GroupBox1.Controls.Add(Me.BunifuFlatButton5)
        Me.GroupBox1.Controls.Add(Me.BunifuFlatButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(846, 459)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'dgvVista
        '
        Me.dgvVista.AllowUserToAddRows = False
        Me.dgvVista.AllowUserToDeleteRows = False
        Me.dgvVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVista.Location = New System.Drawing.Point(16, 54)
        Me.dgvVista.Name = "dgvVista"
        Me.dgvVista.ReadOnly = True
        Me.dgvVista.Size = New System.Drawing.Size(815, 150)
        Me.dgvVista.TabIndex = 101
        '
        'txttel1
        '
        Me.txttel1.BorderColor = System.Drawing.Color.SeaGreen
        Me.txttel1.Location = New System.Drawing.Point(180, 358)
        Me.txttel1.MaxLength = 10
        Me.txttel1.Name = "txttel1"
        Me.txttel1.Size = New System.Drawing.Size(151, 20)
        Me.txttel1.TabIndex = 4
        '
        'txtdir
        '
        Me.txtdir.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtdir.Location = New System.Drawing.Point(434, 226)
        Me.txtdir.Name = "txtdir"
        Me.txtdir.Size = New System.Drawing.Size(374, 20)
        Me.txtdir.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(350, 226)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 21)
        Me.Label11.TabIndex = 97
        Me.Label11.Text = "Dirrecion"
        '
        'txttel2
        '
        Me.txttel2.BorderColor = System.Drawing.Color.SeaGreen
        Me.txttel2.Location = New System.Drawing.Point(180, 401)
        Me.txttel2.MaxLength = 10
        Me.txttel2.Name = "txttel2"
        Me.txttel2.Size = New System.Drawing.Size(151, 20)
        Me.txttel2.TabIndex = 5
        '
        'txtrfc
        '
        Me.txtrfc.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtrfc.Location = New System.Drawing.Point(434, 359)
        Me.txtrfc.MaxLength = 13
        Me.txtrfc.Name = "txtrfc"
        Me.txtrfc.Size = New System.Drawing.Size(374, 20)
        Me.txtrfc.TabIndex = 9
        '
        'txtnombre
        '
        Me.txtnombre.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtnombre.Location = New System.Drawing.Point(180, 226)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(151, 20)
        Me.txtnombre.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(56, 226)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 21)
        Me.Label15.TabIndex = 89
        Me.Label15.Text = "Nombre"
        '
        'txtcontacto
        '
        Me.txtcontacto.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtcontacto.Location = New System.Drawing.Point(534, 318)
        Me.txtcontacto.Name = "txtcontacto"
        Me.txtcontacto.Size = New System.Drawing.Size(274, 20)
        Me.txtcontacto.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(350, 316)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(178, 21)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Persona de Contacto"
        '
        'txtemail
        '
        Me.txtemail.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtemail.Location = New System.Drawing.Point(434, 272)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(374, 20)
        Me.txtemail.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(350, 271)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 21)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Email"
        '
        'txtcodigo
        '
        Me.txtcodigo.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtcodigo.Location = New System.Drawing.Point(180, 316)
        Me.txtcodigo.MaxLength = 5
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(109, 20)
        Me.txtcodigo.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(56, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 21)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Codigo Postal"
        '
        'txtfax
        '
        Me.txtfax.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtfax.Location = New System.Drawing.Point(180, 274)
        Me.txtfax.MaxLength = 10
        Me.txtfax.Name = "txtfax"
        Me.txtfax.Size = New System.Drawing.Size(151, 20)
        Me.txtfax.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(56, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 21)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Fax"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(56, 401)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 21)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Telefono 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(56, 358)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 21)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Telefono 1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(350, 361)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 21)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "RFC"
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.Red
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "  Cancelar"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = Global.Ambientes2.My.Resources.Resources.icons8_Delete_96px_1
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 80.0R
        Me.BunifuFlatButton3.IsTab = False
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(595, 402)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.Red
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(106, 38)
        Me.BunifuFlatButton3.TabIndex = 11
        Me.BunifuFlatButton3.Text = "  Cancelar"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton5
        '
        Me.BunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton5.BorderRadius = 0
        Me.BunifuFlatButton5.ButtonText = "  Finalizar"
        Me.BunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.Iconimage = Global.Ambientes2.My.Resources.Resources.icons8_Checkmark_96px
        Me.BunifuFlatButton5.Iconimage_right = Nothing
        Me.BunifuFlatButton5.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton5.Iconimage_Selected = Nothing
        Me.BunifuFlatButton5.IconMarginLeft = 0
        Me.BunifuFlatButton5.IconMarginRight = 0
        Me.BunifuFlatButton5.IconRightVisible = True
        Me.BunifuFlatButton5.IconRightZoom = 0R
        Me.BunifuFlatButton5.IconVisible = True
        Me.BunifuFlatButton5.IconZoom = 80.0R
        Me.BunifuFlatButton5.IsTab = False
        Me.BunifuFlatButton5.Location = New System.Drawing.Point(725, 402)
        Me.BunifuFlatButton5.Name = "BunifuFlatButton5"
        Me.BunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton5.selected = False
        Me.BunifuFlatButton5.Size = New System.Drawing.Size(106, 38)
        Me.BunifuFlatButton5.TabIndex = 10
        Me.BunifuFlatButton5.Text = "  Finalizar"
        Me.BunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton5.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton5.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Nuevo Proveedor"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Global.Ambientes2.My.Resources.Resources.icons8_Add_User_Male_96px
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 80.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(847, 38)
        Me.BunifuFlatButton1.TabIndex = 5
        Me.BunifuFlatButton1.Text = "Nuevo Proveedor"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'addProvee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(870, 483)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addProvee"
        Me.Text = "addProvee"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvVista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton5 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtcontacto As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtemail As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtcodigo As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtfax As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txttel1 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtdir As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label11 As Label
    Friend WithEvents txttel2 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtrfc As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtnombre As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label15 As Label
    Friend WithEvents dgvVista As DataGridView
End Class
