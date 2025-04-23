Imports MySql.Data.MySqlClient
Public Class F_PROVEEDORES
    Dim consul1 As String
    Dim op As Integer
    Dim btactivo As New List(Of String) From {"btnguardar", "btncancelar"}
    Dim btinactivo As New List(Of String) From {"btnagregar", "btnmodificar", "btneliminar", "btnsalir"}
    Dim lecturatext As New List(Of String) From {"txtid", "txtprove", "txtdireccion", "txtcelular", "txtmail"}
    Dim editatext As New List(Of String) From {"TXTID"}
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
        If txtid.Text = "" Or txtprove.Text = "" Or txtdireccion.Text = "" Or txtcelular.Text = "" Or txtmail.Text = "" Then
            MsgBox("LOS DATOS NO ESTÁN COMPLETOS")
            txtid.Focus()

        Else
            If op = 1 Then
                consul1 = "insert into proveedores (id_prove,nom_prove,dir_prove,tel_prove,mail_prove,estado_prove,id_usuario)" _
                    & "values('" + Trim(txtid.Text) + "','" + Trim(UCase(txtprove.Text)) + "','" + Trim(UCase(txtdireccion.Text)) + "'" _
                    & ",'" + Trim(txtcelular.Text) + "','" + Trim(LCase(txtmail.Text)) + "','" + "ACTIVO" + "','" + Trim(Str(idusu)) + "')"
            Else
                consul1 = "UPDATE proveedores set nom_prove='" + Trim(UCase(txtprove.Text)) + "',dir_prove='" + Trim(UCase(txtdireccion.Text)) + "'" _
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
        'HACER UN DATAGRIDVIEW
    End Sub
    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        'eliminar de control de proveedores
        ' no se que debo colocar exactamente aqui
    End Sub

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged

    End Sub
End Class