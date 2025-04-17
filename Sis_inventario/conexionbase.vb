Imports MySql.Data.MySqlClient

Module conexionbase
    Public conex As New MySqlConnection
    Public ds As DataSet = New DataSet
    Public da As MySqlDataAdapter
    Public comando As MySqlCommand
    Dim conectar As String

    Sub conexion()
        conectar = "server=localhost;user=root;password='123';database=inventario"
        Try
            conex.ConnectionString = conectar
            conex.Open()
            'MsgBox("Conexión satisfactoria")

        Catch ex As Exception
            MsgBox("Error en la conexión!" + ex.Message
                   )

        End Try
    End Sub
End Module
