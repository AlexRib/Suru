Public Class frmContrae
    Public Sub limpiar()
        cboAnimal.Text = ""
        cboEnf.Text = ""
        dateFecha.Text = ""
        cboCausa.Text = ""
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        sql = "insert into contrae (id_animal, id_enf, causa, fecha) Values (" & cboAnimal.Text & "," & cboEnf.Text & ",'" & cboCausa.Text & "','" & dateFecha.Value.ToString("MM/dd/yyyy") & "')"
        Try
            cn.Execute(sql)
            MsgBox("Registro guardado correctamente.", MsgBoxStyle.Information, "Atención")
            limpiar()
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try
    End Sub

    Private Sub frmEnf_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        sql = "select * from animal"
        Try
            rs.Open(sql, cn)
            cboAnimal.Items.Clear()
        Catch ex As Exception
            MsgBox("Error al buscar los datos.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        While Not rs.EOF
            cboAnimal.Items.Add(rs("id_animal").Value)
            rs.MoveNext()
        End While
        rs.Close()

        sql = "select * from Enfermedad"
        Try
            rs.Open(sql, cn)
            cboEnf.Items.Clear()
        Catch ex As Exception
            MsgBox("Error al buscar los datos.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        While Not rs.EOF
            cboEnf.Items.Add(rs("id_enf").Value)
            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub
End Class