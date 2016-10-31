<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVaca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVaca))
        Me.gpoBusqueda = New System.Windows.Forms.GroupBox()
        Me.cboBuscar = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btnBuscar = New DevComponents.DotNetBar.ButtonX()
        Me.lblVaca = New System.Windows.Forms.Label()
        Me.cboRaza = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.lblRaza = New System.Windows.Forms.Label()
        Me.txtNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX()
        Me.btnCrear = New DevComponents.DotNetBar.ButtonX()
        Me.cboTipo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.ComboItem9 = New DevComponents.Editors.ComboItem()
        Me.ComboItem10 = New DevComponents.Editors.ComboItem()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.btnModificar = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.dateNacimiento = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblList = New System.Windows.Forms.Label()
        Me.btnCerrar = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.gpoDatos = New System.Windows.Forms.GroupBox()
        Me.gpoBusqueda.SuspendLayout()
        CType(Me.dateNacimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpoBusqueda
        '
        Me.gpoBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.gpoBusqueda.Controls.Add(Me.cboBuscar)
        Me.gpoBusqueda.Controls.Add(Me.btnBuscar)
        Me.gpoBusqueda.Controls.Add(Me.lblVaca)
        Me.gpoBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpoBusqueda.ForeColor = System.Drawing.Color.White
        Me.gpoBusqueda.Location = New System.Drawing.Point(134, 23)
        Me.gpoBusqueda.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpoBusqueda.Name = "gpoBusqueda"
        Me.gpoBusqueda.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpoBusqueda.Size = New System.Drawing.Size(526, 136)
        Me.gpoBusqueda.TabIndex = 136
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
        Me.cboBuscar.Location = New System.Drawing.Point(188, 64)
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
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(367, 60)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(112, 35)
        Me.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBuscar.TabIndex = 122
        Me.btnBuscar.Text = "Buscar"
        '
        'lblVaca
        '
        Me.lblVaca.AutoSize = True
        Me.lblVaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVaca.Location = New System.Drawing.Point(58, 64)
        Me.lblVaca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVaca.Name = "lblVaca"
        Me.lblVaca.Size = New System.Drawing.Size(50, 20)
        Me.lblVaca.TabIndex = 12
        Me.lblVaca.Text = "Vaca:"
        '
        'cboRaza
        '
        Me.cboRaza.DisplayMember = "Text"
        Me.cboRaza.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboRaza.FormattingEnabled = True
        Me.cboRaza.ItemHeight = 20
        Me.cboRaza.Items.AddRange(New Object() {Me.ComboItem5, Me.ComboItem6, Me.ComboItem7})
        Me.cboRaza.Location = New System.Drawing.Point(154, 112)
        Me.cboRaza.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboRaza.Name = "cboRaza"
        Me.cboRaza.Size = New System.Drawing.Size(175, 26)
        Me.cboRaza.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboRaza.TabIndex = 149
        Me.cboRaza.WatermarkText = "Ingrese"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "Horlando"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "Jersey"
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "Primer show"
        '
        'lblRaza
        '
        Me.lblRaza.AutoSize = True
        Me.lblRaza.BackColor = System.Drawing.Color.Transparent
        Me.lblRaza.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaza.ForeColor = System.Drawing.Color.White
        Me.lblRaza.Location = New System.Drawing.Point(15, 113)
        Me.lblRaza.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(47, 20)
        Me.lblRaza.TabIndex = 148
        Me.lblRaza.Text = "Raza"
        '
        'txtNombre
        '
        '
        '
        '
        Me.txtNombre.Border.Class = "TextBoxBorder"
        Me.txtNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNombre.Location = New System.Drawing.Point(157, 49)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(172, 20)
        Me.txtNombre.TabIndex = 145
        '
        'lblNacimiento
        '
        Me.lblNacimiento.AutoSize = True
        Me.lblNacimiento.BackColor = System.Drawing.Color.Transparent
        Me.lblNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacimiento.ForeColor = System.Drawing.Color.White
        Me.lblNacimiento.Location = New System.Drawing.Point(375, 115)
        Me.lblNacimiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(92, 20)
        Me.lblNacimiento.TabIndex = 139
        Me.lblNacimiento.Text = "Nacimiento:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(16, 51)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(69, 20)
        Me.lblNombre.TabIndex = 137
        Me.lblNombre.Text = "Nombre:"
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminar.BackColor = System.Drawing.Color.Firebrick
        Me.btnEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Location = New System.Drawing.Point(370, 224)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(140, 27)
        Me.btnEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEliminar.TabIndex = 156
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextColor = System.Drawing.Color.White
        '
        'btnCrear
        '
        Me.btnCrear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCrear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCrear.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCrear.Location = New System.Drawing.Point(68, 224)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(140, 27)
        Me.btnCrear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCrear.TabIndex = 155
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.TextColor = System.Drawing.Color.White
        '
        'cboTipo
        '
        Me.cboTipo.DisplayMember = "Text"
        Me.cboTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.ItemHeight = 20
        Me.cboTipo.Items.AddRange(New Object() {Me.ComboItem8, Me.ComboItem9, Me.ComboItem10})
        Me.cboTipo.Location = New System.Drawing.Point(531, 46)
        Me.cboTipo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(154, 26)
        Me.cboTipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboTipo.TabIndex = 158
        Me.cboTipo.WatermarkText = "Ingrese"
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "Vaquillona"
        '
        'ComboItem9
        '
        Me.ComboItem9.Text = "Vaca"
        '
        'ComboItem10
        '
        Me.ComboItem10.Text = "Vaca adulta"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.BackColor = System.Drawing.Color.Transparent
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.White
        Me.lblTipo.Location = New System.Drawing.Point(375, 46)
        Me.lblTipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(39, 20)
        Me.lblTipo.TabIndex = 157
        Me.lblTipo.Text = "Tipo"
        '
        'btnModificar
        '
        Me.btnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModificar.BackColor = System.Drawing.Color.Green
        Me.btnModificar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Location = New System.Drawing.Point(214, 224)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(140, 27)
        Me.btnModificar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnModificar.TabIndex = 164
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextColor = System.Drawing.Color.White
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancelar.BackColor = System.Drawing.Color.Gold
        Me.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Location = New System.Drawing.Point(525, 224)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(140, 27)
        Me.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancelar.TabIndex = 163
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextColor = System.Drawing.Color.White
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
        Me.dateNacimiento.IsPopupCalendarOpen = False
        Me.dateNacimiento.Location = New System.Drawing.Point(531, 115)
        Me.dateNacimiento.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
        Me.dateNacimiento.Size = New System.Drawing.Size(154, 20)
        Me.dateNacimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dateNacimiento.TabIndex = 165
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(757, 102)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(567, 272)
        Me.DataGridView1.TabIndex = 169
        '
        'lblList
        '
        Me.lblList.AutoSize = True
        Me.lblList.BackColor = System.Drawing.Color.Transparent
        Me.lblList.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblList.ForeColor = System.Drawing.Color.White
        Me.lblList.Location = New System.Drawing.Point(956, 40)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(175, 25)
        Me.lblList.TabIndex = 171
        Me.lblList.Text = "Listado de vacas"
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
        Me.btnCerrar.Location = New System.Drawing.Point(1337, 2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(29, 45)
        Me.btnCerrar.TabIndex = 135
        '
        'gpoDatos
        '
        Me.gpoDatos.BackColor = System.Drawing.Color.Transparent
        Me.gpoDatos.Controls.Add(Me.lblNombre)
        Me.gpoDatos.Controls.Add(Me.lblNacimiento)
        Me.gpoDatos.Controls.Add(Me.txtNombre)
        Me.gpoDatos.Controls.Add(Me.dateNacimiento)
        Me.gpoDatos.Controls.Add(Me.lblRaza)
        Me.gpoDatos.Controls.Add(Me.btnModificar)
        Me.gpoDatos.Controls.Add(Me.cboRaza)
        Me.gpoDatos.Controls.Add(Me.btnCancelar)
        Me.gpoDatos.Controls.Add(Me.btnCrear)
        Me.gpoDatos.Controls.Add(Me.cboTipo)
        Me.gpoDatos.Controls.Add(Me.btnEliminar)
        Me.gpoDatos.Controls.Add(Me.lblTipo)
        Me.gpoDatos.ForeColor = System.Drawing.Color.White
        Me.gpoDatos.Location = New System.Drawing.Point(34, 205)
        Me.gpoDatos.Name = "gpoDatos"
        Me.gpoDatos.Size = New System.Drawing.Size(699, 298)
        Me.gpoDatos.TabIndex = 172
        Me.gpoDatos.TabStop = False
        Me.gpoDatos.Text = "Datos"
        '
        'frmVaca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 685)
        Me.Controls.Add(Me.gpoDatos)
        Me.Controls.Add(Me.lblList)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.gpoBusqueda)
        Me.Controls.Add(Me.btnCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVaca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vacas"
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.gpoBusqueda.ResumeLayout(False)
        Me.gpoBusqueda.PerformLayout()
        CType(Me.dateNacimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoDatos.ResumeLayout(False)
        Me.gpoDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCerrar As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents gpoBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblVaca As System.Windows.Forms.Label
    Friend WithEvents cboRaza As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents lblRaza As System.Windows.Forms.Label
    Friend WithEvents txtNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblNacimiento As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCrear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cboTipo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem10 As DevComponents.Editors.ComboItem
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents btnModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dateNacimiento As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents cboBuscar As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblList As System.Windows.Forms.Label
    Friend WithEvents gpoDatos As System.Windows.Forms.GroupBox
End Class
