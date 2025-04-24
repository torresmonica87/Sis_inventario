Imports MySql.Data.MySqlClient
Imports System.IO
Public Class F_PRODUCTOS
    Dim botonactivo As New List(Of String) From {"btnguardar", "btncancelar"}
    Dim botoninactivo As New List(Of String) From {"btnnuevo", "btnmodificar", "btnsalir"}
    Dim txtlectura As New List(Of String) From {"txtid", "txtdetalle", "txtcosto", "txtventa", "txtstock", "txtmin"}
    Dim txteditable As New List(Of String) From {"TXTID"} 'ESTE CONTROL NO EXISTE
    Dim op As Integer, consul1 As String, pcost1 As Double, pvp1 As Double, st1 As Double, stmin1 As Double
    Dim selectimagen As String = ""
    Dim carpetaservidor As String = "C:\laragon\www\sis_inventario\foto_producto" 'ruta local de imagen
    Dim rutaweb As Integer
    Dim nombrefinal As Integer
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
            File.Copy(selectimagen, rutadestino, True)
            Dim rutaweb As String = "http://localhost/sis_inventario/foto_producto/" & nombrefinal 'ruta web local 
            Dim consul1 As String = ""
            If op = 1 Then 'producto nuevo
                consul1 = "INSERT INTO productos (id_prod, deta_prod, pcosto_prod, pventa_prod, stock_prod, cadu_prod, fec_cadu_prod, stock_min_prod, estado_prod, foto_prod, id_cate, id_usuario) " +
                    "VALUES ('" + Trim(UCase(txtid.Text)) + "', '" + Trim(UCase(txtdetalle.Text)) + "', '" + Str(pcost1) + "', '" + Str(pvp1) + "', '" + Str(st1) + "', '" + Trim(UCase(cbcaduca.Text)) + "', '" + Trim(Format(dtfecha.Value.Date, "yyyy-MM-dd")) + "', '" +
                    Str(stmin1) + "', '" + Trim(UCase(cbestado.Text)) + "', '" + Trim(rutaweb) + "', '" + Str(cbcategoria.SelectedValue) + "', '" + Str(idusu) + "')"

            End If
            If acciontabla(consul1) Then
                MsgBox("REGISTRO ACTUALIZADO!")
                limpiatextos(Me)
                DESACTIVAR()
                btnnuevo.Focus()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GroupBox1.Visible = True
        txtcateg.Text = ""
        txtcateg.Focus()
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
End Class