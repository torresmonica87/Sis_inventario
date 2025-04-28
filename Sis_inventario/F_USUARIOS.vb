Imports MySql.Data.MySqlClient

Public Class F_USUARIOS
    Dim op As Integer
    Dim botonactivo As New List(Of String) From {"btnguardar", "btncancelar"}
    Dim botoninactivo As New List(Of String) From {"btnagregar", "btnmodificar", "btneliminar", "btnsalir"}
    Dim txtlectura As New List(Of String) From {"txtnombre", "txtemail", "txtuser", "txtcontraseña"}
    Dim txteditable As New List(Of String) From {"txtnombre", "txtemail", "txtuser", "txtcontraseña"}
    Dim consul1 As String
    Dim idusu As Integer
    Dim tipusu As String
    Dim conex As MySqlConnection
    Dim ds As New DataSet

    Sub conexion()
        Try
            conex = New MySqlConnection("server=localhost;user id=root;password=123;database=inventario")
            conex.Open()
        Catch ex As MySqlException
            MsgBox("ERROR AL CONECTAR CON LA BASE DE DATOS: " + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub consultas(query As String, tableName As String)
        Try
            Dim da As New MySqlDataAdapter(query, conex)
            ds.Clear()
            da.Fill(ds, tableName)

            If ds.Tables(tableName).Rows.Count > 0 Then
                DGV1.DataSource = ds.Tables(tableName)
                DGV1.Columns(5).Visible = False
                DGV1.Columns(6).Visible = False
                DGV1.Columns(0).HeaderText = "ID"
                DGV1.Columns(1).HeaderText = "NOMBRE"
                DGV1.Columns(2).HeaderText = "USUARIO"
                DGV1.Columns(3).HeaderText = "CONTRASEÑA"
                DGV1.Columns(4).HeaderText = "EMAIL"
                DGV1.Columns(1).Width = 200
            Else
                MsgBox("No se encontraron datos en la base de datos.", MsgBoxStyle.Information, "Sin resultados")
            End If
        Catch ex As Exception
            MsgBox("ERROR AL CONSULTAR LOS DATOS: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub F_USUARIOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If conex Is Nothing OrElse conex.State <> ConnectionState.Open Then
                conexion()
            End If
            tipusu = "ADMINISTRADOR"
            consultas("SELECT * FROM usuarios WHERE 1", "usuarios")
            mostrar_datos()
        Catch ex As Exception
            MsgBox("ERROR AL CARGAR FORMULARIO: " + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Sub ACTIVAR()
        cambioestadoboton(Me, botonactivo, botoninactivo)
        cambiolectura(Me, txteditable, txtlectura)
    End Sub

    Sub DESACTIVAR()
        cambioestadoboton(Me, botoninactivo, botonactivo)
        cambiolectura(Me, txtlectura, txteditable)
    End Sub

    Sub cambiolectura(frm As Form, camposactivar As List(Of String), camposdesactivar As List(Of String))
        For Each ctrl As Control In frm.Controls
            If TypeOf ctrl Is TextBox Then
                If camposactivar.Contains(ctrl.Name) Then
                    CType(ctrl, TextBox).ReadOnly = False
                ElseIf camposdesactivar.Contains(ctrl.Name) Then
                    CType(ctrl, TextBox).ReadOnly = True
                End If
            End If
        Next
    End Sub

    Sub cambioestadoboton(frm As Form, botonesactivar As List(Of String), botonesdesactivar As List(Of String))
        For Each ctrl As Control In frm.Controls
            If TypeOf ctrl Is Button Then
                If botonesactivar.Contains(ctrl.Name) Then
                    ctrl.Enabled = True
                ElseIf botonesdesactivar.Contains(ctrl.Name) Then
                    ctrl.Enabled = False
                End If
            End If
        Next
    End Sub

    Sub Limpiartextos(frm As Form)
        For Each ctrl As Control In frm.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()
            End If
        Next
    End Sub

    Sub mostrar_datos()
        If ds.Tables("usuarios") IsNot Nothing Then
            DGV1.DataSource = ds.Tables("usuarios")
            DGV1.Columns(5).Visible = False
            DGV1.Columns(6).Visible = False
            DGV1.Columns(0).HeaderText = "ID"
            DGV1.Columns(1).HeaderText = "NOMBRE"
            DGV1.Columns(2).HeaderText = "USUARIO"
            DGV1.Columns(3).HeaderText = "CONTRASEÑA"
            DGV1.Columns(4).HeaderText = "EMAIL"
            DGV1.Columns(1).Width = 200
        End If
    End Sub

    Sub pasar_datos()
        If DGV1.Rows.Count > 0 Then
            txtnombre.Text = Trim(DGV1.CurrentRow.Cells(1).Value)
            txtemail.Text = Trim(DGV1.CurrentRow.Cells(2).Value)
            txtuser.Text = Trim(DGV1.CurrentRow.Cells(3).Value)
            txtcontraseña.Text = Trim(DGV1.CurrentRow.Cells(4).Value)
        End If
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Limpiartextos(Me)
        cambioestadoboton(Me, botonactivo, botoninactivo)
        txtnombre.ReadOnly = False
        txtemail.ReadOnly = False
        txtuser.ReadOnly = False
        txtcontraseña.ReadOnly = False

        op = 1
        txtnombre.Focus()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Limpiartextos(Me)
        cambioestadoboton(Me, botoninactivo, botonactivo)
        txtnombre.ReadOnly = True
        txtemail.ReadOnly = True
        txtuser.ReadOnly = True
        txtcontraseña.ReadOnly = True
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        If Trim(tipusu) <> "ADMINISTRADOR" Then
            MsgBox("NO TIENE PERMISO PARA REALIZAR ÉSTA ACCIÓN!", MsgBoxStyle.Exclamation)
        Else
            op = 2
            GroupBox1.Visible = True
            txtnombre.Clear()
            txtnombre.Focus()
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If Trim(tipusu) <> "ADMINISTRADOR" Then
            MsgBox("NO TIENE PERMISO PARA REALIZAR ÉSTA ACCIÓN!", MsgBoxStyle.Exclamation)
        Else
            op = 3
            GroupBox1.Visible = True
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If MessageBox.Show("ESTÁ SEGURO DE SALIR?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        txtnombre.ReadOnly = True
        txtemail.ReadOnly = True
        txtuser.ReadOnly = True
        txtcontraseña.ReadOnly = True

        If txtnombre.Text = "" Or txtemail.Text = "" Or txtuser.Text = "" Or txtcontraseña.Text = "" Then
            MsgBox("DEBE LLENAR TODOS LOS CAMPOS.", MsgBoxStyle.Exclamation)
            txtnombre.Focus()
            Exit Sub
        End If

        Try
            If op = 1 Then
                consul1 = "INSERT INTO usuarios (nom_usuario, nick_usuario, clave_usuario, email_usuario, tipo_usuario, estado_usuario) " +
                "VALUES (@nom, @nick, @clave, @mail, @tipo, @estado)"
                Dim cmd As New MySqlCommand(consul1, conex)
                cmd.Parameters.AddWithValue("@nom", Trim(UCase(txtnombre.Text)))
                cmd.Parameters.AddWithValue("@nick", Trim(txtuser.Text))
                cmd.Parameters.AddWithValue("@clave", Trim(txtcontraseña.Text))
                cmd.Parameters.AddWithValue("@mail", Trim(LCase(txtemail.Text)))
                cmd.Parameters.AddWithValue("@tipo", "ADMINISTRADOR")
                cmd.Parameters.AddWithValue("@estado", "ACTIVO")
                cmd.ExecuteNonQuery()
            ElseIf op = 2 Then
                consul1 = "UPDATE usuarios SET nom_usuario=@nom, email_usuario=@mail, nick_usuario=@nick, clave_usuario=@clave WHERE id_usuario=@id"
                Dim cmd As New MySqlCommand(consul1, conex)
                cmd.Parameters.AddWithValue("@nom", Trim(UCase(txtnombre.Text)))
                cmd.Parameters.AddWithValue("@mail", Trim(LCase(txtemail.Text)))
                cmd.Parameters.AddWithValue("@nick", Trim(txtuser.Text))
                cmd.Parameters.AddWithValue("@clave", Trim(txtcontraseña.Text))
                cmd.Parameters.AddWithValue("@id", idusu)
                cmd.ExecuteNonQuery()
                'USAR + hace que se concatene directamente dentro de la consulta SQL 
                'USAR @ Los valores se pasan a la consulta utilizando el método AddWithValue de MySqlCommand, lo que es más seguro previene ataque SQL Injection INVESTIGAR MAS
            End If

            MsgBox("USUARIO REGISTRADO EXITOSAMENTE!", MsgBoxStyle.Information)
            Limpiartextos(Me)
            DESACTIVAR()
            btnagregar.Focus()
        Catch ex As Exception
            MsgBox("ERROR AL GUARDAR: " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        GroupBox1.Visible = False
    End Sub

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        If DGV1.Rows.Count > 0 Then
            If op = 2 Then
                GroupBox1.Visible = False
                cambioestadoboton(Me, botonactivo, botoninactivo)
                cambiolectura(Me, txteditable, txtlectura)
                idusu = DGV1.CurrentRow.Cells(0).Value
                pasar_datos()
                txtnombre.Focus()
            End If
            If op = 3 Then
                GroupBox1.Visible = False
                pasar_datos()
                Dim jl As Integer
                jl = MsgBox("SEGURO DE ELIMINAR EL USUARIO?", 4 + 16, "CONFIRMACIÓN")
                If jl = 6 Then
                    consul1 = "UPDATE usuarios SET estado_usuario='" + "INACTIVO" + "' WHERE id_usuario=" + idusu.ToString()
                    If accionesbdd(consul1) Then
                        Limpiartextos(Me)
                        MsgBox("USUARIO ELIMINADO CON ÉXITO!", MsgBoxStyle.Information)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtbuscar_KeyUp(sender As Object, e As KeyEventArgs) Handles txtbuscar.KeyUp
        Try ' MEJOR MANEJO DE ERRORES , RECOMENDADO BUENA PRACTICA
            If txtbuscar.Text <> "" Then
                Dim query As String = "SELECT * FROM usuarios WHERE nom_usuario LIKE '%" & txtbuscar.Text & "%'"
                consultas(query, "usuarios")
                mostrar_datos()
            Else
                mostrar_datos()
            End If
        Catch ex As Exception
            MsgBox("ERROR AL REALIZAR LA BÚSQUEDA: " + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    'es más seguro y adecuado para manejar datos de usuario debido al uso de parámetros SQL, manejo de errores y la posibilidad de hacer tanto inserciones como actualizaciones de manera flexible.
    'en donde no uso @ try catch tiene el inconveniente de usar concatenación directa en las consultas SQL, lo cual no es recomendable por razones de seguridad.
    'más susceptible a problemas de seguridad y errores no controlados. el usar + y controlar bien las excepciones 
End Class
