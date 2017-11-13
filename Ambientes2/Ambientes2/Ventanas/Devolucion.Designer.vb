<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Devolucion
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.dgvDevol = New System.Windows.Forms.DataGridView()
        Me.txtBId = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvvigencia = New System.Windows.Forms.DataGridView()
        Me.dgvSocio = New System.Windows.Forms.DataGridView()
        Me.Btncheck = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.txtPago = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRentas = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMembre = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotal = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnok = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BtnRenovar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.dgvDevol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvvigencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'dgvDevol
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvDevol.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvDevol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDevol.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvDevol.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDevol.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvDevol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDevol.Location = New System.Drawing.Point(21, 52)
        Me.dgvDevol.Name = "dgvDevol"
        Me.dgvDevol.Size = New System.Drawing.Size(548, 384)
        Me.dgvDevol.TabIndex = 13
        '
        'txtBId
        '
        Me.txtBId.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtBId.Location = New System.Drawing.Point(15, 94)
        Me.txtBId.Name = "txtBId"
        Me.txtBId.Size = New System.Drawing.Size(241, 20)
        Me.txtBId.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero de Socio"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvvigencia)
        Me.GroupBox1.Controls.Add(Me.dgvSocio)
        Me.GroupBox1.Controls.Add(Me.Btncheck)
        Me.GroupBox1.Controls.Add(Me.BtnRenovar)
        Me.GroupBox1.Controls.Add(Me.BunifuFlatButton1)
        Me.GroupBox1.Controls.Add(Me.txtBId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(585, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 282)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'dgvvigencia
        '
        Me.dgvvigencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvvigencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvvigencia.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgvvigencia.Location = New System.Drawing.Point(15, 180)
        Me.dgvvigencia.Name = "dgvvigencia"
        Me.dgvvigencia.Size = New System.Drawing.Size(239, 44)
        Me.dgvvigencia.TabIndex = 37
        '
        'dgvSocio
        '
        Me.dgvSocio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSocio.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvSocio.Location = New System.Drawing.Point(15, 130)
        Me.dgvSocio.Name = "dgvSocio"
        Me.dgvSocio.Size = New System.Drawing.Size(239, 44)
        Me.dgvSocio.TabIndex = 36
        '
        'Btncheck
        '
        Me.Btncheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Btncheck.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Btncheck.Checked = True
        Me.Btncheck.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Btncheck.Enabled = False
        Me.Btncheck.ForeColor = System.Drawing.Color.White
        Me.Btncheck.Location = New System.Drawing.Point(159, 71)
        Me.Btncheck.Name = "Btncheck"
        Me.Btncheck.Size = New System.Drawing.Size(20, 20)
        Me.Btncheck.TabIndex = 26
        '
        'txtPago
        '
        Me.txtPago.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtPago.Location = New System.Drawing.Point(721, 420)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(95, 20)
        Me.txtPago.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(666, 420)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 21)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Pago"
        '
        'txtRentas
        '
        Me.txtRentas.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtRentas.Enabled = False
        Me.txtRentas.Location = New System.Drawing.Point(722, 354)
        Me.txtRentas.Name = "txtRentas"
        Me.txtRentas.Size = New System.Drawing.Size(95, 20)
        Me.txtRentas.TabIndex = 33
        Me.txtRentas.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(652, 354)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 21)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Rentas"
        '
        'txtMembre
        '
        Me.txtMembre.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtMembre.Enabled = False
        Me.txtMembre.Location = New System.Drawing.Point(722, 322)
        Me.txtMembre.Name = "txtMembre"
        Me.txtMembre.Size = New System.Drawing.Size(95, 20)
        Me.txtMembre.TabIndex = 35
        Me.txtMembre.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(620, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 21)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Membresia"
        '
        'txtTotal
        '
        Me.txtTotal.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(722, 386)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(95, 20)
        Me.txtTotal.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(597, 385)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 21)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Total a  Pagar"
        '
        'BunifuFlatButton4
        '
        Me.BunifuFlatButton4.Activecolor = System.Drawing.Color.Red
        Me.BunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton4.BorderRadius = 0
        Me.BunifuFlatButton4.ButtonText = ""
        Me.BunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.Iconimage = Global.Ambientes2.My.Resources.Resources.icons8_Delete_26px
        Me.BunifuFlatButton4.Iconimage_right = Nothing
        Me.BunifuFlatButton4.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton4.Iconimage_Selected = Nothing
        Me.BunifuFlatButton4.IconMarginLeft = 0
        Me.BunifuFlatButton4.IconMarginRight = 0
        Me.BunifuFlatButton4.IconRightVisible = True
        Me.BunifuFlatButton4.IconRightZoom = 0R
        Me.BunifuFlatButton4.IconVisible = True
        Me.BunifuFlatButton4.IconZoom = 40.0R
        Me.BunifuFlatButton4.IsTab = False
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(823, 322)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.Red
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton4.selected = False
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(20, 20)
        Me.BunifuFlatButton4.TabIndex = 38
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(611, 465)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.Red
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(106, 38)
        Me.BunifuFlatButton3.TabIndex = 29
        Me.BunifuFlatButton3.Text = "  Cancelar"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnok.Location = New System.Drawing.Point(735, 465)
        Me.btnok.Name = "btnok"
        Me.btnok.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnok.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnok.OnHoverTextColor = System.Drawing.Color.White
        Me.btnok.selected = False
        Me.btnok.Size = New System.Drawing.Size(106, 38)
        Me.btnok.TabIndex = 28
        Me.btnok.Text = "  Finalizar"
        Me.btnok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnok.Textcolor = System.Drawing.Color.White
        Me.btnok.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Adeudos"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = Global.Ambientes2.My.Resources.Resources.icons8_Search_96px_1
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = False
        Me.BunifuFlatButton2.IconZoom = 80.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(21, 15)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(549, 38)
        Me.BunifuFlatButton2.TabIndex = 27
        Me.BunifuFlatButton2.Text = "Adeudos"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnRenovar
        '
        Me.BtnRenovar.Activecolor = System.Drawing.Color.Red
        Me.BtnRenovar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnRenovar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRenovar.BorderRadius = 0
        Me.BtnRenovar.ButtonText = "Renovar"
        Me.BtnRenovar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRenovar.DisabledColor = System.Drawing.Color.Gray
        Me.BtnRenovar.Enabled = False
        Me.BtnRenovar.Iconcolor = System.Drawing.Color.Transparent
        Me.BtnRenovar.Iconimage = Global.Ambientes2.My.Resources.Resources.icons8_Delete_96px_1
        Me.BtnRenovar.Iconimage_right = Nothing
        Me.BtnRenovar.Iconimage_right_Selected = Nothing
        Me.BtnRenovar.Iconimage_Selected = Nothing
        Me.BtnRenovar.IconMarginLeft = 0
        Me.BtnRenovar.IconMarginRight = 0
        Me.BtnRenovar.IconRightVisible = True
        Me.BtnRenovar.IconRightZoom = 0R
        Me.BtnRenovar.IconVisible = False
        Me.BtnRenovar.IconZoom = 80.0R
        Me.BtnRenovar.IsTab = False
        Me.BtnRenovar.Location = New System.Drawing.Point(109, 243)
        Me.BtnRenovar.Name = "BtnRenovar"
        Me.BtnRenovar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnRenovar.OnHovercolor = System.Drawing.Color.Red
        Me.BtnRenovar.OnHoverTextColor = System.Drawing.Color.White
        Me.BtnRenovar.selected = False
        Me.BtnRenovar.Size = New System.Drawing.Size(62, 22)
        Me.BtnRenovar.TabIndex = 25
        Me.BtnRenovar.Text = "Renovar"
        Me.BtnRenovar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRenovar.Textcolor = System.Drawing.Color.White
        Me.BtnRenovar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'Devolucion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(870, 533)
        Me.Controls.Add(Me.BunifuFlatButton4)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMembre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPago)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRentas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BunifuFlatButton3)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.BunifuFlatButton2)
        Me.Controls.Add(Me.dgvDevol)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Devolucion"
        Me.Text = "Devolucion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvDevol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvvigencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents dgvDevol As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtBId As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btncheck As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BtnRenovar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtPago As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRentas As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnok As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dgvSocio As DataGridView
    Friend WithEvents dgvvigencia As DataGridView
    Friend WithEvents txtMembre As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotal As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuFlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
End Class
