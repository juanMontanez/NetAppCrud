<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class modalEliminarEmpleado
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
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconPerfil = New FontAwesome.Sharp.IconPictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCancelar = New FontAwesome.Sharp.IconButton()
        Me.btnAceptar = New FontAwesome.Sharp.IconButton()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContainer.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.IconPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.RoyalBlue
        Me.PanelTitleBar.Controls.Add(Me.Label1)
        Me.PanelTitleBar.Controls.Add(Me.IconPictureBox1)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(408, 59)
        Me.PanelTitleBar.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "¿Desea eliminar el usuario seleccionado?"
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.RoyalBlue
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.Red
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.IconPictureBox1.IconColor = System.Drawing.Color.Red
        Me.IconPictureBox1.Location = New System.Drawing.Point(30, 7)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox1.TabIndex = 0
        Me.IconPictureBox1.TabStop = False
        '
        'PanelContainer
        '
        Me.PanelContainer.Controls.Add(Me.Panel1)
        Me.PanelContainer.Controls.Add(Me.btnCancelar)
        Me.PanelContainer.Controls.Add(Me.btnAceptar)
        Me.PanelContainer.Location = New System.Drawing.Point(1, 44)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(405, 449)
        Me.PanelContainer.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.IconPerfil)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.lblNombre)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblCargo)
        Me.Panel1.Controls.Add(Me.lblApellidos)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(30, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(347, 254)
        Me.Panel1.TabIndex = 10
        '
        'IconPerfil
        '
        Me.IconPerfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.IconPerfil.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconPerfil.IconChar = FontAwesome.Sharp.IconChar.UserCircle
        Me.IconPerfil.IconColor = System.Drawing.Color.Gainsboro
        Me.IconPerfil.IconSize = 95
        Me.IconPerfil.Location = New System.Drawing.Point(129, 3)
        Me.IconPerfil.Name = "IconPerfil"
        Me.IconPerfil.Size = New System.Drawing.Size(95, 96)
        Me.IconPerfil.TabIndex = 10
        Me.IconPerfil.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre : "
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(79, 215)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(17, 17)
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.Text = "E"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(79, 132)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(18, 17)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "N"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Email :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Apellidos :"
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargo.Location = New System.Drawing.Point(79, 187)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(17, 17)
        Me.lblCargo.TabIndex = 7
        Me.lblCargo.Text = "C"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.Location = New System.Drawing.Point(79, 160)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(17, 17)
        Me.lblApellidos.TabIndex = 5
        Me.lblApellidos.Text = "A"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Cargo: "
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnCancelar.IconColor = System.Drawing.Color.Red
        Me.btnCancelar.IconSize = 32
        Me.btnCancelar.Location = New System.Drawing.Point(251, 357)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Rotation = 0R
        Me.btnCancelar.Size = New System.Drawing.Size(126, 40)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btnAceptar.IconColor = System.Drawing.Color.Lime
        Me.btnAceptar.IconSize = 32
        Me.btnAceptar.Location = New System.Drawing.Point(30, 357)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Rotation = 0R
        Me.btnAceptar.Size = New System.Drawing.Size(126, 40)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'modalEliminarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(408, 494)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelContainer)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.ForeColor = System.Drawing.Color.Gainsboro
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "modalEliminarEmpleado"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "modalEliminarEmpleado"
        Me.TopMost = True
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContainer.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IconPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnCancelar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAceptar As FontAwesome.Sharp.IconButton
    Friend WithEvents lblEmail As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblCargo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconPerfil As FontAwesome.Sharp.IconPictureBox
End Class
