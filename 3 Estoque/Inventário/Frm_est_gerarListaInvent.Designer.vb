<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_est_gerarListaInvent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_est_gerarListaInvent))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtIdCodFinal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtIdCodInicial = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnItemFim = New System.Windows.Forms.Button()
        Me.BtnItemInic = New System.Windows.Forms.Button()
        Me.BtnCategInicial = New System.Windows.Forms.Button()
        Me.CboxSaldoZero = New System.Windows.Forms.CheckBox()
        Me.DataInv = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtIdCategoriaFinal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtIdCategoriaInicial = New System.Windows.Forms.TextBox()
        Me.TxtIdLocalFinal = New System.Windows.Forms.TextBox()
        Me.TxtIdLocalInicial = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAdicionar = New System.Windows.Forms.Button()
        Me.BtnCategFinal = New System.Windows.Forms.Button()
        Me.BtnLocalIncial = New System.Windows.Forms.Button()
        Me.BtnLocalFinal = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BtnClose)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(493, 30)
        Me.Panel2.TabIndex = 45
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
        Me.BtnClose.Location = New System.Drawing.Point(463, 0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(30, 30)
        Me.BtnClose.TabIndex = 1
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
        Me.Label15.Text = "Gerar lista de inventário"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtIdCodFinal
        '
        Me.TxtIdCodFinal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtIdCodFinal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtIdCodFinal.Location = New System.Drawing.Point(273, 69)
        Me.TxtIdCodFinal.Name = "TxtIdCodFinal"
        Me.TxtIdCodFinal.Size = New System.Drawing.Size(73, 25)
        Me.TxtIdCodFinal.TabIndex = 3
        Me.TxtIdCodFinal.Text = "99999"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(24, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Item:"
        '
        'TxtIdCodInicial
        '
        Me.TxtIdCodInicial.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtIdCodInicial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtIdCodInicial.Location = New System.Drawing.Point(151, 69)
        Me.TxtIdCodInicial.Name = "TxtIdCodInicial"
        Me.TxtIdCodInicial.Size = New System.Drawing.Size(72, 25)
        Me.TxtIdCodInicial.TabIndex = 1
        Me.TxtIdCodInicial.Text = "0"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnLocalFinal)
        Me.GroupBox2.Controls.Add(Me.BtnLocalIncial)
        Me.GroupBox2.Controls.Add(Me.BtnCategFinal)
        Me.GroupBox2.Controls.Add(Me.BtnItemFim)
        Me.GroupBox2.Controls.Add(Me.BtnItemInic)
        Me.GroupBox2.Controls.Add(Me.BtnCategInicial)
        Me.GroupBox2.Controls.Add(Me.CboxSaldoZero)
        Me.GroupBox2.Controls.Add(Me.DataInv)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtIdCodInicial)
        Me.GroupBox2.Controls.Add(Me.TxtIdCodFinal)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.TxtIdCategoriaFinal)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtIdCategoriaInicial)
        Me.GroupBox2.Controls.Add(Me.TxtIdLocalFinal)
        Me.GroupBox2.Controls.Add(Me.TxtIdLocalInicial)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(24, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(452, 220)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Parâmetros"
        '
        'BtnItemFim
        '
        Me.BtnItemFim.BackColor = System.Drawing.Color.Transparent
        Me.BtnItemFim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnItemFim.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnItemFim.FlatAppearance.BorderSize = 0
        Me.BtnItemFim.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnItemFim.Location = New System.Drawing.Point(346, 68)
        Me.BtnItemFim.Name = "BtnItemFim"
        Me.BtnItemFim.Size = New System.Drawing.Size(26, 27)
        Me.BtnItemFim.TabIndex = 4
        Me.BtnItemFim.Text = "..."
        Me.BtnItemFim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnItemFim.UseVisualStyleBackColor = False
        '
        'BtnItemInic
        '
        Me.BtnItemInic.BackColor = System.Drawing.Color.Transparent
        Me.BtnItemInic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnItemInic.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnItemInic.FlatAppearance.BorderSize = 0
        Me.BtnItemInic.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnItemInic.Location = New System.Drawing.Point(223, 68)
        Me.BtnItemInic.Name = "BtnItemInic"
        Me.BtnItemInic.Size = New System.Drawing.Size(26, 27)
        Me.BtnItemInic.TabIndex = 2
        Me.BtnItemInic.Text = "..."
        Me.BtnItemInic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnItemInic.UseVisualStyleBackColor = False
        '
        'BtnCategInicial
        '
        Me.BtnCategInicial.BackColor = System.Drawing.Color.Transparent
        Me.BtnCategInicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnCategInicial.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnCategInicial.FlatAppearance.BorderSize = 0
        Me.BtnCategInicial.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnCategInicial.Location = New System.Drawing.Point(223, 101)
        Me.BtnCategInicial.Name = "BtnCategInicial"
        Me.BtnCategInicial.Size = New System.Drawing.Size(26, 27)
        Me.BtnCategInicial.TabIndex = 6
        Me.BtnCategInicial.Text = "..."
        Me.BtnCategInicial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCategInicial.UseVisualStyleBackColor = False
        '
        'CboxSaldoZero
        '
        Me.CboxSaldoZero.AutoSize = True
        Me.CboxSaldoZero.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CboxSaldoZero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.CboxSaldoZero.Location = New System.Drawing.Point(28, 182)
        Me.CboxSaldoZero.Name = "CboxSaldoZero"
        Me.CboxSaldoZero.Size = New System.Drawing.Size(191, 21)
        Me.CboxSaldoZero.TabIndex = 7
        Me.CboxSaldoZero.Text = "Incluir item com saldo zero"
        Me.CboxSaldoZero.UseVisualStyleBackColor = True
        '
        'DataInv
        '
        Me.DataInv.CalendarFont = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DataInv.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.DataInv.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.DataInv.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DataInv.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataInv.Location = New System.Drawing.Point(151, 23)
        Me.DataInv.Name = "DataInv"
        Me.DataInv.Size = New System.Drawing.Size(120, 25)
        Me.DataInv.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(25, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 17)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Data Inventário:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(24, 140)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 17)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Localização:"
        '
        'TxtIdCategoriaFinal
        '
        Me.TxtIdCategoriaFinal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtIdCategoriaFinal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtIdCategoriaFinal.Location = New System.Drawing.Point(273, 102)
        Me.TxtIdCategoriaFinal.Name = "TxtIdCategoriaFinal"
        Me.TxtIdCategoriaFinal.Size = New System.Drawing.Size(73, 25)
        Me.TxtIdCategoriaFinal.TabIndex = 7
        Me.TxtIdCategoriaFinal.Text = "99"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(24, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Categoria:"
        '
        'TxtIdCategoriaInicial
        '
        Me.TxtIdCategoriaInicial.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtIdCategoriaInicial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtIdCategoriaInicial.Location = New System.Drawing.Point(151, 102)
        Me.TxtIdCategoriaInicial.Name = "TxtIdCategoriaInicial"
        Me.TxtIdCategoriaInicial.Size = New System.Drawing.Size(72, 25)
        Me.TxtIdCategoriaInicial.TabIndex = 5
        Me.TxtIdCategoriaInicial.Text = "0"
        '
        'TxtIdLocalFinal
        '
        Me.TxtIdLocalFinal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtIdLocalFinal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtIdLocalFinal.Location = New System.Drawing.Point(273, 135)
        Me.TxtIdLocalFinal.Name = "TxtIdLocalFinal"
        Me.TxtIdLocalFinal.Size = New System.Drawing.Size(73, 25)
        Me.TxtIdLocalFinal.TabIndex = 11
        Me.TxtIdLocalFinal.Text = "99"
        '
        'TxtIdLocalInicial
        '
        Me.TxtIdLocalInicial.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TxtIdLocalInicial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.TxtIdLocalInicial.Location = New System.Drawing.Point(151, 135)
        Me.TxtIdLocalInicial.Name = "TxtIdLocalInicial"
        Me.TxtIdLocalInicial.Size = New System.Drawing.Size(72, 25)
        Me.TxtIdLocalInicial.TabIndex = 9
        Me.TxtIdLocalInicial.Text = "0"
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
        Me.BtnCancelar.Location = New System.Drawing.Point(158, 283)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(131, 38)
        Me.BtnCancelar.TabIndex = 52
        Me.BtnCancelar.TabStop = False
        Me.BtnCancelar.Text = "CANCELAR (ESC)"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnAdicionar
        '
        Me.BtnAdicionar.BackColor = System.Drawing.Color.Transparent
        Me.BtnAdicionar.BackgroundImage = CType(resources.GetObject("BtnAdicionar.BackgroundImage"), System.Drawing.Image)
        Me.BtnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdicionar.FlatAppearance.BorderSize = 0
        Me.BtnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdicionar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdicionar.ForeColor = System.Drawing.Color.White
        Me.BtnAdicionar.Location = New System.Drawing.Point(24, 283)
        Me.BtnAdicionar.Name = "BtnAdicionar"
        Me.BtnAdicionar.Size = New System.Drawing.Size(121, 38)
        Me.BtnAdicionar.TabIndex = 53
        Me.BtnAdicionar.TabStop = False
        Me.BtnAdicionar.Text = "EXECUTAR"
        Me.BtnAdicionar.UseVisualStyleBackColor = False
        '
        'BtnCategFinal
        '
        Me.BtnCategFinal.BackColor = System.Drawing.Color.Transparent
        Me.BtnCategFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnCategFinal.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnCategFinal.FlatAppearance.BorderSize = 0
        Me.BtnCategFinal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnCategFinal.Location = New System.Drawing.Point(346, 101)
        Me.BtnCategFinal.Name = "BtnCategFinal"
        Me.BtnCategFinal.Size = New System.Drawing.Size(26, 27)
        Me.BtnCategFinal.TabIndex = 8
        Me.BtnCategFinal.Text = "..."
        Me.BtnCategFinal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCategFinal.UseVisualStyleBackColor = False
        '
        'BtnLocalIncial
        '
        Me.BtnLocalIncial.BackColor = System.Drawing.Color.Transparent
        Me.BtnLocalIncial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnLocalIncial.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnLocalIncial.FlatAppearance.BorderSize = 0
        Me.BtnLocalIncial.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnLocalIncial.Location = New System.Drawing.Point(223, 134)
        Me.BtnLocalIncial.Name = "BtnLocalIncial"
        Me.BtnLocalIncial.Size = New System.Drawing.Size(26, 27)
        Me.BtnLocalIncial.TabIndex = 10
        Me.BtnLocalIncial.Text = "..."
        Me.BtnLocalIncial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLocalIncial.UseVisualStyleBackColor = False
        '
        'BtnLocalFinal
        '
        Me.BtnLocalFinal.BackColor = System.Drawing.Color.Transparent
        Me.BtnLocalFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnLocalFinal.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnLocalFinal.FlatAppearance.BorderSize = 0
        Me.BtnLocalFinal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnLocalFinal.Location = New System.Drawing.Point(346, 134)
        Me.BtnLocalFinal.Name = "BtnLocalFinal"
        Me.BtnLocalFinal.Size = New System.Drawing.Size(26, 27)
        Me.BtnLocalFinal.TabIndex = 12
        Me.BtnLocalFinal.Text = "..."
        Me.BtnLocalFinal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLocalFinal.UseVisualStyleBackColor = False
        '
        'Frm_est_fichasinvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(493, 338)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnAdicionar)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "Frm_est_fichasinvent"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtIdLocalInicial As TextBox
    Friend WithEvents TxtIdCategoriaInicial As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataInv As DateTimePicker
    Friend WithEvents TxtIdCodFinal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtIdCodInicial As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtIdLocalFinal As TextBox
    Friend WithEvents TxtIdCategoriaFinal As TextBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAdicionar As Button
    Friend WithEvents CboxSaldoZero As CheckBox
    Friend WithEvents BtnCategInicial As Button
    Friend WithEvents BtnItemFim As Button
    Friend WithEvents BtnItemInic As Button
    Friend WithEvents BtnCategFinal As Button
    Friend WithEvents BtnLocalFinal As Button
    Friend WithEvents BtnLocalIncial As Button
End Class
