Public Class frmContrae
    Dim a As Integer
    Dim b As Integer
    Dim c As Integer
    Public Sub cargar_animal()
        sql = "select * from animal"
        Try
            rs.Open(sql, cn)
            cboAnimal.Items.Clear()
            cboAnimal2.Items.Clear()
        Catch ex As Exception
            MsgBox("Error al buscar los datos.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        While Not rs.EOF
            cboAnimal.Items.Add(rs("id_animal").Value)
            cboAnimal2.Items.Add(rs("id_animal").Value)
            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    Public Sub cargar_enfermedad()
        sql = "select * from enfermedad"
        Try
            rs.Open(sql, cn)
            cboEnf.Items.Clear()
        Catch ex As Exception
            MsgBox("Error al buscar.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        While Not rs.EOF
            cboEnf.Items.Add(rs("nombre").Value)
            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    Public Sub cargar_tratamiento()
        sql = "select * from tratamiento"
        Try
            rs.Open(sql, cn)
            cboTratamiento.Items.Clear()
        Catch ex As Exception
            MsgBox("Error al buscar.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        While Not rs.EOF
            cboTratamiento.Items.Add(rs("nombre").Value)
            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    Public Sub cargar_animal_enfermo()
        sql = "select * from contrae where cont=1"
        Try
            rs.Open(sql, cn)
            cboAnimal3.Items.Clear()
        Catch ex As Exception
            MsgBox("Error al buscar los datos.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        While Not rs.EOF
            cboAnimal3.Items.Add(rs("id_animal").Value)
            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    Public Sub cargargrilla()
        sql = "select * from contrae where cont=1"
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Ocurrió un error al cargar los listados.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        If Not cargoGrilla(rs, DataGridView1) Then
            MsgBox("No tiene ningún registro de animales enfermos", MsgBoxStyle.Information, "Atención")
        End If
        rs.Close()
    End Sub

    Public Sub cargargrilla2()
        sql = "select * from contrae"
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Ocurrió un error al cargar los listados.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        If Not cargoGrilla(rs, DataGridView3) Then
            MsgBox("No tiene ningún registro guardado de animales que padecieron una enfermedad.", MsgBoxStyle.Information, "Atención")
        End If
        rs.Close()
    End Sub

    Public Sub cargargrilla_tratamiento()
        sql = "select * from requiere"
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Ocurrió un error al cargar los listados.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        If Not cargoGrilla(rs, DataGridView2) Then
            MsgBox("No tiene ningún registro de animales que requieran tratamiento.", MsgBoxStyle.Information, "Atención")
        End If
        rs.Close()
    End Sub

    Public Sub limpiar()
        cboAnimal.Text = ""
        cboEnf.Text = ""
        dateFecha.Text = ""
    End Sub

    Public Sub limpiar2()
        cboAnimal2.Text = ""
        cboTratamiento.Text = ""
        cboMedicacion.Text = ""
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        sql = "insert into contrae (id_animal, id_enf, fecha_i, cont) Values (" & cboAnimal.Text & "," & a & ",'" & dateFecha.Value.ToString("dd/MM/yyyy") & "'," & 1 & ")"
        Try
            cn.Execute(sql)
            MsgBox("Registro guardado correctamente.", MsgBoxStyle.Information, "Atención")
            limpiar()
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try
        cargargrilla()
    End Sub

    Private Sub frmEnf_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cargar_animal()
        cargar_enfermedad()
        cargargrilla()
        cargargrilla2()
        cargar_tratamiento()
        cargargrilla_tratamiento()
        cargar_animal_enfermo()
    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

    Private Sub cboEnf_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboEnf.SelectedIndexChanged
        sql = "select * from enfermedad where nombre='" & cboEnf.Text & "'"
        Try
            rs.Open(sql)
            a = rs("id_enf").Value
        Catch ex As Exception
            MsgBox("Ocurrió un error", MsgBoxStyle.Exclamation, "Atención")
        End Try
        rs.Close()
    End Sub

    Private Sub cboTratamiento_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboTratamiento.SelectedIndexChanged
        sql = "select * from tratamiento where nombre='" & cboTratamiento.Text & "'"
        Try
            rs.Open(sql)
            b = rs("id_tratam").Value
        Catch ex As Exception
            MsgBox("Ocurrió un error", MsgBoxStyle.Exclamation, "Atención")
        End Try
        rs.Close()
    End Sub

    Private Sub ButtonX1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX1.Click
        sql = "insert into requiere (id_animal, id_tratam, medicacion) Values (" & cboAnimal2.Text & "," & b & ",'" & cboMedicacion.Text & "')"
        Try
            cn.Execute(sql)
            MsgBox("Registro guardado correctamente.", MsgBoxStyle.Information, "Atención")
            limpiar()
        Catch ex As Exception
            MsgBox("Ocurrió un error.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        cargargrilla()
        cargargrilla2()
        cargargrilla_tratamiento()
    End Sub

    Private Sub SwitchButton1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles SwitchButton1.ValueChanged
        If SwitchButton1.Value = True Then
            DataGridView1.Visible = True
            DataGridView3.Visible = False
        Else
            DataGridView1.Visible = False
            DataGridView3.Visible = True
        End If
    End Sub

    Private Sub ButtonX2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX2.Click
        limpiar2()
    End Sub

    Private Sub ButtonX3_Click(sender As System.Object, e As System.EventArgs) Handles ButtonX3.Click
        sql = "update contrae set fecha_f='" & dateFechaF.Value.ToString("dd/MM/yyyy") & "', cont='" & 0 & "' where id_animal=" & cboAnimal3.Text & ""
        Try
            MsgBox(sql)
            cn.Execute(sql)
            MsgBox("Modificación exitosa.", MsgBoxStyle.Information, "Atención")
            limpiar()
        Catch ex As Exception
            MsgBox("No se pudo conectar con la Base de Datos.", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End Try
        cargargrilla()
        cboAnimal3.Text = ""
        dateFechaF.Text = ""
    End Sub

    Private Sub cboAnimal2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboAnimal2.SelectedIndexChanged

    End Sub

    Private Sub cboAnimal3_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboAnimal3.SelectedIndexChanged
        
    End Sub
End Class