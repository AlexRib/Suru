<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecria2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecria2))
        Me.gpoRecria = New System.Windows.Forms.GroupBox()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.dateFecha = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.btnIngresar = New DevComponents.DotNetBar.ButtonX()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblRecria = New System.Windows.Forms.Label()
        Me.cboRecria = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblCria = New System.Windows.Forms.Label()
        Me.cboCria = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.btnCerrar = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.gpoRecria.SuspendLayout()
        CType(Me.dateFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.gpoRecria.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpoRecria.Location = New System.Drawing.Point(12, 33)
        Me.gpoRecria.Name = "gpoRecria"
        Me.gpoRecria.Size = New System.Drawing.Size(368, 299)
        Me.gpoRecria.TabIndex = 182
        Me.gpoRecria.TabStop = False
        Me.gpoRecria.Text = "Asignar cría a campo de recría"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.BackColor = System.Drawing.Color.Gold
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.ButtonX1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonX1.Location = New System.Drawing.Point(195, 248)
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
        Me.btnIngresar.Location = New System.Drawing.Point(60, 248)
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
        'btnCerrar
        '
        '
        '
        '
        Me.btnCerrar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btnCerrar.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(365, 1)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(29, 45)
        Me.btnCerrar.TabIndex = 183
        '
        'frmRecria2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(395, 344)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.gpoRecria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(800, 150)
        Me.Name = "frmRecria2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Asignar"
        Me.gpoRecria.ResumeLayout(False)
        Me.gpoRecria.PerformLayout()
        CType(Me.dateFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpoRecria As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dateFecha As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents btnIngresar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblRecria As System.Windows.Forms.Label
    Friend WithEvents cboRecria As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblCria As System.Windows.Forms.Label
    Friend WithEvents cboCria As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btnCerrar As DevComponents.DotNetBar.Controls.ReflectionImage
End Class
