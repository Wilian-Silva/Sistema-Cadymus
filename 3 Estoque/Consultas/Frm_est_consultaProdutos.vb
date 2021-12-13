Imports MySql.Data.MySqlClient

Public Class Frm_est_consultaProdutos
    Private Sub LbFiltro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LbFiltro.LinkClicked
        Dim heig As String
        heig = PanelB.Height

        TxtProduto.Text = ""
        TxtProduto.Focus()

        If heig <> 70 Or heig = 0 Then

            PanelB.Height = 70

        Else
            PanelB.Height = 0
            Carregar_DataGrid()

        End If
    End Sub

    Sub Carregar_DataGrid()

        Try
            Abrir()
            Dim dt As New DataTable
            Dim sql As String
            Dim da As MySqlDataAdapter
            sql = "SELECT id, cod_barras, descricao, preco_venda, preco_custo, markup, saldo, prm_promocao, prm_preco, controle_estoque, status from tbl_cad_produtos Order By id asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()

        Catch ex As Exception
            MsgBox("Errp Carregar_DataGrid ---- " + ex.Message)
        End Try
    End Sub
    Private Sub FormatarGrid()

        DataGrid.Columns(0).HeaderText = "Cód. Prod."
        DataGrid.Columns(1).HeaderText = "Cód. Barras"
        DataGrid.Columns(2).HeaderText = "Descrição"
        DataGrid.Columns(3).HeaderText = "Preço Venda"
        DataGrid.Columns(4).HeaderText = "Preço Custo"
        DataGrid.Columns(5).HeaderText = "Markup"
        DataGrid.Columns(6).HeaderText = "Saldo Est."
        DataGrid.Columns(7).HeaderText = "Promoção"
        DataGrid.Columns(8).HeaderText = "Preço Promoção"
        DataGrid.Columns(9).HeaderText = "Controle Est."
        DataGrid.Columns(10).HeaderText = "Status"

        DataGrid.Columns(3).DefaultCellStyle.Format = "c"
        DataGrid.Columns(4).DefaultCellStyle.Format = "c"
        DataGrid.Columns(5).DefaultCellStyle.Format = "p"
        DataGrid.Columns(8).DefaultCellStyle.Format = "c"

        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(10).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        PanelB.Height = 0

    End Sub

    Private Sub Btnfiltro_Click(sender As Object, e As EventArgs) Handles Btnfiltro.Click
        Try
            Abrir()
            Dim dt As New DataTable
            Dim sql As String
            Dim da As MySqlDataAdapter

            sql = "SELECT id, cod_barras, descricao, preco_venda, preco_custo, markup, saldo, prm_promocao, prm_preco, controle_estoque, status from tbl_cad_produtos Order By id asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            dt.DefaultView.RowFilter = "descricao LIKE " & "'%" & TxtProduto.Text & "%' "
            DataGrid.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro Btnfiltro_Click- " + ex.Message)
        End Try
    End Sub

    Private Sub Frm_cad_consultaProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar_DataGrid()
        FormatarGrid()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub


    Sub DadosProduto()

        IdProd = DataGrid.CurrentRow.Cells(0).Value
        NomeProd = DataGrid.CurrentRow.Cells(2).Value
        PrecoVenda = DataGrid.CurrentRow.Cells(3).Value
        PrecoCusto = DataGrid.CurrentRow.Cells(4).Value
        Markup = DataGrid.CurrentRow.Cells(5).Value

    End Sub

    Private Sub Frm_cad_consultaProdutos_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Enter And PesqProd = "True" Then

            DadosProduto()
            Me.Close()

        End If

    End Sub

    Private Sub Selecionar(sender As Object, e As EventArgs) Handles BtnSelecionar.Click, DataGrid.DoubleClick
        If PesqProd = "True" Then
            DadosProduto()
            Me.Close()
        End If
    End Sub


End Class