<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addPeli
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvVista = New System.Windows.Forms.DataGridView()
        Me.radiocat = New System.Windows.Forms.RadioButton()
        Me.radioestreno = New System.Windows.Forms.RadioButton()
        Me.txtcategoria = New System.Windows.Forms.ComboBox()
        Me.txtclas = New System.Windows.Forms.ComboBox()
        Me.txtdur = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncancel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnok = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txttitulo = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dgvVista)
        Me.GroupBox1.Controls.Add(Me.radiocat)
        Me.GroupBox1.Controls.Add(Me.radioestreno)
        Me.GroupBox1.Controls.Add(Me.txtcategoria)
        Me.GroupBox1.Controls.Add(Me.txtclas)
        Me.GroupBox1.Controls.Add(Me.txtdur)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btncancel)
        Me.GroupBox1.Controls.Add(Me.btnok)
        Me.GroupBox1.Controls.Add(Me.txttitulo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BunifuFlatButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(846, 459)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(276, 334)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 21)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "mins"
        '
        'dgvVista
        '
        Me.dgvVista.AllowUserToAddRows = False
        Me.dgvVista.AllowUserToDeleteRows = False
        Me.dgvVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVista.Location = New System.Drawing.Point(38, 54)
        Me.dgvVista.Name = "dgvVista"
        Me.dgvVista.ReadOnly = True
        Me.dgvVista.Size = New System.Drawing.Size(775, 150)
        Me.dgvVista.TabIndex = 52
        '
        'radiocat
        '
        Me.radiocat.AutoSize = True
        Me.radiocat.Checked = True
        Me.radiocat.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radiocat.ForeColor = System.Drawing.Color.White
        Me.radiocat.Location = New System.Drawing.Point(615, 290)
        Me.radiocat.Name = "radiocat"
        Me.radiocat.Size = New System.Drawing.Size(104, 25)
        Me.radiocat.TabIndex = 5
        Me.radiocat.TabStop = True
        Me.radiocat.Text = "Catalogo"
        Me.radiocat.UseVisualStyleBackColor = True
        '
        'radioestreno
        '
        Me.radioestreno.AutoSize = True
        Me.radioestreno.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioestreno.ForeColor = System.Drawing.Color.White
        Me.radioestreno.Location = New System.Drawing.Point(615, 321)
        Me.radioestreno.Name = "radioestreno"
        Me.radioestreno.Size = New System.Drawing.Size(85, 25)
        Me.radioestreno.TabIndex = 50
        Me.radioestreno.Text = "Estreno"
        Me.radioestreno.UseVisualStyleBackColor = True
        '
        'txtcategoria
        '
        Me.txtcategoria.FormattingEnabled = True
        Me.txtcategoria.Items.AddRange(New Object() {"Ficcion", "Miedo", "Accion", "Aventura", "Comedia", "Drama", "Musical", "Misterio", "Romance", "Deportes", "Animacion"})
        Me.txtcategoria.Location = New System.Drawing.Point(655, 240)
        Me.txtcategoria.Name = "txtcategoria"
        Me.txtcategoria.Size = New System.Drawing.Size(138, 21)
        Me.txtcategoria.TabIndex = 4
        '
        'txtclas
        '
        Me.txtclas.FormattingEnabled = True
        Me.txtclas.Items.AddRange(New Object() {"AA", "A", "B", "B15", "C", "D"})
        Me.txtclas.Location = New System.Drawing.Point(175, 286)
        Me.txtclas.Name = "txtclas"
        Me.txtclas.Size = New System.Drawing.Size(138, 21)
        Me.txtclas.TabIndex = 2
        '
        'txtdur
        '
        Me.txtdur.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtdur.Location = New System.Drawing.Point(175, 335)
        Me.txtdur.Name = "txtdur"
        Me.txtdur.Size = New System.Drawing.Size(95, 20)
        Me.txtdur.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(558, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 21)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Categoria"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(61, 289)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 21)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Clasificacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(558, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 21)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Tipo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(61, 335)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 21)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Duracion"
        '
        'btncancel
        '
        Me.btncancel.Activecolor = System.Drawing.Color.Red
        Me.btncancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancel.BorderRadius = 0
        Me.btncancel.ButtonText = "  Cancelar"
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.DisabledColor = System.Drawing.Color.Gray
        Me.btncancel.Iconcolor = System.Drawing.Color.Transparent
        Me.btncancel.Iconimage = Global.Ambientes2.My.Resources.Resources.icons8_Delete_96px_1
        Me.btncancel.Iconimage_right = Nothing
        Me.btncancel.Iconimage_right_Selected = Nothing
        Me.btncancel.Iconimage_Selected = Nothing
        Me.btncancel.IconMarginLeft = 0
        Me.btncancel.IconMarginRight = 0
        Me.btncancel.IconRightVisible = True
        Me.btncancel.IconRightZoom = 0R
        Me.btncancel.IconVisible = True
        Me.btncancel.IconZoom = 80.0R
        Me.btncancel.IsTab = False
        Me.btncancel.Location = New System.Drawing.Point(595, 402)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btncancel.OnHovercolor = System.Drawing.Color.Red
        Me.btncancel.OnHoverTextColor = System.Drawing.Color.White
        Me.btncancel.selected = False
        Me.btncancel.Size = New System.Drawing.Size(106, 38)
        Me.btncancel.TabIndex = 7
        Me.btncancel.Text = "  Cancelar"
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancel.Textcolor = System.Drawing.Color.White
        Me.btncancel.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnok
        '
        Me.btnok.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnok.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnok.BorderRadius = 0
        Me.btnok.ButtonText = "  Finalizar"
        Me.btnok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnok.DisabledColor = System.Drawing.Color.Gray
        Me.btnok.Iconcolor = System.Drawing.Color.Transparent
        Me.btnok.Iconimage = Global.Ambientes2.My.Resources.Resources.icons8_Checkmark_96px
        Me.btnok.Iconimage_right = Nothing
        Me.btnok.Iconimage_right_Selected = Nothing
        Me.btnok.Iconimage_Selected = Nothing
        Me.btnok.IconMarginLeft = 0
        Me.btnok.IconMarginRight = 0
        Me.btnok.IconRightVisible = True
        Me.btnok.IconRightZoom = 0R
        Me.btnok.IconVisible = True
        Me.btnok.IconZoom = 80.0R
        Me.btnok.IsTab = False
        Me.btnok.Location = New System.Drawing.Point(725, 402)
        Me.btnok.Name = "btnok"
        Me.btnok.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnok.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnok.OnHoverTextColor = System.Drawing.Color.White
        Me.btnok.selected = False
        Me.btnok.Size = New System.Drawing.Size(106, 38)
        Me.btnok.TabIndex = 6
        Me.btnok.Text = "  Finalizar"
        Me.btnok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnok.Textcolor = System.Drawing.Color.White
        Me.btnok.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txttitulo
        '
        Me.txttitulo.BorderColor = System.Drawing.Color.SeaGreen
        Me.txttitulo.Location = New System.Drawing.Point(175, 240)
        Me.txttitulo.Name = "txttitulo"
        Me.txttitulo.Size = New System.Drawing.Size(358, 20)
        Me.txttitulo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(61, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 21)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Titulo"
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Nueva Pelicula"
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
        Me.BunifuFlatButton1.Text = "Nueva Pelicula"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'addPeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(870, 483)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addPeli"
        Me.Text = "addPeli"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvVista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btncancel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnok As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txttitulo As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtdur As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents radiocat As RadioButton
    Friend WithEvents radioestreno As RadioButton
    Friend WithEvents txtcategoria As ComboBox
    Friend WithEvents txtclas As ComboBox
    Friend WithEvents dgvVista As DataGridView
    Friend WithEvents Label6 As Label
End Class
