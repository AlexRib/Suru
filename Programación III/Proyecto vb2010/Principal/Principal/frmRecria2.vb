Public Class frmRecria2
    Dim camporecria As Integer
    Public Sub cargar_camporecria()
        sql = "select * from campo_recria"
        Try
            rs.Open(sql, cn)
            cboRecria.Items.Clear()
        Catch ex As Exception
            MsgBox("Error al buscar los datos.", MsgBoxStyle.Exclamation, "Atención")
            Exit Sub
        End Try
        While Not rs.EOF
            cboRecria.Items.Add(rs("nombre").Value)
            rs.MoveNext()
        End While
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

    Private Sub btnIngresar_Click(sender As System.Object, e As System.EventArgs) Handles btnIngresar.Click

    End Sub

    Private Sub frmRecria2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cargar_camporecria()
        cargar_cria()
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

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class