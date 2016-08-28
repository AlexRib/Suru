Public Class frmAborto

    Public Sub limpiar()
        cboVaca.Text = ""
        dateFechaAborto.Text = ""
        cboCausa.Text = ""
        txtCriasPerdidas.Text = ""
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ReflectionImage1_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub
End Class