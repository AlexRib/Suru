Public Class frmToro

    Public Sub cargtoro()
        sql = "select * from animal, toro where id_animal=id_toro and x=1"
        Try
            rs.Open(sql, cn)
            cboBuscar.Items.Clear()
        Catch ex As Exception
            MsgBox("Error al buscar los datos.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        While Not rs.EOF
            cboBuscar.Items.Add(rs("id_toro").Value)
            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    Public Sub cargar_toroo()
        sql = "select nom_animal from toro, animal where id_toro=id_animal"
        Try
            rs.Open(sql, cn)
            cboBuscar.Items.Clear()
        Catch ex As Exception
            MsgBox("Error al buscar el Usuario.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        While Not rs.EOF
            cboBuscar.Items.Add(rs("nom_animal").Value)
            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    Public Sub cargargrilla()
        sql = "select * from animal,toro where id_animal=id_toro and x=1"
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

    Public Sub filtrar()
        sql = "select * from toro, animal where id_toro=id_animal and nom_animal=%like" & txtFIltrar.Text & ""
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al buscar los datos.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        If Not cargoGrilla(rs, DataGridView1) Then
            MsgBox("No se pudo cargar el listado de animales")
        End If
        rs.Close()
    End Sub

    Public Sub alertas(ByRef combo As ComboBox)
        sql = "select * from animal where day(current) = day(fecha_nac) and month(current) = month(fecha_nac)"

    End Sub

    Public Sub limpiar()
        cboBuscar.Text = ""
        txtNombre.Text = ""
        cboRaza.Text = ""
        dateNacimiento.Text = ""
        cboTipo.Text = ""
        cboRaza.Text = ""
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Private Sub ReflectionImage1_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        sql = "delete from toro where id_toro=" & Val(cboBuscar.Text)
        Try
            MsgBox(sql)
            If MsgBox("¿Está seguro que desea eliminar el registro?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cn.Execute(sql)
            End If
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos1.", MsgBoxStyle.Exclamation, "Error")
            btnCrear.Enabled = True
            Exit Sub
        End Try

        sql = "delete from animal where id_animal=" & Val(cboBuscar.Text)
        Try
            cn.Execute(sql)
            MsgBox("Animal eliminado del registro.", MsgBoxStyle.Information, "Atención")
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            limpiar()
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            btnCrear.Enabled = True
            Exit Sub
        End Try
        btnCrear.Enabled = True
        cargar_toroo()
        cargargrilla()
    End Sub

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles btnCrear.Click
        Dim idtoro As Integer
        sql = "insert into animal (nom_animal, sexo, raza, fecha_nac, x) Values ('" & _
            txtNombre.Text & "','" & "Macho" & "','" & cboRaza.Text & "','" & _
            dateNacimiento.Value.ToString("dd/MM/yyyy") & "'," & 1 & ")"
        Try
            MsgBox(sql)
            cn.Execute(sql)
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try

        'Con lo siguiente capturaremos el último ID ingresado en la última tabla.
        'Es decir, tomaremos el último ID ingresado en la tabla Animal para luego ingresar ese ID
        'en la tabla Toro.
        'Con eso logramos que la id_animal e id_toro coincidan.
        sql = "select max (dbinfo('sqlca.sqlerrd1')) from animal"
        Try
            rs.Open(sql, cn)
            idtoro = rs(0).Value
            rs.Close()
        Catch ex As Exception
            MsgBox("Ocurrió un error", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try

        sql = "insert into toro (id_toro, tipo) Values (" & idtoro & ",'" & cboTipo.Text & "')"
        Try
            cn.Execute(sql)
            MsgBox("Animal registrado correctamente.", MsgBoxStyle.Information, "Atención")
            limpiar()
        Catch ex As Exception
            Exit Sub
        End Try
        cargar_toroo()
        cargargrilla()
    End Sub

    Private Sub frmToro_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        cargtoro()
        cargargrilla()
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        btnCrear.Enabled = False
        sql = "select * from animal where x=1 and id_animal=" & Val(cboBuscar.Text)
        Try
            MsgBox(sql)
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al buscar el Animal.", MsgBoxStyle.Exclamation, "Atención")
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
            btnCrear.Enabled = True
        End If
        rs.Close()

        sql = "select * from toro where id_toro=" & Val(cboBuscar.Text)
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            Exit Sub
        End Try
        If rs.RecordCount = 1 Then
            cboTipo.Text = rs("tipo").Value
        Else
        End If
        rs.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        limpiar()
        btnCrear.Enabled = True
    End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
        sql = "update animal set nom_animal='" & txtNombre.Text & "', raza='" & cboRaza.Text & "'  where id_animal=" & cboBuscar.Text & "; update toro set tipo='" & cboTipo.Text & "'  where id_toro=" & cboBuscar.Text & ""
        Try
            cn.Execute(sql)
            MsgBox("Modificación exitosa.", MsgBoxStyle.Information, "Atención")
            btnCrear.Enabled = True
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try
        limpiar()
        btnCrear.Enabled = True
        cargar_toroo()
        cargargrilla()
    End Sub

End Class