Public Class frmTambo
    Dim idtambo As Integer
    Public Sub cargar_tambo()
        sql = "select * from tambo"
        Try
            rs.Open(sql, cn)
            cboBuscar.Items.Clear()
        Catch ex As Exception
            MsgBox("Error al buscar el Tambo.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        While Not rs.EOF
            cboBuscar.Items.Add(rs("nom_tambo").Value)
            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    Public Sub cargargrilla()
        sql = "select * from tambo"
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("No tiene ningun listado de tambos", MsgBoxStyle.Information, "Atención")
            Exit Sub
        End Try
        If Not cargoGrilla(rs, DataGridView1) Then
            MsgBox("No tiene ningun listado de tambos", MsgBoxStyle.Information, "Atención")
        End If
        rs.Close()
    End Sub

    Public Sub capturar_maximo()
        sql = "select max (dbinfo('sqlca.sqlerrd1')) from tambo"
        Try
            rs.Open(sql, cn)
            idtambo = rs(0).Value
            rs.Close()
        Catch ex As Exception
            MsgBox("Ocurrió un error", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try
    End Sub

    Public Sub inserto_tel()
        sql = "insert into tel_tambo (id_tambo, tel_tambo) Values (" & idtambo & ",'" & txtTel.Text & "')"
        Try
            MsgBox(sql)
            cn.Execute(sql)
        Catch ex As Exception
            MsgBox("Error al ingresar el registro", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
    End Sub

    Public Sub inserto_cel()
        sql = "insert into tel_tambo (id_tambo, tel_tambo) Values (" & idtambo & ",'" & txtCel.Text & "')"
        Try
            cn.Execute(sql)
        Catch ex As Exception
            MsgBox("Error al ingresar el registro", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
    End Sub

    Public Sub Limpiar()
        cboBuscar.Text = ""
        txtNombre.Text = ""
        cboSector.Text = ""
        txtTel.Text = ""
        txtCalle.Text = ""
        txtNro.Text = ""
        txtCel.Text = ""
        btnCrear.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmTambo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        gpoDatos.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        cargar_tambo()
        cargargrilla()
    End Sub

    Private Sub btnCrear_Click(sender As System.Object, e As System.EventArgs) Handles btnCrear.Click
        sql = "insert into tambo (nom_tambo, calle_tambo, num_tambo, sector) Values ('" & txtNombre.Text & "','" & txtCalle.Text & "'," & txtNro.Text & ",'" & cboSector.Text & "')"
        Try
            MsgBox(sql)
            cn.Execute(sql)
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try

        capturar_maximo()

        'Inserto Tel
        If txtTel.Text <> "" Then
            inserto_tel()
        End If

        'Inserto Cel
        If txtCel.Text <> "" Then
            inserto_cel()
        End If
        MsgBox("Usuario registrado correctamente.", MsgBoxStyle.Information, "Atención")
        Limpiar()
        cargar_tambo()
        cargargrilla()
    End Sub




    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        sql = "delete from tel_tambo where id_tambo=(select id_tambo from tambo where nom_tambo='" & cboBuscar.Text & "')"
        Try
            If MsgBox("¿Está seguro que desea eliminar el tambo y sus registros?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cn.Execute(sql)
            End If
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try

        sql = "delete from tambo where nom_tambo='" & cboBuscar.Text & "'"
        Try
            cn.Execute(sql)
            MsgBox("Usuario eliminado con éxito", MsgBoxStyle.Information, "Atención")
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try
        Limpiar()
        cargar_tambo()
        cargargrilla()
    End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
        sql = "update tel_tambo set tel_tambo='" & txtTel.Text & "') where id_tambo=(select id_tambo from tambo where nom_tambo='" & cboBuscar.Text & "')"
        Try
            cn.Execute(sql)
        Catch ex As Exception

        End Try

        sql = "update tambo set nom_tambo='" & txtNombre.Text & "', calle_tambo='" & txtCalle.Text & "', num_tambo=" & txtNro.Text & ", sector='" & cboSector.Text & "'  where nom_tambo='" & cboBuscar.Text & "'"
        Try
            cn.Execute(sql)
            MsgBox("Modificación exitosa", MsgBoxStyle.Information, "Atención")
        Catch ex As Exception
            MsgBox("Se produjo un error", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        Limpiar()
        cargar_tambo()
        cargargrilla()
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        sql = "select * from tambo where nom_tambo='" & cboBuscar.Text & "'"
        '; select * from tel_tambo where id_tambo=(select * from tambo where nom_tambo='" & cboBuscar.Text & "')
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al buscar el Usuario.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        If rs.RecordCount = 1 Then
            txtNombre.Text = rs("nom_tambo").Value
            cboSector.Text = rs("sector").Value
            txtCalle.Text = rs("calle_tambo").Value
            txtNro.Text = rs("num_tambo").Value
            'txtTel.Text = rs("tel_tambo").Value
            btnCrear.Enabled = False
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        Else
            MsgBox("No se encontró el usuario.", MsgBoxStyle.Exclamation, "Atención")
        End If
        rs.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Limpiar()
    End Sub
End Class