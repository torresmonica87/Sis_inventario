Imports MySql.Data.MySqlClient
Imports System.IO
Public Class F_PRODUCTOS
    Dim botonactivo As New List(Of String) From {"btnguardar", "btncancelar"}
    Dim botoninactivo As New List(Of String) From {"btnnuevo", "btnmodificar", "btnsalir"}
    Dim txtlectura As New List(Of String) From {"txtid", "txtdetalle", "txtcosto", "txtventa", "txtstock", "txtmin"}
    Dim txteditable As New List(Of String) From {"TXTID"} 'ESTE CONTROL NO EXISTE
    Dim op As Integer
    Dim consul1 As String
    Dim selectimagen As String = ""
    ' Dim carpetaservidor As String = 'ruta de imagen
    Dim rutaweb As Integer
    Dim carpetaservidor As Integer
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
    Sub llenarcategorias()
        Dim cate1 As New MySqlDataAdapter("select * from categorias", conex)
        Dim dscate As New DataSet()
        cate1.Fill(dscate.Tables("categorias"))
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

    Private Sub F_PRODUCTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' pbfoto.Load("") 'aqui falta colocar la direccion enlace de la imagen 
        ' If conex.State <> ConnectionState.Open Then

        ' End If
        ' conexion()
        'llenarcategorias()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtcate.Text = "" Then
            MsgBox("LOS DATOS NO ESTÁN COMPLETOS")
            txtcate.Focus()
        Else
            consul1 = "INSERT INTO categorias (detalle_cate, id_usuario) VALUES ('" & Trim(UCase(txtcate.Text)) & "', " & idusu & ")"
            If acciontabla(consul1) Then
                MsgBox("CATEGORIA AGREGADA")
                txtcate.Text = ""
                GroupBox1.Visible = False
                llenarcategorias()
            End If
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtcate.Text = ""
        GroupBox1.Visible = False

    End Sub

    Private Sub pbfoto_Click(sender As Object, e As EventArgs) Handles pbfoto.Click
        OpenFileDialog1.Filter = "Imágenes|*.jpg;*.jpeg;*.png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pbfoto.Image = Image.FromFile(OpenFileDialog1.FileName)
            selectimagen = OpenFileDialog1.FileName
        End If
    End Sub


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        GroupBox1.Visible = True
        txtcate.Text = ""
        txtcate.Focus()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        If txtid.Text = "" Or txtdetalle.Text = "" Or txtcosto.Text = "" Or txtventa.Text = "" Or txtmin.Text = "" Or cbcaduca.Text = "" Then
            MsgBox("LOS DATOS NO ESTÁN COMPLETOS")
            txtid.Focus()
            Exit Sub
        End If


        Dim nombreorigen As String = Path.GetFileNameWithoutExtension(selectimagen)
        Dim extension As String = Path.GetExtension(selectimagen)
        Dim timestamp As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")
        Dim nombrefinal As String = nombreorigen & "_" & timestamp & extension
        Dim rutadestino As String = Path.Combine(carpetaservidor, nombrefinal)
        Dim rutaweb As String = "/" & nombrefinal 'falta colocar la ruta

        If op = 1 Then ' Producto nuevo
            Dim consul1 As String = "INSERT INTO productos (id_prod, deta_prod, pcosto_prod, pventa_prod, stock_prod, cadu_prod, fec_cadu_prod, stock_min_prod, estado_prod, foto_prod) " &
                    "VALUES ('" & txtid.Text & "', '" & txtdetalle.Text & "', '" & txtcosto.Text & "', '" & txtventa.Text & "', 0, '" & cbcaduca.Text & "', NULL, '" & txtmin.Text & "', 'A', '" & rutaweb & "')"

            If acciontabla(consul1) Then
                MsgBox("PRODUCTO AGREGADO")
            End If
        End If
    End Sub
End Class