<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNavegar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNavegar))
        Me.txtUrl = New DevComponents.DotNetBar.Controls.MaskedTextBoxAdv()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.btnCerrar = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnAdelante = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnRecargar = New System.Windows.Forms.Button()
        Me.btnIr = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUrl
        '
        '
        '
        '
        Me.txtUrl.BackgroundStyle.Class = "TextBoxBorder"
        Me.txtUrl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUrl.ButtonClear.Visible = True
        Me.txtUrl.Location = New System.Drawing.Point(170, 10)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(355, 19)
        Me.txtUrl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txtUrl.TabIndex = 64
        Me.txtUrl.Text = ""
        Me.txtUrl.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty
        Me.txtUrl.WatermarkText = "Ingrese URL"
        '
        'TabControl1
        '
        Me.TabControl1.Location = New System.Drawing.Point(12, 70)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(865, 438)
        Me.TabControl1.TabIndex = 66
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.btnCerrar)
        Me.PanelEx1.Controls.Add(Me.btnAdd)
        Me.PanelEx1.Controls.Add(Me.btnAdelante)
        Me.PanelEx1.Controls.Add(Me.btnAtras)
        Me.PanelEx1.Controls.Add(Me.btnRecargar)
        Me.PanelEx1.Controls.Add(Me.txtUrl)
        Me.PanelEx1.Controls.Add(Me.btnIr)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(889, 36)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 67
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
        Me.btnCerrar.Location = New System.Drawing.Point(857, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(29, 45)
        Me.btnCerrar.TabIndex = 124
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(631, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(31, 27)
        Me.btnAdd.TabIndex = 68
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnAdelante
        '
        Me.btnAdelante.BackColor = System.Drawing.Color.Transparent
        Me.btnAdelante.BackgroundImage = CType(resources.GetObject("btnAdelante.BackgroundImage"), System.Drawing.Image)
        Me.btnAdelante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdelante.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdelante.FlatAppearance.BorderSize = 0
        Me.btnAdelante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAdelante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAdelante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdelante.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdelante.ForeColor = System.Drawing.Color.Black
        Me.btnAdelante.Location = New System.Drawing.Point(44, 3)
        Me.btnAdelante.Name = "btnAdelante"
        Me.btnAdelante.Size = New System.Drawing.Size(30, 30)
        Me.btnAdelante.TabIndex = 67
        Me.btnAdelante.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdelante.UseVisualStyleBackColor = False
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.Transparent
        Me.btnAtras.BackgroundImage = CType(resources.GetObject("btnAtras.BackgroundImage"), System.Drawing.Image)
        Me.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAtras.FlatAppearance.BorderSize = 0
        Me.btnAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.ForeColor = System.Drawing.Color.Black
        Me.btnAtras.Location = New System.Drawing.Point(8, 3)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(30, 30)
        Me.btnAtras.TabIndex = 66
        Me.btnAtras.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'btnRecargar
        '
        Me.btnRecargar.BackColor = System.Drawing.Color.Transparent
        Me.btnRecargar.BackgroundImage = CType(resources.GetObject("btnRecargar.BackgroundImage"), System.Drawing.Image)
        Me.btnRecargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRecargar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecargar.FlatAppearance.BorderSize = 0
        Me.btnRecargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRecargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecargar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecargar.ForeColor = System.Drawing.Color.Black
        Me.btnRecargar.Location = New System.Drawing.Point(132, 1)
        Me.btnRecargar.Name = "btnRecargar"
        Me.btnRecargar.Size = New System.Drawing.Size(32, 32)
        Me.btnRecargar.TabIndex = 65
        Me.btnRecargar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRecargar.UseVisualStyleBackColor = False
        '
        'btnIr
        '
        Me.btnIr.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnIr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIr.Location = New System.Drawing.Point(541, 6)
        Me.btnIr.Name = "btnIr"
        Me.btnIr.Size = New System.Drawing.Size(75, 23)
        Me.btnIr.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnIr.TabIndex = 4
        Me.btnIr.Text = "Ir"
        '
        'frmNavegar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(889, 520)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNavegar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Navegar"
        Me.PanelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtUrl As DevComponents.DotNetBar.Controls.MaskedTextBoxAdv
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnRecargar As System.Windows.Forms.Button
    Friend WithEvents btnAdelante As System.Windows.Forms.Button
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnIr As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As DevComponents.DotNetBar.Controls.ReflectionImage
End Class
