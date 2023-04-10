<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.PanelSideMenu = New System.Windows.Forms.Panel()
        Me.btnLogOut = New FontAwesome.Sharp.IconButton()
        Me.PanelTrabajosSubMenu = New System.Windows.Forms.Panel()
        Me.btnDelParte = New FontAwesome.Sharp.IconButton()
        Me.btnModParte = New FontAwesome.Sharp.IconButton()
        Me.btnAddParte = New FontAwesome.Sharp.IconButton()
        Me.btnListPartes = New FontAwesome.Sharp.IconButton()
        Me.PanelUsuariosSubMenu = New System.Windows.Forms.Panel()
        Me.btnDel = New FontAwesome.Sharp.IconButton()
        Me.btnMod = New FontAwesome.Sharp.IconButton()
        Me.btnAdd = New FontAwesome.Sharp.IconButton()
        Me.btnUsuarios = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelChildForm = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelTittleBar = New System.Windows.Forms.Panel()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.tituloFormLabel = New System.Windows.Forms.Label()
        Me.IconCurrentFrm = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelSideMenu.SuspendLayout()
        Me.PanelTrabajosSubMenu.SuspendLayout()
        Me.PanelUsuariosSubMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelChildForm.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTittleBar.SuspendLayout()
        CType(Me.IconCurrentFrm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSideMenu
        '
        Me.PanelSideMenu.AutoScroll = True
        Me.PanelSideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.PanelSideMenu.Controls.Add(Me.btnLogOut)
        Me.PanelSideMenu.Controls.Add(Me.PanelTrabajosSubMenu)
        Me.PanelSideMenu.Controls.Add(Me.btnListPartes)
        Me.PanelSideMenu.Controls.Add(Me.PanelUsuariosSubMenu)
        Me.PanelSideMenu.Controls.Add(Me.btnUsuarios)
        Me.PanelSideMenu.Controls.Add(Me.PanelLogo)
        Me.PanelSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelSideMenu.Name = "PanelSideMenu"
        Me.PanelSideMenu.Size = New System.Drawing.Size(250, 735)
        Me.PanelSideMenu.TabIndex = 3
        '
        'btnLogOut
        '
        Me.btnLogOut.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.btnLogOut.IconColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnLogOut.IconSize = 32
        Me.btnLogOut.Location = New System.Drawing.Point(0, 693)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Rotation = 0R
        Me.btnLogOut.Size = New System.Drawing.Size(250, 40)
        Me.btnLogOut.TabIndex = 21
        Me.btnLogOut.Text = "Cerrar Sesión"
        Me.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'PanelTrabajosSubMenu
        '
        Me.PanelTrabajosSubMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelTrabajosSubMenu.Controls.Add(Me.btnDelParte)
        Me.PanelTrabajosSubMenu.Controls.Add(Me.btnModParte)
        Me.PanelTrabajosSubMenu.Controls.Add(Me.btnAddParte)
        Me.PanelTrabajosSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTrabajosSubMenu.Location = New System.Drawing.Point(0, 266)
        Me.PanelTrabajosSubMenu.Name = "PanelTrabajosSubMenu"
        Me.PanelTrabajosSubMenu.Size = New System.Drawing.Size(250, 122)
        Me.PanelTrabajosSubMenu.TabIndex = 19
        '
        'btnDelParte
        '
        Me.btnDelParte.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDelParte.FlatAppearance.BorderSize = 0
        Me.btnDelParte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelParte.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnDelParte.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelParte.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnDelParte.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.btnDelParte.IconColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnDelParte.IconSize = 32
        Me.btnDelParte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelParte.Location = New System.Drawing.Point(0, 80)
        Me.btnDelParte.Name = "btnDelParte"
        Me.btnDelParte.Padding = New System.Windows.Forms.Padding(40, 0, 20, 0)
        Me.btnDelParte.Rotation = 0R
        Me.btnDelParte.Size = New System.Drawing.Size(250, 40)
        Me.btnDelParte.TabIndex = 11
        Me.btnDelParte.Text = "Eliminar Parte"
        Me.btnDelParte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelParte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelParte.UseVisualStyleBackColor = True
        '
        'btnModParte
        '
        Me.btnModParte.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnModParte.FlatAppearance.BorderSize = 0
        Me.btnModParte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModParte.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnModParte.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModParte.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnModParte.IconChar = FontAwesome.Sharp.IconChar.PencilAlt
        Me.btnModParte.IconColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnModParte.IconSize = 32
        Me.btnModParte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModParte.Location = New System.Drawing.Point(0, 40)
        Me.btnModParte.Name = "btnModParte"
        Me.btnModParte.Padding = New System.Windows.Forms.Padding(40, 0, 20, 0)
        Me.btnModParte.Rotation = 0R
        Me.btnModParte.Size = New System.Drawing.Size(250, 40)
        Me.btnModParte.TabIndex = 10
        Me.btnModParte.Text = "Modificar Parte"
        Me.btnModParte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModParte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModParte.UseVisualStyleBackColor = True
        '
        'btnAddParte
        '
        Me.btnAddParte.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAddParte.FlatAppearance.BorderSize = 0
        Me.btnAddParte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddParte.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnAddParte.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddParte.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnAddParte.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btnAddParte.IconColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnAddParte.IconSize = 32
        Me.btnAddParte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddParte.Location = New System.Drawing.Point(0, 0)
        Me.btnAddParte.Name = "btnAddParte"
        Me.btnAddParte.Padding = New System.Windows.Forms.Padding(40, 0, 20, 0)
        Me.btnAddParte.Rotation = 0R
        Me.btnAddParte.Size = New System.Drawing.Size(250, 40)
        Me.btnAddParte.TabIndex = 12
        Me.btnAddParte.Text = "Añadir Parte"
        Me.btnAddParte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddParte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddParte.UseVisualStyleBackColor = True
        '
        'btnListPartes
        '
        Me.btnListPartes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnListPartes.FlatAppearance.BorderSize = 0
        Me.btnListPartes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnListPartes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListPartes.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnListPartes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListPartes.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnListPartes.IconChar = FontAwesome.Sharp.IconChar.Tools
        Me.btnListPartes.IconColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnListPartes.IconSize = 32
        Me.btnListPartes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListPartes.Location = New System.Drawing.Point(0, 226)
        Me.btnListPartes.Name = "btnListPartes"
        Me.btnListPartes.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnListPartes.Rotation = 0R
        Me.btnListPartes.Size = New System.Drawing.Size(250, 40)
        Me.btnListPartes.TabIndex = 20
        Me.btnListPartes.Text = "Trabajos Realizados"
        Me.btnListPartes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListPartes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnListPartes.UseVisualStyleBackColor = True
        '
        'PanelUsuariosSubMenu
        '
        Me.PanelUsuariosSubMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelUsuariosSubMenu.Controls.Add(Me.btnDel)
        Me.PanelUsuariosSubMenu.Controls.Add(Me.btnMod)
        Me.PanelUsuariosSubMenu.Controls.Add(Me.btnAdd)
        Me.PanelUsuariosSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelUsuariosSubMenu.Location = New System.Drawing.Point(0, 104)
        Me.PanelUsuariosSubMenu.Name = "PanelUsuariosSubMenu"
        Me.PanelUsuariosSubMenu.Size = New System.Drawing.Size(250, 122)
        Me.PanelUsuariosSubMenu.TabIndex = 17
        '
        'btnDel
        '
        Me.btnDel.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDel.FlatAppearance.BorderSize = 0
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnDel.IconChar = FontAwesome.Sharp.IconChar.UserTimes
        Me.btnDel.IconColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnDel.IconSize = 32
        Me.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDel.Location = New System.Drawing.Point(0, 80)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Padding = New System.Windows.Forms.Padding(40, 0, 20, 0)
        Me.btnDel.Rotation = 0R
        Me.btnDel.Size = New System.Drawing.Size(250, 40)
        Me.btnDel.TabIndex = 7
        Me.btnDel.Text = "Eliminar Empleados"
        Me.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMod.FlatAppearance.BorderSize = 0
        Me.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMod.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMod.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnMod.IconChar = FontAwesome.Sharp.IconChar.UserCog
        Me.btnMod.IconColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnMod.IconSize = 32
        Me.btnMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMod.Location = New System.Drawing.Point(0, 40)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Padding = New System.Windows.Forms.Padding(40, 0, 20, 0)
        Me.btnMod.Rotation = 0R
        Me.btnMod.Size = New System.Drawing.Size(250, 40)
        Me.btnMod.TabIndex = 6
        Me.btnMod.Text = "Modificar Empleados"
        Me.btnMod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.btnAdd.IconColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnAdd.IconSize = 32
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(0, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Padding = New System.Windows.Forms.Padding(40, 0, 20, 0)
        Me.btnAdd.Rotation = 0R
        Me.btnAdd.Size = New System.Drawing.Size(250, 40)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Añadir Empleados"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.btnUsuarios.IconColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnUsuarios.IconSize = 32
        Me.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.Location = New System.Drawing.Point(0, 64)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnUsuarios.Rotation = 0R
        Me.btnUsuarios.Size = New System.Drawing.Size(250, 40)
        Me.btnUsuarios.TabIndex = 0
        Me.btnUsuarios.Text = "Empleados"
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(250, 64)
        Me.PanelLogo.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.INTERFAZ.My.Resources.Resources.logoItea
        Me.PictureBox1.Location = New System.Drawing.Point(56, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'PanelChildForm
        '
        Me.PanelChildForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelChildForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.PanelChildForm.Controls.Add(Me.PictureBox2)
        Me.PanelChildForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelChildForm.Location = New System.Drawing.Point(250, 64)
        Me.PanelChildForm.Name = "PanelChildForm"
        Me.PanelChildForm.Size = New System.Drawing.Size(955, 675)
        Me.PanelChildForm.TabIndex = 9
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.INTERFAZ.My.Resources.Resources.almazaras
        Me.PictureBox2.Location = New System.Drawing.Point(229, 135)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(496, 413)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PanelTittleBar
        '
        Me.PanelTittleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.PanelTittleBar.Controls.Add(Me.lblCargo)
        Me.PanelTittleBar.Controls.Add(Me.lblEmail)
        Me.PanelTittleBar.Controls.Add(Me.Label2)
        Me.PanelTittleBar.Controls.Add(Me.lblNombre)
        Me.PanelTittleBar.Controls.Add(Me.tituloFormLabel)
        Me.PanelTittleBar.Controls.Add(Me.IconCurrentFrm)
        Me.PanelTittleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTittleBar.Location = New System.Drawing.Point(250, 0)
        Me.PanelTittleBar.Name = "PanelTittleBar"
        Me.PanelTittleBar.Padding = New System.Windows.Forms.Padding(0, 0, 40, 0)
        Me.PanelTittleBar.Size = New System.Drawing.Size(951, 64)
        Me.PanelTittleBar.TabIndex = 10
        '
        'lblCargo
        '
        Me.lblCargo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargo.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblCargo.Location = New System.Drawing.Point(699, 44)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(46, 17)
        Me.lblCargo.TabIndex = 5
        Me.lblCargo.Text = "Cargo"
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblEmail.Location = New System.Drawing.Point(699, 24)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(811, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblNombre.Location = New System.Drawing.Point(699, 5)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(130, 17)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre y Apellidos"
        '
        'tituloFormLabel
        '
        Me.tituloFormLabel.AutoSize = True
        Me.tituloFormLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tituloFormLabel.ForeColor = System.Drawing.Color.Gainsboro
        Me.tituloFormLabel.Location = New System.Drawing.Point(56, 21)
        Me.tituloFormLabel.Name = "tituloFormLabel"
        Me.tituloFormLabel.Size = New System.Drawing.Size(40, 17)
        Me.tituloFormLabel.TabIndex = 1
        Me.tituloFormLabel.Text = "Inicio"
        '
        'IconCurrentFrm
        '
        Me.IconCurrentFrm.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.IconCurrentFrm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.IconCurrentFrm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentFrm.IconColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.IconCurrentFrm.Location = New System.Drawing.Point(18, 12)
        Me.IconCurrentFrm.Name = "IconCurrentFrm"
        Me.IconCurrentFrm.Size = New System.Drawing.Size(32, 32)
        Me.IconCurrentFrm.TabIndex = 0
        Me.IconCurrentFrm.TabStop = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 735)
        Me.Controls.Add(Me.PanelTittleBar)
        Me.Controls.Add(Me.PanelChildForm)
        Me.Controls.Add(Me.PanelSideMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión Itea"
        Me.PanelSideMenu.ResumeLayout(False)
        Me.PanelTrabajosSubMenu.ResumeLayout(False)
        Me.PanelUsuariosSubMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelChildForm.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTittleBar.ResumeLayout(False)
        Me.PanelTittleBar.PerformLayout()
        CType(Me.IconCurrentFrm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSideMenu As Panel
    Friend WithEvents PanelUsuariosSubMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelChildForm As Panel
    Friend WithEvents btnDel As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMod As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAdd As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUsuarios As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTittleBar As Panel
    Friend WithEvents IconCurrentFrm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents tituloFormLabel As Label
    Friend WithEvents PanelTrabajosSubMenu As Panel
    Friend WithEvents btnDelParte As FontAwesome.Sharp.IconButton
    Friend WithEvents btnModParte As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAddParte As FontAwesome.Sharp.IconButton
    Friend WithEvents btnListPartes As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnLogOut As FontAwesome.Sharp.IconButton
    Friend WithEvents lblCargo As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNombre As Label
End Class
