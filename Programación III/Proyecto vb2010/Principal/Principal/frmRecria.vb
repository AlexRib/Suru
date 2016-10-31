Public Class frmRecria
    Dim camporecria As Integer
    Public Sub cargar_camporecria()
        sql = "select * from campo_recria"
        Try
            rs.Open(sql, cn)
            cboBuscar.Items.Clear()
            cboRecria.Items.Clear()
        Catch ex As Exception
            MsgBox("Error al buscar los datos.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        While Not rs.EOF
            cboBuscar.Items.Add(rs("nombre").Value)
            cboRecria.Items.Add(rs("nombre").Value)
            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    Public Sub cargargrilla()
        sql = "select * from campo_recria"
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("No se pudo cargar el listado.", MsgBoxStyle.Information, "Atención")
            Exit Sub
        End Try
        If Not cargoGrilla(rs, DataGridView1) Then
            MsgBox("No se pudo cargar el listado.", MsgBoxStyle.Information, "Atención")
        End If
        rs.Close()
    End Sub

    Public Sub cargar_crias_en_camporecria()
        sql = "select * from van"
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("No se pudo cargar el listado.", MsgBoxStyle.Information, "Atención")
            Exit Sub
        End Try
        If Not cargoGrilla(rs, DataGridView2) Then
            MsgBox("No se pudo cargar el listado.", MsgBoxStyle.Information, "Atención")
        End If
        rs.Close()
    End Sub

    Public Sub cargar_cria()
        sql = "select * from cria"
        Try
            rs.Open(sql, cn)
            cboCria.Items.Clear()
        Catch ex As Exception
            MsgBox("Error al buscar los datos.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        While Not rs.EOF
            cboCria.Items.Add(rs("id_cria").Value)
            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    Public Sub limpiar()
        txtRecria.Text = ""
        txtUbicacion.Text = ""
    End Sub

    Private Sub frmRecria_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cargar_camporecria()
        cargargrilla()
        cargar_crias_en_camporecria()
        cargar_cria()
    End Sub

    Private Sub btnCrear_Click(sender As System.Object, e As System.EventArgs) Handles btnCrear.Click
        sql = "insert into campo_recria (nombre, ubicacion) Values ('" & txtRecria.Text & "', '" & txtUbicacion.Text & "')"
        Try
            cn.Execute(sql)
            MsgBox("Campo de recría registrada correctamente.", MsgBoxStyle.Information, "Atención")
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try
        limpiar()
        cargar_camporecria()
        cargargrilla()
    End Sub

    Private Sub btnEliminar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        sql = "delete from van where id_camporec=(select * from campo_recria where nombre='" & cboBuscar.Text & "'); delete from campo_recria where nombre='" & (cboBuscar.Text) & "'"
        Try
            MsgBox(sql)
            If MsgBox("¿Está seguro que desea eliminar el registro?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cn.Execute(sql)
                MsgBox("Registro eliminado correctamente.", MsgBoxStyle.Information, "Atención")
            End If
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try
        cboBuscar.Text = ""
        cargar_camporecria()
        cargargrilla()
    End Sub

    Private Sub btnIngresar_Click(sender As System.Object, e As System.EventArgs) Handles btnIngresar.Click
        sql = "insert into van (id_cria, id_camporec, fecha) Values (" & cboCria.Text & ", " & camporecria & ", '" & dateFecha.Value.ToString("dd/MM/yyyy") & "')"
        Try
            cn.Execute(sql)
            MsgBox("Campo de recría registrada correctamente.", MsgBoxStyle.Information, "Atención")
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try
        cboCria.Text = ""
        cboRecria.Text = ""
        dateFecha.Text = ""
        cargar_crias_en_camporecria()
    End Sub

    Private Sub cboRecria_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboRecria.SelectedIndexChanged
        sql = "select * from campo_recria where nombre='" & cboRecria.Text & "'"
        Try
            rs.Open(sql)
            camporecria = rs("id_camporec").Value
        Catch ex As Exception
            MsgBox("Ocurrió un error", MsgBoxStyle.Exclamation, "Atención")
        End Try
        rs.Close()
    End Sub
End Class