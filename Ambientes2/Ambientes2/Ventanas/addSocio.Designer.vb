<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addSocio
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
        Me.txtcel = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdir = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txttel = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtapm = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtapp = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtnombre = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label15 = New System.Windows.Forms.Label()
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
        Me.GroupBox1.Controls.Add(Me.txtcel)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtdir)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txttel)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtapm)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtapp)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.BunifuFlatButton3)
        Me.GroupBox1.Controls.Add(Me.BunifuFlatButton5)
        Me.GroupBox1.Controls.Add(Me.BunifuFlatButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(846, 459)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'dgvVista
        '
        Me.dgvVista.AllowUserToAddRows = False
        Me.dgvVista.AllowUserToDeleteRows = False
        Me.dgvVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVista.Location = New System.Drawing.Point(18, 55)
        Me.dgvVista.Name = "dgvVista"
        Me.dgvVista.ReadOnly = True
        Me.dgvVista.Size = New System.Drawing.Size(813, 171)
        Me.dgvVista.TabIndex = 87
        '
        'txtcel
        '
        Me.txtcel.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtcel.Location = New System.Drawing.Point(439, 345)
        Me.txtcel.MaxLength = 10
        Me.txtcel.Name = "txtcel"
        Me.txtcel.Size = New System.Drawing.Size(138, 20)
        Me.txtcel.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(357, 345)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 21)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Celular"
        '
        'txtdir
        '
        Me.txtdir.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtdir.Location = New System.Drawing.Point(439, 259)
        Me.txtdir.Name = "txtdir"
        Me.txtdir.Size = New System.Drawing.Size(374, 20)
        Me.txtdir.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(357, 259)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 21)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "Direccion"
        '
        'txttel
        '
        Me.txttel.BorderColor = System.Drawing.Color.SeaGreen
        Me.txttel.Location = New System.Drawing.Point(439, 302)
        Me.txttel.MaxLength = 10
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(138, 20)
        Me.txttel.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(357, 301)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 21)
        Me.Label12.TabIndex = 81
        Me.Label12.Text = "Telefono"
        '
        'txtapm
        '
        Me.txtapm.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtapm.Location = New System.Drawing.Point(186, 349)
        Me.txtapm.Name = "txtapm"
        Me.txtapm.Size = New System.Drawing.Size(140, 20)
        Me.txtapm.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(38, 349)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(146, 21)
        Me.Label13.TabIndex = 79
        Me.Label13.Text = "Apellido Materno"
        '
        'txtapp
        '
        Me.txtapp.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtapp.Location = New System.Drawing.Point(186, 306)
        Me.txtapp.Name = "txtapp"
        Me.txtapp.Size = New System.Drawing.Size(140, 20)
        Me.txtapp.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(38, 306)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(140, 21)
        Me.Label14.TabIndex = 77
        Me.Label14.Text = "Apellido Paterno"
        '
        'txtnombre
        '
        Me.txtnombre.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtnombre.Location = New System.Drawing.Point(130, 262)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(196, 20)
        Me.txtnombre.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(38, 262)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 21)
        Me.Label15.TabIndex = 75
        Me.Label15.Text = "Nombre"
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
        Me.BunifuFlatButton3.TabIndex = 8
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
        Me.BunifuFlatButton5.TabIndex = 7
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
        Me.BunifuFlatButton1.ButtonText = "Nuevo Socio"
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
        Me.BunifuFlatButton1.Text = "Nuevo Socio"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'addSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(870, 483)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addSocio"
        Me.Text = "addSocio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvVista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton5 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtcel As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtdir As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label11 As Label
    Friend WithEvents txttel As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtapm As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtapp As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtnombre As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label15 As Label
    Friend WithEvents dgvVista As DataGridView
End Class
