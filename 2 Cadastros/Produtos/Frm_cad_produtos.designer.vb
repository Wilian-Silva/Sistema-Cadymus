<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_cad_produtos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_cad_produtos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.PanelB = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CbStatus = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbControlaEst = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CbPromocao = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbLocalizacao = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btnfiltro = New System.Windows.Forms.Button()
        Me.TxtProduto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtFornecedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbMarca = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbCategoria = New System.Windows.Forms.ComboBox()
        Me.PanelA = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnExcuir = New System.Windows.Forms.Button()
        Me.BtnExportarExcel = New System.Windows.Forms.Button()
        Me.BtnInativar = New System.Windows.Forms.Button()
        Me.BtnPromocao = New System.Windows.Forms.Button()
        Me.BtnPrecoVenda = New System.Windows.Forms.Button()
        Me.BtnCopiar = New System.Windows.Forms.Button()
        Me.LbFiltro = New System.Windows.Forms.LinkLabel()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnIncluir = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelB.SuspendLayout()
        Me.PanelA.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.DataGrid)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 175)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1148, 452)
        Me.GroupBox1.TabIndex = 54
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(138, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrid.ColumnHeadersHeight = 30
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(218, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid.EnableHeadersVisualStyles = False
        Me.DataGrid.Location = New System.Drawing.Point(3, 16)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.RowTemplate.Height = 30
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(1142, 433)
        Me.DataGrid.TabIndex = 0
        '
        'PanelB
        '
        Me.PanelB.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelB.Controls.Add(Me.Label8)
        Me.PanelB.Controls.Add(Me.CbStatus)
        Me.PanelB.Controls.Add(Me.Label7)
        Me.PanelB.Controls.Add(Me.CbControlaEst)
        Me.PanelB.Controls.Add(Me.Label6)
        Me.PanelB.Controls.Add(Me.CbPromocao)
        Me.PanelB.Controls.Add(Me.Label5)
        Me.PanelB.Controls.Add(Me.CbLocalizacao)
        Me.PanelB.Controls.Add(Me.Label4)
        Me.PanelB.Controls.Add(Me.Btnfiltro)
        Me.PanelB.Controls.Add(Me.TxtProduto)
        Me.PanelB.Controls.Add(Me.Label3)
        Me.PanelB.Controls.Add(Me.TxtFornecedor)
        Me.PanelB.Controls.Add(Me.Label2)
        Me.PanelB.Controls.Add(Me.CbMarca)
        Me.PanelB.Controls.Add(Me.Label1)
        Me.PanelB.Controls.Add(Me.CbCategoria)
        Me.PanelB.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelB.Location = New System.Drawing.Point(0, 45)
        Me.PanelB.Name = "PanelB"
        Me.PanelB.Size = New System.Drawing.Size(1148, 130)
        Me.PanelB.TabIndex = 53
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(605, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 15)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Status"
        '
        'CbStatus
        '
        Me.CbStatus.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.CbStatus.FormattingEnabled = True
        Me.CbStatus.Items.AddRange(New Object() {"", "Ativo", "Inativo"})
        Me.CbStatus.Location = New System.Drawing.Point(605, 86)
        Me.CbStatus.Name = "CbStatus"
        Me.CbStatus.Size = New System.Drawing.Size(126, 23)
        Me.CbStatus.TabIndex = 67
        Me.CbStatus.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(408, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 15)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Controla Est."
        '
        'CbControlaEst
        '
        Me.CbControlaEst.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbControlaEst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.CbControlaEst.FormattingEnabled = True
        Me.CbControlaEst.Items.AddRange(New Object() {"", "Sim", "Não"})
        Me.CbControlaEst.Location = New System.Drawing.Point(408, 86)
        Me.CbControlaEst.Name = "CbControlaEst"
        Me.CbControlaEst.Size = New System.Drawing.Size(126, 23)
        Me.CbControlaEst.TabIndex = 65
        Me.CbControlaEst.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(240, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 15)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Promoção:"
        '
        'CbPromocao
        '
        Me.CbPromocao.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbPromocao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.CbPromocao.FormattingEnabled = True
        Me.CbPromocao.Items.AddRange(New Object() {"", "Sim", "Não"})
        Me.CbPromocao.Location = New System.Drawing.Point(240, 86)
        Me.CbPromocao.Name = "CbPromocao"
        Me.CbPromocao.Size = New System.Drawing.Size(126, 23)
        Me.CbPromocao.TabIndex = 63
        Me.CbPromocao.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(17, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 15)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Locallização:"
        '
        'CbLocalizacao
        '
        Me.CbLocalizacao.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbLocalizacao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.CbLocalizacao.FormattingEnabled = True
        Me.CbLocalizacao.Location = New System.Drawing.Point(15, 86)
        Me.CbLocalizacao.Name = "CbLocalizacao"
        Me.CbLocalizacao.Size = New System.Drawing.Size(188, 23)
        Me.CbLocalizacao.TabIndex = 62
        Me.CbLocalizacao.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(16, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Produto:"
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
        Me.Btnfiltro.Location = New System.Drawing.Point(737, 84)
        Me.Btnfiltro.Name = "Btnfiltro"
        Me.Btnfiltro.Size = New System.Drawing.Size(30, 25)
        Me.Btnfiltro.TabIndex = 5
        Me.Btnfiltro.TabStop = False
        Me.Btnfiltro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btnfiltro.UseVisualStyleBackColor = False
        '
        'TxtProduto
        '
        Me.TxtProduto.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TxtProduto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtProduto.Location = New System.Drawing.Point(15, 32)
        Me.TxtProduto.Multiline = True
        Me.TxtProduto.Name = "TxtProduto"
        Me.TxtProduto.Size = New System.Drawing.Size(133, 25)
        Me.TxtProduto.TabIndex = 1
        Me.TxtProduto.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(607, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Fornecedor:"
        '
        'TxtFornecedor
        '
        Me.TxtFornecedor.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.TxtFornecedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtFornecedor.Location = New System.Drawing.Point(605, 30)
        Me.TxtFornecedor.Multiline = True
        Me.TxtFornecedor.Name = "TxtFornecedor"
        Me.TxtFornecedor.Size = New System.Drawing.Size(162, 25)
        Me.TxtFornecedor.TabIndex = 4
        Me.TxtFornecedor.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(410, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Marca:"
        '
        'CbMarca
        '
        Me.CbMarca.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbMarca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.CbMarca.FormattingEnabled = True
        Me.CbMarca.Location = New System.Drawing.Point(408, 32)
        Me.CbMarca.Name = "CbMarca"
        Me.CbMarca.Size = New System.Drawing.Size(171, 23)
        Me.CbMarca.TabIndex = 3
        Me.CbMarca.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(186, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Categoria:"
        '
        'CbCategoria
        '
        Me.CbCategoria.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.CbCategoria.FormattingEnabled = True
        Me.CbCategoria.Location = New System.Drawing.Point(184, 32)
        Me.CbCategoria.Name = "CbCategoria"
        Me.CbCategoria.Size = New System.Drawing.Size(182, 23)
        Me.CbCategoria.TabIndex = 2
        Me.CbCategoria.TabStop = False
        '
        'PanelA
        '
        Me.PanelA.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.PanelA.Controls.Add(Me.BtnCancelar)
        Me.PanelA.Controls.Add(Me.BtnExcuir)
        Me.PanelA.Controls.Add(Me.BtnExportarExcel)
        Me.PanelA.Controls.Add(Me.BtnInativar)
        Me.PanelA.Controls.Add(Me.BtnPromocao)
        Me.PanelA.Controls.Add(Me.BtnPrecoVenda)
        Me.PanelA.Controls.Add(Me.BtnCopiar)
        Me.PanelA.Controls.Add(Me.LbFiltro)
        Me.PanelA.Controls.Add(Me.BtnEditar)
        Me.PanelA.Controls.Add(Me.BtnIncluir)
        Me.PanelA.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelA.Location = New System.Drawing.Point(0, 0)
        Me.PanelA.Name = "PanelA"
        Me.PanelA.Size = New System.Drawing.Size(1148, 45)
        Me.PanelA.TabIndex = 52
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
        Me.BtnCancelar.Location = New System.Drawing.Point(519, 0)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(67, 45)
        Me.BtnCancelar.TabIndex = 55
        Me.BtnCancelar.TabStop = False
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
        Me.BtnExcuir.Location = New System.Drawing.Point(452, 0)
        Me.BtnExcuir.Name = "BtnExcuir"
        Me.BtnExcuir.Size = New System.Drawing.Size(67, 45)
        Me.BtnExcuir.TabIndex = 54
        Me.BtnExcuir.TabStop = False
        Me.BtnExcuir.Text = "Excluir"
        Me.BtnExcuir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnExcuir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.BtnExcuir, "Excluir (DELETE)")
        Me.BtnExcuir.UseVisualStyleBackColor = False
        '
        'BtnExportarExcel
        '
        Me.BtnExportarExcel.BackColor = System.Drawing.Color.Transparent
        Me.BtnExportarExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnExportarExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExportarExcel.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnExportarExcel.FlatAppearance.BorderSize = 0
        Me.BtnExportarExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExportarExcel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExportarExcel.ForeColor = System.Drawing.Color.White
        Me.BtnExportarExcel.Image = CType(resources.GetObject("BtnExportarExcel.Image"), System.Drawing.Image)
        Me.BtnExportarExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnExportarExcel.Location = New System.Drawing.Point(381, 0)
        Me.BtnExportarExcel.Name = "BtnExportarExcel"
        Me.BtnExportarExcel.Size = New System.Drawing.Size(71, 45)
        Me.BtnExportarExcel.TabIndex = 61
        Me.BtnExportarExcel.TabStop = False
        Me.BtnExportarExcel.Text = "Exportar"
        Me.BtnExportarExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnExportarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.BtnExportarExcel, "Exportar para Excel")
        Me.BtnExportarExcel.UseVisualStyleBackColor = False
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
        Me.BtnInativar.Location = New System.Drawing.Point(321, 0)
        Me.BtnInativar.Name = "BtnInativar"
        Me.BtnInativar.Size = New System.Drawing.Size(60, 45)
        Me.BtnInativar.TabIndex = 50
        Me.BtnInativar.TabStop = False
        Me.BtnInativar.Text = "Inativar"
        Me.BtnInativar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnInativar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.BtnInativar, "Inativar produto (F5)")
        Me.BtnInativar.UseVisualStyleBackColor = False
        '
        'BtnPromocao
        '
        Me.BtnPromocao.BackColor = System.Drawing.Color.Transparent
        Me.BtnPromocao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPromocao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPromocao.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnPromocao.FlatAppearance.BorderSize = 0
        Me.BtnPromocao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnPromocao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPromocao.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPromocao.ForeColor = System.Drawing.Color.White
        Me.BtnPromocao.Image = CType(resources.GetObject("BtnPromocao.Image"), System.Drawing.Image)
        Me.BtnPromocao.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPromocao.Location = New System.Drawing.Point(240, 0)
        Me.BtnPromocao.Name = "BtnPromocao"
        Me.BtnPromocao.Size = New System.Drawing.Size(81, 45)
        Me.BtnPromocao.TabIndex = 60
        Me.BtnPromocao.TabStop = False
        Me.BtnPromocao.Text = "Promoção"
        Me.BtnPromocao.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPromocao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.BtnPromocao, "Promoção (F6)")
        Me.BtnPromocao.UseVisualStyleBackColor = False
        '
        'BtnPrecoVenda
        '
        Me.BtnPrecoVenda.BackColor = System.Drawing.Color.Transparent
        Me.BtnPrecoVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPrecoVenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrecoVenda.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnPrecoVenda.FlatAppearance.BorderSize = 0
        Me.BtnPrecoVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnPrecoVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrecoVenda.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrecoVenda.ForeColor = System.Drawing.Color.White
        Me.BtnPrecoVenda.Image = CType(resources.GetObject("BtnPrecoVenda.Image"), System.Drawing.Image)
        Me.BtnPrecoVenda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPrecoVenda.Location = New System.Drawing.Point(180, 0)
        Me.BtnPrecoVenda.Name = "BtnPrecoVenda"
        Me.BtnPrecoVenda.Size = New System.Drawing.Size(60, 45)
        Me.BtnPrecoVenda.TabIndex = 59
        Me.BtnPrecoVenda.TabStop = False
        Me.BtnPrecoVenda.Text = "Preço"
        Me.BtnPrecoVenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPrecoVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.BtnPrecoVenda, "Preço de venda (F4)")
        Me.BtnPrecoVenda.UseVisualStyleBackColor = False
        '
        'BtnCopiar
        '
        Me.BtnCopiar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCopiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCopiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCopiar.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnCopiar.FlatAppearance.BorderSize = 0
        Me.BtnCopiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCopiar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCopiar.ForeColor = System.Drawing.Color.White
        Me.BtnCopiar.Image = CType(resources.GetObject("BtnCopiar.Image"), System.Drawing.Image)
        Me.BtnCopiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCopiar.Location = New System.Drawing.Point(120, 0)
        Me.BtnCopiar.Name = "BtnCopiar"
        Me.BtnCopiar.Size = New System.Drawing.Size(60, 45)
        Me.BtnCopiar.TabIndex = 58
        Me.BtnCopiar.TabStop = False
        Me.BtnCopiar.Text = "Copiar"
        Me.BtnCopiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCopiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.BtnCopiar, "Copiar resgistro (F3)")
        Me.BtnCopiar.UseVisualStyleBackColor = False
        '
        'LbFiltro
        '
        Me.LbFiltro.ActiveLinkColor = System.Drawing.Color.Yellow
        Me.LbFiltro.AutoSize = True
        Me.LbFiltro.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LbFiltro.LinkColor = System.Drawing.Color.White
        Me.LbFiltro.Location = New System.Drawing.Point(600, 11)
        Me.LbFiltro.Name = "LbFiltro"
        Me.LbFiltro.Size = New System.Drawing.Size(66, 19)
        Me.LbFiltro.TabIndex = 57
        Me.LbFiltro.TabStop = True
        Me.LbFiltro.Text = "Pesquisar"
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
        'Frm_cad_produtos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 627)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanelB)
        Me.Controls.Add(Me.PanelA)
        Me.KeyPreview = True
        Me.Name = "Frm_cad_produtos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Produtos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelB.ResumeLayout(False)
        Me.PanelB.PerformLayout()
        Me.PanelA.ResumeLayout(False)
        Me.PanelA.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents PanelB As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Btnfiltro As Button
    Friend WithEvents TxtProduto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtFornecedor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CbMarca As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CbCategoria As ComboBox
    Friend WithEvents PanelA As Panel
    Friend WithEvents LbFiltro As LinkLabel
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnExcuir As Button
    Friend WithEvents BtnInativar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnIncluir As Button
    Friend WithEvents BtnExportarExcel As Button
    Friend WithEvents BtnPromocao As Button
    Friend WithEvents BtnPrecoVenda As Button
    Friend WithEvents BtnCopiar As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label8 As Label
    Friend WithEvents CbStatus As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CbControlaEst As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CbPromocao As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CbLocalizacao As ComboBox
End Class
