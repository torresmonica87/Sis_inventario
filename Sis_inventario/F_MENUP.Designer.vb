<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_MENUP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_MENUP))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.USUARIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRODUCTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROVEEDORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LBNICK = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LBDETALLE = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LBTIPO = New System.Windows.Forms.ToolStripStatusLabel()
        Me.REGISTRODEPRODUCTIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOVIMIENTODEPRODUCTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.USUARIOSToolStripMenuItem, Me.PRODUCTOSToolStripMenuItem, Me.CLIENTESToolStripMenuItem, Me.PROVEEDORESToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(844, 56)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'USUARIOSToolStripMenuItem
        '
        Me.USUARIOSToolStripMenuItem.Image = CType(resources.GetObject("USUARIOSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.USUARIOSToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.USUARIOSToolStripMenuItem.Name = "USUARIOSToolStripMenuItem"
        Me.USUARIOSToolStripMenuItem.Size = New System.Drawing.Size(122, 52)
        Me.USUARIOSToolStripMenuItem.Text = "USUARIOS"
        '
        'PRODUCTOSToolStripMenuItem
        '
        Me.PRODUCTOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REGISTRODEPRODUCTIOSToolStripMenuItem, Me.MOVIMIENTODEPRODUCTOSToolStripMenuItem})
        Me.PRODUCTOSToolStripMenuItem.Name = "PRODUCTOSToolStripMenuItem"
        Me.PRODUCTOSToolStripMenuItem.Size = New System.Drawing.Size(87, 52)
        Me.PRODUCTOSToolStripMenuItem.Text = "PRODUCTOS"
        '
        'CLIENTESToolStripMenuItem
        '
        Me.CLIENTESToolStripMenuItem.Name = "CLIENTESToolStripMenuItem"
        Me.CLIENTESToolStripMenuItem.Size = New System.Drawing.Size(70, 52)
        Me.CLIENTESToolStripMenuItem.Text = "CLIENTES"
        '
        'PROVEEDORESToolStripMenuItem
        '
        Me.PROVEEDORESToolStripMenuItem.Name = "PROVEEDORESToolStripMenuItem"
        Me.PROVEEDORESToolStripMenuItem.Size = New System.Drawing.Size(97, 52)
        Me.PROVEEDORESToolStripMenuItem.Text = "PROVEEDORES"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Image = CType(resources.GetObject("SALIRToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SALIRToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(97, 52)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.LBNICK, Me.LBDETALLE, Me.LBTIPO})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 402)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(844, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(59, 17)
        Me.ToolStripStatusLabel1.Text = "USUARIO:"
        '
        'LBNICK
        '
        Me.LBNICK.Name = "LBNICK"
        Me.LBNICK.Size = New System.Drawing.Size(12, 17)
        Me.LBNICK.Text = "-"
        '
        'LBDETALLE
        '
        Me.LBDETALLE.Name = "LBDETALLE"
        Me.LBDETALLE.Size = New System.Drawing.Size(12, 17)
        Me.LBDETALLE.Text = "-"
        '
        'LBTIPO
        '
        Me.LBTIPO.Name = "LBTIPO"
        Me.LBTIPO.Size = New System.Drawing.Size(12, 17)
        Me.LBTIPO.Text = "-"
        '
        'REGISTRODEPRODUCTIOSToolStripMenuItem
        '
        Me.REGISTRODEPRODUCTIOSToolStripMenuItem.Name = "REGISTRODEPRODUCTIOSToolStripMenuItem"
        Me.REGISTRODEPRODUCTIOSToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.REGISTRODEPRODUCTIOSToolStripMenuItem.Text = "REGISTRO DE PRODUCTOS"
        '
        'MOVIMIENTODEPRODUCTOSToolStripMenuItem
        '
        Me.MOVIMIENTODEPRODUCTOSToolStripMenuItem.Name = "MOVIMIENTODEPRODUCTOSToolStripMenuItem"
        Me.MOVIMIENTODEPRODUCTOSToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.MOVIMIENTODEPRODUCTOSToolStripMenuItem.Text = "MOVIMIENTO DE PRODUCTOS"
        '
        'F_MENUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(844, 424)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "F_MENUP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONTROL DE INVENTARIO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents USUARIOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRODUCTOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CLIENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PROVEEDORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents LBNICK As ToolStripStatusLabel
    Friend WithEvents LBDETALLE As ToolStripStatusLabel
    Friend WithEvents LBTIPO As ToolStripStatusLabel
    Friend WithEvents REGISTRODEPRODUCTIOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MOVIMIENTODEPRODUCTOSToolStripMenuItem As ToolStripMenuItem
End Class
