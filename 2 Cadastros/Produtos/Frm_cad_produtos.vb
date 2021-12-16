Imports ClosedXML.Excel
Imports MySql.Data.MySqlClient

Public Class Frm_cad_produtos
    Private Sub Frm_cad_produtos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PesProdTelaProd = "True"
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

    End Sub

    Private Sub Copiar_Produto()
        If DataGrid.SelectedRows.Count = 1 Then
            Dim form = New Frm_cad_addProdutos


            If IsDBNull(DataGrid.CurrentRow.Cells(3).Value) Then
                form.TxtCategoria.Text = ""
            Else
                form.TxtCategoria.Text = DataGrid.CurrentRow.Cells(3).Value
            End If

            If IsDBNull(DataGrid.CurrentRow.Cells(4).Value) Then
                form.TxtMarca.Text = ""
            Else
                form.TxtMarca.Text = DataGrid.CurrentRow.Cells(4).Value
            End If

            If IsDBNull(DataGrid.CurrentRow.Cells(10).Value) Then
                form.TxtLocal.Text = ""
            Else
                form.TxtLocal.Text = DataGrid.CurrentRow.Cells(10).Value
            End If
            If IsDBNull(DataGrid.CurrentRow.Cells(6).Value) Then
                form.TxtForncedor.Text = ""
            Else
                form.TxtForncedor.Text = DataGrid.CurrentRow.Cells(6).Value
            End If

            If IsDBNull(DataGrid.CurrentRow.Cells(11).Value) Then
                form.TxtUndMedida.Text = ""
            Else
                form.TxtUndMedida.Text = DataGrid.CurrentRow.Cells(11).Value
            End If

            form.TxtDescricao.Text = DataGrid.CurrentRow.Cells(2).Value
            form.TxtIdCategoria.Text = DataGrid.CurrentRow.Cells(22).Value
            form.TxtIdMarca.Text = DataGrid.CurrentRow.Cells(23).Value
            form.TxtIdLocal.Text = DataGrid.CurrentRow.Cells(24).Value
            form.TxtIdUndMedida.Text = DataGrid.CurrentRow.Cells(25).Value

            form.TxtIdFornec.Text = DataGrid.CurrentRow.Cells(5).Value
            form.TxtPvenda.Text = DataGrid.CurrentRow.Cells(7).Value
            form.TxtPcusto.Text = DataGrid.CurrentRow.Cells(8).Value
            form.TxtMarkup.Text = DataGrid.CurrentRow.Cells(9).Value
            form.TxtSaldoProd.Text = DataGrid.CurrentRow.Cells(12).Value
            form.TxtEstMinimo.Text = DataGrid.CurrentRow.Cells(13).Value
            form.TxtEstMaximo.Text = DataGrid.CurrentRow.Cells(14).Value
            form.DataInicio.Text = DataGrid.CurrentRow.Cells(16).Value
            form.DataFim.Text = DataGrid.CurrentRow.Cells(17).Value
            form.TxtPpromocao.Text = DataGrid.CurrentRow.Cells(18).Value

            '//PRODUTO PROMOÇÃO
            If DataGrid.CurrentRow.Cells(15).Value = "Sim" Then
                form.CboxPromocao.Checked = True
            End If

            '//CONTROLE ESTOQUE
            If DataGrid.CurrentRow.Cells(19).Value = "Sim" Then
                form.CboxEstoque.Checked = True
            Else
                form.CboxEstoque.Checked = False
            End If

            '//SATUS PRODUTO
            If DataGrid.CurrentRow.Cells(20).Value = "Ativo" Then
                form.RbAtivo.Checked = True
            End If
            If DataGrid.CurrentRow.Cells(20).Value = "Inativo" Then
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

            If IsDBNull(DataGrid.CurrentRow.Cells(3).Value) Then
                form.TxtCategoria.Text = ""
            Else
                form.TxtCategoria.Text = DataGrid.CurrentRow.Cells(3).Value
            End If

            If IsDBNull(DataGrid.CurrentRow.Cells(4).Value) Then
                form.TxtMarca.Text = ""
            Else
                form.TxtMarca.Text = DataGrid.CurrentRow.Cells(4).Value
            End If

            If IsDBNull(DataGrid.CurrentRow.Cells(10).Value) Then
                form.TxtLocal.Text = ""
            Else
                form.TxtLocal.Text = DataGrid.CurrentRow.Cells(10).Value
            End If
            If IsDBNull(DataGrid.CurrentRow.Cells(6).Value) Then
                form.TxtForncedor.Text = ""
            Else
                form.TxtForncedor.Text = DataGrid.CurrentRow.Cells(6).Value
            End If

            If IsDBNull(DataGrid.CurrentRow.Cells(11).Value) Then
                form.TxtUndMedida.Text = ""
            Else
                form.TxtUndMedida.Text = DataGrid.CurrentRow.Cells(11).Value
            End If

            form.TxtCod.Text = DataGrid.CurrentRow.Cells(0).Value
            form.TxtCodBarras.Text = DataGrid.CurrentRow.Cells(1).Value
            form.TxtDescricao.Text = DataGrid.CurrentRow.Cells(2).Value

            form.TxtIdCategoria.Text = DataGrid.CurrentRow.Cells(22).Value
            form.TxtIdMarca.Text = DataGrid.CurrentRow.Cells(23).Value
            form.TxtIdLocal.Text = DataGrid.CurrentRow.Cells(24).Value
            form.TxtIdUndMedida.Text = DataGrid.CurrentRow.Cells(25).Value

            form.TxtIdFornec.Text = DataGrid.CurrentRow.Cells(5).Value
            form.TxtPvenda.Text = DataGrid.CurrentRow.Cells(7).Value
            form.TxtPcusto.Text = DataGrid.CurrentRow.Cells(8).Value
            form.TxtMarkup.Text = DataGrid.CurrentRow.Cells(9).Value
            form.TxtSaldoProd.Text = DataGrid.CurrentRow.Cells(12).Value
            form.TxtEstMinimo.Text = DataGrid.CurrentRow.Cells(13).Value
            form.TxtEstMaximo.Text = DataGrid.CurrentRow.Cells(14).Value
            form.DataInicio.Text = DataGrid.CurrentRow.Cells(16).Value
            form.DataFim.Text = DataGrid.CurrentRow.Cells(17).Value
            form.TxtPpromocao.Text = DataGrid.CurrentRow.Cells(18).Value

            '//PRODUTO PROMOÇÃO
            If DataGrid.CurrentRow.Cells(15).Value = "Sim" Then
                form.CboxPromocao.Checked = True
            End If

            '//CONTROLE ESTOQUE
            If DataGrid.CurrentRow.Cells(19).Value = "Sim" Then
                form.CboxEstoque.Checked = True
            Else
                form.CboxEstoque.Checked = False
            End If

            '//SATUS PRODUTO
            If DataGrid.CurrentRow.Cells(20).Value = "Ativo" Then
                form.RbAtivo.Checked = True
            End If
            If DataGrid.CurrentRow.Cells(20).Value = "Inativo" Then
                form.RbInativo.Checked = True
            End If

            form.ShowDialog()
        End If
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Sub Carregar_DataGrid()

        Try
            Abrir()
            Dim dt As New DataTable
            Dim sql As String
            Dim da As MySqlDataAdapter

            sql = "SELECT  p.id, p.cod_barras, p.descricao, c.categoria, m.marca, p.id_fornecedor, f.nome, p.preco_venda, p.preco_custo, p.markup, " _
            & " l.local, u.und_medida, p.saldo,  p.estoque_minimo, p.estoque_maximo, p.prm_promocao, p.prm_data_inicio, p.prm_data_fim, p.prm_preco, p.controle_estoque, p.status, p.data_inclusao, p.id_categoria, p.id_marca, p.id_local, p.id_undmedida " _
            & " From tbl_cad_produtos as p " _
            & " LEFT JOIN tbl_cad_categorias as c ON p.id_categoria = c.id " _
            & " LEFT JOIN tbl_cad_marcas as m ON p.id_marca = m.id " _
            & " LEFT JOIN tbl_cad_locais as l on p.id_local = l.id " _
            & " LEFT JOIN tbl_cad_undmedidas as u on p.id_undmedida = u.id " _
            & " LEFT JOIN tbl_cad_fornecedores as f on p.id_fornecedor = f.id Order By p.id asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

        Catch ex As Exception
            MsgBox("Errp Carregar_DataGrid ---- " + ex.Message)
        End Try
    End Sub
    Private Sub FormatarGrid()

        DataGrid.Columns(0).HeaderText = "Cód. Prod."
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
        DataGrid.Columns(11).HeaderText = "Und. Medida"
        DataGrid.Columns(12).HeaderText = "Saldo Est."
        DataGrid.Columns(13).HeaderText = "Est. Mínimo"
        DataGrid.Columns(14).HeaderText = "Est. Máximo"
        DataGrid.Columns(15).HeaderText = "Promoção"
        DataGrid.Columns(16).HeaderText = "Data Início"
        DataGrid.Columns(17).HeaderText = "Data Fim"
        DataGrid.Columns(18).HeaderText = "Preço Promoção"
        DataGrid.Columns(19).HeaderText = "Controle Est."
        DataGrid.Columns(20).HeaderText = "Status"
        DataGrid.Columns(21).HeaderText = "Data Inclusão"
        DataGrid.Columns(22).Visible = False
        DataGrid.Columns(23).Visible = False
        DataGrid.Columns(24).Visible = False
        DataGrid.Columns(25).Visible = False

        DataGrid.Columns(7).DefaultCellStyle.Format = "c"
        DataGrid.Columns(8).DefaultCellStyle.Format = "c"
        DataGrid.Columns(9).DefaultCellStyle.Format = "p"
        DataGrid.Columns(18).DefaultCellStyle.Format = "c"


        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(11).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(12).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(13).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(14).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(15).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(16).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(17).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(19).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(20).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(21).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        PanelB.Height = 0


    End Sub

    Private Sub Frm_cad_produtos_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If filtro = "True" Then Exit Sub

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
                Dim prod As String
                stat = "Inativo"
                cod = DataGrid.CurrentRow.Cells(0).Value
                prod = DataGrid.CurrentRow.Cells(2).Value

                If MsgBox("Deseja inativar o produto: " & prod & " ?", vbYesNo, "Inativar Produto") = vbYes Then
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

        If PesqProd = "True" Then Exit Sub

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

    Private Sub BtnExportarExcel_Click(sender As Object, e As EventArgs) Handles BtnExportarExcel.Click

        Using sfd As New SaveFileDialog() With {.Filter = "Excel Workbook| *.xlsx"}
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using workbook As New XLWorkbook()
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

    Private Sub Btnfiltro_Click(sender As Object, e As EventArgs) Handles Btnfiltro.Click
        Try
            'Stop
            Abrir()

            Dim colunaA As String = "p.descricao"
            Dim colunaB As String = "p.descricao"

            '\\FILTRO A
            If CbFiltroA.Text = "Cód.Prod" Then
                colunaA = "p.id"
            End If
            If CbFiltroA.Text = "Cód.Barras" Then
                colunaA = "p.cod_barras"
            End If
            If CbFiltroA.Text = "Produto" Then
                colunaA = "p.descricao"
            End If
            If CbFiltroA.Text = "Categoria" Then
                colunaA = "c.categoria"
            End If
            If CbFiltroA.Text = "Marca" Then
                colunaA = "m.marca"
            End If
            If CbFiltroA.Text = "Fornecedor" Then
                colunaA = "f.nome"
            End If
            If CbFiltroA.Text = "Localização" Then
                colunaA = "l.local"
            End If
            If CbFiltroA.Text = "Status" Then
                colunaA = "p.status"
            End If
            If CbFiltroA.Text = "Promoção" Then
                colunaA = "p.prm_promocao"
            End If
            If CbFiltroA.Text = "Controle Estoque" Then
                colunaA = "p.controle_estoque"
            End If

            '\\FILTRO B
            If CbFiltroB.Text = "Cód.Prod" Then
                colunaB = "p.id"
            End If
            If CbFiltroB.Text = "Cód.Barras" Then
                colunaB = "p.cod_barras"
            End If
            If CbFiltroB.Text = "Produto" Then
                colunaB = "p.descricao"
            End If
            If CbFiltroB.Text = "Categoria" Then
                colunaB = "c.categoria"
            End If
            If CbFiltroB.Text = "Marca" Then
                colunaB = "m.marca"
            End If
            If CbFiltroB.Text = "Fornecedor" Then
                colunaB = "f.nome"
            End If
            If CbFiltroB.Text = "Localização" Then
                colunaB = "l.local"
            End If
            If CbFiltroB.Text = "Status" Then
                colunaB = "p.status"
            End If
            If CbFiltroB.Text = "Promoção" Then
                colunaB = "p.prm_promocao"
            End If
            If CbFiltroB.Text = "Controle Estoque" Then
                colunaB = "p.controle_estoque"
            End If

            If CbFiltroA.Text = "" Then
                colunaA = "p.descricao"
            End If

            If CbFiltroB.Text = "" Then
                colunaB = colunaA
            End If

            Dim dt As New DataTable
            Dim sql As String
            Dim da As MySqlDataAdapter

            sql = "SELECT  p.id, p.cod_barras, p.descricao, c.categoria, m.marca, p.id_fornecedor, f.nome, p.preco_venda, p.preco_custo, p.markup, " _
                & " l.local, u.und_medida, p.saldo,  p.estoque_minimo, p.estoque_maximo, p.prm_promocao, p.prm_data_inicio, p.prm_data_fim, p.prm_preco, " _
                & " p.controle_estoque, p.status, p.data_inclusao, p.id_categoria, p.id_marca, p.id_local, p.id_undmedida From tbl_cad_produtos as p " _
                & " LEFT JOIN tbl_cad_categorias as c ON p.id_categoria = c.id " _
                & " LEFT JOIN tbl_cad_marcas as m ON p.id_marca = m.id " _
                & " LEFT JOIN tbl_cad_locais as l on p.id_local = l.id " _
                & " LEFT JOIN tbl_cad_undmedidas as u on p.id_undmedida = u.id " _
                & " LEFT JOIN tbl_cad_fornecedores as f on p.id_fornecedor = f.id  " _
                & " WHERE " & colunaA & " Like '" & TxtFiltroA.Text & "%' AND " & colunaB & " Like '" & TxtFiltroB.Text & "%' Order By p.id asc "

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro Btnfiltro_Click- " + ex.Message)
        End Try
    End Sub

    Private Sub LbFiltro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LbFiltro.LinkClicked

        Dim heig As String
        heig = PanelB.Height

        CbFiltroA.Text = ""
        TxtFiltroA.Text = ""
        CbFiltroB.Text = ""
        TxtFiltroB.Text = ""

        If heig <> 80 Or heig = 0 Then

            PanelB.Height = 80
            filtro = "True"

        Else
            filtro = ""
            PanelB.Height = 0
            Carregar_DataGrid()

        End If
    End Sub


End Class