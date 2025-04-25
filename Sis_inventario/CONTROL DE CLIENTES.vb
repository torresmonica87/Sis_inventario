Imports MySql.Data.MySqlClient
Public Class F_CLIENTES
    Dim op As Integer
    Dim btactivo As New List(Of String) From {"btnguardar", "btncancelar"}
    Dim btinactivo As New List(Of String) From {"btnagregar", "btnmodificar", "btneliminar", "btnsalir"}
    Dim lecturatext As New List(Of String) From {"txtid", "txtnombre", "txtdireccion", "txtcelular", "txtmail"}
    Dim editatext As New List(Of String) From {"TXTID"}
    Dim consul1 As String
    Sub mostrar_datos()
        DGV1.DataSource = ds.Tables("cliente")
        DGV1.Columns(5).Visible = False
        DGV1.Columns(6).Visible = False
        DGV1.Columns(0).HeaderText = "RUC/CI"
        DGV1.Columns(1).HeaderText = "CLIENTES"
        DGV1.Columns(2).HeaderText = "DIRECCIÓN"
        DGV1.Columns(3).HeaderText = "CELULAR"
        DGV1.Columns(4).HeaderText = "E-MAIL"
        DGV1.Columns(1).Width = "200"
    End Sub
    Sub pasar_datos()
        If DGV1.Rows.Count > 0 Then
            txtid.Text = Trim(DGV1.CurrentRow.Cells(0).Value)
            txtnombre.Text = Trim(DGV1.CurrentRow.Cells(1).Value)
            txtdireccion.Text = Trim(DGV1.CurrentRow.Cells(2).Value)
            txtcelular.Text = Trim(DGV1.CurrentRow.Cells(3).Value)
            txtemail.Text = Trim(DGV1.CurrentRow.Cells(4).Value)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If cierre_ventana() = 6 Then
            Me.Close()
        End If
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        'agregar de control de clientes
        Limpiartextos(Me)
        cambioestadoboton(Me, btactivo, btinactivo)
        cambiolectura(Me, editatext, lecturatext)
        op = 1
        txtid.Focus()
    End Sub
    ' modificar de formulario de control de clientes
    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        If Trim(tipusu) <> "ADMINISTRADOR" Then
            MsgBox("no tiene permiso para realizar esta acción!!!!")
        Else
            op = 2
            consultas("select * from cliente where estado_cliente='" + "ACTIVO" + "'", "cliente")
            mostrar_datos()
            GroupBox1.Visible = True
            TextBox1.Text = ""
            TextBox1.Focus()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If RB1.Checked = True Then
            consultas("SELECT * FROM CLIENTE where nom_cliente like'" + Trim(TextBox1.Text) + "%' AND estado_cliente='" + "ACTIVO" + "'", "cliente")
        Else
            consultas("SELECT * FROM CLIENTE where id_cliente like'" + Trim(TextBox1.Text) + "%' AND estado_cliente='" + "ACTIVO" + "'", "cliente")
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
                txtid.ReadOnly = True
                pasar_datos()
                txtnombre.Focus()
            End If
            If op = 3 Then
                'inactivar cliente
                GroupBox1.Visible = False
                pasar_datos()
                Dim jl As Integer
                jl = MsgBox("SEGURO DE ELIMINAR EL CLIENTE?", 4 + 16, "INFOSISTEMAS-JL")
                If jl = 6 Then
                    consul1 = "update cliente set estado_cliente='" + "INACTIVO" + "' WHERE id_cliente='" + Trim(txtid.Text) + "'"
                    If accionesbdd(consul1) Then
                        Limpiartextos(Me)
                        MsgBox("cliente eliminado con éxito..!!!")
                        btnagregar.Focus()
                    End If
                End If
            End If
        Else
            MsgBox("NO HA SELECCIONADO EL CLIENTE..!!!!!")
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        GroupBox1.Visible = False
    End Sub
    'boton de guardar de formulario clientes
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If txtid.Text = "" Or txtnombre.Text = "" Or txtdireccion.Text = "" Or txtcelular.Text = "" Or txtemail.Text = "" Then
            MsgBox("LOS DATOS NO ESTÁN COMPLETOS..!!!!")
            txtid.Focus()
        Else
            If op = 1 Then
                consul1 = "insert into cliente (id_cliente,nom_cliente,dir_cliente,tel_cliente,mail_cliente,estado_cliente,id_usuario)" _
                    & "values('" + Trim(txtid.Text) + "','" + Trim(UCase(txtnombre.Text)) + "','" + Trim(UCase(txtdireccion.Text)) + "'" _
                    & ",'" + Trim(txtcelular.Text) + "','" + Trim(LCase(txtemail.Text)) + "','" + "ACTIVO" + "','" + Trim(Str(idusu)) + "')"
            Else
                consul1 = "UPDATE cliente set nom_cliente='" + Trim(UCase(txtnombre.Text)) + "',dir_cliente='" + Trim(UCase(txtdireccion.Text)) + "'" _
                    & ",tel_cliente='" + Trim(txtcelular.Text) + "',mail_cliente='" + Trim(LCase(txtemail.Text)) + "',id_usuario='" + Trim(Str(idusu)) + "' where id_cliente='" + Trim(txtid.Text) + "' "
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

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Limpiartextos(Me)
        cambioestadoboton(Me, btinactivo, btactivo)
        cambiolectura(Me, lecturatext, editatext)
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If Trim(tipusu) <> "ADMINISTRADOR" Then
            MsgBox("no tiene permiso para realizar esta acción!!!!")
        Else
            op = 3
            consultas("select * from cliente where estado_cliente='" + "ACTIVO" + "'", "cliente")
            mostrar_datos()
            GroupBox1.Visible = True
            TextBox1.Text = ""
            TextBox1.Focus()
        End If
    End Sub
End Class