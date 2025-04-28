Public Class F_MENUP
    Private Sub USUARIOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USUARIOSToolStripMenuItem.Click
        F_USUARIOS.MdiParent = Me
        F_USUARIOS.Show()
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
        ' F_PRODUCTOS.MdiParent = Me SE COMENTO CUANDO EMPECE A REALIZAR KARDEX
        ' F_PRODUCTOS.Show() ESTAS LINEAS LE PEGUE HACIENDO DOBLE CLICK EN LA OPCION REGISTRO DE PRODUCTOS DESDE F_MENU
    End Sub

    Private Sub CLIENTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLIENTESToolStripMenuItem.Click
        F_CLIENTES.MdiParent = Me
        F_CLIENTES.Show()
    End Sub

    Private Sub PROVEEDORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PROVEEDORESToolStripMenuItem.Click
        F_PROVEEDORES.MdiParent = Me
        F_PROVEEDORES.Show()
    End Sub

    Private Sub REGISTRODEPRODUCTIOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGISTRODEPRODUCTIOSToolStripMenuItem.Click
        'F_PRODUCTOS.MdiParent = Me
        ' F_PRODUCTOS.Show()
        Dim hijoDeFProducto As New F_PRODUCTOS
        hijoDeFProducto.ShowDialog()
    End Sub

    Private Sub MOVIMIENTODEPRODUCTOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOVIMIENTODEPRODUCTOSToolStripMenuItem.Click
        'DOBLE CLICK MOVIEMINTO DE PRODUCTROS DE F_MENU
        F_KARDEX.MdiParent = Me
        F_KARDEX.Show()
    End Sub
End Class