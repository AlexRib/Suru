<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenie))
        Me.btnCerrar = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.lblOrdeñes = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.cboVaca = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblVaca = New System.Windows.Forms.Label()
        Me.cboLote = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.gpoLote = New System.Windows.Forms.GroupBox()
        Me.gpoAniadir = New System.Windows.Forms.GroupBox()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.btnCrear = New DevComponents.DotNetBar.ButtonX()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombreLote = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.gpoEliminar = New System.Windows.Forms.GroupBox()
        Me.lblNombre2 = New System.Windows.Forms.Label()
        Me.cboELiminarLote = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX()
        Me.cboIngresarLote = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblIngresarLote = New System.Windows.Forms.Label()
        Me.cbolIngresarLeche = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblIngresarLeche = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txtCantidad = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblCalcio = New System.Windows.Forms.Label()
        Me.txtCalcio = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dateFecha = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.gpoProduccion = New System.Windows.Forms.GroupBox()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.gpoAsignar = New System.Windows.Forms.GroupBox()
        Me.gpoLote.SuspendLayout
        Me.gpoAniadir.SuspendLayout
        Me.gpoEliminar.SuspendLayout
        CType(Me.dateFecha,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gpoProduccion.SuspendLayout
        Me.gpoAsignar.SuspendLayout
        Me.SuspendLayout
        '
        'btnCerrar
        '
        '
        '
        '
        Me.btnCerrar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btnCerrar.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"),System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(1337, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(29, 45)
        Me.btnCerrar.TabIndex = 128
        '
        'lblOrdeñes
        '
        '
        '
        '
        Me.lblOrdeñes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblOrdeñes.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblOrdeñes.Location = New System.Drawing.Point(594, 12)
        Me.lblOrdeñes.Name = "lblOrdeñes"
        Me.lblOrdeñes.Size = New System.Drawing.Size(107, 52)
        Me.lblOrdeñes.TabIndex = 130
        Me.lblOrdeñes.Text = "<b><font size=""+6""><i></i><font color=""#B02B2C"">Ordeñes</font></font></b>"
        '
        'cboVaca
        '
        Me.cboVaca.DisplayMember = "Text"
        Me.cboVaca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboVaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboVaca.FormattingEnabled = true
        Me.cboVaca.ItemHeight = 20
        Me.cboVaca.Location = New System.Drawing.Point(203, 31)
        Me.cboVaca.Name = "cboVaca"
        Me.cboVaca.Size = New System.Drawing.Size(117, 26)
        Me.cboVaca.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboVaca.TabIndex = 175
        Me.cboVaca.WatermarkText = "Seleccione"
        '
        'lblVaca
        '
        Me.lblVaca.AutoSize = true
        Me.lblVaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblVaca.Location = New System.Drawing.Point(73, 31)
        Me.lblVaca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVaca.Name = "lblVaca"
        Me.lblVaca.Size = New System.Drawing.Size(50, 20)
        Me.lblVaca.TabIndex = 174
        Me.lblVaca.Text = "Vaca:"
        '
        'cboLote
        '
        Me.cboLote.DisplayMember = "Text"
        Me.cboLote.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboLote.FormattingEnabled = true
        Me.cboLote.ItemHeight = 20
        Me.cboLote.Location = New System.Drawing.Point(203, 96)
        Me.cboLote.Name = "cboLote"
        Me.cboLote.Size = New System.Drawing.Size(117, 26)
        Me.cboLote.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboLote.TabIndex = 177
        Me.cboLote.WatermarkText = "Seleccione"
        '
        'lblLote
        '
        Me.lblLote.AutoSize = true
        Me.lblLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblLote.Location = New System.Drawing.Point(73, 96)
        Me.lblLote.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(45, 20)
        Me.lblLote.TabIndex = 176
        Me.lblLote.Text = "Lote:"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.BackColor = System.Drawing.Color.Firebrick
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.ButtonX1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonX1.Location = New System.Drawing.Point(221, 168)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(140, 27)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 179
        Me.ButtonX1.Text = "Cancelar"
        Me.ButtonX1.TextColor = System.Drawing.Color.White
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.ButtonX2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonX2.Location = New System.Drawing.Point(31, 168)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(140, 27)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 178
        Me.ButtonX2.Text = "Aceptar"
        Me.ButtonX2.TextColor = System.Drawing.Color.White
        '
        'gpoLote
        '
        Me.gpoLote.Controls.Add(Me.gpoAniadir)
        Me.gpoLote.Controls.Add(Me.gpoEliminar)
        Me.gpoLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gpoLote.Location = New System.Drawing.Point(451, 95)
        Me.gpoLote.Name = "gpoLote"
        Me.gpoLote.Size = New System.Drawing.Size(414, 311)
        Me.gpoLote.TabIndex = 185
        Me.gpoLote.TabStop = false
        Me.gpoLote.Text = "Lotes"
        '
        'gpoAniadir
        '
        Me.gpoAniadir.BackColor = System.Drawing.Color.DarkCyan
        Me.gpoAniadir.Controls.Add(Me.ButtonX3)
        Me.gpoAniadir.Controls.Add(Me.btnCrear)
        Me.gpoAniadir.Controls.Add(Me.lblNombre)
        Me.gpoAniadir.Controls.Add(Me.txtNombreLote)
        Me.gpoAniadir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gpoAniadir.Location = New System.Drawing.Point(18, 34)
        Me.gpoAniadir.Name = "gpoAniadir"
        Me.gpoAniadir.Size = New System.Drawing.Size(377, 139)
        Me.gpoAniadir.TabIndex = 104
        Me.gpoAniadir.TabStop = false
        Me.gpoAniadir.Text = "Añadir"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.BackColor = System.Drawing.Color.Gold
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.ButtonX3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonX3.Location = New System.Drawing.Point(214, 84)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(96, 27)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 182
        Me.ButtonX3.Text = "Cancelar"
        Me.ButtonX3.TextColor = System.Drawing.Color.White
        '
        'btnCrear
        '
        Me.btnCrear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCrear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCrear.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCrear.Location = New System.Drawing.Point(85, 84)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(96, 27)
        Me.btnCrear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCrear.TabIndex = 175
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.TextColor = System.Drawing.Color.White
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = true
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblNombre.Location = New System.Drawing.Point(81, 38)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(69, 20)
        Me.lblNombre.TabIndex = 102
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombreLote
        '
        '
        '
        '
        Me.txtNombreLote.Border.Class = "TextBoxBorder"
        Me.txtNombreLote.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNombreLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtNombreLote.Location = New System.Drawing.Point(211, 38)
        Me.txtNombreLote.Name = "txtNombreLote"
        Me.txtNombreLote.Size = New System.Drawing.Size(100, 26)
        Me.txtNombreLote.TabIndex = 103
        '
        'gpoEliminar
        '
        Me.gpoEliminar.BackColor = System.Drawing.Color.DarkCyan
        Me.gpoEliminar.Controls.Add(Me.lblNombre2)
        Me.gpoEliminar.Controls.Add(Me.cboELiminarLote)
        Me.gpoEliminar.Controls.Add(Me.btnEliminar)
        Me.gpoEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gpoEliminar.Location = New System.Drawing.Point(18, 194)
        Me.gpoEliminar.Name = "gpoEliminar"
        Me.gpoEliminar.Size = New System.Drawing.Size(377, 95)
        Me.gpoEliminar.TabIndex = 180
        Me.gpoEliminar.TabStop = false
        Me.gpoEliminar.Text = "Eliminar"
        '
        'lblNombre2
        '
        Me.lblNombre2.AutoSize = true
        Me.lblNombre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblNombre2.Location = New System.Drawing.Point(17, 45)
        Me.lblNombre2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre2.Name = "lblNombre2"
        Me.lblNombre2.Size = New System.Drawing.Size(69, 20)
        Me.lblNombre2.TabIndex = 177
        Me.lblNombre2.Text = "Nombre:"
        '
        'cboELiminarLote
        '
        Me.cboELiminarLote.DisplayMember = "Text"
        Me.cboELiminarLote.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboELiminarLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboELiminarLote.FormattingEnabled = true
        Me.cboELiminarLote.ItemHeight = 20
        Me.cboELiminarLote.Location = New System.Drawing.Point(114, 43)
        Me.cboELiminarLote.Name = "cboELiminarLote"
        Me.cboELiminarLote.Size = New System.Drawing.Size(133, 26)
        Me.cboELiminarLote.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboELiminarLote.TabIndex = 178
        Me.cboELiminarLote.WatermarkText = "Seleccione"
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminar.BackColor = System.Drawing.Color.Firebrick
        Me.btnEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Location = New System.Drawing.Point(272, 44)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(99, 25)
        Me.btnEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEliminar.TabIndex = 179
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextColor = System.Drawing.Color.White
        '
        'cboIngresarLote
        '
        Me.cboIngresarLote.DisplayMember = "Text"
        Me.cboIngresarLote.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboIngresarLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboIngresarLote.FormattingEnabled = true
        Me.cboIngresarLote.ItemHeight = 20
        Me.cboIngresarLote.Location = New System.Drawing.Point(137, 91)
        Me.cboIngresarLote.Name = "cboIngresarLote"
        Me.cboIngresarLote.Size = New System.Drawing.Size(117, 26)
        Me.cboIngresarLote.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboIngresarLote.TabIndex = 187
        Me.cboIngresarLote.WatermarkText = "Seleccione"
        '
        'lblIngresarLote
        '
        Me.lblIngresarLote.AutoSize = true
        Me.lblIngresarLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblIngresarLote.Location = New System.Drawing.Point(7, 91)
        Me.lblIngresarLote.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIngresarLote.Name = "lblIngresarLote"
        Me.lblIngresarLote.Size = New System.Drawing.Size(45, 20)
        Me.lblIngresarLote.TabIndex = 186
        Me.lblIngresarLote.Text = "Lote:"
        '
        'cbolIngresarLeche
        '
        Me.cbolIngresarLeche.DisplayMember = "Text"
        Me.cbolIngresarLeche.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbolIngresarLeche.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbolIngresarLeche.FormattingEnabled = true
        Me.cbolIngresarLeche.ItemHeight = 20
        Me.cbolIngresarLeche.Location = New System.Drawing.Point(137, 40)
        Me.cbolIngresarLeche.Name = "cbolIngresarLeche"
        Me.cbolIngresarLeche.Size = New System.Drawing.Size(117, 26)
        Me.cbolIngresarLeche.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbolIngresarLeche.TabIndex = 189
        Me.cbolIngresarLeche.WatermarkText = "Seleccione"
        '
        'lblIngresarLeche
        '
        Me.lblIngresarLeche.AutoSize = true
        Me.lblIngresarLeche.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblIngresarLeche.Location = New System.Drawing.Point(7, 40)
        Me.lblIngresarLeche.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIngresarLeche.Name = "lblIngresarLeche"
        Me.lblIngresarLeche.Size = New System.Drawing.Size(57, 20)
        Me.lblIngresarLeche.TabIndex = 188
        Me.lblIngresarLeche.Text = "Leche:"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = true
        Me.lblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(7, 199)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(77, 20)
        Me.lblCantidad.TabIndex = 190
        Me.lblCantidad.Text = "Cantidad:"
        '
        'txtCantidad
        '
        '
        '
        '
        Me.txtCantidad.Border.Class = "TextBoxBorder"
        Me.txtCantidad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(137, 199)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 26)
        Me.txtCantidad.TabIndex = 191
        '
        'lblCalcio
        '
        Me.lblCalcio.AutoSize = true
        Me.lblCalcio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblCalcio.Location = New System.Drawing.Point(7, 255)
        Me.lblCalcio.Name = "lblCalcio"
        Me.lblCalcio.Size = New System.Drawing.Size(56, 20)
        Me.lblCalcio.TabIndex = 192
        Me.lblCalcio.Text = "Calcio:"
        '
        'txtCalcio
        '
        '
        '
        '
        Me.txtCalcio.Border.Class = "TextBoxBorder"
        Me.txtCalcio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCalcio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtCalcio.Location = New System.Drawing.Point(137, 255)
        Me.txtCalcio.Name = "txtCalcio"
        Me.txtCalcio.Size = New System.Drawing.Size(100, 26)
        Me.txtCalcio.TabIndex = 193
        '
        'dateFecha
        '
        '
        '
        '
        Me.dateFecha.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dateFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateFecha.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dateFecha.ButtonDropDown.Visible = true
        Me.dateFecha.IsPopupCalendarOpen = false
        Me.dateFecha.Location = New System.Drawing.Point(137, 147)
        Me.dateFecha.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        '
        '
        '
        Me.dateFecha.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dateFecha.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateFecha.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dateFecha.MonthCalendar.ClearButtonVisible = true
        '
        '
        '
        Me.dateFecha.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dateFecha.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dateFecha.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dateFecha.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dateFecha.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dateFecha.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dateFecha.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateFecha.MonthCalendar.DisplayMonth = New Date(2016, 7, 1, 0, 0, 0, 0)
        Me.dateFecha.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dateFecha.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dateFecha.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dateFecha.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dateFecha.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dateFecha.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dateFecha.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateFecha.MonthCalendar.TodayButtonVisible = true
        Me.dateFecha.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dateFecha.Name = "dateFecha"
        Me.dateFecha.Size = New System.Drawing.Size(117, 26)
        Me.dateFecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dateFecha.TabIndex = 195
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = true
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblFecha.Location = New System.Drawing.Point(8, 147)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(58, 20)
        Me.lblFecha.TabIndex = 194
        Me.lblFecha.Text = "Fecha:"
        '
        'gpoProduccion
        '
        Me.gpoProduccion.Controls.Add(Me.ButtonX4)
        Me.gpoProduccion.Controls.Add(Me.lblIngresarLeche)
        Me.gpoProduccion.Controls.Add(Me.dateFecha)
        Me.gpoProduccion.Controls.Add(Me.lblIngresarLote)
        Me.gpoProduccion.Controls.Add(Me.cboIngresarLote)
        Me.gpoProduccion.Controls.Add(Me.lblCalcio)
        Me.gpoProduccion.Controls.Add(Me.lblFecha)
        Me.gpoProduccion.Controls.Add(Me.cbolIngresarLeche)
        Me.gpoProduccion.Controls.Add(Me.txtCalcio)
        Me.gpoProduccion.Controls.Add(Me.txtCantidad)
        Me.gpoProduccion.Controls.Add(Me.lblCantidad)
        Me.gpoProduccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gpoProduccion.Location = New System.Drawing.Point(88, 86)
        Me.gpoProduccion.Name = "gpoProduccion"
        Me.gpoProduccion.Size = New System.Drawing.Size(270, 366)
        Me.gpoProduccion.TabIndex = 196
        Me.gpoProduccion.TabStop = false
        Me.gpoProduccion.Text = "Registrar producción"
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.ButtonX4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonX4.Location = New System.Drawing.Point(40, 309)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(197, 27)
        Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX4.TabIndex = 198
        Me.ButtonX4.Text = "Aceptar"
        Me.ButtonX4.TextColor = System.Drawing.Color.White
        '
        'gpoAsignar
        '
        Me.gpoAsignar.Controls.Add(Me.lblVaca)
        Me.gpoAsignar.Controls.Add(Me.cboVaca)
        Me.gpoAsignar.Controls.Add(Me.lblLote)
        Me.gpoAsignar.Controls.Add(Me.ButtonX1)
        Me.gpoAsignar.Controls.Add(Me.cboLote)
        Me.gpoAsignar.Controls.Add(Me.ButtonX2)
        Me.gpoAsignar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.gpoAsignar.Location = New System.Drawing.Point(915, 95)
        Me.gpoAsignar.Name = "gpoAsignar"
        Me.gpoAsignar.Size = New System.Drawing.Size(380, 225)
        Me.gpoAsignar.TabIndex = 197
        Me.gpoAsignar.TabStop = false
        Me.gpoAsignar.Text = "Asignar vaca a un lote"
        '
        'frmOrdenie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1378, 780)
        Me.Controls.Add(Me.gpoAsignar)
        Me.Controls.Add(Me.gpoProduccion)
        Me.Controls.Add(Me.gpoLote)
        Me.Controls.Add(Me.lblOrdeñes)
        Me.Controls.Add(Me.btnCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmOrdenie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordeñes"
        Me.gpoLote.ResumeLayout(false)
        Me.gpoAniadir.ResumeLayout(false)
        Me.gpoAniadir.PerformLayout
        Me.gpoEliminar.ResumeLayout(false)
        Me.gpoEliminar.PerformLayout
        CType(Me.dateFecha,System.ComponentModel.ISupportInitialize).EndInit
        Me.gpoProduccion.ResumeLayout(false)
        Me.gpoProduccion.PerformLayout
        Me.gpoAsignar.ResumeLayout(false)
        Me.gpoAsignar.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents btnCerrar As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents lblOrdeñes As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents cboVaca As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblVaca As System.Windows.Forms.Label
    Friend WithEvents cboLote As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblLote As System.Windows.Forms.Label
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gpoLote As System.Windows.Forms.GroupBox
    Friend WithEvents gpoAniadir As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCrear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombreLote As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents gpoEliminar As System.Windows.Forms.GroupBox
    Friend WithEvents lblNombre2 As System.Windows.Forms.Label
    Friend WithEvents cboELiminarLote As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cboIngresarLote As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblIngresarLote As System.Windows.Forms.Label
    Friend WithEvents cbolIngresarLeche As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblIngresarLeche As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblCalcio As System.Windows.Forms.Label
    Friend WithEvents txtCalcio As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dateFecha As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents gpoProduccion As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gpoAsignar As System.Windows.Forms.GroupBox
End Class
