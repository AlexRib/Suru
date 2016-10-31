<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCria))
        Me.lblRaza = New System.Windows.Forms.Label()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblKg = New System.Windows.Forms.Label()
        Me.dateNacimiento = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.gpoBusqueda = New System.Windows.Forms.GroupBox()
        Me.cboBuscar = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btnBuscar = New DevComponents.DotNetBar.ButtonX()
        Me.lblCria = New System.Windows.Forms.Label()
        Me.gpoDatos = New System.Windows.Forms.GroupBox()
        Me.radHembra = New System.Windows.Forms.RadioButton()
        Me.radMacho = New System.Windows.Forms.RadioButton()
        Me.gpoProg = New System.Windows.Forms.GroupBox()
        Me.cboVaca = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblVaca = New System.Windows.Forms.Label()
        Me.cboToro = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblToro = New System.Windows.Forms.Label()
        Me.btnModificar = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX()
        Me.btnCrear = New DevComponents.DotNetBar.ButtonX()
        Me.cboRaza = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.txtNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblCrias = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.ComboItem9 = New DevComponents.Editors.ComboItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.lblList = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnCerrar = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.btnRecria1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        CType(Me.dateNacimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoBusqueda.SuspendLayout()
        Me.gpoDatos.SuspendLayout()
        Me.gpoProg.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRaza
        '
        Me.lblRaza.AutoSize = True
        Me.lblRaza.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaza.Location = New System.Drawing.Point(26, 104)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(51, 20)
        Me.lblRaza.TabIndex = 59
        Me.lblRaza.Text = "Raza:"
        '
        'lblNacimiento
        '
        Me.lblNacimiento.AutoSize = True
        Me.lblNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacimiento.Location = New System.Drawing.Point(24, 159)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(92, 20)
        Me.lblNacimiento.TabIndex = 55
        Me.lblNacimiento.Text = "Nacimiento:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(25, 53)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(98, 20)
        Me.lblNombre.TabIndex = 54
        Me.lblNombre.Text = "Nombre cría:"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(319, 55)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(49, 20)
        Me.lblSexo.TabIndex = 79
        Me.lblSexo.Text = "Sexo:"
        '
        'lblKg
        '
        Me.lblKg.AutoSize = True
        Me.lblKg.Location = New System.Drawing.Point(291, 219)
        Me.lblKg.Name = "lblKg"
        Me.lblKg.Size = New System.Drawing.Size(23, 13)
        Me.lblKg.TabIndex = 82
        Me.lblKg.Text = "Kg."
        '
        'dateNacimiento
        '
        '
        '
        '
        Me.dateNacimiento.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dateNacimiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateNacimiento.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dateNacimiento.ButtonDropDown.Visible = True
        Me.dateNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateNacimiento.IsPopupCalendarOpen = False
        Me.dateNacimiento.Location = New System.Drawing.Point(153, 158)
        '
        '
        '
        Me.dateNacimiento.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dateNacimiento.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateNacimiento.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dateNacimiento.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dateNacimiento.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dateNacimiento.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dateNacimiento.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dateNacimiento.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dateNacimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dateNacimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dateNacimiento.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateNacimiento.MonthCalendar.DisplayMonth = New Date(2016, 7, 1, 0, 0, 0, 0)
        Me.dateNacimiento.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dateNacimiento.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dateNacimiento.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dateNacimiento.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dateNacimiento.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dateNacimiento.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dateNacimiento.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateNacimiento.MonthCalendar.TodayButtonVisible = True
        Me.dateNacimiento.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dateNacimiento.Name = "dateNacimiento"
        Me.dateNacimiento.Size = New System.Drawing.Size(117, 21)
        Me.dateNacimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dateNacimiento.TabIndex = 98
        '
        'gpoBusqueda
        '
        Me.gpoBusqueda.Controls.Add(Me.cboBuscar)
        Me.gpoBusqueda.Controls.Add(Me.btnBuscar)
        Me.gpoBusqueda.Controls.Add(Me.lblCria)
        Me.gpoBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpoBusqueda.Location = New System.Drawing.Point(183, 57)
        Me.gpoBusqueda.Name = "gpoBusqueda"
        Me.gpoBusqueda.Size = New System.Drawing.Size(404, 87)
        Me.gpoBusqueda.TabIndex = 100
        Me.gpoBusqueda.TabStop = False
        Me.gpoBusqueda.Text = "Búsqueda"
        '
        'cboBuscar
        '
        Me.cboBuscar.DisplayMember = "Text"
        Me.cboBuscar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBuscar.FormattingEnabled = True
        Me.cboBuscar.ItemHeight = 20
        Me.cboBuscar.Location = New System.Drawing.Point(146, 39)
        Me.cboBuscar.Name = "cboBuscar"
        Me.cboBuscar.Size = New System.Drawing.Size(117, 26)
        Me.cboBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboBuscar.TabIndex = 173
        Me.cboBuscar.WatermarkText = "Seleccione"
        '
        'btnBuscar
        '
        Me.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btnBuscar.Location = New System.Drawing.Point(295, 39)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBuscar.TabIndex = 121
        Me.btnBuscar.Text = "Buscar"
        '
        'lblCria
        '
        Me.lblCria.AutoSize = True
        Me.lblCria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCria.Location = New System.Drawing.Point(42, 39)
        Me.lblCria.Name = "lblCria"
        Me.lblCria.Size = New System.Drawing.Size(41, 20)
        Me.lblCria.TabIndex = 12
        Me.lblCria.Text = "Cría:"
        '
        'gpoDatos
        '
        Me.gpoDatos.Controls.Add(Me.radHembra)
        Me.gpoDatos.Controls.Add(Me.radMacho)
        Me.gpoDatos.Controls.Add(Me.gpoProg)
        Me.gpoDatos.Controls.Add(Me.btnModificar)
        Me.gpoDatos.Controls.Add(Me.btnCancelar)
        Me.gpoDatos.Controls.Add(Me.btnEliminar)
        Me.gpoDatos.Controls.Add(Me.btnCrear)
        Me.gpoDatos.Controls.Add(Me.cboRaza)
        Me.gpoDatos.Controls.Add(Me.txtNombre)
        Me.gpoDatos.Controls.Add(Me.lblNombre)
        Me.gpoDatos.Controls.Add(Me.dateNacimiento)
        Me.gpoDatos.Controls.Add(Me.lblNacimiento)
        Me.gpoDatos.Controls.Add(Me.lblRaza)
        Me.gpoDatos.Controls.Add(Me.lblSexo)
        Me.gpoDatos.Location = New System.Drawing.Point(66, 174)
        Me.gpoDatos.Name = "gpoDatos"
        Me.gpoDatos.Size = New System.Drawing.Size(621, 330)
        Me.gpoDatos.TabIndex = 101
        Me.gpoDatos.TabStop = False
        Me.gpoDatos.Text = "Datos"
        '
        'radHembra
        '
        Me.radHembra.AutoSize = True
        Me.radHembra.Location = New System.Drawing.Point(498, 56)
        Me.radHembra.Name = "radHembra"
        Me.radHembra.Size = New System.Drawing.Size(62, 17)
        Me.radHembra.TabIndex = 145
        Me.radHembra.TabStop = True
        Me.radHembra.Text = "Hembra"
        Me.radHembra.UseVisualStyleBackColor = True
        '
        'radMacho
        '
        Me.radMacho.AutoSize = True
        Me.radMacho.Location = New System.Drawing.Point(404, 56)
        Me.radMacho.Name = "radMacho"
        Me.radMacho.Size = New System.Drawing.Size(58, 17)
        Me.radMacho.TabIndex = 144
        Me.radMacho.TabStop = True
        Me.radMacho.Text = "Macho"
        Me.radMacho.UseVisualStyleBackColor = True
        '
        'gpoProg
        '
        Me.gpoProg.Controls.Add(Me.cboVaca)
        Me.gpoProg.Controls.Add(Me.lblVaca)
        Me.gpoProg.Controls.Add(Me.cboToro)
        Me.gpoProg.Controls.Add(Me.lblToro)
        Me.gpoProg.Location = New System.Drawing.Point(323, 90)
        Me.gpoProg.Name = "gpoProg"
        Me.gpoProg.Size = New System.Drawing.Size(255, 100)
        Me.gpoProg.TabIndex = 143
        Me.gpoProg.TabStop = False
        Me.gpoProg.Text = "Progenitores"
        '
        'cboVaca
        '
        Me.cboVaca.DisplayMember = "Text"
        Me.cboVaca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboVaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVaca.FormattingEnabled = True
        Me.cboVaca.ItemHeight = 20
        Me.cboVaca.Location = New System.Drawing.Point(124, 63)
        Me.cboVaca.Name = "cboVaca"
        Me.cboVaca.Size = New System.Drawing.Size(117, 26)
        Me.cboVaca.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboVaca.TabIndex = 176
        Me.cboVaca.WatermarkText = "Seleccione"
        '
        'lblVaca
        '
        Me.lblVaca.AutoSize = True
        Me.lblVaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVaca.Location = New System.Drawing.Point(34, 69)
        Me.lblVaca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVaca.Name = "lblVaca"
        Me.lblVaca.Size = New System.Drawing.Size(50, 20)
        Me.lblVaca.TabIndex = 175
        Me.lblVaca.Text = "Vaca:"
        '
        'cboToro
        '
        Me.cboToro.DisplayMember = "Text"
        Me.cboToro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboToro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboToro.FormattingEnabled = True
        Me.cboToro.ItemHeight = 20
        Me.cboToro.Location = New System.Drawing.Point(124, 19)
        Me.cboToro.Name = "cboToro"
        Me.cboToro.Size = New System.Drawing.Size(117, 26)
        Me.cboToro.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboToro.TabIndex = 174
        Me.cboToro.WatermarkText = "Seleccione"
        '
        'lblToro
        '
        Me.lblToro.AutoSize = True
        Me.lblToro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToro.Location = New System.Drawing.Point(34, 25)
        Me.lblToro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblToro.Name = "lblToro"
        Me.lblToro.Size = New System.Drawing.Size(45, 20)
        Me.lblToro.TabIndex = 173
        Me.lblToro.Text = "Toro:"
        '
        'btnModificar
        '
        Me.btnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModificar.BackColor = System.Drawing.Color.Green
        Me.btnModificar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Location = New System.Drawing.Point(173, 270)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(125, 27)
        Me.btnModificar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnModificar.TabIndex = 141
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextColor = System.Drawing.Color.White
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancelar.BackColor = System.Drawing.Color.Gold
        Me.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Location = New System.Drawing.Point(482, 270)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(125, 27)
        Me.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancelar.TabIndex = 140
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextColor = System.Drawing.Color.White
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminar.BackColor = System.Drawing.Color.Firebrick
        Me.btnEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Location = New System.Drawing.Point(325, 270)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(125, 27)
        Me.btnEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEliminar.TabIndex = 137
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextColor = System.Drawing.Color.White
        '
        'btnCrear
        '
        Me.btnCrear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCrear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCrear.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCrear.Location = New System.Drawing.Point(15, 270)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(125, 27)
        Me.btnCrear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCrear.TabIndex = 136
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.TextColor = System.Drawing.Color.White
        '
        'cboRaza
        '
        Me.cboRaza.DisplayMember = "Text"
        Me.cboRaza.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboRaza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRaza.FormattingEnabled = True
        Me.cboRaza.ItemHeight = 15
        Me.cboRaza.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3})
        Me.cboRaza.Location = New System.Drawing.Point(154, 104)
        Me.cboRaza.Name = "cboRaza"
        Me.cboRaza.Size = New System.Drawing.Size(118, 21)
        Me.cboRaza.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboRaza.TabIndex = 103
        Me.cboRaza.WatermarkText = "Ingrese"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Horlando"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Jersey"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Primer show"
        '
        'txtNombre
        '
        '
        '
        '
        Me.txtNombre.Border.Class = "TextBoxBorder"
        Me.txtNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(154, 53)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 21)
        Me.txtNombre.TabIndex = 101
        '
        'lblCrias
        '
        '
        '
        '
        Me.lblCrias.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblCrias.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrias.Location = New System.Drawing.Point(350, -1)
        Me.lblCrias.Name = "lblCrias"
        Me.lblCrias.Size = New System.Drawing.Size(84, 52)
        Me.lblCrias.TabIndex = 124
        Me.lblCrias.Text = "<b><font size=""+6""><i></i><font color=""#B02B2C"">Crias</font></font></b>"
        '
        'ComboItem9
        '
        Me.ComboItem9.Text = "Hembra"
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "Macho"
        '
        'lblList
        '
        Me.lblList.AutoSize = True
        Me.lblList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblList.Location = New System.Drawing.Point(946, 57)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(140, 24)
        Me.lblList.TabIndex = 174
        Me.lblList.Text = "Listado de crias"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(763, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(509, 272)
        Me.DataGridView1.TabIndex = 173
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
        Me.btnCerrar.Location = New System.Drawing.Point(1349, -1)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(29, 45)
        Me.btnCerrar.TabIndex = 123
        '
        'btnRecria1
        '
        Me.btnRecria1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRecria1.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btnRecria1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecria1.Location = New System.Drawing.Point(876, 402)
        Me.btnRecria1.Name = "btnRecria1"
        Me.btnRecria1.Size = New System.Drawing.Size(243, 36)
        Me.btnRecria1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRecria1.TabIndex = 199
        Me.btnRecria1.Text = "Asignar cría a campo recría"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.ButtonX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Location = New System.Drawing.Point(876, 444)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(243, 36)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 200
        Me.ButtonX2.Text = "Añadir un campo de recría"
        '
        'frmCria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1378, 522)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.btnRecria1)
        Me.Controls.Add(Me.lblList)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblCrias)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.gpoDatos)
        Me.Controls.Add(Me.gpoBusqueda)
        Me.Controls.Add(Me.lblKg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crias"
        CType(Me.dateNacimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoBusqueda.ResumeLayout(False)
        Me.gpoBusqueda.PerformLayout()
        Me.gpoDatos.ResumeLayout(False)
        Me.gpoDatos.PerformLayout()
        Me.gpoProg.ResumeLayout(False)
        Me.gpoProg.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRaza As System.Windows.Forms.Label
    Friend WithEvents lblNacimiento As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents lblKg As System.Windows.Forms.Label
    Friend WithEvents dateNacimiento As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents gpoBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents lblCria As System.Windows.Forms.Label
    Friend WithEvents gpoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cboRaza As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents btnCerrar As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents txtNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblCrias As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCrear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cboBuscar As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents gpoProg As System.Windows.Forms.GroupBox
    Friend WithEvents cboVaca As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblVaca As System.Windows.Forms.Label
    Friend WithEvents cboToro As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblToro As System.Windows.Forms.Label
    Friend WithEvents lblList As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents radHembra As System.Windows.Forms.RadioButton
    Friend WithEvents radMacho As System.Windows.Forms.RadioButton
    Friend WithEvents btnRecria1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
End Class
