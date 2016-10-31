<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContrae
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContrae))
        Me.cboEnf = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblEnf = New System.Windows.Forms.Label()
        Me.btnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.btnAceptar = New DevComponents.DotNetBar.ButtonX()
        Me.dateFecha = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.lblFechaEnfermedad = New System.Windows.Forms.Label()
        Me.lblAnimal = New System.Windows.Forms.Label()
        Me.btnCerrar = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.cboAnimal = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.gpoTratamiento = New System.Windows.Forms.GroupBox()
        Me.cboTratamiento = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboAnimal2 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.lblIDanimal = New System.Windows.Forms.Label()
        Me.lblTratamiento = New System.Windows.Forms.Label()
        Me.lblMedicacion = New System.Windows.Forms.Label()
        Me.cboMedicacion = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.ComboItem9 = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.SwitchButton1 = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.gpoEnf = New System.Windows.Forms.GroupBox()
        Me.lblTratam = New System.Windows.Forms.Label()
        Me.gpoDeclararenf = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dateFechaF = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.cboAnimal3 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        CType(Me.dateFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoTratamiento.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoEnf.SuspendLayout()
        Me.gpoDeclararenf.SuspendLayout()
        CType(Me.dateFechaF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboEnf
        '
        Me.cboEnf.DisplayMember = "Text"
        Me.cboEnf.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboEnf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEnf.FormattingEnabled = True
        Me.cboEnf.ItemHeight = 15
        Me.cboEnf.Location = New System.Drawing.Point(204, 117)
        Me.cboEnf.Name = "cboEnf"
        Me.cboEnf.Size = New System.Drawing.Size(121, 21)
        Me.cboEnf.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboEnf.TabIndex = 155
        '
        'lblEnf
        '
        Me.lblEnf.AutoSize = True
        Me.lblEnf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnf.Location = New System.Drawing.Point(63, 118)
        Me.lblEnf.Name = "lblEnf"
        Me.lblEnf.Size = New System.Drawing.Size(101, 20)
        Me.lblEnf.TabIndex = 154
        Me.lblEnf.Text = "Enfermedad:"
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancelar.BackColor = System.Drawing.Color.Firebrick
        Me.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Location = New System.Drawing.Point(221, 243)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(140, 27)
        Me.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancelar.TabIndex = 153
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextColor = System.Drawing.Color.White
        '
        'btnAceptar
        '
        Me.btnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAceptar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Location = New System.Drawing.Point(31, 243)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(140, 27)
        Me.btnAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAceptar.TabIndex = 152
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextColor = System.Drawing.Color.White
        '
        'dateFecha
        '
        '
        '
        '
        Me.dateFecha.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dateFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateFecha.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dateFecha.ButtonDropDown.Visible = True
        Me.dateFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFecha.IsPopupCalendarOpen = False
        Me.dateFecha.Location = New System.Drawing.Point(204, 173)
        '
        '
        '
        Me.dateFecha.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dateFecha.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateFecha.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dateFecha.MonthCalendar.ClearButtonVisible = True
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
        Me.dateFecha.MonthCalendar.TodayButtonVisible = True
        Me.dateFecha.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dateFecha.Name = "dateFecha"
        Me.dateFecha.Size = New System.Drawing.Size(121, 21)
        Me.dateFecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dateFecha.TabIndex = 147
        '
        'lblFechaEnfermedad
        '
        Me.lblFechaEnfermedad.AutoSize = True
        Me.lblFechaEnfermedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaEnfermedad.Location = New System.Drawing.Point(63, 173)
        Me.lblFechaEnfermedad.Name = "lblFechaEnfermedad"
        Me.lblFechaEnfermedad.Size = New System.Drawing.Size(58, 20)
        Me.lblFechaEnfermedad.TabIndex = 146
        Me.lblFechaEnfermedad.Text = "Fecha:"
        '
        'lblAnimal
        '
        Me.lblAnimal.AutoSize = True
        Me.lblAnimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnimal.Location = New System.Drawing.Point(64, 66)
        Me.lblAnimal.Name = "lblAnimal"
        Me.lblAnimal.Size = New System.Drawing.Size(61, 20)
        Me.lblAnimal.TabIndex = 145
        Me.lblAnimal.Text = "Animal:"
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
        Me.btnCerrar.Location = New System.Drawing.Point(1342, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(29, 45)
        Me.btnCerrar.TabIndex = 150
        '
        'cboAnimal
        '
        Me.cboAnimal.DisplayMember = "Text"
        Me.cboAnimal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAnimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnimal.FormattingEnabled = True
        Me.cboAnimal.ItemHeight = 15
        Me.cboAnimal.Location = New System.Drawing.Point(203, 66)
        Me.cboAnimal.Name = "cboAnimal"
        Me.cboAnimal.Size = New System.Drawing.Size(121, 21)
        Me.cboAnimal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboAnimal.TabIndex = 158
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(500, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(411, 192)
        Me.DataGridView1.TabIndex = 159
        '
        'gpoTratamiento
        '
        Me.gpoTratamiento.Controls.Add(Me.cboTratamiento)
        Me.gpoTratamiento.Controls.Add(Me.cboAnimal2)
        Me.gpoTratamiento.Controls.Add(Me.ButtonX1)
        Me.gpoTratamiento.Controls.Add(Me.ButtonX2)
        Me.gpoTratamiento.Controls.Add(Me.lblIDanimal)
        Me.gpoTratamiento.Controls.Add(Me.lblTratamiento)
        Me.gpoTratamiento.Controls.Add(Me.lblMedicacion)
        Me.gpoTratamiento.Controls.Add(Me.cboMedicacion)
        Me.gpoTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpoTratamiento.Location = New System.Drawing.Point(952, 44)
        Me.gpoTratamiento.Name = "gpoTratamiento"
        Me.gpoTratamiento.Size = New System.Drawing.Size(374, 370)
        Me.gpoTratamiento.TabIndex = 194
        Me.gpoTratamiento.TabStop = False
        Me.gpoTratamiento.Text = "Control"
        '
        'cboTratamiento
        '
        Me.cboTratamiento.DisplayMember = "Text"
        Me.cboTratamiento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTratamiento.FormattingEnabled = True
        Me.cboTratamiento.ItemHeight = 15
        Me.cboTratamiento.Location = New System.Drawing.Point(171, 104)
        Me.cboTratamiento.Name = "cboTratamiento"
        Me.cboTratamiento.Size = New System.Drawing.Size(166, 21)
        Me.cboTratamiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboTratamiento.TabIndex = 181
        '
        'cboAnimal2
        '
        Me.cboAnimal2.DisplayMember = "Text"
        Me.cboAnimal2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAnimal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnimal2.FormattingEnabled = True
        Me.cboAnimal2.ItemHeight = 15
        Me.cboAnimal2.Location = New System.Drawing.Point(171, 46)
        Me.cboAnimal2.Name = "cboAnimal2"
        Me.cboAnimal2.Size = New System.Drawing.Size(166, 21)
        Me.cboAnimal2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboAnimal2.TabIndex = 180
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.ButtonX1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonX1.Location = New System.Drawing.Point(91, 267)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(94, 27)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 142
        Me.ButtonX1.Text = "Aceptar"
        Me.ButtonX1.TextColor = System.Drawing.Color.White
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.BackColor = System.Drawing.Color.Firebrick
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.ButtonX2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonX2.Location = New System.Drawing.Point(218, 267)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(93, 27)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 143
        Me.ButtonX2.Text = "Cancelar"
        Me.ButtonX2.TextColor = System.Drawing.Color.White
        '
        'lblIDanimal
        '
        Me.lblIDanimal.AutoSize = True
        Me.lblIDanimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDanimal.Location = New System.Drawing.Point(33, 46)
        Me.lblIDanimal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIDanimal.Name = "lblIDanimal"
        Me.lblIDanimal.Size = New System.Drawing.Size(61, 20)
        Me.lblIDanimal.TabIndex = 144
        Me.lblIDanimal.Text = "Animal:"
        '
        'lblTratamiento
        '
        Me.lblTratamiento.AutoSize = True
        Me.lblTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTratamiento.Location = New System.Drawing.Point(33, 104)
        Me.lblTratamiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTratamiento.Name = "lblTratamiento"
        Me.lblTratamiento.Size = New System.Drawing.Size(98, 20)
        Me.lblTratamiento.TabIndex = 172
        Me.lblTratamiento.Text = "Tratamiento:"
        '
        'lblMedicacion
        '
        Me.lblMedicacion.AutoSize = True
        Me.lblMedicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedicacion.Location = New System.Drawing.Point(33, 158)
        Me.lblMedicacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMedicacion.Name = "lblMedicacion"
        Me.lblMedicacion.Size = New System.Drawing.Size(93, 20)
        Me.lblMedicacion.TabIndex = 176
        Me.lblMedicacion.Text = "Medicacion:"
        '
        'cboMedicacion
        '
        Me.cboMedicacion.DisplayMember = "Text"
        Me.cboMedicacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboMedicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMedicacion.FormattingEnabled = True
        Me.cboMedicacion.ItemHeight = 15
        Me.cboMedicacion.Items.AddRange(New Object() {Me.ComboItem4, Me.ComboItem8, Me.ComboItem9, Me.ComboItem1, Me.ComboItem2, Me.ComboItem3})
        Me.cboMedicacion.Location = New System.Drawing.Point(171, 158)
        Me.cboMedicacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboMedicacion.Name = "cboMedicacion"
        Me.cboMedicacion.Size = New System.Drawing.Size(166, 21)
        Me.cboMedicacion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboMedicacion.TabIndex = 179
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Analgesico"
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "Antibiotico"
        '
        'ComboItem9
        '
        Me.ComboItem9.Text = "Desparasitante"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Expectorantes"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Inyeccion"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Vitaminas"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(537, 311)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(356, 119)
        Me.DataGridView2.TabIndex = 195
        '
        'SwitchButton1
        '
        '
        '
        '
        Me.SwitchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SwitchButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SwitchButton1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SwitchButton1.Location = New System.Drawing.Point(611, 12)
        Me.SwitchButton1.Name = "SwitchButton1"
        Me.SwitchButton1.OffBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SwitchButton1.OffText = "Historial"
        Me.SwitchButton1.OffTextColor = System.Drawing.Color.White
        Me.SwitchButton1.OnBackColor = System.Drawing.Color.SteelBlue
        Me.SwitchButton1.OnText = "Animales enfermos"
        Me.SwitchButton1.OnTextColor = System.Drawing.Color.White
        Me.SwitchButton1.Size = New System.Drawing.Size(199, 33)
        Me.SwitchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SwitchButton1.TabIndex = 196
        Me.SwitchButton1.Value = True
        Me.SwitchButton1.ValueObject = "Y"
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(500, 70)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(411, 191)
        Me.DataGridView3.TabIndex = 197
        '
        'gpoEnf
        '
        Me.gpoEnf.Controls.Add(Me.lblAnimal)
        Me.gpoEnf.Controls.Add(Me.lblFechaEnfermedad)
        Me.gpoEnf.Controls.Add(Me.dateFecha)
        Me.gpoEnf.Controls.Add(Me.btnAceptar)
        Me.gpoEnf.Controls.Add(Me.btnCancelar)
        Me.gpoEnf.Controls.Add(Me.lblEnf)
        Me.gpoEnf.Controls.Add(Me.cboAnimal)
        Me.gpoEnf.Controls.Add(Me.cboEnf)
        Me.gpoEnf.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpoEnf.Location = New System.Drawing.Point(66, 44)
        Me.gpoEnf.Name = "gpoEnf"
        Me.gpoEnf.Size = New System.Drawing.Size(400, 294)
        Me.gpoEnf.TabIndex = 198
        Me.gpoEnf.TabStop = False
        Me.gpoEnf.Text = "Declarar animal enfermo"
        '
        'lblTratam
        '
        Me.lblTratam.AutoSize = True
        Me.lblTratam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTratam.Location = New System.Drawing.Point(656, 273)
        Me.lblTratam.Name = "lblTratam"
        Me.lblTratam.Size = New System.Drawing.Size(102, 20)
        Me.lblTratam.TabIndex = 199
        Me.lblTratam.Text = "Tratamientos"
        '
        'gpoDeclararenf
        '
        Me.gpoDeclararenf.Controls.Add(Me.Label1)
        Me.gpoDeclararenf.Controls.Add(Me.Label2)
        Me.gpoDeclararenf.Controls.Add(Me.dateFechaF)
        Me.gpoDeclararenf.Controls.Add(Me.ButtonX3)
        Me.gpoDeclararenf.Controls.Add(Me.ButtonX4)
        Me.gpoDeclararenf.Controls.Add(Me.cboAnimal3)
        Me.gpoDeclararenf.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpoDeclararenf.Location = New System.Drawing.Point(66, 344)
        Me.gpoDeclararenf.Name = "gpoDeclararenf"
        Me.gpoDeclararenf.Size = New System.Drawing.Size(400, 220)
        Me.gpoDeclararenf.TabIndex = 200
        Me.gpoDeclararenf.TabStop = False
        Me.gpoDeclararenf.Text = "Declarar finalizada una enfermedad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 20)
        Me.Label1.TabIndex = 145
        Me.Label1.Text = "Animal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 146
        Me.Label2.Text = "Fecha:"
        '
        'dateFechaF
        '
        '
        '
        '
        Me.dateFechaF.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dateFechaF.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateFechaF.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dateFechaF.ButtonDropDown.Visible = True
        Me.dateFechaF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFechaF.IsPopupCalendarOpen = False
        Me.dateFechaF.Location = New System.Drawing.Point(221, 125)
        '
        '
        '
        Me.dateFechaF.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dateFechaF.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateFechaF.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dateFechaF.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dateFechaF.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dateFechaF.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dateFechaF.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dateFechaF.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dateFechaF.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dateFechaF.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dateFechaF.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateFechaF.MonthCalendar.DisplayMonth = New Date(2016, 7, 1, 0, 0, 0, 0)
        Me.dateFechaF.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dateFechaF.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dateFechaF.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dateFechaF.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dateFechaF.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dateFechaF.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dateFechaF.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateFechaF.MonthCalendar.TodayButtonVisible = True
        Me.dateFechaF.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dateFechaF.Name = "dateFechaF"
        Me.dateFechaF.Size = New System.Drawing.Size(121, 21)
        Me.dateFechaF.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dateFechaF.TabIndex = 147
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.ButtonX3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonX3.Location = New System.Drawing.Point(31, 168)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(140, 27)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 152
        Me.ButtonX3.Text = "Aceptar"
        Me.ButtonX3.TextColor = System.Drawing.Color.White
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.BackColor = System.Drawing.Color.Firebrick
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.ButtonX4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonX4.Location = New System.Drawing.Point(221, 168)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(140, 27)
        Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX4.TabIndex = 153
        Me.ButtonX4.Text = "Cancelar"
        Me.ButtonX4.TextColor = System.Drawing.Color.White
        '
        'cboAnimal3
        '
        Me.cboAnimal3.DisplayMember = "Text"
        Me.cboAnimal3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAnimal3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnimal3.FormattingEnabled = True
        Me.cboAnimal3.ItemHeight = 15
        Me.cboAnimal3.Location = New System.Drawing.Point(221, 66)
        Me.cboAnimal3.Name = "cboAnimal3"
        Me.cboAnimal3.Size = New System.Drawing.Size(121, 21)
        Me.cboAnimal3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboAnimal3.TabIndex = 158
        '
        'frmContrae
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1370, 772)
        Me.Controls.Add(Me.gpoDeclararenf)
        Me.Controls.Add(Me.lblTratam)
        Me.Controls.Add(Me.gpoEnf)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.SwitchButton1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.gpoTratamiento)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmContrae"
        Me.Text = "Enfermedad"
        CType(Me.dateFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoTratamiento.ResumeLayout(False)
        Me.gpoTratamiento.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoEnf.ResumeLayout(False)
        Me.gpoEnf.PerformLayout()
        Me.gpoDeclararenf.ResumeLayout(False)
        Me.gpoDeclararenf.PerformLayout()
        CType(Me.dateFechaF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboEnf As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblEnf As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCerrar As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents dateFecha As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents lblFechaEnfermedad As System.Windows.Forms.Label
    Friend WithEvents lblAnimal As System.Windows.Forms.Label
    Friend WithEvents cboAnimal As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents gpoTratamiento As System.Windows.Forms.GroupBox
    Friend WithEvents cboAnimal2 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblIDanimal As System.Windows.Forms.Label
    Friend WithEvents lblMedicacion As System.Windows.Forms.Label
    Friend WithEvents cboMedicacion As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents SwitchButton1 As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents gpoEnf As System.Windows.Forms.GroupBox
    Friend WithEvents lblTratam As System.Windows.Forms.Label
    Friend WithEvents cboTratamiento As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblTratamiento As System.Windows.Forms.Label
    Friend WithEvents gpoDeclararenf As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dateFechaF As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cboAnimal3 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
End Class
