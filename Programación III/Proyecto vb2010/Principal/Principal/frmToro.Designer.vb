<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmToro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmToro))
        Me.gpoBusqueda = New System.Windows.Forms.GroupBox()
        Me.cboBuscar = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btnBuscar = New DevComponents.DotNetBar.ButtonX()
        Me.lblToro = New System.Windows.Forms.Label()
        Me.dateNacimiento = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblRaza = New System.Windows.Forms.Label()
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX()
        Me.btnCrear = New DevComponents.DotNetBar.ButtonX()
        Me.btnModificar = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.cboRaza = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.cboTipo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtma = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblList = New System.Windows.Forms.Label()
        Me.btnCerrar = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.txtFIltrar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.gpoDatos = New System.Windows.Forms.GroupBox()
        Me.gpoBusqueda.SuspendLayout()
        CType(Me.dateNacimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpoBusqueda
        '
        Me.gpoBusqueda.Controls.Add(Me.cboBuscar)
        Me.gpoBusqueda.Controls.Add(Me.btnBuscar)
        Me.gpoBusqueda.Controls.Add(Me.lblToro)
        Me.gpoBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpoBusqueda.Location = New System.Drawing.Point(175, 28)
        Me.gpoBusqueda.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpoBusqueda.Name = "gpoBusqueda"
        Me.gpoBusqueda.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gpoBusqueda.Size = New System.Drawing.Size(526, 104)
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
        Me.cboBuscar.Location = New System.Drawing.Point(193, 58)
        Me.cboBuscar.Name = "cboBuscar"
        Me.cboBuscar.Size = New System.Drawing.Size(117, 26)
        Me.cboBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboBuscar.TabIndex = 172
        Me.cboBuscar.WatermarkText = "Seleccione"
        '
        'btnBuscar
        '
        Me.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(374, 49)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(112, 35)
        Me.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBuscar.TabIndex = 122
        Me.btnBuscar.Text = "Buscar"
        '
        'lblToro
        '
        Me.lblToro.AutoSize = True
        Me.lblToro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToro.Location = New System.Drawing.Point(58, 64)
        Me.lblToro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblToro.Name = "lblToro"
        Me.lblToro.Size = New System.Drawing.Size(45, 20)
        Me.lblToro.TabIndex = 12
        Me.lblToro.Text = "Toro:"
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
        Me.dateNacimiento.Location = New System.Drawing.Point(543, 74)
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
        Me.dateNacimiento.Size = New System.Drawing.Size(154, 26)
        Me.dateNacimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dateNacimiento.TabIndex = 114
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(404, 159)
        Me.lblTipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(43, 20)
        Me.lblTipo.TabIndex = 108
        Me.lblTipo.Text = "Tipo:"
        '
        'lblNacimiento
        '
        Me.lblNacimiento.AutoSize = True
        Me.lblNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacimiento.Location = New System.Drawing.Point(401, 76)
        Me.lblNacimiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(92, 20)
        Me.lblNacimiento.TabIndex = 105
        Me.lblNacimiento.Text = "Nacimiento:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(7, 76)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(69, 20)
        Me.lblNombre.TabIndex = 102
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        '
        '
        '
        Me.txtNombre.Border.Class = "TextBoxBorder"
        Me.txtNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNombre.Location = New System.Drawing.Point(148, 74)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(150, 26)
        Me.txtNombre.TabIndex = 118
        '
        'lblRaza
        '
        Me.lblRaza.AutoSize = True
        Me.lblRaza.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaza.Location = New System.Drawing.Point(9, 163)
        Me.lblRaza.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRaza.Name = "lblRaza"
        Me.lblRaza.Size = New System.Drawing.Size(51, 20)
        Me.lblRaza.TabIndex = 121
        Me.lblRaza.Text = "Raza:"
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminar.BackColor = System.Drawing.Color.Firebrick
        Me.btnEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Location = New System.Drawing.Point(380, 284)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(140, 27)
        Me.btnEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnEliminar.TabIndex = 141
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextColor = System.Drawing.Color.White
        '
        'btnCrear
        '
        Me.btnCrear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCrear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCrear.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCrear.Location = New System.Drawing.Point(52, 284)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(140, 27)
        Me.btnCrear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCrear.TabIndex = 140
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.TextColor = System.Drawing.Color.White
        '
        'btnModificar
        '
        Me.btnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModificar.BackColor = System.Drawing.Color.Green
        Me.btnModificar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Location = New System.Drawing.Point(218, 284)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(140, 27)
        Me.btnModificar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnModificar.TabIndex = 166
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextColor = System.Drawing.Color.White
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancelar.BackColor = System.Drawing.Color.Gold
        Me.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Location = New System.Drawing.Point(543, 284)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(140, 27)
        Me.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancelar.TabIndex = 165
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextColor = System.Drawing.Color.White
        '
        'cboRaza
        '
        Me.cboRaza.DisplayMember = "Text"
        Me.cboRaza.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboRaza.FormattingEnabled = True
        Me.cboRaza.ItemHeight = 20
        Me.cboRaza.Items.AddRange(New Object() {Me.ComboItem5, Me.ComboItem6, Me.ComboItem7})
        Me.cboRaza.Location = New System.Drawing.Point(148, 153)
        Me.cboRaza.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboRaza.Name = "cboRaza"
        Me.cboRaza.Size = New System.Drawing.Size(175, 26)
        Me.cboRaza.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboRaza.TabIndex = 167
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
        'cboTipo
        '
        Me.cboTipo.DisplayMember = "Text"
        Me.cboTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.ItemHeight = 20
        Me.cboTipo.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3})
        Me.cboTipo.Location = New System.Drawing.Point(538, 153)
        Me.cboTipo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(159, 26)
        Me.cboTipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboTipo.TabIndex = 168
        Me.cboTipo.WatermarkText = "Ingrese"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Novillo"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Toro"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Adluto"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(818, 86)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(466, 272)
        Me.DataGridView1.TabIndex = 170
        '
        'txtma
        '
        '
        '
        '
        Me.txtma.Border.Class = "TextBoxBorder"
        Me.txtma.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtma.Location = New System.Drawing.Point(538, 201)
        Me.txtma.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtma.Name = "txtma"
        Me.txtma.Size = New System.Drawing.Size(150, 26)
        Me.txtma.TabIndex = 171
        Me.txtma.Text = "Macho"
        Me.txtma.Visible = False
        '
        'lblList
        '
        Me.lblList.AutoSize = True
        Me.lblList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblList.Location = New System.Drawing.Point(994, 9)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(142, 24)
        Me.lblList.TabIndex = 172
        Me.lblList.Text = "Listado de toros"
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
        Me.btnCerrar.Location = New System.Drawing.Point(1295, -4)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(44, 69)
        Me.btnCerrar.TabIndex = 128
        '
        'txtFIltrar
        '
        '
        '
        '
        Me.txtFIltrar.Border.Class = "TextBoxBorder"
        Me.txtFIltrar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFIltrar.Location = New System.Drawing.Point(946, 52)
        Me.txtFIltrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFIltrar.Name = "txtFIltrar"
        Me.txtFIltrar.Size = New System.Drawing.Size(150, 26)
        Me.txtFIltrar.TabIndex = 174
        '
        'gpoDatos
        '
        Me.gpoDatos.Controls.Add(Me.lblNombre)
        Me.gpoDatos.Controls.Add(Me.lblNacimiento)
        Me.gpoDatos.Controls.Add(Me.lblTipo)
        Me.gpoDatos.Controls.Add(Me.txtma)
        Me.gpoDatos.Controls.Add(Me.dateNacimiento)
        Me.gpoDatos.Controls.Add(Me.txtNombre)
        Me.gpoDatos.Controls.Add(Me.cboTipo)
        Me.gpoDatos.Controls.Add(Me.lblRaza)
        Me.gpoDatos.Controls.Add(Me.cboRaza)
        Me.gpoDatos.Controls.Add(Me.btnCrear)
        Me.gpoDatos.Controls.Add(Me.btnModificar)
        Me.gpoDatos.Controls.Add(Me.btnEliminar)
        Me.gpoDatos.Controls.Add(Me.btnCancelar)
        Me.gpoDatos.Location = New System.Drawing.Point(57, 173)
        Me.gpoDatos.Name = "gpoDatos"
        Me.gpoDatos.Size = New System.Drawing.Size(730, 384)
        Me.gpoDatos.TabIndex = 175
        Me.gpoDatos.TabStop = False
        Me.gpoDatos.Text = "Datos"
        '
        'frmToro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1362, 674)
        Me.Controls.Add(Me.gpoDatos)
        Me.Controls.Add(Me.txtFIltrar)
        Me.Controls.Add(Me.lblList)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.gpoBusqueda)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmToro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Toros"
        Me.gpoBusqueda.ResumeLayout(False)
        Me.gpoBusqueda.PerformLayout()
        CType(Me.dateNacimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoDatos.ResumeLayout(False)
        Me.gpoDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gpoBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents lblToro As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dateNacimiento As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents lblNacimiento As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblRaza As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCrear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cboBuscar As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboRaza As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents cboTipo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtma As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblList As System.Windows.Forms.Label
    Friend WithEvents txtFIltrar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents gpoDatos As System.Windows.Forms.GroupBox
End Class
