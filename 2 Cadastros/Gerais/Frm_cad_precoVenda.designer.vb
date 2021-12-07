<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_cad_precoVenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_cad_precoVenda))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelPercent = New System.Windows.Forms.Label()
        Me.BtnPesquisarProd = New System.Windows.Forms.Button()
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.TxtDescricao = New System.Windows.Forms.TextBox()
        Me.CboxAutomatico = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtPcusto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtMarkup = New System.Windows.Forms.TextBox()
        Me.TxtPvenda = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelPercent)
        Me.GroupBox1.Controls.Add(Me.BtnPesquisarProd)
        Me.GroupBox1.Controls.Add(Me.TxtCod)
        Me.GroupBox1.Controls.Add(Me.TxtDescricao)
        Me.GroupBox1.Controls.Add(Me.CboxAutomatico)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TxtPcusto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TxtMarkup)
        Me.GroupBox1.Controls.Add(Me.TxtPvenda)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(577, 142)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        '
        'LabelPercent
        '
        Me.LabelPercent.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelPercent.ForeColor = System.Drawing.Color.Blue
        Me.LabelPercent.Location = New System.Drawing.Point(291, 62)
        Me.LabelPercent.Name = "LabelPercent"
        Me.LabelPercent.Size = New System.Drawing.Size(274, 25)
        Me.LabelPercent.TabIndex = 53
        Me.LabelPercent.Text = "Inserir % no formato decimal.  Ex: 10% inserir 0,1"
        Me.LabelPercent.Visible = False
        '
        'BtnPesquisarProd
        '
        Me.BtnPesquisarProd.BackColor = System.Drawing.Color.Transparent
        Me.BtnPesquisarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnPesquisarProd.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnPesquisarProd.FlatAppearance.BorderSize = 0
        Me.BtnPesquisarProd.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnPesquisarProd.Location = New System.Drawing.Point(538, 19)
        Me.BtnPesquisarProd.Name = "BtnPesquisarProd"
        Me.BtnPesquisarProd.Size = New System.Drawing.Size(26, 27)
        Me.BtnPesquisarProd.TabIndex = 52
        Me.BtnPesquisarProd.TabStop = False
        Me.BtnPesquisarProd.Text = "..."
        Me.BtnPesquisarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BtnPesquisarProd, "Pesquisar (F5)")
        Me.BtnPesquisarProd.UseVisualStyleBackColor = False
        '
        'TxtCod
        '
        Me.TxtCod.Enabled = False
        Me.TxtCod.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtCod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtCod.Location = New System.Drawing.Point(104, 20)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(62, 25)
        Me.TxtCod.TabIndex = 1
        '
        'TxtDescricao
        '
        Me.TxtDescricao.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtDescricao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtDescricao.Location = New System.Drawing.Point(246, 20)
        Me.TxtDescricao.Name = "TxtDescricao"
        Me.TxtDescricao.Size = New System.Drawing.Size(292, 25)
        Me.TxtDescricao.TabIndex = 2
        '
        'CboxAutomatico
        '
        Me.CboxAutomatico.AutoSize = True
        Me.CboxAutomatico.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CboxAutomatico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.CboxAutomatico.Location = New System.Drawing.Point(196, 61)
        Me.CboxAutomatico.Name = "CboxAutomatico"
        Me.CboxAutomatico.Size = New System.Drawing.Size(98, 21)
        Me.CboxAutomatico.TabIndex = 6
        Me.CboxAutomatico.Text = "Automático"
        Me.CboxAutomatico.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(172, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Descrição:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(14, 99)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 17)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Preço Custo:"
        '
        'TxtPcusto
        '
        Me.TxtPcusto.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtPcusto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtPcusto.Location = New System.Drawing.Point(104, 96)
        Me.TxtPcusto.Name = "TxtPcusto"
        Me.TxtPcusto.Size = New System.Drawing.Size(86, 25)
        Me.TxtPcusto.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Código Prod:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(12, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 17)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Preço Venda:"
        '
        'TxtMarkup
        '
        Me.TxtMarkup.Enabled = False
        Me.TxtMarkup.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtMarkup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtMarkup.Location = New System.Drawing.Point(276, 96)
        Me.TxtMarkup.Name = "TxtMarkup"
        Me.TxtMarkup.Size = New System.Drawing.Size(63, 25)
        Me.TxtMarkup.TabIndex = 5
        '
        'TxtPvenda
        '
        Me.TxtPvenda.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtPvenda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtPvenda.Location = New System.Drawing.Point(104, 58)
        Me.TxtPvenda.Name = "TxtPvenda"
        Me.TxtPvenda.Size = New System.Drawing.Size(86, 25)
        Me.TxtPvenda.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(199, 100)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 17)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "Markup %:"
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
        Me.BtnSalvar.Location = New System.Drawing.Point(22, 206)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(131, 38)
        Me.BtnSalvar.TabIndex = 56
        Me.BtnSalvar.Text = "SALVAR (ENTER)"
        Me.BtnSalvar.UseVisualStyleBackColor = False
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
        Me.BtnCancelar.Location = New System.Drawing.Point(183, 206)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(131, 38)
        Me.BtnCancelar.TabIndex = 55
        Me.BtnCancelar.Text = "CANCELAR (ESC)"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BtnClose)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(635, 30)
        Me.Panel2.TabIndex = 57
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
        Me.BtnClose.Location = New System.Drawing.Point(605, 0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(30, 30)
        Me.BtnClose.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.BtnClose, "Fechar")
        Me.BtnClose.UseVisualStyleBackColor = False
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
        Me.Label15.Text = "Preço de venda"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Frm_cad_precoVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(635, 274)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BtnSalvar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_cad_precoVenda"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnPesquisarProd As Button
    Friend WithEvents TxtCod As TextBox
    Friend WithEvents TxtDescricao As TextBox
    Friend WithEvents CboxAutomatico As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtPcusto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtMarkup As TextBox
    Friend WithEvents TxtPvenda As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LabelPercent As Label
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents Label15 As Label
End Class
