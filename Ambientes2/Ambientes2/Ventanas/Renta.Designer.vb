<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Renta
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.txtSocio = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btncheck = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.btnRenovar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.dgvPelis = New System.Windows.Forms.DataGridView()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.pago = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.total = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnok = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.dgvVenta = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.titulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBTitulo = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBId = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvSocio = New System.Windows.Forms.DataGridView()
        Me.dgvvigencia = New System.Windows.Forms.DataGridView()
        CType(Me.dgvPelis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSocio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvvigencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'txtSocio
        '
        Me.txtSocio.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtSocio.Location = New System.Drawing.Point(160, 435)
        Me.txtSocio.Name = "txtSocio"
        Me.txtSocio.Size = New System.Drawing.Size(137, 20)
        Me.txtSocio.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(12, 435)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 21)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Numero de Socio"
        '
        'btncheck
        '
        Me.btncheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btncheck.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btncheck.Checked = True
        Me.btncheck.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btncheck.Enabled = False
        Me.btncheck.ForeColor = System.Drawing.Color.White
        Me.btncheck.Location = New System.Drawing.Point(303, 435)
        Me.btncheck.Name = "btncheck"
        Me.btncheck.Size = New System.Drawing.Size(20, 20)
        Me.btncheck.TabIndex = 24
        Me.btncheck.Visible = False
        '
        'btnRenovar
        '
        Me.btnRenovar.Activecolor = System.Drawing.Color.Red
        Me.btnRenovar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnRenovar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRenovar.BorderRadius = 0
        Me.btnRenovar.ButtonText = "Renovar"
        Me.btnRenovar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRenovar.DisabledColor = System.Drawing.Color.Gray
        Me.btnRenovar.Enabled = False
        Me.btnRenovar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnRenovar.Iconimage = Global.Ambientes2.My.Resources.Resources.icons8_Delete_96px_1
        Me.btnRenovar.Iconimage_right = Nothing
        Me.btnRenovar.Iconimage_right_Selected = Nothing
        Me.btnRenovar.Iconimage_Selected = Nothing
        Me.btnRenovar.IconMarginLeft = 0
        Me.btnRenovar.IconMarginRight = 0
        Me.btnRenovar.IconRightVisible = True
        Me.btnRenovar.IconRightZoom = 0R
        Me.btnRenovar.IconVisible = False
        Me.btnRenovar.IconZoom = 80.0R
        Me.btnRenovar.IsTab = False
        Me.btnRenovar.Location = New System.Drawing.Point(331, 434)
        Me.btnRenovar.Name = "btnRenovar"
        Me.btnRenovar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnRenovar.OnHovercolor = System.Drawing.Color.Red
        Me.btnRenovar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnRenovar.selected = False
        Me.btnRenovar.Size = New System.Drawing.Size(62, 22)
        Me.btnRenovar.TabIndex = 16
        Me.btnRenovar.Text = "Renovar"
        Me.btnRenovar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRenovar.Textcolor = System.Drawing.Color.White
        Me.btnRenovar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(599, 485)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.Red
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(106, 38)
        Me.BunifuFlatButton3.TabIndex = 34
        Me.BunifuFlatButton3.Text = "  Cancelar"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'dgvPelis
        '
        Me.dgvPelis.AllowUserToAddRows = False
        Me.dgvPelis.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvPelis.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPelis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPelis.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvPelis.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPelis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvPelis.Location = New System.Drawing.Point(17, 19)
        Me.dgvPelis.Name = "dgvPelis"
        Me.dgvPelis.ReadOnly = True
        Me.dgvPelis.Size = New System.Drawing.Size(548, 150)
        Me.dgvPelis.TabIndex = 25
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Buscar"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Global.Ambientes2.My.Resources.Resources.icons8_Search_96px_1
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
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(0, 6)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(275, 38)
        Me.BunifuFlatButton1.TabIndex = 4
        Me.BunifuFlatButton1.Text = "Buscar"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'pago
        '
        Me.pago.BorderColor = System.Drawing.Color.SeaGreen
        Me.pago.Location = New System.Drawing.Point(396, 494)
        Me.pago.Name = "pago"
        Me.pago.Size = New System.Drawing.Size(95, 20)
        Me.pago.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(341, 494)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 21)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Pago"
        '
        'total
        '
        Me.total.BorderColor = System.Drawing.Color.SeaGreen
        Me.total.Location = New System.Drawing.Point(202, 494)
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Size = New System.Drawing.Size(95, 20)
        Me.total.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(77, 493)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 21)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Total a  Pagar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(417, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 23)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Renta"
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
        Me.btnok.Enabled = False
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
        Me.btnok.Location = New System.Drawing.Point(729, 485)
        Me.btnok.Name = "btnok"
        Me.btnok.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnok.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnok.OnHoverTextColor = System.Drawing.Color.White
        Me.btnok.selected = False
        Me.btnok.Size = New System.Drawing.Size(106, 38)
        Me.btnok.TabIndex = 29
        Me.btnok.Text = "  Finalizar"
        Me.btnok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnok.Textcolor = System.Drawing.Color.White
        Me.btnok.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'dgvVenta
        '
        Me.dgvVenta.AllowUserToAddRows = False
        Me.dgvVenta.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvVenta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVenta.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.titulo, Me.tipo, Me.clasi, Me.cant})
        Me.dgvVenta.Location = New System.Drawing.Point(17, 210)
        Me.dgvVenta.Name = "dgvVenta"
        Me.dgvVenta.ReadOnly = True
        Me.dgvVenta.Size = New System.Drawing.Size(835, 210)
        Me.dgvVenta.TabIndex = 27
        '
        'codigo
        '
        Me.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.codigo.HeaderText = "CodigoBarras"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'titulo
        '
        Me.titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.titulo.HeaderText = "Titulo"
        Me.titulo.Name = "titulo"
        Me.titulo.ReadOnly = True
        '
        'tipo
        '
        Me.tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        '
        'clasi
        '
        Me.clasi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clasi.HeaderText = "Clasificacion"
        Me.clasi.Name = "clasi"
        Me.clasi.ReadOnly = True
        '
        'cant
        '
        Me.cant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cant.HeaderText = "Cantidad"
        Me.cant.Name = "cant"
        Me.cant.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BunifuFlatButton1)
        Me.GroupBox1.Controls.Add(Me.txtBTitulo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtBId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(584, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 156)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'txtBTitulo
        '
        Me.txtBTitulo.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtBTitulo.Location = New System.Drawing.Point(10, 118)
        Me.txtBTitulo.Name = "txtBTitulo"
        Me.txtBTitulo.Size = New System.Drawing.Size(241, 20)
        Me.txtBTitulo.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Titulo"
        '
        'txtBId
        '
        Me.txtBId.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtBId.Location = New System.Drawing.Point(10, 71)
        Me.txtBId.Name = "txtBId"
        Me.txtBId.Size = New System.Drawing.Size(241, 20)
        Me.txtBId.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CodigoBarras"
        '
        'dgvSocio
        '
        Me.dgvSocio.AllowUserToAddRows = False
        Me.dgvSocio.AllowUserToDeleteRows = False
        Me.dgvSocio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSocio.Location = New System.Drawing.Point(400, 435)
        Me.dgvSocio.Name = "dgvSocio"
        Me.dgvSocio.ReadOnly = True
        Me.dgvSocio.Size = New System.Drawing.Size(305, 44)
        Me.dgvSocio.TabIndex = 35
        '
        'dgvvigencia
        '
        Me.dgvvigencia.AllowUserToAddRows = False
        Me.dgvvigencia.AllowUserToDeleteRows = False
        Me.dgvvigencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvvigencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvvigencia.Location = New System.Drawing.Point(705, 435)
        Me.dgvvigencia.Name = "dgvvigencia"
        Me.dgvvigencia.ReadOnly = True
        Me.dgvvigencia.Size = New System.Drawing.Size(147, 44)
        Me.dgvvigencia.TabIndex = 36
        '
        'Renta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(870, 533)
        Me.Controls.Add(Me.dgvvigencia)
        Me.Controls.Add(Me.dgvSocio)
        Me.Controls.Add(Me.BunifuFlatButton3)
        Me.Controls.Add(Me.dgvPelis)
        Me.Controls.Add(Me.pago)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.dgvVenta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btncheck)
        Me.Controls.Add(Me.txtSocio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnRenovar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Renta"
        Me.Text = "Renta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvPelis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvSocio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvvigencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtSocio As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents btncheck As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents btnRenovar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dgvPelis As DataGridView
    Friend WithEvents pago As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents total As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnok As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dgvVenta As DataGridView
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents titulo As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents clasi As DataGridViewTextBoxColumn
    Friend WithEvents cant As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtBTitulo As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBId As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvSocio As DataGridView
    Friend WithEvents dgvvigencia As DataGridView
End Class
