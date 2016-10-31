<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVictima
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
        Me.cboID = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.dateMuerte = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.cboCausa = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.lblCausa = New System.Windows.Forms.Label()
        Me.btnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.btnRegistrar = New DevComponents.DotNetBar.ButtonX()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.cboTipo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.gpoVictima = New System.Windows.Forms.GroupBox()
        Me.lblList = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.dateMuerte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoVictima.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboID
        '
        Me.cboID.DisplayMember = "Text"
        Me.cboID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboID.FormattingEnabled = True
        Me.cboID.ItemHeight = 20
        Me.cboID.Location = New System.Drawing.Point(211, 115)
        Me.cboID.Name = "cboID"
        Me.cboID.Size = New System.Drawing.Size(154, 26)
        Me.cboID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboID.TabIndex = 174
        Me.cboID.WatermarkText = "Seleccione"
        '
        'dateMuerte
        '
        '
        '
        '
        Me.dateMuerte.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dateMuerte.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateMuerte.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dateMuerte.ButtonDropDown.Visible = True
        Me.dateMuerte.IsPopupCalendarOpen = False
        Me.dateMuerte.Location = New System.Drawing.Point(211, 171)
        Me.dateMuerte.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        '
        '
        '
        Me.dateMuerte.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dateMuerte.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateMuerte.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dateMuerte.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dateMuerte.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dateMuerte.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dateMuerte.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dateMuerte.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dateMuerte.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dateMuerte.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dateMuerte.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateMuerte.MonthCalendar.DisplayMonth = New Date(2016, 7, 1, 0, 0, 0, 0)
        Me.dateMuerte.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dateMuerte.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dateMuerte.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dateMuerte.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dateMuerte.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dateMuerte.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dateMuerte.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateMuerte.MonthCalendar.TodayButtonVisible = True
        Me.dateMuerte.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dateMuerte.Name = "dateMuerte"
        Me.dateMuerte.Size = New System.Drawing.Size(154, 29)
        Me.dateMuerte.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dateMuerte.TabIndex = 176
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(49, 171)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(150, 20)
        Me.lblFecha.TabIndex = 175
        Me.lblFecha.Text = "Fecha de la muerte:"
        '
        'cboCausa
        '
        Me.cboCausa.DisplayMember = "Text"
        Me.cboCausa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCausa.FormattingEnabled = True
        Me.cboCausa.ItemHeight = 23
        Me.cboCausa.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4, Me.ComboItem5})
        Me.cboCausa.Location = New System.Drawing.Point(211, 221)
        Me.cboCausa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboCausa.Name = "cboCausa"
        Me.cboCausa.Size = New System.Drawing.Size(154, 29)
        Me.cboCausa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboCausa.TabIndex = 178
        Me.cboCausa.WatermarkText = "Ingrese"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Accidente"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Leucosis"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Intoxicacion"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Parto"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "Desconocida"
        '
        'lblCausa
        '
        Me.lblCausa.AutoSize = True
        Me.lblCausa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCausa.Location = New System.Drawing.Point(49, 227)
        Me.lblCausa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCausa.Name = "lblCausa"
        Me.lblCausa.Size = New System.Drawing.Size(59, 20)
        Me.lblCausa.TabIndex = 177
        Me.lblCausa.Text = "Causa:"
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancelar.BackColor = System.Drawing.Color.Gold
        Me.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Location = New System.Drawing.Point(236, 307)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(140, 27)
        Me.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancelar.TabIndex = 180
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextColor = System.Drawing.Color.White
        '
        'btnRegistrar
        '
        Me.btnRegistrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRegistrar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRegistrar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrar.Location = New System.Drawing.Point(44, 307)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(140, 27)
        Me.btnRegistrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRegistrar.TabIndex = 179
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.TextColor = System.Drawing.Color.White
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(49, 115)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(30, 20)
        Me.lblID.TabIndex = 181
        Me.lblID.Text = "ID:"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(49, 52)
        Me.lblTipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(43, 20)
        Me.lblTipo.TabIndex = 183
        Me.lblTipo.Text = "Tipo:"
        '
        'cboTipo
        '
        Me.cboTipo.DisplayMember = "Text"
        Me.cboTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.ItemHeight = 20
        Me.cboTipo.Items.AddRange(New Object() {Me.ComboItem6, Me.ComboItem7, Me.ComboItem8})
        Me.cboTipo.Location = New System.Drawing.Point(211, 52)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(154, 26)
        Me.cboTipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboTipo.TabIndex = 182
        Me.cboTipo.WatermarkText = "Seleccione"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "Toro"
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "Vaca"
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "Cria"
        '
        'gpoVictima
        '
        Me.gpoVictima.Controls.Add(Me.lblTipo)
        Me.gpoVictima.Controls.Add(Me.cboID)
        Me.gpoVictima.Controls.Add(Me.cboTipo)
        Me.gpoVictima.Controls.Add(Me.lblFecha)
        Me.gpoVictima.Controls.Add(Me.lblID)
        Me.gpoVictima.Controls.Add(Me.dateMuerte)
        Me.gpoVictima.Controls.Add(Me.btnCancelar)
        Me.gpoVictima.Controls.Add(Me.lblCausa)
        Me.gpoVictima.Controls.Add(Me.btnRegistrar)
        Me.gpoVictima.Controls.Add(Me.cboCausa)
        Me.gpoVictima.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpoVictima.Location = New System.Drawing.Point(21, 12)
        Me.gpoVictima.Name = "gpoVictima"
        Me.gpoVictima.Size = New System.Drawing.Size(394, 382)
        Me.gpoVictima.TabIndex = 184
        Me.gpoVictima.TabStop = False
        Me.gpoVictima.Text = "Nueva victima"
        '
        'lblList
        '
        Me.lblList.AutoSize = True
        Me.lblList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblList.Location = New System.Drawing.Point(535, 42)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(167, 24)
        Me.lblList.TabIndex = 185
        Me.lblList.Text = "Listado de victimas"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(460, 103)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(319, 217)
        Me.DataGridView1.TabIndex = 184
        '
        'frmVictima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(839, 572)
        Me.Controls.Add(Me.lblList)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.gpoVictima)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVictima"
        Me.Text = "frmMuerte"
        CType(Me.dateMuerte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoVictima.ResumeLayout(False)
        Me.gpoVictima.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboID As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents dateMuerte As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents cboCausa As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents lblCausa As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnRegistrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents cboTipo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents gpoVictima As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblList As System.Windows.Forms.Label
End Class
