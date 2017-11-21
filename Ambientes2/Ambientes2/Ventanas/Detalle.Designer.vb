<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Detalle
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvdet = New System.Windows.Forms.DataGridView()
        Me.btncancel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnok = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtpago = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txttotal = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcambio = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.peli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvdet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(390, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 24)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Detalle"
        '
        'dgvdet
        '
        Me.dgvdet.AllowUserToAddRows = False
        Me.dgvdet.AllowUserToDeleteRows = False
        Me.dgvdet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvdet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.peli, Me.cant, Me.uni, Me.total})
        Me.dgvdet.Location = New System.Drawing.Point(37, 56)
        Me.dgvdet.Name = "dgvdet"
        Me.dgvdet.ReadOnly = True
        Me.dgvdet.Size = New System.Drawing.Size(788, 333)
        Me.dgvdet.TabIndex = 85
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
        Me.btncancel.Location = New System.Drawing.Point(590, 417)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btncancel.OnHovercolor = System.Drawing.Color.Red
        Me.btncancel.OnHoverTextColor = System.Drawing.Color.White
        Me.btncancel.selected = False
        Me.btncancel.Size = New System.Drawing.Size(106, 38)
        Me.btncancel.TabIndex = 87
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
        Me.btnok.Location = New System.Drawing.Point(719, 417)
        Me.btnok.Name = "btnok"
        Me.btnok.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnok.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnok.OnHoverTextColor = System.Drawing.Color.White
        Me.btnok.selected = False
        Me.btnok.Size = New System.Drawing.Size(106, 38)
        Me.btnok.TabIndex = 86
        Me.btnok.Text = "  Finalizar"
        Me.btnok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnok.Textcolor = System.Drawing.Color.White
        Me.btnok.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtpago
        '
        Me.txtpago.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtpago.Location = New System.Drawing.Point(294, 424)
        Me.txtpago.Name = "txtpago"
        Me.txtpago.Size = New System.Drawing.Size(95, 20)
        Me.txtpago.TabIndex = 90
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(247, 423)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 21)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Pago"
        '
        'txttotal
        '
        Me.txttotal.BorderColor = System.Drawing.Color.SeaGreen
        Me.txttotal.Location = New System.Drawing.Point(131, 424)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(95, 20)
        Me.txttotal.TabIndex = 91
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(12, 423)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 21)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Total a  Pagar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(414, 421)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 21)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Cambio"
        '
        'txtcambio
        '
        Me.txtcambio.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtcambio.Location = New System.Drawing.Point(481, 424)
        Me.txtcambio.Name = "txtcambio"
        Me.txtcambio.ReadOnly = True
        Me.txtcambio.Size = New System.Drawing.Size(95, 20)
        Me.txtcambio.TabIndex = 93
        '
        'codigo
        '
        Me.codigo.HeaderText = "CodigoBarras"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'peli
        '
        Me.peli.HeaderText = "Pelicula"
        Me.peli.Name = "peli"
        Me.peli.ReadOnly = True
        '
        'cant
        '
        Me.cant.HeaderText = "Cantidad"
        Me.cant.Name = "cant"
        Me.cant.ReadOnly = True
        '
        'uni
        '
        Me.uni.HeaderText = "PrecioUni"
        Me.uni.Name = "uni"
        Me.uni.ReadOnly = True
        '
        'total
        '
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'Detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(870, 483)
        Me.Controls.Add(Me.txtcambio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpago)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.dgvdet)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Detalle"
        Me.Text = "Detalle"
        CType(Me.dgvdet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents dgvdet As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents btncancel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnok As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtcambio As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtpago As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents txttotal As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents peli As DataGridViewTextBoxColumn
    Friend WithEvents cant As DataGridViewTextBoxColumn
    Friend WithEvents uni As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
End Class
