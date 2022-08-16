<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrypto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrypto))
        Me.txtChave = New System.Windows.Forms.TextBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.txtConteudo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCriptografar = New System.Windows.Forms.Button()
        Me.btnDescriptografar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'txtChave
        '
        Me.txtChave.Location = New System.Drawing.Point(12, 148)
        Me.txtChave.Name = "txtChave"
        Me.txtChave.Size = New System.Drawing.Size(402, 20)
        Me.txtChave.TabIndex = 0
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(12, 252)
        Me.txtResultado.Multiline = True
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(402, 93)
        Me.txtResultado.TabIndex = 1
        '
        'txtConteudo
        '
        Me.txtConteudo.Location = New System.Drawing.Point(12, 21)
        Me.txtConteudo.Multiline = True
        Me.txtConteudo.Name = "txtConteudo"
        Me.txtConteudo.Size = New System.Drawing.Size(402, 93)
        Me.txtConteudo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Conteúdo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Chave:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Resultado:"
        '
        'btnCriptografar
        '
        Me.btnCriptografar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCriptografar.FlatAppearance.BorderSize = 0
        Me.btnCriptografar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCriptografar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnCriptografar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCriptografar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCriptografar.ForeColor = System.Drawing.Color.White
        Me.btnCriptografar.Location = New System.Drawing.Point(12, 180)
        Me.btnCriptografar.Name = "btnCriptografar"
        Me.btnCriptografar.Size = New System.Drawing.Size(195, 44)
        Me.btnCriptografar.TabIndex = 6
        Me.btnCriptografar.Text = "&Criptografar"
        Me.btnCriptografar.UseVisualStyleBackColor = False
        '
        'btnDescriptografar
        '
        Me.btnDescriptografar.BackColor = System.Drawing.Color.Salmon
        Me.btnDescriptografar.FlatAppearance.BorderSize = 0
        Me.btnDescriptografar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon
        Me.btnDescriptografar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnDescriptografar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDescriptografar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescriptografar.ForeColor = System.Drawing.Color.White
        Me.btnDescriptografar.Location = New System.Drawing.Point(219, 180)
        Me.btnDescriptografar.Name = "btnDescriptografar"
        Me.btnDescriptografar.Size = New System.Drawing.Size(195, 44)
        Me.btnDescriptografar.TabIndex = 7
        Me.btnDescriptografar.Text = "&Descriptografar"
        Me.btnDescriptografar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Location = New System.Drawing.Point(12, 180)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 44)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.IndianRed
        Me.Panel2.Location = New System.Drawing.Point(219, 180)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 44)
        Me.Panel2.TabIndex = 9
        '
        'frmCrypto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(425, 362)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnDescriptografar)
        Me.Controls.Add(Me.btnCriptografar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtConteudo)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.txtChave)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(441, 401)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(441, 401)
        Me.Name = "frmCrypto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crypto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtChave As TextBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents txtConteudo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCriptografar As Button
    Friend WithEvents btnDescriptografar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
