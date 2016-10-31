Public Class frmVaca
    Dim Hembra As String
    Public Sub cargar_vaca()
        sql = "select * from vaca, animal where id_vaca=id_animal and x=1"
        Try
            rs.Open(sql, cn)
            cboBuscar.Items.Clear()
        Catch ex As Exception
            MsgBox("Ocurrió un error.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        While Not rs.EOF
            cboBuscar.Items.Add(rs("id_vaca").Value)
            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    Public Sub cargargrilla()
        sql = "select * from animal,vaca where id_animal=id_vaca and x=1"
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("No se pudo cargar el listado de vacas")
            Exit Sub
        End Try
        If Not cargoGrilla(rs, DataGridView1) Then
            MsgBox("No se pudo cargar el listado de animales")
        End If
        rs.Close()
    End Sub

    Public Sub Limpiar()
        cboBuscar.Text = ""
        txtNombre.Text = ""
        dateNacimiento.Text = ""
        cboTipo.Text = ""
        cboRaza.Text = ""
        btnCrear.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Public Sub Estado2()
        btnCrear.Enabled = False
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
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
            Exit Sub
        End Try

        sql = "delete from animal where id_animal=" & Val(cboBuscar.Text)
        Try
            cn.Execute(sql)
            MsgBox("Animal eliminado del registro.", MsgBoxStyle.Information, "Atención")
            Limpiar()
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try
        cargar_vaca()
        cargargrilla()
        btnCrear.Enabled = True
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        btnCrear.Enabled = False
        sql = "select * from animal where x=1 and id_animal=" & Val(cboBuscar.Text)
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
            dateNacimiento.Value = rs("fecha_nac").Value
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
        Else
            MsgBox("No se encontro el animal.", MsgBoxStyle.Exclamation, "Atención")
        End If
        rs.Close()
    End Sub

    Private Sub btnCrear_Click(sender As System.Object, e As System.EventArgs) Handles btnCrear.Click
        Dim idvaca As Integer
        sql = "insert into animal (nom_animal, sexo, raza, fecha_nac, x) Values ('" & _
            txtNombre.Text & "','" & "Hembra" & "','" & cboRaza.Text & "','" & _
            dateNacimiento.Value.ToString("dd/MM/yyyy") & "','" & 1 & "')"
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

        sql = "insert into vaca (id_vaca, tipo) Values (" & idvaca & ",'" & cboTipo.Text & "')"
        Try
            MsgBox("Animal guardado correctamente.", MsgBoxStyle.Information, "Atención")
            cn.Execute(sql)
            Limpiar()
        Catch ex As Exception
            Exit Sub
        End Try
        Limpiar()
        cargar_vaca()
        cargargrilla()
    End Sub

    Private Sub btnCancelar_Click_2(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Limpiar()
        btnCrear.Enabled = True
    End Sub

    Private Sub frmVaca_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        'sql = "select nom_animal from vaca, animal where id_vaca=id_animal"
        cargar_vaca()
        cargargrilla()
    End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
        sql = "update animal set nom_animal='" & txtNombre.Text & "', raza='" & cboRaza.Text & "'  where id_animal=" & cboBuscar.Text & "; update vaca set tipo='" & cboTipo.Text & "'  where id_vaca=" & cboBuscar.Text & ""
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
        cargar_vaca()
        cargargrilla()
    End Sub

End Class