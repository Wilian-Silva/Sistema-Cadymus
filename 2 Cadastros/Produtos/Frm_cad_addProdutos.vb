Imports MySql.Data.MySqlClient

Public Class Frm_cad_addProdutos
    Private Sub Frm_cad_addProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtCodBarras.Focus()
        TxtCodBarras.Select()
    End Sub

    Private Sub TxtCodBarras_Enter(sender As Object, e As EventArgs) Handles TxtCodBarras.Enter
        CorTxtBox(TxtCodBarras, "Am")
    End Sub

    Private Sub TxtCodBarras_Leave(sender As Object, e As EventArgs) Handles TxtCodBarras.Leave
        CorTxtBox(TxtCodBarras, "Br")
    End Sub

    Private Sub TxtDescricao_Enter(sender As Object, e As EventArgs) Handles TxtDescricao.Enter
        CorTxtBox(TxtDescricao, "Am")
    End Sub

    Private Sub TxtDescricao_Leave(sender As Object, e As EventArgs) Handles TxtDescricao.Leave
        CorTxtBox(TxtDescricao, "Br")
    End Sub

    Private Sub TxtCategoria_Enter(sender As Object, e As EventArgs) Handles TxtCategoria.Enter
        CorTxtBox(TxtCategoria, "Am")
    End Sub

    Private Sub TxtCategoria_Leave(sender As Object, e As EventArgs) Handles TxtMarca.Leave, TxtCategoria.Leave
        CorTxtBox(TxtCategoria, "Br")
    End Sub
    Private Sub TxtMarca_Enter(sender As Object, e As EventArgs) Handles TxtMarca.Enter
        CorTxtBox(TxtMarca, "Am")
    End Sub

    Private Sub TxtMarca_Leave(sender As Object, e As EventArgs)
        CorTxtBox(TxtMarca, "Br")
    End Sub

    Private Sub TxtForncedor_Enter(sender As Object, e As EventArgs) Handles TxtForncedor.Enter
        CorTxtBox(TxtForncedor, "Am")
    End Sub

    Private Sub TxtForncedor_Leave(sender As Object, e As EventArgs) Handles TxtForncedor.Leave
        CorTxtBox(TxtForncedor, "Br")
    End Sub

    Private Sub TxtPvenda_Enter(sender As Object, e As EventArgs) Handles TxtPvenda.Enter
        CorTxtBox(TxtPvenda, "Am")
    End Sub

    Private Sub TxtPvenda_Leave(sender As Object, e As EventArgs) Handles TxtPvenda.Leave
        CorTxtBox(TxtPvenda, "Br")
    End Sub

    Private Sub TxtPcusto_Enter(sender As Object, e As EventArgs) Handles TxtPcusto.Enter
        CorTxtBox(TxtPcusto, "Am")
    End Sub

    Private Sub TxtPcusto_Leave(sender As Object, e As EventArgs) Handles TxtPcusto.Leave
        CorTxtBox(TxtPcusto, "Br")
    End Sub

    Private Sub TxtMarkup_Enter(sender As Object, e As EventArgs) Handles TxtMarkup.Enter
        CorTxtBox(TxtMarkup, "Am")
    End Sub

    Private Sub TxtMarkup_Leave(sender As Object, e As EventArgs) Handles TxtMarkup.Leave
        CorTxtBox(TxtMarkup, "Br")
    End Sub

    Private Sub TxtEstMinimo_Enter(sender As Object, e As EventArgs) Handles TxtEstMinimo.Enter
        CorTxtBox(TxtEstMinimo, "Am")
    End Sub
    Private Sub TxtEstMinimo_Leave(sender As Object, e As EventArgs) Handles TxtEstMinimo.Leave
        CorTxtBox(TxtEstMinimo, "Br")
    End Sub

    Private Sub TxtEstMaxio_Enter(sender As Object, e As EventArgs) Handles TxtEstMaximo.Enter
        CorTxtBox(TxtEstMaximo, "Am")
    End Sub
    Private Sub TxtEstMaxio_Leave(sender As Object, e As EventArgs) Handles TxtEstMaximo.Leave
        CorTxtBox(TxtEstMaximo, "Br")
    End Sub

    Private Sub TxtPpromocao_Enter(sender As Object, e As EventArgs) Handles TxtPpromocao.Enter
        CorTxtBox(TxtPpromocao, "Am")
    End Sub

    Private Sub TxtPpromocao_Leave(sender As Object, e As EventArgs) Handles TxtPpromocao.Leave
        CorTxtBox(TxtPpromocao, "Br")
    End Sub
    Private Sub TxtLocal_Enter(sender As Object, e As EventArgs) Handles TxtLocal.Enter
        CorTxtBox(TxtLocal, "Am")
    End Sub

    Private Sub TxtLocal_Leave(sender As Object, e As EventArgs) Handles TxtLocal.Leave
        CorTxtBox(TxtLocal, "Br")
    End Sub

    Private Sub TxtSaldoProd_Enter(sender As Object, e As EventArgs) Handles TxtSaldoProd.Enter
        CorTxtBox(TxtSaldoProd, "Am")
    End Sub

    Private Sub TxtSaldoProd_Leave(sender As Object, e As EventArgs) Handles TxtSaldoProd.Leave
        CorTxtBox(TxtSaldoProd, "Br")
    End Sub

    Private Sub BtnPesqFornecedor_Click(sender As Object, e As EventArgs) Handles BtnPesqFornecedor.Click
        PesqFornec = "True"
        Dim frm As New Frm_cad_fornecedores
        frm.ShowDialog()
    End Sub

    Private Sub Frm_cad_produtosDados_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        If e.KeyCode = Keys.F3 Then
            Salvar_produto()
        End If
    End Sub

    Private Sub Frm_cad_produtosDados_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        If PesqFornec = "True" Then
            TxtForncedor.Text = NomeFornec
            TxtIdFornec.Text = IdFornec

        End If

        If PesqCategoria = "True" Then
            TxtCategoria.Text = Categoria
            TxtIdCategoria.Text = IdCategoria

        End If

        If PesqMarca = "True" Then
            TxtMarca.Text = Marca
            TxtIdMarca.Text = IdMarca

        End If

        If PesqLocal = "True" Then
            TxtLocal.Text = Local
            TxtIdLocal.Text = IdLocal

        End If

    End Sub
    Sub LimpandoVariaveis()
        NomeFornec = ""
        IdFornec = ""
        PesqFornec = ""
        Categoria = ""
        Marca = ""
        PesqLocal = ""
        Local = ""
        IdCategoria = ""
        IdMarca = ""
        IdLocal = ""
        PesqMarca = ""
        PesqCategoria = ""
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Salvar_produto()
    End Sub

    Sub Salvar_produto()
        'Stop
        If TxtCod.Text = "" Then
            If MsgBox("Deseja salvar registro? ", vbYesNo, "Salvar") = vbYes Then

                Salvar_Cad_Produto()
                Exit Sub
            Else
                Exit Sub
            End If
        End If

        If TxtCod.Text > 0 Then
            If MsgBox("Deseja salvar edição? ", vbYesNo, "Editar") = vbYes Then

                Editar_Cad_Produto()
                Exit Sub
            Else
                Exit Sub
            End If
        End If

    End Sub

    Private Sub Editar_Cad_Produto()
        'Stop
        If TxtDescricao.Text <> "" Then

            Try

                'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO
                TxtDescricao.BackColor = Color.White

                Dim estoque As String
                Dim prm As String
                Dim situacao As String
                Dim mkup As String
                Dim data As String
                Dim dataI As String
                Dim dataF As String

                mkup = ""
                estoque = ""
                prm = ""
                situacao = ""

                dataI = Now().ToString("yyyy-MM-dd")
                dataF = Now().ToString("yyyy-MM-dd")
                data = Now().ToString("yyyy-MM-dd")


                '/VALIDANDO CHEKCBOX
                If CboxPromocao.Checked = True And TxtPpromocao.Text = "" Then

                    MsgBox("Valor promocional vazio ou em branco!!", MsgBoxStyle.Information, "Promoção")

                    Exit Sub

                End If

                If CboxAutomatico.Checked = True And TxtMarkup.Text = "" Then

                    MsgBox("% Markup vazio ou em branco!!", MsgBoxStyle.Information, "Markup")

                    Exit Sub
                End If

                '//CONTROLE ESTOQUE
                If CboxEstoque.Checked Then
                    estoque = "Sim"
                Else
                    estoque = "Não"
                End If

                '//VALIDANDO PROMOÇÃO
                If CboxPromocao.Checked = True Then
                    prm = "Sim"
                    dataI = DataInicio.Value.ToString("yyyy-MM-dd")
                    dataF = DataFim.Value.ToString("yyyy-MM-dd")
                End If
                If CboxPromocao.Checked = False Then
                    prm = "Não"
                    Dim dbl3 As Double = 0
                    Double.TryParse(TxtPpromocao.Text, dbl3)
                    TxtPpromocao.Text = dbl3

                End If

                '//SITUAÇÃO PRODUTO
                If RbAtivo.Checked = True Then
                    situacao = "Ativo"
                End If
                If RbInativo.Checked = True Then
                    situacao = "Inativo"
                End If


                Validacao_Campos()

                'Stop
                '//Validando preço promocional com o preco de cust
                Dim dbl1 As Double = 0
                Dim dbl2 As Double = 0
                Double.TryParse(TxtPpromocao.Text, dbl1)
                Double.TryParse(TxtPcusto.Text, dbl2)

                If dbl1 < dbl2 And CboxPromocao.Checked = True Then
                    If MsgBox("Preço promocional está abaixo do preço de custo, deseja salvar mesmo assim? ", vbYesNo, "Preço Promocional") = vbYes Then

                        Abrir()
                        Dim cmd As MySqlCommand
                        Dim sqls As String

                        sqls = "UPDATE tbl_cad_produtos SET cod_barras= '" & TxtCodBarras.Text & "' , descricao = '" & TxtDescricao.Text & "', id_categoria = '" & TxtIdCategoria.Text & "', id_marca ='" & TxtIdMarca.Text & "', id_fornecedor= '" & TxtIdFornec.Text & "', preco_venda= '" & TxtPvenda.Text.Replace(",", ".") & "'," _
                        & " preco_custo='" & TxtPcusto.Text.Replace(",", ".") & "', markup= '" & TxtMarkup.Text.Replace(",", ".") & "', id_local='" & TxtIdLocal.Text & "', saldo='" & TxtSaldoProd.Text & "', estoque_minimo='" & TxtEstMinimo.Text & "', estoque_maximo= '" & TxtEstMaximo.Text & "', prm_promocao='" & prm & "'," _
                        & "prm_data_inicio='" & dataI & "', prm_data_fim='" & dataF & "', prm_preco='" & TxtPpromocao.Text.Replace(",", ".") & "', controle_estoque='" & estoque & "', status='" & situacao & "' WHERE id  = '" & TxtCod.Text & "' "

                        cmd = New MySqlCommand(sqls, con)
                        cmd.ExecuteNonQuery()

                        MsgBox("Cadastro editado com Sucesso!!", MsgBoxStyle.Information, "Salvar")

                        Limpar_campos()

                        Me.Close()
                        Exit Sub

                    Else

                        Exit Sub
                    End If
                Else

                    Abrir()
                    Dim cmd As MySqlCommand
                    Dim sqls As String

                    sqls = "UPDATE tbl_cad_produtos SET cod_barras= '" & TxtCodBarras.Text & "' , descricao = '" & TxtDescricao.Text & "', id_categoria = '" & TxtIdCategoria.Text & "', id_marca ='" & TxtIdMarca.Text & "', id_fornecedor= '" & TxtIdFornec.Text & "', preco_venda= '" & TxtPvenda.Text.Replace(",", ".") & "'," _
                        & " preco_custo='" & TxtPcusto.Text.Replace(",", ".") & "', markup= '" & TxtMarkup.Text.Replace(",", ".") & "', id_local='" & TxtIdLocal.Text & "', saldo='" & TxtSaldoProd.Text & "', estoque_minimo='" & TxtEstMinimo.Text & "', estoque_maximo= '" & TxtEstMaximo.Text & "', prm_promocao='" & prm & "'," _
                        & "prm_data_inicio='" & dataI & "', prm_data_fim='" & dataF & "', prm_preco='" & TxtPpromocao.Text.Replace(",", ".") & "', controle_estoque='" & estoque & "', status='" & situacao & "' WHERE id  = '" & TxtCod.Text & "' "

                    cmd = New MySqlCommand(sqls, con)
                    cmd.ExecuteNonQuery()

                    MsgBox("Cadastro editado com Sucesso!!", MsgBoxStyle.Information, "Salvar")

                    Limpar_campos()

                    Me.Close()
                    Exit Sub
                End If

            Catch ex As Exception
                MessageBox.Show("Erro:" & ex.Message)
            End Try

        Else
            TxtDescricao.BackColor = Color.Salmon

            MsgBox("Campos vazios!!", MsgBoxStyle.Information, "Dados inválidos")
            TxtCodBarras.Focus()

        End If

    End Sub
    Sub Validacao_Campos()
        'Stop
        '//VALIDAÇÕES CAMPOS INTEIROS VAZIOS
        If TxtMarkup.Text = "" Then
            Dim dbl3 As Double = 0
            Double.TryParse(TxtMarkup.Text, dbl3)
            TxtMarkup.Text = dbl3
        End If
        If TxtPpromocao.Text = "" Then
            Dim dbl3 As Double = 0
            Double.TryParse(TxtPpromocao.Text, dbl3)
            TxtPpromocao.Text = dbl3
        End If

        If TxtPvenda.Text = "" Then
            Dim dbl3 As Double = 0
            Double.TryParse(TxtPvenda.Text, dbl3)
            TxtPvenda.Text = dbl3
        End If

        If TxtPcusto.Text = "" Then
            Dim dbl3 As Double = 0
            Double.TryParse(TxtPcusto.Text, dbl3)
            TxtPcusto.Text = dbl3
        End If

        If TxtSaldoProd.Text = "" Then
            Dim dbl3 As Double = 0
            Double.TryParse(TxtSaldoProd.Text, dbl3)
            TxtSaldoProd.Text = dbl3
        End If

        If TxtEstMaximo.Text = "" Then
            Dim dbl3 As Double = 0
            Double.TryParse(TxtEstMaximo.Text, dbl3)
            TxtEstMaximo.Text = dbl3
        End If

        If TxtEstMinimo.Text = "" Then
            Dim dbl3 As Double = 0
            Double.TryParse(TxtEstMinimo.Text, dbl3)
            TxtEstMinimo.Text = dbl3
        End If

        '//MARKUP

        If CboxAutomatico.Checked = False Then

            Dim dbl3 As Double = 0
            Double.TryParse(TxtMarkup.Text, dbl3)
            TxtMarkup.Text = dbl3
        End If
    End Sub
    Private Sub Salvar_Cad_Produto()
        'Stop
        If TxtDescricao.Text <> "" Then

            Try
                'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO
                TxtDescricao.BackColor = Color.White

                '/VALIDANDO CHEKCBOX
                If CboxPromocao.Checked = True And TxtPpromocao.Text = "" Then

                    MsgBox("Valor promocional vazio ou em branco!!", MsgBoxStyle.Information, "Promoção")

                    Exit Sub

                End If

                If CboxAutomatico.Checked = True And TxtMarkup.Text = "" Then

                    MsgBox("% Markup vazio ou em branco!!", MsgBoxStyle.Information, "Markup")

                    Exit Sub
                End If

                '//CONTROLE ESTOQUE
                Dim estoque As String
                estoque = ""
                If CboxEstoque.Checked Then
                    estoque = "Sim"
                Else
                    estoque = "Não"
                End If

                '//VALIDANDO PROMOÇÃO
                Dim data As String
                Dim dataI As String
                Dim dataF As String
                Dim prm As String
                prm = ""

                dataI = Now().ToString("yyyy-MM-dd")
                dataF = Now().ToString("yyyy-MM-dd")
                data = Now().ToString("yyyy-MM-dd")
                If CboxPromocao.Checked = True Then
                    prm = "Sim"
                    dataI = DataInicio.Value.ToString("yyyy-MM-dd")
                    dataF = DataFim.Value.ToString("yyyy-MM-dd")
                End If
                If CboxPromocao.Checked = False Then
                    prm = "Não"
                    Dim dbl3 As Double = 0
                    Double.TryParse(TxtPpromocao.Text, dbl3)
                    TxtPpromocao.Text = dbl3

                End If

                '//SITUAÇÃO PRODUTO
                Dim situacao As String
                situacao = ""

                If RbAtivo.Checked = True Then
                    situacao = "Ativo"
                End If
                If RbInativo.Checked = True Then
                    situacao = "Inativo"
                End If

                Validacao_Campos()

                '//Validando preço promocional com o preco de cust
                Dim dbl1 As Double = 0
                Dim dbl2 As Double = 0
                Double.TryParse(TxtPpromocao.Text, dbl1)
                Double.TryParse(TxtPcusto.Text, dbl2)

                If dbl1 < dbl2 And CboxPromocao.Checked = True Then
                    If MsgBox("Preço promocional está abaixo do preço de custo, deseja salvar mesmo assim? ", vbYesNo, "Preço Promocional") = vbYes Then

                        Abrir()
                        Dim cmd As MySqlCommand
                        Dim sqls As String

                        sqls = "INSERT INTO tbl_cad_produtos (cod_barras, descricao, id_categoria, id_marca, id_fornecedor, preco_venda, preco_custo, markup, id_local, saldo, estoque_minimo, estoque_maximo, prm_promocao, prm_data_inicio, prm_data_fim, prm_preco, controle_estoque, status, data_inclusao )" _
                        & "VALUES('" & TxtCodBarras.Text & "','" & TxtDescricao.Text & "', '" & TxtIdCategoria.Text & "', '" & TxtIdMarca.Text & "', '" & TxtIdFornec.Text & "', '" & TxtPvenda.Text.Replace(",", ".") & "', '" & TxtPcusto.Text.Replace(",", ".") & "', '" & TxtMarkup.Text.Replace(",", ".") & "','" & TxtIdLocal.Text & "','" & TxtSaldoProd.Text & "', '" & TxtEstMinimo.Text & "', '" & TxtEstMaximo.Text & "','" & prm & "', '" & dataI & "','" & dataF & "','" & TxtPpromocao.Text.Replace(",", ".") & "', '" & estoque & "', '" & situacao & "', '" & data & "')"

                        cmd = New MySqlCommand(sqls, con)
                        cmd.ExecuteNonQuery()

                        Limpar_campos()

                        MsgBox("Cadastro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar")

                        Me.Close()
                        Exit Sub

                    Else
                        Exit Sub
                    End If
                Else

                    Abrir()
                    Dim cmd As MySqlCommand
                    Dim sqls As String

                    sqls = "INSERT INTO tbl_cad_produtos (cod_barras, descricao, id_categoria, id_marca, id_fornecedor,  preco_venda, preco_custo, markup, id_local, saldo, estoque_minimo, estoque_maximo, prm_promocao, prm_data_inicio, prm_data_fim, prm_preco, controle_estoque, status, data_inclusao )" _
                        & "VALUES('" & TxtCodBarras.Text & "','" & TxtDescricao.Text & "', '" & TxtIdCategoria.Text & "', '" & TxtIdMarca.Text & "', '" & TxtIdFornec.Text & "',  '" & TxtPvenda.Text.Replace(",", ".") & "', '" & TxtPcusto.Text.Replace(",", ".") & "', '" & TxtMarkup.Text.Replace(",", ".") & "','" & TxtIdLocal.Text & "','" & TxtSaldoProd.Text & "', '" & TxtEstMinimo.Text & "', '" & TxtEstMaximo.Text & "','" & prm & "', '" & dataI & "','" & dataF & "','" & TxtPpromocao.Text.Replace(",", ".") & "', '" & estoque & "', '" & situacao & "', '" & data & "')"

                    cmd = New MySqlCommand(sqls, con)
                    cmd.ExecuteNonQuery()

                    MsgBox("Cadastro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar")

                    Limpar_campos()

                    Me.Close()
                    Exit Sub

                End If


            Catch ex As Exception
                MessageBox.Show("Erro:" & ex.Message)
            End Try

        Else
            TxtDescricao.BackColor = Color.Salmon

            MsgBox("Campos vazios!!", MsgBoxStyle.Information, "Dados inválidos")
            TxtCodBarras.Focus()

        End If
    End Sub

    Private Sub Limpar_campos()
        TxtCodBarras.Text = ""
        TxtDescricao.Text = ""
        TxtCategoria.Text = ""
        TxtMarca.Text = ""
        TxtIdFornec.Text = ""
        TxtForncedor.Text = ""
        TxtPvenda.Text = ""
        TxtPcusto.Text = ""
        TxtMarkup.Text = ""
        CboxAutomatico.Checked = False
        TxtEstMinimo.Text = ""
        TxtEstMaximo.Text = ""
        CboxPromocao.Checked = False
        TxtPpromocao.Text = ""
        TxtSaldoProd.Text = ""
        TxtLocal.Text = ""
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub CboxAutomatico_CheckedChanged(sender As Object, e As EventArgs) Handles CboxAutomatico.CheckedChanged

        If CboxAutomatico.Checked = True Then
            TxtMarkup.Enabled = True
            TxtPvenda.Enabled = False
            TxtPcusto.Focus()
            LabelPercent.Visible = True


        End If

        If CboxAutomatico.Checked = False Then
            TxtMarkup.Enabled = False
            TxtPvenda.Enabled = True
            TxtPvenda.Focus()
            LabelPercent.Visible = False

        End If

    End Sub

    Private Sub TxtMarkup_TextChanged(sender As Object, e As EventArgs) Handles TxtMarkup.TextChanged
        If CboxAutomatico.Checked = True Then

            Cal_Markup()

        End If

    End Sub

    Sub Cal_Markup()

        Dim dbl1 As Double = 0
        Dim dbl2 As Double = 0

        Double.TryParse(TxtPcusto.Text, dbl1)
        Double.TryParse(TxtMarkup.Text, dbl2)

        TxtPvenda.Text = (dbl1 / (1 - dbl2)) '.ToString("n")

    End Sub

    Sub Cal_Margem()

        Dim dbl1 As Double = 0
        Dim dbl2 As Double = 0

        Double.TryParse(TxtPvenda.Text, dbl1)
        Double.TryParse(TxtPcusto.Text, dbl2)

        TxtMarkup.Text = ((dbl1 - dbl2) / dbl1).ToString("n")

    End Sub
    Private Sub TxtPvenda_TextChanged(sender As Object, e As EventArgs) Handles TxtPvenda.TextChanged
        If CboxAutomatico.Checked = False Then

            Cal_Margem()

        End If
    End Sub
    Private Sub TxtPcusto_TextChanged(sender As Object, e As EventArgs) Handles TxtPcusto.TextChanged
        If CboxAutomatico.Checked = True Then

            Cal_Markup()

        End If

        If CboxAutomatico.Checked = False Then

            Cal_Margem()

        End If
    End Sub

    Private Sub CboxPromocao_CheckedChanged(sender As Object, e As EventArgs) Handles CboxPromocao.CheckedChanged
        If CboxPromocao.Checked = True Then
            DataFim.Enabled = True
            DataInicio.Enabled = True
            TxtPpromocao.Enabled = True


        End If
        If CboxPromocao.Checked = False Then
            DataFim.Enabled = False
            DataInicio.Enabled = False
            TxtPpromocao.Enabled = False
            TxtPpromocao.Text = ""

        End If

    End Sub

    Private Sub TxtPvenda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPvenda.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtPcusto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPcusto.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtEstMinimo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEstMinimo.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtEstMaximo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEstMaximo.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtPpromocao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPpromocao.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtMarkup_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMarkup.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtCodBarras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodBarras.KeyPress

        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub TxtSaldoProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSaldoProd.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub BtnCategoria_Click(sender As Object, e As EventArgs) Handles BtnCategoria.Click
        PesqCategoria = "True"
        Dim frm As New Frm_cad_categorias
        frm.ShowDialog()
    End Sub

    Private Sub BtnMarca_Click(sender As Object, e As EventArgs) Handles BtnMarca.Click
        PesqMarca = "True"
        Dim frm As New Frm_cad_marca
        frm.ShowDialog()
    End Sub

    Private Sub Frm_cad_produtosDados_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        LimpandoVariaveis()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnLocal.Click
        PesqLocal = "True"
        Dim frm As New Frm_cad_local
        frm.ShowDialog()
    End Sub

    Private Sub TxtCategoria_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCategoria.KeyDown
        If e.KeyCode = Keys.F5 Then
            PesqCategoria = "True"
            Dim frm As New Frm_cad_categorias
            frm.ShowDialog()
        End If
    End Sub

    Private Sub TxtMarca_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtMarca.KeyDown
        If e.KeyCode = Keys.F5 Then
            PesqMarca = "True"
            Dim frm As New Frm_cad_marca
            frm.ShowDialog()
        End If
    End Sub

    Private Sub TxtForncedor_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtForncedor.KeyDown

        If e.KeyCode = Keys.F5 Then
            PesqFornec = "True"
            Dim frm As New Frm_cad_fornecedores
            frm.ShowDialog()
        End If
    End Sub

    Private Sub TxtLocal_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtLocal.KeyDown

        If e.KeyCode = Keys.F5 Then
            PesqLocal = "True"
            Dim frm As New Frm_cad_local
            frm.ShowDialog()

        End If
    End Sub
End Class