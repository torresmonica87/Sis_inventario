﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_PRODUCTOS
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtdetalle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcosto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtventa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbcaduca = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtmin = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbestado = New System.Windows.Forms.ComboBox()
        Me.lbimagen = New System.Windows.Forms.Label()
        Me.pbfoto = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbcategoria = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtcateg = New System.Windows.Forms.TextBox()
        Me.btnsubirfoto = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.rbcodigo = New System.Windows.Forms.RadioButton()
        Me.rbnombre = New System.Windows.Forms.RadioButton()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.pbfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CÓDIGO"
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(173, 60)
        Me.txtid.MaxLength = 25
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(156, 22)
        Me.txtid.TabIndex = 1
        '
        'txtdetalle
        '
        Me.txtdetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdetalle.Location = New System.Drawing.Point(173, 87)
        Me.txtdetalle.MaxLength = 100
        Me.txtdetalle.Name = "txtdetalle"
        Me.txtdetalle.ReadOnly = True
        Me.txtdetalle.Size = New System.Drawing.Size(500, 22)
        Me.txtdetalle.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DESCRIPCIÓN"
        '
        'txtcosto
        '
        Me.txtcosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcosto.Location = New System.Drawing.Point(173, 115)
        Me.txtcosto.MaxLength = 25
        Me.txtcosto.Name = "txtcosto"
        Me.txtcosto.ReadOnly = True
        Me.txtcosto.Size = New System.Drawing.Size(97, 22)
        Me.txtcosto.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 27)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "P. COSTO"
        '
        'txtventa
        '
        Me.txtventa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtventa.Location = New System.Drawing.Point(382, 114)
        Me.txtventa.MaxLength = 25
        Me.txtventa.Name = "txtventa"
        Me.txtventa.ReadOnly = True
        Me.txtventa.Size = New System.Drawing.Size(97, 22)
        Me.txtventa.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(295, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 27)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "P. VENTA"
        '
        'txtstock
        '
        Me.txtstock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstock.Location = New System.Drawing.Point(576, 117)
        Me.txtstock.MaxLength = 25
        Me.txtstock.Name = "txtstock"
        Me.txtstock.ReadOnly = True
        Me.txtstock.Size = New System.Drawing.Size(97, 22)
        Me.txtstock.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(508, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 27)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "STOCK"
        '
        'cbcaduca
        '
        Me.cbcaduca.FormattingEnabled = True
        Me.cbcaduca.Items.AddRange(New Object() {"SI", "NO"})
        Me.cbcaduca.Location = New System.Drawing.Point(173, 145)
        Me.cbcaduca.Name = "cbcaduca"
        Me.cbcaduca.Size = New System.Drawing.Size(97, 21)
        Me.cbcaduca.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(59, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 27)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "CADUCA"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(295, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 27)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "F.CADUCA"
        '
        'dtfecha
        '
        Me.dtfecha.Location = New System.Drawing.Point(391, 144)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(282, 20)
        Me.dtfecha.TabIndex = 13
        '
        'txtmin
        '
        Me.txtmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmin.Location = New System.Drawing.Point(173, 170)
        Me.txtmin.MaxLength = 25
        Me.txtmin.Name = "txtmin"
        Me.txtmin.ReadOnly = True
        Me.txtmin.Size = New System.Drawing.Size(97, 22)
        Me.txtmin.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(59, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 27)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "STOCK MIN"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(59, 205)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 27)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "ESTADO"
        '
        'cbestado
        '
        Me.cbestado.FormattingEnabled = True
        Me.cbestado.Items.AddRange(New Object() {"ACTIVO", "INACTIVO"})
        Me.cbestado.Location = New System.Drawing.Point(173, 204)
        Me.cbestado.Name = "cbestado"
        Me.cbestado.Size = New System.Drawing.Size(97, 21)
        Me.cbestado.TabIndex = 17
        '
        'lbimagen
        '
        Me.lbimagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbimagen.Location = New System.Drawing.Point(59, 346)
        Me.lbimagen.Name = "lbimagen"
        Me.lbimagen.Size = New System.Drawing.Size(106, 27)
        Me.lbimagen.TabIndex = 18
        Me.lbimagen.Text = "IMAGEN"
        '
        'pbfoto
        '
        Me.pbfoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbfoto.Location = New System.Drawing.Point(62, 235)
        Me.pbfoto.Name = "pbfoto"
        Me.pbfoto.Size = New System.Drawing.Size(87, 99)
        Me.pbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbfoto.TabIndex = 19
        Me.pbfoto.TabStop = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(295, 204)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 27)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "CATEGORÍA"
        '
        'cbcategoria
        '
        Me.cbcategoria.FormattingEnabled = True
        Me.cbcategoria.Location = New System.Drawing.Point(391, 204)
        Me.cbcategoria.Name = "cbcategoria"
        Me.cbcategoria.Size = New System.Drawing.Size(282, 21)
        Me.cbcategoria.TabIndex = 21
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(391, 175)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(282, 22)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "CREAR CATEGORIA"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.PowderBlue
        Me.btnnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnuevo.Location = New System.Drawing.Point(86, 376)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(106, 31)
        Me.btnnuevo.TabIndex = 24
        Me.btnnuevo.Text = "NUEVO"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.PowderBlue
        Me.btncancelar.Enabled = False
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Location = New System.Drawing.Point(310, 376)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(106, 31)
        Me.btncancelar.TabIndex = 25
        Me.btncancelar.Text = "CANCELAR"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.PowderBlue
        Me.btnguardar.Enabled = False
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.Location = New System.Drawing.Point(198, 376)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(106, 31)
        Me.btnguardar.TabIndex = 26
        Me.btnguardar.Text = "GUARDAR"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.PowderBlue
        Me.btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.Location = New System.Drawing.Point(535, 376)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(106, 31)
        Me.btnsalir.TabIndex = 27
        Me.btnsalir.Text = "SALIR"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.PowderBlue
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.Location = New System.Drawing.Point(422, 376)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(106, 31)
        Me.btnmodificar.TabIndex = 28
        Me.btnmodificar.Text = "MODIFICAR"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtcateg)
        Me.GroupBox1.Location = New System.Drawing.Point(302, 235)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 99)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CREAR CATEGORIAS"
        Me.GroupBox1.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(221, 56)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 32)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "CANCELAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(36, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ACEPTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtcateg
        '
        Me.txtcateg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcateg.Location = New System.Drawing.Point(19, 19)
        Me.txtcateg.Name = "txtcateg"
        Me.txtcateg.Size = New System.Drawing.Size(333, 22)
        Me.txtcateg.TabIndex = 0
        '
        'btnsubirfoto
        '
        Me.btnsubirfoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubirfoto.Location = New System.Drawing.Point(173, 234)
        Me.btnsubirfoto.Name = "btnsubirfoto"
        Me.btnsubirfoto.Size = New System.Drawing.Size(97, 27)
        Me.btnsubirfoto.TabIndex = 30
        Me.btnsubirfoto.Text = "SUBIR FOTO"
        Me.btnsubirfoto.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.dgv1)
        Me.GroupBox2.Controls.Add(Me.rbcodigo)
        Me.GroupBox2.Controls.Add(Me.rbnombre)
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(39, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(634, 347)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SELECCIONE EL PRODUCTO"
        Me.GroupBox2.Visible = False
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(508, 304)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(98, 37)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "CANCELAR"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(32, 304)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 37)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "ACEPTAR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(31, 56)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.Size = New System.Drawing.Size(575, 242)
        Me.dgv1.TabIndex = 11
        '
        'rbcodigo
        '
        Me.rbcodigo.AutoSize = True
        Me.rbcodigo.Location = New System.Drawing.Point(441, 6)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(93, 17)
        Me.rbcodigo.TabIndex = 10
        Me.rbcodigo.Text = "POR CÓDIGO"
        Me.rbcodigo.UseVisualStyleBackColor = True
        '
        'rbnombre
        '
        Me.rbnombre.AutoSize = True
        Me.rbnombre.Checked = True
        Me.rbnombre.Location = New System.Drawing.Point(316, 6)
        Me.rbnombre.Name = "rbnombre"
        Me.rbnombre.Size = New System.Drawing.Size(98, 17)
        Me.rbnombre.TabIndex = 9
        Me.rbnombre.TabStop = True
        Me.rbnombre.Text = "POR NOMBRE"
        Me.rbnombre.UseVisualStyleBackColor = True
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(197, 25)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(409, 20)
        Me.txtbuscar.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(28, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(163, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "INGRESE TODO O PARTE:"
        '
        'F_PRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnsubirfoto)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cbcategoria)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.pbfoto)
        Me.Controls.Add(Me.lbimagen)
        Me.Controls.Add(Me.cbestado)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtmin)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtfecha)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbcaduca)
        Me.Controls.Add(Me.txtstock)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtventa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcosto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtdetalle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "F_PRODUCTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONTROL DE PRODUCTOS"
        CType(Me.pbfoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtdetalle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcosto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtventa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtstock As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbcaduca As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtfecha As DateTimePicker
    Friend WithEvents txtmin As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbestado As ComboBox
    Friend WithEvents lbimagen As Label
    Friend WithEvents pbfoto As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbcategoria As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtcateg As TextBox
    Friend WithEvents btnsubirfoto As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents rbcodigo As RadioButton
    Friend WithEvents rbnombre As RadioButton
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents Label10 As Label
End Class
