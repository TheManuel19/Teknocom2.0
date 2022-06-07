<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormatosDeInfo
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.CBTextoPlano = New System.Windows.Forms.CheckBox()
        Me.CBExcel = New System.Windows.Forms.CheckBox()
        Me.CBXml = New System.Windows.Forms.CheckBox()
        Me.CBManual = New System.Windows.Forms.CheckBox()
        Me.CBBd = New System.Windows.Forms.CheckBox()
        Me.OFDArchivosDeDatos = New System.Windows.Forms.OpenFileDialog()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.CBBd)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CBManual)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CBXml)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CBExcel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CBTextoPlano)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 450)
        Me.SplitContainer1.SplitterDistance = 179
        Me.SplitContainer1.TabIndex = 0
        '
        'CBTextoPlano
        '
        Me.CBTextoPlano.AutoSize = True
        Me.CBTextoPlano.Location = New System.Drawing.Point(43, 31)
        Me.CBTextoPlano.Name = "CBTextoPlano"
        Me.CBTextoPlano.Size = New System.Drawing.Size(138, 20)
        Me.CBTextoPlano.TabIndex = 0
        Me.CBTextoPlano.Text = "Texto Plano (TXT)"
        Me.CBTextoPlano.UseVisualStyleBackColor = True
        '
        'CBExcel
        '
        Me.CBExcel.AutoSize = True
        Me.CBExcel.Location = New System.Drawing.Point(43, 68)
        Me.CBExcel.Name = "CBExcel"
        Me.CBExcel.Size = New System.Drawing.Size(62, 20)
        Me.CBExcel.TabIndex = 1
        Me.CBExcel.Text = "Excel"
        Me.CBExcel.UseVisualStyleBackColor = True
        '
        'CBXml
        '
        Me.CBXml.AutoSize = True
        Me.CBXml.Location = New System.Drawing.Point(43, 108)
        Me.CBXml.Name = "CBXml"
        Me.CBXml.Size = New System.Drawing.Size(55, 20)
        Me.CBXml.TabIndex = 2
        Me.CBXml.Text = "XML"
        Me.CBXml.UseVisualStyleBackColor = True
        '
        'CBManual
        '
        Me.CBManual.AutoSize = True
        Me.CBManual.Location = New System.Drawing.Point(43, 179)
        Me.CBManual.Name = "CBManual"
        Me.CBManual.Size = New System.Drawing.Size(123, 20)
        Me.CBManual.TabIndex = 3
        Me.CBManual.Text = "Entrada Manual"
        Me.CBManual.UseVisualStyleBackColor = True
        '
        'CBBd
        '
        Me.CBBd.AutoSize = True
        Me.CBBd.Location = New System.Drawing.Point(43, 144)
        Me.CBBd.Name = "CBBd"
        Me.CBBd.Size = New System.Drawing.Size(117, 20)
        Me.CBBd.TabIndex = 4
        Me.CBBd.Text = "Base de datos"
        Me.CBBd.UseVisualStyleBackColor = True
        '
        'OFDArchivosDeDatos
        '
        Me.OFDArchivosDeDatos.FileName = "OpenFileDialog1"
        '
        'FormatosDeInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FormatosDeInfo"
        Me.Text = "FormatosDeInfo"
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents CBManual As CheckBox
    Friend WithEvents CBXml As CheckBox
    Friend WithEvents CBExcel As CheckBox
    Friend WithEvents CBTextoPlano As CheckBox
    Friend WithEvents CBBd As CheckBox
    Friend WithEvents OFDArchivosDeDatos As OpenFileDialog
End Class
