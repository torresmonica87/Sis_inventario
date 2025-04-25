Public Class F_USUARIOS
    Dim op As Integer
    Dim btactivo As New List(Of String) From {"btnguardar", "btncancelar"}
    Dim btinactivo As New List(Of String) From {"btnagregar", "btnmodificar", "btneliminar", "btnsalir"}
    Dim lecturatext As New List(Of String) From {"txtnombre", "txtuser", "txtcontraseña", "txtmail", "cbtipo", "cbestado"}
    Dim editatext As New List(Of String) From {"TXTID"}
    Dim consul1 As String
    'mostrar datos a dgv en f_usuarios 
    Sub mostrar_datos()
        DGV1.DataSource = ds.Tables("usuarios")
        DGV1.Columns(5).Visible = False ' Se establece en False para que la columna no sea visible en el DataGridView
        DGV1.Columns(0).HeaderText = "NOMBRE COMPLETO"
        DGV1.Columns(1).HeaderText = "NICK/USER"
        DGV1.Columns(2).HeaderText = "CONTRASEÑA"
        DGV1.Columns(3).HeaderText = "E_MAIL"
        DGV1.Columns(4).HeaderText = "TIPO USUARIO"
        DGV1.Columns(1).Width = "200"
    End Sub
    Sub pasar_datos()
        If DGV1.Rows.Count > 0 Then
            txtnombre.Text = Trim(DGV1.CurrentRow.Cells(0).Value)
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
                          Trim(txtemail.Text) + "', 'ADMIN', 'ACTIVO')"
            Else
                ' UPDATE corrigiendo las comas
                consul1 = "UPDATE usuarios SET nom_usuario='" + Trim(UCase(txtnombre.Text)) + "', " +
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
            TextBox1.Text = ""
            TextBox1.Focus()
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
            TextBox1.Text = ""
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'este es label de dgv para filtrar
        If RB1.Checked = True Then
            consultas("SELECT * FROM USUARIOS where nom_usuario like'" + Trim(TextBox1.Text) + "%' AND estado_usuario='" + "ACTIVO" + "'", "usuarios")
        Else
            consultas("SELECT * FROM USUARIOS where id_usuario like'" + Trim(TextBox1.Text) + "%' AND estado_usuario='" + "ACTIVO" + "'", "usuarios")
        End If
        mostrar_datos()
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
                jl = MsgBox("SEGURO DE ELIMINAR EL USUARIO?", 4 + 16, "INFOSISTEMAS-JL")
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
        GroupBox1.Visible = False
    End Sub
End Class