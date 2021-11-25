<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_cad_addUsuarios
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_cad_addUsuarios))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnPesqFunc = New System.Windows.Forms.Button()
        Me.TxtIdFunc = New System.Windows.Forms.TextBox()
        Me.TxtFuncionario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtSenha = New System.Windows.Forms.TextBox()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TxtIdFuncao = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtFuncao = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.TxtIdFuncao)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TxtFuncao)
        Me.GroupBox2.Controls.Add(Me.TxtCod)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.BtnPesqFunc)
        Me.GroupBox2.Controls.Add(Me.TxtIdFunc)
        Me.GroupBox2.Controls.Add(Me.TxtFuncionario)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.TxtSenha)
        Me.GroupBox2.Controls.Add(Me.TxtUsuario)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(544, 177)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'TxtCod
        '
        Me.TxtCod.Enabled = False
        Me.TxtCod.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtCod.ForeColor = System.Drawing.Color.Black
        Me.TxtCod.Location = New System.Drawing.Point(105, 20)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(50, 25)
        Me.TxtCod.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(64, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 19)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Cód:"
        '
        'BtnPesqFunc
        '
        Me.BtnPesqFunc.BackColor = System.Drawing.Color.Transparent
        Me.BtnPesqFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnPesqFunc.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnPesqFunc.FlatAppearance.BorderSize = 0
        Me.BtnPesqFunc.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnPesqFunc.Location = New System.Drawing.Point(496, 54)
        Me.BtnPesqFunc.Name = "BtnPesqFunc"
        Me.BtnPesqFunc.Size = New System.Drawing.Size(26, 27)
        Me.BtnPesqFunc.TabIndex = 68
        Me.BtnPesqFunc.TabStop = False
        Me.BtnPesqFunc.Text = "..."
        Me.BtnPesqFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BtnPesqFunc, "Pesquisar (F5)")
        Me.BtnPesqFunc.UseVisualStyleBackColor = False
        '
        'TxtIdFunc
        '
        Me.TxtIdFunc.Enabled = False
        Me.TxtIdFunc.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtIdFunc.ForeColor = System.Drawing.Color.Black
        Me.TxtIdFunc.Location = New System.Drawing.Point(105, 55)
        Me.TxtIdFunc.Name = "TxtIdFunc"
        Me.TxtIdFunc.Size = New System.Drawing.Size(50, 25)
        Me.TxtIdFunc.TabIndex = 2
        '
        'TxtFuncionario
        '
        Me.TxtFuncionario.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtFuncionario.ForeColor = System.Drawing.Color.Black
        Me.TxtFuncionario.Location = New System.Drawing.Point(159, 55)
        Me.TxtFuncionario.Name = "TxtFuncionario"
        Me.TxtFuncionario.ReadOnly = True
        Me.TxtFuncionario.Size = New System.Drawing.Size(337, 25)
        Me.TxtFuncionario.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(21, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 19)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Funcionário"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label15.Location = New System.Drawing.Point(313, 128)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 19)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Senha:"
        '
        'TxtSenha
        '
        Me.TxtSenha.BackColor = System.Drawing.Color.White
        Me.TxtSenha.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtSenha.ForeColor = System.Drawing.Color.Black
        Me.TxtSenha.Location = New System.Drawing.Point(365, 125)
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtSenha.Size = New System.Drawing.Size(131, 25)
        Me.TxtSenha.TabIndex = 8
        '
        'TxtUsuario
        '
        Me.TxtUsuario.BackColor = System.Drawing.Color.White
        Me.TxtUsuario.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtUsuario.ForeColor = System.Drawing.Color.Black
        Me.TxtUsuario.Location = New System.Drawing.Point(105, 125)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(131, 25)
        Me.TxtUsuario.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(43, 128)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 19)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Usuário:"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.Location = New System.Drawing.Point(66, 8)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(61, 50)
        Me.BtnCancelar.TabIndex = 11
        Me.BtnCancelar.TabStop = False
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.BtnCancelar, "Teclha de Atalho (Esc)")
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackColor = System.Drawing.Color.Transparent
        Me.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.FlatAppearance.BorderSize = 0
        Me.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.Image = CType(resources.GetObject("BtnSalvar.Image"), System.Drawing.Image)
        Me.BtnSalvar.Location = New System.Drawing.Point(3, 8)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(60, 50)
        Me.BtnSalvar.TabIndex = 10
        Me.BtnSalvar.TabStop = False
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.BtnSalvar, "Teclha de Atalho (F3)")
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox6.Controls.Add(Me.BtnCancelar)
        Me.GroupBox6.Controls.Add(Me.BtnSalvar)
        Me.GroupBox6.Location = New System.Drawing.Point(15, 5)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(544, 60)
        Me.GroupBox6.TabIndex = 27
        Me.GroupBox6.TabStop = False
        '
        'TxtIdFuncao
        '
        Me.TxtIdFuncao.Enabled = False
        Me.TxtIdFuncao.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtIdFuncao.ForeColor = System.Drawing.Color.Black
        Me.TxtIdFuncao.Location = New System.Drawing.Point(105, 90)
        Me.TxtIdFuncao.Name = "TxtIdFuncao"
        Me.TxtIdFuncao.Size = New System.Drawing.Size(50, 25)
        Me.TxtIdFuncao.TabIndex = 80
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(48, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 19)
        Me.Label11.TabIndex = 79
        Me.Label11.Text = "Função:"
        '
        'TxtFuncao
        '
        Me.TxtFuncao.BackColor = System.Drawing.Color.White
        Me.TxtFuncao.Enabled = False
        Me.TxtFuncao.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtFuncao.ForeColor = System.Drawing.Color.Black
        Me.TxtFuncao.Location = New System.Drawing.Point(159, 90)
        Me.TxtFuncao.Name = "TxtFuncao"
        Me.TxtFuncao.ReadOnly = True
        Me.TxtFuncao.Size = New System.Drawing.Size(188, 25)
        Me.TxtFuncao.TabIndex = 78
        Me.ToolTip1.SetToolTip(Me.TxtFuncao, "Pesquisar (F5)")
        '
        'Frm_cad_addUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 256)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_cad_addUsuarios"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro Usuários"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtSenha As TextBox
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents BtnPesqFunc As Button
    Friend WithEvents TxtIdFunc As TextBox
    Friend WithEvents TxtFuncionario As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents TxtCod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtIdFuncao As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtFuncao As TextBox
End Class
