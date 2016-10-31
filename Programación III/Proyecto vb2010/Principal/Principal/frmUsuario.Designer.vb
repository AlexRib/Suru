<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuario))
        Me.gpoBusqueda = New System.Windows.Forms.GroupBox()
        Me.cboBuscar = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.btnBuscar = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cboRol = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.optBloquear = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.txtCedula = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.btnCerrar = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.gpoDatos = New System.Windows.Forms.GroupBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.txtLogin = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtApellido = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX()
        Me.btnModificar = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.btnCrear = New DevComponents.DotNetBar.ButtonX()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Login = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblListado = New System.Windows.Forms.Label()
        Me.gpoBusqueda.SuspendLayout()
        Me.gpoDatos.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpoBusqueda
        '
        Me.gpoBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.gpoBusqueda.Controls.Add(Me.cboBuscar)
        Me.gpoBusqueda.Controls.Add(Me.btnBuscar)
        Me.gpoBusqueda.Controls.Add(Me.Label1)
        Me.gpoBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpoBusqueda.Location = New System.Drawing.Point(168, 12)
        Me.gpoBusqueda.Name = "gpoBusqueda"
        Me.gpoBusqueda.Size = New System.Drawing.Size(429, 96)
        Me.gpoBusqueda.TabIndex = 17
        Me.gpoBusqueda.TabStop = False
        Me.gpoBusqueda.Text = "Búsqueda"
        '
        'cboBuscar
        '
        Me.cboBuscar.DisplayMember = "Text"
        Me.cboBuscar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBuscar.FormattingEnabled = True
        Me.cboBuscar.ItemHeight = 15
        Me.cboBuscar.Items.AddRange(New Object() {Me.ComboItem5, Me.ComboItem6, Me.ComboItem7, Me.ComboItem8})
        Me.cboBuscar.Location = New System.Drawing.Point(142, 40)
        Me.cboBuscar.Name = "cboBuscar"
        Me.cboBuscar.Size = New System.Drawing.Size(117, 21)
        Me.cboBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboBuscar.TabIndex = 137
        Me.cboBuscar.WatermarkText = "Ingrese"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "Administrador"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "Gerente"
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "Establecimiento"
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "Auxiliar"
        '
        'btnBuscar
        '
        Me.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btnBuscar.Location = New System.Drawing.Point(303, 36)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(87, 27)
        Me.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBuscar.TabIndex = 123
        Me.btnBuscar.Text = "Buscar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Usuario:"
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRol.Location = New System.Drawing.Point(335, 96)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(39, 20)
        Me.lblRol.TabIndex = 18
        Me.lblRol.Text = "Rol:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(38, 98)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(73, 20)
        Me.lblNombre.TabIndex = 21
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        '
        '
        '
        Me.txtNombre.Border.Class = "TextBoxBorder"
        Me.txtNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(159, 97)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(117, 21)
        Me.txtNombre.TabIndex = 119
        '
        'cboRol
        '
        Me.cboRol.DisplayMember = "Text"
        Me.cboRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRol.FormattingEnabled = True
        Me.cboRol.ItemHeight = 15
        Me.cboRol.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4})
        Me.cboRol.Location = New System.Drawing.Point(454, 97)
        Me.cboRol.Name = "cboRol"
        Me.cboRol.Size = New System.Drawing.Size(117, 21)
        Me.cboRol.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboRol.TabIndex = 121
        Me.cboRol.WatermarkText = "Ingrese"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Administrador"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Gerente"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Establecimiento"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Auxiliar"
        '
        'optBloquear
        '
        '
        '
        '
        Me.optBloquear.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.optBloquear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optBloquear.Location = New System.Drawing.Point(350, 152)
        Me.optBloquear.Name = "optBloquear"
        Me.optBloquear.Size = New System.Drawing.Size(288, 27)
        Me.optBloquear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.optBloquear.TabIndex = 123
        Me.optBloquear.Text = "Bloquear este usuario"
        '
        'txtCedula
        '
        '
        '
        '
        Me.txtCedula.Border.Class = "TextBoxBorder"
        Me.txtCedula.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(454, 47)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(117, 21)
        Me.txtCedula.TabIndex = 125
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(335, 47)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(66, 20)
        Me.lblCedula.TabIndex = 124
        Me.lblCedula.Text = "Cédula:"
        '
        'btnCerrar
        '
        '
        '
        '
        Me.btnCerrar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btnCerrar.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(1316, -6)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(34, 52)
        Me.btnCerrar.TabIndex = 128
        '
        'gpoDatos
        '
        Me.gpoDatos.BackColor = System.Drawing.Color.Transparent
        Me.gpoDatos.Controls.Add(Me.lblLogin)
        Me.gpoDatos.Controls.Add(Me.txtLogin)
        Me.gpoDatos.Controls.Add(Me.lblApellido)
        Me.gpoDatos.Controls.Add(Me.txtApellido)
        Me.gpoDatos.Controls.Add(Me.lblNombre)
        Me.gpoDatos.Controls.Add(Me.lblRol)
        Me.gpoDatos.Controls.Add(Me.txtCedula)
        Me.gpoDatos.Controls.Add(Me.txtNombre)
        Me.gpoDatos.Controls.Add(Me.lblCedula)
        Me.gpoDatos.Controls.Add(Me.cboRol)
        Me.gpoDatos.Controls.Add(Me.optBloquear)
        Me.gpoDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpoDatos.Location = New System.Drawing.Point(26, 161)
        Me.gpoDatos.Name = "gpoDatos"
        Me.gpoDatos.Size = New System.Drawing.Size(728, 243)
        Me.gpoDatos.TabIndex = 131
        Me.gpoDatos.TabStop = False
        Me.gpoDatos.Text = "Datos"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(38, 48)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(55, 20)
        Me.lblLogin.TabIndex = 135
        Me.lblLogin.Text = "Login:"
        '
        'txtLogin
        '
        '
        '
        '
        Me.txtLogin.Border.Class = "TextBoxBorder"
        Me.txtLogin.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogin.Location = New System.Drawing.Point(159, 48)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(117, 21)
        Me.txtLogin.TabIndex = 136
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(38, 153)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(73, 20)
        Me.lblApellido.TabIndex = 133
        Me.lblApellido.Text = "Apellido:"
        '
        'txtApellido
        '
        '
        '
        '
        Me.txtApellido.Border.Class = "TextBoxBorder"
        Me.txtApellido.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(159, 152)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(117, 21)
        Me.txtApellido.TabIndex = 134
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminar.BackColor = System.Drawing.Color.Firebrick
        Me.btnEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Location = New System.Drawing.Point(404, 436)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(140, 27)
        Me.btnEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEliminar.TabIndex = 138
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextColor = System.Drawing.Color.White
        '
        'btnModificar
        '
        Me.btnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModificar.BackColor = System.Drawing.Color.Green
        Me.btnModificar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Location = New System.Drawing.Point(241, 436)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(140, 27)
        Me.btnModificar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnModificar.TabIndex = 137
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextColor = System.Drawing.Color.White
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancelar.BackColor = System.Drawing.Color.Gold
        Me.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Location = New System.Drawing.Point(569, 436)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(140, 27)
        Me.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancelar.TabIndex = 132
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextColor = System.Drawing.Color.White
        '
        'btnCrear
        '
        Me.btnCrear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCrear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCrear.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCrear.Location = New System.Drawing.Point(77, 436)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(140, 27)
        Me.btnCrear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCrear.TabIndex = 131
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.TextColor = System.Drawing.Color.White
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Cedula, Me.Login, Me.Nombre, Me.Apellido, Me.Rol})
        Me.DataGridView1.GridColor = System.Drawing.Color.Black
        Me.DataGridView1.Location = New System.Drawing.Point(816, 75)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DataGridView1.Size = New System.Drawing.Size(534, 224)
        Me.DataGridView1.TabIndex = 140
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Width = 50
        '
        'Cedula
        '
        Me.Cedula.HeaderText = "Cedula"
        Me.Cedula.Name = "Cedula"
        Me.Cedula.Width = 80
        '
        'Login
        '
        Me.Login.HeaderText = "Login"
        Me.Login.Name = "Login"
        Me.Login.Width = 90
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 90
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Width = 90
        '
        'Rol
        '
        Me.Rol.HeaderText = "Rol"
        Me.Rol.Name = "Rol"
        Me.Rol.Width = 90
        '
        'lblListado
        '
        Me.lblListado.AutoSize = True
        Me.lblListado.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListado.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblListado.Location = New System.Drawing.Point(1037, 31)
        Me.lblListado.Name = "lblListado"
        Me.lblListado.Size = New System.Drawing.Size(72, 22)
        Me.lblListado.TabIndex = 141
        Me.lblListado.Text = "Listado"
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1362, 494)
        Me.Controls.Add(Me.lblListado)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.gpoDatos)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.gpoBusqueda)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.btnCancelar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Usuarios "
        Me.gpoBusqueda.ResumeLayout(False)
        Me.gpoBusqueda.PerformLayout()
        Me.gpoDatos.ResumeLayout(False)
        Me.gpoDatos.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gpoBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblRol As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cboRol As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents optBloquear As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents txtCedula As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents gpoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCrear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents txtLogin As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents txtApellido As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cboBuscar As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents btnBuscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Login As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblListado As System.Windows.Forms.Label
End Class
