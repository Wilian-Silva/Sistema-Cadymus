Imports MySql.Data.MySqlClient

Public Class Frm_cad_consultaFornecedores
    Private Sub LbFiltro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LbFiltro.LinkClicked
        Dim heig As String
        heig = PanelB.Height

        CbSitucao.Text = ""
        CbTipo.Text = ""
        TxtCidade.Text = ""
        Txtnome.Text = ""
        Txtnome.Focus()

        If heig <> 75 Or heig = 0 Then

            PanelB.Height = 75
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

            sql = "SELECT * FROM tbl_cad_fornecedores order by id asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro Carregar_DataGrid " + ex.Message)
        End Try

    End Sub

    Private Sub FormatarGrid()

        DataGrid.Columns(0).HeaderText = "Código"
        DataGrid.Columns(1).HeaderText = "Tipo"
        DataGrid.Columns(2).HeaderText = "Nome"
        DataGrid.Columns(3).HeaderText = "CPF/CNPJ"
        DataGrid.Columns(4).Visible = False
        DataGrid.Columns(5).HeaderText = "Endereço"
        DataGrid.Columns(6).HeaderText = "Nº"
        DataGrid.Columns(7).Visible = False
        DataGrid.Columns(8).Visible = False
        DataGrid.Columns(9).Visible = False
        DataGrid.Columns(10).HeaderText = "Cidade"
        DataGrid.Columns(11).Visible = False
        DataGrid.Columns(12).Visible = False
        DataGrid.Columns(13).HeaderText = "Status"
        DataGrid.Columns(14).Visible = False

        DataGrid.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(13).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        PanelB.Height = 0

    End Sub

    Private Sub Btnfiltro_Click(sender As Object, e As EventArgs) Handles Btnfiltro.Click
        Try
            Abrir()
            Dim dt As New DataTable
            Dim sql As String
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM tbl_cad_fornecedores order by id asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            dt.DefaultView.RowFilter = "nome LIKE " & "'" & Txtnome.Text & "%' and tipo LIKE " & "'" & CbTipo.Text & "%' and status LIKE " & "'" & CbSitucao.Text & "%' and cidade LIKE " & "'%" & TxtCidade.Text & "%' "
            DataGrid.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro Btnfiltro_Click " + ex.Message)
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

        If PesqFornec = "True" Then
            IdFornec = DataGrid.CurrentRow.Cells(0).Value
            NomeFornec = DataGrid.CurrentRow.Cells(2).Value

        End If

    End Sub

    Private Sub Frm_cad_consultaProdutos_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Enter And PesqFornec = "True" Then

            DadosProduto()
            Me.Close()

        End If

    End Sub

    Private Sub Selecionar(sender As Object, e As EventArgs) Handles BtnSelecionar.Click, DataGrid.DoubleClick
        If PesqFornec = "True" Then
            DadosProduto()
            Me.Close()
        End If
    End Sub


End Class