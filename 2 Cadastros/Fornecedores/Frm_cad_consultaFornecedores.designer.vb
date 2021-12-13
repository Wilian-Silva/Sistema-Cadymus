<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_cad_consultaFornecedores
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_cad_consultaFornecedores))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.PanelB = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btnfiltro = New System.Windows.Forms.Button()
        Me.Txtnome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCidade = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbSitucao = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbTipo = New System.Windows.Forms.ComboBox()
        Me.PanelA = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSelecionar = New System.Windows.Forms.Button()
        Me.LbFiltro = New System.Windows.Forms.LinkLabel()
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
        Me.GroupBox1.Location = New System.Drawing.Point(0, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(844, 346)
        Me.GroupBox1.TabIndex = 57
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
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(138, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(118, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGrid.ColumnHeadersHeight = 30
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(218, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid.EnableHeadersVisualStyles = False
        Me.DataGrid.Location = New System.Drawing.Point(3, 16)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.RowTemplate.Height = 30
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(838, 327)
        Me.DataGrid.TabIndex = 0
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
        Me.PanelB.Controls.Add(Me.CbTipo)
        Me.PanelB.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelB.Location = New System.Drawing.Point(0, 45)
        Me.PanelB.Name = "PanelB"
        Me.PanelB.Size = New System.Drawing.Size(844, 70)
        Me.PanelB.TabIndex = 56
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(7, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Nome:"
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
        Me.Btnfiltro.Location = New System.Drawing.Point(746, 33)
        Me.Btnfiltro.Name = "Btnfiltro"
        Me.Btnfiltro.Size = New System.Drawing.Size(30, 25)
        Me.Btnfiltro.TabIndex = 67
        Me.Btnfiltro.TabStop = False
        Me.Btnfiltro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btnfiltro.UseVisualStyleBackColor = False
        '
        'Txtnome
        '
        Me.Txtnome.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Txtnome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Txtnome.Location = New System.Drawing.Point(6, 31)
        Me.Txtnome.Multiline = True
        Me.Txtnome.Name = "Txtnome"
        Me.Txtnome.Size = New System.Drawing.Size(165, 25)
        Me.Txtnome.TabIndex = 61
        Me.Txtnome.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(539, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Cidade:"
        '
        'TxtCidade
        '
        Me.TxtCidade.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.TxtCidade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtCidade.Location = New System.Drawing.Point(537, 33)
        Me.TxtCidade.Multiline = True
        Me.TxtCidade.Name = "TxtCidade"
        Me.TxtCidade.Size = New System.Drawing.Size(203, 25)
        Me.TxtCidade.TabIndex = 66
        Me.TxtCidade.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(365, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Situação:"
        '
        'CbSitucao
        '
        Me.CbSitucao.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbSitucao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.CbSitucao.FormattingEnabled = True
        Me.CbSitucao.Items.AddRange(New Object() {"", "Ativo", "Inativo"})
        Me.CbSitucao.Location = New System.Drawing.Point(362, 33)
        Me.CbSitucao.Name = "CbSitucao"
        Me.CbSitucao.Size = New System.Drawing.Size(131, 23)
        Me.CbSitucao.TabIndex = 65
        Me.CbSitucao.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(201, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Tipo cadastro:"
        '
        'CbTipo
        '
        Me.CbTipo.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.CbTipo.FormattingEnabled = True
        Me.CbTipo.Items.AddRange(New Object() {"", "Pessoa Física", "Pessoa Jurídica"})
        Me.CbTipo.Location = New System.Drawing.Point(199, 33)
        Me.CbTipo.Name = "CbTipo"
        Me.CbTipo.Size = New System.Drawing.Size(131, 23)
        Me.CbTipo.TabIndex = 63
        Me.CbTipo.TabStop = False
        '
        'PanelA
        '
        Me.PanelA.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.PanelA.Controls.Add(Me.BtnCancelar)
        Me.PanelA.Controls.Add(Me.BtnSelecionar)
        Me.PanelA.Controls.Add(Me.LbFiltro)
        Me.PanelA.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelA.Location = New System.Drawing.Point(0, 0)
        Me.PanelA.Name = "PanelA"
        Me.PanelA.Size = New System.Drawing.Size(844, 45)
        Me.PanelA.TabIndex = 55
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
        Me.BtnCancelar.Location = New System.Drawing.Point(71, 0)
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
        Me.BtnSelecionar.FlatAppearance.BorderSize = 0
        Me.BtnSelecionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelecionar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelecionar.ForeColor = System.Drawing.Color.White
        Me.BtnSelecionar.Image = CType(resources.GetObject("BtnSelecionar.Image"), System.Drawing.Image)
        Me.BtnSelecionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSelecionar.Location = New System.Drawing.Point(0, 0)
        Me.BtnSelecionar.Name = "BtnSelecionar"
        Me.BtnSelecionar.Size = New System.Drawing.Size(71, 45)
        Me.BtnSelecionar.TabIndex = 52
        Me.BtnSelecionar.TabStop = False
        Me.BtnSelecionar.Text = "Selecionar"
        Me.BtnSelecionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSelecionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnSelecionar.UseVisualStyleBackColor = False
        '
        'LbFiltro
        '
        Me.LbFiltro.ActiveLinkColor = System.Drawing.Color.Yellow
        Me.LbFiltro.AutoSize = True
        Me.LbFiltro.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.LbFiltro.LinkColor = System.Drawing.Color.White
        Me.LbFiltro.Location = New System.Drawing.Point(155, 15)
        Me.LbFiltro.Name = "LbFiltro"
        Me.LbFiltro.Size = New System.Drawing.Size(66, 19)
        Me.LbFiltro.TabIndex = 57
        Me.LbFiltro.TabStop = True
        Me.LbFiltro.Text = "Pesquisar"
        '
        'Frm_cad_consultaFornecedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 461)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanelB)
        Me.Controls.Add(Me.PanelA)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "Frm_cad_consultaFornecedores"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Fornecedores"
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
    Friend WithEvents PanelA As Panel
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnSelecionar As Button
    Friend WithEvents LbFiltro As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents Btnfiltro As Button
    Friend WithEvents Txtnome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCidade As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CbSitucao As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CbTipo As ComboBox
End Class
