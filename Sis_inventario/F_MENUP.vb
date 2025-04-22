Public Class F_MENUP
    Private Sub USUARIOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USUARIOSToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub F_MENUP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBNICK.Text = nickusu
        LBDETALLE.Text = nomusu
        LBTIPO.Text = tipusu
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If cierre_ventana() = 6 Then
            End
        End If
    End Sub

    Private Sub PRODUCTOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRODUCTOSToolStripMenuItem.Click
        F_PRODUCTOS.MdiParent = Me
        F_PRODUCTOS.Show()
    End Sub
End Class