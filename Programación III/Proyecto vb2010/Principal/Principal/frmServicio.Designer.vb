<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServicio))
        Me.cboVaca = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblVaca = New System.Windows.Forms.Label()
        Me.cboToro = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblToro = New System.Windows.Forms.Label()
        Me.cboTipo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.cboProceso = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.lblProceso = New System.Windows.Forms.Label()
        Me.lblEntore = New System.Windows.Forms.Label()
        Me.dateEntore = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.gpoBusqueda = New System.Windows.Forms.GroupBox()
        Me.cboServicio = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btnBuscar = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.btnCrear = New DevComponents.DotNetBar.ButtonX()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Login = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SwitchButton1 = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCerrar = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.gpoDatos = New System.Windows.Forms.GroupBox()
        CType(Me.dateEntore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoBusqueda.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboVaca
        '
        Me.cboVaca.DisplayMember = "Text"
        Me.cboVaca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboVaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVaca.FormattingEnabled = True
        Me.cboVaca.ItemHeight = 20
        Me.cboVaca.Location = New System.Drawing.Point(118, 50)
        Me.cboVaca.Name = "cboVaca"
        Me.cboVaca.Size = New System.Drawing.Size(117, 26)
        Me.cboVaca.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboVaca.TabIndex = 175
        Me.cboVaca.WatermarkText = "Seleccione"
        '
        'lblVaca
        '
        Me.lblVaca.AutoSize = True
        Me.lblVaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVaca.Location = New System.Drawing.Point(39, 50)
        Me.lblVaca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVaca.Name = "lblVaca"
        Me.lblVaca.Size = New System.Drawing.Size(50, 20)
        Me.lblVaca.TabIndex = 174
        Me.lblVaca.Text = "Vaca:"
        '
        'cboToro
        '
        Me.cboToro.DisplayMember = "Text"
        Me.cboToro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboToro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboToro.FormattingEnabled = True
        Me.cboToro.ItemHeight = 20
        Me.cboToro.Location = New System.Drawing.Point(118, 97)
        Me.cboToro.Name = "cboToro"
        Me.cboToro.Size = New System.Drawing.Size(117, 26)
        Me.cboToro.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboToro.TabIndex = 177
        Me.cboToro.WatermarkText = "Seleccione"
        '
        'lblToro
        '
        Me.lblToro.AutoSize = True
        Me.lblToro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToro.Location = New System.Drawing.Point(39, 103)
        Me.lblToro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblToro.Name = "lblToro"
        Me.lblToro.Size = New System.Drawing.Size(45, 20)
        Me.lblToro.TabIndex = 176
        Me.lblToro.Text = "Toro:"
        '
        'cboTipo
        '
        Me.cboTipo.DisplayMember = "Text"
        Me.cboTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.ItemHeight = 20
        Me.cboTipo.Items.AddRange(New Object() {Me.ComboItem3, Me.ComboItem4})
        Me.cboTipo.Location = New System.Drawing.Point(282, 155)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(117, 26)
        Me.cboTipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboTipo.TabIndex = 179
        Me.cboTipo.WatermarkText = "Seleccione"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Natural"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Artificial"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(204, 161)
        Me.lblTipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(43, 20)
        Me.lblTipo.TabIndex = 178
        Me.lblTipo.Text = "Tipo:"
        '
        'cboProceso
        '
        Me.cboProceso.DisplayMember = "Text"
        Me.cboProceso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProceso.FormattingEnabled = True
        Me.cboProceso.ItemHeight = 20
        Me.cboProceso.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2})
        Me.cboProceso.Location = New System.Drawing.Point(384, 50)
        Me.cboProceso.Name = "cboProceso"
        Me.cboProceso.Size = New System.Drawing.Size(117, 26)
        Me.cboProceso.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboProceso.TabIndex = 181
        Me.cboProceso.WatermarkText = "Seleccione"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Continuo"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Estacionado"
        '
        'lblProceso
        '
        Me.lblProceso.AutoSize = True
        Me.lblProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProceso.Location = New System.Drawing.Point(287, 50)
        Me.lblProceso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProceso.Name = "lblProceso"
        Me.lblProceso.Size = New System.Drawing.Size(71, 20)
        Me.lblProceso.TabIndex = 180
        Me.lblProceso.Text = "Proceso:"
        '
        'lblEntore
        '
        Me.lblEntore.AutoSize = True
        Me.lblEntore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntore.Location = New System.Drawing.Point(287, 103)
        Me.lblEntore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEntore.Name = "lblEntore"
        Me.lblEntore.Size = New System.Drawing.Size(58, 20)
        Me.lblEntore.TabIndex = 182
        Me.lblEntore.Text = "Fecha:"
        '
        'dateEntore
        '
        '
        '
        '
        Me.dateEntore.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dateEntore.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateEntore.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dateEntore.ButtonDropDown.Visible = True
        Me.dateEntore.IsPopupCalendarOpen = False
        Me.dateEntore.Location = New System.Drawing.Point(384, 109)
        Me.dateEntore.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        '
        '
        '
        Me.dateEntore.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dateEntore.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateEntore.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dateEntore.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dateEntore.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dateEntore.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dateEntore.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dateEntore.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dateEntore.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dateEntore.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dateEntore.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateEntore.MonthCalendar.DisplayMonth = New Date(2016, 7, 1, 0, 0, 0, 0)
        Me.dateEntore.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dateEntore.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dateEntore.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dateEntore.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dateEntore.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dateEntore.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dateEntore.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateEntore.MonthCalendar.TodayButtonVisible = True
        Me.dateEntore.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dateEntore.Name = "dateEntore"
        Me.dateEntore.Size = New System.Drawing.Size(117, 20)
        Me.dateEntore.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dateEntore.TabIndex = 183
        '
        'gpoBusqueda
        '
        Me.gpoBusqueda.Controls.Add(Me.cboServicio)
        Me.gpoBusqueda.Controls.Add(Me.btnBuscar)
        Me.gpoBusqueda.Controls.Add(Me.Label1)
        Me.gpoBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpoBusqueda.Location = New System.Drawing.Point(65, 31)
        Me.gpoBusqueda.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpoBusqueda.Name = "gpoBusqueda"
        Me.gpoBusqueda.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpoBusqueda.Size = New System.Drawing.Size(439, 78)
        Me.gpoBusqueda.TabIndex = 184
        Me.gpoBusqueda.TabStop = False
        Me.gpoBusqueda.Text = "Búsqueda"
        '
        'cboServicio
        '
        Me.cboServicio.DisplayMember = "Text"
        Me.cboServicio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboServicio.FormattingEnabled = True
        Me.cboServicio.ItemHeight = 20
        Me.cboServicio.Location = New System.Drawing.Point(154, 38)
        Me.cboServicio.Name = "cboServicio"
        Me.cboServicio.Size = New System.Drawing.Size(117, 26)
        Me.cboServicio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboServicio.TabIndex = 172
        Me.cboServicio.WatermarkText = "Seleccione"
        '
        'btnBuscar
        '
        Me.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(307, 29)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(112, 35)
        Me.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBuscar.TabIndex = 122
        Me.btnBuscar.Text = "Buscar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "N° Servicio:"
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancelar.BackColor = System.Drawing.Color.Gold
        Me.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Location = New System.Drawing.Point(331, 212)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(140, 27)
        Me.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancelar.TabIndex = 186
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextColor = System.Drawing.Color.White
        '
        'btnCrear
        '
        Me.btnCrear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCrear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCrear.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCrear.Location = New System.Drawing.Point(118, 212)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(140, 27)
        Me.btnCrear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCrear.TabIndex = 185
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
        Me.DataGridView1.Location = New System.Drawing.Point(613, 95)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DataGridView1.Size = New System.Drawing.Size(365, 224)
        Me.DataGridView1.TabIndex = 188
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
        'SwitchButton1
        '
        '
        '
        '
        Me.SwitchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SwitchButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SwitchButton1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SwitchButton1.Location = New System.Drawing.Point(694, 43)
        Me.SwitchButton1.Name = "SwitchButton1"
        Me.SwitchButton1.OffBackColor = System.Drawing.Color.SteelBlue
        Me.SwitchButton1.OffText = "Historial"
        Me.SwitchButton1.OffTextColor = System.Drawing.Color.White
        Me.SwitchButton1.OnBackColor = System.Drawing.Color.LimeGreen
        Me.SwitchButton1.OnText = "Servicios activos"
        Me.SwitchButton1.OnTextColor = System.Drawing.Color.White
        Me.SwitchButton1.Size = New System.Drawing.Size(199, 33)
        Me.SwitchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SwitchButton1.TabIndex = 197
        Me.SwitchButton1.Value = True
        Me.SwitchButton1.ValueObject = "Y"
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DataGridView2.GridColor = System.Drawing.Color.Black
        Me.DataGridView2.Location = New System.Drawing.Point(613, 95)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DataGridView2.Size = New System.Drawing.Size(365, 224)
        Me.DataGridView2.TabIndex = 198
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cedula"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Login"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 90
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 90
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Apellido"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 90
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Rol"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 90
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
        Me.btnCerrar.Location = New System.Drawing.Point(1346, 1)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(29, 45)
        Me.btnCerrar.TabIndex = 187
        '
        'gpoDatos
        '
        Me.gpoDatos.Controls.Add(Me.cboVaca)
        Me.gpoDatos.Controls.Add(Me.lblVaca)
        Me.gpoDatos.Controls.Add(Me.lblToro)
        Me.gpoDatos.Controls.Add(Me.cboToro)
        Me.gpoDatos.Controls.Add(Me.lblTipo)
        Me.gpoDatos.Controls.Add(Me.btnCancelar)
        Me.gpoDatos.Controls.Add(Me.cboTipo)
        Me.gpoDatos.Controls.Add(Me.btnCrear)
        Me.gpoDatos.Controls.Add(Me.lblProceso)
        Me.gpoDatos.Controls.Add(Me.cboProceso)
        Me.gpoDatos.Controls.Add(Me.dateEntore)
        Me.gpoDatos.Controls.Add(Me.lblEntore)
        Me.gpoDatos.Location = New System.Drawing.Point(12, 139)
        Me.gpoDatos.Name = "gpoDatos"
        Me.gpoDatos.Size = New System.Drawing.Size(545, 276)
        Me.gpoDatos.TabIndex = 199
        Me.gpoDatos.TabStop = False
        Me.gpoDatos.Text = "Datos"
        '
        'frmServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 772)
        Me.Controls.Add(Me.gpoDatos)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.SwitchButton1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.gpoBusqueda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servicio"
        CType(Me.dateEntore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoBusqueda.ResumeLayout(False)
        Me.gpoBusqueda.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoDatos.ResumeLayout(False)
        Me.gpoDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboVaca As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblVaca As System.Windows.Forms.Label
    Friend WithEvents cboToro As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblToro As System.Windows.Forms.Label
    Friend WithEvents cboTipo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents cboProceso As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblProceso As System.Windows.Forms.Label
    Friend WithEvents lblEntore As System.Windows.Forms.Label
    Friend WithEvents dateEntore As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents gpoBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents cboServicio As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btnBuscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCrear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents btnCerrar As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Login As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SwitchButton1 As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpoDatos As System.Windows.Forms.GroupBox
End Class
