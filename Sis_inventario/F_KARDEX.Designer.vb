<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_KARDEX
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
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtdetalle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtventa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcosto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtmovimiento = New System.Windows.Forms.TextBox()
        Me.txtsaldo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtsalida = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtentrada = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnentrada = New System.Windows.Forms.Button()
        Me.btnsalida = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.rbcodigo = New System.Windows.Forms.RadioButton()
        Me.rbnombre = New System.Windows.Forms.RadioButton()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.PowderBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(711, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATOS DEL PRODUCTO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label2
        '
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(38, 78)
        Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(100, 23)
        Me.label2.TabIndex = 1
        Me.label2.Text = "CÓDIGO"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(162, 78)
        Me.txtid.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(205, 20)
        Me.txtid.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(386, 78)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(365, 22)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "SELECCIONAR PRODUCTO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtdetalle
        '
        Me.txtdetalle.Location = New System.Drawing.Point(162, 112)
        Me.txtdetalle.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtdetalle.Name = "txtdetalle"
        Me.txtdetalle.ReadOnly = True
        Me.txtdetalle.Size = New System.Drawing.Size(588, 20)
        Me.txtdetalle.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 112)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "DESCRIPCION"
        '
        'txtstock
        '
        Me.txtstock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstock.Location = New System.Drawing.Point(630, 149)
        Me.txtstock.MaxLength = 25
        Me.txtstock.Name = "txtstock"
        Me.txtstock.ReadOnly = True
        Me.txtstock.Size = New System.Drawing.Size(120, 22)
        Me.txtstock.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(529, 149)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 27)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "STOCK"
        '
        'txtventa
        '
        Me.txtventa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtventa.Location = New System.Drawing.Point(386, 149)
        Me.txtventa.MaxLength = 25
        Me.txtventa.Name = "txtventa"
        Me.txtventa.ReadOnly = True
        Me.txtventa.Size = New System.Drawing.Size(120, 22)
        Me.txtventa.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(297, 152)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 27)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "P. VENTA"
        '
        'txtcosto
        '
        Me.txtcosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcosto.Location = New System.Drawing.Point(162, 149)
        Me.txtcosto.MaxLength = 25
        Me.txtcosto.Name = "txtcosto"
        Me.txtcosto.ReadOnly = True
        Me.txtcosto.Size = New System.Drawing.Size(120, 22)
        Me.txtcosto.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 152)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 27)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "P. COSTO"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.PowderBlue
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 188)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(715, 39)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "DATOS DEL MOVIMIENTO"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtfecha
        '
        Me.dtfecha.Location = New System.Drawing.Point(162, 249)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(131, 20)
        Me.dtfecha.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 249)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 27)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "FECHA"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(38, 282)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 27)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "DETALLE"
        '
        'txtmovimiento
        '
        Me.txtmovimiento.Location = New System.Drawing.Point(162, 282)
        Me.txtmovimiento.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtmovimiento.Name = "txtmovimiento"
        Me.txtmovimiento.ReadOnly = True
        Me.txtmovimiento.Size = New System.Drawing.Size(588, 20)
        Me.txtmovimiento.TabIndex = 20
        '
        'txtsaldo
        '
        Me.txtsaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsaldo.Location = New System.Drawing.Point(630, 322)
        Me.txtsaldo.MaxLength = 25
        Me.txtsaldo.Name = "txtsaldo"
        Me.txtsaldo.ReadOnly = True
        Me.txtsaldo.Size = New System.Drawing.Size(120, 22)
        Me.txtsaldo.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(529, 322)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 27)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "SALDO"
        '
        'txtsalida
        '
        Me.txtsalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsalida.Location = New System.Drawing.Point(386, 322)
        Me.txtsalida.MaxLength = 25
        Me.txtsalida.Name = "txtsalida"
        Me.txtsalida.ReadOnly = True
        Me.txtsalida.Size = New System.Drawing.Size(120, 22)
        Me.txtsalida.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(297, 325)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 27)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "SALIDA"
        '
        'txtentrada
        '
        Me.txtentrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtentrada.Location = New System.Drawing.Point(162, 322)
        Me.txtentrada.MaxLength = 25
        Me.txtentrada.Name = "txtentrada"
        Me.txtentrada.ReadOnly = True
        Me.txtentrada.Size = New System.Drawing.Size(120, 22)
        Me.txtentrada.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(38, 325)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 27)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "ENTRADA"
        '
        'btnentrada
        '
        Me.btnentrada.BackColor = System.Drawing.Color.PowderBlue
        Me.btnentrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnentrada.Location = New System.Drawing.Point(37, 375)
        Me.btnentrada.Name = "btnentrada"
        Me.btnentrada.Size = New System.Drawing.Size(92, 38)
        Me.btnentrada.TabIndex = 28
        Me.btnentrada.Text = "ENTRADA"
        Me.btnentrada.UseVisualStyleBackColor = False
        '
        'btnsalida
        '
        Me.btnsalida.BackColor = System.Drawing.Color.PowderBlue
        Me.btnsalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalida.Location = New System.Drawing.Point(162, 375)
        Me.btnsalida.Name = "btnsalida"
        Me.btnsalida.Size = New System.Drawing.Size(92, 38)
        Me.btnsalida.TabIndex = 29
        Me.btnsalida.Text = "SALIDA"
        Me.btnsalida.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.PowderBlue
        Me.btnguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.Location = New System.Drawing.Point(285, 375)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(92, 38)
        Me.btnguardar.TabIndex = 30
        Me.btnguardar.Text = "GUARDAR"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.PowderBlue
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Location = New System.Drawing.Point(414, 375)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(92, 38)
        Me.btncancelar.TabIndex = 31
        Me.btncancelar.Text = "CANCELAR"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.PowderBlue
        Me.btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.Location = New System.Drawing.Point(532, 375)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(92, 38)
        Me.btnbuscar.TabIndex = 32
        Me.btnbuscar.Text = "BUSCAR"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.PowderBlue
        Me.btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.Location = New System.Drawing.Point(658, 375)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(92, 38)
        Me.btnsalir.TabIndex = 33
        Me.btnsalir.Text = "SALIR"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.dgv1)
        Me.GroupBox1.Controls.Add(Me.rbcodigo)
        Me.GroupBox1.Controls.Add(Me.rbnombre)
        Me.GroupBox1.Controls.Add(Me.txtbuscar)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(748, 382)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SELECCIONE EL PRODUCTO"
        Me.GroupBox1.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(547, 338)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 37)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "CANCELAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(71, 338)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(98, 37)
        Me.Button8.TabIndex = 19
        Me.Button8.Text = "ACEPTAR"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(70, 90)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.Size = New System.Drawing.Size(575, 242)
        Me.dgv1.TabIndex = 18
        '
        'rbcodigo
        '
        Me.rbcodigo.AutoSize = True
        Me.rbcodigo.Location = New System.Drawing.Point(480, 40)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(93, 17)
        Me.rbcodigo.TabIndex = 17
        Me.rbcodigo.Text = "POR CÓDIGO"
        Me.rbcodigo.UseVisualStyleBackColor = True
        '
        'rbnombre
        '
        Me.rbnombre.AutoSize = True
        Me.rbnombre.Checked = True
        Me.rbnombre.Location = New System.Drawing.Point(355, 40)
        Me.rbnombre.Name = "rbnombre"
        Me.rbnombre.Size = New System.Drawing.Size(98, 17)
        Me.rbnombre.TabIndex = 16
        Me.rbnombre.TabStop = True
        Me.rbnombre.Text = "POR NOMBRE"
        Me.rbnombre.UseVisualStyleBackColor = True
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(236, 59)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(409, 20)
        Me.txtbuscar.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(67, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(163, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "INGRESE TODO O PARTE:"
        '
        'F_KARDEX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnsalida)
        Me.Controls.Add(Me.btnentrada)
        Me.Controls.Add(Me.txtsaldo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtsalida)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtentrada)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtmovimiento)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtfecha)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtstock)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtventa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcosto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdetalle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "F_KARDEX"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F_KARDEX"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtdetalle As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtstock As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtventa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcosto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtfecha As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtmovimiento As TextBox
    Friend WithEvents txtsaldo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtsalida As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtentrada As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnentrada As Button
    Friend WithEvents btnsalida As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents rbcodigo As RadioButton
    Friend WithEvents rbnombre As RadioButton
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents Label13 As Label
End Class
