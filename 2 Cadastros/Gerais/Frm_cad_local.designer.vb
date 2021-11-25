<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_cad_local
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_cad_local))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnIncluir = New System.Windows.Forms.ToolStripButton()
        Me.BtnEditar = New System.Windows.Forms.ToolStripButton()
        Me.BtnExcuir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.TxtPesquisar = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnSelecionar = New System.Windows.Forms.Button()
        Me.Panel_Atalhos = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        AddHandler BtnCancelar.Click, AddressOf Me.BtnCancelar_Click_2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnIncluir, Me.BtnEditar, Me.BtnExcuir, Me.ToolStripSeparator1, Me.ToolStripLabel3, Me.TxtPesquisar, Me.ToolStripSeparator3, BtnCancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1087, 53)
        Me.ToolStrip1.TabIndex = 57
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnIncluir
        '
        Me.BtnIncluir.AutoSize = False
        Me.BtnIncluir.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        Me.BtnEditar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        'BtnExcuir
        '
        Me.BtnExcuir.AutoSize = False
        Me.BtnExcuir.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 53)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.AutoSize = False
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(60, 50)
        Me.ToolStripLabel3.Text = " Pesquisar: "
        '
        'TxtPesquisar
        '
        Me.TxtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPesquisar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtPesquisar.Name = "TxtPesquisar"
        Me.TxtPesquisar.Size = New System.Drawing.Size(150, 53)
        Me.TxtPesquisar.ToolTipText = "Digite o nome do Local"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 53)
        '
        'BtnSelecionar
        '
        Me.BtnSelecionar.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnSelecionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSelecionar.FlatAppearance.BorderSize = 0
        Me.BtnSelecionar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BtnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelecionar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnSelecionar.Image = CType(resources.GetObject("BtnSelecionar.Image"), System.Drawing.Image)
        Me.BtnSelecionar.Location = New System.Drawing.Point(476, 2)
        Me.BtnSelecionar.Name = "BtnSelecionar"
        Me.BtnSelecionar.Size = New System.Drawing.Size(70, 48)
        Me.BtnSelecionar.TabIndex = 60
        Me.BtnSelecionar.TabStop = False
        Me.BtnSelecionar.Text = "Selecionar"
        Me.BtnSelecionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSelecionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnSelecionar.UseVisualStyleBackColor = False
        Me.BtnSelecionar.Visible = False
        '
        'Panel_Atalhos
        '
        Me.Panel_Atalhos.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel_Atalhos.Controls.Add(Me.Label5)
        Me.Panel_Atalhos.Controls.Add(Me.Label4)
        Me.Panel_Atalhos.Controls.Add(Me.Label2)
        Me.Panel_Atalhos.Controls.Add(Me.Label1)
        Me.Panel_Atalhos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Atalhos.Location = New System.Drawing.Point(0, 567)
        Me.Panel_Atalhos.Name = "Panel_Atalhos"
        Me.Panel_Atalhos.Size = New System.Drawing.Size(1087, 68)
        Me.Panel_Atalhos.TabIndex = 61
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(397, 21)
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
        Me.Label4.Location = New System.Drawing.Point(241, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 30)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Excluir: (Delete)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.GroupBox1.Size = New System.Drawing.Size(1087, 514)
        Me.GroupBox1.TabIndex = 62
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrid.ColumnHeadersHeight = 30
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
        Me.DataGrid.Size = New System.Drawing.Size(1081, 495)
        Me.DataGrid.TabIndex = 4
        '
        'Frm_cad_local
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 635)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel_Atalhos)
        Me.Controls.Add(Me.BtnSelecionar)
        Me.Controls.Add(Me.ToolStrip1)
        Me.KeyPreview = True
        Me.Name = "Frm_cad_local"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Locais de Estoque"
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
    Friend WithEvents BtnExcuir As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents TxtPesquisar As ToolStripTextBox
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents BtnSelecionar As Button
    Friend WithEvents Panel_Atalhos As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGrid As DataGridView
End Class
