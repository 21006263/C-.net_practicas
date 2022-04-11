<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frEmpleado
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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.NumericUpDown()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.lnkFoto = New System.Windows.Forms.LinkLabel()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnNombre = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.openFoto = New System.Windows.Forms.OpenFileDialog()
        Me.gridDatos = New System.Windows.Forms.DataGridView()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(111, 73)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(195, 23)
        Me.txtNombre.TabIndex = 0
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(111, 117)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(195, 23)
        Me.txtApellido.TabIndex = 1
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(111, 29)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(64, 23)
        Me.txtId.TabIndex = 2
        '
        'picFoto
        '
        Me.picFoto.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.picFoto.Location = New System.Drawing.Point(111, 156)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(95, 79)
        Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFoto.TabIndex = 3
        Me.picFoto.TabStop = False
        '
        'lnkFoto
        '
        Me.lnkFoto.AutoSize = True
        Me.lnkFoto.Location = New System.Drawing.Point(111, 238)
        Me.lnkFoto.Name = "lnkFoto"
        Me.lnkFoto.Size = New System.Drawing.Size(67, 15)
        Me.lnkFoto.TabIndex = 4
        Me.lnkFoto.TabStop = True
        Me.lnkFoto.Text = "Seleccionar"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(88, 31)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(17, 15)
        Me.Label.TabIndex = 5
        Me.Label.Text = "Id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Foto"
        '
        'btnNombre
        '
        Me.btnNombre.Location = New System.Drawing.Point(24, 301)
        Me.btnNombre.Name = "btnNombre"
        Me.btnNombre.Size = New System.Drawing.Size(61, 20)
        Me.btnNombre.TabIndex = 9
        Me.btnNombre.Text = "Nuevo"
        Me.btnNombre.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(156, 301)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(61, 20)
        Me.btnEliminar.TabIndex = 10
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(223, 301)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(61, 20)
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'gridDatos
        '
        Me.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridDatos.Location = New System.Drawing.Point(355, 32)
        Me.gridDatos.Name = "gridDatos"
        Me.gridDatos.RowTemplate.Height = 25
        Me.gridDatos.Size = New System.Drawing.Size(349, 220)
        Me.gridDatos.TabIndex = 12
        '
        'frEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 334)
        Me.Controls.Add(Me.gridDatos)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.lnkFoto)
        Me.Controls.Add(Me.picFoto)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "frEmpleado"
        Me.Text = "Form1"
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtId As NumericUpDown
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents lnkFoto As LinkLabel
    Friend WithEvents Label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnNombre As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents openFoto As OpenFileDialog
    Friend WithEvents gridDatos As DataGridView
End Class
