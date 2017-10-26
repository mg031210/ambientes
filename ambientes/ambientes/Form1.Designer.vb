<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SocioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SocioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SocioToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedorToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MembresíasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenovaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuarioToolStripMenuItem, Me.SocioToolStripMenuItem, Me.ProveedorToolStripMenuItem, Me.RegistrarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.MembresíasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(95, 421)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(88, 19)
        Me.UsuarioToolStripMenuItem.Text = "Venta"
        '
        'SocioToolStripMenuItem
        '
        Me.SocioToolStripMenuItem.Name = "SocioToolStripMenuItem"
        Me.SocioToolStripMenuItem.Size = New System.Drawing.Size(88, 19)
        Me.SocioToolStripMenuItem.Text = "Renta"
        '
        'ProveedorToolStripMenuItem
        '
        Me.ProveedorToolStripMenuItem.Name = "ProveedorToolStripMenuItem"
        Me.ProveedorToolStripMenuItem.Size = New System.Drawing.Size(88, 19)
        Me.ProveedorToolStripMenuItem.Text = "Compra"
        '
        'RegistrarToolStripMenuItem
        '
        Me.RegistrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SocioToolStripMenuItem1, Me.UsuarioToolStripMenuItem1, Me.ProveedorToolStripMenuItem1})
        Me.RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
        Me.RegistrarToolStripMenuItem.Size = New System.Drawing.Size(88, 19)
        Me.RegistrarToolStripMenuItem.Text = "Registrar"
        '
        'SocioToolStripMenuItem1
        '
        Me.SocioToolStripMenuItem1.Name = "SocioToolStripMenuItem1"
        Me.SocioToolStripMenuItem1.Size = New System.Drawing.Size(128, 22)
        Me.SocioToolStripMenuItem1.Text = "Socio"
        '
        'UsuarioToolStripMenuItem1
        '
        Me.UsuarioToolStripMenuItem1.Name = "UsuarioToolStripMenuItem1"
        Me.UsuarioToolStripMenuItem1.Size = New System.Drawing.Size(128, 22)
        Me.UsuarioToolStripMenuItem1.Text = "Usuario"
        '
        'ProveedorToolStripMenuItem1
        '
        Me.ProveedorToolStripMenuItem1.Name = "ProveedorToolStripMenuItem1"
        Me.ProveedorToolStripMenuItem1.Size = New System.Drawing.Size(128, 22)
        Me.ProveedorToolStripMenuItem1.Text = "Proveedor"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SocioToolStripMenuItem2, Me.UsuarioToolStripMenuItem2, Me.ProveedorToolStripMenuItem2})
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(88, 19)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'SocioToolStripMenuItem2
        '
        Me.SocioToolStripMenuItem2.Name = "SocioToolStripMenuItem2"
        Me.SocioToolStripMenuItem2.Size = New System.Drawing.Size(128, 22)
        Me.SocioToolStripMenuItem2.Text = "Socio"
        '
        'UsuarioToolStripMenuItem2
        '
        Me.UsuarioToolStripMenuItem2.Name = "UsuarioToolStripMenuItem2"
        Me.UsuarioToolStripMenuItem2.Size = New System.Drawing.Size(128, 22)
        Me.UsuarioToolStripMenuItem2.Text = "Usuario"
        '
        'ProveedorToolStripMenuItem2
        '
        Me.ProveedorToolStripMenuItem2.Name = "ProveedorToolStripMenuItem2"
        Me.ProveedorToolStripMenuItem2.Size = New System.Drawing.Size(128, 22)
        Me.ProveedorToolStripMenuItem2.Text = "Proveedor"
        '
        'MembresíasToolStripMenuItem
        '
        Me.MembresíasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaToolStripMenuItem, Me.RenovaciónToolStripMenuItem})
        Me.MembresíasToolStripMenuItem.Name = "MembresíasToolStripMenuItem"
        Me.MembresíasToolStripMenuItem.Size = New System.Drawing.Size(88, 19)
        Me.MembresíasToolStripMenuItem.Text = "Membresías"
        '
        'NuevaToolStripMenuItem
        '
        Me.NuevaToolStripMenuItem.Name = "NuevaToolStripMenuItem"
        Me.NuevaToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.NuevaToolStripMenuItem.Text = "Nueva"
        '
        'RenovaciónToolStripMenuItem
        '
        Me.RenovaciónToolStripMenuItem.Name = "RenovaciónToolStripMenuItem"
        Me.RenovaciónToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.RenovaciónToolStripMenuItem.Text = "Renovación"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(754, 421)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SocioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SocioToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProveedorToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SocioToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ProveedorToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents MembresíasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RenovaciónToolStripMenuItem As ToolStripMenuItem
End Class
