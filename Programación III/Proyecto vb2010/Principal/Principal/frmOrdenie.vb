Public Class frmOrdenie
    Dim a, b As Integer
    Public Sub cargar_lote()
        sql = "select * from lote"
        Try
            rs.Open(sql, cn)
            cboLote.Items.Clear()
            cboELiminarLote.Items.Clear()
            cboIngresarLote.Items.Clear()
        Catch ex As Exception
            MsgBox("Error al buscar los datos.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        While Not rs.EOF
            cboLote.Items.Add(rs("nombre").Value)
            cboELiminarLote.Items.Add(rs("nombre").Value)
            cboIngresarLote.Items.Add(rs("nombre").Value)
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

    Public Sub cargar_leche()
        sql = "select * from leche"
        Try
            rs.Open(sql, cn)
            cbolIngresarLeche.Items.Clear()
        Catch ex As Exception
            MsgBox("Error al buscar los datos.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        While Not rs.EOF
            cbolIngresarLeche.Items.Add(rs("tipo").Value)
            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs)
        
    End Sub

    Private Sub btnVolver_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ReflectionImage1_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub ButtonX1_Click_1(sender As System.Object, e As System.EventArgs)
        
    End Sub

    Private Sub frmOrdenie_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cargar_vaca()
        cargar_lote()
        cargar_leche()

    End Sub

    Private Sub ButtonX4_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX4.Click
        sql = "insert into producen (id_lote, id_leche, cantidad, calcio, fecha) Values (" & a & ", " & cbolIngresarLeche.Text & ", " & txtCantidad.Text & ", " & txtCalcio.Text & ", '" & dateFecha.Value.ToString("dd/MM/yyyy") & "')"
        Try
            MsgBox(sql)
            cn.Execute(sql)
            MsgBox("Campo de recría registrada correctamente.", MsgBoxStyle.Information, "Atención")
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try
    End Sub

    Private Sub cboIngresarLote_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboIngresarLote.SelectedIndexChanged
        sql = "select * from lote where nombre='" & cboIngresarLote.Text & "'"
        Try
            rs.Open(sql)
            a = rs("id_lote").Value
        Catch ex As Exception
            MsgBox("err")
        End Try
        rs.Close()
    End Sub

    Private Sub cboLote_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboLote.SelectedIndexChanged
        sql = "select * from lote where nombre='" & cboLote.Text & "'"
        Try
            rs.Open(sql)
            b = rs("id_lote").Value
        Catch ex As Exception
            MsgBox("err")
        End Try
        rs.Close()
    End Sub

    Private Sub btnCrear_Click(sender As System.Object, e As System.EventArgs) Handles btnCrear.Click
        sql = "insert into lote (nombre) Values ('" & txtNombreLote.Text & "')"
        Try
            cn.Execute(sql)
            MsgBox("Enfermedad registrada correctamente.", MsgBoxStyle.Information, "Atención")
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try
        cargar_lote()
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        sql = "delete from lote where nombre='" & (cboELiminarLote.Text) & "'"
        Try
            If MsgBox("¿Está seguro que desea eliminar el registro?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                MsgBox(sql)
                cn.Execute(sql)
                MsgBox("Registro eliminado correctamente.", MsgBoxStyle.Information, "Atención")
            End If
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try
        cargar_lote()
    End Sub

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        sql = "insert into asigna (id_vaca, id_lote) Values (" & cboVaca.Text & ", " & b & ")"
        Try
            MsgBox(sql)
            cn.Execute(sql)
            MsgBox("Vaca asignada correctamente.", MsgBoxStyle.Information, "Atención")
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try
    End Sub

End Class