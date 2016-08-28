<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenie))
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.nudOrdeniesdiarios = New System.Windows.Forms.NumericUpDown()
        Me.lblOrdeniesdiarios = New System.Windows.Forms.Label()
        Me.lblHorai1 = New System.Windows.Forms.Label()
        Me.gpo1ordeñe = New System.Windows.Forms.GroupBox()
        Me.nudHorai1 = New System.Windows.Forms.NumericUpDown()
        Me.lblHoraf1 = New System.Windows.Forms.Label()
        Me.Horaf1 = New System.Windows.Forms.NumericUpDown()
        Me.gpo2ordeñe = New System.Windows.Forms.GroupBox()
        Me.lblHoraf2 = New System.Windows.Forms.Label()
        Me.Horaf2 = New System.Windows.Forms.NumericUpDown()
        Me.lblHorai2 = New System.Windows.Forms.Label()
        Me.Horai2 = New System.Windows.Forms.NumericUpDown()
        Me.gpo3ordeñe = New System.Windows.Forms.GroupBox()
        Me.lblHoraf3 = New System.Windows.Forms.Label()
        Me.Horaf3 = New System.Windows.Forms.NumericUpDown()
        Me.lblHorai3 = New System.Windows.Forms.Label()
        Me.Horai3 = New System.Windows.Forms.NumericUpDown()
        Me.gpo4ordeñe = New System.Windows.Forms.GroupBox()
        Me.lblHoraf4 = New System.Windows.Forms.Label()
        Me.Horaf4 = New System.Windows.Forms.NumericUpDown()
        Me.lblHorai4 = New System.Windows.Forms.Label()
        Me.Horai4 = New System.Windows.Forms.NumericUpDown()
        Me.cboTipo = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.TimeSelector1 = New DevComponents.Editors.DateTimeAdv.TimeSelector()
        Me.btnCerrar = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.lblOrdeñes = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.btnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.btnAceptar = New DevComponents.DotNetBar.ButtonX()
        CType(Me.nudOrdeniesdiarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpo1ordeñe.SuspendLayout()
        CType(Me.nudHorai1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Horaf1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpo2ordeñe.SuspendLayout()
        CType(Me.Horaf2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Horai2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpo3ordeñe.SuspendLayout()
        CType(Me.Horaf3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Horai3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpo4ordeñe.SuspendLayout()
        CType(Me.Horaf4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Horai4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(51, 78)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(122, 20)
        Me.lblTipo.TabIndex = 53
        Me.lblTipo.Text = "Tipo de Ordeñe:"
        '
        'nudOrdeniesdiarios
        '
        Me.nudOrdeniesdiarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudOrdeniesdiarios.Location = New System.Drawing.Point(193, 130)
        Me.nudOrdeniesdiarios.Name = "nudOrdeniesdiarios"
        Me.nudOrdeniesdiarios.Size = New System.Drawing.Size(46, 21)
        Me.nudOrdeniesdiarios.TabIndex = 58
        '
        'lblOrdeniesdiarios
        '
        Me.lblOrdeniesdiarios.AutoSize = True
        Me.lblOrdeniesdiarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdeniesdiarios.Location = New System.Drawing.Point(51, 129)
        Me.lblOrdeniesdiarios.Name = "lblOrdeniesdiarios"
        Me.lblOrdeniesdiarios.Size = New System.Drawing.Size(124, 20)
        Me.lblOrdeniesdiarios.TabIndex = 57
        Me.lblOrdeniesdiarios.Text = "Ordeñes diarios:"
        '
        'lblHorai1
        '
        Me.lblHorai1.AutoSize = True
        Me.lblHorai1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorai1.Location = New System.Drawing.Point(18, 42)
        Me.lblHorai1.Name = "lblHorai1"
        Me.lblHorai1.Size = New System.Drawing.Size(83, 20)
        Me.lblHorai1.TabIndex = 59
        Me.lblHorai1.Text = "Hora inicio"
        '
        'gpo1ordeñe
        '
        Me.gpo1ordeñe.Controls.Add(Me.nudHorai1)
        Me.gpo1ordeñe.Controls.Add(Me.lblHoraf1)
        Me.gpo1ordeñe.Controls.Add(Me.Horaf1)
        Me.gpo1ordeñe.Controls.Add(Me.lblHorai1)
        Me.gpo1ordeñe.Enabled = False
        Me.gpo1ordeñe.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpo1ordeñe.Location = New System.Drawing.Point(366, 78)
        Me.gpo1ordeñe.Name = "gpo1ordeñe"
        Me.gpo1ordeñe.Size = New System.Drawing.Size(220, 128)
        Me.gpo1ordeñe.TabIndex = 61
        Me.gpo1ordeñe.TabStop = False
        Me.gpo1ordeñe.Text = "Primer Ordeñe"
        '
        'nudHorai1
        '
        Me.nudHorai1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudHorai1.Location = New System.Drawing.Point(128, 44)
        Me.nudHorai1.Name = "nudHorai1"
        Me.nudHorai1.Size = New System.Drawing.Size(64, 21)
        Me.nudHorai1.TabIndex = 63
        '
        'lblHoraf1
        '
        Me.lblHoraf1.AutoSize = True
        Me.lblHoraf1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraf1.Location = New System.Drawing.Point(18, 77)
        Me.lblHoraf1.Name = "lblHoraf1"
        Me.lblHoraf1.Size = New System.Drawing.Size(65, 20)
        Me.lblHoraf1.TabIndex = 61
        Me.lblHoraf1.Text = "Hora fin"
        '
        'Horaf1
        '
        Me.Horaf1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Horaf1.Location = New System.Drawing.Point(128, 79)
        Me.Horaf1.Name = "Horaf1"
        Me.Horaf1.Size = New System.Drawing.Size(64, 21)
        Me.Horaf1.TabIndex = 62
        '
        'gpo2ordeñe
        '
        Me.gpo2ordeñe.Controls.Add(Me.lblHoraf2)
        Me.gpo2ordeñe.Controls.Add(Me.Horaf2)
        Me.gpo2ordeñe.Controls.Add(Me.lblHorai2)
        Me.gpo2ordeñe.Controls.Add(Me.Horai2)
        Me.gpo2ordeñe.Enabled = False
        Me.gpo2ordeñe.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpo2ordeñe.Location = New System.Drawing.Point(592, 78)
        Me.gpo2ordeñe.Name = "gpo2ordeñe"
        Me.gpo2ordeñe.Size = New System.Drawing.Size(226, 128)
        Me.gpo2ordeñe.TabIndex = 62
        Me.gpo2ordeñe.TabStop = False
        Me.gpo2ordeñe.Text = " Segundo Ordeñe"
        '
        'lblHoraf2
        '
        Me.lblHoraf2.AutoSize = True
        Me.lblHoraf2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraf2.Location = New System.Drawing.Point(19, 78)
        Me.lblHoraf2.Name = "lblHoraf2"
        Me.lblHoraf2.Size = New System.Drawing.Size(65, 20)
        Me.lblHoraf2.TabIndex = 61
        Me.lblHoraf2.Text = "Hora fin"
        '
        'Horaf2
        '
        Me.Horaf2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Horaf2.Location = New System.Drawing.Point(134, 79)
        Me.Horaf2.Name = "Horaf2"
        Me.Horaf2.Size = New System.Drawing.Size(64, 21)
        Me.Horaf2.TabIndex = 62
        '
        'lblHorai2
        '
        Me.lblHorai2.AutoSize = True
        Me.lblHorai2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorai2.Location = New System.Drawing.Point(19, 42)
        Me.lblHorai2.Name = "lblHorai2"
        Me.lblHorai2.Size = New System.Drawing.Size(83, 20)
        Me.lblHorai2.TabIndex = 59
        Me.lblHorai2.Text = "Hora inicio"
        '
        'Horai2
        '
        Me.Horai2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Horai2.Location = New System.Drawing.Point(134, 44)
        Me.Horai2.Name = "Horai2"
        Me.Horai2.Size = New System.Drawing.Size(64, 21)
        Me.Horai2.TabIndex = 60
        '
        'gpo3ordeñe
        '
        Me.gpo3ordeñe.Controls.Add(Me.lblHoraf3)
        Me.gpo3ordeñe.Controls.Add(Me.Horaf3)
        Me.gpo3ordeñe.Controls.Add(Me.lblHorai3)
        Me.gpo3ordeñe.Controls.Add(Me.Horai3)
        Me.gpo3ordeñe.Enabled = False
        Me.gpo3ordeñe.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpo3ordeñe.Location = New System.Drawing.Point(366, 224)
        Me.gpo3ordeñe.Name = "gpo3ordeñe"
        Me.gpo3ordeñe.Size = New System.Drawing.Size(220, 128)
        Me.gpo3ordeñe.TabIndex = 63
        Me.gpo3ordeñe.TabStop = False
        Me.gpo3ordeñe.Text = "Tercer Ordeñe"
        '
        'lblHoraf3
        '
        Me.lblHoraf3.AutoSize = True
        Me.lblHoraf3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraf3.Location = New System.Drawing.Point(18, 74)
        Me.lblHoraf3.Name = "lblHoraf3"
        Me.lblHoraf3.Size = New System.Drawing.Size(65, 20)
        Me.lblHoraf3.TabIndex = 61
        Me.lblHoraf3.Text = "Hora fin"
        '
        'Horaf3
        '
        Me.Horaf3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Horaf3.Location = New System.Drawing.Point(129, 75)
        Me.Horaf3.Name = "Horaf3"
        Me.Horaf3.Size = New System.Drawing.Size(63, 21)
        Me.Horaf3.TabIndex = 62
        '
        'lblHorai3
        '
        Me.lblHorai3.AutoSize = True
        Me.lblHorai3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorai3.Location = New System.Drawing.Point(18, 37)
        Me.lblHorai3.Name = "lblHorai3"
        Me.lblHorai3.Size = New System.Drawing.Size(83, 20)
        Me.lblHorai3.TabIndex = 59
        Me.lblHorai3.Text = "Hora inicio"
        '
        'Horai3
        '
        Me.Horai3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Horai3.Location = New System.Drawing.Point(129, 38)
        Me.Horai3.Name = "Horai3"
        Me.Horai3.Size = New System.Drawing.Size(63, 21)
        Me.Horai3.TabIndex = 60
        '
        'gpo4ordeñe
        '
        Me.gpo4ordeñe.Controls.Add(Me.lblHoraf4)
        Me.gpo4ordeñe.Controls.Add(Me.Horaf4)
        Me.gpo4ordeñe.Controls.Add(Me.lblHorai4)
        Me.gpo4ordeñe.Controls.Add(Me.Horai4)
        Me.gpo4ordeñe.Enabled = False
        Me.gpo4ordeñe.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpo4ordeñe.Location = New System.Drawing.Point(592, 224)
        Me.gpo4ordeñe.Name = "gpo4ordeñe"
        Me.gpo4ordeñe.Size = New System.Drawing.Size(226, 128)
        Me.gpo4ordeñe.TabIndex = 64
        Me.gpo4ordeñe.TabStop = False
        Me.gpo4ordeñe.Text = "Cuarto Ordeñe"
        '
        'lblHoraf4
        '
        Me.lblHoraf4.AutoSize = True
        Me.lblHoraf4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraf4.Location = New System.Drawing.Point(19, 71)
        Me.lblHoraf4.Name = "lblHoraf4"
        Me.lblHoraf4.Size = New System.Drawing.Size(65, 20)
        Me.lblHoraf4.TabIndex = 61
        Me.lblHoraf4.Text = "Hora fin"
        '
        'Horaf4
        '
        Me.Horaf4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Horaf4.Location = New System.Drawing.Point(147, 73)
        Me.Horaf4.Name = "Horaf4"
        Me.Horaf4.Size = New System.Drawing.Size(63, 21)
        Me.Horaf4.TabIndex = 62
        '
        'lblHorai4
        '
        Me.lblHorai4.AutoSize = True
        Me.lblHorai4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorai4.Location = New System.Drawing.Point(19, 37)
        Me.lblHorai4.Name = "lblHorai4"
        Me.lblHorai4.Size = New System.Drawing.Size(83, 20)
        Me.lblHorai4.TabIndex = 59
        Me.lblHorai4.Text = "Hora inicio"
        '
        'Horai4
        '
        Me.Horai4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Horai4.Location = New System.Drawing.Point(147, 37)
        Me.Horai4.Name = "Horai4"
        Me.Horai4.Size = New System.Drawing.Size(63, 21)
        Me.Horai4.TabIndex = 60
        '
        'cboTipo
        '
        Me.cboTipo.DisplayMember = "Text"
        Me.cboTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.ItemHeight = 15
        Me.cboTipo.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2})
        Me.cboTipo.Location = New System.Drawing.Point(193, 78)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(121, 21)
        Me.cboTipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboTipo.TabIndex = 116
        Me.cboTipo.WatermarkText = "Ingrese"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Mecanico"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Ternero"
        '
        'TimeSelector1
        '
        Me.TimeSelector1.AutoSize = True
        '
        '
        '
        Me.TimeSelector1.BackgroundStyle.Class = "ItemPanel"
        Me.TimeSelector1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TimeSelector1.ContainerControlProcessDialogKey = True
        Me.TimeSelector1.Location = New System.Drawing.Point(54, 157)
        Me.TimeSelector1.Name = "TimeSelector1"
        Me.TimeSelector1.SelectorType = DevComponents.Editors.DateTimeAdv.eTimeSelectorType.MonthCalendarStyle
        Me.TimeSelector1.Size = New System.Drawing.Size(185, 161)
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
        Me.btnCerrar.Location = New System.Drawing.Point(826, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(29, 45)
        Me.btnCerrar.TabIndex = 128
        '
        'lblOrdeñes
        '
        '
        '
        '
        Me.lblOrdeñes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblOrdeñes.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdeñes.Location = New System.Drawing.Point(360, 0)
        Me.lblOrdeñes.Name = "lblOrdeñes"
        Me.lblOrdeñes.Size = New System.Drawing.Size(107, 52)
        Me.lblOrdeñes.TabIndex = 130
        Me.lblOrdeñes.Text = "<b><font size=""+6""><i></i><font color=""#B02B2C"">Ordeñes</font></font></b>"
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancelar.BackColor = System.Drawing.Color.Firebrick
        Me.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Location = New System.Drawing.Point(244, 380)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(140, 27)
        Me.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancelar.TabIndex = 140
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextColor = System.Drawing.Color.White
        '
        'btnAceptar
        '
        Me.btnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAceptar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Location = New System.Drawing.Point(54, 380)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(140, 27)
        Me.btnAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAceptar.TabIndex = 139
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextColor = System.Drawing.Color.White
        '
        'frmOrdenie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(857, 436)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblOrdeñes)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.TimeSelector1)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.gpo4ordeñe)
        Me.Controls.Add(Me.gpo3ordeñe)
        Me.Controls.Add(Me.gpo2ordeñe)
        Me.Controls.Add(Me.gpo1ordeñe)
        Me.Controls.Add(Me.nudOrdeniesdiarios)
        Me.Controls.Add(Me.lblOrdeniesdiarios)
        Me.Controls.Add(Me.lblTipo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmOrdenie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordeñes"
        CType(Me.nudOrdeniesdiarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpo1ordeñe.ResumeLayout(False)
        Me.gpo1ordeñe.PerformLayout()
        CType(Me.nudHorai1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Horaf1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpo2ordeñe.ResumeLayout(False)
        Me.gpo2ordeñe.PerformLayout()
        CType(Me.Horaf2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Horai2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpo3ordeñe.ResumeLayout(False)
        Me.gpo3ordeñe.PerformLayout()
        CType(Me.Horaf3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Horai3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpo4ordeñe.ResumeLayout(False)
        Me.gpo4ordeñe.PerformLayout()
        CType(Me.Horaf4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Horai4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents nudOrdeniesdiarios As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblOrdeniesdiarios As System.Windows.Forms.Label
    Friend WithEvents lblHorai1 As System.Windows.Forms.Label
    Friend WithEvents gpo1ordeñe As System.Windows.Forms.GroupBox
    Friend WithEvents lblHoraf1 As System.Windows.Forms.Label
    Friend WithEvents Horaf1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents gpo2ordeñe As System.Windows.Forms.GroupBox
    Friend WithEvents lblHoraf2 As System.Windows.Forms.Label
    Friend WithEvents Horaf2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblHorai2 As System.Windows.Forms.Label
    Friend WithEvents Horai2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents gpo3ordeñe As System.Windows.Forms.GroupBox
    Friend WithEvents lblHoraf3 As System.Windows.Forms.Label
    Friend WithEvents Horaf3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblHorai3 As System.Windows.Forms.Label
    Friend WithEvents Horai3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents gpo4ordeñe As System.Windows.Forms.GroupBox
    Friend WithEvents lblHoraf4 As System.Windows.Forms.Label
    Friend WithEvents Horaf4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblHorai4 As System.Windows.Forms.Label
    Friend WithEvents Horai4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents cboTipo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents TimeSelector1 As DevComponents.Editors.DateTimeAdv.TimeSelector
    Friend WithEvents btnCerrar As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents lblOrdeñes As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents nudHorai1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAceptar As DevComponents.DotNetBar.ButtonX
End Class
