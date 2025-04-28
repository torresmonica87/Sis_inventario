Imports MySql.Data.MySqlClient
Imports System.IO
Public Class F_PRODUCTOS
    Dim botonactivo As New List(Of String) From {"btnguardar", "btncancelar"}
    Dim botoninactivo As New List(Of String) From {"btnnuevo", "btnmodificar", "btnsalir"}
    Dim txtlectura As New List(Of String) From {"txtid", "txtdetalle", "txtcosto", "txtventa", "txtstock", "txtmin"}
    Dim txteditable As New List(Of String) From {"TXTID"} 'ESTE CONTROL NO EXISTE
    Dim op As Integer, consul1 As String, pcost1 As Double, pvp1 As Double, st1 As Double, stmin1 As Double, consul2 As String
    Dim selectimagen As String = ""
    Dim carpetaservidor As String = "C:\laragon\www\sis_inventario\foto_producto" 'ruta local de imagen
    Dim rutaweb As Integer
    Dim nombrefinal As Integer
    Dim selecimagen As String = ""
    Dim imagenmod As String
    Sub mostrar_datos()
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
        cbcaduca.Text = Trim(dgv1.CurrentRow.Cells(5).Value)
        dtfecha.Value = Trim(dgv1.CurrentRow.Cells(6).Value)
        txtmin.Text = Trim(dgv1.CurrentRow.Cells(7).Value)
        cbestado.Text = Trim(dgv1.CurrentRow.Cells(8).Value)
        pbfoto.Load(Trim(dgv1.CurrentRow.Cells(9).Value))
        imagenmod = Trim(dgv1.CurrentRow.Cells(9).Value)
        lbimagen.Text = Trim(dgv1.CurrentRow.Cells(9).Value)
        cbcategoria.SelectedValue = Trim(dgv1.CurrentRow.Cells(10).Value)

    End Sub
    Sub ACTIVAR()
        estadoboton(Me, botonactivo, botoninactivo)
        lecturayescritura(Me, txteditable, txtlectura)
    End Sub
    Sub DESACTIVAR()
        estadoboton(Me, botoninactivo, botonactivo)
        lecturayescritura(Me, txtlectura, txteditable)
    End Sub
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If cierre_ventana() = 6 Then
            Me.Close()
        End If
    End Sub
    Sub llenarcategorias() 'para seleccionar categorias en el formulario de control de productos
        Dim cate1 As New MySqlDataAdapter("select * from categorias", conex)
        Dim dscate As New DataSet()
        cate1.Fill(dscate, "categorias")
        cbcategoria.DataSource = dscate.Tables("categorias")
        cbcategoria.ValueMember = ("id_cate")
        cbcategoria.DisplayMember = ("detalle_cate")
    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiatextos(Me)
        ACTIVAR()
        op = 1
        txtid.Focus()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        If cancelar_accion() = 6 Then
            limpiatextos(Me)
            DESACTIVAR()
            btnsalir.Focus()
        End If
    End Sub
    'cuando doy doble click a formulario control de productos
    Private Sub F_PRODUCTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbfoto.Load("http://localhost/sis_inventario/foto_producto/PRODUCTO.png") 'si quiero colocarle red solo coloco la dirección ip en lugar del localhost
        If conex.State <> ConnectionState.Open Then
            conexion()
        End If
        llenarcategorias()
    End Sub
    'boton aceptar del groupbox de control de productos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtcateg.Text = "" Then
            MsgBox("LOS DATOS NO ESTÁN COMPLETOS!")
            txtcateg.Focus()
        Else
            consul1 = "INSERT INTO categorias (detalle_cate, id_usuario) values ('" + Trim(UCase(txtcateg.Text)) + "', '" + Str(idusu) + "')"
            If acciontabla(consul1) Then
                MsgBox("CATEGORIA AGREGADA CON ÉXITO")
                txtcateg.Text = ""
                GroupBox1.Visible = False
                llenarcategorias()
            End If
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtcateg.Text = ""
        GroupBox1.Visible = False
    End Sub

    Private Sub pbfoto_Click(sender As Object, e As EventArgs) Handles pbfoto.Click

    End Sub


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        GroupBox1.Visible = True
        txtcateg.Text = ""
        txtcateg.Focus()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        'boton guardar de control de productos
        If txtid.Text = "" Or txtdetalle.Text = "" Or txtcosto.Text = "" Or txtventa.Text = "" Or txtmin.Text = "" Or cbcaduca.Text = "" Or cbestado.Text = "" Or cbcategoria.Text = "" Then
            MsgBox("LOS DATOS NO ESTÁN COMPLETOS")
            txtid.Focus()
        Else
            pcost1 = txtcosto.Text
            pvp1 = txtventa.Text
            st1 = txtstock.Text
            stmin1 = txtmin.Text
            Dim nombreorigen As String = Path.GetFileNameWithoutExtension(selectimagen)
            Dim extension As String = Path.GetExtension(selectimagen)
            Dim timestamp As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")
            Dim nombrefinal As String = $"{nombreorigen}_{timestamp}{extension}"
            Dim rutadestino As String = Path.Combine(carpetaservidor, nombrefinal)


            Dim rutaweb As String = "http://localhost/sis_inventario/foto_producto/" & nombrefinal 'ruta web local 
            Dim consul1 As String = ""
            If op = 1 Then 'me permite agregar un producto nuevo
                File.Copy(selectimagen, rutadestino, True)
                consul1 = "INSERT INTO productos (id_prod, deta_prod, pcosto_prod, pventa_prod, stock_prod, cadu_prod, fec_cadu_prod, stock_min_prod, estado_prod, foto_prod, id_cate, id_usuario) " +
                    "VALUES ('" + Trim(UCase(txtid.Text)) + "', '" + Trim(UCase(txtdetalle.Text)) + "', '" + Str(pcost1) + "', '" + Str(pvp1) + "', '" + Str(st1) + "', '" + Trim(UCase(cbcaduca.Text)) + "', '" + Trim(Format(dtfecha.Value.Date, "yyyy-MM-dd")) + "', '" +
                    Str(stmin1) + "', '" + Trim(UCase(cbestado.Text)) + "', '" + Trim(rutaweb) + "', '" + Str(cbcategoria.SelectedValue) + "', '" + Str(idusu) + "')"
                'crear registro en kardex solo para productos nuevos, al modificarle no se creará registro para kardex
                consul2 = "insert into kardex (fecha_kardex,detalle_kardex,entrada_kardex,salida_kardex,saldo_kardex,id_prod,id_usuario)" _
                    & "values('" + Format(Now.Date, "yyyy-MM-dd") + "','" + "INVENTARIO INICIAL" + "','" + Str(st1) + "','" + "0" + "','" + Str(st1) + "'" _
                    & " ,'" + Trim(UCase(txtid.Text)) + "','" + Str(idusu) + "')"

                If acciontabla(consul1) And acciontabla(consul2) Then
                    MsgBox("REGISTRO ACTUALIZADO.!!!!")
                    limpiatextos(Me)
                    DESACTIVAR()
                    pbfoto.Load("http://localhost/sis_inventario/foto_producto/PRODUCTO.png")
                    btnnuevo.Focus()
                End If
            Else
                'nos permite modificar un producto 
                If imagenmod = Trim(lbimagen.Text) Then
                    rutaweb = imagenmod
                Else
                    rutaweb = "http://localhost/sis_inventario/foto_producto/" & nombrefinal
                    File.Copy(selecimagen, rutadestino, True)
                End If
                consul1 = "UPDATE productos set deta_prod='" + Trim(txtdetalle.Text) + "',pcosto_prod='" + Str(pcost1) + "'" _
                    & ",pventa_prod='" + Str(pvp1) + "',cadu_prod='" + Trim(cbcaduca.Text) + "',fec_cadu_prod='" + Trim(Format(dtfecha.Value.Date, "yyyy-MM-dd")) + "'" _
                    & ",stock_min_prod='" + Str(stmin1) + "',estado_prod='" + Trim(cbestado.Text) + "',foto_prod='" + Trim(rutaweb) + "',id_cate='" + Trim(cbcategoria.SelectedValue) + "'" _
                    & ",id_usuario='" + Str(idusu) + "' where id_prod='" + Trim(txtid.Text) + "'"
                consul2 = "insert into kardex (fecha_kardex,detalle_kardex,entrada_kardex,salida_kardex,saldo_kardex,id_prod,id_usuario)" _
                    & "values('" + Format(Now.Date, "yyyy-MM-dd") + "','" + "INVENTARIO INICIAL" + "','" + Str(st1) + "','" + "0" + "','" + Str(st1) + "'" _
                    & " ,'" + Trim(UCase(txtid.Text)) + "','" + Str(idusu) + "')"
                If acciontabla(consul1) And acciontabla(consul2) Then
                    MsgBox("REGISTRO ACTUALIZADO.!!!!")
                    limpiatextos(Me)
                    DESACTIVAR()
                    pbfoto.Load("http://localhost/sis_inventario/foto_producto/PRODUCTO.png")
                    btnnuevo.Focus()
                End If

                'Editar
                If imagenmod = Trim(lbimagen.Text) Then
                    rutaweb = imagenmod
                Else
                    rutaweb = "http://localhost/sis_inventario/foto_producto/" & nombrefinal
                    File.Copy(selecimagen, rutadestino, True)
                End If
                consul1 = "UPDATE productos set deta_prod='" + Trim(txtdetalle.Text) + "',pcosto_prod='" + Str(pcost1) + "'" _
                    & ",pventa_prod='" + Str(pvp1) + "',cadu_prod='" + Trim(cbcaduca.Text) + "',fec_cadu_prod='" + Trim(Format(dtfecha.Value.Date, "yyyy-MM-dd")) + "'" _
                    & ",stock_min_prod='" + Str(stmin1) + "',estado_prod='" + Trim(cbestado.Text) + "',foto_prod='" + Trim(rutaweb) + "',id_cate='" + Trim(cbcategoria.SelectedValue) + "'" _
                    & ",id_usuario='" + Str(idusu) + "' where id_prod='" + Trim(txtid.Text) + "'"

                If acciontabla(consul1) Then
                    MsgBox("REGISTRO ACTUALIZADO.!!!!")
                    limpiatextos(Me)
                    DESACTIVAR()
                    pbfoto.Load("http://localhost/sis_inventario/foto_producto/PRODUCTO.png")
                    btnnuevo.Focus()
                End If
            End If


        End If

    End Sub

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GroupBox1.Visible = True
        txtcateg.Text = ""
        txtcateg.Focus()
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        If Trim(tipusu) <> "ADMINISTRADOR" Then
            MsgBox("AVISO: NO TIENE PERMISO PARA REALIZAR ESTA ACCIÓN..!!!")
        Else
            op = 2
            consultas("select * from productos", "productos")
            mostrar_datos()
            GroupBox2.Visible = True
            txtbuscar.Text = ""
            txtbuscar.Focus()

        End If
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        If rbnombre.Checked = True Then 'no filtra rbnombre 
            consultas("select * from productos where deta_prod like'" + Trim(txtbuscar.Text) + "%'", "productos")
        Else
            consultas("select * from productos where id_prod like'" + Trim(txtbuscar.Text) + "%'", "productos")
        End If
        mostrar_datos()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If dgv1.Rows.Count > 0 Then
            GroupBox2.Visible = False
            ACTIVAR()
            txtid.ReadOnly = True
            txtstock.ReadOnly = True
            txtdetalle.Focus()
            pasar_datos()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GroupBox2.Visible = False
    End Sub

    Private Sub cbcategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcategoria.SelectedIndexChanged

    End Sub

    Private Sub txtcate_TextChanged(sender As Object, e As EventArgs) Handles txtcateg.TextChanged

    End Sub

    Private Sub btnsubirfoto_Click(sender As Object, e As EventArgs) Handles btnsubirfoto.Click
        'boton subirfoto de formulario control de producto
        OpenFileDialog1.Filter = "Imágenes|*.jpg;*.jpeg;*.png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            selectimagen = OpenFileDialog1.FileName
            pbfoto.Image = Image.FromFile(selectimagen)
            lbimagen.Text = selectimagen
        End If
    End Sub

    Private Sub lbimagen_Click(sender As Object, e As EventArgs) Handles lbimagen.Click
        'este es el label imagen que esta debajo de pbfoto en control de productos
    End Sub

    Private Sub txtcate_LostFocus(sender As Object, e As EventArgs) Handles txtcateg.LostFocus
        If txtcateg.Text <> "" Then
            Dim consultacate1 As New MySqlDataAdapter("select * FROM categorias where detalle_cate = '" + Trim(txtcateg.Text) + "'", conex)
            Dim dsc1 As New DataSet
            consultacate1.Fill(dsc1, "categorias")
            If dsc1.Tables("categorias").Rows.Count > 0 Then
                MsgBox("LA CATEGORÍA YA EXISTE!")
                txtcateg.Text = ""
                txtcateg.Focus()
            End If
        End If
    End Sub

    Private Sub txtid_LostFocus(sender As Object, e As EventArgs) Handles txtid.LostFocus
        If op = 1 And txtid.Text <> "" Then
            consultas("select * from productos where id_prod='" + Trim(txtid.Text) + "'", "productos")
            If ds.Tables("productos").Rows.Count > 0 Then
                MsgBox("ESTE CÓDIGO YA EXISTE!!.. PERTENECE A:" + ds.Tables("productos").Rows(0).Item("deta_prod"))
                txtid.Text = ""
                txtid.Focus()
            End If
        End If
    End Sub
End Class