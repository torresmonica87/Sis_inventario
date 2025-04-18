<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtuser = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtpass = New System.Windows.Forms.TextBox()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(31, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USUARIO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 1
        '
        'Txtuser
        '
        Me.Txtuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtuser.Location = New System.Drawing.Point(31, 195)
        Me.Txtuser.Name = "Txtuser"
        Me.Txtuser.Size = New System.Drawing.Size(201, 26)
        Me.Txtuser.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.Location = New System.Drawing.Point(31, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CONTRASEÑA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Txtpass
        '
        Me.Txtpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtpass.Location = New System.Drawing.Point(31, 283)
        Me.Txtpass.Name = "Txtpass"
        Me.Txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtpass.Size = New System.Drawing.Size(201, 26)
        Me.Txtpass.TabIndex = 4
        '
        'btningresar
        '
        Me.btningresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btningresar.Location = New System.Drawing.Point(57, 331)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(157, 23)
        Me.btningresar.TabIndex = 5
        Me.btningresar.Text = "INGRESAR"
        Me.btningresar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.Location = New System.Drawing.Point(57, 371)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(157, 23)
        Me.btnsalir.TabIndex = 6
        Me.btnsalir.Text = "SALIR DEL SISTEMA"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(75, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(285, 406)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btningresar)
        Me.Controls.Add(Me.Txtpass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txtuser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BIENVENIDO AL SISTEMA"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtuser As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txtpass As TextBox
    Friend WithEvents btningresar As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    'aqui es cuando hago doble click en form de bienvenida
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion()
    End Sub

    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        If Txtuser.Text = "" Or Txtpass.Text = "" Then
            MsgBox("LOS DATOS NO ESTÁN COMPLETOS!")
        Else
            consultas("SELECT * FROM usuarios where nick_usuario= '" + Trim(Txtuser.Text) + "'and clave_usuario='" + Trim(Eramake.eCryptography.Encrypt(Txtpass.Text)) + "'", "usuarios")
            da.Fill(ds, "usuarios")
            Dim fila1 As Integer
            fila1 = ds.Tables("usuarios").Rows.Count
            If fila1 = 0 Then
                MsgBox("LAS CREDENCIALES NO SON CORRECTAS!")
                Txtuser.Text = ""
                Txtpass.Text = ""
                Txtuser.Focus()
            Else
                'debo crear un nuevo formulario para poder dar ingreso al sistema en caso de que todos los datos esten correctos
                Me.Hide()
                F_MENUP.Show()
            End If
        End If
    End Sub
End Class
