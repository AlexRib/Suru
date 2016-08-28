Public Class frmVaca
    Public Sub Limpiar()
        cboBuscar.Text = ""
        txtNombre.Text = ""
        dateNacimiento.Text = ""
        cboTipo.Text = ""
        cboRaza.Text = ""
        txtCantcrias.Text = ""
        txtCantpariciones.Text = ""
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub
    Private Sub btnVolver_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ReflectionImage1_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        sql = "delete from vaca where id_vaca=" & Val(cboBuscar.Text)
        Try
            If MsgBox("¿Está seguro que desea eliminar el registro?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cn.Execute(sql)
            End If
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            btnCrear.Enabled = True
            Exit Sub
        End Try

        sql = "delete from animal where id_animal=" & Val(cboBuscar.Text)
        Try
            cn.Execute(sql)
            MsgBox("Animal eliminado del registro.", MsgBoxStyle.Information, "Atención")
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            Limpiar()
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            btnCrear.Enabled = True
            Exit Sub
        End Try
        btnCrear.Enabled = True
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        btnCrear.Enabled = False
        sql = "select * from animal where id_animal=" & Val(cboBuscar.Text)
        Try
            rs.Open(sql, cn)
            btnCrear.Enabled = False
        Catch ex As Exception
            MsgBox("Error al buscar el Animal.", MsgBoxStyle.Exclamation, "Atención")
            btnCrear.Enabled = True
            Exit Sub
        End Try
        If rs.RecordCount = 1 Then
            txtNombre.Text = rs("nom_animal").Value
            cboRaza.Text = rs("raza").Value
            'dateNacimiento = rs("fecha_nac").Value
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        Else
            MsgBox("No se encontro el animal.", MsgBoxStyle.Exclamation, "Atención")
        End If
        rs.Close()

        sql = "select * from vaca where id_vaca=" & Val(cboBuscar.Text)
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            Exit Sub
        End Try
        If rs.RecordCount = 1 Then
            cboTipo.Text = rs("tipo").Value
            txtCantcrias.Text = rs("cant_crias").Value
            txtCantpariciones.Text = rs("cant_pariciones").Value
        Else
            MsgBox("No se encontro el animal.", MsgBoxStyle.Exclamation, "Atención")
        End If
        rs.Close()
    End Sub

    Private Sub btnCrear_Click(sender As System.Object, e As System.EventArgs) Handles btnCrear.Click
        Dim idvaca As Integer
        sql = "insert into animal (nom_animal, sexo, raza, fecha_nac) Values ('" & _
            txtNombre.Text & "','" & "Hembra" & "','" & cboRaza.Text & "','" & _
            dateNacimiento.Value.ToString("MM/dd/yyyy") & "')"
        Try
            cn.Execute(sql)
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try
        sql = "select max (dbinfo('sqlca.sqlerrd1')) from animal"

        Try
            rs.Open(sql, cn)
            idvaca = rs(0).Value
            rs.Close()
        Catch ex As Exception
            MsgBox("Ocurrió un error", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try

        sql = "insert into vaca (id_vaca, tipo, cant_crias, cant_pariciones) Values (" & idvaca & ",'" & cboTipo.Text & "'," & txtCantcrias.Text & "," & txtCantpariciones.Text & ")"
        Try
            MsgBox("Animal guardado correctamente.", MsgBoxStyle.Information, "Atención")
            cn.Execute(sql)
            Limpiar()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btnCancelar_Click_2(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Limpiar()
        btnCrear.Enabled = True
    End Sub

    Private Sub frmVaca_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        sql = "select * from vaca"
        Try
            rs.Open(sql, cn)
            cboBuscar.Items.Clear()
        Catch ex As Exception
            MsgBox("Error al buscar los datos.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        While Not rs.EOF
            cboBuscar.Items.Add(rs("id_vaca").Value)
            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
        sql = "update animal set nom_animal='" & txtNombre.Text & "', raza='" & cboRaza.Text & "'  where id_animal=" & cboBuscar.Text & "; update vaca set tipo='" & cboTipo.Text & "', cant_pariciones=" & txtCantpariciones.Text & ", cant_crias='" & txtCantcrias.Text & "'  where id_vaca=" & cboBuscar.Text & ""
        Try
            cn.Execute(sql)
            MsgBox("Modificación exitosa.", MsgBoxStyle.Information, "Atención")
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            btnCrear.Enabled = True
            Exit Sub
        End Try
        Limpiar()
        btnCrear.Enabled = True
    End Sub
End Class