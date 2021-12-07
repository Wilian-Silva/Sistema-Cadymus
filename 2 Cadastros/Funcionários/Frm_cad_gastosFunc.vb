Imports MySql.Data.MySqlClient

Public Class Frm_cad_gastosFunc

    Private Sub Frm_cad_gastosFunc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Carregar_DataGrid()
        FormatarGrid()
    End Sub
    Private Sub BtnIncluir_Click(sender As Object, e As EventArgs) Handles BtnIncluir.Click
        Dim frm As New Frm_cad_addGastosFunc
        frm.ShowDialog()
    End Sub
    Sub Carregar_DataGrid()
        'Stop
        Try
            Abrir()
            Dim dt As New DataTable
            Dim sql As String
            Dim da As MySqlDataAdapter

            sql = "SELECT g.id, g.id_funcionario, f.nome, f.status, u.funcao, g.salario_base, g.salario_familia, g.13_salario, g.ferias, g.fgts, g.inss_patronal," _
                & "g.vale_ref_alim, g.vale_transporte, g.plano_saude, g.plano_odonto, g.previdencia, g.plr, g.outros, g.descricao_outros, g.data_inclusao, g.id_funcao " _
                    & "FROM tbl_cad_gastosfunc as g INNER JOIN tbl_cad_funcionarios as f on g.id_funcionario = f.id INNER JOIN tbl_cad_funcoes as u ON g.id_funcao = u.id order by g.id asc"


            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            If DataGrid.Rows.Count <> 0 Then
                Dim total_salarioBase As Double
                Dim total_salarioFamilia As Double
                Dim total_13salario As Double
                Dim total_ferias As Double
                Dim total_fgts As Double
                Dim total_inss As Double
                Dim total_valeRef As Double
                Dim total_valeTransp As Double
                Dim total_planoSaude As Double
                Dim total_planoOdonto As Double
                Dim total_planoPrev As Double
                Dim total_plr As Double
                Dim total_outros As Double

                For i As Integer = 0 To DataGrid.Rows.Count - 1
                    total_salarioBase += DataGrid.Rows(i).Cells(5).Value
                    total_salarioFamilia += DataGrid.Rows(i).Cells(6).Value
                    total_13salario += DataGrid.Rows(i).Cells(7).Value
                    total_ferias += DataGrid.Rows(i).Cells(8).Value
                    total_fgts += DataGrid.Rows(i).Cells(9).Value
                    total_inss += DataGrid.Rows(i).Cells(10).Value
                    total_valeRef += DataGrid.Rows(i).Cells(11).Value
                    total_valeTransp += DataGrid.Rows(i).Cells(12).Value
                    total_planoSaude += DataGrid.Rows(i).Cells(13).Value
                    total_planoOdonto += DataGrid.Rows(i).Cells(14).Value
                    total_planoPrev += DataGrid.Rows(i).Cells(15).Value
                    total_plr += DataGrid.Rows(i).Cells(16).Value
                    total_outros += DataGrid.Rows(i).Cells(17).Value


                Next
                'Stop
                dt.Rows.Add(Nothing, Nothing, "Total", Nothing, Nothing, total_salarioBase, total_salarioFamilia, total_13salario, total_ferias, total_fgts, total_inss, total_valeRef, total_valeTransp, total_planoSaude, total_planoOdonto, total_planoPrev, total_plr, total_outros, Nothing, Nothing)

                'Stop
                Dim dgrow As Integer
                dgrow = DataGrid.Rows.Count - 1

                DataGrid.Rows(dgrow).DefaultCellStyle.Font = New Font("SEGOE UI", 10, FontStyle.Bold)
            End If
        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub
    Private Sub FormatarGrid()
        'Stop
        DataGrid.Columns(0).HeaderText = "Código"
        DataGrid.Columns(1).HeaderText = "Matrícula"
        DataGrid.Columns(2).HeaderText = "Funcionário"
        DataGrid.Columns(3).HeaderText = "Status"
        DataGrid.Columns(4).HeaderText = "Cargo/Função"
        DataGrid.Columns(5).HeaderText = "Salário Base"
        DataGrid.Columns(6).HeaderText = "Salário Família"
        DataGrid.Columns(7).HeaderText = "13º Salário"
        DataGrid.Columns(8).HeaderText = "Férias + 1/3"
        DataGrid.Columns(9).HeaderText = "FGTS"
        DataGrid.Columns(10).HeaderText = "INSS Patronal"
        DataGrid.Columns(11).HeaderText = "Vale Ref/Alim"
        DataGrid.Columns(12).HeaderText = "Vale Transp."
        DataGrid.Columns(13).HeaderText = "Plano Saúde"
        DataGrid.Columns(14).HeaderText = "Plano Odonto"
        DataGrid.Columns(15).HeaderText = "Previdencia"
        DataGrid.Columns(16).HeaderText = "PLR"
        DataGrid.Columns(17).HeaderText = "Outros"
        DataGrid.Columns(18).HeaderText = "Descrição"
        DataGrid.Columns(19).HeaderText = "Data Inclusão"
        DataGrid.Columns(20).Visible = False


        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(16).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(17).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(19).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(5).DefaultCellStyle.Format = "c"
        DataGrid.Columns(6).DefaultCellStyle.Format = "c"
        DataGrid.Columns(7).DefaultCellStyle.Format = "c"
        DataGrid.Columns(8).DefaultCellStyle.Format = "c"
        DataGrid.Columns(9).DefaultCellStyle.Format = "c"
        DataGrid.Columns(10).DefaultCellStyle.Format = "c"
        DataGrid.Columns(11).DefaultCellStyle.Format = "c"
        DataGrid.Columns(12).DefaultCellStyle.Format = "c"
        DataGrid.Columns(13).DefaultCellStyle.Format = "c"
        DataGrid.Columns(14).DefaultCellStyle.Format = "c"
        DataGrid.Columns(15).DefaultCellStyle.Format = "c"
        DataGrid.Columns(16).DefaultCellStyle.Format = "c"
        DataGrid.Columns(17).DefaultCellStyle.Format = "c"


        PanelB.Height = 0

    End Sub

    Sub Excluir()

        If DataGrid.SelectedRows.Count = 1 Then
            Dim fun As String
            Dim cod As String
            cod = DataGrid.CurrentRow.Cells(0).Value
            fun = DataGrid.CurrentRow.Cells(2).Value

            If cod <> "" Then

                If MsgBox("Deseja excluir os gastos de " & fun & "?", vbYesNo, "Exclusão") = vbYes Then

                    Try
                        Abrir()

                        'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                        Dim cmd As MySqlCommand
                        Dim sql As String

                        sql = "DELETE FROM tbl_cad_gastosfunc where id = '" & cod & "' "
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

    Private Sub BtnExcuir_Click_1(sender As Object, e As EventArgs) Handles BtnExcuir.Click
        Excluir()
    End Sub



    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnEditar_Click_1(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Editar_Dados()
    End Sub

    Private Sub Editar_Dados()
        If DataGrid.SelectedRows.Count = 1 Then

            Dim form = New Frm_cad_addGastosFunc

            form.TxtCod.Text = DataGrid.CurrentRow.Cells(0).Value
            form.TxtIdFunc.Text = DataGrid.CurrentRow.Cells(1).Value
            form.TxtFuncionario.Text = DataGrid.CurrentRow.Cells(2).Value
            form.TxtSalario.Text = DataGrid.CurrentRow.Cells(5).Value
            form.TxtSalarioFamilia.Text = DataGrid.CurrentRow.Cells(6).Value
            form.Txt13Salario.Text = DataGrid.CurrentRow.Cells(7).Value
            form.TxtFerias.Text = DataGrid.CurrentRow.Cells(8).Value
            form.TxtFgts.Text = DataGrid.CurrentRow.Cells(9).Value
            form.TxtInss.Text = DataGrid.CurrentRow.Cells(10).Value
            form.TxtVrVa.Text = DataGrid.CurrentRow.Cells(11).Value
            form.TxtVt.Text = DataGrid.CurrentRow.Cells(12).Value
            form.TxtOdonto.Text = DataGrid.CurrentRow.Cells(13).Value
            form.TxtSaude.Text = DataGrid.CurrentRow.Cells(14).Value
            form.TxtPrev.Text = DataGrid.CurrentRow.Cells(15).Value
            form.TxtPlr.Text = DataGrid.CurrentRow.Cells(16).Value
            form.TxtOutros.Text = DataGrid.CurrentRow.Cells(17).Value
            form.TxtDescricao.Text = DataGrid.CurrentRow.Cells(18).Value
            form.TxtIdFuncao.Text = DataGrid.CurrentRow.Cells(20).Value
            form.TxtFuncao.Text = DataGrid.CurrentRow.Cells(3).Value

            form.ShowDialog()
        End If

    End Sub

    Private Sub Frm_cad_categorias_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim frm As New Frm_cad_addGastosFunc
            frm.ShowDialog()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        If e.KeyCode = Keys.F2 Then
            Editar_Dados()
        End If

        If e.KeyCode = Keys.Delete Then
            Excluir()
        End If

    End Sub

    Private Sub Frm_cad_marcas_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Carregar_DataGrid()
    End Sub

    Private Sub Frm_cad_funcionarios_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmPesqFunc = ""
    End Sub

    Private Sub Btnfiltro_Click(sender As Object, e As EventArgs) Handles Btnfiltro.Click
        Try
            Abrir()
            Dim dt As New DataTable
            Dim sql As String
            Dim da As MySqlDataAdapter

            'sql = "SELECT * FROM tbl_cad_gastosfunc"

            sql = "SELECT g.id, g.id_funcionario, f.nome,f.status, u.funcao, g.salario_base, g.salario_familia, g.13_salario, g.ferias, g.fgts, g.inss_patronal," _
                & "g.vale_ref_alim, g.vale_transporte, g.plano_saude, g.plano_odonto, g.previdencia, g.plr, g.outros, g.descricao_outros, g.data_inclusao, g.id_funcao " _
                    & "FROM tbl_cad_gastosfunc as g INNER JOIN tbl_cad_funcionarios as f on g.id_funcionario = f.id INNER JOIN tbl_cad_funcoes as u ON g.id_funcao = u.id order by g.id asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            dt.DefaultView.RowFilter = "nome LIKE " & "'" & Txtnome.Text & "%' and funcao LIKE " & "'" & Cbfuncao.Text & "%'  "
            DataGrid.DataSource = dt


        Catch ex As Exception
            MsgBox("Erro Btnfiltro_Clic " + ex.Message)
        End Try
    End Sub

    Private Sub LbFiltro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LbFiltro.LinkClicked
        Dim heig As String
        heig = PanelB.Height

        Txtnome.Text = ""
        Txtnome.Focus()

        If heig <> 65 Or heig = 0 Then

            PanelB.Height = 65
            Carregar_funcoes()
        Else
            PanelB.Height = 0
            Carregar_DataGrid()

        End If
    End Sub

    Private Sub Carregar_funcoes()

        Try
            Abrir()
            Dim dt As New DataTable
            Dim sql As String
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM tbl_cad_funcoes order by funcao asc "

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            Cbfuncao.ValueMember = "id"
            Cbfuncao.DisplayMember = "funcao"
            Cbfuncao.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro Carregar_funcoes " + ex.Message)
        End Try

    End Sub


End Class