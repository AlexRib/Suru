Imports System.Xml
Public Class frmUsuario

    Public Sub Limpiar()
        cboBuscar.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtCedula.Text = ""
        txtLogin.Text = ""
        cboRol.Text = ""
        optBloquear.Checked = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gpoDatos.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        sql = "select * from usuario"
        Try
            rs.Open(sql, cn)
            cboBuscar.Items.Clear()
        Catch ex As Exception
            MsgBox("Error al buscar el Usuario.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        While Not rs.EOF
            cboBuscar.Items.Add(rs("id_usuario").Value)
            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    Private Sub ReflectionImage1_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click_2(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        sql = "select * from usuario where id_usuario=" & Val(cboBuscar.Text)
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al buscar el Usuario.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        If rs.RecordCount = 1 Then
            txtCedula.Text = rs("cedula").Value
            txtLogin.Text = rs("login").Value
            txtNombre.Text = rs("nombre").Value
            txtApellido.Text = rs("apellido").Value
            cboRol.Text = rs("rol").Value
            btnCrear.Enabled = False
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        Else
            MsgBox("No se encontro el usuario.", MsgBoxStyle.Exclamation, "Atención")
        End If
        rs.Close()
    End Sub

    Private Sub btnUsuarios_Click(sender As System.Object, e As System.EventArgs)
        If txtNombre.Text = "" Then
            txtNombre.Focus()
        End If
        If cboRol.Text = "Ingrese..." Then
            cboRol.Focus()
        End If
    End Sub


    Private Sub btnCancelar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Limpiar()
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Private Sub btnAceptar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnCrear.Click
        sql = "insert into usuario (cedula, login, nombre, apellido, rol) Values (" & txtCedula.Text & ",'" & txtLogin.Text & "','" & txtNombre.Text & "','" & txtApellido.Text & "','" & cboRol.Text & "')"
        Try
            cn.Execute(sql)
            MsgBox("Usuario guardado correctamente.", MsgBoxStyle.Information, "Atención")
            Limpiar()
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try
    End Sub

    Private Sub txtCedula_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedula.KeyPress
        'TextBox solo numeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCedula_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCedula.TextChanged

    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        sql = "delete from usuario where id_usuario=" & Val(cboBuscar.Text)
        Try
            If MsgBox("¿Está seguro que desea eliminar el usuario?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cn.Execute(sql)
                MsgBox("Usuario eliminado correctamente.", MsgBoxStyle.Information, "Atención")
                btnModificar.Enabled = False
                btnEliminar.Enabled = False
                Limpiar()
            End If
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try
        btnCrear.Enabled = True
    End Sub

    Private Sub btnModificar_Click(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
        sql = "update usuario set cedula=" & txtCedula.Text & ", login='" & txtLogin.Text & "', nombre='" & txtNombre.Text & "', apellido='" & txtApellido.Text & "', rol='" & cboRol.Text & "'  where id_usuario=" & cboBuscar.Text & ""
        Try
            cn.Execute(sql)
            MsgBox("Modificación exitosa.", MsgBoxStyle.Information, "Atención")
            Limpiar()
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try
        btnCrear.Enabled = True
    End Sub

End Class