<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pbfoto = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbcategoria = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        CType(Me.pbfoto, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(59, 346)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 27)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "IMAGEN"
        '
        'pbfoto
        '
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
        Me.btnnuevo.Location = New System.Drawing.Point(70, 376)
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
        Me.btncancelar.Location = New System.Drawing.Point(294, 376)
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
        Me.btnguardar.Location = New System.Drawing.Point(182, 376)
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
        Me.btnsalir.Location = New System.Drawing.Point(519, 376)
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
        Me.btnmodificar.Location = New System.Drawing.Point(406, 376)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(106, 31)
        Me.btnmodificar.TabIndex = 28
        Me.btnmodificar.Text = "MODIFICAR"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'F_PRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cbcategoria)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.pbfoto)
        Me.Controls.Add(Me.Label10)
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
    Friend WithEvents Label10 As Label
    Friend WithEvents pbfoto As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbcategoria As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnmodificar As Button
End Class
