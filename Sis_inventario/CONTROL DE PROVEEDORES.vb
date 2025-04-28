Imports MySql.Data.MySqlClient
Public Class F_PROVEEDORES
    Dim consul1 As String
    Dim op As Integer
    Dim btactivo As New List(Of String) From {"btnguardar", "btncancelar"}
    Dim btinactivo As New List(Of String) From {"btnagregar", "btnmodificar", "btneliminar", "btnsalir"}
    Dim lecturatext As New List(Of String) From {"txtid", "txtprove", "txtdireccion", "txtcelular", "txtmail"}
    Dim editatext As New List(Of String) From {"TXTID"}
    Sub mostrar_datos()
        DGV1.DataSource = ds.Tables("proveedores")
        DGV1.Columns(5).Visible = False
        DGV1.Columns(6).Visible = False
        DGV1.Columns(0).HeaderText = "RUC/CI"
        DGV1.Columns(1).HeaderText = "PROVEEDOR"
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
            txtmail.Text = Trim(DGV1.CurrentRow.Cells(4).Value)
        End If
    End Sub
    Private Sub F_PROVEEDORES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conex.State <> ConnectionState.Open Then
            conexion()
        End If
    End Sub
    ' --------------------rpracticando-------------------------------------------------------
    '--------------------------aun falta codigo---------------------------------
    Private Sub txtid_LostFocus(sender As Object, e As EventArgs) Handles txtid.LostFocus
        If op = 1 And txtid.Text <> "" Then
            consultas("select * from proveedores where id_prove='" + Trim(txtid.Text) + "'", "proveedores")
            If ds.Tables("proveedores").Rows.Count > 0 Then
                MsgBox("EL RUC/CI YA EXISTE, PERTENECE A..:" + ds.Tables("proveedores").Rows(0).Item("nom_prove"))
                txtid.Text = ""
                txtid.Focus()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        'salir de control de proveedores
        If cierre_ventana() = 6 Then
            Me.Close()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        'guardar de control de proveedores
        If txtid.Text = "" Or txtnombre.Text = "" Or txtdireccion.Text = "" Or txtcelular.Text = "" Or txtmail.Text = "" Then
            MsgBox("LOS DATOS NO ESTÁN COMPLETOS")
            txtid.Focus()

        Else
            If op = 1 Then
                consul1 = "insert into proveedores (id_prove,nom_prove,dir_prove,tel_prove,mail_prove,estado_prove,id_usuario)" _
                    & "values('" + Trim(txtid.Text) + "','" + Trim(UCase(txtnombre.Text)) + "','" + Trim(UCase(txtdireccion.Text)) + "'" _
                    & ",'" + Trim(txtcelular.Text) + "','" + Trim(LCase(txtmail.Text)) + "','" + "ACTIVO" + "','" + Trim(Str(idusu)) + "')"
            Else
                consul1 = "UPDATE proveedores set nom_prove='" + Trim(UCase(txtnombre.Text)) + "',dir_prove='" + Trim(UCase(txtdireccion.Text)) + "'" _
                    & ",tel_prove='" + Trim(txtcelular.Text) + "',mail_prove='" + Trim(LCase(txtmail.Text)) + "',id_usuario='" + Trim(Str(idusu)) + "' where id_prove='" + Trim(txtid.Text) + "' "
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
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        'cancelar de control de proveedores
        Limpiartextos(Me)
        cambioestadoboton(Me, btinactivo, btactivo)
        cambiolectura(Me, lecturatext, editatext)
    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        'agregar de control de proveedores
        Limpiartextos(Me)
        cambioestadoboton(Me, btactivo, btinactivo)
        cambiolectura(Me, editatext, lecturatext)
        op = 1
        txtid.Focus()
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        'modificar de control de proveedores
        If Trim(tipusu) <> "ADMINISTRADOR" Then
            MsgBox("no tiene permiso para realizar esta acción!!!!")
        Else
            op = 2
            consultas("select * from proveedores where estado_prove='" + "ACTIVO" + "'", "proveedores")
            mostrar_datos()
            GroupBox1.Visible = True
            TextBox1.Text = ""
            TextBox1.Focus()
        End If
    End Sub
    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        'eliminar de control de proveedores
        If Trim(tipusu) <> "ADMINISTRADOR" Then
            MsgBox("NO TIENE PERMISO PARA REALIZAR ÉSTA ACCIÓN!!!!")
        Else
            op = 3
            consultas("select * from proveedores where estado_prove='" + "ACTIVO" + "'", "proveedores")
            mostrar_datos()
            GroupBox1.Visible = True
            TextBox1.Text = ""
            TextBox1.Focus()
        End If
    End Sub

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'este es label de dgv para filtrar
        'no filtra rbnombre 
        If RB1.Checked = True Then
            consultas("SELECT * FROM PROVEEDORES where nom_prove like'" + Trim(TextBox1.Text) + "%' AND estado_prove='" + "ACTIVO" + "'", "proveedores")
        Else
            consultas("SELECT * FROM PROVEEDORES where id_prove like'" + Trim(TextBox1.Text) + "%' AND estado_prove='" + "ACTIVO" + "'", "proveedores")
        End If
        mostrar_datos()
    End Sub

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        'aceptar de dgv para modificar en proveedores
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
                jl = MsgBox("SEGURO DE ELIMINAR EL PROVEEDOR?", 4 + 16, "PROYECTO")
                If jl = 6 Then
                    consul1 = "update proveedores set estado_prove='" + "INACTIVO" + "' WHERE id_prove='" + Trim(txtid.Text) + "'"
                    If accionesbdd(consul1) Then
                        Limpiartextos(Me)
                        MsgBox("PROVEEDOR ELIMINADO EXITOSAMENTE..!!!")
                        btnagregar.Focus()
                    End If
                End If
            End If
        Else
            MsgBox("NO HA SELECCIONADO EL PROVEEDOR..!!!!!")
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        'este es el cerrar de dgv para proveedores
        GroupBox1.Visible = False
    End Sub
End Class