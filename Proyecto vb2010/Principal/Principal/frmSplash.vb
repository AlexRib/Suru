﻿Public Class frmSplash

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar2.Visible = False
        ProgressBar2.Increment(1)
        MarqueeProgressBarControl1.Enabled = True
        If (ProgressBar2.Value = 99) Then
            Timer1.Stop()
            Me.Hide()
            System.Threading.Thread.Sleep(2000)
            MarqueeProgressBarControl1.Enabled = False
            frmLogin.Show()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer1.Interval = 45
    End Sub

End Class