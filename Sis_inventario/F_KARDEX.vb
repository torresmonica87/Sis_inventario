Public Class F_KARDEX
    Dim tipo1 As Integer
    Dim btactivo As New List(Of String) From {"btnguardar", " btncancelar"}
    Dim btinactivo As New List(Of String) From {"btnentrada", "btnsalida", "btnbuscar", "btnsalir"}
    Dim lecturatext As New List(Of String) From {"txtmovimiento", "txtentrada", "txtsalida"}
    Dim editatext As New List(Of String) From {"TXTID"} '  este no existe 
    Dim consul1 As String, consul2 As String
    Dim st1 As Integer, VMOVI1 As Integer, st2 As Integer



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        If cancelar_accion() = 6 Then
            limpiatextos(Me)
            desactivar()
            btnsalir.Focus()
        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If cierre_ventana() = 6 Then
            Me.Close()
        End If
    End Sub
    Sub mostrar_producto()
        dgv1.DataSource = ds.Tables("productos")
        dgv1.Columns(5).Visible = False
        dgv1.Columns(6).Visible = False
        dgv1.Columns(7).Visible = False
        dgv1.Columns(8).Visible = False
        dgv1.Columns(9).Visible = False
        dgv1.Columns(10).Visible = False
        dgv1.Columns(11).Visible = False
        dgv1.Columns(0).HeaderText = "CÓDIGO"
        dgv1.Columns(1).HeaderText = "DETALLE"
        dgv1.Columns(2).HeaderText = "P. COSTO"
        dgv1.Columns(3).HeaderText = "P.V.P."
        dgv1.Columns(4).HeaderText = "STOCK"
        dgv1.Columns(1).Width = "200"
        dgv1.Columns(2).Width = "75"
        dgv1.Columns(3).Width = "75"
        dgv1.Columns(4).Width = "75"
    End Sub
    Sub pasar_datos()
        txtid.Text = Trim(dgv1.CurrentRow.Cells(0).Value)
        txtdetalle.Text = Trim(dgv1.CurrentRow.Cells(1).Value)
        txtcosto.Text = Trim(dgv1.CurrentRow.Cells(2).Value)
        txtventa.Text = Trim(dgv1.CurrentRow.Cells(3).Value)
        txtstock.Text = Trim(dgv1.CurrentRow.Cells(4).Value)
    End Sub

    Sub calcular()
        VMOVI1 = 0
        If txtid.Text <> "" Then
            If txtstock.Text = "" Then
                st1 = 0
            Else
                st1 = Val(txtstock.Text)
            End If

            If tipo1 = 1 Then ' sumar
                If txtentrada.Text = "" Then
                    VMOVI1 = 0
                Else
                    VMOVI1 = Val(txtentrada.Text)
                End If
                st2 = st1 + VMOVI1
            ElseIf tipo1 = 2 Then ' restar
                If txtsalida.Text = "" Then
                    VMOVI1 = 0
                Else
                    VMOVI1 = Val(txtsalida.Text)
                End If

                If VMOVI1 > st1 Then
                    MsgBox("EL VALOR INGRESADO SUPERA EL STOCK!!!")
                    VMOVI1 = 0
                    txtsalida.Text = ""
                    txtsalida.Focus()
                End If
                st2 = st1 - VMOVI1
            End If

            ' FALTÓOOOOOO MUY IMPORTANTE: ACTUALIZAR EL CAMPO txtsaldo
            txtsaldo.Text = st2.ToString
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox1.Visible = True
        txtbuscar.Text = ""
        consultas("Select * from productos", "productos")
        mostrar_producto()
        txtbuscar.Focus()
    End Sub
    Sub activar()
        estadoboton(Me, btactivo, btinactivo)
        lecturayescritura(Me, editatext, lecturatext)
    End Sub
    Sub desactivar()
        estadoboton(Me, btinactivo, btactivo)
        lecturayescritura(Me, lecturatext, editatext)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GroupBox1.Visible = False

    End Sub
    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        If rbnombre.Checked = True Then 'no filtra rbnombre 
            consultas("select * from productos where deta_prod like'" + Trim(txtbuscar.Text) + "%'", "productos")
        Else
            consultas("select * from productos where id_prod like'" + Trim(txtbuscar.Text) + "%'", "productos")
        End If
        mostrar_producto()
    End Sub


    Private Sub txtsaldo_TextChanged(sender As Object, e As EventArgs) Handles txtsaldo.TextChanged
        'txtsaldo.Text = st2
        'Una mejor forma sería eliminar el evento en txtsaldo, porque ya en calcular() se actualiza txtsaldo. No necesito actualizarlo en TextChanged puede provocar un ciclo infinito.??
        'probado 
    End Sub

    Private Sub txtentrada_TextChanged(sender As Object, e As EventArgs) Handles txtentrada.TextChanged
        If txtentrada.Text <> "" Then
            If Not IsNumeric(txtentrada.Text) Then
                MsgBox("AVISO: SÓLO INGRESE UN VALOR NUMÉRICO!")
                txtentrada.Text = ""
                txtentrada.Focus()
            Else
                calcular()
            End If
        End If
    End Sub

    Private Sub txtsalida_TextChanged(sender As Object, e As EventArgs) Handles txtsalida.TextChanged
        If txtsalida.Text <> "" Then
            If Not IsNumeric(txtsalida.Text) Then
                MsgBox("AVISO: SÓLO INGRESE UN VALOR NUMÉRICO!")
                txtsalida.Text = ""
                txtsalida.Focus()
            Else
                calcular()
            End If
        End If
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If txtid.Text = "" Or txtmovimiento.Text = "" Or VMOVI1 = 0 Then
            MsgBox("LOS DATOS NO ESTÁN COMPLETOS!!")
            Button1.Focus()

        Else
            Dim valorentrada1 As Integer, valorsalida1 As Integer
            If tipo1 = 1 Then
                valorentrada1 = VMOVI1
                valorsalida1 = 0
            Else
                valorentrada1 = 0
                valorsalida1 = VMOVI1


            End If
            'registrar movimiento en kardex
            consul1 = "insert into kardex (fecha_kardex, detalle_kardex,entrada_kardex, salida_kardex, saldo_kardex, id_prod, id_usuario)" _
                & " values ('" + Trim(Format(dtfecha.Value.Date, "yyyy-MM-dd")) + "','" + Trim(UCase(txtmovimiento.Text)) + "','" + Str(valorentrada1) + "','" + Str(valorsalida1) + "'" _
                & ", '" + Str(st2) + "','" + Trim(txtid.Text) + "','" + Str(idusu) + "')"

            'actualizar stock de productos
            consul2 = "update productos set stock_prod='" + Str(st2) + "'where id_prod='" + Trim(txtid.Text) + "'"
            If acciontabla(consul1) And acciontabla(consul2) Then
                MsgBox("REGISTRO ACTUALIZADO EXITOSAMENTE!")
                Limpiartextos(Me)
                desactivar()
                btnentrada.Focus()


            End If
        End If
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        GroupBox1.Visible = True
        txtbuscar.Text = ""
        consultas("SELECT * FROM productos", "productos")
        mostrar_producto()
        txtbuscar.Focus()
    End Sub

    Private Sub btnentrada_Click(sender As Object, e As EventArgs) Handles btnentrada.Click
        tipo1 = 1 ' entrada de informacion
        activar()
        limpiatextos(Me)
        txtsalida.ReadOnly = True
        Button1.Focus()


    End Sub

    Private Sub btnsalida_Click(sender As Object, e As EventArgs) Handles btnsalida.Click
        tipo1 = 2
        activar()
        limpiatextos(Me)
        txtentrada.ReadOnly = True
        Button1.Focus()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If dgv1.Rows.Count > 0 Then
            GroupBox1.Visible = False
            pasar_datos()
            dtfecha.Focus()
        End If
    End Sub
End Class