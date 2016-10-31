Public Class frmMenu

    Public Sub cerrar_sesion()
        NotifyIcon1.ShowBalloonTip(3500, "Atención", "Cerrando sesión...", ToolTipIcon.Info)
        System.Threading.Thread.Sleep(3500)
        cn.Close()
        Me.Visible = False
        System.Threading.Thread.Sleep(2000)
        frmLogin.Show()
    End Sub

    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        frmSplash.Show()
    End Sub

    Sub GestionarClientPanel()
        If XtraTabbedMdiManager1.Pages.Count = 0 Then
            'ClientPanel.Visible = True()
            Panel2.Visible = True
        Else
            Panel2.Visible = False
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblFecha2.Text = DateString
        lblHora2.Text = TimeOfDay
    End Sub

    Private Sub ButtonItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdenie1.Click
        frmOrdenie.MdiParent = Me
        frmOrdenie.Show()
    End Sub

    Private Sub ButtonItem19_Click(sender As System.Object, e As System.EventArgs) Handles ButtonItem19.Click
        End
    End Sub

    Private Sub ButtonItem25_Click(sender As System.Object, e As System.EventArgs) Handles btnMenuSalir.Click
        If MsgBox("Está seguro que desea salir del programa", MsgBoxStyle.YesNo, "Salir") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnUsuarios_Click(sender As System.Object, e As System.EventArgs)
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        'Mostrar frmMenu
        NotifyIcon1.ShowBalloonTip(5000, "Información", "El formulario se ha mostrado", ToolTipIcon.Info)
        Me.Show()
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AbrirToolStripMenuItem.Click
        NotifyIcon1.ShowBalloonTip(5000, "Información", "El formulario se ha mostrado", ToolTipIcon.Info)
        Me.Show()
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        If MsgBox("Está seguro que desea salir del programa", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub ButtonItem10_Click_1(sender As System.Object, e As System.EventArgs) Handles btnUsuario.Click
        frmUsuario.MdiParent = Me
        frmUsuario.Show()
    End Sub

    Private Sub btnCrias_Click(sender As System.Object, e As System.EventArgs) Handles btnCrias.Click
        frmCria.MdiParent = Me
        frmCria.Show()
    End Sub

    Private Sub ButtonItem5_Click(sender As System.Object, e As System.EventArgs) Handles btnEnf2.Click
        frmContrae.MdiParent = Me
        frmContrae.Show()
    End Sub

    Private Sub ButtonItem12_Click(sender As System.Object, e As System.EventArgs) Handles btnEnf4.Click
        frmServicio.MdiParent = Me
        frmServicio.Show()
    End Sub

    Private Sub btnVacas_Click(sender As System.Object, e As System.EventArgs) Handles btnVacas.Click
        frmVaca.MdiParent = Me
        frmVaca.Show()
    End Sub

    Private Sub btnToros_Click(sender As System.Object, e As System.EventArgs) Handles btnToros.Click
        frmToro.MdiParent = Me
        frmToro.Show()
    End Sub

    Private Sub Button3_Click_1(sender As System.Object, e As System.EventArgs)
        frmNavegar.Show()
    End Sub

    Private Sub XtraTabbedMdiManager1_PageAdded(sender As Object, e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageAdded
        GestionarClientPanel()
    End Sub

    Private Sub XtraTabbedMdiManager1_PageRemoved(sender As Object, e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageRemoved
        GestionarClientPanel()
    End Sub

    Private Sub Panel2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint
        Timer1.Start()
        Timer1.Interval = 20
    End Sub

    Private Sub btnDeclararestado_Click(sender As System.Object, e As System.EventArgs) Handles btnEst1.Click
        frmEstado.MdiParent = Me
        frmEstado.Show()
    End Sub

    Private Sub btnSer1_Click(sender As System.Object, e As System.EventArgs) Handles btnSer1.Click
        frmServicio.MdiParent = Me
        frmServicio.Show()
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        If SwitchButton1.Value = False Then
            NotifyIcon1.ShowBalloonTip(4000, "Información", "Minimizado. Estado: Desconectado", ToolTipIcon.Info)
        Else
            NotifyIcon1.ShowBalloonTip(4000, "Información", "Minimizado. Estado: Conectado", ToolTipIcon.Info)
        End If
        Me.Hide()
    End Sub

    Private Sub btnENf1_Click(sender As System.Object, e As System.EventArgs) Handles btnEnf1.Click
        frmEnfermedad.Show()
    End Sub

    Private Sub btnAbo1_Click(sender As System.Object, e As System.EventArgs) Handles btnAbo1.Click

    End Sub

    Private Sub btnNavegar_Click(sender As System.Object, e As System.EventArgs) Handles btnNavegar.Click
        frmNavegar.MdiParent = Me
        frmNavegar.Show()
    End Sub

    Private Sub btnTra2_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnMenuOpciones_Click(sender As System.Object, e As System.EventArgs) Handles btnMenuOpciones.Click
        cerrar_sesion()
    End Sub

    Private Sub SwitchButton1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles SwitchButton1.ValueChanged

    End Sub

    Private Sub RibbonControl_Click(sender As System.Object, e As System.EventArgs) Handles RibbonControl.Click

    End Sub

    Private Sub btnTra3_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnVic1_Click(sender As System.Object, e As System.EventArgs) Handles btnVic1.Click
        frmVictima.MdiParent = Me
        frmVictima.Show()
    End Sub

    Private Sub btnTra1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        frmRecria.MdiParent = Me
        frmRecria.Show()
    End Sub

    Private Sub btnTambo2_Click(sender As System.Object, e As System.EventArgs) Handles btnTambo.Click
        frmTambo.MdiParent = Me
        frmTambo.Show()
    End Sub

    Private Sub btnCam1_Click(sender As System.Object, e As System.EventArgs) Handles btnCam1.Click
        frmRecria.MdiParent = Me
        frmRecria.Show()
    End Sub

End Class