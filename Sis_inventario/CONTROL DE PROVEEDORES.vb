Public Class F_PROVEEDORES
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If cierre_ventana() = 6 Then
            Me.Close()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'guardar de control de proveedores
        If txtid.Text = "" Or txtprove.Text = "" Or txtdir.Text = "" Or txtcel.Text = "" Or txtmail.Text = "" Then
            MsgBox("LOS DATOS NO ESTÁN COMPLETOS")
            txtid.Focus()
            Exit Sub
            'aqui falta codigo
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'cancelar de control de proveedores
    End Sub
End Class