Public Class frmInicio
    Dim NewPoint As New System.Drawing.Point
    Dim X, Y As Integer


    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.X - Me.Location.Y
    End Sub
    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If
    End Sub
    Private Sub btnCerrar_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.MouseDown
        Me.btnCerrar.Image = My.Resources.BtB
    End Sub
    Private Sub btnCerrar_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.MouseEnter
        Me.btnCerrar.Image = My.Resources.BtnC
    End Sub
    Private Sub btnCerrar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.MouseLeave
        Me.btnCerrar.Image = My.Resources.BtB
    End Sub
    Private Sub btnCerrar_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.MouseUp
        Me.btnCerrar.Image = My.Resources.BtnC
    End Sub
    Private Sub btnMinimizar_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.MouseDown
        Me.btnMinimizar.Image = My.Resources.BtB
    End Sub
    Private Sub btnMinimizar_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.MouseEnter
        Me.btnMinimizar.Image = My.Resources.BtnM
    End Sub
    Private Sub btnMinimizar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.MouseLeave
        Me.btnMinimizar.Image = My.Resources.BtB
    End Sub
    Private Sub btnMinimizar_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.MouseUp
        Me.btnMinimizar.Image = My.Resources.BtnM
    End Sub

    Private Sub btnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Titulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Titulo.Click

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
