Public Class frmEnfermedad
    Dim a As Integer

    Public Sub cargar_enfermedad()
        sql = "select * from enfermedad"
        Try
            rs.Open(sql, cn)
            cboBuscar.Items.Clear()
        Catch ex As Exception
            MsgBox("Error al buscar.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        While Not rs.EOF
            cboBuscar.Items.Add(rs("nombre").Value)
            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    Public Sub limpiar()
        cboBuscar.Text = ""
        txtNombre.Text = ""
        cboTipo.Text = ""
        txtDescripcion.Text = ""
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub
    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnCrear_Click(sender As System.Object, e As System.EventArgs) Handles btnCrear.Click
        sql = "insert into enfermedad (nombre, tipo, descrip) Values ('" & txtNombre.Text & "','" & cboTipo.Text & "','" & txtDescripcion.Text & "')"
        Try
            cn.Execute(sql)
            MsgBox("Enfermedad registrada correctamente.", MsgBoxStyle.Information, "Atención")
            limpiar()
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try
        cargar_enfermedad()
    End Sub

    Private Sub frmEnfermedad_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        cargar_enfermedad()
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        sql = "delete from enfermedad where nombre='" & (txtNombre.Text) & "'"
        Try
            If MsgBox("¿Está seguro que desea eliminar el registro?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                MsgBox(sql)
                cn.Execute(sql)
                MsgBox("Registro eliminado correctamente.", MsgBoxStyle.Information, "Atención")
                btnModificar.Enabled = False
                btnEliminar.Enabled = False
                limpiar()
            End If
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try
        cargar_enfermedad()
        btnCrear.Enabled = True
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        limpiar()
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
        sql = "update enfermedad set nombre='" & txtNombre.Text & "', tipo='" & cboTipo.Text & "', descrip='" & txtDescripcion.Text & "'  where nombre='" & cboBuscar.Text & "'"
        Try
            cn.Execute(sql)
            MsgBox("Modificación exitosa.", MsgBoxStyle.Information, "Atención")
            limpiar()
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try
        btnCrear.Enabled = True
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        sql = "select * from enfermedad where nombre='" & cboBuscar.Text & "'"
        Try
            rs.Open(sql)
            a = rs("id_enf").Value
        Catch ex As Exception
            MsgBox("err")
        End Try
        If rs.RecordCount = 1 Then
            txtNombre.Text = rs("nombre").Value
            cboTipo.Text = rs("tipo").Value
            txtDescripcion.Text = rs("descrip").Value
            btnCrear.Enabled = False
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        Else
            MsgBox("No se encontro lo solicitado.", MsgBoxStyle.Exclamation, "Atención")
        End If
        rs.Close()
    End Sub

    Private Sub cboBuscar_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboBuscar.SelectedIndexChanged
        
    End Sub
End Class