<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEmpleados
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.usuarioTextBox = New System.Windows.Forms.TextBox()
        Me.contraTextBox = New System.Windows.Forms.TextBox()
        Me.telefonoTextBox = New System.Windows.Forms.TextBox()
        Me.fechaAltaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EntityCommand1 = New System.Data.Entity.Core.EntityClient.EntityCommand()
        Me.btnGuardar = New FontAwesome.Sharp.IconButton()
        Me.cargoTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.apellidosTextBox = New System.Windows.Forms.TextBox()
        Me.nombreTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(12, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Teléfono :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(12, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha de alta :"
        '
        'usuarioTextBox
        '
        Me.usuarioTextBox.Location = New System.Drawing.Point(118, 20)
        Me.usuarioTextBox.Name = "usuarioTextBox"
        Me.usuarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.usuarioTextBox.TabIndex = 4
        '
        'contraTextBox
        '
        Me.contraTextBox.Location = New System.Drawing.Point(118, 72)
        Me.contraTextBox.Name = "contraTextBox"
        Me.contraTextBox.Size = New System.Drawing.Size(100, 20)
        Me.contraTextBox.TabIndex = 5
        '
        'telefonoTextBox
        '
        Me.telefonoTextBox.Location = New System.Drawing.Point(118, 123)
        Me.telefonoTextBox.Name = "telefonoTextBox"
        Me.telefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.telefonoTextBox.TabIndex = 6
        '
        'fechaAltaDateTimePicker
        '
        Me.fechaAltaDateTimePicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaAltaDateTimePicker.Location = New System.Drawing.Point(118, 172)
        Me.fechaAltaDateTimePicker.Name = "fechaAltaDateTimePicker"
        Me.fechaAltaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.fechaAltaDateTimePicker.TabIndex = 7
        '
        'EntityCommand1
        '
        Me.EntityCommand1.CommandTimeout = 0
        Me.EntityCommand1.CommandTree = Nothing
        Me.EntityCommand1.Connection = Nothing
        Me.EntityCommand1.EnablePlanCaching = True
        Me.EntityCommand1.Transaction = Nothing
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
        Me.btnGuardar.Location = New System.Drawing.Point(400, 403)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnGuardar.Rotation = 0R
        Me.btnGuardar.Size = New System.Drawing.Size(150, 40)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'cargoTextBox
        '
        Me.cargoTextBox.Location = New System.Drawing.Point(543, 171)
        Me.cargoTextBox.Name = "cargoTextBox"
        Me.cargoTextBox.Size = New System.Drawing.Size(156, 20)
        Me.cargoTextBox.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label11.Location = New System.Drawing.Point(437, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 17)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Cargo :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(437, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 17)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Apellidos :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(437, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 17)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Nombre :"
        '
        'emailTextBox
        '
        Me.emailTextBox.Location = New System.Drawing.Point(543, 122)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.Size = New System.Drawing.Size(156, 20)
        Me.emailTextBox.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label10.Location = New System.Drawing.Point(437, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 17)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Email :"
        '
        'apellidosTextBox
        '
        Me.apellidosTextBox.Location = New System.Drawing.Point(543, 71)
        Me.apellidosTextBox.Name = "apellidosTextBox"
        Me.apellidosTextBox.Size = New System.Drawing.Size(156, 20)
        Me.apellidosTextBox.TabIndex = 29
        '
        'nombreTextBox
        '
        Me.nombreTextBox.Location = New System.Drawing.Point(543, 19)
        Me.nombreTextBox.Name = "nombreTextBox"
        Me.nombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.nombreTextBox.TabIndex = 28
        '
        'frmAddEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(934, 631)
        Me.Controls.Add(Me.cargoTextBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.emailTextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.apellidosTextBox)
        Me.Controls.Add(Me.nombreTextBox)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.fechaAltaDateTimePicker)
        Me.Controls.Add(Me.telefonoTextBox)
        Me.Controls.Add(Me.contraTextBox)
        Me.Controls.Add(Me.usuarioTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAddEmpleados"
        Me.Text = "Añadir Empleados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents usuarioTextBox As TextBox
    Friend WithEvents contraTextBox As TextBox
    Friend WithEvents telefonoTextBox As TextBox
    Friend WithEvents fechaAltaDateTimePicker As DateTimePicker
    Friend WithEvents btnGuardar As FontAwesome.Sharp.IconButton
    Friend WithEvents EntityCommand1 As Entity.Core.EntityClient.EntityCommand
    Friend WithEvents cargoTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents apellidosTextBox As TextBox
    Friend WithEvents nombreTextBox As TextBox
End Class
