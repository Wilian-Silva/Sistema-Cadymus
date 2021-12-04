<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_cad_clientes
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_cad_clientes))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LbFiltro = New System.Windows.Forms.LinkLabel()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnExcuir = New System.Windows.Forms.Button()
        Me.BtnLimiteDebito = New System.Windows.Forms.Button()
        Me.BtnInativar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnIncluir = New System.Windows.Forms.Button()
        Me.Txtnome = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TxtCidade = New System.Windows.Forms.TextBox()
        Me.Btnfiltro = New System.Windows.Forms.Button()
        Me.PanelFiltro = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbSitucao = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbTipo = New System.Windows.Forms.ComboBox()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.PanelFiltro.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LbFiltro)
        Me.Panel1.Controls.Add(Me.BtnCancelar)
        Me.Panel1.Controls.Add(Me.BtnExcuir)
        Me.Panel1.Controls.Add(Me.BtnLimiteDebito)
        Me.Panel1.Controls.Add(Me.BtnInativar)
        Me.Panel1.Controls.Add(Me.BtnEditar)
        Me.Panel1.Controls.Add(Me.BtnIncluir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1026, 45)
        Me.Panel1.TabIndex = 46
        '
        'LbFiltro
        '
        Me.LbFiltro.ActiveLinkColor = System.Drawing.Color.Yellow
        Me.LbFiltro.AutoSize = True
        Me.LbFiltro.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LbFiltro.LinkColor = System.Drawing.Color.White
        Me.LbFiltro.Location = New System.Drawing.Point(380, 12)
        Me.LbFiltro.Name = "LbFiltro"
        Me.LbFiltro.Size = New System.Drawing.Size(66, 19)
        Me.LbFiltro.TabIndex = 57
        Me.LbFiltro.TabStop = True
        Me.LbFiltro.Text = "Pesquisar"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(307, 0)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(67, 45)
        Me.BtnCancelar.TabIndex = 55
        Me.BtnCancelar.Text = "Fechar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.BtnCancelar, "Sair (ESC)")
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnExcuir
        '
        Me.BtnExcuir.BackColor = System.Drawing.Color.Transparent
        Me.BtnExcuir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnExcuir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExcuir.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnExcuir.FlatAppearance.BorderSize = 0
        Me.BtnExcuir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnExcuir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExcuir.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcuir.ForeColor = System.Drawing.Color.White
        Me.BtnExcuir.Image = CType(resources.GetObject("BtnExcuir.Image"), System.Drawing.Image)
        Me.BtnExcuir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnExcuir.Location = New System.Drawing.Point(240, 0)
        Me.BtnExcuir.Name = "BtnExcuir"
        Me.BtnExcuir.Size = New System.Drawing.Size(67, 45)
        Me.BtnExcuir.TabIndex = 54
        Me.BtnExcuir.Text = "Excluir"
        Me.BtnExcuir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnExcuir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.BtnExcuir, "Excluir resgistro  (Delete)")
        Me.BtnExcuir.UseVisualStyleBackColor = False
        '
        'BtnLimiteDebito
        '
        Me.BtnLimiteDebito.BackColor = System.Drawing.Color.Transparent
        Me.BtnLimiteDebito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnLimiteDebito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimiteDebito.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnLimiteDebito.FlatAppearance.BorderSize = 0
        Me.BtnLimiteDebito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnLimiteDebito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimiteDebito.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimiteDebito.ForeColor = System.Drawing.Color.White
        Me.BtnLimiteDebito.Image = CType(resources.GetObject("BtnLimiteDebito.Image"), System.Drawing.Image)
        Me.BtnLimiteDebito.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnLimiteDebito.Location = New System.Drawing.Point(180, 0)
        Me.BtnLimiteDebito.Name = "BtnLimiteDebito"
        Me.BtnLimiteDebito.Size = New System.Drawing.Size(60, 45)
        Me.BtnLimiteDebito.TabIndex = 52
        Me.BtnLimiteDebito.Text = "Débito"
        Me.BtnLimiteDebito.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnLimiteDebito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.BtnLimiteDebito, "Limite débito (F4)")
        Me.BtnLimiteDebito.UseVisualStyleBackColor = False
        '
        'BtnInativar
        '
        Me.BtnInativar.BackColor = System.Drawing.Color.Transparent
        Me.BtnInativar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnInativar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnInativar.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnInativar.FlatAppearance.BorderSize = 0
        Me.BtnInativar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnInativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInativar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInativar.ForeColor = System.Drawing.Color.White
        Me.BtnInativar.Image = CType(resources.GetObject("BtnInativar.Image"), System.Drawing.Image)
        Me.BtnInativar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnInativar.Location = New System.Drawing.Point(120, 0)
        Me.BtnInativar.Name = "BtnInativar"
        Me.BtnInativar.Size = New System.Drawing.Size(60, 45)
        Me.BtnInativar.TabIndex = 50
        Me.BtnInativar.Text = "Inativar"
        Me.BtnInativar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnInativar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.BtnInativar, "Inativar cliente (F5)")
        Me.BtnInativar.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.Transparent
        Me.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.Color.White
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEditar.Location = New System.Drawing.Point(60, 0)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(60, 45)
        Me.BtnEditar.TabIndex = 49
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.BtnEditar, "Editar registro (F2)")
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnIncluir
        '
        Me.BtnIncluir.BackColor = System.Drawing.Color.Transparent
        Me.BtnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnIncluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIncluir.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnIncluir.FlatAppearance.BorderSize = 0
        Me.BtnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIncluir.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIncluir.ForeColor = System.Drawing.Color.White
        Me.BtnIncluir.Image = CType(resources.GetObject("BtnIncluir.Image"), System.Drawing.Image)
        Me.BtnIncluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnIncluir.Location = New System.Drawing.Point(0, 0)
        Me.BtnIncluir.Name = "BtnIncluir"
        Me.BtnIncluir.Size = New System.Drawing.Size(60, 45)
        Me.BtnIncluir.TabIndex = 46
        Me.BtnIncluir.Text = "Incluir"
        Me.BtnIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnIncluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.BtnIncluir, "Incluir registro (F1)")
        Me.BtnIncluir.UseVisualStyleBackColor = False
        '
        'Txtnome
        '
        Me.Txtnome.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Txtnome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Txtnome.Location = New System.Drawing.Point(35, 32)
        Me.Txtnome.Multiline = True
        Me.Txtnome.Name = "Txtnome"
        Me.Txtnome.Size = New System.Drawing.Size(165, 25)
        Me.Txtnome.TabIndex = 56
        Me.ToolTip1.SetToolTip(Me.Txtnome, "Pesquisar")
        '
        'TxtCidade
        '
        Me.TxtCidade.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.TxtCidade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtCidade.Location = New System.Drawing.Point(584, 34)
        Me.TxtCidade.Multiline = True
        Me.TxtCidade.Name = "TxtCidade"
        Me.TxtCidade.Size = New System.Drawing.Size(249, 25)
        Me.TxtCidade.TabIndex = 57
        Me.ToolTip1.SetToolTip(Me.TxtCidade, "Pesquisar")
        '
        'Btnfiltro
        '
        Me.Btnfiltro.BackColor = System.Drawing.Color.Transparent
        Me.Btnfiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnfiltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnfiltro.FlatAppearance.BorderSize = 0
        Me.Btnfiltro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Btnfiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnfiltro.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnfiltro.ForeColor = System.Drawing.Color.White
        Me.Btnfiltro.Image = CType(resources.GetObject("Btnfiltro.Image"), System.Drawing.Image)
        Me.Btnfiltro.Location = New System.Drawing.Point(838, 34)
        Me.Btnfiltro.Name = "Btnfiltro"
        Me.Btnfiltro.Size = New System.Drawing.Size(30, 25)
        Me.Btnfiltro.TabIndex = 59
        Me.Btnfiltro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Btnfiltro, "Fitrar")
        Me.Btnfiltro.UseVisualStyleBackColor = False
        '
        'PanelFiltro
        '
        Me.PanelFiltro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelFiltro.Controls.Add(Me.Label4)
        Me.PanelFiltro.Controls.Add(Me.Btnfiltro)
        Me.PanelFiltro.Controls.Add(Me.Txtnome)
        Me.PanelFiltro.Controls.Add(Me.Label3)
        Me.PanelFiltro.Controls.Add(Me.TxtCidade)
        Me.PanelFiltro.Controls.Add(Me.Label2)
        Me.PanelFiltro.Controls.Add(Me.CbSitucao)
        Me.PanelFiltro.Controls.Add(Me.Label1)
        Me.PanelFiltro.Controls.Add(Me.CbTipo)
        Me.PanelFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFiltro.Location = New System.Drawing.Point(0, 45)
        Me.PanelFiltro.Name = "PanelFiltro"
        Me.PanelFiltro.Size = New System.Drawing.Size(1026, 75)
        Me.PanelFiltro.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(36, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Nome:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(586, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Cidade:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(414, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Situação:"
        '
        'CbSitucao
        '
        Me.CbSitucao.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbSitucao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.CbSitucao.FormattingEnabled = True
        Me.CbSitucao.Items.AddRange(New Object() {"", "Ativo", "Inativo"})
        Me.CbSitucao.Location = New System.Drawing.Point(411, 34)
        Me.CbSitucao.Name = "CbSitucao"
        Me.CbSitucao.Size = New System.Drawing.Size(131, 23)
        Me.CbSitucao.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(242, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo cadastro:"
        '
        'CbTipo
        '
        Me.CbTipo.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.CbTipo.FormattingEnabled = True
        Me.CbTipo.Items.AddRange(New Object() {"", "Pessoa Física", "Pessoa Jurídica"})
        Me.CbTipo.Location = New System.Drawing.Point(240, 34)
        Me.CbTipo.Name = "CbTipo"
        Me.CbTipo.Size = New System.Drawing.Size(131, 23)
        Me.CbTipo.TabIndex = 0
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(138, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGrid.ColumnHeadersHeight = 30
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(218, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid.EnableHeadersVisualStyles = False
        Me.DataGrid.Location = New System.Drawing.Point(3, 16)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.RowTemplate.Height = 30
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(1020, 356)
        Me.DataGrid.TabIndex = 48
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.DataGrid)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1026, 375)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        '
        'Frm_cad_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1026, 495)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanelFiltro)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "Frm_cad_clientes"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelFiltro.ResumeLayout(False)
        Me.PanelFiltro.PerformLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnInativar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnIncluir As Button
    Friend WithEvents BtnLimiteDebito As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnExcuir As Button
    Friend WithEvents Txtnome As TextBox
    Friend WithEvents LbFiltro As LinkLabel
    Friend WithEvents PanelFiltro As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCidade As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CbSitucao As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CbTipo As ComboBox
    Friend WithEvents Btnfiltro As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
End Class
