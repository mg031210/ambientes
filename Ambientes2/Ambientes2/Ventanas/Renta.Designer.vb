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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.dgvPelis = New System.Windows.Forms.DataGridView()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBTitulo = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBId = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomTextbox2 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuCustomTextbox1 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BunifuCustomTextbox3 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BunifuCheckbox1 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BunifuFlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.dgvPelis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'dgvPelis
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvPelis.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPelis.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvPelis.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPelis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvPelis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPelis.Location = New System.Drawing.Point(16, 15)
        Me.dgvPelis.Name = "dgvPelis"
        Me.dgvPelis.Size = New System.Drawing.Size(548, 150)
        Me.dgvPelis.TabIndex = 11
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
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(-1, 6)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CodigoBarras"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BunifuFlatButton1)
        Me.GroupBox1.Controls.Add(Me.txtBTitulo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtBId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(583, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 156)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'txtBTitulo
        '
        Me.txtBTitulo.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtBTitulo.Location = New System.Drawing.Point(14, 121)
        Me.txtBTitulo.Name = "txtBTitulo"
        Me.txtBTitulo.Size = New System.Drawing.Size(241, 20)
        Me.txtBTitulo.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Titulo"
        '
        'txtBId
        '
        Me.txtBId.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtBId.Location = New System.Drawing.Point(14, 74)
        Me.txtBId.Name = "txtBId"
        Me.txtBId.Size = New System.Drawing.Size(241, 20)
        Me.txtBId.TabIndex = 4
        '
        'BunifuCustomTextbox2
        '
        Me.BunifuCustomTextbox2.BorderColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomTextbox2.Location = New System.Drawing.Point(409, 492)
        Me.BunifuCustomTextbox2.Name = "BunifuCustomTextbox2"
        Me.BunifuCustomTextbox2.Size = New System.Drawing.Size(95, 20)
        Me.BunifuCustomTextbox2.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(354, 492)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 21)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Pago"
        '
        'BunifuCustomTextbox1
        '
        Me.BunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomTextbox1.Location = New System.Drawing.Point(215, 492)
        Me.BunifuCustomTextbox1.Name = "BunifuCustomTextbox1"
        Me.BunifuCustomTextbox1.Size = New System.Drawing.Size(95, 20)
        Me.BunifuCustomTextbox1.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(90, 491)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 21)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Total a  Pagar"
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
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(615, 474)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.Red
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(106, 38)
        Me.BunifuFlatButton3.TabIndex = 16
        Me.BunifuFlatButton3.Text = "  Cancelar"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(416, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 23)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Renta"
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "  Finalizar"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Enabled = False
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = Global.Ambientes2.My.Resources.Resources.icons8_Checkmark_96px
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 80.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(745, 474)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(106, 38)
        Me.BunifuFlatButton2.TabIndex = 15
        Me.BunifuFlatButton2.Text = "  Finalizar"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'DataGridView1
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 206)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(835, 210)
        Me.DataGridView1.TabIndex = 13
        '
        'BunifuCustomTextbox3
        '
        Me.BunifuCustomTextbox3.BorderColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomTextbox3.Location = New System.Drawing.Point(215, 440)
        Me.BunifuCustomTextbox3.Name = "BunifuCustomTextbox3"
        Me.BunifuCustomTextbox3.Size = New System.Drawing.Size(262, 20)
        Me.BunifuCustomTextbox3.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(67, 440)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 21)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Numero de Socio"
        '
        'BunifuCheckbox1
        '
        Me.BunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckbox1.Checked = True
        Me.BunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckbox1.Enabled = False
        Me.BunifuCheckbox1.ForeColor = System.Drawing.Color.White
        Me.BunifuCheckbox1.Location = New System.Drawing.Point(484, 440)
        Me.BunifuCheckbox1.Name = "BunifuCheckbox1"
        Me.BunifuCheckbox1.Size = New System.Drawing.Size(20, 20)
        Me.BunifuCheckbox1.TabIndex = 24
        '
        'BunifuFlatButton4
        '
        Me.BunifuFlatButton4.Activecolor = System.Drawing.Color.Red
        Me.BunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton4.BorderRadius = 0
        Me.BunifuFlatButton4.ButtonText = "Renovar"
        Me.BunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.Iconimage = Global.Ambientes2.My.Resources.Resources.icons8_Delete_96px_1
        Me.BunifuFlatButton4.Iconimage_right = Nothing
        Me.BunifuFlatButton4.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton4.Iconimage_Selected = Nothing
        Me.BunifuFlatButton4.IconMarginLeft = 0
        Me.BunifuFlatButton4.IconMarginRight = 0
        Me.BunifuFlatButton4.IconRightVisible = True
        Me.BunifuFlatButton4.IconRightZoom = 0R
        Me.BunifuFlatButton4.IconVisible = False
        Me.BunifuFlatButton4.IconZoom = 80.0R
        Me.BunifuFlatButton4.IsTab = False
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(512, 439)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.Red
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton4.selected = False
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(62, 22)
        Me.BunifuFlatButton4.TabIndex = 16
        Me.BunifuFlatButton4.Text = "Renovar"
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Renta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(870, 533)
        Me.Controls.Add(Me.BunifuCheckbox1)
        Me.Controls.Add(Me.BunifuCustomTextbox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvPelis)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BunifuCustomTextbox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BunifuCustomTextbox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BunifuFlatButton4)
        Me.Controls.Add(Me.BunifuFlatButton3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BunifuFlatButton2)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Renta"
        Me.Text = "Renta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvPelis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents dgvPelis As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtBTitulo As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBId As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuCustomTextbox2 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuCustomTextbox1 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BunifuCustomTextbox3 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents BunifuCheckbox1 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BunifuFlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
End Class
