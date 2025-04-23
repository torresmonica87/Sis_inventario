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
    ' --------------------rpracticando--------------------------------------------------------

    '--------------------------aun falta codigo---------------------------------
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
            Exit Sub
            'aqui falta codigo
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
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        'modificar de control de proveedores
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        'eliminar de control de proveedores
    End Sub
End Class