<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonasDesconectado
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grdPersonasDescanectadas = New System.Windows.Forms.DataGridView()
        Me.btnGuardar = New System.Windows.Forms.Button()
        CType(Me.grdPersonasDescanectadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdPersonasDescanectadas
        '
        Me.grdPersonasDescanectadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdPersonasDescanectadas.Location = New System.Drawing.Point(106, 59)
        Me.grdPersonasDescanectadas.Name = "grdPersonasDescanectadas"
        Me.grdPersonasDescanectadas.Size = New System.Drawing.Size(354, 150)
        Me.grdPersonasDescanectadas.TabIndex = 0
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(246, 245)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Save"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'PersonasDesconectado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 430)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.grdPersonasDescanectadas)
        Me.Name = "PersonasDesconectado"
        Me.Text = "PersonasDesconectado"
        CType(Me.grdPersonasDescanectadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdPersonasDescanectadas As DataGridView
    Friend WithEvents btnGuardar As Button
End Class
