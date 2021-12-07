<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_cad_funcionarios
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_cad_funcionarios))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnExcuir = New System.Windows.Forms.Button()
        Me.BtnInativar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnIncluir = New System.Windows.Forms.Button()
        Me.Btnfiltro = New System.Windows.Forms.Button()
        Me.PanelA = New System.Windows.Forms.Panel()
        Me.LbFiltro = New System.Windows.Forms.LinkLabel()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSelecionar = New System.Windows.Forms.Button()
        Me.PanelB = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtnome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCidade = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbSitucao = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cbfuncao = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelA.SuspendLayout()
        Me.PanelB.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.DataGrid)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1043, 428)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
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
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(138, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGrid.ColumnHeadersHeight = 30
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(218, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid.EnableHeadersVisualStyles = False
        Me.DataGrid.Location = New System.Drawing.Point(3, 16)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.RowTemplate.Height = 30
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(1037, 409)
        Me.DataGrid.TabIndex = 0
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
        Me.BtnExcuir.Location = New System.Drawing.Point(251, 0)
        Me.BtnExcuir.Name = "BtnExcuir"
        Me.BtnExcuir.Size = New System.Drawing.Size(67, 45)
        Me.BtnExcuir.TabIndex = 54
        Me.BtnExcuir.TabStop = False
        Me.BtnExcuir.Text = "Excluir"
        Me.BtnExcuir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnExcuir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.BtnExcuir, "Exluir registro (DELETE)")
        Me.BtnExcuir.UseVisualStyleBackColor = False
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
        Me.BtnInativar.TabStop = False
        Me.BtnInativar.Text = "Inativar"
        Me.BtnInativar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnInativar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.BtnInativar, "Inativar fornecedor (F5)")
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
        Me.BtnEditar.TabStop = False
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
        Me.BtnIncluir.TabStop = False
        Me.BtnIncluir.Text = "Incluir"
        Me.BtnIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnIncluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.BtnIncluir, "Incluir registro (F1)")
        Me.BtnIncluir.UseVisualStyleBackColor = False
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
        Me.Btnfiltro.Location = New System.Drawing.Point(887, 34)
        Me.Btnfiltro.Name = "Btnfiltro"
        Me.Btnfiltro.Size = New System.Drawing.Size(30, 25)
        Me.Btnfiltro.TabIndex = 5
        Me.Btnfiltro.TabStop = False
        Me.Btnfiltro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Btnfiltro, "Filtrar fornecedor")
        Me.Btnfiltro.UseVisualStyleBackColor = False
        '
        'PanelA
        '
        Me.PanelA.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.PanelA.Controls.Add(Me.LbFiltro)
        Me.PanelA.Controls.Add(Me.BtnCancelar)
        Me.PanelA.Controls.Add(Me.BtnExcuir)
        Me.PanelA.Controls.Add(Me.BtnSelecionar)
        Me.PanelA.Controls.Add(Me.BtnInativar)
        Me.PanelA.Controls.Add(Me.BtnEditar)
        Me.PanelA.Controls.Add(Me.BtnIncluir)
        Me.PanelA.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelA.Location = New System.Drawing.Point(0, 0)
        Me.PanelA.Name = "PanelA"
        Me.PanelA.Size = New System.Drawing.Size(1043, 45)
        Me.PanelA.TabIndex = 63
        '
        'LbFiltro
        '
        Me.LbFiltro.ActiveLinkColor = System.Drawing.Color.Yellow
        Me.LbFiltro.AutoSize = True
        Me.LbFiltro.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LbFiltro.LinkColor = System.Drawing.Color.White
        Me.LbFiltro.Location = New System.Drawing.Point(391, 12)
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
        Me.BtnCancelar.Location = New System.Drawing.Point(318, 0)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(67, 45)
        Me.BtnCancelar.TabIndex = 55
        Me.BtnCancelar.TabStop = False
        Me.BtnCancelar.Text = "Fechar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnSelecionar
        '
        Me.BtnSelecionar.BackColor = System.Drawing.Color.Transparent
        Me.BtnSelecionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSelecionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSelecionar.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnSelecionar.Enabled = False
        Me.BtnSelecionar.FlatAppearance.BorderSize = 0
        Me.BtnSelecionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelecionar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelecionar.ForeColor = System.Drawing.Color.White
        Me.BtnSelecionar.Image = CType(resources.GetObject("BtnSelecionar.Image"), System.Drawing.Image)
        Me.BtnSelecionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSelecionar.Location = New System.Drawing.Point(180, 0)
        Me.BtnSelecionar.Name = "BtnSelecionar"
        Me.BtnSelecionar.Size = New System.Drawing.Size(71, 45)
        Me.BtnSelecionar.TabIndex = 52
        Me.BtnSelecionar.TabStop = False
        Me.BtnSelecionar.Text = "Selecionar"
        Me.BtnSelecionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSelecionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnSelecionar.UseVisualStyleBackColor = False
        '
        'PanelB
        '
        Me.PanelB.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelB.Controls.Add(Me.Label4)
        Me.PanelB.Controls.Add(Me.Btnfiltro)
        Me.PanelB.Controls.Add(Me.Txtnome)
        Me.PanelB.Controls.Add(Me.Label3)
        Me.PanelB.Controls.Add(Me.TxtCidade)
        Me.PanelB.Controls.Add(Me.Label2)
        Me.PanelB.Controls.Add(Me.CbSitucao)
        Me.PanelB.Controls.Add(Me.Label1)
        Me.PanelB.Controls.Add(Me.Cbfuncao)
        Me.PanelB.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelB.Location = New System.Drawing.Point(0, 45)
        Me.PanelB.Name = "PanelB"
        Me.PanelB.Size = New System.Drawing.Size(1043, 77)
        Me.PanelB.TabIndex = 64
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
        'Txtnome
        '
        Me.Txtnome.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Txtnome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Txtnome.Location = New System.Drawing.Point(35, 32)
        Me.Txtnome.Multiline = True
        Me.Txtnome.Name = "Txtnome"
        Me.Txtnome.Size = New System.Drawing.Size(165, 25)
        Me.Txtnome.TabIndex = 1
        Me.Txtnome.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(635, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Cidade:"
        '
        'TxtCidade
        '
        Me.TxtCidade.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.TxtCidade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtCidade.Location = New System.Drawing.Point(633, 34)
        Me.TxtCidade.Multiline = True
        Me.TxtCidade.Name = "TxtCidade"
        Me.TxtCidade.Size = New System.Drawing.Size(249, 25)
        Me.TxtCidade.TabIndex = 4
        Me.TxtCidade.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(463, 16)
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
        Me.CbSitucao.Location = New System.Drawing.Point(460, 34)
        Me.CbSitucao.Name = "CbSitucao"
        Me.CbSitucao.Size = New System.Drawing.Size(131, 23)
        Me.CbSitucao.TabIndex = 3
        Me.CbSitucao.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(242, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Função:"
        '
        'Cbfuncao
        '
        Me.Cbfuncao.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbfuncao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Cbfuncao.FormattingEnabled = True
        Me.Cbfuncao.Items.AddRange(New Object() {""})
        Me.Cbfuncao.Location = New System.Drawing.Point(240, 34)
        Me.Cbfuncao.Name = "Cbfuncao"
        Me.Cbfuncao.Size = New System.Drawing.Size(188, 23)
        Me.Cbfuncao.TabIndex = 2
        Me.Cbfuncao.TabStop = False
        '
        'Frm_cad_funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 550)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanelB)
        Me.Controls.Add(Me.PanelA)
        Me.KeyPreview = True
        Me.Name = "Frm_cad_funcionarios"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Funcionários"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelA.ResumeLayout(False)
        Me.PanelA.PerformLayout()
        Me.PanelB.ResumeLayout(False)
        Me.PanelB.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PanelA As Panel
    Friend WithEvents LbFiltro As LinkLabel
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnExcuir As Button
    Friend WithEvents BtnSelecionar As Button
    Friend WithEvents BtnInativar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnIncluir As Button
    Friend WithEvents PanelB As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Btnfiltro As Button
    Friend WithEvents Txtnome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCidade As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CbSitucao As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Cbfuncao As ComboBox
End Class
