<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.value1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.value2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.value3 = New System.Windows.Forms.Label()
        Me.Jogar = New System.Windows.Forms.Button()
        Me.Sair = New System.Windows.Forms.Button()
        Me.ImageResultado = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ImageResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.value1)
        Me.Panel1.Location = New System.Drawing.Point(146, 114)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(100, 100)
        Me.Panel1.TabIndex = 1
        '
        'value1
        '
        Me.value1.AutoSize = True
        Me.value1.Font = New System.Drawing.Font("Segoe Fluent Icons", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.value1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.value1.Location = New System.Drawing.Point(28, 23)
        Me.value1.Name = "value1"
        Me.value1.Size = New System.Drawing.Size(35, 40)
        Me.value1.TabIndex = 0
        Me.value1.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.value2)
        Me.Panel2.Location = New System.Drawing.Point(339, 114)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(100, 100)
        Me.Panel2.TabIndex = 2
        '
        'value2
        '
        Me.value2.AutoSize = True
        Me.value2.Font = New System.Drawing.Font("Segoe Fluent Icons", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.value2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.value2.Location = New System.Drawing.Point(24, 23)
        Me.value2.Name = "value2"
        Me.value2.Size = New System.Drawing.Size(35, 40)
        Me.value2.TabIndex = 4
        Me.value2.Text = "0"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.value3)
        Me.Panel3.Location = New System.Drawing.Point(541, 114)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(100, 100)
        Me.Panel3.TabIndex = 3
        '
        'value3
        '
        Me.value3.AutoSize = True
        Me.value3.Font = New System.Drawing.Font("Segoe Fluent Icons", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.value3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.value3.Location = New System.Drawing.Point(28, 23)
        Me.value3.Name = "value3"
        Me.value3.Size = New System.Drawing.Size(35, 40)
        Me.value3.TabIndex = 4
        Me.value3.Text = "0"
        '
        'Jogar
        '
        Me.Jogar.BackColor = System.Drawing.Color.Green
        Me.Jogar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Jogar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Jogar.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jogar.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Jogar.Location = New System.Drawing.Point(43, 392)
        Me.Jogar.Name = "Jogar"
        Me.Jogar.Size = New System.Drawing.Size(100, 50)
        Me.Jogar.TabIndex = 4
        Me.Jogar.Text = "JOGAR"
        Me.Jogar.UseVisualStyleBackColor = False
        '
        'Sair
        '
        Me.Sair.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Sair.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sair.ForeColor = System.Drawing.Color.White
        Me.Sair.Location = New System.Drawing.Point(684, 392)
        Me.Sair.Name = "Sair"
        Me.Sair.Size = New System.Drawing.Size(100, 50)
        Me.Sair.TabIndex = 5
        Me.Sair.Text = "SAIR"
        Me.Sair.UseVisualStyleBackColor = False
        '
        'ImageResultado
        '
        Me.ImageResultado.Location = New System.Drawing.Point(204, 250)
        Me.ImageResultado.Name = "ImageResultado"
        Me.ImageResultado.Size = New System.Drawing.Size(371, 165)
        Me.ImageResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImageResultado.TabIndex = 6
        Me.ImageResultado.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(288, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 37)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Jogo 7 da Sorte"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 455)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ImageResultado)
        Me.Controls.Add(Me.Sair)
        Me.Controls.Add(Me.Jogar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ImageResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents value1 As Label
    Friend WithEvents value2 As Label
    Friend WithEvents value3 As Label
    Friend WithEvents Jogar As Button
    Friend WithEvents Sair As Button
    Friend WithEvents ImageResultado As PictureBox
    Friend WithEvents Label2 As Label
End Class
