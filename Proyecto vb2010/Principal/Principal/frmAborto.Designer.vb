<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAborto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAborto))
        Me.dateFechaAborto = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.lblFechaAborto = New System.Windows.Forms.Label()
        Me.lblVaca = New System.Windows.Forms.Label()
        Me.lblCausaAborto = New System.Windows.Forms.Label()
        Me.cboCausa = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.lblAbortos = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.gpoBusqueda = New System.Windows.Forms.GroupBox()
        Me.txtCriasPerdidas = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblCriasPerdidas = New System.Windows.Forms.Label()
        Me.btnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.btnAceptar = New DevComponents.DotNetBar.ButtonX()
        Me.btnCerrar = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.cboVaca = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        CType(Me.dateFechaAborto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoBusqueda.SuspendLayout()
        Me.SuspendLayout()
        '
        'dateFechaAborto
        '
        '
        '
        '
        Me.dateFechaAborto.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dateFechaAborto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateFechaAborto.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dateFechaAborto.ButtonDropDown.Visible = True
        Me.dateFechaAborto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFechaAborto.IsPopupCalendarOpen = False
        Me.dateFechaAborto.Location = New System.Drawing.Point(192, 102)
        '
        '
        '
        Me.dateFechaAborto.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dateFechaAborto.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateFechaAborto.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dateFechaAborto.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dateFechaAborto.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dateFechaAborto.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dateFechaAborto.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dateFechaAborto.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dateFechaAborto.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dateFechaAborto.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dateFechaAborto.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateFechaAborto.MonthCalendar.DisplayMonth = New Date(2016, 7, 1, 0, 0, 0, 0)
        Me.dateFechaAborto.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dateFechaAborto.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dateFechaAborto.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dateFechaAborto.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dateFechaAborto.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dateFechaAborto.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dateFechaAborto.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateFechaAborto.MonthCalendar.TodayButtonVisible = True
        Me.dateFechaAborto.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dateFechaAborto.Name = "dateFechaAborto"
        Me.dateFechaAborto.Size = New System.Drawing.Size(121, 21)
        Me.dateFechaAborto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dateFechaAborto.TabIndex = 103
        '
        'lblFechaAborto
        '
        Me.lblFechaAborto.AutoSize = True
        Me.lblFechaAborto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaAborto.Location = New System.Drawing.Point(32, 102)
        Me.lblFechaAborto.Name = "lblFechaAborto"
        Me.lblFechaAborto.Size = New System.Drawing.Size(129, 20)
        Me.lblFechaAborto.TabIndex = 102
        Me.lblFechaAborto.Text = "Fecha del aborto"
        '
        'lblVaca
        '
        Me.lblVaca.AutoSize = True
        Me.lblVaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVaca.Location = New System.Drawing.Point(34, 53)
        Me.lblVaca.Name = "lblVaca"
        Me.lblVaca.Size = New System.Drawing.Size(50, 20)
        Me.lblVaca.TabIndex = 100
        Me.lblVaca.Text = "Vaca:"
        '
        'lblCausaAborto
        '
        Me.lblCausaAborto.AutoSize = True
        Me.lblCausaAborto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCausaAborto.Location = New System.Drawing.Point(32, 153)
        Me.lblCausaAborto.Name = "lblCausaAborto"
        Me.lblCausaAborto.Size = New System.Drawing.Size(130, 20)
        Me.lblCausaAborto.TabIndex = 105
        Me.lblCausaAborto.Text = "Causa del aborto"
        '
        'cboCausa
        '
        Me.cboCausa.DisplayMember = "Text"
        Me.cboCausa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCausa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCausa.FormattingEnabled = True
        Me.cboCausa.ItemHeight = 15
        Me.cboCausa.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3})
        Me.cboCausa.Location = New System.Drawing.Point(192, 153)
        Me.cboCausa.Name = "cboCausa"
        Me.cboCausa.Size = New System.Drawing.Size(121, 21)
        Me.cboCausa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboCausa.TabIndex = 117
        Me.cboCausa.WatermarkText = "Ingrese"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "NormalNormal"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Cesárea"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Prematuro"
        '
        'lblAbortos
        '
        '
        '
        '
        Me.lblAbortos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblAbortos.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbortos.Location = New System.Drawing.Point(195, 12)
        Me.lblAbortos.Name = "lblAbortos"
        Me.lblAbortos.Size = New System.Drawing.Size(83, 52)
        Me.lblAbortos.TabIndex = 120
        Me.lblAbortos.Text = "<b><font size=""+6""><i></i><font color=""#B02B2C"">Abortos</font></font></b>"
        '
        'gpoBusqueda
        '
        Me.gpoBusqueda.Controls.Add(Me.cboVaca)
        Me.gpoBusqueda.Controls.Add(Me.txtCriasPerdidas)
        Me.gpoBusqueda.Controls.Add(Me.lblCriasPerdidas)
        Me.gpoBusqueda.Controls.Add(Me.btnCancelar)
        Me.gpoBusqueda.Controls.Add(Me.btnAceptar)
        Me.gpoBusqueda.Controls.Add(Me.lblVaca)
        Me.gpoBusqueda.Controls.Add(Me.lblFechaAborto)
        Me.gpoBusqueda.Controls.Add(Me.cboCausa)
        Me.gpoBusqueda.Controls.Add(Me.dateFechaAborto)
        Me.gpoBusqueda.Controls.Add(Me.lblCausaAborto)
        Me.gpoBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpoBusqueda.Location = New System.Drawing.Point(26, 81)
        Me.gpoBusqueda.Name = "gpoBusqueda"
        Me.gpoBusqueda.Size = New System.Drawing.Size(439, 355)
        Me.gpoBusqueda.TabIndex = 122
        Me.gpoBusqueda.TabStop = False
        Me.gpoBusqueda.Text = "Nuevo Aborto"
        '
        'txtCriasPerdidas
        '
        '
        '
        '
        Me.txtCriasPerdidas.Border.Class = "TextBoxBorder"
        Me.txtCriasPerdidas.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCriasPerdidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCriasPerdidas.Location = New System.Drawing.Point(192, 208)
        Me.txtCriasPerdidas.Name = "txtCriasPerdidas"
        Me.txtCriasPerdidas.Size = New System.Drawing.Size(117, 21)
        Me.txtCriasPerdidas.TabIndex = 139
        '
        'lblCriasPerdidas
        '
        Me.lblCriasPerdidas.AutoSize = True
        Me.lblCriasPerdidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCriasPerdidas.Location = New System.Drawing.Point(34, 209)
        Me.lblCriasPerdidas.Name = "lblCriasPerdidas"
        Me.lblCriasPerdidas.Size = New System.Drawing.Size(114, 20)
        Me.lblCriasPerdidas.TabIndex = 138
        Me.lblCriasPerdidas.Text = "Crias perdidas:"
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancelar.BackColor = System.Drawing.Color.Firebrick
        Me.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Location = New System.Drawing.Point(247, 305)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(140, 27)
        Me.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancelar.TabIndex = 137
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextColor = System.Drawing.Color.White
        '
        'btnAceptar
        '
        Me.btnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAceptar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Location = New System.Drawing.Point(57, 305)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(140, 27)
        Me.btnAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAceptar.TabIndex = 136
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextColor = System.Drawing.Color.White
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
        Me.btnCerrar.Location = New System.Drawing.Point(453, -2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(44, 45)
        Me.btnCerrar.TabIndex = 121
        '
        'cboVaca
        '
        Me.cboVaca.DisplayMember = "Text"
        Me.cboVaca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboVaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVaca.FormattingEnabled = True
        Me.cboVaca.ItemHeight = 15
        Me.cboVaca.Location = New System.Drawing.Point(192, 52)
        Me.cboVaca.Name = "cboVaca"
        Me.cboVaca.Size = New System.Drawing.Size(121, 21)
        Me.cboVaca.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboVaca.TabIndex = 174
        Me.cboVaca.WatermarkText = "Seleccione"
        '
        'frmAborto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(491, 448)
        Me.Controls.Add(Me.gpoBusqueda)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.lblAbortos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAborto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Abortos"
        CType(Me.dateFechaAborto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoBusqueda.ResumeLayout(False)
        Me.gpoBusqueda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dateFechaAborto As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents lblFechaAborto As System.Windows.Forms.Label
    Friend WithEvents lblVaca As System.Windows.Forms.Label
    Friend WithEvents lblCausaAborto As System.Windows.Forms.Label
    Friend WithEvents cboCausa As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents lblAbortos As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents btnCerrar As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents gpoBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtCriasPerdidas As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblCriasPerdidas As System.Windows.Forms.Label
    Friend WithEvents cboVaca As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
