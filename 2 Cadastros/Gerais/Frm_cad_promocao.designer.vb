<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_cad_promocao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_cad_promocao))
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelPercent = New System.Windows.Forms.Label()
        Me.RbPercent = New System.Windows.Forms.RadioButton()
        Me.RbValor = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPercDesc = New System.Windows.Forms.TextBox()
        Me.TxtPcusto = New System.Windows.Forms.TextBox()
        Me.TxtPvenda = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnPesquisarProd = New System.Windows.Forms.Button()
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.TxtDescricao = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataFim = New System.Windows.Forms.DateTimePicker()
        Me.DataInicio = New System.Windows.Forms.DateTimePicker()
        Me.TxtPpromocao = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox6.Controls.Add(Me.BtnCancelar)
        Me.GroupBox6.Controls.Add(Me.BtnSalvar)
        Me.GroupBox6.Location = New System.Drawing.Point(20, 2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(623, 60)
        Me.GroupBox6.TabIndex = 55
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
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.LabelPercent)
        Me.GroupBox4.Controls.Add(Me.RbPercent)
        Me.GroupBox4.Controls.Add(Me.RbValor)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.TxtPercDesc)
        Me.GroupBox4.Controls.Add(Me.TxtPcusto)
        Me.GroupBox4.Controls.Add(Me.TxtPvenda)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.BtnPesquisarProd)
        Me.GroupBox4.Controls.Add(Me.TxtCod)
        Me.GroupBox4.Controls.Add(Me.TxtDescricao)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.DataFim)
        Me.GroupBox4.Controls.Add(Me.DataInicio)
        Me.GroupBox4.Controls.Add(Me.TxtPpromocao)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(21, 62)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(622, 225)
        Me.GroupBox4.TabIndex = 54
        Me.GroupBox4.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(278, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 19)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Preço Custo:"
        '
        'LabelPercent
        '
        Me.LabelPercent.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelPercent.ForeColor = System.Drawing.Color.Blue
        Me.LabelPercent.Location = New System.Drawing.Point(216, 150)
        Me.LabelPercent.Name = "LabelPercent"
        Me.LabelPercent.Size = New System.Drawing.Size(288, 16)
        Me.LabelPercent.TabIndex = 62
        Me.LabelPercent.Text = "Inserir % no formato decimal.  Ex: 10% inserir 0,1"
        Me.LabelPercent.Visible = False
        '
        'RbPercent
        '
        Me.RbPercent.AutoSize = True
        Me.RbPercent.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbPercent.Location = New System.Drawing.Point(368, 105)
        Me.RbPercent.Name = "RbPercent"
        Me.RbPercent.Size = New System.Drawing.Size(109, 21)
        Me.RbPercent.TabIndex = 6
        Me.RbPercent.Text = "Percentual (%)"
        Me.RbPercent.UseVisualStyleBackColor = True
        '
        'RbValor
        '
        Me.RbValor.AutoSize = True
        Me.RbValor.Checked = True
        Me.RbValor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbValor.Location = New System.Drawing.Point(260, 105)
        Me.RbValor.Name = "RbValor"
        Me.RbValor.Size = New System.Drawing.Size(83, 21)
        Me.RbValor.TabIndex = 5
        Me.RbValor.TabStop = True
        Me.RbValor.Text = "Valor (R$)"
        Me.RbValor.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(52, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "% Desconto"
        '
        'TxtPercDesc
        '
        Me.TxtPercDesc.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtPercDesc.ForeColor = System.Drawing.Color.Black
        Me.TxtPercDesc.Location = New System.Drawing.Point(136, 145)
        Me.TxtPercDesc.Name = "TxtPercDesc"
        Me.TxtPercDesc.Size = New System.Drawing.Size(75, 25)
        Me.TxtPercDesc.TabIndex = 8
        '
        'TxtPcusto
        '
        Me.TxtPcusto.Enabled = False
        Me.TxtPcusto.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtPcusto.ForeColor = System.Drawing.Color.Black
        Me.TxtPcusto.Location = New System.Drawing.Point(368, 65)
        Me.TxtPcusto.Name = "TxtPcusto"
        Me.TxtPcusto.Size = New System.Drawing.Size(105, 25)
        Me.TxtPcusto.TabIndex = 12
        '
        'TxtPvenda
        '
        Me.TxtPvenda.Enabled = False
        Me.TxtPvenda.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtPvenda.ForeColor = System.Drawing.Color.Black
        Me.TxtPvenda.Location = New System.Drawing.Point(136, 65)
        Me.TxtPvenda.Name = "TxtPvenda"
        Me.TxtPvenda.Size = New System.Drawing.Size(105, 25)
        Me.TxtPvenda.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(44, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 19)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "Preço Venda:"
        '
        'BtnPesquisarProd
        '
        Me.BtnPesquisarProd.BackColor = System.Drawing.Color.Transparent
        Me.BtnPesquisarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnPesquisarProd.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnPesquisarProd.FlatAppearance.BorderSize = 0
        Me.BtnPesquisarProd.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnPesquisarProd.Location = New System.Drawing.Point(582, 24)
        Me.BtnPesquisarProd.Name = "BtnPesquisarProd"
        Me.BtnPesquisarProd.Size = New System.Drawing.Size(26, 27)
        Me.BtnPesquisarProd.TabIndex = 3
        Me.BtnPesquisarProd.TabStop = False
        Me.BtnPesquisarProd.Text = "..."
        Me.BtnPesquisarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BtnPesquisarProd, "Pesquisar  (F5)")
        Me.BtnPesquisarProd.UseVisualStyleBackColor = False
        '
        'TxtCod
        '
        Me.TxtCod.Enabled = False
        Me.TxtCod.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtCod.ForeColor = System.Drawing.Color.Black
        Me.TxtCod.Location = New System.Drawing.Point(136, 25)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(62, 25)
        Me.TxtCod.TabIndex = 1
        '
        'TxtDescricao
        '
        Me.TxtDescricao.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtDescricao.ForeColor = System.Drawing.Color.Black
        Me.TxtDescricao.Location = New System.Drawing.Point(278, 25)
        Me.TxtDescricao.Name = "TxtDescricao"
        Me.TxtDescricao.Size = New System.Drawing.Size(304, 25)
        Me.TxtDescricao.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(204, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 19)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Descrição:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(45, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 19)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Código Prod:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(8, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 19)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Preço Promocional"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(282, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 19)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Data Final:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(52, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 19)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Data Inicial:"
        '
        'DataFim
        '
        Me.DataFim.CalendarFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataFim.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DataFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataFim.Location = New System.Drawing.Point(358, 185)
        Me.DataFim.Name = "DataFim"
        Me.DataFim.Size = New System.Drawing.Size(105, 25)
        Me.DataFim.TabIndex = 10
        '
        'DataInicio
        '
        Me.DataInicio.CalendarFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataInicio.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataInicio.Location = New System.Drawing.Point(136, 185)
        Me.DataInicio.Name = "DataInicio"
        Me.DataInicio.Size = New System.Drawing.Size(105, 25)
        Me.DataInicio.TabIndex = 9
        '
        'TxtPpromocao
        '
        Me.TxtPpromocao.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtPpromocao.ForeColor = System.Drawing.Color.Black
        Me.TxtPpromocao.Location = New System.Drawing.Point(136, 105)
        Me.TxtPpromocao.Name = "TxtPpromocao"
        Me.TxtPpromocao.Size = New System.Drawing.Size(105, 25)
        Me.TxtPpromocao.TabIndex = 7
        '
        'Frm_cad_promocao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 303)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_cad_promocao"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Promoção"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RbPercent As RadioButton
    Friend WithEvents RbValor As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPercDesc As TextBox
    Friend WithEvents TxtPcusto As TextBox
    Friend WithEvents TxtPvenda As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents BtnPesquisarProd As Button
    Friend WithEvents TxtCod As TextBox
    Friend WithEvents TxtDescricao As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataFim As DateTimePicker
    Friend WithEvents DataInicio As DateTimePicker
    Friend WithEvents TxtPpromocao As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LabelPercent As Label
    Friend WithEvents Label6 As Label
End Class
