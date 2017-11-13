<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ticket
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
        Me.Barra1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
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
        Me.Barra1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Barra1.Location = New System.Drawing.Point(0, 0)
        Me.Barra1.Name = "Barra1"
        Me.Barra1.Size = New System.Drawing.Size(400, 40)
        Me.Barra1.TabIndex = 3
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
        Me.BunifuImageButton2.Location = New System.Drawing.Point(324, 0)
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
        Me.BunifuImageButton1.Location = New System.Drawing.Point(365, 0)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(35, 35)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuImageButton1.TabIndex = 2
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.DocumentMapWidth = 3
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Ambientes2.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 40)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(400, 514)
        Me.ReportViewer1.TabIndex = 4
        '
        'Ticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 554)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Barra1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ticket"
        Me.Text = "Ticket"
        Me.Barra1.ResumeLayout(False)
        Me.Barra1.PerformLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Barra1 As Panel
    Protected Friend WithEvents Label1 As Label
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
