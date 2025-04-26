Imports MySql.Data.MySqlClient
Public Class F_USUARIOS
    Dim op As Integer
    Dim btactivo As New List(Of String) From {"btnguardar", "btncancelar"}
    Dim btinactivo As New List(Of String) From {"btnagregar", "btnmodificar", "btneliminar", "btnsalir"}
    Dim lecturatext As New List(Of String) From {"txtnombre", "txtuser", "txtcontraseña", "txtemail", "cbtipo", "cbestado"}
    Dim editatext As New List(Of String) From {"TXTID"}
    Dim consul1 As String
    'mostrar datos a dgv en f_usuarios muestra en relacion a la bd y "NOMBRE COMPLETO" es lo que quiero que muestre al filtrar
    Sub mostrar_datos()
        DGV1.DataSource = ds.Tables("usuarios")

        DGV1.Columns(0).Visible = False ' id_usuario
        DGV1.Columns(5).Visible = False ' tipo_usuario
        DGV1.Columns(6).Visible = False ' estado_usuario
        DGV1.Columns(1).HeaderText = "NOMBRE COMPLETO"
        DGV1.Columns(2).HeaderText = "NICK/USER"
        DGV1.Columns(3).HeaderText = "CONTRASEÑA"
        DGV1.Columns(4).HeaderText = "E_MAIL"
        DGV1.Columns(2).Width = 200

    End Sub
    Sub pasar_datos()
        If DGV1.Rows.Count > 0 Then
            txtnombre.Text = Trim(DGV1.CurrentRow.Cells(0).Value) 'readOnly true hace los label inactivo hasta que se ejecuta una accion ej. pulsa boton agregar
            txtuser.Text = Trim(DGV1.CurrentRow.Cells(1).Value)
            txtcontraseña.Text = Trim(DGV1.CurrentRow.Cells(2).Value)
            txtemail.Text = Trim(DGV1.CurrentRow.Cells(3).Value)
            cbtipo.SelectedValue = Trim(DGV1.CurrentRow.Cells(4).Value)
            cbestado.SelectedValue = Trim(DGV1.CurrentRow.Cells(5).Value)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        'salir de_f usuarios
        If cierre_ventana() = 6 Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        'agregar de control de usuarios
        Limpiartextos(Me)
        cambioestadoboton(Me, btactivo, btinactivo)
        cambiolectura(Me, editatext, lecturatext)
        op = 1
        txtnombre.Focus()
    End Sub
    'boton guardar de f_usuarios
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If txtnombre.Text = "" Or txtuser.Text = "" Or txtcontraseña.Text = "" Or txtemail.Text = "" Then
            MsgBox("LOS DATOS NO ESTÁN COMPLETOS..!!!!")
            txtnombre.Focus()
        Else
            If op = 1 Then
                ' INSERT sin id_usuario porque es AUTO_INCREMENT
                consul1 = "INSERT INTO usuarios (nom_usuario, nick_usuario, clave_usuario, email_usuario, tipo_usuario, estado_usuario) " +
                          "VALUES ('" + Trim(txtnombre.Text) + "', '" + Trim(UCase(txtuser.Text)) + "', '" + Trim(UCase(txtcontraseña.Text)) + "', '" +
                          Trim(txtemail.Text) + "', 'ADMINISTRADOR', 'ACTIVO')"
            Else
                ' UPDATE corrigiendo las comas
                consul1 = "UPDATE usuarios SET id_usuario='" + Trim(UCase(txtnombre.Text)) +
                          "nom_usuario='" + Trim(UCase(txtnombre.Text)) + "', " +
                          "nick_usuario='" + Trim(UCase(txtuser.Text)) + "', " +
                          "clave_usuario='" + Trim(txtcontraseña.Text) + "', " +
                          "email_usuario='" + Trim(LCase(txtemail.Text)) + "' " +
                          "WHERE id_usuario='" + Trim(Str(idusu)) + "'"
            End If

            If accionesbdd(consul1) Then
                MsgBox("REGISTRO ACTUALIZADO..!!!!")
                Limpiartextos(Me)
                cambioestadoboton(Me, btinactivo, btactivo)
                cambiolectura(Me, lecturatext, editatext)
                btnagregar.Focus()
            End If
        End If

    End Sub
    ' cancelar de f_usuarios
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Limpiartextos(Me)
        cambioestadoboton(Me, btinactivo, btactivo)
        cambiolectura(Me, lecturatext, editatext)
    End Sub
    'modificar de f_usuarios
    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        If Trim(tipusu) <> "ADMINISTRADOR" Then
            MsgBox("AVISO!. NO TIENE PERMISO PARA REALIZAR ÉSTA ACCIÓN!!!!")
        Else
            op = 2
            consultas("select * from usuarios where estado_usuario='" + "ACTIVO" + "'", "usuarios")
            mostrar_datos()
            GroupBox1.Visible = True
            txtbuscar.Text = ""
            txtbuscar.Focus()
        End If
    End Sub
    'eliminar de f_usuarios
    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If Trim(tipusu) <> "ADMINISTRADOR" Then
            MsgBox("AVISO!. NO TIENE PERMISO PARA REALIZAR ÉSTA ACCIÓN!!!!")
        Else
            op = 3
            consultas("select * from usuarios where estado_usuario='" + "ACTIVO" + "'", "usuarios")
            mostrar_datos()
            GroupBox1.Visible = True
            txtbuscar.Text = ""
            txtbuscar.Focus()
        End If
    End Sub

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        If DGV1.Rows.Count > 0 Then
            'modificar
            If op = 2 Then
                GroupBox1.Visible = False
                cambioestadoboton(Me, btactivo, btinactivo)
                cambiolectura(Me, editatext, lecturatext)
                txtnombre.ReadOnly = True
                pasar_datos()
                txtnombre.Focus()
            End If
            If op = 3 Then
                'inactivar cliente
                GroupBox1.Visible = False
                pasar_datos()
                Dim jl As Integer
                jl = MsgBox("SEGURO DE ELIMINAR EL USUARIO?", 4 + 16, "PROYECTO")
                If jl = 6 Then
                    consul1 = "update usuarios set estado_usuario='" + "INACTIVO" + "' WHERE id_usuario='" + Trim(txtnombre.Text) + "'"
                    If accionesbdd(consul1) Then
                        Limpiartextos(Me)
                        MsgBox("USUARIO ELIMINADO EXITOSAMENTE..!!!")
                        btnagregar.Focus()
                    End If
                End If
            End If
        Else
            MsgBox("NO HA SELECCIONADO EL USUARIO..!!!!!")
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        'cerrar de dgv de usuarios
        If Trim(tipusu) <> "ADMINISTRADOR" Then
            MsgBox("AVISO! NO TIENE PERMISO PARA REALIZAR ESTA ACCION!!!!")
        Else
            op = 3
            consultas("select * from usuarios where estado_usuario='" + "ACTIVO" + "'", "usuarios")
            mostrar_datos()
            GroupBox1.Visible = True
            txtbuscar.Text = ""
            txtbuscar.Focus()
        End If
        GroupBox1.Visible = False
    End Sub
    Private Sub F_USUARIOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conex.State <> ConnectionState.Open Then
            conexion()
        End If
    End Sub
End Class
