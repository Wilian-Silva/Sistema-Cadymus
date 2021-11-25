<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_cad_clientes
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
        Dim BtnCancelar As System.Windows.Forms.ToolStripButton
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_cad_clientes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnIncluir = New System.Windows.Forms.ToolStripButton()
        Me.BtnEditar = New System.Windows.Forms.ToolStripButton()
        Me.BtnCopiar = New System.Windows.Forms.ToolStripButton()
        Me.BtnLimiteDebito = New System.Windows.Forms.ToolStripButton()
        Me.BtnInativar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnExcuir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.BtnTodos = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnAtivos = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnInativos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.TxtPesquisar = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel_Atalhos = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        BtnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel_Atalhos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCancelar
        '
        BtnCancelar.AutoSize = False
        BtnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        BtnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        BtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnCancelar.Size = New System.Drawing.Size(60, 50)
        BtnCancelar.Text = "Sair"
        BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        BtnCancelar.ToolTipText = "Tecla de Atalho (ESC)"
        AddHandler BtnCancelar.Click, AddressOf Me.BtnCancelar_Click_1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnIncluir, Me.BtnEditar, Me.BtnCopiar, Me.BtnLimiteDebito, Me.BtnInativar, Me.ToolStripSeparator1, Me.BtnExcuir, Me.ToolStripSeparator2, Me.ToolStripSplitButton1, Me.ToolStripLabel3, Me.TxtPesquisar, Me.ToolStripSeparator4, BtnCancelar, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1362, 53)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnIncluir
        '
        Me.BtnIncluir.AutoSize = False
        Me.BtnIncluir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIncluir.Image = CType(resources.GetObject("BtnIncluir.Image"), System.Drawing.Image)
        Me.BtnIncluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnIncluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnIncluir.Name = "BtnIncluir"
        Me.BtnIncluir.Size = New System.Drawing.Size(60, 50)
        Me.BtnIncluir.Text = "Incluir"
        Me.BtnIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnIncluir.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.BtnIncluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnIncluir.ToolTipText = "Tecla de Atalho (F1)"
        '
        'BtnEditar
        '
        Me.BtnEditar.AutoSize = False
        Me.BtnEditar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnEditar.Size = New System.Drawing.Size(60, 50)
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnEditar.ToolTipText = "Tecla de Atalho (F2)"
        '
        'BtnCopiar
        '
        Me.BtnCopiar.AutoSize = False
        Me.BtnCopiar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCopiar.Image = CType(resources.GetObject("BtnCopiar.Image"), System.Drawing.Image)
        Me.BtnCopiar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnCopiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCopiar.Name = "BtnCopiar"
        Me.BtnCopiar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnCopiar.Size = New System.Drawing.Size(60, 50)
        Me.BtnCopiar.Text = "Copiar"
        Me.BtnCopiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCopiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnCopiar.ToolTipText = "Tecla de Atalho (F3)"
        '
        'BtnLimiteDebito
        '
        Me.BtnLimiteDebito.AutoSize = False
        Me.BtnLimiteDebito.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimiteDebito.Image = CType(resources.GetObject("BtnLimiteDebito.Image"), System.Drawing.Image)
        Me.BtnLimiteDebito.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnLimiteDebito.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnLimiteDebito.Name = "BtnLimiteDebito"
        Me.BtnLimiteDebito.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnLimiteDebito.Size = New System.Drawing.Size(80, 50)
        Me.BtnLimiteDebito.Text = "Limite Débito"
        Me.BtnLimiteDebito.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnLimiteDebito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnLimiteDebito.ToolTipText = "Tecla de Atalho (F4)"
        '
        'BtnInativar
        '
        Me.BtnInativar.AutoSize = False
        Me.BtnInativar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInativar.Image = CType(resources.GetObject("BtnInativar.Image"), System.Drawing.Image)
        Me.BtnInativar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnInativar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnInativar.Name = "BtnInativar"
        Me.BtnInativar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnInativar.Size = New System.Drawing.Size(90, 50)
        Me.BtnInativar.Text = "Inativar Cliente"
        Me.BtnInativar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnInativar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnInativar.ToolTipText = "Tecla de Atalho (F5)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 53)
        '
        'BtnExcuir
        '
        Me.BtnExcuir.AutoSize = False
        Me.BtnExcuir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcuir.ForeColor = System.Drawing.Color.Black
        Me.BtnExcuir.Image = CType(resources.GetObject("BtnExcuir.Image"), System.Drawing.Image)
        Me.BtnExcuir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnExcuir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnExcuir.Name = "BtnExcuir"
        Me.BtnExcuir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnExcuir.Size = New System.Drawing.Size(60, 50)
        Me.BtnExcuir.Text = "Excluir"
        Me.BtnExcuir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnExcuir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnExcuir.ToolTipText = "Tecla de Atalho (Delete)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 53)
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnTodos, Me.BtnAtivos, Me.BtnInativos})
        Me.ToolStripSplitButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(55, 50)
        Me.ToolStripSplitButton1.Text = "Exibir:"
        '
        'BtnTodos
        '
        Me.BtnTodos.Name = "BtnTodos"
        Me.BtnTodos.Size = New System.Drawing.Size(160, 22)
        Me.BtnTodos.Text = "Todos Clientes"
        '
        'BtnAtivos
        '
        Me.BtnAtivos.Name = "BtnAtivos"
        Me.BtnAtivos.Size = New System.Drawing.Size(160, 22)
        Me.BtnAtivos.Text = "Clientes Ativos"
        '
        'BtnInativos
        '
        Me.BtnInativos.Name = "BtnInativos"
        Me.BtnInativos.Size = New System.Drawing.Size(160, 22)
        Me.BtnInativos.Text = "Clientes Inativos"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(78, 50)
        Me.ToolStripLabel3.Text = "     Pesquisar: "
        '
        'TxtPesquisar
        '
        Me.TxtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPesquisar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtPesquisar.Name = "TxtPesquisar"
        Me.TxtPesquisar.Size = New System.Drawing.Size(250, 53)
        Me.TxtPesquisar.ToolTipText = "Digite o nome do cliente"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 53)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 53)
        '
        'Panel_Atalhos
        '
        Me.Panel_Atalhos.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel_Atalhos.Controls.Add(Me.Label5)
        Me.Panel_Atalhos.Controls.Add(Me.Label4)
        Me.Panel_Atalhos.Controls.Add(Me.Label9)
        Me.Panel_Atalhos.Controls.Add(Me.Label3)
        Me.Panel_Atalhos.Controls.Add(Me.Label8)
        Me.Panel_Atalhos.Controls.Add(Me.Label2)
        Me.Panel_Atalhos.Controls.Add(Me.Label1)
        Me.Panel_Atalhos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Atalhos.Location = New System.Drawing.Point(0, 690)
        Me.Panel_Atalhos.Name = "Panel_Atalhos"
        Me.Panel_Atalhos.Size = New System.Drawing.Size(1362, 73)
        Me.Panel_Atalhos.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(856, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 30)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Sair: (Esc)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(700, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 30)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Excluir: (Delete)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(519, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(169, 30)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Inativar Cliente (F5)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(359, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 30)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Limite Débito: (F4)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(245, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 30)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Copiar: (F3)"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(132, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Editar: (F2)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Incluir: (F1)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.DataGrid)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1362, 637)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrid.ColumnHeadersHeight = 50
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid.EnableHeadersVisualStyles = False
        Me.DataGrid.Location = New System.Drawing.Point(3, 16)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.RowTemplate.Height = 25
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(1356, 618)
        Me.DataGrid.TabIndex = 4
        '
        'Frm_cad_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 763)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel_Atalhos)
        Me.Controls.Add(Me.ToolStrip1)
        Me.KeyPreview = True
        Me.Name = "Frm_cad_clientes"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel_Atalhos.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnIncluir As ToolStripButton
    Friend WithEvents BtnEditar As ToolStripButton
    Friend WithEvents BtnCopiar As ToolStripButton
    Friend WithEvents BtnLimiteDebito As ToolStripButton
    Friend WithEvents BtnInativar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BtnExcuir As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents BtnTodos As ToolStripMenuItem
    Friend WithEvents BtnAtivos As ToolStripMenuItem
    Friend WithEvents BtnInativos As ToolStripMenuItem
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents TxtPesquisar As ToolStripTextBox
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents Panel_Atalhos As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGrid As DataGridView
End Class
