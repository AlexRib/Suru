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
        Me.cboCausa = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblCausa = New System.Windows.Forms.Label()
        Me.cboEnf = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblEnf = New System.Windows.Forms.Label()
        Me.btnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.btnAceptar = New DevComponents.DotNetBar.ButtonX()
        Me.lblEnfermedad = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.dateFecha = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.lblFechaEnfermedad = New System.Windows.Forms.Label()
        Me.lblAnimal = New System.Windows.Forms.Label()
        Me.btnCerrar = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.cboAnimal = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        CType(Me.dateFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboCausa
        '
        Me.cboCausa.DisplayMember = "Text"
        Me.cboCausa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCausa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCausa.FormattingEnabled = True
        Me.cboCausa.ItemHeight = 15
        Me.cboCausa.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3})
        Me.cboCausa.Location = New System.Drawing.Point(216, 256)
        Me.cboCausa.Name = "cboCausa"
        Me.cboCausa.Size = New System.Drawing.Size(121, 21)
        Me.cboCausa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboCausa.TabIndex = 157
        '
        'lblCausa
        '
        Me.lblCausa.AutoSize = True
        Me.lblCausa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCausa.Location = New System.Drawing.Point(75, 257)
        Me.lblCausa.Name = "lblCausa"
        Me.lblCausa.Size = New System.Drawing.Size(59, 20)
        Me.lblCausa.TabIndex = 156
        Me.lblCausa.Text = "Causa:"
        '
        'cboEnf
        '
        Me.cboEnf.DisplayMember = "Text"
        Me.cboEnf.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboEnf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEnf.FormattingEnabled = True
        Me.cboEnf.ItemHeight = 15
        Me.cboEnf.Location = New System.Drawing.Point(217, 145)
        Me.cboEnf.Name = "cboEnf"
        Me.cboEnf.Size = New System.Drawing.Size(121, 21)
        Me.cboEnf.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboEnf.TabIndex = 155
        '
        'lblEnf
        '
        Me.lblEnf.AutoSize = True
        Me.lblEnf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnf.Location = New System.Drawing.Point(76, 146)
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
        Me.btnCancelar.Location = New System.Drawing.Point(234, 336)
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
        Me.btnAceptar.Location = New System.Drawing.Point(44, 336)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(140, 27)
        Me.btnAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAceptar.TabIndex = 152
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextColor = System.Drawing.Color.White
        '
        'lblEnfermedad
        '
        '
        '
        '
        Me.lblEnfermedad.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblEnfermedad.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnfermedad.Location = New System.Drawing.Point(161, 12)
        Me.lblEnfermedad.Name = "lblEnfermedad"
        Me.lblEnfermedad.Size = New System.Drawing.Size(120, 52)
        Me.lblEnfermedad.TabIndex = 151
        Me.lblEnfermedad.Text = "<b><font size=""+6""><i></i><font color=""#B02B2C"">Enfermedad</font></font></b>"
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
        Me.dateFecha.Location = New System.Drawing.Point(217, 201)
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
        Me.lblFechaEnfermedad.Location = New System.Drawing.Point(76, 201)
        Me.lblFechaEnfermedad.Name = "lblFechaEnfermedad"
        Me.lblFechaEnfermedad.Size = New System.Drawing.Size(58, 20)
        Me.lblFechaEnfermedad.TabIndex = 146
        Me.lblFechaEnfermedad.Text = "Fecha:"
        '
        'lblAnimal
        '
        Me.lblAnimal.AutoSize = True
        Me.lblAnimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnimal.Location = New System.Drawing.Point(77, 94)
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
        Me.btnCerrar.Location = New System.Drawing.Point(392, 0)
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
        Me.cboAnimal.Location = New System.Drawing.Point(216, 94)
        Me.cboAnimal.Name = "cboAnimal"
        Me.cboAnimal.Size = New System.Drawing.Size(121, 21)
        Me.cboAnimal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboAnimal.TabIndex = 158
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Frio"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Contagio"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Fiebre"
        '
        'frmContrae
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(423, 405)
        Me.Controls.Add(Me.cboAnimal)
        Me.Controls.Add(Me.cboCausa)
        Me.Controls.Add(Me.lblCausa)
        Me.Controls.Add(Me.cboEnf)
        Me.Controls.Add(Me.lblEnf)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblEnfermedad)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.dateFecha)
        Me.Controls.Add(Me.lblFechaEnfermedad)
        Me.Controls.Add(Me.lblAnimal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmContrae"
        Me.Text = "Enfermedad"
        CType(Me.dateFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboCausa As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblCausa As System.Windows.Forms.Label
    Friend WithEvents cboEnf As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblEnf As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblEnfermedad As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents btnCerrar As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents dateFecha As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents lblFechaEnfermedad As System.Windows.Forms.Label
    Friend WithEvents lblAnimal As System.Windows.Forms.Label
    Friend WithEvents cboAnimal As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
End Class
