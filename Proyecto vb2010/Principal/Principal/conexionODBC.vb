Module conexionODBC
    Public cn As New ADODB.Connection
    Public rs As New ADODB.RecordSet
    Public sql As String

    Public cmd As OleDb.OleDbCommand
    Public dr As OleDb.OleDbDataReader

    Public Sub cerrar()
        cn.Close()
    End Sub

End Module
