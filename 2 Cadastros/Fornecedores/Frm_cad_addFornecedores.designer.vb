﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_cad_addFornecedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_cad_addFornecedores))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RbInativo = New System.Windows.Forms.RadioButton()
        Me.RbAtivo = New System.Windows.Forms.RadioButton()
        Me.TxtTel = New System.Windows.Forms.MaskedTextBox()
        Me.TxtCep = New System.Windows.Forms.MaskedTextBox()
        Me.TxtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.TxtCnpj = New System.Windows.Forms.MaskedTextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RbPessoaJuridica = New System.Windows.Forms.RadioButton()
        Me.RbPessoaFisica = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtEstado = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtCidade = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtBairro = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtComp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtEndereco = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.BtnCancelar)
        Me.GroupBox3.Controls.Add(Me.BtnSalvar)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(614, 60)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.TxtTel)
        Me.GroupBox1.Controls.Add(Me.TxtCep)
        Me.GroupBox1.Controls.Add(Me.TxtCpf)
        Me.GroupBox1.Controls.Add(Me.TxtCnpj)
        Me.GroupBox1.Controls.Add(Me.TxtEmail)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.RbPessoaJuridica)
        Me.GroupBox1.Controls.Add(Me.RbPessoaFisica)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TxtEstado)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxtCidade)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtBairro)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtComp)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtNum)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtEndereco)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtNome)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtCod)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(614, 324)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RbInativo)
        Me.Panel1.Controls.Add(Me.RbAtivo)
        Me.Panel1.Location = New System.Drawing.Point(427, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(164, 35)
        Me.Panel1.TabIndex = 13
        '
        'RbInativo
        '
        Me.RbInativo.AutoSize = True
        Me.RbInativo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RbInativo.Location = New System.Drawing.Point(86, 5)
        Me.RbInativo.Name = "RbInativo"
        Me.RbInativo.Size = New System.Drawing.Size(69, 23)
        Me.RbInativo.TabIndex = 29
        Me.RbInativo.Text = "Inativo"
        Me.RbInativo.UseVisualStyleBackColor = True
        '
        'RbAtivo
        '
        Me.RbAtivo.AutoSize = True
        Me.RbAtivo.Checked = True
        Me.RbAtivo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RbAtivo.Location = New System.Drawing.Point(5, 5)
        Me.RbAtivo.Name = "RbAtivo"
        Me.RbAtivo.Size = New System.Drawing.Size(59, 23)
        Me.RbAtivo.TabIndex = 28
        Me.RbAtivo.TabStop = True
        Me.RbAtivo.Text = "Ativo"
        Me.RbAtivo.UseVisualStyleBackColor = True
        '
        'TxtTel
        '
        Me.TxtTel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtTel.Location = New System.Drawing.Point(90, 270)
        Me.TxtTel.Mask = "(00)00000-0000"
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(110, 25)
        Me.TxtTel.TabIndex = 15
        '
        'TxtCep
        '
        Me.TxtCep.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtCep.Location = New System.Drawing.Point(90, 130)
        Me.TxtCep.Mask = "00000-000"
        Me.TxtCep.Name = "TxtCep"
        Me.TxtCep.Size = New System.Drawing.Size(110, 25)
        Me.TxtCep.TabIndex = 8
        '
        'TxtCpf
        '
        Me.TxtCpf.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtCpf.Location = New System.Drawing.Point(90, 95)
        Me.TxtCpf.Mask = "000,000,000-00"
        Me.TxtCpf.Name = "TxtCpf"
        Me.TxtCpf.Size = New System.Drawing.Size(110, 25)
        Me.TxtCpf.TabIndex = 6
        '
        'TxtCnpj
        '
        Me.TxtCnpj.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtCnpj.Location = New System.Drawing.Point(265, 95)
        Me.TxtCnpj.Mask = "00,000,000,0000/00"
        Me.TxtCnpj.Name = "TxtCnpj"
        Me.TxtCnpj.Size = New System.Drawing.Size(130, 25)
        Me.TxtCnpj.TabIndex = 7
        '
        'TxtEmail
        '
        Me.TxtEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtEmail.ForeColor = System.Drawing.Color.Black
        Me.TxtEmail.Location = New System.Drawing.Point(265, 270)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(326, 25)
        Me.TxtEmail.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(216, 274)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 19)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Email:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(24, 273)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 19)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Telefone:"
        '
        'RbPessoaJuridica
        '
        Me.RbPessoaJuridica.AutoSize = True
        Me.RbPessoaJuridica.Checked = True
        Me.RbPessoaJuridica.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RbPessoaJuridica.Location = New System.Drawing.Point(231, 25)
        Me.RbPessoaJuridica.Name = "RbPessoaJuridica"
        Me.RbPessoaJuridica.Size = New System.Drawing.Size(117, 23)
        Me.RbPessoaJuridica.TabIndex = 3
        Me.RbPessoaJuridica.TabStop = True
        Me.RbPessoaJuridica.Text = "Pessoa Jurídica"
        Me.RbPessoaJuridica.UseVisualStyleBackColor = True
        '
        'RbPessoaFisica
        '
        Me.RbPessoaFisica.AutoSize = True
        Me.RbPessoaFisica.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RbPessoaFisica.Location = New System.Drawing.Point(369, 25)
        Me.RbPessoaFisica.Name = "RbPessoaFisica"
        Me.RbPessoaFisica.Size = New System.Drawing.Size(104, 23)
        Me.RbPessoaFisica.TabIndex = 2
        Me.RbPessoaFisica.Text = "Pessoa Física"
        Me.RbPessoaFisica.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(218, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 19)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "CNPJ:"
        '
        'TxtEstado
        '
        Me.TxtEstado.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtEstado.ForeColor = System.Drawing.Color.Black
        Me.TxtEstado.Location = New System.Drawing.Point(513, 200)
        Me.TxtEstado.Name = "TxtEstado"
        Me.TxtEstado.Size = New System.Drawing.Size(77, 25)
        Me.TxtEstado.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(456, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 19)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Estado:"
        '
        'TxtCidade
        '
        Me.TxtCidade.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtCidade.ForeColor = System.Drawing.Color.Black
        Me.TxtCidade.Location = New System.Drawing.Point(336, 235)
        Me.TxtCidade.Name = "TxtCidade"
        Me.TxtCidade.Size = New System.Drawing.Size(254, 25)
        Me.TxtCidade.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(278, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 19)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Cidade:"
        '
        'TxtBairro
        '
        Me.TxtBairro.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtBairro.ForeColor = System.Drawing.Color.Black
        Me.TxtBairro.Location = New System.Drawing.Point(90, 235)
        Me.TxtBairro.Name = "TxtBairro"
        Me.TxtBairro.Size = New System.Drawing.Size(176, 25)
        Me.TxtBairro.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(38, 238)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 19)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Bairro:"
        '
        'TxtComp
        '
        Me.TxtComp.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtComp.ForeColor = System.Drawing.Color.Black
        Me.TxtComp.Location = New System.Drawing.Point(231, 200)
        Me.TxtComp.Name = "TxtComp"
        Me.TxtComp.Size = New System.Drawing.Size(211, 25)
        Me.TxtComp.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(179, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 19)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Comp:"
        '
        'TxtNum
        '
        Me.TxtNum.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtNum.ForeColor = System.Drawing.Color.Black
        Me.TxtNum.Location = New System.Drawing.Point(90, 200)
        Me.TxtNum.Name = "TxtNum"
        Me.TxtNum.Size = New System.Drawing.Size(76, 25)
        Me.TxtNum.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(58, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Nº:"
        '
        'TxtEndereco
        '
        Me.TxtEndereco.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtEndereco.ForeColor = System.Drawing.Color.Black
        Me.TxtEndereco.Location = New System.Drawing.Point(90, 165)
        Me.TxtEndereco.Name = "TxtEndereco"
        Me.TxtEndereco.Size = New System.Drawing.Size(500, 25)
        Me.TxtEndereco.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(18, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Endereço:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(50, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "CEP:"
        '
        'TxtNome
        '
        Me.TxtNome.BackColor = System.Drawing.Color.White
        Me.TxtNome.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtNome.ForeColor = System.Drawing.Color.Black
        Me.TxtNome.Location = New System.Drawing.Point(90, 60)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(500, 25)
        Me.TxtNome.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(37, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(50, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CPF:"
        '
        'TxtCod
        '
        Me.TxtCod.Enabled = False
        Me.TxtCod.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtCod.ForeColor = System.Drawing.Color.Black
        Me.TxtCod.Location = New System.Drawing.Point(90, 25)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(110, 25)
        Me.TxtCod.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(30, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'Frm_cad_addFornecedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 401)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "Frm_cad_addFornecedores"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dados do Fornecedor"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RbInativo As RadioButton
    Friend WithEvents RbAtivo As RadioButton
    Friend WithEvents TxtTel As MaskedTextBox
    Friend WithEvents TxtCep As MaskedTextBox
    Friend WithEvents TxtCpf As MaskedTextBox
    Friend WithEvents TxtCnpj As MaskedTextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents RbPessoaJuridica As RadioButton
    Friend WithEvents RbPessoaFisica As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtEstado As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtCidade As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtBairro As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtComp As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtNum As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtEndereco As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
