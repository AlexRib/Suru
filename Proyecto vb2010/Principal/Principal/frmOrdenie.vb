Public Class frmOrdenie

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs)
        gpo1ordeñe.Enabled = False
        gpo2ordeñe.Enabled = False
        gpo3ordeñe.Enabled = False
        gpo4ordeñe.Enabled = False
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs)
        If nudOrdeniesdiarios.Text = 1 Then
            gpo1ordeñe.Enabled = True
            gpo2ordeñe.Enabled = False
            gpo3ordeñe.Enabled = False
            gpo4ordeñe.Enabled = False
        End If
        If nudOrdeniesdiarios.Text = 2 Then
            gpo1ordeñe.Enabled = True
            gpo2ordeñe.Enabled = True
            gpo3ordeñe.Enabled = False
            gpo4ordeñe.Enabled = False

        End If
        If nudOrdeniesdiarios.Text = 3 Then
            gpo1ordeñe.Enabled = True
            gpo2ordeñe.Enabled = True
            gpo3ordeñe.Enabled = True
            gpo4ordeñe.Enabled = False
        End If
        If nudOrdeniesdiarios.Text = 4 Then
            gpo1ordeñe.Enabled = True
            gpo2ordeñe.Enabled = True
            gpo3ordeñe.Enabled = True
            gpo4ordeñe.Enabled = True
        End If
    End Sub

    Private Sub btnVolver_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ReflectionImage1_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub ButtonX1_Click_1(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        cboTipo.Text = ""
        gpo1ordeñe.Enabled = False
        gpo2ordeñe.Enabled = False
        gpo3ordeñe.Enabled = False
        gpo4ordeñe.Enabled = False
    End Sub
End Class