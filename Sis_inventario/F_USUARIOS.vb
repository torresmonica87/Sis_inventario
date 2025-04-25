Public Class F_USUARIOS
    Dim op As Integer
    Dim btactivo As New List(Of String) From {"btnguardar", "btncancelar"}
    Dim btinactivo As New List(Of String) From {"btnagregar", "btnmodificar", "btneliminar", "btnsalir"}
    Dim lecturatext As New List(Of String) From {"txtnombre", "txtuser", "txtcontraseña", "txtmail", "cbtipo", "cbestado"}
    Dim editatext As New List(Of String) From {"TXTID"}
    Dim consul1 As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
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
    'de f_usuarios
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

    End Sub
    'de f_usuarios
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Limpiartextos(Me)
        cambioestadoboton(Me, btinactivo, btactivo)
        cambiolectura(Me, lecturatext, editatext)
    End Sub
    'de f_usuarios
    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click

    End Sub
    'de f_usuarios
    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click

    End Sub
End Class