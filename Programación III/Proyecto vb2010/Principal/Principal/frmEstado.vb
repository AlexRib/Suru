Public Class frmEstado
    Dim a As Integer

    Public Sub crear_estado()
        sql = "insert into tiene (id_vaca, id_estado, fecha_i) Values (" & cboVaca.Text & "," & a & ",'" & dateFechaI.Value.ToString("dd/MM/yyyy") & "')"
        Try
            cn.Execute(sql)
            MsgBox("Registro guardado correctamente.", MsgBoxStyle.Information, "Atención")
            limpiar()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try
        cargargrilla_tiene()
    End Sub

    Public Sub crear_estado_fechafin()
        sql = "insert into tiene (id_vaca, id_estado, fecha_i, fecha_f) Values (" & cboVaca.Text & "," & a & ",'" & dateFechaI.Value.ToString("dd/MM/yyyy") & "', '" & dateFechaF.Value.ToString("dd/MM/yyyy") & "')"
        Try
            cn.Execute(sql)
            MsgBox("Registro guardado correctamente.", MsgBoxStyle.Information, "Atención")
            limpiar()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try
        cargargrilla_tiene()
    End Sub

    Public Sub cargar_estado()
        sql = "select * from estado"
        Try
            rs.Open(sql, cn)
            cboEstado.Items.Clear()
        Catch ex As Exception
            MsgBox("Error al buscar los datos.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        While Not rs.EOF
            cboEstado.Items.Add(rs("nombre").Value)
            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    Public Sub cargar_vaca()
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
    End Sub

    Public Sub cargar_tiene()
        sql = "select * from tiene"
        Try
            rs.Open(sql, cn)
            cboBuscar.Items.Clear()
        Catch ex As Exception
            MsgBox("Error al buscar los datos.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        While Not rs.EOF
            cboBuscar.Items.Add(rs("id_estado").Value)
            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    Public Sub cargargrilla_tiene()
        sql = "select * from tiene"
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("No se pudo cargar el listado debido a que no tiene registros.", MsgBoxStyle.Information, "Atención")
            Exit Sub
        End Try
        If Not cargoGrilla(rs, DataGridView1) Then
            MsgBox("No se pudo cargar el listado debido a que no tiene registros.", MsgBoxStyle.Information, "Atención")
        End If
        rs.Close()
    End Sub

    Public Sub limpiar()
        cboBuscar.Text = ""
        cboVaca.Text = ""
        cboEstado.Text = ""
        dateFechaI.Text = ""
        dateFechaF.Text = ""
    End Sub

    Private Sub frmEstado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cargar_vaca()
        cargar_estado()
        cargar_tiene()
        'cargargrilla_tiene()
    End Sub

    Private Sub btnRegistrar_Click(sender As System.Object, e As System.EventArgs) Handles btnRegistrar.Click
        If chkDeclarar.Checked Then
            crear_estado_fechafin()
        Else
            crear_estado()
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click

    End Sub

    Private Sub cboEstado_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboEstado.SelectedIndexChanged
        sql = "select * from estado where nombre='" & cboEstado.Text & "'"
        Try
            rs.Open(sql)
            a = rs("id_estado").Value
            MsgBox(a)
        Catch ex As Exception
            MsgBox("err")
        End Try
        rs.Close()
    End Sub

    Private Sub cboBuscar_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboBuscar.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkDeclarar.CheckedChanged
        If chkDeclarar.Checked Then
            dateFechaF.Enabled = True
        Else
            dateFechaF.Enabled = False
        End If
    End Sub
End Class