Public Class frmLogin

    Public Sub conectar()
        Try
            cn.Open("sur1", txtUsuario.Text, txtClave.Text)
            'permisos()
            MsgBox("Bienvenido! " & txtUsuario.Text & "", MsgBoxStyle.Information, "Acceder")
            Me.Close()
            System.Threading.Thread.Sleep(2000)
            frmMenu.Visible = True
        Catch ex As Exception
            MsgBox("Usuario o Contraseña incorrecta.", MsgBoxStyle.Exclamation, "Acceder")
            limpiar()
            Exit Sub
        End Try
        cn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    End Sub

    Public Sub permisos()
        Dim rol As Integer
        If cn.State <> 1 Then
            MsgBox("La conexión a la base de datos está cerrada.")
        Else
            sql = "select id_rol from usu_rol where id_usuario=(select id_usuario from usuario where login='" & txtUsuario.Text & "')"
            Try
                MsgBox(sql)
                rs.Open(sql, cn)
            Catch ex As Exception
                MsgBox("Error al buscar el rol del usuario")
                Exit Sub
            End Try
            If rs.RecordCount = 1 Then
                rol = rs(0).Value
                Select Case rol
                    Case 1
                        
                    Case 2
                        'frmMenu.Visible = True
                        frmMenu.btnTambo.Enabled = True
                        frmUsuario.gpoDatos.Enabled = False
                        frmUsuario.gpoBusqueda.Enabled = False
                        frmToro.gpoDatos.Enabled = False
                        frmToro.gpoBusqueda.Enabled = False
                        frmVaca.gpoDatos.Enabled = False
                        frmVaca.gpoBusqueda.Enabled = False
                        frmCria.gpoDatos.Enabled = False
                        frmCria.gpoBusqueda.Enabled = False
                        frmContrae.gpoEnf.Enabled = False
                        frmContrae.gpoTratamiento.Enabled = False
                        frmContrae.gpoDeclararenf.Enabled = False
                        frmMenu.btnEnf1.Enabled = False
                        frmMenu.btnEnf2.Enabled = False
                        frmEstado.gpoBusqueda.Enabled = False
                        frmEstado.gpoAniadir.Enabled = False
                        frmMenu.btnOrdenie1.Enabled = False
                        frmRecria.gpoRecria.Enabled = False
                        frmRecria.gpoCamporecria.Enabled = False
                        frmCria.btnRecria1.Enabled = False
                        frmServicio.gpoBusqueda.Enabled = False
                        frmServicio.gpoDatos.Enabled = False
                        frmVictima.gpoVictima.Enabled = False
                    Case 3
                        'frmMenu.Visible = True
                        frmTambo.gpoBusqueda.Enabled = False
                        frmTambo.gpoBusqueda.Enabled = False
                    Case(4)
                        'frmMenu.Visible = True
                        frmTambo.gpoBusqueda.Enabled = False
                        frmTambo.gpoBusqueda.Enabled = False
                        frmUsuario.gpoBusqueda.Enabled = False
                        frmUsuario.gpoDatos.Enabled = False
                        frmToro.btnEliminar.Visible = True
                        frmVaca.btnEliminar.Visible = True
                        frmCria.btnEliminar.Visible = True
                End Select
            Else
                MsgBox("No se encontró el rol de usuario")
                cn.Close()
            End If
            rs.Close()
        End If
    End Sub

    Public Sub limpiar()
        txtUsuario.Text = ""
        txtClave.Text = ""
        chkMostrarclave.Checked = False
        txtUsuario.Focus()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUsuario.Focus()
        If txtUsuario.Text = "" Or txtClave.Text = "" Then
            btnCancelar.Enabled = False
            btnAceptar.Enabled = False
        Else
            btnCancelar.Enabled = True
            btnAceptar.Enabled = True

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chkMostrarclave.Checked Then
            txtClave.PasswordChar = ""
        Else
            txtClave.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        conectar()
        'permisos()
    End Sub

    Private Sub chkMostrarclave_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMostrarclave.CheckedChanged
        If chkMostrarclave.Checked = True Then
            txtClave.PasswordChar = ""
        Else
            txtClave.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        If MsgBox("Está seguro que desea salir del programa", MsgBoxStyle.YesNo, "Salir") = MsgBoxResult.Yes Then
            frmMenu.Close()
        Else
            limpiar()
        End If
    End Sub

    Private Sub txtUsuario_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUsuario.TextChanged
        If txtUsuario.Text = "" Then
            btnCancelar.Enabled = False
            btnAceptar.Enabled = False
        Else
            btnCancelar.Enabled = True
            btnAceptar.Enabled = True
        End If
    End Sub

End Class