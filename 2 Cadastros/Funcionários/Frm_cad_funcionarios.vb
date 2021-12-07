Imports MySql.Data.MySqlClient

Public Class Frm_cad_funcionarios
    Private Sub Frm_cad_funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If FrmPesqFunc = "True" Then
            BtnSelecionar.Enabled = True
        End If
        Carregar_DataGrid()
        FormatarGrid()
    End Sub
    Private Sub BtnIncluir_Click(sender As Object, e As EventArgs) Handles BtnIncluir.Click
        Dim frm As New Frm_cad_addFuncionarios
        frm.ShowDialog()
    End Sub
    Sub Carregar_DataGrid()
        'Stop
        Try
            Abrir()
            Dim dt As New DataTable
            Dim sql As String
            Dim da As MySqlDataAdapter

            'sql = "SELECT * FROM tbl_cad_funcionarios order by id asc"
            sql = "SELECT f.id, p.funcao, f.nome, f.cpf, f.status, f.cep, f.endereco, f.numero, f.comp, f.estado, f.bairro, f.cidade, f.telefone, f.email, f.data_inclusao, f.id_funcao FROM tbl_cad_funcionarios as f INNER JOIN tbl_cad_funcoes as p ON f.id_funcao = p.id order by p.id asc "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro ao  Carregar_DataGrid " + ex.Message)
        End Try
    End Sub
    Private Sub FormatarGrid()


        DataGrid.Columns(0).HeaderText = "Matrícula"
        DataGrid.Columns(1).HeaderText = "Função"
        DataGrid.Columns(2).HeaderText = "Funcionário"
        DataGrid.Columns(3).HeaderText = "CPF"
        DataGrid.Columns(4).HeaderText = "Status"
        DataGrid.Columns(5).HeaderText = "CEP"
        DataGrid.Columns(6).HeaderText = "Endereço"
        DataGrid.Columns(7).HeaderText = "Nº"
        DataGrid.Columns(8).HeaderText = "Comp."
        DataGrid.Columns(9).HeaderText = "Estado"
        DataGrid.Columns(10).HeaderText = "Bairro"
        DataGrid.Columns(11).HeaderText = "Cidade"
        DataGrid.Columns(12).HeaderText = "Telefone"
        DataGrid.Columns(13).HeaderText = "Email"
        'DataGrid.Columns(14).HeaderText = "Usuário"
        'DataGrid.Columns(15).Visible = False
        DataGrid.Columns(14).HeaderText = "Data Inclusão"
        DataGrid.Columns(15).Visible = False


        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(12).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(14).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        PanelB.Height = 0

    End Sub


    Sub Excluir()

        If DataGrid.SelectedRows.Count = 1 Then
            Dim produto As String
            Dim cod As String

            cod = DataGrid.CurrentRow.Cells(0).Value
            produto = DataGrid.CurrentRow.Cells(2).Value


            If cod <> "" Then


                If MsgBox("Deseja excluir funcionário " & produto & "?", vbYesNo, "Exclusão") = vbYes Then

                    Try
                        Abrir()

                        'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                        Dim cmd As MySqlCommand
                        Dim sql As String

                        sql = "DELETE FROM tbl_cad_funcionarios where id = '" & cod & "' "
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

    Private Sub BtnEditar_Click_1(sender As Object, e As EventArgs) Handles BtnEditar.Click, BtnInativar.Click
        Editar_Dados()
    End Sub

    Private Sub Editar_Dados()
        If DataGrid.SelectedRows.Count = 1 Then

            Dim form = New Frm_cad_addFuncionarios

            form.TxtCod.Text = DataGrid.CurrentRow.Cells(0).Value
            form.TxtFuncao.Text = DataGrid.CurrentRow.Cells(1).Value
            form.TxtNome.Text = DataGrid.CurrentRow.Cells(2).Value
            form.TxtCpf.Text = DataGrid.CurrentRow.Cells(3).Value

            form.TxtCep.Text = DataGrid.CurrentRow.Cells(5).Value
            form.TxtEndereco.Text = DataGrid.CurrentRow.Cells(6).Value
            form.TxtNum.Text = DataGrid.CurrentRow.Cells(7).Value
            form.TxtComp.Text = DataGrid.CurrentRow.Cells(8).Value
            form.TxtEstado.Text = DataGrid.CurrentRow.Cells(9).Value
            form.TxtBairro.Text = DataGrid.CurrentRow.Cells(10).Value
            form.TxtCidade.Text = DataGrid.CurrentRow.Cells(11).Value
            form.TxtTel.Text = DataGrid.CurrentRow.Cells(12).Value
            form.TxtEmail.Text = DataGrid.CurrentRow.Cells(13).Value
            form.TxtIdFuncao.Text = DataGrid.CurrentRow.Cells(15).Value

            form.TxtCpf.Enabled = False
            '//SATUS
            If DataGrid.CurrentRow.Cells(4).Value = "Ativo" Then
                form.RbAtivo.Checked = True
            End If
            If DataGrid.CurrentRow.Cells(4).Value = "Inativo" Then
                form.RbInativo.Checked = True
            End If

            form.ShowDialog()
        End If

    End Sub

    Private Sub Frm_cad_categorias_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim frm As New Frm_cad_addFuncionarios
            frm.ShowDialog()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        If e.KeyCode = Keys.F2 Then
            Editar_Dados()
        End If

        If e.KeyCode = Keys.F5 Then
            Inativar()
        End If

        If e.KeyCode = Keys.Delete Then
            Excluir()
        End If

        If e.KeyCode = Keys.Enter And FrmPesqFunc = "True" Then

            Selecionar()
            Me.Close()

        End If


    End Sub

    Private Sub Frm_cad_marcas_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        Carregar_DataGrid()
    End Sub


    Private Sub BtnInativar_Click(sender As Object, e As EventArgs)
        Inativar()
    End Sub

    Private Sub Inativar()

        If DataGrid.SelectedRows.Count = 1 Then
            Try
                Abrir()
                Dim cmd As MySqlCommand
                Dim sqls As String
                Dim stat As String
                Dim cod As String
                stat = "Inativo"
                cod = DataGrid.CurrentRow.Cells(0).Value

                If MsgBox("Deseja inativar esse funcionário?", vbYesNo, "Inativar Funcionário") = vbYes Then

                    sqls = "UPDATE tbl_cad_funcionarios SET status =  '" & stat & "' WHERE id = '" & cod & "' "
                    cmd = New MySqlCommand(sqls, con)
                    cmd.ExecuteNonQuery()

                    Carregar_DataGrid()
                End If
            Catch ex As Exception
                MsgBox("Erro ao Inativar" + ex.Message)
            End Try
        End If
    End Sub

    Private Sub DataGrid_SelectionChanged(sender As Object, e As EventArgs) Handles DataGrid.SelectionChanged
        Dim status As String

        If DataGrid.SelectedRows.Count = 1 Then

            status = DataGrid.CurrentRow.Cells(4).Value
            If status = "Inativo" Then
                BtnInativar.Enabled = False
            End If
            If status = "Ativo" Then
                BtnInativar.Enabled = True
            End If

        End If
    End Sub


    Private Sub BtnSelecionar_Click(sender As Object, e As EventArgs) Handles BtnSelecionar.Click
        Selecionar()
        Me.Close()
    End Sub

    Private Sub DataGrid_DoubleClick(sender As Object, e As EventArgs) Handles DataGrid.DoubleClick
        Selecionar()
        Me.Close()
    End Sub

    Sub Selecionar()
        PesqFunc = "True"
        If DataGrid.SelectedRows.Count = 1 Then
            IdFunc = DataGrid.CurrentRow.Cells(0).Value
            NomeFunc = DataGrid.CurrentRow.Cells(2).Value

            FuncaoFunc = DataGrid.CurrentRow.Cells(1).Value
            IdFuncaoFunc = DataGrid.CurrentRow.Cells(15).Value

            BtnSelecionar.Enabled = False

        End If
    End Sub

    Private Sub Frm_cad_funcionarios_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmPesqFunc = ""
    End Sub

    Private Sub LbFiltro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LbFiltro.LinkClicked
        Dim heig As String
        heig = PanelB.Height

        CbSitucao.Text = ""
        Cbfuncao.Text = ""
        TxtCidade.Text = ""
        Txtnome.Text = ""
        Txtnome.Focus()

        If heig <> 75 Or heig = 0 Then

            PanelB.Height = 75
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

    Private Sub Btnfiltro_Click(sender As Object, e As EventArgs) Handles Btnfiltro.Click
        Try
            Abrir()
            Dim dt As New DataTable
            Dim sql As String
            Dim da As MySqlDataAdapter

            sql = "SELECT f.id, p.funcao, f.nome, f.cpf, f.status, f.cep, f.endereco, f.numero, f.comp, f.estado, f.bairro, f.cidade, f.telefone, f.email,  f.data_inclusao, f.id_funcao FROM tbl_cad_funcionarios as f INNER JOIN tbl_cad_funcoes as p ON f.id_funcao = p.id order by p.id asc "

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            dt.DefaultView.RowFilter = "nome LIKE " & "'" & Txtnome.Text & "%' and funcao LIKE " & "'" & Cbfuncao.Text & "%' and status LIKE " & "'" & CbSitucao.Text & "%' and cidade LIKE " & "'%" & TxtCidade.Text & "%'  "
            DataGrid.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro Btnfiltro_Click " + ex.Message)
        End Try
    End Sub
End Class