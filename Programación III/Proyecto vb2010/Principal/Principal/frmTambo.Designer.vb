<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTambo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTambo))
        Me.gpoDatos = New System.Windows.Forms.GroupBox()
        Me.lblCel = New System.Windows.Forms.Label()
        Me.txtCel = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.txtTel = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblNro = New System.Windows.Forms.Label()
        Me.txtNro = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.txtCalle = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblSector = New System.Windows.Forms.Label()
        Me.cboSector = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.gpoBusqueda = New System.Windows.Forms.GroupBox()
        Me.cboBuscar = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.btnBuscar = New DevComponents.DotNetBar.ButtonX()
        Me.lblTambo = New System.Windows.Forms.Label()
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX()
        Me.btnModificar = New DevComponents.DotNetBar.ButtonX()
        Me.btnCrear = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Login = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblListado = New System.Windows.Forms.Label()
        Me.btnCerrar = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.gpoDatos.SuspendLayout()
        Me.gpoBusqueda.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpoDatos
        '
        Me.gpoDatos.BackColor = System.Drawing.Color.Transparent
        Me.gpoDatos.Controls.Add(Me.lblCel)
        Me.gpoDatos.Controls.Add(Me.txtCel)
        Me.gpoDatos.Controls.Add(Me.lblTel)
        Me.gpoDatos.Controls.Add(Me.txtTel)
        Me.gpoDatos.Controls.Add(Me.lblNombre)
        Me.gpoDatos.Controls.Add(Me.txtNombre)
        Me.gpoDatos.Controls.Add(Me.lblNro)
        Me.gpoDatos.Controls.Add(Me.txtNro)
        Me.gpoDatos.Controls.Add(Me.lblCalle)
        Me.gpoDatos.Controls.Add(Me.txtCalle)
        Me.gpoDatos.Controls.Add(Me.lblSector)
        Me.gpoDatos.Controls.Add(Me.cboSector)
        Me.gpoDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpoDatos.ForeColor = System.Drawing.Color.White
        Me.gpoDatos.Location = New System.Drawing.Point(49, 192)
        Me.gpoDatos.Name = "gpoDatos"
        Me.gpoDatos.Size = New System.Drawing.Size(610, 225)
        Me.gpoDatos.TabIndex = 133
        Me.gpoDatos.TabStop = False
        Me.gpoDatos.Text = "Datos"
        '
        'lblCel
        '
        Me.lblCel.AutoSize = True
        Me.lblCel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCel.ForeColor = System.Drawing.Color.White
        Me.lblCel.Location = New System.Drawing.Point(349, 157)
        Me.lblCel.Name = "lblCel"
        Me.lblCel.Size = New System.Drawing.Size(43, 20)
        Me.lblCel.TabIndex = 139
        Me.lblCel.Text = "Cel.:"
        '
        'txtCel
        '
        '
        '
        '
        Me.txtCel.Border.Class = "TextBoxBorder"
        Me.txtCel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCel.Location = New System.Drawing.Point(470, 158)
        Me.txtCel.Name = "txtCel"
        Me.txtCel.Size = New System.Drawing.Size(117, 21)
        Me.txtCel.TabIndex = 140
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel.ForeColor = System.Drawing.Color.White
        Me.lblTel.Location = New System.Drawing.Point(42, 158)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(78, 20)
        Me.lblTel.TabIndex = 137
        Me.lblTel.Text = "Teléfono:"
        '
        'txtTel
        '
        '
        '
        '
        Me.txtTel.Border.Class = "TextBoxBorder"
        Me.txtTel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Location = New System.Drawing.Point(159, 158)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(117, 21)
        Me.txtTel.TabIndex = 138
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(42, 48)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(73, 20)
        Me.lblNombre.TabIndex = 135
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
        Me.txtNombre.Location = New System.Drawing.Point(159, 48)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(117, 21)
        Me.txtNombre.TabIndex = 136
        '
        'lblNro
        '
        Me.lblNro.AutoSize = True
        Me.lblNro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNro.ForeColor = System.Drawing.Color.White
        Me.lblNro.Location = New System.Drawing.Point(349, 104)
        Me.lblNro.Name = "lblNro"
        Me.lblNro.Size = New System.Drawing.Size(41, 20)
        Me.lblNro.TabIndex = 133
        Me.lblNro.Text = "Nro:"
        '
        'txtNro
        '
        '
        '
        '
        Me.txtNro.Border.Class = "TextBoxBorder"
        Me.txtNro.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNro.Location = New System.Drawing.Point(470, 103)
        Me.txtNro.Name = "txtNro"
        Me.txtNro.Size = New System.Drawing.Size(117, 21)
        Me.txtNro.TabIndex = 134
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalle.ForeColor = System.Drawing.Color.White
        Me.lblCalle.Location = New System.Drawing.Point(349, 49)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(52, 20)
        Me.lblCalle.TabIndex = 21
        Me.lblCalle.Text = "Calle:"
        '
        'txtCalle
        '
        '
        '
        '
        Me.txtCalle.Border.Class = "TextBoxBorder"
        Me.txtCalle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalle.Location = New System.Drawing.Point(470, 48)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(117, 21)
        Me.txtCalle.TabIndex = 119
        '
        'lblSector
        '
        Me.lblSector.AutoSize = True
        Me.lblSector.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSector.ForeColor = System.Drawing.Color.White
        Me.lblSector.Location = New System.Drawing.Point(42, 102)
        Me.lblSector.Name = "lblSector"
        Me.lblSector.Size = New System.Drawing.Size(63, 20)
        Me.lblSector.TabIndex = 124
        Me.lblSector.Text = "Sector:"
        '
        'cboSector
        '
        Me.cboSector.DisplayMember = "Text"
        Me.cboSector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboSector.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSector.FormattingEnabled = True
        Me.cboSector.ItemHeight = 15
        Me.cboSector.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4})
        Me.cboSector.Location = New System.Drawing.Point(161, 103)
        Me.cboSector.Name = "cboSector"
        Me.cboSector.Size = New System.Drawing.Size(115, 21)
        Me.cboSector.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboSector.TabIndex = 121
        Me.cboSector.WatermarkText = "Ingrese"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Sector A"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Sector B"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Sector C"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Sector D"
        '
        'gpoBusqueda
        '
        Me.gpoBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.gpoBusqueda.Controls.Add(Me.cboBuscar)
        Me.gpoBusqueda.Controls.Add(Me.btnBuscar)
        Me.gpoBusqueda.Controls.Add(Me.lblTambo)
        Me.gpoBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpoBusqueda.ForeColor = System.Drawing.Color.White
        Me.gpoBusqueda.Location = New System.Drawing.Point(191, 43)
        Me.gpoBusqueda.Name = "gpoBusqueda"
        Me.gpoBusqueda.Size = New System.Drawing.Size(429, 96)
        Me.gpoBusqueda.TabIndex = 132
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
        'lblTambo
        '
        Me.lblTambo.AutoSize = True
        Me.lblTambo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTambo.ForeColor = System.Drawing.Color.White
        Me.lblTambo.Location = New System.Drawing.Point(23, 40)
        Me.lblTambo.Name = "lblTambo"
        Me.lblTambo.Size = New System.Drawing.Size(65, 20)
        Me.lblTambo.TabIndex = 12
        Me.lblTambo.Text = "Tambo:"
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminar.BackColor = System.Drawing.Color.Firebrick
        Me.btnEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Location = New System.Drawing.Point(402, 439)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(140, 27)
        Me.btnEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEliminar.TabIndex = 142
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextColor = System.Drawing.Color.White
        '
        'btnModificar
        '
        Me.btnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModificar.BackColor = System.Drawing.Color.Green
        Me.btnModificar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Location = New System.Drawing.Point(239, 439)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(140, 27)
        Me.btnModificar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnModificar.TabIndex = 141
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextColor = System.Drawing.Color.White
        '
        'btnCrear
        '
        Me.btnCrear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCrear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCrear.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCrear.Location = New System.Drawing.Point(75, 439)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(140, 27)
        Me.btnCrear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCrear.TabIndex = 139
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.TextColor = System.Drawing.Color.White
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancelar.BackColor = System.Drawing.Color.Gold
        Me.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Location = New System.Drawing.Point(567, 439)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(140, 27)
        Me.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancelar.TabIndex = 140
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextColor = System.Drawing.Color.White
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Cedula, Me.Login, Me.Nombre, Me.Apellido, Me.Rol})
        Me.DataGridView1.GridColor = System.Drawing.Color.Black
        Me.DataGridView1.Location = New System.Drawing.Point(718, 124)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DataGridView1.Size = New System.Drawing.Size(534, 224)
        Me.DataGridView1.TabIndex = 143
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
        Me.lblListado.BackColor = System.Drawing.Color.Transparent
        Me.lblListado.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListado.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblListado.Location = New System.Drawing.Point(983, 84)
        Me.lblListado.Name = "lblListado"
        Me.lblListado.Size = New System.Drawing.Size(72, 22)
        Me.lblListado.TabIndex = 144
        Me.lblListado.Text = "Listado"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.btnCerrar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btnCerrar.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(1330, -2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(34, 52)
        Me.btnCerrar.TabIndex = 145
        '
        'frmTambo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1365, 493)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.lblListado)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.gpoDatos)
        Me.Controls.Add(Me.gpoBusqueda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTambo"
        Me.Text = "frmTambo"
        Me.gpoDatos.ResumeLayout(False)
        Me.gpoDatos.PerformLayout()
        Me.gpoBusqueda.ResumeLayout(False)
        Me.gpoBusqueda.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gpoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblNro As System.Windows.Forms.Label
    Friend WithEvents txtNro As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblCalle As System.Windows.Forms.Label
    Friend WithEvents txtCalle As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblSector As System.Windows.Forms.Label
    Friend WithEvents cboSector As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents gpoBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents cboBuscar As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents btnBuscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblTambo As System.Windows.Forms.Label
    Friend WithEvents lblCel As System.Windows.Forms.Label
    Friend WithEvents txtCel As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents txtTel As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCrear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Login As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblListado As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As DevComponents.DotNetBar.Controls.ReflectionImage
End Class
