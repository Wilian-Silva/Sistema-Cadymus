<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_cad_addProdutos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_cad_addProdutos))
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataFim = New System.Windows.Forms.DateTimePicker()
        Me.DataInicio = New System.Windows.Forms.DateTimePicker()
        Me.CboxPromocao = New System.Windows.Forms.CheckBox()
        Me.TxtPpromocao = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtIdLocal = New System.Windows.Forms.TextBox()
        Me.TxtIdMarca = New System.Windows.Forms.TextBox()
        Me.TxtIdCategoria = New System.Windows.Forms.TextBox()
        Me.BtnLocal = New System.Windows.Forms.Button()
        Me.LabelPercent = New System.Windows.Forms.Label()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.TxtCategoria = New System.Windows.Forms.TextBox()
        Me.BtnMarca = New System.Windows.Forms.Button()
        Me.BtnCategoria = New System.Windows.Forms.Button()
        Me.BtnPesqFornecedor = New System.Windows.Forms.Button()
        Me.TxtLocal = New System.Windows.Forms.TextBox()
        Me.TxtSaldoProd = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RbInativo = New System.Windows.Forms.RadioButton()
        Me.RbAtivo = New System.Windows.Forms.RadioButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtMarkup = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CboxEstoque = New System.Windows.Forms.CheckBox()
        Me.TxtEstMaximo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtEstMinimo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtIdFornec = New System.Windows.Forms.TextBox()
        Me.TxtPvenda = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtForncedor = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtPcusto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CboxAutomatico = New System.Windows.Forms.CheckBox()
        Me.TxtDescricao = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCodBarras = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox6.Controls.Add(Me.BtnCancelar)
        Me.GroupBox6.Controls.Add(Me.BtnSalvar)
        Me.GroupBox6.Location = New System.Drawing.Point(14, 5)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(581, 60)
        Me.GroupBox6.TabIndex = 26
        Me.GroupBox6.TabStop = False
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.DataFim)
        Me.GroupBox4.Controls.Add(Me.DataInicio)
        Me.GroupBox4.Controls.Add(Me.CboxPromocao)
        Me.GroupBox4.Controls.Add(Me.TxtPpromocao)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(17, 415)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(578, 98)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Preço Promocional de Venda"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(359, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 19)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Preço Prom."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(369, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 19)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Data Final:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(100, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 19)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Data Inicial:"
        '
        'DataFim
        '
        Me.DataFim.CalendarFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataFim.Enabled = False
        Me.DataFim.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DataFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataFim.Location = New System.Drawing.Point(445, 61)
        Me.DataFim.Name = "DataFim"
        Me.DataFim.Size = New System.Drawing.Size(105, 25)
        Me.DataFim.TabIndex = 25
        '
        'DataInicio
        '
        Me.DataInicio.CalendarFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataInicio.Enabled = False
        Me.DataInicio.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataInicio.Location = New System.Drawing.Point(184, 59)
        Me.DataInicio.Name = "DataInicio"
        Me.DataInicio.Size = New System.Drawing.Size(105, 25)
        Me.DataInicio.TabIndex = 24
        '
        'CboxPromocao
        '
        Me.CboxPromocao.AutoSize = True
        Me.CboxPromocao.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CboxPromocao.Location = New System.Drawing.Point(102, 26)
        Me.CboxPromocao.Name = "CboxPromocao"
        Me.CboxPromocao.Size = New System.Drawing.Size(167, 23)
        Me.CboxPromocao.TabIndex = 22
        Me.CboxPromocao.Text = "Produto em promoção"
        Me.CboxPromocao.UseVisualStyleBackColor = True
        '
        'TxtPpromocao
        '
        Me.TxtPpromocao.Enabled = False
        Me.TxtPpromocao.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtPpromocao.ForeColor = System.Drawing.Color.Black
        Me.TxtPpromocao.Location = New System.Drawing.Point(445, 26)
        Me.TxtPpromocao.Name = "TxtPpromocao"
        Me.TxtPpromocao.Size = New System.Drawing.Size(105, 25)
        Me.TxtPpromocao.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.TxtIdLocal)
        Me.GroupBox1.Controls.Add(Me.TxtIdMarca)
        Me.GroupBox1.Controls.Add(Me.TxtIdCategoria)
        Me.GroupBox1.Controls.Add(Me.BtnLocal)
        Me.GroupBox1.Controls.Add(Me.LabelPercent)
        Me.GroupBox1.Controls.Add(Me.TxtMarca)
        Me.GroupBox1.Controls.Add(Me.TxtCategoria)
        Me.GroupBox1.Controls.Add(Me.BtnMarca)
        Me.GroupBox1.Controls.Add(Me.BtnCategoria)
        Me.GroupBox1.Controls.Add(Me.BtnPesqFornecedor)
        Me.GroupBox1.Controls.Add(Me.TxtLocal)
        Me.GroupBox1.Controls.Add(Me.TxtSaldoProd)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.TxtMarkup)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.CboxEstoque)
        Me.GroupBox1.Controls.Add(Me.TxtEstMaximo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtEstMinimo)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxtIdFornec)
        Me.GroupBox1.Controls.Add(Me.TxtPvenda)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtForncedor)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TxtPcusto)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.CboxAutomatico)
        Me.GroupBox1.Controls.Add(Me.TxtDescricao)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtCodBarras)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtCod)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(581, 352)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'TxtIdLocal
        '
        Me.TxtIdLocal.Enabled = False
        Me.TxtIdLocal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtIdLocal.ForeColor = System.Drawing.Color.Black
        Me.TxtIdLocal.Location = New System.Drawing.Point(105, 275)
        Me.TxtIdLocal.Name = "TxtIdLocal"
        Me.TxtIdLocal.Size = New System.Drawing.Size(35, 25)
        Me.TxtIdLocal.TabIndex = 48
        '
        'TxtIdMarca
        '
        Me.TxtIdMarca.Enabled = False
        Me.TxtIdMarca.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtIdMarca.ForeColor = System.Drawing.Color.Black
        Me.TxtIdMarca.Location = New System.Drawing.Point(341, 92)
        Me.TxtIdMarca.Name = "TxtIdMarca"
        Me.TxtIdMarca.Size = New System.Drawing.Size(35, 25)
        Me.TxtIdMarca.TabIndex = 47
        '
        'TxtIdCategoria
        '
        Me.TxtIdCategoria.Enabled = False
        Me.TxtIdCategoria.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtIdCategoria.ForeColor = System.Drawing.Color.Black
        Me.TxtIdCategoria.Location = New System.Drawing.Point(105, 91)
        Me.TxtIdCategoria.Name = "TxtIdCategoria"
        Me.TxtIdCategoria.Size = New System.Drawing.Size(35, 25)
        Me.TxtIdCategoria.TabIndex = 46
        '
        'BtnLocal
        '
        Me.BtnLocal.BackColor = System.Drawing.Color.Transparent
        Me.BtnLocal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnLocal.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnLocal.FlatAppearance.BorderSize = 0
        Me.BtnLocal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnLocal.Location = New System.Drawing.Point(527, 274)
        Me.BtnLocal.Name = "BtnLocal"
        Me.BtnLocal.Size = New System.Drawing.Size(26, 27)
        Me.BtnLocal.TabIndex = 45
        Me.BtnLocal.TabStop = False
        Me.BtnLocal.Text = "..."
        Me.BtnLocal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BtnLocal, "Pesquisar (F5)")
        Me.BtnLocal.UseVisualStyleBackColor = False
        '
        'LabelPercent
        '
        Me.LabelPercent.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelPercent.ForeColor = System.Drawing.Color.Blue
        Me.LabelPercent.Location = New System.Drawing.Point(343, 236)
        Me.LabelPercent.Name = "LabelPercent"
        Me.LabelPercent.Size = New System.Drawing.Size(176, 35)
        Me.LabelPercent.TabIndex = 44
        Me.LabelPercent.Text = "Inserir % no formato decimal.  Ex: 10% inserir 0,1"
        Me.LabelPercent.Visible = False
        '
        'TxtMarca
        '
        Me.TxtMarca.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtMarca.ForeColor = System.Drawing.Color.Black
        Me.TxtMarca.Location = New System.Drawing.Point(377, 92)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.ReadOnly = True
        Me.TxtMarca.Size = New System.Drawing.Size(150, 25)
        Me.TxtMarca.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.TxtMarca, "Pesquisar (F5)")
        '
        'TxtCategoria
        '
        Me.TxtCategoria.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtCategoria.ForeColor = System.Drawing.Color.Black
        Me.TxtCategoria.Location = New System.Drawing.Point(141, 91)
        Me.TxtCategoria.Name = "TxtCategoria"
        Me.TxtCategoria.ReadOnly = True
        Me.TxtCategoria.Size = New System.Drawing.Size(114, 25)
        Me.TxtCategoria.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.TxtCategoria, "Pesquisar (F5)")
        '
        'BtnMarca
        '
        Me.BtnMarca.BackColor = System.Drawing.Color.Transparent
        Me.BtnMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnMarca.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnMarca.FlatAppearance.BorderSize = 0
        Me.BtnMarca.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnMarca.Location = New System.Drawing.Point(527, 91)
        Me.BtnMarca.Name = "BtnMarca"
        Me.BtnMarca.Size = New System.Drawing.Size(26, 27)
        Me.BtnMarca.TabIndex = 7
        Me.BtnMarca.TabStop = False
        Me.BtnMarca.Text = "..."
        Me.BtnMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BtnMarca, "Pesquisar (F5)")
        Me.BtnMarca.UseVisualStyleBackColor = False
        '
        'BtnCategoria
        '
        Me.BtnCategoria.BackColor = System.Drawing.Color.Transparent
        Me.BtnCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnCategoria.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnCategoria.FlatAppearance.BorderSize = 0
        Me.BtnCategoria.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnCategoria.Location = New System.Drawing.Point(255, 90)
        Me.BtnCategoria.Name = "BtnCategoria"
        Me.BtnCategoria.Size = New System.Drawing.Size(26, 27)
        Me.BtnCategoria.TabIndex = 5
        Me.BtnCategoria.TabStop = False
        Me.BtnCategoria.Text = "..."
        Me.BtnCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BtnCategoria, "Pesquisar (F5)")
        Me.BtnCategoria.UseVisualStyleBackColor = False
        '
        'BtnPesqFornecedor
        '
        Me.BtnPesqFornecedor.BackColor = System.Drawing.Color.Transparent
        Me.BtnPesqFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnPesqFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnPesqFornecedor.FlatAppearance.BorderSize = 0
        Me.BtnPesqFornecedor.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnPesqFornecedor.Location = New System.Drawing.Point(527, 169)
        Me.BtnPesqFornecedor.Name = "BtnPesqFornecedor"
        Me.BtnPesqFornecedor.Size = New System.Drawing.Size(26, 27)
        Me.BtnPesqFornecedor.TabIndex = 13
        Me.BtnPesqFornecedor.TabStop = False
        Me.BtnPesqFornecedor.Text = "..."
        Me.BtnPesqFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BtnPesqFornecedor, "Pesquisar (F5)")
        Me.BtnPesqFornecedor.UseVisualStyleBackColor = False
        '
        'TxtLocal
        '
        Me.TxtLocal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtLocal.ForeColor = System.Drawing.Color.Black
        Me.TxtLocal.Location = New System.Drawing.Point(141, 275)
        Me.TxtLocal.Name = "TxtLocal"
        Me.TxtLocal.ReadOnly = True
        Me.TxtLocal.Size = New System.Drawing.Size(386, 25)
        Me.TxtLocal.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.TxtLocal, "Pesquisar (F5)")
        '
        'TxtSaldoProd
        '
        Me.TxtSaldoProd.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtSaldoProd.ForeColor = System.Drawing.Color.Black
        Me.TxtSaldoProd.Location = New System.Drawing.Point(105, 310)
        Me.TxtSaldoProd.Name = "TxtSaldoProd"
        Me.TxtSaldoProd.Size = New System.Drawing.Size(86, 25)
        Me.TxtSaldoProd.TabIndex = 19
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RbInativo)
        Me.Panel1.Controls.Add(Me.RbAtivo)
        Me.Panel1.Location = New System.Drawing.Point(359, 124)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(164, 35)
        Me.Panel1.TabIndex = 24
        '
        'RbInativo
        '
        Me.RbInativo.AutoSize = True
        Me.RbInativo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RbInativo.Location = New System.Drawing.Point(86, 6)
        Me.RbInativo.Name = "RbInativo"
        Me.RbInativo.Size = New System.Drawing.Size(69, 23)
        Me.RbInativo.TabIndex = 10
        Me.RbInativo.Text = "Inativo"
        Me.RbInativo.UseVisualStyleBackColor = True
        '
        'RbAtivo
        '
        Me.RbAtivo.AutoSize = True
        Me.RbAtivo.Checked = True
        Me.RbAtivo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RbAtivo.Location = New System.Drawing.Point(4, 6)
        Me.RbAtivo.Name = "RbAtivo"
        Me.RbAtivo.Size = New System.Drawing.Size(59, 23)
        Me.RbAtivo.TabIndex = 9
        Me.RbAtivo.TabStop = True
        Me.RbAtivo.Text = "Ativo"
        Me.RbAtivo.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label19.Location = New System.Drawing.Point(21, 277)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 19)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Localização:"
        '
        'TxtMarkup
        '
        Me.TxtMarkup.Enabled = False
        Me.TxtMarkup.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtMarkup.ForeColor = System.Drawing.Color.Black
        Me.TxtMarkup.Location = New System.Drawing.Point(277, 240)
        Me.TxtMarkup.Name = "TxtMarkup"
        Me.TxtMarkup.Size = New System.Drawing.Size(63, 25)
        Me.TxtMarkup.TabIndex = 17
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label18.Location = New System.Drawing.Point(2, 314)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(98, 19)
        Me.Label18.TabIndex = 41
        Me.Label18.Text = "Saldo Estoque:"
        '
        'CboxEstoque
        '
        Me.CboxEstoque.AutoSize = True
        Me.CboxEstoque.Checked = True
        Me.CboxEstoque.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CboxEstoque.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CboxEstoque.Location = New System.Drawing.Point(105, 131)
        Me.CboxEstoque.Name = "CboxEstoque"
        Me.CboxEstoque.Size = New System.Drawing.Size(134, 23)
        Me.CboxEstoque.TabIndex = 8
        Me.CboxEstoque.Text = "Controla Estoque"
        Me.CboxEstoque.UseVisualStyleBackColor = True
        '
        'TxtEstMaximo
        '
        Me.TxtEstMaximo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtEstMaximo.ForeColor = System.Drawing.Color.Black
        Me.TxtEstMaximo.Location = New System.Drawing.Point(476, 310)
        Me.TxtEstMaximo.Name = "TxtEstMaximo"
        Me.TxtEstMaximo.Size = New System.Drawing.Size(86, 25)
        Me.TxtEstMaximo.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(385, 313)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 19)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Est. Máximo:"
        '
        'TxtEstMinimo
        '
        Me.TxtEstMinimo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtEstMinimo.ForeColor = System.Drawing.Color.Black
        Me.TxtEstMinimo.Location = New System.Drawing.Point(287, 310)
        Me.TxtEstMinimo.Name = "TxtEstMinimo"
        Me.TxtEstMinimo.Size = New System.Drawing.Size(86, 25)
        Me.TxtEstMinimo.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(200, 242)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 19)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Markup %:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(199, 313)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 19)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Est. Mínimo:"
        '
        'TxtIdFornec
        '
        Me.TxtIdFornec.Enabled = False
        Me.TxtIdFornec.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtIdFornec.ForeColor = System.Drawing.Color.Black
        Me.TxtIdFornec.Location = New System.Drawing.Point(105, 170)
        Me.TxtIdFornec.Name = "TxtIdFornec"
        Me.TxtIdFornec.Size = New System.Drawing.Size(35, 25)
        Me.TxtIdFornec.TabIndex = 11
        '
        'TxtPvenda
        '
        Me.TxtPvenda.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtPvenda.ForeColor = System.Drawing.Color.Black
        Me.TxtPvenda.Location = New System.Drawing.Point(105, 205)
        Me.TxtPvenda.Name = "TxtPvenda"
        Me.TxtPvenda.Size = New System.Drawing.Size(86, 25)
        Me.TxtPvenda.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(290, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 19)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Marca:"
        '
        'TxtForncedor
        '
        Me.TxtForncedor.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtForncedor.ForeColor = System.Drawing.Color.Black
        Me.TxtForncedor.Location = New System.Drawing.Point(141, 170)
        Me.TxtForncedor.Name = "TxtForncedor"
        Me.TxtForncedor.ReadOnly = True
        Me.TxtForncedor.Size = New System.Drawing.Size(386, 25)
        Me.TxtForncedor.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.TxtForncedor, "Pesquisar (F5)")
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(13, 208)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 19)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Preço Venda:"
        '
        'TxtPcusto
        '
        Me.TxtPcusto.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtPcusto.ForeColor = System.Drawing.Color.Black
        Me.TxtPcusto.Location = New System.Drawing.Point(105, 240)
        Me.TxtPcusto.Name = "TxtPcusto"
        Me.TxtPcusto.Size = New System.Drawing.Size(86, 25)
        Me.TxtPcusto.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(15, 243)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 19)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Preço Custo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(20, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 19)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fornecedor:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(30, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Categoria:"
        '
        'CboxAutomatico
        '
        Me.CboxAutomatico.AutoSize = True
        Me.CboxAutomatico.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CboxAutomatico.Location = New System.Drawing.Point(197, 208)
        Me.CboxAutomatico.Name = "CboxAutomatico"
        Me.CboxAutomatico.Size = New System.Drawing.Size(89, 19)
        Me.CboxAutomatico.TabIndex = 15
        Me.CboxAutomatico.Text = "Automático"
        Me.CboxAutomatico.UseVisualStyleBackColor = True
        '
        'TxtDescricao
        '
        Me.TxtDescricao.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtDescricao.ForeColor = System.Drawing.Color.Black
        Me.TxtDescricao.Location = New System.Drawing.Point(105, 56)
        Me.TxtDescricao.Name = "TxtDescricao"
        Me.TxtDescricao.Size = New System.Drawing.Size(448, 25)
        Me.TxtDescricao.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(31, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Descrição:"
        '
        'TxtCodBarras
        '
        Me.TxtCodBarras.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtCodBarras.ForeColor = System.Drawing.Color.Black
        Me.TxtCodBarras.Location = New System.Drawing.Point(346, 21)
        Me.TxtCodBarras.Name = "TxtCodBarras"
        Me.TxtCodBarras.Size = New System.Drawing.Size(207, 25)
        Me.TxtCodBarras.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(259, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cód. Barras:"
        '
        'TxtCod
        '
        Me.TxtCod.Enabled = False
        Me.TxtCod.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtCod.ForeColor = System.Drawing.Color.Black
        Me.TxtCod.Location = New System.Drawing.Point(105, 21)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(77, 25)
        Me.TxtCod.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(45, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'Frm_cad_addProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 519)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "Frm_cad_addProdutos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dados do Produto"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataFim As DateTimePicker
    Friend WithEvents DataInicio As DateTimePicker
    Friend WithEvents CboxPromocao As CheckBox
    Friend WithEvents TxtPpromocao As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtMarca As TextBox
    Friend WithEvents TxtCategoria As TextBox
    Friend WithEvents BtnMarca As Button
    Friend WithEvents BtnCategoria As Button
    Friend WithEvents BtnPesqFornecedor As Button
    Friend WithEvents TxtLocal As TextBox
    Friend WithEvents TxtSaldoProd As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RbInativo As RadioButton
    Friend WithEvents RbAtivo As RadioButton
    Friend WithEvents Label19 As Label
    Friend WithEvents TxtMarkup As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents CboxEstoque As CheckBox
    Friend WithEvents TxtEstMaximo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtEstMinimo As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtIdFornec As TextBox
    Friend WithEvents TxtPvenda As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtForncedor As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtPcusto As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CboxAutomatico As CheckBox
    Friend WithEvents TxtDescricao As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtCodBarras As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LabelPercent As Label
    Friend WithEvents BtnLocal As Button
    Friend WithEvents TxtIdLocal As TextBox
    Friend WithEvents TxtIdMarca As TextBox
    Friend WithEvents TxtIdCategoria As TextBox
End Class
