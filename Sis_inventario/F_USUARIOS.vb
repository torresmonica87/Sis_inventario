Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class F_USUARIOS
    ' Declaración de variables
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

    ' Método para inicializar la conexión
    Sub conexion()
        Try
            conex = New MySqlConnection("server=localhost;user id=root;password=123;database=inventario")
            conex.Open()
        Catch ex As MySqlException
            MsgBox("ERROR AL CONECTAR CON LA BASE DE DATPS: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    ' Evento Load del formulario
    Private Sub F_USUARIOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If conex Is Nothing OrElse conex.State <> ConnectionState.Open Then
                conexion()
            End If
            tipusu = "ADMINISTRADOR"

            ' Desactivar textos al cargar
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is TextBox Then
                    CType(ctrl, TextBox).ReadOnly = True
                End If
            Next
        Catch ex As Exception
            MsgBox("ERROR AL CARGAR FORMULARIO: " & ex.Message, MsgBoxStyle.Critical, "Error")
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

    ' Métodos auxiliares
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
        DGV1.DataSource = ds.Tables("usuarios")
        DGV1.Columns(5).Visible = False 'TIPO
        DGV1.Columns(6).Visible = False 'ESTADO
        DGV1.Columns(0).HeaderText = "ID"
        DGV1.Columns(1).HeaderText = "NOMBRE"
        DGV1.Columns(2).HeaderText = "EMAIL"
        DGV1.Columns(3).HeaderText = "USUARIO"
        DGV1.Columns(4).HeaderText = "CONTRASEÑA"
        DGV1.Columns(1).Width = 200
    End Sub

    Sub pasar_datos()
        If DGV1.Rows.Count > 0 Then
            txtnombre.Text = Trim(DGV1.CurrentRow.Cells(1).Value)
            txtemail.Text = Trim(DGV1.CurrentRow.Cells(2).Value)
            txtuser.Text = Trim(DGV1.CurrentRow.Cells(3).Value)
            txtcontraseña.Text = Trim(DGV1.CurrentRow.Cells(4).Value)
        End If
    End Sub
    ' esto es para cifraR
    Private Function HashSHA256(ByVal texto As String) As String
        Using sha256 As System.Security.Cryptography.SHA256 = System.Security.Cryptography.SHA256.Create()
            Dim bytesTexto As Byte() = System.Text.Encoding.UTF8.GetBytes(texto)
            Dim bytesHash As Byte() = sha256.ComputeHash(bytesTexto)
            Return BitConverter.ToString(bytesHash).Replace("-", "").ToLower()
        End Using
    End Function


    ' Botones
    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        Limpiartextos(Me)
        cambioestadoboton(Me, botonactivo, botoninactivo)

        ' Activar solo los TextBox que deben estar activos
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

        ' Volver a ponerlos como solo lectura
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
            ' Deberías llenar el datagrid aquí
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
                consul1 = "INSERT INTO usuarios (nom_usuario, nick_usuario, clave_usuario, email_usuario, tipo_usuario, estado_usuario) " &
                    "VALUES (@nom, @nick, @clave, @mail, @tipo, @estado)"
                Dim cmd As New MySqlCommand(consul1, conex)
                cmd.Parameters.AddWithValue("@nom", Trim(UCase(txtnombre.Text)))
                cmd.Parameters.AddWithValue("@nick", Trim(txtuser.Text))
                cmd.Parameters.AddWithValue("@clave", HashSHA256(Trim(txtcontraseña.Text)))
                cmd.Parameters.AddWithValue("@mail", Trim(LCase(txtemail.Text)))
                cmd.Parameters.AddWithValue("@tipo", "ADMINISTRADOR") '
                cmd.Parameters.AddWithValue("@estado", "ACTIVO")
                cmd.ExecuteNonQuery()
            ElseIf op = 2 Then
                consul1 = "UPDATE usuarios SET nom_usuario=@nom, email_usuario=@mail, nick_usuario=@nick, clave_usuario=@clave WHERE id_usuario=@id"
                Dim cmd As New MySqlCommand(consul1, conex)
                cmd.Parameters.AddWithValue("@nom", Trim(UCase(txtnombre.Text)))
                cmd.Parameters.AddWithValue("@mail", Trim(LCase(txtemail.Text)))
                cmd.Parameters.AddWithValue("@nick", Trim(txtuser.Text))
                cmd.Parameters.AddWithValue("@clave", HashSHA256(Trim(txtcontraseña.Text)))
                cmd.Parameters.AddWithValue("@id", idusu)
                cmd.ExecuteNonQuery()
            End If

            MsgBox("USUARIO REGISTRADO EXITOSAMENTE!", MsgBoxStyle.Information)
            Limpiartextos(Me)
            DESACTIVAR()
            btnagregar.Focus()

        Catch ex As Exception
            MsgBox("ERROR AL GUARDAR: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    'FALTA EL CODIGO DE DGV1-----------------------------------------------------------------------
End Class
