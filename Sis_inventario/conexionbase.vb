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

    Sub consultas(ByVal Sql As String, ByVal Tabla As String)
        Try
            da = New MySqlDataAdapter(Sql, conex)
            da.Fill(ds, Tabla)
        Catch ex As Exception
            MsgBox("ERROR!" + ex.Message)
        End Try

    End Sub

    Function acciontabla(ByVal sql As String)
        Try
            If conex.State <> ConnectionState.Open Then
                conex.Open()
            End If
            comando = New MySqlCommand(sql, conex)
            Dim i1 As Integer = comando.ExecuteNonQuery
            conex.Close()
            If i1 > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception

        End Try
    End Function

End Module
