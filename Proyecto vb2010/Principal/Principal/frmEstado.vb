Public Class frmEstado

    Public Sub limpiar()
        cboBuscar.Text = ""
        cboVaca.Text = ""
        cboEstado.Text = ""
        dateFechaI.Text = ""
        dateFechaF.Text = ""
    End Sub

    Private Sub frmEstado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        sql = "select * from vaca"
        Try
            rs.Open(sql, cn)
            cboVaca.Items.Clear()
        Catch ex As Exception
            MsgBox("Error al buscar los datos.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        While Not rs.EOF
            cboVaca.Items.Add(rs("id_vaca").Value)
            rs.MoveNext()
        End While
        rs.Close()

        sql = "select * from estado"
        Try
            rs.Open(sql, cn)
            cboEstado.Items.Clear()
        Catch ex As Exception
            MsgBox("Error al buscar los datos.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        While Not rs.EOF
            cboEstado.Items.Add(rs("id_estado").Value)
            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    Private Sub btnRegistrar_Click(sender As System.Object, e As System.EventArgs) Handles btnRegistrar.Click
        sql = "insert into tiene (id_vaca, id_estado, fecha_inicio, fecha_fin) Values (" & cboVaca.Text & ",'" & cboEstado.Text & "','" & dateFechaI.Value.ToString("MM/dd/yyyy") & "','" & dateFechaF.Value.ToString("MM/dd/yyyy") & "')"
        Try
            cn.Execute(sql)
            MsgBox("Registro guardado correctamente.", MsgBoxStyle.Information, "Atención")
            limpiar()
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class