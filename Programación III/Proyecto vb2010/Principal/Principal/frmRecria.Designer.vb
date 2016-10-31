<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecria
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
        Me.txtRecria = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.gpoAniadir = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.lblUbicacion = New System.Windows.Forms.Label()
        Me.txtUbicacion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnCrear = New DevComponents.DotNetBar.ButtonX()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cboBuscar = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX()
        Me.lblNombre2 = New System.Windows.Forms.Label()
        Me.lblListado = New System.Windows.Forms.Label()
        Me.gpoEliminar = New System.Windows.Forms.GroupBox()
        Me.gpoRecria = New System.Windows.Forms.GroupBox()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.dateFecha = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.btnIngresar = New DevComponents.DotNetBar.ButtonX()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblRecria = New System.Windows.Forms.Label()
        Me.cboRecria = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblCria = New System.Windows.Forms.Label()
        Me.cboCria = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblListado2 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.gpoCamporecria = New System.Windows.Forms.GroupBox()
        Me.gpoGrilla = New System.Windows.Forms.GroupBox()
        Me.gpoAniadir.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoEliminar.SuspendLayout()
        Me.gpoRecria.SuspendLayout()
        CType(Me.dateFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoCamporecria.SuspendLayout()
        Me.gpoGrilla.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtRecria
        '
        '
        '
        '
        Me.txtRecria.Border.Class = "TextBoxBorder"
        Me.txtRecria.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtRecria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecria.Location = New System.Drawing.Point(211, 38)
        Me.txtRecria.Name = "txtRecria"
        Me.txtRecria.Size = New System.Drawing.Size(100, 26)
        Me.txtRecria.TabIndex = 103
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(81, 38)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(69, 20)
        Me.lblNombre.TabIndex = 102
        Me.lblNombre.Text = "Nombre:"
        '
        'gpoAniadir
        '
        Me.gpoAniadir.Controls.Add(Me.btnCancelar)
        Me.gpoAniadir.Controls.Add(Me.lblUbicacion)
        Me.gpoAniadir.Controls.Add(Me.txtUbicacion)
        Me.gpoAniadir.Controls.Add(Me.btnCrear)
        Me.gpoAniadir.Controls.Add(Me.lblNombre)
        Me.gpoAniadir.Controls.Add(Me.txtRecria)
        Me.gpoAniadir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpoAniadir.Location = New System.Drawing.Point(18, 34)
        Me.gpoAniadir.Name = "gpoAniadir"
        Me.gpoAniadir.Size = New System.Drawing.Size(377, 187)
        Me.gpoAniadir.TabIndex = 104
        Me.gpoAniadir.TabStop = False
        Me.gpoAniadir.Text = "Añadir"
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancelar.BackColor = System.Drawing.Color.Gold
        Me.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Location = New System.Drawing.Point(215, 142)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(96, 27)
        Me.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancelar.TabIndex = 182
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextColor = System.Drawing.Color.White
        '
        'lblUbicacion
        '
        Me.lblUbicacion.AutoSize = True
        Me.lblUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUbicacion.Location = New System.Drawing.Point(81, 86)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(83, 20)
        Me.lblUbicacion.TabIndex = 180
        Me.lblUbicacion.Text = "Ubicacion:"
        '
        'txtUbicacion
        '
        '
        '
        '
        Me.txtUbicacion.Border.Class = "TextBoxBorder"
        Me.txtUbicacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUbicacion.Location = New System.Drawing.Point(211, 87)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(100, 26)
        Me.txtUbicacion.TabIndex = 181
        '
        'btnCrear
        '
        Me.btnCrear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCrear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCrear.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCrear.Location = New System.Drawing.Point(86, 142)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(96, 27)
        Me.btnCrear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCrear.TabIndex = 175
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.TextColor = System.Drawing.Color.White
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(35, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(311, 105)
        Me.DataGridView1.TabIndex = 105
        '
        'cboBuscar
        '
        Me.cboBuscar.DisplayMember = "Text"
        Me.cboBuscar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBuscar.FormattingEnabled = True
        Me.cboBuscar.ItemHeight = 20
        Me.cboBuscar.Location = New System.Drawing.Point(114, 43)
        Me.cboBuscar.Name = "cboBuscar"
        Me.cboBuscar.Size = New System.Drawing.Size(133, 26)
        Me.cboBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboBuscar.TabIndex = 178
        Me.cboBuscar.WatermarkText = "Seleccione"
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
        'lblNombre2
        '
        Me.lblNombre2.AutoSize = True
        Me.lblNombre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre2.Location = New System.Drawing.Point(17, 45)
        Me.lblNombre2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre2.Name = "lblNombre2"
        Me.lblNombre2.Size = New System.Drawing.Size(69, 20)
        Me.lblNombre2.TabIndex = 177
        Me.lblNombre2.Text = "Nombre:"
        '
        'lblListado
        '
        Me.lblListado.AutoSize = True
        Me.lblListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListado.Location = New System.Drawing.Point(113, 22)
        Me.lblListado.Name = "lblListado"
        Me.lblListado.Size = New System.Drawing.Size(137, 20)
        Me.lblListado.TabIndex = 106
        Me.lblListado.Text = "Campos de recría:"
        '
        'gpoEliminar
        '
        Me.gpoEliminar.Controls.Add(Me.lblNombre2)
        Me.gpoEliminar.Controls.Add(Me.cboBuscar)
        Me.gpoEliminar.Controls.Add(Me.btnEliminar)
        Me.gpoEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpoEliminar.Location = New System.Drawing.Point(18, 256)
        Me.gpoEliminar.Name = "gpoEliminar"
        Me.gpoEliminar.Size = New System.Drawing.Size(377, 95)
        Me.gpoEliminar.TabIndex = 180
        Me.gpoEliminar.TabStop = False
        Me.gpoEliminar.Text = "Eliminar"
        '
        'gpoRecria
        '
        Me.gpoRecria.Controls.Add(Me.ButtonX1)
        Me.gpoRecria.Controls.Add(Me.dateFecha)
        Me.gpoRecria.Controls.Add(Me.btnIngresar)
        Me.gpoRecria.Controls.Add(Me.lblFecha)
        Me.gpoRecria.Controls.Add(Me.lblRecria)
        Me.gpoRecria.Controls.Add(Me.cboRecria)
        Me.gpoRecria.Controls.Add(Me.lblCria)
        Me.gpoRecria.Controls.Add(Me.cboCria)
        Me.gpoRecria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpoRecria.Location = New System.Drawing.Point(892, 60)
        Me.gpoRecria.Name = "gpoRecria"
        Me.gpoRecria.Size = New System.Drawing.Size(368, 299)
        Me.gpoRecria.TabIndex = 181
        Me.gpoRecria.TabStop = False
        Me.gpoRecria.Text = "Asignar cría a campo de recría"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.BackColor = System.Drawing.Color.Gold
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.ButtonX1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonX1.Location = New System.Drawing.Point(193, 244)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(117, 25)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 186
        Me.ButtonX1.Text = "Cancelar"
        Me.ButtonX1.TextColor = System.Drawing.Color.White
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
        Me.dateFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFecha.IsPopupCalendarOpen = False
        Me.dateFecha.Location = New System.Drawing.Point(193, 167)
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
        Me.dateFecha.Size = New System.Drawing.Size(117, 26)
        Me.dateFecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dateFecha.TabIndex = 184
        '
        'btnIngresar
        '
        Me.btnIngresar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnIngresar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnIngresar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngresar.Location = New System.Drawing.Point(58, 244)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(117, 25)
        Me.btnIngresar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnIngresar.TabIndex = 185
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.TextColor = System.Drawing.Color.White
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(28, 167)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(58, 20)
        Me.lblFecha.TabIndex = 183
        Me.lblFecha.Text = "Fecha:"
        '
        'lblRecria
        '
        Me.lblRecria.AutoSize = True
        Me.lblRecria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecria.Location = New System.Drawing.Point(28, 99)
        Me.lblRecria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRecria.Name = "lblRecria"
        Me.lblRecria.Size = New System.Drawing.Size(129, 20)
        Me.lblRecria.TabIndex = 181
        Me.lblRecria.Text = "Campo de recria:"
        '
        'cboRecria
        '
        Me.cboRecria.DisplayMember = "Text"
        Me.cboRecria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboRecria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRecria.FormattingEnabled = True
        Me.cboRecria.ItemHeight = 20
        Me.cboRecria.Location = New System.Drawing.Point(193, 99)
        Me.cboRecria.Name = "cboRecria"
        Me.cboRecria.Size = New System.Drawing.Size(117, 26)
        Me.cboRecria.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboRecria.TabIndex = 182
        Me.cboRecria.WatermarkText = "Seleccione"
        '
        'lblCria
        '
        Me.lblCria.AutoSize = True
        Me.lblCria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCria.Location = New System.Drawing.Point(28, 40)
        Me.lblCria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCria.Name = "lblCria"
        Me.lblCria.Size = New System.Drawing.Size(41, 20)
        Me.lblCria.TabIndex = 179
        Me.lblCria.Text = "Cría:"
        '
        'cboCria
        '
        Me.cboCria.DisplayMember = "Text"
        Me.cboCria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCria.FormattingEnabled = True
        Me.cboCria.ItemHeight = 20
        Me.cboCria.Location = New System.Drawing.Point(193, 40)
        Me.cboCria.Name = "cboCria"
        Me.cboCria.Size = New System.Drawing.Size(117, 26)
        Me.cboCria.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboCria.TabIndex = 180
        Me.cboCria.WatermarkText = "Seleccione"
        '
        'lblListado2
        '
        Me.lblListado2.AutoSize = True
        Me.lblListado2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListado2.Location = New System.Drawing.Point(88, 189)
        Me.lblListado2.Name = "lblListado2"
        Me.lblListado2.Size = New System.Drawing.Size(188, 20)
        Me.lblListado2.TabIndex = 183
        Me.lblListado2.Text = "Crías en campo de recría:"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(35, 216)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(311, 123)
        Me.DataGridView2.TabIndex = 182
        '
        'gpoCamporecria
        '
        Me.gpoCamporecria.Controls.Add(Me.gpoAniadir)
        Me.gpoCamporecria.Controls.Add(Me.gpoEliminar)
        Me.gpoCamporecria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpoCamporecria.Location = New System.Drawing.Point(24, 48)
        Me.gpoCamporecria.Name = "gpoCamporecria"
        Me.gpoCamporecria.Size = New System.Drawing.Size(414, 378)
        Me.gpoCamporecria.TabIndex = 184
        Me.gpoCamporecria.TabStop = False
        Me.gpoCamporecria.Text = "Campos de recría"
        '
        'gpoGrilla
        '
        Me.gpoGrilla.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gpoGrilla.Controls.Add(Me.lblListado)
        Me.gpoGrilla.Controls.Add(Me.DataGridView1)
        Me.gpoGrilla.Controls.Add(Me.lblListado2)
        Me.gpoGrilla.Controls.Add(Me.DataGridView2)
        Me.gpoGrilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpoGrilla.Location = New System.Drawing.Point(475, 60)
        Me.gpoGrilla.Name = "gpoGrilla"
        Me.gpoGrilla.Size = New System.Drawing.Size(376, 366)
        Me.gpoGrilla.TabIndex = 185
        Me.gpoGrilla.TabStop = False
        Me.gpoGrilla.Text = "Listados"
        '
        'frmRecria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1323, 673)
        Me.Controls.Add(Me.gpoGrilla)
        Me.Controls.Add(Me.gpoCamporecria)
        Me.Controls.Add(Me.gpoRecria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRecria"
        Me.Text = "Campo de recrías"
        Me.gpoAniadir.ResumeLayout(False)
        Me.gpoAniadir.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoEliminar.ResumeLayout(False)
        Me.gpoEliminar.PerformLayout()
        Me.gpoRecria.ResumeLayout(False)
        Me.gpoRecria.PerformLayout()
        CType(Me.dateFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoCamporecria.ResumeLayout(False)
        Me.gpoGrilla.ResumeLayout(False)
        Me.gpoGrilla.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtRecria As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents gpoAniadir As System.Windows.Forms.GroupBox
    Friend WithEvents btnCrear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cboBuscar As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblNombre2 As System.Windows.Forms.Label
    Friend WithEvents lblListado As System.Windows.Forms.Label
    Friend WithEvents lblUbicacion As System.Windows.Forms.Label
    Friend WithEvents txtUbicacion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents gpoEliminar As System.Windows.Forms.GroupBox
    Friend WithEvents gpoRecria As System.Windows.Forms.GroupBox
    Friend WithEvents lblRecria As System.Windows.Forms.Label
    Friend WithEvents cboRecria As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblCria As System.Windows.Forms.Label
    Friend WithEvents cboCria As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents dateFecha As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents btnIngresar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblListado2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents gpoCamporecria As System.Windows.Forms.GroupBox
    Friend WithEvents gpoGrilla As System.Windows.Forms.GroupBox
End Class
