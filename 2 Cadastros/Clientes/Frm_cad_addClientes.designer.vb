<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_cad_addClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_cad_addClientes))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtLimiteCredito = New System.Windows.Forms.TextBox()
        Me.RbLimiteDiff = New System.Windows.Forms.RadioButton()
        Me.RbSemDebito = New System.Windows.Forms.RadioButton()
        Me.RbLimitePadrao = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RbInativo = New System.Windows.Forms.RadioButton()
        Me.RbAtivo = New System.Windows.Forms.RadioButton()
        Me.TxtSexo = New System.Windows.Forms.ComboBox()
        Me.Lblsexo = New System.Windows.Forms.Label()
        Me.TxtTel = New System.Windows.Forms.MaskedTextBox()
        Me.TxtCep = New System.Windows.Forms.MaskedTextBox()
        Me.TxtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.TxtCnpj = New System.Windows.Forms.MaskedTextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RbPessoaJuridica = New System.Windows.Forms.RadioButton()
        Me.RbPessoaFisica = New System.Windows.Forms.RadioButton()
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
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.TxtLimiteCredito)
        Me.GroupBox4.Controls.Add(Me.RbLimiteDiff)
        Me.GroupBox4.Controls.Add(Me.RbSemDebito)
        Me.GroupBox4.Controls.Add(Me.RbLimitePadrao)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(21, 359)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(610, 120)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Valor Limite Débitos"
        '
        'TxtLimiteCredito
        '
        Me.TxtLimiteCredito.BackColor = System.Drawing.Color.White
        Me.TxtLimiteCredito.Enabled = False
        Me.TxtLimiteCredito.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtLimiteCredito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtLimiteCredito.Location = New System.Drawing.Point(320, 80)
        Me.TxtLimiteCredito.Name = "TxtLimiteCredito"
        Me.TxtLimiteCredito.Size = New System.Drawing.Size(110, 25)
        Me.TxtLimiteCredito.TabIndex = 31
        '
        'RbLimiteDiff
        '
        Me.RbLimiteDiff.AutoSize = True
        Me.RbLimiteDiff.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RbLimiteDiff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.RbLimiteDiff.Location = New System.Drawing.Point(19, 82)
        Me.RbLimiteDiff.Name = "RbLimiteDiff"
        Me.RbLimiteDiff.Size = New System.Drawing.Size(291, 21)
        Me.RbLimiteDiff.TabIndex = 30
        Me.RbLimiteDiff.Text = "3. Esse cliente possui um limite diferenciado"
        Me.RbLimiteDiff.UseVisualStyleBackColor = True
        '
        'RbSemDebito
        '
        Me.RbSemDebito.AutoSize = True
        Me.RbSemDebito.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RbSemDebito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.RbSemDebito.Location = New System.Drawing.Point(19, 53)
        Me.RbSemDebito.Name = "RbSemDebito"
        Me.RbSemDebito.Size = New System.Drawing.Size(270, 21)
        Me.RbSemDebito.TabIndex = 29
        Me.RbSemDebito.Text = "2. Não permitir débitos para esse cliente"
        Me.RbSemDebito.UseVisualStyleBackColor = True
        '
        'RbLimitePadrao
        '
        Me.RbLimitePadrao.AutoSize = True
        Me.RbLimitePadrao.Checked = True
        Me.RbLimitePadrao.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RbLimitePadrao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.RbLimitePadrao.Location = New System.Drawing.Point(19, 25)
        Me.RbLimitePadrao.Name = "RbLimitePadrao"
        Me.RbLimitePadrao.Size = New System.Drawing.Size(163, 21)
        Me.RbLimitePadrao.TabIndex = 28
        Me.RbLimitePadrao.TabStop = True
        Me.RbLimitePadrao.Text = "1. Seguir Limite Padrão"
        Me.RbLimitePadrao.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.TxtSexo)
        Me.GroupBox1.Controls.Add(Me.Lblsexo)
        Me.GroupBox1.Controls.Add(Me.TxtTel)
        Me.GroupBox1.Controls.Add(Me.TxtCep)
        Me.GroupBox1.Controls.Add(Me.TxtCpf)
        Me.GroupBox1.Controls.Add(Me.TxtCnpj)
        Me.GroupBox1.Controls.Add(Me.TxtEmail)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.RbPessoaJuridica)
        Me.GroupBox1.Controls.Add(Me.RbPessoaFisica)
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
        Me.GroupBox1.Location = New System.Drawing.Point(21, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(610, 317)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(19, 57)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(15, 15)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "*"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RbInativo)
        Me.Panel1.Controls.Add(Me.RbAtivo)
        Me.Panel1.Location = New System.Drawing.Point(428, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(156, 35)
        Me.Panel1.TabIndex = 28
        '
        'RbInativo
        '
        Me.RbInativo.AutoSize = True
        Me.RbInativo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RbInativo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.RbInativo.Location = New System.Drawing.Point(82, 6)
        Me.RbInativo.Name = "RbInativo"
        Me.RbInativo.Size = New System.Drawing.Size(68, 21)
        Me.RbInativo.TabIndex = 9
        Me.RbInativo.Text = "Inativo"
        Me.RbInativo.UseVisualStyleBackColor = True
        '
        'RbAtivo
        '
        Me.RbAtivo.AutoSize = True
        Me.RbAtivo.Checked = True
        Me.RbAtivo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RbAtivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.RbAtivo.Location = New System.Drawing.Point(4, 6)
        Me.RbAtivo.Name = "RbAtivo"
        Me.RbAtivo.Size = New System.Drawing.Size(58, 21)
        Me.RbAtivo.TabIndex = 8
        Me.RbAtivo.TabStop = True
        Me.RbAtivo.Text = "Ativo"
        Me.RbAtivo.UseVisualStyleBackColor = True
        '
        'TxtSexo
        '
        Me.TxtSexo.BackColor = System.Drawing.Color.White
        Me.TxtSexo.DisplayMember = "SELECIONE"
        Me.TxtSexo.Enabled = False
        Me.TxtSexo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtSexo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtSexo.FormattingEnabled = True
        Me.TxtSexo.Items.AddRange(New Object() {"Masculino", "Feminino"})
        Me.TxtSexo.Location = New System.Drawing.Point(291, 90)
        Me.TxtSexo.Name = "TxtSexo"
        Me.TxtSexo.Size = New System.Drawing.Size(92, 25)
        Me.TxtSexo.TabIndex = 7
        Me.TxtSexo.ValueMember = "SELECIONE"
        '
        'Lblsexo
        '
        Me.Lblsexo.AutoSize = True
        Me.Lblsexo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Lblsexo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Lblsexo.Location = New System.Drawing.Point(247, 92)
        Me.Lblsexo.Name = "Lblsexo"
        Me.Lblsexo.Size = New System.Drawing.Size(40, 17)
        Me.Lblsexo.TabIndex = 27
        Me.Lblsexo.Text = "Sexo:"
        '
        'TxtTel
        '
        Me.TxtTel.BackColor = System.Drawing.Color.White
        Me.TxtTel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtTel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtTel.Location = New System.Drawing.Point(85, 265)
        Me.TxtTel.Mask = "(00)00000-0000"
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(109, 25)
        Me.TxtTel.TabIndex = 17
        '
        'TxtCep
        '
        Me.TxtCep.BackColor = System.Drawing.Color.White
        Me.TxtCep.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtCep.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtCep.Location = New System.Drawing.Point(84, 125)
        Me.TxtCep.Mask = "00000-000"
        Me.TxtCep.Name = "TxtCep"
        Me.TxtCep.Size = New System.Drawing.Size(133, 25)
        Me.TxtCep.TabIndex = 10
        '
        'TxtCpf
        '
        Me.TxtCpf.BackColor = System.Drawing.Color.White
        Me.TxtCpf.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtCpf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtCpf.Location = New System.Drawing.Point(84, 90)
        Me.TxtCpf.Mask = "000,000,000-00"
        Me.TxtCpf.Name = "TxtCpf"
        Me.TxtCpf.Size = New System.Drawing.Size(133, 25)
        Me.TxtCpf.TabIndex = 5
        '
        'TxtCnpj
        '
        Me.TxtCnpj.BackColor = System.Drawing.Color.White
        Me.TxtCnpj.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtCnpj.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtCnpj.Location = New System.Drawing.Point(84, 90)
        Me.TxtCnpj.Mask = "00,000,000,0000/00"
        Me.TxtCnpj.Name = "TxtCnpj"
        Me.TxtCnpj.Size = New System.Drawing.Size(151, 25)
        Me.TxtCnpj.TabIndex = 6
        Me.TxtCnpj.Visible = False
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.White
        Me.TxtEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtEmail.Location = New System.Drawing.Point(260, 265)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(324, 25)
        Me.TxtEmail.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(212, 268)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 17)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Email:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(19, 267)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 17)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Telefone:"
        '
        'RbPessoaJuridica
        '
        Me.RbPessoaJuridica.AutoSize = True
        Me.RbPessoaJuridica.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RbPessoaJuridica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.RbPessoaJuridica.Location = New System.Drawing.Point(320, 20)
        Me.RbPessoaJuridica.Name = "RbPessoaJuridica"
        Me.RbPessoaJuridica.Size = New System.Drawing.Size(117, 21)
        Me.RbPessoaJuridica.TabIndex = 3
        Me.RbPessoaJuridica.Text = "Pessoa Jurídica"
        Me.RbPessoaJuridica.UseVisualStyleBackColor = True
        '
        'RbPessoaFisica
        '
        Me.RbPessoaFisica.AutoSize = True
        Me.RbPessoaFisica.Checked = True
        Me.RbPessoaFisica.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RbPessoaFisica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.RbPessoaFisica.Location = New System.Drawing.Point(208, 20)
        Me.RbPessoaFisica.Name = "RbPessoaFisica"
        Me.RbPessoaFisica.Size = New System.Drawing.Size(104, 21)
        Me.RbPessoaFisica.TabIndex = 2
        Me.RbPessoaFisica.TabStop = True
        Me.RbPessoaFisica.Text = "Pessoa Física"
        Me.RbPessoaFisica.UseVisualStyleBackColor = True
        '
        'TxtEstado
        '
        Me.TxtEstado.BackColor = System.Drawing.Color.White
        Me.TxtEstado.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtEstado.Location = New System.Drawing.Point(507, 195)
        Me.TxtEstado.Name = "TxtEstado"
        Me.TxtEstado.Size = New System.Drawing.Size(77, 25)
        Me.TxtEstado.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(450, 197)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 17)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Estado:"
        '
        'TxtCidade
        '
        Me.TxtCidade.BackColor = System.Drawing.Color.White
        Me.TxtCidade.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtCidade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtCidade.Location = New System.Drawing.Point(329, 230)
        Me.TxtCidade.Name = "TxtCidade"
        Me.TxtCidade.Size = New System.Drawing.Size(255, 25)
        Me.TxtCidade.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(273, 233)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Cidade:"
        '
        'TxtBairro
        '
        Me.TxtBairro.BackColor = System.Drawing.Color.White
        Me.TxtBairro.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtBairro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtBairro.Location = New System.Drawing.Point(85, 230)
        Me.TxtBairro.Name = "TxtBairro"
        Me.TxtBairro.Size = New System.Drawing.Size(176, 25)
        Me.TxtBairro.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(32, 232)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Bairro:"
        '
        'TxtComp
        '
        Me.TxtComp.BackColor = System.Drawing.Color.White
        Me.TxtComp.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtComp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtComp.Location = New System.Drawing.Point(225, 195)
        Me.TxtComp.Name = "TxtComp"
        Me.TxtComp.Size = New System.Drawing.Size(211, 25)
        Me.TxtComp.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(172, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Comp:"
        '
        'TxtNum
        '
        Me.TxtNum.BackColor = System.Drawing.Color.White
        Me.TxtNum.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtNum.Location = New System.Drawing.Point(85, 195)
        Me.TxtNum.Name = "TxtNum"
        Me.TxtNum.Size = New System.Drawing.Size(83, 25)
        Me.TxtNum.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(53, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Nº:"
        '
        'TxtEndereco
        '
        Me.TxtEndereco.BackColor = System.Drawing.Color.White
        Me.TxtEndereco.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtEndereco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtEndereco.Location = New System.Drawing.Point(84, 160)
        Me.TxtEndereco.Name = "TxtEndereco"
        Me.TxtEndereco.Size = New System.Drawing.Size(500, 25)
        Me.TxtEndereco.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Endereço:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(44, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "CEP:"
        '
        'TxtNome
        '
        Me.TxtNome.BackColor = System.Drawing.Color.White
        Me.TxtNome.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtNome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtNome.Location = New System.Drawing.Point(84, 55)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(351, 25)
        Me.TxtNome.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(33, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(13, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CPF/CNPJ:"
        '
        'TxtCod
        '
        Me.TxtCod.BackColor = System.Drawing.Color.White
        Me.TxtCod.Enabled = False
        Me.TxtCod.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtCod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtCod.Location = New System.Drawing.Point(84, 20)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(110, 25)
        Me.TxtCod.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(24, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Transparent
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.Snow
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(624, 0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(30, 30)
        Me.BtnClose.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.BtnClose, "Fechar")
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BtnClose)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(654, 30)
        Me.Panel2.TabIndex = 28
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Snow
        Me.Label15.Location = New System.Drawing.Point(0, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(166, 30)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = " Cadastro de Clientes"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.BackgroundImage = CType(resources.GetObject("BtnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnCancelar.ForeColor = System.Drawing.Color.DimGray
        Me.BtnCancelar.Location = New System.Drawing.Point(149, 494)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(126, 38)
        Me.BtnCancelar.TabIndex = 40
        Me.BtnCancelar.Text = "CANCELAR (ESC)"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackColor = System.Drawing.Color.Transparent
        Me.BtnSalvar.BackgroundImage = CType(resources.GetObject("BtnSalvar.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.FlatAppearance.BorderSize = 0
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.ForeColor = System.Drawing.Color.White
        Me.BtnSalvar.Location = New System.Drawing.Point(21, 494)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(113, 38)
        Me.BtnSalvar.TabIndex = 41
        Me.BtnSalvar.Text = "SALVAR (F3)"
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'Frm_cad_addClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(654, 550)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnSalvar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "Frm_cad_addClientes"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtLimiteCredito As TextBox
    Friend WithEvents RbLimiteDiff As RadioButton
    Friend WithEvents RbSemDebito As RadioButton
    Friend WithEvents RbLimitePadrao As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RbInativo As RadioButton
    Friend WithEvents RbAtivo As RadioButton
    Friend WithEvents TxtSexo As ComboBox
    Friend WithEvents Lblsexo As Label
    Friend WithEvents TxtTel As MaskedTextBox
    Friend WithEvents TxtCep As MaskedTextBox
    Friend WithEvents TxtCpf As MaskedTextBox
    Friend WithEvents TxtCnpj As MaskedTextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents RbPessoaJuridica As RadioButton
    Friend WithEvents RbPessoaFisica As RadioButton
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
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents Label16 As Label
End Class
