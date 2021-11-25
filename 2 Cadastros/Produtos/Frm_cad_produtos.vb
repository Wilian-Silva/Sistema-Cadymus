﻿Imports ClosedXML.Excel
Imports MySql.Data.MySqlClient

Public Class Frm_cad_produtos
    Private Sub Frm_cad_produtos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PesProdTelaProd = "True"
        If PesqProd = "True" Then
            BtnSelecionar.Visible = True
        End If

        Carregar_DataGrid()
        FormatarGrid()
    End Sub
    Private Sub BtnIncluir_Click(sender As Object, e As EventArgs) Handles BtnIncluir.Click
        Dim frm As New Frm_cad_addProdutos
        frm.ShowDialog()
    End Sub

    Private Sub Frm_cad_produtos_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.F1 Then

            Dim frm As New Frm_cad_addProdutos
            frm.ShowDialog()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        If e.KeyCode = Keys.F2 Then
            Editar_Produto()
        End If

        If e.KeyCode = Keys.Delete Then
            Excluir_Produto()
        End If

        If e.KeyCode = Keys.F3 Then
            Copiar_Produto()
        End If

        If e.KeyCode = Keys.F4 Then
            Editar_PrecoVenda()

        End If
        If e.KeyCode = Keys.F5 Then

            Inativar_Produto()

        End If

        If e.KeyCode = Keys.F6 Then
            Promocao()
        End If

        If e.KeyCode = Keys.Enter And PesqProd = "True" Then

            DadosProduto()
            Me.Close()

        End If

    End Sub

    Private Sub Copiar_Produto()
        If DataGrid.SelectedRows.Count = 1 Then
            Dim form = New Frm_cad_addProdutos



            form.TxtDescricao.Text = DataGrid.CurrentRow.Cells(2).Value

            form.TxtCategoria.Text = DataGrid.CurrentRow.Cells(3).Value
            form.TxtMarca.Text = DataGrid.CurrentRow.Cells(4).Value
            form.TxtLocal.Text = DataGrid.CurrentRow.Cells(10).Value

            form.TxtIdCategoria.Text = DataGrid.CurrentRow.Cells(21).Value
            form.TxtIdMarca.Text = DataGrid.CurrentRow.Cells(22).Value
            form.TxtIdLocal.Text = DataGrid.CurrentRow.Cells(23).Value

            form.TxtIdFornec.Text = DataGrid.CurrentRow.Cells(5).Value
            form.TxtForncedor.Text = DataGrid.CurrentRow.Cells(6).Value
            form.TxtPvenda.Text = DataGrid.CurrentRow.Cells(7).Value
            form.TxtPcusto.Text = DataGrid.CurrentRow.Cells(8).Value
            form.TxtMarkup.Text = DataGrid.CurrentRow.Cells(9).Value

            form.TxtSaldoProd.Text = DataGrid.CurrentRow.Cells(11).Value
            form.TxtEstMinimo.Text = DataGrid.CurrentRow.Cells(12).Value
            form.TxtEstMaximo.Text = DataGrid.CurrentRow.Cells(13).Value

            form.DataInicio.Text = DataGrid.CurrentRow.Cells(15).Value
            form.DataFim.Text = DataGrid.CurrentRow.Cells(16).Value
            form.TxtPpromocao.Text = DataGrid.CurrentRow.Cells(17).Value

            '//PRODUTO PROMOÇÃO
            If DataGrid.CurrentRow.Cells(14).Value = "Sim" Then
                form.CboxPromocao.Checked = True
            End If

            '//CONTROLE ESTOQUE
            If DataGrid.CurrentRow.Cells(18).Value = "Sim" Then
                form.CboxEstoque.Checked = True
            Else
                form.CboxEstoque.Checked = False
            End If

            '//SATUS PRODUTO
            If DataGrid.CurrentRow.Cells(19).Value = "Ativo" Then
                form.RbAtivo.Checked = True
            End If
            If DataGrid.CurrentRow.Cells(19).Value = "Inativo" Then
                form.RbInativo.Checked = True
            End If

            form.ShowDialog()
        End If
    End Sub

    Private Sub Editar_Produto()

        If DataGrid.SelectedRows.Count = 1 Then
            Dim form = New Frm_cad_addProdutos

            '//NÃO PODE EDITAR TIPO CONTROLE ESTOQUE
            form.CboxEstoque.Enabled = False


            form.TxtCod.Text = DataGrid.CurrentRow.Cells(0).Value
            form.TxtCodBarras.Text = DataGrid.CurrentRow.Cells(1).Value
            form.TxtDescricao.Text = DataGrid.CurrentRow.Cells(2).Value

            form.TxtCategoria.Text = DataGrid.CurrentRow.Cells(3).Value
            form.TxtMarca.Text = DataGrid.CurrentRow.Cells(4).Value
            form.TxtLocal.Text = DataGrid.CurrentRow.Cells(10).Value

            form.TxtIdCategoria.Text = DataGrid.CurrentRow.Cells(21).Value
            form.TxtIdMarca.Text = DataGrid.CurrentRow.Cells(22).Value
            form.TxtIdLocal.Text = DataGrid.CurrentRow.Cells(23).Value

            form.TxtIdFornec.Text = DataGrid.CurrentRow.Cells(5).Value
            form.TxtForncedor.Text = DataGrid.CurrentRow.Cells(6).Value
            form.TxtPvenda.Text = DataGrid.CurrentRow.Cells(7).Value
            form.TxtPcusto.Text = DataGrid.CurrentRow.Cells(8).Value
            form.TxtMarkup.Text = DataGrid.CurrentRow.Cells(9).Value

            form.TxtSaldoProd.Text = DataGrid.CurrentRow.Cells(11).Value
            form.TxtEstMinimo.Text = DataGrid.CurrentRow.Cells(12).Value
            form.TxtEstMaximo.Text = DataGrid.CurrentRow.Cells(13).Value

            form.DataInicio.Text = DataGrid.CurrentRow.Cells(15).Value
            form.DataFim.Text = DataGrid.CurrentRow.Cells(16).Value
            form.TxtPpromocao.Text = DataGrid.CurrentRow.Cells(17).Value

            '//PRODUTO PROMOÇÃO
            If DataGrid.CurrentRow.Cells(14).Value = "Sim" Then
                form.CboxPromocao.Checked = True
            End If

            '//CONTROLE ESTOQUE
            If DataGrid.CurrentRow.Cells(18).Value = "Sim" Then
                form.CboxEstoque.Checked = True
            Else
                form.CboxEstoque.Checked = False
            End If

            '//SATUS PRODUTO
            If DataGrid.CurrentRow.Cells(19).Value = "Ativo" Then
                form.RbAtivo.Checked = True
            End If
            If DataGrid.CurrentRow.Cells(19).Value = "Inativo" Then
                form.RbInativo.Checked = True
            End If

            form.ShowDialog()
        End If
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Sub Carregar_DataGrid()

        Try
            Abrir()
            Dim dt As New DataTable
            Dim sql As String
            Dim da As MySqlDataAdapter

            sql = "SELECT  p.id, p.cod_barras, p.descricao, c.categoria, m.marca, p.id_fornecedor, f.nome, p.preco_venda, p.preco_custo, p.markup, " _
            & " l.local, p.saldo, p.estoque_minimo, p.estoque_maximo, p.prm_promocao, p.prm_data_inicio, p.prm_data_fim, p.prm_preco, p.controle_estoque, p.status, p.data_inclusao,p.id_categoria, p.id_marca, p.id_local " _
            & " From tbl_cad_produtos as p " _
            & " INNER JOIN tbl_cad_categorias as c ON p.id_categoria = c.id " _
            & " INNER JOIN tbl_cad_marcas as m ON p.id_marca = m.id " _
            & " INNER JOIN tbl_cad_locais as l on p.id_local = l.id " _
            & " INNER JOIN tbl_cad_fornecedores as f on p.id_fornecedor = f.id Order By p.id asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub
    Private Sub FormatarGrid()

        DataGrid.Columns(0).HeaderText = "Código Produto"
        DataGrid.Columns(1).HeaderText = "Cód. Barras"
        DataGrid.Columns(2).HeaderText = "Descrição"
        DataGrid.Columns(3).HeaderText = "Categoria"
        DataGrid.Columns(4).HeaderText = "Marca"
        DataGrid.Columns(5).HeaderText = "Cód. Fornec."
        DataGrid.Columns(6).HeaderText = "Fornecedor"
        DataGrid.Columns(7).HeaderText = "Preço Venda"
        DataGrid.Columns(8).HeaderText = "Preço Custo"
        DataGrid.Columns(9).HeaderText = "Markup"
        DataGrid.Columns(10).HeaderText = "Localização"
        DataGrid.Columns(11).HeaderText = "Saldo Estoque"
        DataGrid.Columns(12).HeaderText = "Estoque Mínimo"
        DataGrid.Columns(13).HeaderText = "Estoque Máximo."
        DataGrid.Columns(14).HeaderText = "Promoção"
        DataGrid.Columns(15).HeaderText = "Data Início"
        DataGrid.Columns(16).HeaderText = "Data Fim"
        DataGrid.Columns(17).HeaderText = "Preço Promoção"
        DataGrid.Columns(18).HeaderText = "Controle Estoque"
        DataGrid.Columns(19).HeaderText = "Status"
        DataGrid.Columns(20).HeaderText = "Data Inclusão"
        DataGrid.Columns(21).Visible = False
        DataGrid.Columns(22).Visible = False
        DataGrid.Columns(23).Visible = False

        DataGrid.Columns(7).DefaultCellStyle.Format = "c"
        DataGrid.Columns(8).DefaultCellStyle.Format = "c"
        DataGrid.Columns(9).DefaultCellStyle.Format = "p"
        DataGrid.Columns(14).DefaultCellStyle.Format = "c"
        DataGrid.Columns(17).DefaultCellStyle.Format = "c"

        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(11).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(12).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(13).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(14).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(15).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(16).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(17).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(18).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(19).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(20).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(0).Width = 80
        DataGrid.Columns(1).Width = 150
        DataGrid.Columns(2).Width = 230
        DataGrid.Columns(3).Width = 150
        DataGrid.Columns(4).Width = 150
        DataGrid.Columns(5).Width = 60
        DataGrid.Columns(6).Width = 250
        DataGrid.Columns(7).Width = 85
        DataGrid.Columns(8).Width = 85
        DataGrid.Columns(9).Width = 70
        DataGrid.Columns(10).Width = 150
        DataGrid.Columns(11).Width = 70
        DataGrid.Columns(12).Width = 70
        DataGrid.Columns(13).Width = 70
        DataGrid.Columns(14).Width = 90
        DataGrid.Columns(15).Width = 100
        DataGrid.Columns(16).Width = 100
        DataGrid.Columns(17).Width = 80
        DataGrid.Columns(18).Width = 70
        DataGrid.Columns(19).Width = 80
        DataGrid.Columns(20).Width = 90



    End Sub

    Private Sub Frm_cad_produtos_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Carregar_DataGrid()
    End Sub
    Sub Excluir_Produto()
        If DataGrid.SelectedRows.Count = 1 Then
            Dim produto As String
            Dim cod As String

            cod = DataGrid.CurrentRow.Cells(0).Value
            produto = DataGrid.CurrentRow.Cells(2).Value


            If cod <> "" Then


                If MsgBox("Deseja excluir o produto " & produto & "?", vbYesNo, "Exclusão") = vbYes Then

                    Try
                        Abrir()

                        'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                        Dim cmd As MySqlCommand
                        Dim sql As String

                        sql = "DELETE FROM tbl_cad_produtos where id = '" & cod & "' "
                        cmd = New MySqlCommand(sql, con)
                        cmd.ExecuteNonQuery()

                        MsgBox("Registro excluído com Sucesso!!", MsgBoxStyle.Information, "Exlusão")

                        Carregar_DataGrid()

                    Catch ex As Exception
                        MsgBox("Erro ao excluir!!" + ex.Message)
                    End Try
                End If
            Else

                MsgBox("Selecione um registro para excluir!!", MsgBoxStyle.Information, "Exlusão")
            End If
        End If
    End Sub
    Private Sub BtnExcuir_Click(sender As Object, e As EventArgs) Handles BtnExcuir.Click
        Excluir_Produto()
    End Sub

    Private Sub TxtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisar.TextChanged

        Try
            Abrir()
            Dim dt As New DataTable
            Dim sql As String
            Dim da As MySqlDataAdapter

            sql = "SELECT  p.id, p.cod_barras, p.descricao, c.categoria, m.marca, p.id_fornecedor, f.nome, p.preco_venda, p.preco_custo, p.markup, " _
            & " l.local, p.saldo, p.estoque_minimo, p.estoque_maximo, p.prm_promocao, p.prm_data_inicio, p.prm_data_fim, p.prm_preco, p.controle_estoque, p.status, p.data_inclusao,p.id_categoria, p.id_marca, p.id_local " _
            & " From tbl_cad_produtos as p " _
            & " INNER JOIN tbl_cad_categorias as c ON p.id_categoria = c.id " _
            & " INNER JOIN tbl_cad_marcas as m ON p.id_marca = m.id " _
            & " INNER JOIN tbl_cad_locais as l on p.id_local = l.id " _
            & " INNER JOIN tbl_cad_fornecedores as f on p.id_fornecedor = f.id Order By p.id asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            dt.DefaultView.RowFilter = "descricao LIKE " & "'%" & TxtPesquisar.Text & "%'"
            DataGrid.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub

    Private Sub BtnTodos_Click(sender As Object, e As EventArgs) Handles BtnTodos.Click
        Carregar_DataGrid()
    End Sub

    Private Sub BtnAtivos_Click(sender As Object, e As EventArgs) Handles BtnAtivos.Click
        Try
            Abrir()
            Dim dt As New DataTable
            Dim sql As String
            Dim da As MySqlDataAdapter
            Dim stat As String
            stat = "Ativo"

            sql = "SELECT  p.id, p.cod_barras, p.descricao, c.categoria, m.marca, p.id_fornecedor, f.nome, p.preco_venda, p.preco_custo, p.markup, " _
            & " l.local, p.saldo, p.estoque_minimo, p.estoque_maximo, p.prm_promocao, p.prm_data_inicio, p.prm_data_fim, p.prm_preco, p.controle_estoque, p.status, p.data_inclusao,p.id_categoria, p.id_marca, p.id_local " _
            & " From tbl_cad_produtos as p " _
            & " INNER JOIN tbl_cad_categorias as c ON p.id_categoria = c.id " _
            & " INNER JOIN tbl_cad_marcas as m ON p.id_marca = m.id " _
            & " INNER JOIN tbl_cad_locais as l on p.id_local = l.id " _
            & " INNER JOIN tbl_cad_fornecedores as f on p.id_fornecedor = f.id Order By p.id asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            dt.DefaultView.RowFilter = "status LIKE '" & stat & "'"
            DataGrid.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub

    Private Sub BtnInativos_Click(sender As Object, e As EventArgs) Handles BtnInativos.Click
        Try
            Abrir()
            Dim dt As New DataTable
            Dim sql As String
            Dim da As MySqlDataAdapter
            Dim stat As String
            stat = "Inativo"

            sql = "SELECT  p.id, p.cod_barras, p.descricao, c.categoria, m.marca, p.id_fornecedor, f.nome, p.preco_venda, p.preco_custo, p.markup, " _
            & " l.local, p.saldo, p.estoque_minimo, p.estoque_maximo, p.prm_promocao, p.prm_data_inicio, p.prm_data_fim, p.prm_preco, p.controle_estoque, p.status, p.data_inclusao,p.id_categoria, p.id_marca, p.id_local " _
            & " From tbl_cad_produtos as p " _
            & " INNER JOIN tbl_cad_categorias as c ON p.id_categoria = c.id " _
            & " INNER JOIN tbl_cad_marcas as m ON p.id_marca = m.id " _
            & " INNER JOIN tbl_cad_locais as l on p.id_local = l.id " _
            & " INNER JOIN tbl_cad_fornecedores as f on p.id_fornecedor = f.id Order By p.id asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            dt.DefaultView.RowFilter = "status LIKE '" & stat & "'"
            DataGrid.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub

    Private Sub BtnInativar_Click(sender As Object, e As EventArgs) Handles BtnInativar.Click

        Inativar_Produto()

    End Sub

    Sub Inativar_Produto()
        If DataGrid.SelectedRows.Count = 1 Then
            Try
                Abrir()
                Dim cmd As MySqlCommand
                Dim sqls As String
                Dim stat As String
                Dim cod As String
                stat = "Inativo"
                cod = DataGrid.CurrentRow.Cells(0).Value

                If MsgBox("Deseja inativar esse produto ?", vbYesNo, "Inativar Produto") = vbYes Then
                    sqls = "UPDATE tbl_cad_produtos SET status =  '" & stat & "' WHERE id = '" & cod & "' "
                    cmd = New MySqlCommand(sqls, con)
                    cmd.ExecuteNonQuery()

                    Carregar_DataGrid()
                End If
            Catch ex As Exception
                MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub DataGrid_SelectionChanged(sender As Object, e As EventArgs) Handles DataGrid.SelectionChanged
        Dim status As String

        If DataGrid.SelectedRows.Count > 0 Then

            status = DataGrid.CurrentRow.Cells(19).Value

            If status = "Inativo" Then
                BtnInativar.Enabled = False
            End If
            If status = "Ativo" Then
                BtnInativar.Enabled = True
            End If

        End If
    End Sub

    Private Sub BtnCancelar_Click_1(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnCopiar_Click(sender As Object, e As EventArgs) Handles BtnCopiar.Click
        Copiar_Produto()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Editar_Produto()
    End Sub

    Private Sub BtnPrecoVenda_Click(sender As Object, e As EventArgs) Handles BtnPrecoVenda.Click
        Editar_PrecoVenda()
    End Sub

    Sub Editar_PrecoVenda()


        If DataGrid.SelectedRows.Count = 1 Then
            Dim form As New Frm_cad_precoVenda

            form.TxtCod.Text = DataGrid.CurrentRow.Cells(0).Value
            form.TxtDescricao.Text = DataGrid.CurrentRow.Cells(2).Value
            form.TxtPvenda.Text = DataGrid.CurrentRow.Cells(7).Value
            form.TxtPcusto.Text = DataGrid.CurrentRow.Cells(8).Value
            form.TxtMarkup.Text = DataGrid.CurrentRow.Cells(9).Value
            form.TxtDescricao.Enabled = False
            form.BtnPesquisarProd.Visible = False
            form.ShowDialog()
        End If
    End Sub

    Private Sub BtnSelecionar_Click(sender As Object, e As EventArgs) Handles BtnSelecionar.Click
        If PesqProd = "True" Then
            DadosProduto()
            Me.Close()
        End If

    End Sub
    Sub DadosProduto()

        IdProd = DataGrid.CurrentRow.Cells(0).Value
        NomeProd = DataGrid.CurrentRow.Cells(2).Value
        PrecoVenda = DataGrid.CurrentRow.Cells(7).Value
        PrecoCusto = DataGrid.CurrentRow.Cells(8).Value
        Markup = DataGrid.CurrentRow.Cells(9).Value

        BtnSelecionar.Visible = False

    End Sub
    Private Sub DataGrid_DoubleClick(sender As Object, e As EventArgs) Handles DataGrid.DoubleClick
        If PesqProd = "True" Then
            DadosProduto()
            Me.Close()
        End If
    End Sub

    Private Sub Frm_cad_produtos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        PesProdTelaProd = ""
    End Sub

    Private Sub BtnPromocao_Click(sender As Object, e As EventArgs) Handles BtnPromocao.Click
        Promocao()
    End Sub

    Sub Promocao()
        If DataGrid.SelectedRows.Count = 1 Then

            Dim form As New Frm_cad_promocao
            form.TxtCod.Text = DataGrid.CurrentRow.Cells(0).Value
            form.TxtDescricao.Text = DataGrid.CurrentRow.Cells(2).Value
            form.TxtPvenda.Text = DataGrid.CurrentRow.Cells(7).Value
            form.TxtPcusto.Text = DataGrid.CurrentRow.Cells(8).Value

            form.TxtDescricao.Enabled = False
            form.BtnPesquisarProd.Visible = False
            form.ShowDialog()
        End If
    End Sub

    Private Sub BtnExibirPromocao_Click(sender As Object, e As EventArgs) Handles BtnExibirPromocao.Click
        Try
            Abrir()
            Dim dt As New DataTable
            Dim sql As String
            Dim da As MySqlDataAdapter
            Dim stat As String
            stat = "Sim"

            sql = "SELECT  p.id, p.cod_barras, p.descricao, c.categoria, m.marca, p.id_fornecedor, f.nome, p.preco_venda, p.preco_custo, p.markup, " _
            & " l.local, p.saldo, p.estoque_minimo, p.estoque_maximo, p.prm_promocao, p.prm_data_inicio, p.prm_data_fim, p.prm_preco, p.controle_estoque, p.status, p.data_inclusao,p.id_categoria, p.id_marca, p.id_local " _
            & " From tbl_cad_produtos as p " _
            & " INNER JOIN tbl_cad_categorias as c ON p.id_categoria = c.id " _
            & " INNER JOIN tbl_cad_marcas as m ON p.id_marca = m.id " _
            & " INNER JOIN tbl_cad_locais as l on p.id_local = l.id " _
            & " INNER JOIN tbl_cad_fornecedores as f on p.id_fornecedor = f.id Order By p.id asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            dt.DefaultView.RowFilter = "prm_promocao LIKE '" & stat & "'"
            DataGrid.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub

    Private Sub BtnCancelar_Click_2(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnExportarExcel_Click(sender As Object, e As EventArgs)
        Using sfd As New SaveFileDialog() With {.Filter = "Excel Workbook| *.xlsx"}
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using workbook As New XLWorkbook
                        workbook.Worksheets.Add(DataGrid.DataSource, "Cadastro Produtos")
                        workbook.SaveAs(sfd.FileName)
                    End Using
                    MessageBox.Show("Dados exportados com sucesso!", "Exportar dados Excel", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Exportar dados Excel", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        End Using
    End Sub
End Class