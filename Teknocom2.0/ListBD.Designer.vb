<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListBD
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
        Me.DGVEmpresas = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBInstancia = New System.Windows.Forms.TextBox()
        Me.TBIdUser = New System.Windows.Forms.TextBox()
        Me.TBPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTNConectarDB = New System.Windows.Forms.Button()
        CType(Me.DGVEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVEmpresas
        '
        Me.DGVEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEmpresas.Location = New System.Drawing.Point(367, 12)
        Me.DGVEmpresas.Name = "DGVEmpresas"
        Me.DGVEmpresas.RowHeadersWidth = 51
        Me.DGVEmpresas.RowTemplate.Height = 24
        Me.DGVEmpresas.Size = New System.Drawing.Size(421, 426)
        Me.DGVEmpresas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Instancia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "IdUser"
        '
        'TBInstancia
        '
        Me.TBInstancia.Location = New System.Drawing.Point(12, 95)
        Me.TBInstancia.Name = "TBInstancia"
        Me.TBInstancia.Size = New System.Drawing.Size(328, 22)
        Me.TBInstancia.TabIndex = 3
        '
        'TBIdUser
        '
        Me.TBIdUser.Location = New System.Drawing.Point(12, 139)
        Me.TBIdUser.Name = "TBIdUser"
        Me.TBIdUser.Size = New System.Drawing.Size(328, 22)
        Me.TBIdUser.TabIndex = 4
        '
        'TBPassword
        '
        Me.TBPassword.Location = New System.Drawing.Point(11, 183)
        Me.TBPassword.Name = "TBPassword"
        Me.TBPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBPassword.Size = New System.Drawing.Size(329, 22)
        Me.TBPassword.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password"
        '
        'BTNConectarDB
        '
        Me.BTNConectarDB.Location = New System.Drawing.Point(189, 415)
        Me.BTNConectarDB.Name = "BTNConectarDB"
        Me.BTNConectarDB.Size = New System.Drawing.Size(151, 23)
        Me.BTNConectarDB.TabIndex = 7
        Me.BTNConectarDB.Text = "Conectar"
        Me.BTNConectarDB.UseVisualStyleBackColor = True
        '
        'ListBD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTNConectarDB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBPassword)
        Me.Controls.Add(Me.TBIdUser)
        Me.Controls.Add(Me.TBInstancia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVEmpresas)
        Me.Name = "ListBD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empresas"
        CType(Me.DGVEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVEmpresas As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TBInstancia As TextBox
    Friend WithEvents TBIdUser As TextBox
    Friend WithEvents TBPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BTNConectarDB As Button
End Class
