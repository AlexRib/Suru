Public Class frmServicio

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

    Public Sub cargargrilla_servicioactivo()
        sql = "select * from entora where servicio_activo=1"
        Try
            MsgBox(sql)
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("err")
            Exit Sub
        End Try
        If Not cargoGrilla(rs, DataGridView1) Then
            MsgBox("No se pudo cargar grilla")
        End If
        rs.Close()
    End Sub

    Public Sub cargargrilla_servicio()
        sql = "select * from entora"
        Try
            MsgBox(sql)
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("err")
            Exit Sub
        End Try
        If Not cargoGrilla(rs, DataGridView1) Then
            MsgBox("No se pudo cargar grilla")
        End If
        rs.Close()
    End Sub

    Public Sub limpiar()
        cboServicio.Text = ""
        cboVaca.Text = ""
        cboToro.Text = ""
        cboTipo.Text = ""
        cboProceso.Text = ""
        dateEntore.Text = ""
    End Sub

    Private Sub btnCrear_Click(sender As System.Object, e As System.EventArgs) Handles btnCrear.Click
        sql = "insert into entora (id_vaca, id_toro, tipo, proceso, fecha, servicio_activo) Values (" & cboVaca.Text & "," & cboToro.Text & ",'" & cboTipo.Text & "','" & cboProceso.Text & "','" & dateEntore.Value.ToString("dd/MM/yyyy") & "'," & 1 & ")"
        Try
            MsgBox(sql)
            cn.Execute(sql)
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try
    End Sub

    Private Sub frmServicio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
1:      cargar_vaca()
        cargar_toro()
        cargargrilla_servicioactivo()
        cargargrilla_servicio()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub SwitchButton1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles SwitchButton1.ValueChanged
        If SwitchButton1.Value = True Then
            DataGridView1.Visible = True
            DataGridView2.Visible = False
        Else
            DataGridView1.Visible = False
            DataGridView2.Visible = True
        End If
    End Sub
End Class