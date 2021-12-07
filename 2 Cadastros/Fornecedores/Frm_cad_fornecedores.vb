Imports MySql.Data.MySqlClient

Public Class Frm_cad_fornecedores
    Private Sub Frm_cad_forneceores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If PesqFornec = "True" Then
            BtnSelecionar.Enabled = True
        End If

        Carregar_DataGrid()
        FormatarGrid()
    End Sub
    Private Sub BtnIncluir_Click(sender As Object, e As EventArgs) Handles BtnIncluir.Click
        Dim frm As New Frm_cad_addFornecedores
        frm.ShowDialog()
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
        DataGrid.Columns(4).HeaderText = "CEP"
        DataGrid.Columns(5).HeaderText = "Endereço"
        DataGrid.Columns(6).HeaderText = "Nº"
        DataGrid.Columns(7).HeaderText = "Comp."
        DataGrid.Columns(8).HeaderText = "Estado"
        DataGrid.Columns(9).HeaderText = "Bairro"
        DataGrid.Columns(10).HeaderText = "Cidade"
        DataGrid.Columns(11).HeaderText = "Telefone"
        DataGrid.Columns(12).HeaderText = "Email"
        DataGrid.Columns(13).HeaderText = "Status"
        DataGrid.Columns(14).HeaderText = "Data Inclusão"

        DataGrid.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(13).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        PanelB.Height = 0

    End Sub

    Private Sub Frm_cad_clientes_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Carregar_DataGrid()
    End Sub
    Sub Excluir_Fornecedor()

        Dim cliente As String
        Dim cod As String
        If DataGrid.SelectedRows.Count = 1 Then

            cod = DataGrid.CurrentRow.Cells(0).Value
            cliente = DataGrid.CurrentRow.Cells(2).Value

            If cod <> "" Then


                If MsgBox("Deseja excluir o cliente " & cliente & "?", vbYesNo, "Exclusão") = vbYes Then

                    Try
                        Abrir()

                        'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                        Dim cmd As MySqlCommand
                        Dim sql As String

                        sql = "DELETE FROM tbl_cad_fornecedores where id = '" & cod & "' "
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
        Excluir_Fornecedor()

    End Sub

    Sub Editar_Fornecedor()
        If DataGrid.SelectedRows.Count = 1 Then
            Dim form = New Frm_cad_addFornecedores

            form.TxtCod.Text = DataGrid.CurrentRow.Cells(0).Value
            form.TxtNome.Text = DataGrid.CurrentRow.Cells(2).Value

            form.TxtCep.Text = DataGrid.CurrentRow.Cells(4).Value
            form.TxtEndereco.Text = DataGrid.CurrentRow.Cells(5).Value
            form.TxtNum.Text = DataGrid.CurrentRow.Cells(6).Value
            form.TxtComp.Text = DataGrid.CurrentRow.Cells(7).Value
            form.TxtEstado.Text = DataGrid.CurrentRow.Cells(8).Value
            form.TxtBairro.Text = DataGrid.CurrentRow.Cells(9).Value
            form.TxtCidade.Text = DataGrid.CurrentRow.Cells(10).Value
            form.TxtTel.Text = DataGrid.CurrentRow.Cells(11).Value
            form.TxtEmail.Text = DataGrid.CurrentRow.Cells(12).Value

            '//TIPO DE PESSOA
            If DataGrid.CurrentRow.Cells(1).Value = "Pessoa Física" Then
                form.RbPessoaFisica.Checked = True
                form.TxtCpf.Text = DataGrid.CurrentRow.Cells(3).Value

            End If
            If DataGrid.CurrentRow.Cells(1).Value = "Pessoa Jurídica" Then
                form.RbPessoaJuridica.Checked = True
                form.TxtCnpj.Text = DataGrid.CurrentRow.Cells(3).Value

            End If

            '//SATUS
            If DataGrid.CurrentRow.Cells(13).Value = "Ativo" Then
                form.RbAtivo.Checked = True
            End If
            If DataGrid.CurrentRow.Cells(13).Value = "Inativo" Then
                form.RbInativo.Checked = True
            End If

            form.RbPessoaFisica.Enabled = False
            form.RbPessoaJuridica.Enabled = False
            form.TxtCnpj.Enabled = False
            form.TxtCpf.Enabled = False
            form.ShowDialog()
        End If
    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        Editar_Fornecedor()
    End Sub

    Private Sub Frm_cad_clientes_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim frm As New Frm_cad_addFornecedores
            frm.ShowDialog()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        If e.KeyCode = Keys.F2 Then
            Editar_Fornecedor()
        End If

        If e.KeyCode = Keys.Delete Then
            Excluir_Fornecedor()
        End If


        If e.KeyCode = Keys.F5 Then

            Inativar_fornecedor()

        End If

        If e.KeyCode = Keys.Enter And PesqFornec = "True" Then

            IdFornec = DataGrid.CurrentRow.Cells(0).Value
            NomeFornec = DataGrid.CurrentRow.Cells(2).Value
            BtnSelecionar.Visible = False
            Me.Close()

        End If

    End Sub

    Private Sub Inativar_fornecedor()
        'Stop
        If DataGrid.SelectedRows.Count = 1 Then
            Dim stat As String
            Dim cod1 As String

            stat = "Inativo"
            cod1 = DataGrid.CurrentRow.Cells(0).Value


            If MsgBox("Deseja inativar esse fornecedor?", vbYesNo, "Inativar Fornecedor") = vbYes Then


                Try

                    Abrir()
                    Dim cmd As MySqlCommand
                    Dim sqls As String

                    sqls = "UPDATE tbl_cad_fornecedores SET status =  '" & stat & "' WHERE id = '" & cod1 & "' "
                    cmd = New MySqlCommand(sqls, con)
                    cmd.ExecuteNonQuery()

                    Carregar_DataGrid()

                Catch ex As Exception
                    MsgBox("Erro Inativar_fornecedor " + ex.Message)
                End Try

            End If
        Else

        End If
    End Sub

    Private Sub BtnInativar_Click(sender As Object, e As EventArgs) Handles BtnInativar.Click

        Inativar_fornecedor()
    End Sub

    Private Sub DataGrid_SelectionChanged(sender As Object, e As EventArgs) Handles DataGrid.SelectionChanged
        Dim status As String

        If DataGrid.SelectedRows.Count = 1 Then

            status = DataGrid.CurrentRow.Cells(13).Value
            If status = "Inativo" Then
                BtnInativar.Enabled = False
            End If
            If status = "Ativo" Then
                BtnInativar.Enabled = True
            End If

        End If

    End Sub

    Private Sub BtnSelecionar_Click(sender As Object, e As EventArgs) Handles BtnSelecionar.Click

        If PesqFornec = "True" Then
            IdFornec = DataGrid.CurrentRow.Cells(0).Value
            NomeFornec = DataGrid.CurrentRow.Cells(2).Value
            BtnSelecionar.Enabled = True
            Me.Close()

        End If

    End Sub

    Private Sub DataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellDoubleClick
        If PesqFornec = "True" Then
            IdFornec = DataGrid.CurrentRow.Cells(0).Value
            NomeFornec = DataGrid.CurrentRow.Cells(2).Value
            Me.Close()
        End If

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
End Class