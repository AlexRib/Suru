Public Class frmNavegar
    Dim p As Integer = 1
    Private Sub frmNavegar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim browse As New WebBrowser
        TabControl1.TabPages.Add(p, "Página" & p)
        TabControl1.SelectTab(p - 1)
        browse.Name = "anjes"
        browse.Dock = DockStyle.Fill
        TabControl1.SelectedTab.Controls.Add(browse)
        p = p + 1
    End Sub

    Private Sub ButtonX5_Click(sender As System.Object, e As System.EventArgs) Handles btnIr.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate(txtUrl.Text)
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
    End Sub

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
    End Sub

    Private Sub ButtonX4_Click(sender As System.Object, e As System.EventArgs)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
    End Sub

    Private Sub ButtonX3_Click(sender As System.Object, e As System.EventArgs)
        Dim browse As New WebBrowser
        TabControl1.TabPages.Add(p, "Página" & p)
        TabControl1.SelectTab(p - 1)
        browse.Name = "anjes"
        browse.Dock = DockStyle.Fill
        TabControl1.SelectedTab.Controls.Add(browse)
        p = p + 1
    End Sub

    Private Sub btnUsuarios_Click(sender As System.Object, e As System.EventArgs) Handles btnRecargar.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnAtras.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoBack()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnAdelante.Click
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).GoForward()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim browse As New WebBrowser
        TabControl1.TabPages.Add(p, "Página" & p)
        TabControl1.SelectTab(p - 1)
        browse.Name = "anjes"
        browse.Dock = DockStyle.Fill
        TabControl1.SelectedTab.Controls.Add(browse)
        p = p + 1
    End Sub

    Private Sub ReflectionImage1_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

End Class