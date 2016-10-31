<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstado))
        Me.lblEstados = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.gpoBusqueda = New System.Windows.Forms.GroupBox()
        Me.cboBuscar = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.btnBuscar = New DevComponents.DotNetBar.ButtonX()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.gpoAniadir = New System.Windows.Forms.GroupBox()
        Me.chkDeclarar = New System.Windows.Forms.CheckBox()
        Me.txthem = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dateFechaI = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dateFechaF = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.btnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.btnRegistrar = New DevComponents.DotNetBar.ButtonX()
        Me.lblFfin = New System.Windows.Forms.Label()
        Me.lblFinicio = New System.Windows.Forms.Label()
        Me.cboEstado = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.lblEstado2 = New System.Windows.Forms.Label()
        Me.cboVaca = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.ComboItem9 = New DevComponents.Editors.ComboItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Login = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCerrar = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.gpoBusqueda.SuspendLayout()
        Me.gpoAniadir.SuspendLayout()
        CType(Me.dateFechaI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateFechaF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEstados
        '
        '
        '
        '
        Me.lblEstados.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblEstados.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstados.Location = New System.Drawing.Point(233, 9)
        Me.lblEstados.Name = "lblEstados"
        Me.lblEstados.Size = New System.Drawing.Size(106, 52)
        Me.lblEstados.TabIndex = 127
        Me.lblEstados.Text = "<b><font size=""+6""><i></i><font color=""#B02B2C"">Estados</font></font></b>"
        '
        'gpoBusqueda
        '
        Me.gpoBusqueda.Controls.Add(Me.cboBuscar)
        Me.gpoBusqueda.Controls.Add(Me.btnBuscar)
        Me.gpoBusqueda.Controls.Add(Me.lblEstado)
        Me.gpoBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpoBusqueda.Location = New System.Drawing.Point(51, 67)
        Me.gpoBusqueda.Name = "gpoBusqueda"
        Me.gpoBusqueda.Size = New System.Drawing.Size(404, 87)
        Me.gpoBusqueda.TabIndex = 125
        Me.gpoBusqueda.TabStop = False
        Me.gpoBusqueda.Text = "Búsqueda"
        '
        'cboBuscar
        '
        Me.cboBuscar.DisplayMember = "Text"
        Me.cboBuscar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBuscar.FormattingEnabled = True
        Me.cboBuscar.ItemHeight = 15
        Me.cboBuscar.Items.AddRange(New Object() {Me.ComboItem5, Me.ComboItem6, Me.ComboItem7, Me.ComboItem3})
        Me.cboBuscar.Location = New System.Drawing.Point(146, 39)
        Me.cboBuscar.Name = "cboBuscar"
        Me.cboBuscar.Size = New System.Drawing.Size(117, 21)
        Me.cboBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboBuscar.TabIndex = 138
        Me.cboBuscar.WatermarkText = "Ingrese"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "Administrador"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "Gerente"
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "Establecimiento"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Auxiliar"
        '
        'btnBuscar
        '
        Me.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(295, 39)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBuscar.TabIndex = 121
        Me.btnBuscar.Text = "Buscar"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(42, 39)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(64, 20)
        Me.lblEstado.TabIndex = 12
        Me.lblEstado.Text = "Estado:"
        '
        'gpoAniadir
        '
        Me.gpoAniadir.Controls.Add(Me.chkDeclarar)
        Me.gpoAniadir.Controls.Add(Me.txthem)
        Me.gpoAniadir.Controls.Add(Me.dateFechaI)
        Me.gpoAniadir.Controls.Add(Me.dateFechaF)
        Me.gpoAniadir.Controls.Add(Me.btnCancelar)
        Me.gpoAniadir.Controls.Add(Me.btnRegistrar)
        Me.gpoAniadir.Controls.Add(Me.lblFfin)
        Me.gpoAniadir.Controls.Add(Me.lblFinicio)
        Me.gpoAniadir.Controls.Add(Me.cboEstado)
        Me.gpoAniadir.Controls.Add(Me.lblEstado2)
        Me.gpoAniadir.Controls.Add(Me.cboVaca)
        Me.gpoAniadir.Controls.Add(Me.Label1)
        Me.gpoAniadir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpoAniadir.Location = New System.Drawing.Point(51, 185)
        Me.gpoAniadir.Name = "gpoAniadir"
        Me.gpoAniadir.Size = New System.Drawing.Size(404, 399)
        Me.gpoAniadir.TabIndex = 128
        Me.gpoAniadir.TabStop = False
        Me.gpoAniadir.Text = "Añadir"
        '
        'chkDeclarar
        '
        Me.chkDeclarar.AutoSize = True
        Me.chkDeclarar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDeclarar.Location = New System.Drawing.Point(63, 199)
        Me.chkDeclarar.Name = "chkDeclarar"
        Me.chkDeclarar.Size = New System.Drawing.Size(278, 24)
        Me.chkDeclarar.TabIndex = 172
        Me.chkDeclarar.Text = "Declarar fecha de estado finalizado"
        Me.chkDeclarar.UseVisualStyleBackColor = True
        '
        'txthem
        '
        '
        '
        '
        Me.txthem.Border.Class = "TextBoxBorder"
        Me.txthem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txthem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthem.Location = New System.Drawing.Point(31, 349)
        Me.txthem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txthem.Name = "txthem"
        Me.txthem.Size = New System.Drawing.Size(93, 24)
        Me.txthem.TabIndex = 171
        Me.txthem.Text = "Hembra"
        Me.txthem.Visible = False
        '
        'dateFechaI
        '
        '
        '
        '
        Me.dateFechaI.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateFechaI.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dateFechaI.ButtonDropDown.Visible = True
        Me.dateFechaI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFechaI.IsPopupCalendarOpen = False
        Me.dateFechaI.Location = New System.Drawing.Point(223, 158)
        Me.dateFechaI.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        '
        '
        '
        Me.dateFechaI.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dateFechaI.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.dateFechaI.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateFechaI.MonthCalendar.DisplayMonth = New Date(2016, 8, 1, 0, 0, 0, 0)
        Me.dateFechaI.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dateFechaI.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dateFechaI.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateFechaI.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dateFechaI.Name = "dateFechaI"
        Me.dateFechaI.Size = New System.Drawing.Size(118, 21)
        Me.dateFechaI.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dateFechaI.TabIndex = 154
        '
        'dateFechaF
        '
        '
        '
        '
        Me.dateFechaF.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateFechaF.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dateFechaF.ButtonDropDown.Visible = True
        Me.dateFechaF.Enabled = False
        Me.dateFechaF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFechaF.IsPopupCalendarOpen = False
        Me.dateFechaF.Location = New System.Drawing.Point(223, 246)
        Me.dateFechaF.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        '
        '
        '
        Me.dateFechaF.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dateFechaF.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.dateFechaF.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateFechaF.MonthCalendar.DisplayMonth = New Date(2016, 8, 1, 0, 0, 0, 0)
        Me.dateFechaF.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dateFechaF.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dateFechaF.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dateFechaF.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dateFechaF.Name = "dateFechaF"
        Me.dateFechaF.Size = New System.Drawing.Size(118, 21)
        Me.dateFechaF.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dateFechaF.TabIndex = 153
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancelar.BackColor = System.Drawing.Color.Gold
        Me.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Location = New System.Drawing.Point(223, 305)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(140, 27)
        Me.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancelar.TabIndex = 151
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextColor = System.Drawing.Color.White
        '
        'btnRegistrar
        '
        Me.btnRegistrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRegistrar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRegistrar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrar.Location = New System.Drawing.Point(31, 305)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(140, 27)
        Me.btnRegistrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRegistrar.TabIndex = 150
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.TextColor = System.Drawing.Color.White
        '
        'lblFfin
        '
        Me.lblFfin.AutoSize = True
        Me.lblFfin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFfin.Location = New System.Drawing.Point(74, 247)
        Me.lblFfin.Name = "lblFfin"
        Me.lblFfin.Size = New System.Drawing.Size(79, 20)
        Me.lblFfin.TabIndex = 148
        Me.lblFfin.Text = "Fecha fin:"
        '
        'lblFinicio
        '
        Me.lblFinicio.AutoSize = True
        Me.lblFinicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinicio.Location = New System.Drawing.Point(74, 158)
        Me.lblFinicio.Name = "lblFinicio"
        Me.lblFinicio.Size = New System.Drawing.Size(97, 20)
        Me.lblFinicio.TabIndex = 146
        Me.lblFinicio.Text = "Fecha inicio:"
        '
        'cboEstado
        '
        Me.cboEstado.DisplayMember = "Text"
        Me.cboEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.ItemHeight = 15
        Me.cboEstado.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2})
        Me.cboEstado.Location = New System.Drawing.Point(223, 105)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(118, 21)
        Me.cboEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboEstado.TabIndex = 145
        Me.cboEstado.WatermarkText = "Ingrese"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Macho"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Hembra"
        '
        'lblEstado2
        '
        Me.lblEstado2.AutoSize = True
        Me.lblEstado2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado2.Location = New System.Drawing.Point(74, 105)
        Me.lblEstado2.Name = "lblEstado2"
        Me.lblEstado2.Size = New System.Drawing.Size(64, 20)
        Me.lblEstado2.TabIndex = 144
        Me.lblEstado2.Text = "Estado:"
        '
        'cboVaca
        '
        Me.cboVaca.DisplayMember = "Text"
        Me.cboVaca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboVaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVaca.FormattingEnabled = True
        Me.cboVaca.ItemHeight = 15
        Me.cboVaca.Items.AddRange(New Object() {Me.ComboItem8, Me.ComboItem9})
        Me.cboVaca.Location = New System.Drawing.Point(223, 53)
        Me.cboVaca.Name = "cboVaca"
        Me.cboVaca.Size = New System.Drawing.Size(118, 21)
        Me.cboVaca.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboVaca.TabIndex = 143
        Me.cboVaca.WatermarkText = "Ingrese"
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "Macho"
        '
        'ComboItem9
        '
        Me.ComboItem9.Text = "Hembra"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Vaca:"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Cedula, Me.Login, Me.Nombre, Me.Apellido, Me.Rol})
        Me.DataGridView1.GridColor = System.Drawing.Color.Black
        Me.DataGridView1.Location = New System.Drawing.Point(497, 128)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DataGridView1.Size = New System.Drawing.Size(323, 280)
        Me.DataGridView1.TabIndex = 141
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Width = 50
        '
        'Cedula
        '
        Me.Cedula.HeaderText = "Cedula"
        Me.Cedula.Name = "Cedula"
        Me.Cedula.Width = 80
        '
        'Login
        '
        Me.Login.HeaderText = "Login"
        Me.Login.Name = "Login"
        Me.Login.Width = 90
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 90
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Width = 90
        '
        'Rol
        '
        Me.Rol.HeaderText = "Rol"
        Me.Rol.Name = "Rol"
        Me.Rol.Width = 90
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(580, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 20)
        Me.Label2.TabIndex = 144
        Me.Label2.Text = "Vacas con estado"
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
        Me.btnCerrar.Location = New System.Drawing.Point(1339, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(29, 45)
        Me.btnCerrar.TabIndex = 126
        '
        'frmEstado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 553)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.gpoAniadir)
        Me.Controls.Add(Me.lblEstados)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.gpoBusqueda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEstado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEstado"
        Me.gpoBusqueda.ResumeLayout(False)
        Me.gpoBusqueda.PerformLayout()
        Me.gpoAniadir.ResumeLayout(False)
        Me.gpoAniadir.PerformLayout()
        CType(Me.dateFechaI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateFechaF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEstados As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents btnCerrar As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents gpoBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents gpoAniadir As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboEstado As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents lblEstado2 As System.Windows.Forms.Label
    Friend WithEvents cboVaca As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents lblFfin As System.Windows.Forms.Label
    Friend WithEvents lblFinicio As System.Windows.Forms.Label
    Friend WithEvents btnRegistrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dateFechaF As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dateFechaI As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents cboBuscar As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cedula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Login As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txthem As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents chkDeclarar As System.Windows.Forms.CheckBox
End Class
