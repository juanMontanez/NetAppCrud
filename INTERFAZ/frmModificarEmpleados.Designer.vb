<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmModificarEmpleados
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
        Me.EntityCommand1 = New System.Data.Entity.Core.EntityClient.EntityCommand()
        Me.fechaAltaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.telefonoTextBox = New System.Windows.Forms.TextBox()
        Me.contraTextBox = New System.Windows.Forms.TextBox()
        Me.usuarioTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DatosEmpleadoPanel = New System.Windows.Forms.Panel()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nombreLoginTextBox = New System.Windows.Forms.TextBox()
        Me.contraLoginTextBox = New System.Windows.Forms.TextBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.checkPanel = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.apellidosTextBox = New System.Windows.Forms.TextBox()
        Me.nombreTextBox = New System.Windows.Forms.TextBox()
        Me.cargoTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DatosEmpleadoPanel.SuspendLayout()
        Me.checkPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'EntityCommand1
        '
        Me.EntityCommand1.CommandTimeout = 0
        Me.EntityCommand1.CommandTree = Nothing
        Me.EntityCommand1.Connection = Nothing
        Me.EntityCommand1.EnablePlanCaching = True
        Me.EntityCommand1.Transaction = Nothing
        '
        'fechaAltaDateTimePicker
        '
        Me.fechaAltaDateTimePicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaAltaDateTimePicker.Location = New System.Drawing.Point(128, 175)
        Me.fechaAltaDateTimePicker.Name = "fechaAltaDateTimePicker"
        Me.fechaAltaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.fechaAltaDateTimePicker.TabIndex = 15
        '
        'telefonoTextBox
        '
        Me.telefonoTextBox.Location = New System.Drawing.Point(128, 126)
        Me.telefonoTextBox.Name = "telefonoTextBox"
        Me.telefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.telefonoTextBox.TabIndex = 14
        '
        'contraTextBox
        '
        Me.contraTextBox.Location = New System.Drawing.Point(128, 75)
        Me.contraTextBox.Name = "contraTextBox"
        Me.contraTextBox.Size = New System.Drawing.Size(100, 20)
        Me.contraTextBox.TabIndex = 13
        '
        'usuarioTextBox
        '
        Me.usuarioTextBox.Location = New System.Drawing.Point(128, 23)
        Me.usuarioTextBox.Name = "usuarioTextBox"
        Me.usuarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.usuarioTextBox.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(22, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Fecha de alta :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(22, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Teléfono :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(22, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Contraseña :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Usuario :"
        '
        'DatosEmpleadoPanel
        '
        Me.DatosEmpleadoPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DatosEmpleadoPanel.Controls.Add(Me.cargoTextBox)
        Me.DatosEmpleadoPanel.Controls.Add(Me.Label11)
        Me.DatosEmpleadoPanel.Controls.Add(Me.Label8)
        Me.DatosEmpleadoPanel.Controls.Add(Me.Label9)
        Me.DatosEmpleadoPanel.Controls.Add(Me.emailTextBox)
        Me.DatosEmpleadoPanel.Controls.Add(Me.Label10)
        Me.DatosEmpleadoPanel.Controls.Add(Me.apellidosTextBox)
        Me.DatosEmpleadoPanel.Controls.Add(Me.nombreTextBox)
        Me.DatosEmpleadoPanel.Controls.Add(Me.btnGuardar)
        Me.DatosEmpleadoPanel.Controls.Add(Me.Label2)
        Me.DatosEmpleadoPanel.Controls.Add(Me.fechaAltaDateTimePicker)
        Me.DatosEmpleadoPanel.Controls.Add(Me.Label1)
        Me.DatosEmpleadoPanel.Controls.Add(Me.telefonoTextBox)
        Me.DatosEmpleadoPanel.Controls.Add(Me.Label3)
        Me.DatosEmpleadoPanel.Controls.Add(Me.contraTextBox)
        Me.DatosEmpleadoPanel.Controls.Add(Me.Label4)
        Me.DatosEmpleadoPanel.Controls.Add(Me.usuarioTextBox)
        Me.DatosEmpleadoPanel.Location = New System.Drawing.Point(119, 46)
        Me.DatosEmpleadoPanel.Name = "DatosEmpleadoPanel"
        Me.DatosEmpleadoPanel.Size = New System.Drawing.Size(709, 261)
        Me.DatosEmpleadoPanel.TabIndex = 16
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle
        Me.btnGuardar.IconColor = System.Drawing.Color.Lime
        Me.btnGuardar.IconSize = 32
        Me.btnGuardar.Location = New System.Drawing.Point(253, 221)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.btnGuardar.Rotation = 0R
        Me.btnGuardar.Size = New System.Drawing.Size(201, 40)
        Me.btnGuardar.TabIndex = 16
        Me.btnGuardar.Text = "Guardar Cambios"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(530, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Introduzca el nombre del usuario y contraseña del empleado que desea modificar :"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(79, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Usuario :"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(56, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Contraseña :"
        '
        'nombreLoginTextBox
        '
        Me.nombreLoginTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.nombreLoginTextBox.Location = New System.Drawing.Point(169, 33)
        Me.nombreLoginTextBox.Name = "nombreLoginTextBox"
        Me.nombreLoginTextBox.Size = New System.Drawing.Size(100, 20)
        Me.nombreLoginTextBox.TabIndex = 16
        '
        'contraLoginTextBox
        '
        Me.contraLoginTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.contraLoginTextBox.Location = New System.Drawing.Point(169, 68)
        Me.contraLoginTextBox.Name = "contraLoginTextBox"
        Me.contraLoginTextBox.Size = New System.Drawing.Size(100, 20)
        Me.contraLoginTextBox.TabIndex = 18
        '
        'IconButton1
        '
        Me.IconButton1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IconButton1.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.IconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Key
        Me.IconButton1.IconColor = System.Drawing.Color.Gold
        Me.IconButton1.IconSize = 32
        Me.IconButton1.Location = New System.Drawing.Point(115, 132)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(150, 40)
        Me.IconButton1.TabIndex = 19
        Me.IconButton1.Text = "Acceder"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'checkPanel
        '
        Me.checkPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.checkPanel.Controls.Add(Me.Label6)
        Me.checkPanel.Controls.Add(Me.IconButton1)
        Me.checkPanel.Controls.Add(Me.Label7)
        Me.checkPanel.Controls.Add(Me.contraLoginTextBox)
        Me.checkPanel.Controls.Add(Me.nombreLoginTextBox)
        Me.checkPanel.Location = New System.Drawing.Point(312, 43)
        Me.checkPanel.Name = "checkPanel"
        Me.checkPanel.Size = New System.Drawing.Size(388, 212)
        Me.checkPanel.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(410, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Apellidos :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(410, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Nombre :"
        '
        'emailTextBox
        '
        Me.emailTextBox.Location = New System.Drawing.Point(516, 128)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.Size = New System.Drawing.Size(156, 20)
        Me.emailTextBox.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label10.Location = New System.Drawing.Point(410, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 17)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Email :"
        '
        'apellidosTextBox
        '
        Me.apellidosTextBox.Location = New System.Drawing.Point(516, 77)
        Me.apellidosTextBox.Name = "apellidosTextBox"
        Me.apellidosTextBox.Size = New System.Drawing.Size(156, 20)
        Me.apellidosTextBox.TabIndex = 21
        '
        'nombreTextBox
        '
        Me.nombreTextBox.Location = New System.Drawing.Point(516, 25)
        Me.nombreTextBox.Name = "nombreTextBox"
        Me.nombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.nombreTextBox.TabIndex = 20
        '
        'cargoTextBox
        '
        Me.cargoTextBox.Location = New System.Drawing.Point(516, 177)
        Me.cargoTextBox.Name = "cargoTextBox"
        Me.cargoTextBox.Size = New System.Drawing.Size(156, 20)
        Me.cargoTextBox.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label11.Location = New System.Drawing.Point(410, 178)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 17)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Cargo :"
        '
        'frmModificarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(934, 631)
        Me.Controls.Add(Me.DatosEmpleadoPanel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.checkPanel)
        Me.Name = "frmModificarEmpleados"
        Me.Text = "Modificar Empleados"
        Me.DatosEmpleadoPanel.ResumeLayout(False)
        Me.DatosEmpleadoPanel.PerformLayout()
        Me.checkPanel.ResumeLayout(False)
        Me.checkPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EntityCommand1 As Entity.Core.EntityClient.EntityCommand
    Friend WithEvents fechaAltaDateTimePicker As DateTimePicker
    Friend WithEvents telefonoTextBox As TextBox
    Friend WithEvents contraTextBox As TextBox
    Friend WithEvents usuarioTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DatosEmpleadoPanel As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents nombreLoginTextBox As TextBox
    Friend WithEvents contraLoginTextBox As TextBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents checkPanel As Panel
    Friend WithEvents cargoTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents apellidosTextBox As TextBox
    Friend WithEvents nombreTextBox As TextBox
End Class
