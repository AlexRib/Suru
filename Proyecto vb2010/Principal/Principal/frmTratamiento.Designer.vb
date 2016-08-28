<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTratamiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTratamiento))
        Me.btnCerrar = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.btnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.btnAceptar = New DevComponents.DotNetBar.ButtonX()
        Me.lblIDanimal = New System.Windows.Forms.Label()
        Me.lblTratamiento = New System.Windows.Forms.Label()
        Me.lblCausa = New System.Windows.Forms.Label()
        Me.lblMedicacion = New System.Windows.Forms.Label()
        Me.cboCausa = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.cboMedicacion = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.gpoTratamiento = New System.Windows.Forms.GroupBox()
        Me.cboID = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cboTratamiento = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.gpoTratamiento.SuspendLayout()
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
        Me.btnCerrar.Location = New System.Drawing.Point(416, 1)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(29, 45)
        Me.btnCerrar.TabIndex = 128
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancelar.BackColor = System.Drawing.Color.Firebrick
        Me.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Location = New System.Drawing.Point(191, 326)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(93, 27)
        Me.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancelar.TabIndex = 143
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextColor = System.Drawing.Color.White
        '
        'btnAceptar
        '
        Me.btnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAceptar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Location = New System.Drawing.Point(64, 326)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(94, 27)
        Me.btnAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAceptar.TabIndex = 142
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextColor = System.Drawing.Color.White
        '
        'lblIDanimal
        '
        Me.lblIDanimal.AutoSize = True
        Me.lblIDanimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDanimal.Location = New System.Drawing.Point(33, 46)
        Me.lblIDanimal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIDanimal.Name = "lblIDanimal"
        Me.lblIDanimal.Size = New System.Drawing.Size(82, 20)
        Me.lblIDanimal.TabIndex = 144
        Me.lblIDanimal.Text = "ID Animal:"
        '
        'lblTratamiento
        '
        Me.lblTratamiento.AutoSize = True
        Me.lblTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTratamiento.Location = New System.Drawing.Point(33, 104)
        Me.lblTratamiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTratamiento.Name = "lblTratamiento"
        Me.lblTratamiento.Size = New System.Drawing.Size(98, 20)
        Me.lblTratamiento.TabIndex = 172
        Me.lblTratamiento.Text = "Tratamiento:"
        '
        'lblCausa
        '
        Me.lblCausa.AutoSize = True
        Me.lblCausa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCausa.Location = New System.Drawing.Point(33, 160)
        Me.lblCausa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCausa.Name = "lblCausa"
        Me.lblCausa.Size = New System.Drawing.Size(59, 20)
        Me.lblCausa.TabIndex = 174
        Me.lblCausa.Text = "Causa:"
        '
        'lblMedicacion
        '
        Me.lblMedicacion.AutoSize = True
        Me.lblMedicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedicacion.Location = New System.Drawing.Point(33, 216)
        Me.lblMedicacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMedicacion.Name = "lblMedicacion"
        Me.lblMedicacion.Size = New System.Drawing.Size(93, 20)
        Me.lblMedicacion.TabIndex = 176
        Me.lblMedicacion.Text = "Medicacion:"
        '
        'cboCausa
        '
        Me.cboCausa.DisplayMember = "Text"
        Me.cboCausa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboCausa.FormattingEnabled = True
        Me.cboCausa.ItemHeight = 20
        Me.cboCausa.Items.AddRange(New Object() {Me.ComboItem5, Me.ComboItem6, Me.ComboItem7})
        Me.cboCausa.Location = New System.Drawing.Point(171, 154)
        Me.cboCausa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboCausa.Name = "cboCausa"
        Me.cboCausa.Size = New System.Drawing.Size(166, 26)
        Me.cboCausa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboCausa.TabIndex = 178
        Me.cboCausa.WatermarkText = "Ingrese"
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
        'cboMedicacion
        '
        Me.cboMedicacion.DisplayMember = "Text"
        Me.cboMedicacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboMedicacion.FormattingEnabled = True
        Me.cboMedicacion.ItemHeight = 20
        Me.cboMedicacion.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3})
        Me.cboMedicacion.Location = New System.Drawing.Point(171, 210)
        Me.cboMedicacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboMedicacion.Name = "cboMedicacion"
        Me.cboMedicacion.Size = New System.Drawing.Size(166, 26)
        Me.cboMedicacion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboMedicacion.TabIndex = 179
        Me.cboMedicacion.WatermarkText = "Ingrese"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Horlando"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Jersey"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Primer show"
        '
        'gpoTratamiento
        '
        Me.gpoTratamiento.Controls.Add(Me.cboTratamiento)
        Me.gpoTratamiento.Controls.Add(Me.cboID)
        Me.gpoTratamiento.Controls.Add(Me.btnAceptar)
        Me.gpoTratamiento.Controls.Add(Me.btnCancelar)
        Me.gpoTratamiento.Controls.Add(Me.lblIDanimal)
        Me.gpoTratamiento.Controls.Add(Me.lblTratamiento)
        Me.gpoTratamiento.Controls.Add(Me.lblCausa)
        Me.gpoTratamiento.Controls.Add(Me.lblMedicacion)
        Me.gpoTratamiento.Controls.Add(Me.cboCausa)
        Me.gpoTratamiento.Controls.Add(Me.cboMedicacion)
        Me.gpoTratamiento.Location = New System.Drawing.Point(36, 38)
        Me.gpoTratamiento.Name = "gpoTratamiento"
        Me.gpoTratamiento.Size = New System.Drawing.Size(374, 380)
        Me.gpoTratamiento.TabIndex = 192
        Me.gpoTratamiento.TabStop = False
        Me.gpoTratamiento.Text = "Tratamiento"
        '
        'cboID
        '
        Me.cboID.DisplayMember = "Text"
        Me.cboID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboID.FormattingEnabled = True
        Me.cboID.ItemHeight = 20
        Me.cboID.Location = New System.Drawing.Point(171, 46)
        Me.cboID.Name = "cboID"
        Me.cboID.Size = New System.Drawing.Size(166, 26)
        Me.cboID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboID.TabIndex = 180
        Me.cboID.WatermarkText = "Seleccione"
        '
        'cboTratamiento
        '
        Me.cboTratamiento.DisplayMember = "Text"
        Me.cboTratamiento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTratamiento.FormattingEnabled = True
        Me.cboTratamiento.ItemHeight = 20
        Me.cboTratamiento.Location = New System.Drawing.Point(171, 104)
        Me.cboTratamiento.Name = "cboTratamiento"
        Me.cboTratamiento.Size = New System.Drawing.Size(166, 26)
        Me.cboTratamiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboTratamiento.TabIndex = 181
        Me.cboTratamiento.WatermarkText = "Seleccione"
        '
        'frmTratamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(449, 451)
        Me.Controls.Add(Me.gpoTratamiento)
        Me.Controls.Add(Me.btnCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTratamiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tratamientos"
        Me.gpoTratamiento.ResumeLayout(False)
        Me.gpoTratamiento.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCerrar As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents btnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblIDanimal As System.Windows.Forms.Label
    Friend WithEvents lblTratamiento As System.Windows.Forms.Label
    Friend WithEvents lblCausa As System.Windows.Forms.Label
    Friend WithEvents lblMedicacion As System.Windows.Forms.Label
    Friend WithEvents cboCausa As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents cboMedicacion As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents gpoTratamiento As System.Windows.Forms.GroupBox
    Friend WithEvents cboTratamiento As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cboID As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
