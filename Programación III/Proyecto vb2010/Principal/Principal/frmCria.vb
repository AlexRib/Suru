Public Class frmCria

    Public Sub crear_cria_m()
        Dim idcria As Integer
        sql = "insert into animal (nom_animal, sexo, raza, fecha_nac, x) Values ('" & _
            txtNombre.Text & "','" & "Macho" & "','" & cboRaza.Text & "','" & _
            dateNacimiento.Value.ToString("dd/MM/yyyy") & "', " & 1 & ")"
        Try
            cn.Execute(sql)
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try

        'Con lo siguiente capturaremos el último ID ingresado en la última tabla.
        'Es decir, tomaremos el último ID ingresado en la tabla Animal para luego ingresar ese ID
        'en la tabla Cria.
        'Con eso logramos que la id_animal e id_cria coincidan.
        sql = "select max (dbinfo('sqlca.sqlerrd1')) from animal"
        Try
            rs.Open(sql, cn)
            idcria = rs(0).Value
            rs.Close()
        Catch ex As Exception
            MsgBox("Ocurrió un error", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try

        sql = "insert into cria (id_cria, id_toro, id_vaca) Values (" & idcria & "," & cboToro.Text & ",'" & cboVaca.Text & "')"
        Try
            cn.Execute(sql)
            MsgBox("Cria registrada correctamente.", MsgBoxStyle.Information, "Atención")
            limpiar()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Public Sub crear_cria_h()
        Dim idcria As Integer
        sql = "insert into animal (nom_animal, sexo, raza, fecha_nac, x) Values ('" & _
            txtNombre.Text & "','" & "Hembra" & "','" & cboRaza.Text & "','" & _
            dateNacimiento.Value.ToString("dd/MM/yyyy") & "', " & 1 & ")"
        Try
            cn.Execute(sql)
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try

        'Con lo siguiente capturaremos el último ID ingresado en la última tabla.
        'Es decir, tomaremos el último ID ingresado en la tabla Animal para luego ingresar ese ID
        'en la tabla Cria.
        'Con eso logramos que la id_animal e id_cria coincidan.
        sql = "select max (dbinfo('sqlca.sqlerrd1')) from animal"
        Try
            rs.Open(sql, cn)
            idcria = rs(0).Value
            rs.Close()
        Catch ex As Exception
            MsgBox("Ocurrió un error", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try

        sql = "insert into cria (id_cria, id_toro, id_vaca) Values (" & idcria & "," & cboToro.Text & ",'" & cboVaca.Text & "')"
        Try
            cn.Execute(sql)
            MsgBox("Cria registrada correctamente.", MsgBoxStyle.Information, "Atención")
            limpiar()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Public Sub cargar_toro()
        sql = "select * from toro, animal where id_toro=id_animal and x=1"
        Try
            rs.Open(sql, cn)
            cboToro.Items.Clear()
        Catch ex As Exception
            MsgBox("Error al buscar los datos.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        While Not rs.EOF
            cboToro.Items.Add(rs("id_toro").Value)
            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    Public Sub cargar_vaca()
        sql = "select * from vaca, animal where id_vaca=id_animal and x=1"
        Try
            rs.Open(sql, cn)
            cboVaca.Items.Clear()
        Catch ex As Exception
            MsgBox("Ocurrió un error.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        While Not rs.EOF
            cboVaca.Items.Add(rs("id_vaca").Value)
            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    Public Sub cargar_cria()
        sql = "select * from cria"
        Try
            rs.Open(sql, cn)
            cboBuscar.Items.Clear()
        Catch ex As Exception
            MsgBox("Error al buscar los datos.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        While Not rs.EOF
            cboBuscar.Items.Add(rs("id_cria").Value)
            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    Public Sub cargargrilla()
        sql = "select * from animal,cria where id_cria=id_animal and x=1"
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("No se pudo cargar el listado de crías")
            Exit Sub
        End Try
        If Not cargoGrilla(rs, DataGridView1) Then
            MsgBox("No se pudo cargar el listado de crías")
        End If
        rs.Close()
    End Sub

    Public Sub limpiar()
        cboBuscar.Text = ""
        txtNombre.Text = ""
        cboRaza.Text = ""
        dateNacimiento.Text = ""
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ReflectionImage1_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmCria_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        cargar_toro()
        cargar_vaca()
        cargar_cria()
        cargargrilla()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        btnCrear.Enabled = False
        sql = "select * from animal where id_animal=" & Val(cboBuscar.Text)
        Try
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

        sql = "select * from cria where id_cria=" & Val(cboBuscar.Text)
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            Exit Sub
        End Try
        If rs.RecordCount = 1 Then

        Else

        End If
        rs.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        sql = "delete from cria where id_cria=" & Val(cboBuscar.Text)
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
            limpiar()
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            btnCrear.Enabled = True
            Exit Sub
        End Try
        cargargrilla()
        btnCrear.Enabled = True
    End Sub

    Private Sub btnCrear_Click(sender As System.Object, e As System.EventArgs) Handles btnCrear.Click
        Dim idcria As Integer
        If radMacho.Checked Then
            crear_cria_m()
        End If

        If radHembra.Checked Then
            crear_cria_h()
        End If
        cargargrilla()
    End Sub

    Private Sub btnCancelar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
        sql = "update animal set nom_animal='" & txtNombre.Text & "', raza='" & cboRaza.Text & "'  where id_animal=" & cboBuscar.Text & ""
        Try
            cn.Execute(sql)
            MsgBox("Modificación exitosa.", MsgBoxStyle.Information, "Atención")
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            btnCrear.Enabled = True
            Exit Sub
        End Try
        limpiar()
        btnCrear.Enabled = True
        cargargrilla()
    End Sub

    Private Sub btnRecria1_Click(sender As System.Object, e As System.EventArgs) Handles btnRecria1.Click
        frmRecria2.Show()
    End Sub

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        frmRecria.MdiParent = frmMenu
        frmRecria.Show()
    End Sub
End Class