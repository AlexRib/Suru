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
        Me.btnCerrar = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.lblServicio = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.radNatural = New System.Windows.Forms.RadioButton()
        Me.radInseminacion = New System.Windows.Forms.RadioButton()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.cboFecha = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.lblVaca = New System.Windows.Forms.Label()
        Me.lblDuracion = New System.Windows.Forms.Label()
        Me.cboDuracion = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.lblToro = New System.Windows.Forms.Label()
        Me.btnRegistrar = New DevComponents.DotNetBar.ButtonX()
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX()
        Me.gpoServicio = New System.Windows.Forms.GroupBox()
        Me.btnModificar = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.cboToro = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.cboVaca = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.gpoBusqueda = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New DevComponents.DotNetBar.ButtonX()
        Me.lblNServicio = New System.Windows.Forms.Label()
        Me.cboBuscar = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        CType(Me.cboFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoServicio.SuspendLayout()
        Me.gpoBusqueda.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnCerrar.Location = New System.Drawing.Point(686, 2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(29, 45)
        Me.btnCerrar.TabIndex = 124
        '
        'lblServicio
        '
        '
        '
        '
        Me.lblServicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblServicio.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicio.Location = New System.Drawing.Point(304, 12)
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(104, 52)
        Me.lblServicio.TabIndex = 125
        Me.lblServicio.Text = "<b><font size=""+6""><i></i><font color=""#B02B2C"">Servicio</font></font></b>"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(215, 169)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(53, 24)
        Me.lblSexo.TabIndex = 79
        Me.lblSexo.Text = "Tipo:"
        '
        'radNatural
        '
        Me.radNatural.AutoSize = True
        Me.radNatural.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNatural.Location = New System.Drawing.Point(316, 160)
        Me.radNatural.Name = "radNatural"
        Me.radNatural.Size = New System.Drawing.Size(73, 22)
        Me.radNatural.TabIndex = 80
        Me.radNatural.TabStop = True
        Me.radNatural.Text = "Natural"
        Me.radNatural.UseVisualStyleBackColor = True
        '
        'radInseminacion
        '
        Me.radInseminacion.AutoSize = True
        Me.radInseminacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radInseminacion.Location = New System.Drawing.Point(316, 188)
        Me.radInseminacion.Name = "radInseminacion"
        Me.radInseminacion.Size = New System.Drawing.Size(166, 22)
        Me.radInseminacion.TabIndex = 81
        Me.radInseminacion.TabStop = True
        Me.radInseminacion.Text = "Inseminacion artificial"
        Me.radInseminacion.UseVisualStyleBackColor = True
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(355, 52)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(139, 20)
        Me.lblFecha.TabIndex = 55
        Me.lblFecha.Text = "Fecha del servicio:"
        '
        'cboFecha
        '
        '
        '
        '
        Me.cboFecha.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.cboFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cboFecha.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.cboFecha.ButtonDropDown.Visible = True
        Me.cboFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFecha.IsPopupCalendarOpen = False
        Me.cboFecha.Location = New System.Drawing.Point(509, 51)
        '
        '
        '
        Me.cboFecha.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.cboFecha.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cboFecha.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.cboFecha.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.cboFecha.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.cboFecha.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.cboFecha.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.cboFecha.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.cboFecha.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.cboFecha.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.cboFecha.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cboFecha.MonthCalendar.DisplayMonth = New Date(2016, 7, 1, 0, 0, 0, 0)
        Me.cboFecha.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.cboFecha.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.cboFecha.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.cboFecha.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.cboFecha.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.cboFecha.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.cboFecha.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cboFecha.MonthCalendar.TodayButtonVisible = True
        Me.cboFecha.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.cboFecha.Name = "cboFecha"
        Me.cboFecha.Size = New System.Drawing.Size(117, 21)
        Me.cboFecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboFecha.TabIndex = 98
        '
        'lblVaca
        '
        Me.lblVaca.AutoSize = True
        Me.lblVaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVaca.Location = New System.Drawing.Point(42, 51)
        Me.lblVaca.Name = "lblVaca"
        Me.lblVaca.Size = New System.Drawing.Size(50, 20)
        Me.lblVaca.TabIndex = 54
        Me.lblVaca.Text = "Vaca:"
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuracion.Location = New System.Drawing.Point(355, 101)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(77, 20)
        Me.lblDuracion.TabIndex = 104
        Me.lblDuracion.Text = "Duración:"
        '
        'cboDuracion
        '
        Me.cboDuracion.DisplayMember = "Text"
        Me.cboDuracion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboDuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDuracion.FormattingEnabled = True
        Me.cboDuracion.ItemHeight = 15
        Me.cboDuracion.Items.AddRange(New Object() {Me.ComboItem4, Me.ComboItem5})
        Me.cboDuracion.Location = New System.Drawing.Point(508, 101)
        Me.cboDuracion.Name = "cboDuracion"
        Me.cboDuracion.Size = New System.Drawing.Size(118, 21)
        Me.cboDuracion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboDuracion.TabIndex = 105
        Me.cboDuracion.WatermarkText = "Ingrese"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Continuo"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "Estacionado"
        '
        'lblToro
        '
        Me.lblToro.AutoSize = True
        Me.lblToro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToro.Location = New System.Drawing.Point(42, 101)
        Me.lblToro.Name = "lblToro"
        Me.lblToro.Size = New System.Drawing.Size(45, 20)
        Me.lblToro.TabIndex = 136
        Me.lblToro.Text = "Toro:"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRegistrar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRegistrar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrar.Location = New System.Drawing.Point(31, 264)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(140, 27)
        Me.btnRegistrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRegistrar.TabIndex = 141
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.TextColor = System.Drawing.Color.White
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminar.BackColor = System.Drawing.Color.Firebrick
        Me.btnEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Location = New System.Drawing.Point(323, 264)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(140, 27)
        Me.btnEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEliminar.TabIndex = 142
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextColor = System.Drawing.Color.White
        '
        'gpoServicio
        '
        Me.gpoServicio.Controls.Add(Me.btnModificar)
        Me.gpoServicio.Controls.Add(Me.btnCancelar)
        Me.gpoServicio.Controls.Add(Me.cboToro)
        Me.gpoServicio.Controls.Add(Me.cboVaca)
        Me.gpoServicio.Controls.Add(Me.btnEliminar)
        Me.gpoServicio.Controls.Add(Me.btnRegistrar)
        Me.gpoServicio.Controls.Add(Me.lblToro)
        Me.gpoServicio.Controls.Add(Me.cboDuracion)
        Me.gpoServicio.Controls.Add(Me.lblDuracion)
        Me.gpoServicio.Controls.Add(Me.lblVaca)
        Me.gpoServicio.Controls.Add(Me.cboFecha)
        Me.gpoServicio.Controls.Add(Me.lblFecha)
        Me.gpoServicio.Controls.Add(Me.radInseminacion)
        Me.gpoServicio.Controls.Add(Me.radNatural)
        Me.gpoServicio.Controls.Add(Me.lblSexo)
        Me.gpoServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpoServicio.Location = New System.Drawing.Point(31, 203)
        Me.gpoServicio.Name = "gpoServicio"
        Me.gpoServicio.Size = New System.Drawing.Size(652, 324)
        Me.gpoServicio.TabIndex = 102
        Me.gpoServicio.TabStop = False
        Me.gpoServicio.Text = "Nuevo Servicio"
        '
        'btnModificar
        '
        Me.btnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModificar.BackColor = System.Drawing.Color.Green
        Me.btnModificar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Location = New System.Drawing.Point(177, 264)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(140, 27)
        Me.btnModificar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnModificar.TabIndex = 146
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextColor = System.Drawing.Color.White
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancelar.BackColor = System.Drawing.Color.Gold
        Me.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Location = New System.Drawing.Point(469, 264)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(140, 27)
        Me.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancelar.TabIndex = 145
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextColor = System.Drawing.Color.White
        '
        'cboToro
        '
        Me.cboToro.DisplayMember = "Text"
        Me.cboToro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboToro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboToro.FormattingEnabled = True
        Me.cboToro.ItemHeight = 15
        Me.cboToro.Items.AddRange(New Object() {Me.ComboItem3, Me.ComboItem6})
        Me.cboToro.Location = New System.Drawing.Point(154, 100)
        Me.cboToro.Name = "cboToro"
        Me.cboToro.Size = New System.Drawing.Size(118, 21)
        Me.cboToro.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboToro.TabIndex = 144
        Me.cboToro.WatermarkText = "Ingrese"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Continuo"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "Estacionado"
        '
        'cboVaca
        '
        Me.cboVaca.DisplayMember = "Text"
        Me.cboVaca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboVaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVaca.FormattingEnabled = True
        Me.cboVaca.ItemHeight = 15
        Me.cboVaca.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2})
        Me.cboVaca.Location = New System.Drawing.Point(154, 51)
        Me.cboVaca.Name = "cboVaca"
        Me.cboVaca.Size = New System.Drawing.Size(118, 21)
        Me.cboVaca.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboVaca.TabIndex = 143
        Me.cboVaca.WatermarkText = "Ingrese"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Continuo"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Estacionado"
        '
        'gpoBusqueda
        '
        Me.gpoBusqueda.Controls.Add(Me.cboBuscar)
        Me.gpoBusqueda.Controls.Add(Me.btnBuscar)
        Me.gpoBusqueda.Controls.Add(Me.lblNServicio)
        Me.gpoBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpoBusqueda.Location = New System.Drawing.Point(148, 81)
        Me.gpoBusqueda.Name = "gpoBusqueda"
        Me.gpoBusqueda.Size = New System.Drawing.Size(429, 96)
        Me.gpoBusqueda.TabIndex = 126
        Me.gpoBusqueda.TabStop = False
        Me.gpoBusqueda.Text = "Búsqueda"
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
        'lblNServicio
        '
        Me.lblNServicio.AutoSize = True
        Me.lblNServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNServicio.Location = New System.Drawing.Point(23, 40)
        Me.lblNServicio.Name = "lblNServicio"
        Me.lblNServicio.Size = New System.Drawing.Size(98, 20)
        Me.lblNServicio.TabIndex = 12
        Me.lblNServicio.Text = "N° Servicio:"
        '
        'cboBuscar
        '
        Me.cboBuscar.DisplayMember = "Text"
        Me.cboBuscar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBuscar.FormattingEnabled = True
        Me.cboBuscar.ItemHeight = 20
        Me.cboBuscar.Location = New System.Drawing.Point(156, 40)
        Me.cboBuscar.Name = "cboBuscar"
        Me.cboBuscar.Size = New System.Drawing.Size(117, 26)
        Me.cboBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboBuscar.TabIndex = 173
        Me.cboBuscar.WatermarkText = "Seleccione"
        '
        'frmServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 541)
        Me.Controls.Add(Me.gpoBusqueda)
        Me.Controls.Add(Me.lblServicio)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.gpoServicio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servicios"
        CType(Me.cboFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoServicio.ResumeLayout(False)
        Me.gpoServicio.PerformLayout()
        Me.gpoBusqueda.ResumeLayout(False)
        Me.gpoBusqueda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCerrar As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents lblServicio As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents radNatural As System.Windows.Forms.RadioButton
    Friend WithEvents radInseminacion As System.Windows.Forms.RadioButton
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents cboFecha As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents lblVaca As System.Windows.Forms.Label
    Friend WithEvents lblDuracion As System.Windows.Forms.Label
    Friend WithEvents cboDuracion As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents lblToro As System.Windows.Forms.Label
    Friend WithEvents btnRegistrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gpoServicio As System.Windows.Forms.GroupBox
    Friend WithEvents cboToro As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents cboVaca As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents gpoBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblNServicio As System.Windows.Forms.Label
    Friend WithEvents btnModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cboBuscar As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
