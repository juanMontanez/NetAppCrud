<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEliminarEmpleado
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.usuarioComboBox = New System.Windows.Forms.ComboBox()
        Me.EmpleadosSet = New INTERFAZ.EmpleadosSet()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnEliminar = New FontAwesome.Sharp.IconButton()
        Me.EmpleadosTableAdapter = New INTERFAZ.EmpleadosSetTableAdapters.EmpleadosTableAdapter()
        Me.nombreTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.EmpleadosSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(457, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "y selecciónelo :"
        '
        'usuarioComboBox
        '
        Me.usuarioComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.usuarioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpleadosSet, "Empleados.usuario", True))
        Me.usuarioComboBox.DataSource = Me.EmpleadosBindingSource
        Me.usuarioComboBox.DisplayMember = "usuario"
        Me.usuarioComboBox.FormattingEnabled = True
        Me.usuarioComboBox.Location = New System.Drawing.Point(609, 51)
        Me.usuarioComboBox.Name = "usuarioComboBox"
        Me.usuarioComboBox.Size = New System.Drawing.Size(89, 21)
        Me.usuarioComboBox.TabIndex = 19
        Me.usuarioComboBox.ValueMember = "usuario"
        '
        'EmpleadosSet
        '
        Me.EmpleadosSet.DataSetName = "EmpleadosSet"
        Me.EmpleadosSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.EmpleadosSetBindingSource
        '
        'EmpleadosSetBindingSource
        '
        Me.EmpleadosSetBindingSource.DataSource = Me.EmpleadosSet
        Me.EmpleadosSetBindingSource.Position = 0
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.btnEliminar.IconColor = System.Drawing.Color.Red
        Me.btnEliminar.IconSize = 32
        Me.btnEliminar.Location = New System.Drawing.Point(399, 164)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnEliminar.Rotation = 0R
        Me.btnEliminar.Size = New System.Drawing.Size(121, 40)
        Me.btnEliminar.TabIndex = 20
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'nombreTextBox
        '
        Me.nombreTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.nombreTextBox.Location = New System.Drawing.Point(334, 52)
        Me.nombreTextBox.Name = "nombreTextBox"
        Me.nombreTextBox.Size = New System.Drawing.Size(94, 20)
        Me.nombreTextBox.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 25)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Busque el nombre de usuario"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.nombreTextBox)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.usuarioComboBox)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(934, 631)
        Me.Panel1.TabIndex = 23
        '
        'frmEliminarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(934, 631)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmEliminarEmpleado"
        Me.Text = "Eliminar Empleados"
        CType(Me.EmpleadosSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents usuarioComboBox As ComboBox
    Friend WithEvents EmpleadosSetBindingSource As BindingSource
    Friend WithEvents EmpleadosSet As EmpleadosSet
    Friend WithEvents btnEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As EmpleadosSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents nombreTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
End Class
