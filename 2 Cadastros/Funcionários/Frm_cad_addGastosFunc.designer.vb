<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_cad_addGastosFunc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_cad_addGastosFunc))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnPesqFunc = New System.Windows.Forms.Button()
        Me.TxtSalario = New System.Windows.Forms.TextBox()
        Me.TxtFerias = New System.Windows.Forms.TextBox()
        Me.Txt13Salario = New System.Windows.Forms.TextBox()
        Me.TxtFgts = New System.Windows.Forms.TextBox()
        Me.TxtInss = New System.Windows.Forms.TextBox()
        Me.TxtVt = New System.Windows.Forms.TextBox()
        Me.TxtVrVa = New System.Windows.Forms.TextBox()
        Me.TxtSaude = New System.Windows.Forms.TextBox()
        Me.TxtOdonto = New System.Windows.Forms.TextBox()
        Me.TxtPrev = New System.Windows.Forms.TextBox()
        Me.TxtPlr = New System.Windows.Forms.TextBox()
        Me.TxtOutros = New System.Windows.Forms.TextBox()
        Me.TxtDescricao = New System.Windows.Forms.TextBox()
        Me.TxtSalarioFamilia = New System.Windows.Forms.TextBox()
        Me.TxtFuncao = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtIdFuncao = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtIdFunc = New System.Windows.Forms.TextBox()
        Me.TxtFuncionario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboxAutomatico = New System.Windows.Forms.CheckBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        'BtnPesqFunc
        '
        Me.BtnPesqFunc.BackColor = System.Drawing.Color.Transparent
        Me.BtnPesqFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnPesqFunc.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnPesqFunc.FlatAppearance.BorderSize = 0
        Me.BtnPesqFunc.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnPesqFunc.Location = New System.Drawing.Point(465, 54)
        Me.BtnPesqFunc.Name = "BtnPesqFunc"
        Me.BtnPesqFunc.Size = New System.Drawing.Size(26, 27)
        Me.BtnPesqFunc.TabIndex = 4
        Me.BtnPesqFunc.TabStop = False
        Me.BtnPesqFunc.Text = "..."
        Me.BtnPesqFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BtnPesqFunc, "Pesquisar (F5)")
        Me.BtnPesqFunc.UseVisualStyleBackColor = False
        '
        'TxtSalario
        '
        Me.TxtSalario.BackColor = System.Drawing.Color.White
        Me.TxtSalario.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtSalario.ForeColor = System.Drawing.Color.Black
        Me.TxtSalario.Location = New System.Drawing.Point(103, 37)
        Me.TxtSalario.Name = "TxtSalario"
        Me.TxtSalario.Size = New System.Drawing.Size(90, 25)
        Me.TxtSalario.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.TxtSalario, "Pesquisar (F5)")
        '
        'TxtFerias
        '
        Me.TxtFerias.BackColor = System.Drawing.Color.White
        Me.TxtFerias.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtFerias.ForeColor = System.Drawing.Color.Black
        Me.TxtFerias.Location = New System.Drawing.Point(375, 72)
        Me.TxtFerias.Name = "TxtFerias"
        Me.TxtFerias.Size = New System.Drawing.Size(90, 25)
        Me.TxtFerias.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.TxtFerias, "Pesquisar (F5)")
        '
        'Txt13Salario
        '
        Me.Txt13Salario.BackColor = System.Drawing.Color.White
        Me.Txt13Salario.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Txt13Salario.ForeColor = System.Drawing.Color.Black
        Me.Txt13Salario.Location = New System.Drawing.Point(103, 72)
        Me.Txt13Salario.Name = "Txt13Salario"
        Me.Txt13Salario.Size = New System.Drawing.Size(90, 25)
        Me.Txt13Salario.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.Txt13Salario, "Pesquisar (F5)")
        '
        'TxtFgts
        '
        Me.TxtFgts.BackColor = System.Drawing.Color.White
        Me.TxtFgts.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtFgts.ForeColor = System.Drawing.Color.Black
        Me.TxtFgts.Location = New System.Drawing.Point(103, 107)
        Me.TxtFgts.Name = "TxtFgts"
        Me.TxtFgts.Size = New System.Drawing.Size(90, 25)
        Me.TxtFgts.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.TxtFgts, "Pesquisar (F5)")
        '
        'TxtInss
        '
        Me.TxtInss.BackColor = System.Drawing.Color.White
        Me.TxtInss.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtInss.ForeColor = System.Drawing.Color.Black
        Me.TxtInss.Location = New System.Drawing.Point(375, 107)
        Me.TxtInss.Name = "TxtInss"
        Me.TxtInss.Size = New System.Drawing.Size(90, 25)
        Me.TxtInss.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.TxtInss, "Pesquisar (F5)")
        '
        'TxtVt
        '
        Me.TxtVt.BackColor = System.Drawing.Color.White
        Me.TxtVt.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtVt.ForeColor = System.Drawing.Color.Black
        Me.TxtVt.Location = New System.Drawing.Point(375, 142)
        Me.TxtVt.Name = "TxtVt"
        Me.TxtVt.Size = New System.Drawing.Size(90, 25)
        Me.TxtVt.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.TxtVt, "Pesquisar (F5)")
        '
        'TxtVrVa
        '
        Me.TxtVrVa.BackColor = System.Drawing.Color.White
        Me.TxtVrVa.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtVrVa.ForeColor = System.Drawing.Color.Black
        Me.TxtVrVa.Location = New System.Drawing.Point(103, 142)
        Me.TxtVrVa.Name = "TxtVrVa"
        Me.TxtVrVa.Size = New System.Drawing.Size(90, 25)
        Me.TxtVrVa.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.TxtVrVa, "Pesquisar (F5)")
        '
        'TxtSaude
        '
        Me.TxtSaude.BackColor = System.Drawing.Color.White
        Me.TxtSaude.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtSaude.ForeColor = System.Drawing.Color.Black
        Me.TxtSaude.Location = New System.Drawing.Point(103, 177)
        Me.TxtSaude.Name = "TxtSaude"
        Me.TxtSaude.Size = New System.Drawing.Size(90, 25)
        Me.TxtSaude.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.TxtSaude, "Pesquisar (F5)")
        '
        'TxtOdonto
        '
        Me.TxtOdonto.BackColor = System.Drawing.Color.White
        Me.TxtOdonto.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtOdonto.ForeColor = System.Drawing.Color.Black
        Me.TxtOdonto.Location = New System.Drawing.Point(375, 177)
        Me.TxtOdonto.Name = "TxtOdonto"
        Me.TxtOdonto.Size = New System.Drawing.Size(90, 25)
        Me.TxtOdonto.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.TxtOdonto, "Pesquisar (F5)")
        '
        'TxtPrev
        '
        Me.TxtPrev.BackColor = System.Drawing.Color.White
        Me.TxtPrev.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtPrev.ForeColor = System.Drawing.Color.Black
        Me.TxtPrev.Location = New System.Drawing.Point(103, 212)
        Me.TxtPrev.Name = "TxtPrev"
        Me.TxtPrev.Size = New System.Drawing.Size(90, 25)
        Me.TxtPrev.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.TxtPrev, "Pesquisar (F5)")
        '
        'TxtPlr
        '
        Me.TxtPlr.BackColor = System.Drawing.Color.White
        Me.TxtPlr.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtPlr.ForeColor = System.Drawing.Color.Black
        Me.TxtPlr.Location = New System.Drawing.Point(375, 212)
        Me.TxtPlr.Name = "TxtPlr"
        Me.TxtPlr.Size = New System.Drawing.Size(90, 25)
        Me.TxtPlr.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.TxtPlr, "Pesquisar (F5)")
        '
        'TxtOutros
        '
        Me.TxtOutros.BackColor = System.Drawing.Color.White
        Me.TxtOutros.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtOutros.ForeColor = System.Drawing.Color.Black
        Me.TxtOutros.Location = New System.Drawing.Point(103, 247)
        Me.TxtOutros.Name = "TxtOutros"
        Me.TxtOutros.Size = New System.Drawing.Size(90, 25)
        Me.TxtOutros.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.TxtOutros, "Pesquisar (F5)")
        '
        'TxtDescricao
        '
        Me.TxtDescricao.BackColor = System.Drawing.Color.White
        Me.TxtDescricao.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtDescricao.ForeColor = System.Drawing.Color.Black
        Me.TxtDescricao.Location = New System.Drawing.Point(295, 247)
        Me.TxtDescricao.Name = "TxtDescricao"
        Me.TxtDescricao.Size = New System.Drawing.Size(170, 25)
        Me.TxtDescricao.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.TxtDescricao, "Pesquisar (F5)")
        '
        'TxtSalarioFamilia
        '
        Me.TxtSalarioFamilia.BackColor = System.Drawing.Color.White
        Me.TxtSalarioFamilia.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtSalarioFamilia.ForeColor = System.Drawing.Color.Black
        Me.TxtSalarioFamilia.Location = New System.Drawing.Point(375, 37)
        Me.TxtSalarioFamilia.Name = "TxtSalarioFamilia"
        Me.TxtSalarioFamilia.Size = New System.Drawing.Size(90, 25)
        Me.TxtSalarioFamilia.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.TxtSalarioFamilia, "Pesquisar (F5)")
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
        Me.TxtFuncao.TabIndex = 75
        Me.ToolTip1.SetToolTip(Me.TxtFuncao, "Pesquisar (F5)")
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.BtnCancelar)
        Me.GroupBox3.Controls.Add(Me.BtnSalvar)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(513, 60)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(513, 135)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'TxtIdFuncao
        '
        Me.TxtIdFuncao.Enabled = False
        Me.TxtIdFuncao.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtIdFuncao.ForeColor = System.Drawing.Color.Black
        Me.TxtIdFuncao.Location = New System.Drawing.Point(105, 90)
        Me.TxtIdFuncao.Name = "TxtIdFuncao"
        Me.TxtIdFuncao.Size = New System.Drawing.Size(50, 25)
        Me.TxtIdFuncao.TabIndex = 77
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(48, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 19)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "Função:"
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
        Me.TxtFuncionario.Size = New System.Drawing.Size(306, 25)
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.CboxAutomatico)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.TxtSalarioFamilia)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.TxtDescricao)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TxtOutros)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TxtPlr)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TxtPrev)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TxtOdonto)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxtSaude)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtVrVa)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtVt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtInss)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtFgts)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Txt13Salario)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtFerias)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtSalario)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 200)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(513, 291)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gastos Mensais"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label17.Location = New System.Drawing.Point(276, 38)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(98, 19)
        Me.Label17.TabIndex = 97
        Me.Label17.Text = "Salário Família:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label16.Location = New System.Drawing.Point(222, 250)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 19)
        Me.Label16.TabIndex = 95
        Me.Label16.Text = "Descrição:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label15.Location = New System.Drawing.Point(45, 250)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 19)
        Me.Label15.TabIndex = 93
        Me.Label15.Text = "Outros:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(337, 215)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 19)
        Me.Label14.TabIndex = 91
        Me.Label14.Text = "PLR:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(19, 215)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 19)
        Me.Label13.TabIndex = 89
        Me.Label13.Text = "Previdência:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(273, 179)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 19)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "Plano Odonto:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(13, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 19)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "Plano Saúde:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(48, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 19)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "VR/VA:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(265, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 19)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Vale Transporte:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(276, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 19)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "INSS Patronal:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(57, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 19)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "FGTS:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(1, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 19)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "13º /Encargos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(272, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 19)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Férias/Ecargos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(15, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 19)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Salário Base:"
        '
        'CboxAutomatico
        '
        Me.CboxAutomatico.AutoSize = True
        Me.CboxAutomatico.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.CboxAutomatico.Location = New System.Drawing.Point(103, 14)
        Me.CboxAutomatico.Name = "CboxAutomatico"
        Me.CboxAutomatico.Size = New System.Drawing.Size(85, 17)
        Me.CboxAutomatico.TabIndex = 12
        Me.CboxAutomatico.Text = "Automático"
        Me.CboxAutomatico.UseVisualStyleBackColor = True
        '
        'Frm_cad_addGastosFunc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 500)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.KeyPreview = True
        Me.Name = "Frm_cad_addGastosFunc"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Incluir Gastos Funcionários"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtCod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnPesqFunc As Button
    Friend WithEvents TxtIdFunc As TextBox
    Friend WithEvents TxtFuncionario As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtSaude As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtVrVa As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtVt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtInss As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtFgts As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt13Salario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtFerias As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtSalario As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtOdonto As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtSalarioFamilia As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtDescricao As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtOutros As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtPlr As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtPrev As TextBox
    Friend WithEvents TxtIdFuncao As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtFuncao As TextBox
    Friend WithEvents CboxAutomatico As CheckBox
End Class
