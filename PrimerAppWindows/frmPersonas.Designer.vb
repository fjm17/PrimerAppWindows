<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPersonas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.grdDatosPersonas = New System.Windows.Forms.DataGridView()
        CType(Me.grdDatosPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(39, 65)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Location = New System.Drawing.Point(39, 104)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(49, 13)
        Me.lblApellidos.TabIndex = 1
        Me.lblApellidos.Text = "Apellidos"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Location = New System.Drawing.Point(39, 33)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(40, 13)
        Me.lblCedula.TabIndex = 2
        Me.lblCedula.Text = "Cedula"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(96, 62)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 2
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(96, 101)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(100, 20)
        Me.txtApellidos.TabIndex = 3
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(96, 26)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(100, 20)
        Me.txtCedula.TabIndex = 1
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(96, 140)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'grdDatosPersonas
        '
        Me.grdDatosPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDatosPersonas.Location = New System.Drawing.Point(12, 192)
        Me.grdDatosPersonas.Name = "grdDatosPersonas"
        Me.grdDatosPersonas.Size = New System.Drawing.Size(240, 150)
        Me.grdDatosPersonas.TabIndex = 9
        '
        'frmPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 404)
        Me.Controls.Add(Me.grdDatosPersonas)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.lblApellidos)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "frmPersonas"
        Me.Text = "Datos Personales"
        CType(Me.grdDatosPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents grdDatosPersonas As DataGridView
End Class
