Imports FontAwesome.Sharp
Imports COMUN
Public Class frmPrincipal

    'Variables globales de esta clase
    Private btnActual As IconButton
    Private bordeIzquierdoBtn As Panel
    Private currentForm As Form = Nothing

    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        bordeIzquierdoBtn = New Panel
        bordeIzquierdoBtn.Size = New Size(7, 40)
        'Añadimos los controles borde izquierdo del botón al panel lateral
        PanelSideMenu.Controls.Add(bordeIzquierdoBtn)
        PictureBox2.Left = (Me.PanelChildForm.Width - PictureBox2.Width) / 2
        PictureBox2.Top = (Me.PanelChildForm.Height - PictureBox2.Height) / 2
    End Sub

    'Metodo para resaltar el botón activo
    Private Sub ActiveButton(senderBtn As Object, customColor As Color)
        'Creamos una comprobación para verificar que el botón no este nulo
        If senderBtn IsNot Nothing Then
            DisableButton()
            '
            'Comenzamos a personalizar el botón
            '
            'Asignamos el botón remitente a botón actual convirtiendo el objeto al mismo tipo de botón
            btnActual = CType(senderBtn, IconButton)
            'Cambiamos el color de fondo del botón
            btnActual.BackColor = Color.FromArgb(240, 127, 19)
            'Cambiamos el color de texto a parametro color
            btnActual.ForeColor = Color.Gainsboro
            'Cambiamos el color del icono a parametro color
            btnActual.IconColor = customColor
            'Alineamos el texto hacia el centro
            'btnActual.TextAlign = ContentAlignment.MiddleCenter
            'Alineamos el icono hacia la derecha
            'btnActual.ImageAlign = ContentAlignment.MiddleRight
            'Cambiamos la alineación del texto sobre la imagen
            'btnActual.TextImageRelation = TextImageRelation.TextBeforeImage
            '
            'Borde izquierdo del botón
            '
            'Asignamos el color de fondo
            bordeIzquierdoBtn.BackColor = customColor
            'Asignamos la posición
            bordeIzquierdoBtn.Location = New Point(0, btnActual.Location.Y)
            'Activamos la visibilidad a verdadero
            bordeIzquierdoBtn.Visible = True
            'Lo Traemos al frente
            bordeIzquierdoBtn.BringToFront()
            '
            'Cambiamos el icono de la barra de titulo al icono del formulario activo o botón activo
            '
            IconCurrentFrm.IconChar = btnActual.IconChar
            'Asignamos el color personalizado actual
            IconCurrentFrm.IconColor = customColor

        End If
    End Sub
    'Metodo para quitar el resaltado del boton
    Private Sub DisableButton()
        'Cómprobamos si el boton actual no está vacio
        If btnActual IsNot Nothing Then
            'Colocamos los valores por defecto
            btnActual.BackColor = Color.FromArgb(11, 7, 37)
            'Cambiamos el color de texto
            btnActual.ForeColor = Color.Gainsboro
            'Cambiamos el color del icono
            btnActual.IconColor = Color.RoyalBlue
            'Alineamos el texto hacia la izquierda
            btnActual.TextAlign = ContentAlignment.MiddleLeft
            'Alineamos el icono hacia la derecha
            btnActual.ImageAlign = ContentAlignment.MiddleLeft
            'Cambiamos la alineación del texto sobre la imagen
            btnActual.TextImageRelation = TextImageRelation.ImageBeforeText

        End If

    End Sub


    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubMenu()
        lblNombre.Text = ActiveUser.nombre.trim + ", " + ActiveUser.apellidos.trim
        lblEmail.Text = ActiveUser.email.trim
        lblCargo.Text = ActiveUser.cargo.trim
    End Sub

    Private Sub hideSubMenu()
        PanelUsuariosSubMenu.Visible = False
        PanelTrabajosSubMenu.Visible = False
    End Sub

    Private Sub showSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Public Sub openChildForm(childForm As Form)
        'Si existe un formulario abierto lo cerramos
        If currentForm IsNot Nothing Then currentForm.Close()
        'Guardamos el formulario que se abre en la variable formulario actual(currentForm)
        currentForm = childForm
        'Le indicamos que el formulario no es de nivel superior por lo que se portara igual que un control
        childForm.TopLevel = False
        'Quitamos el borde de un formulario
        childForm.FormBorderStyle = FormBorderStyle.None
        'Establecemos la propiedad dock a fill para que ocupe todo el ancho del contenedor
        childForm.Dock = DockStyle.Fill
        'Agregamos el formulario a la lista de controles del panel contenedor
        PanelChildForm.Controls.Add(childForm)
        'Asociamos el formulario con el panel contenedor
        PanelChildForm.Tag = childForm
        'Traemos el formulario hacia el frente
        childForm.BringToFront()
        'Mostramos el formulario hijo
        childForm.Show()
        'Establecemos la etiqueta de la barra de menu al titulo que tenga el formulario
        tituloFormLabel.Text = childForm.Text
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'Comprobamos si el formulario actual no está vacio lo cerramos
        If currentForm IsNot Nothing Then
            currentForm.Close()
        End If
        Reset()
    End Sub
    'Establecemos los valores por defecto
    Private Sub Reset()
        DisableButton()
        bordeIzquierdoBtn.Visible = False
        IconCurrentFrm.IconChar = IconChar.Home
        IconCurrentFrm.IconColor = Color.RoyalBlue
        tituloFormLabel.Text = "Inicio"
        hideSubMenu()
    End Sub

    Private Sub btnListPartes_Click(sender As Object, e As EventArgs) Handles btnListPartes.Click
        Dim frmListaPartes As New frmListaPartes
        ActiveButton(sender, Color.FromArgb(100, 100, 100))
        showSubMenu(PanelTrabajosSubMenu)
        openChildForm(frmListaPartes)
    End Sub

    Private Sub btnUsuarios_Click_1(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        Dim frmListaEmpleados As New frmListaEmpleados
        ActiveButton(sender, Color.FromArgb(100, 100, 100))
        showSubMenu(PanelUsuariosSubMenu)
        openChildForm(frmListaEmpleados)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim frmAddEmpleados As New frmAddEmpleados
        openChildForm(frmAddEmpleados)
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Dim frmModificarEmpleados As New frmModificarEmpleados
        openChildForm(frmModificarEmpleados)
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        If MessageBox.Show("¿Estás seguro de que desea cerrar sesión?", "Atención",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
            frmLogin.Show()
        End If

    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim frmEliminarEmpleados As New frmEliminarEmpleado
        openChildForm(frmEliminarEmpleados)
    End Sub
End Class