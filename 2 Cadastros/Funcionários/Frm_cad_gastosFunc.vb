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

            sql = "SELECT g.id, g.id_funcionario, f.nome, u.funcao, f.status, g.salario_base, g.salario_familia, g.13_salario, g.ferias, g.fgts, g.inss_patronal," _
                & "g.vale_ref_alim, g.vale_transporte, g.plano_saude, g.plano_odonto, g.previdencia, g.plr, g.outros, g.descricao_outros, g.data_inclusao, g.id_funcao " _
                    & "FROM tbl_cad_gastosfunc as g INNER JOIN tbl_cad_funcionarios as f on g.id_funcionario = f.id INNER JOIN tbl_cad_funcoes as u ON g.id_funcao = u.id order by g.id asc"


            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub
    Private Sub FormatarGrid()
        'Stop
        DataGrid.Columns(0).HeaderText = "Código"
        DataGrid.Columns(1).HeaderText = "Matrícula"
        DataGrid.Columns(2).HeaderText = "Funcionário"
        DataGrid.Columns(3).HeaderText = "Cargo/Função"
        DataGrid.Columns(4).HeaderText = "Status"
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

        DataGrid.Columns(0).Width = 80
        DataGrid.Columns(1).Width = 80
        DataGrid.Columns(2).Width = 200
        DataGrid.Columns(3).Width = 150
        DataGrid.Columns(4).Width = 70
        DataGrid.Columns(5).Width = 100
        DataGrid.Columns(6).Width = 120
        DataGrid.Columns(7).Width = 100
        DataGrid.Columns(8).Width = 100
        DataGrid.Columns(9).Width = 100
        DataGrid.Columns(10).Width = 100
        DataGrid.Columns(11).Width = 100
        DataGrid.Columns(12).Width = 100
        DataGrid.Columns(13).Width = 100
        DataGrid.Columns(14).Width = 100
        DataGrid.Columns(16).Width = 100
        DataGrid.Columns(17).Width = 100
        DataGrid.Columns(18).Width = 200
        DataGrid.Columns(19).Width = 100

    End Sub

    Sub Excluir()

        If DataGrid.SelectedRows.Count = 1 Then

            Dim cod As String
            cod = DataGrid.CurrentRow.Cells(0).Value

            If cod <> "" Then

                If MsgBox("Deseja excluir esse registro ?", vbYesNo, "Exclusão") = vbYes Then

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

    Private Sub TxtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisar.TextChanged

        Try
            Abrir()
            Dim dt As New DataTable
            Dim sql As String
            Dim da As MySqlDataAdapter

            'sql = "SELECT * FROM tbl_cad_gastosfunc"

            sql = "SELECT g.id, g.id_funcionario, f.nome, u.funcao, f.status, g.salario_base, g.salario_familia, g.13_salario, g.ferias, g.fgts, g.inss_patronal," _
                & "g.vale_ref_alim, g.vale_transporte, g.plano_saude, g.plano_odonto, g.previdencia, g.plr, g.outros, g.descricao_outros, g.data_inclusao, g.id_funcao " _
                    & "FROM tbl_cad_gastosfunc as g INNER JOIN tbl_cad_funcionarios as f on g.id_funcionario = f.id INNER JOIN tbl_cad_funcoes as u ON g.id_funcao = u.id order by g.id asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            dt.DefaultView.RowFilter = "nome LIKE " & "'%" & TxtPesquisar.Text & "%'"
            DataGrid.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs)
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
End Class