
Imports _5_Vendas
Imports MySql.Data.MySqlClient

Public Class Frm_cad_clientes
    Private Sub Frm_cad_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Carregar_DataGrid()
        FormatarGrid()
    End Sub
    Private Sub BtnIncluir_Click(sender As Object, e As EventArgs) Handles BtnIncluir.Click
        Dim frm As New Frm_cad_addClientes
        frm.ShowDialog()
    End Sub

    Private Sub BtnLimiteDebito_Click(sender As Object, e As EventArgs) Handles BtnLimiteDebito.Click
        Dim frm As New Frm_ven_limiteDebito
        frm.ShowDialog()
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

            sql = "SELECT * FROM tbl_cad_clientes order by id asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub
    Private Sub FormatarGrid()

        DataGrid.Columns(0).HeaderText = "Código"
        DataGrid.Columns(1).HeaderText = "Tipo"
        DataGrid.Columns(2).HeaderText = "Nome"
        DataGrid.Columns(3).HeaderText = "Sexo"
        DataGrid.Columns(4).HeaderText = "CPF/CNPJ"
        DataGrid.Columns(5).HeaderText = "CEP"
        DataGrid.Columns(6).HeaderText = "Endereço"
        DataGrid.Columns(7).HeaderText = "Nº"
        DataGrid.Columns(8).HeaderText = "Comp."
        DataGrid.Columns(9).HeaderText = "Estado"
        DataGrid.Columns(10).HeaderText = "Bairro"
        DataGrid.Columns(11).HeaderText = "Cidade"
        DataGrid.Columns(12).HeaderText = "Telefone"
        DataGrid.Columns(13).HeaderText = "Email"
        DataGrid.Columns(14).HeaderText = "Status"
        DataGrid.Columns(15).Visible = False
        DataGrid.Columns(16).HeaderText = "Limite de Débito"
        DataGrid.Columns(17).HeaderText = "Data Inclusão"

        DataGrid.Columns(16).DefaultCellStyle.Format = "c"
        DataGrid.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(14).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(17).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(16).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(0).Width = 80
        DataGrid.Columns(1).Width = 120
        DataGrid.Columns(2).Width = 200
        DataGrid.Columns(3).Width = 80
        DataGrid.Columns(4).Width = 130
        DataGrid.Columns(5).Width = 90
        DataGrid.Columns(6).Width = 250
        DataGrid.Columns(7).Width = 60
        DataGrid.Columns(8).Width = 80
        DataGrid.Columns(9).Width = 60
        DataGrid.Columns(10).Width = 150
        DataGrid.Columns(11).Width = 150
        DataGrid.Columns(12).Width = 120
        DataGrid.Columns(13).Width = 250
        DataGrid.Columns(14).Width = 80
        DataGrid.Columns(16).Width = 90
        DataGrid.Columns(17).Width = 90


    End Sub


    Private Sub Frm_cad_clientes_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Carregar_DataGrid()
    End Sub
    Sub Excluir_Cliente()

        If DataGrid.SelectedRows.Count = 1 Then
            Dim cliente As String
            Dim cod As String

            cod = DataGrid.CurrentRow.Cells(0).Value
            cliente = DataGrid.CurrentRow.Cells(2).Value


            If cod <> "" Then


                If MsgBox("Deseja excluir o cliente " & cliente & "?", vbYesNo, "Exclusão") = vbYes Then

                    Try
                        Abrir()

                        'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                        Dim cmd As MySqlCommand
                        Dim sql As String

                        sql = "DELETE FROM tbl_cad_clientes where id = '" & cod & "' "
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
        Excluir_Cliente()

    End Sub

    Sub Editar_Cliente()

        If DataGrid.SelectedRows.Count = 1 Then
            Dim form = New Frm_cad_addClientes()


            form.TxtCod.Text = DataGrid.CurrentRow.Cells(0).Value
            form.TxtNome.Text = DataGrid.CurrentRow.Cells(2).Value
            form.TxtSexo.Text = DataGrid.CurrentRow.Cells(3).Value

            form.TxtCep.Text = DataGrid.CurrentRow.Cells(5).Value
            form.TxtEndereco.Text = DataGrid.CurrentRow.Cells(6).Value
            form.TxtNum.Text = DataGrid.CurrentRow.Cells(7).Value
            form.TxtComp.Text = DataGrid.CurrentRow.Cells(8).Value
            form.TxtEstado.Text = DataGrid.CurrentRow.Cells(9).Value
            form.TxtBairro.Text = DataGrid.CurrentRow.Cells(10).Value
            form.TxtCidade.Text = DataGrid.CurrentRow.Cells(11).Value
            form.TxtTel.Text = DataGrid.CurrentRow.Cells(12).Value
            form.TxtEmail.Text = DataGrid.CurrentRow.Cells(13).Value
            form.TxtLimiteCredito.Text = DataGrid.CurrentRow.Cells(16).Value

            form.RbPessoaFisica.Enabled = False
            form.RbPessoaJuridica.Enabled = False
            form.TxtCpf.Enabled = False
            form.TxtCnpj.Enabled = False


            '//TIPO DE PESSOA
            If DataGrid.CurrentRow.Cells(1).Value = "Pessoa Física" Then
                form.RbPessoaFisica.Checked = True
                form.TxtCpf.Text = DataGrid.CurrentRow.Cells(4).Value
            End If
            If DataGrid.CurrentRow.Cells(1).Value = "Pessoa Jurídica" Then
                form.RbPessoaJuridica.Checked = True
                form.TxtCnpj.Text = DataGrid.CurrentRow.Cells(4).Value
            End If

            '//LIMITE DEBITO
            If DataGrid.CurrentRow.Cells(15).Value = 1 Then
                form.RbLimitePadrao.Checked = True
                form.TxtLimiteCredito.Text = ""
            End If
            If DataGrid.CurrentRow.Cells(15).Value = 2 Then
                form.RbSemDebito.Checked = True
                form.TxtLimiteCredito.Text = ""
            End If
            If DataGrid.CurrentRow.Cells(15).Value = 3 Then
                form.RbLimiteDiff.Checked = True
                form.TxtLimiteCredito.Text = DataGrid.CurrentRow.Cells(16).Value
            End If

            '//SATUS
            If DataGrid.CurrentRow.Cells(14).Value = "Ativo" Then
                form.RbAtivo.Checked = True
            End If
            If DataGrid.CurrentRow.Cells(14).Value = "Inativo" Then
                form.RbInativo.Checked = True
            End If


            form.ShowDialog()
        End If
    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        Editar_Cliente()

    End Sub

    Private Sub Frm_cad_clientes_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim frm As New Frm_cad_addClientes
            frm.ShowDialog()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        If e.KeyCode = Keys.F2 Then
            Editar_Cliente()
        End If

        If e.KeyCode = Keys.Delete Then
            Excluir_Cliente()
        End If

        If e.KeyCode = Keys.F3 Then
            Copirar_Cliente()
        End If

        If e.KeyCode = Keys.F4 Then
            Dim frm As New Frm_ven_limiteDebito
            frm.ShowDialog()
        End If

        If e.KeyCode = Keys.F5 Then

            Inativar_cliente()
        End If

    End Sub

    Private Sub Inativar_cliente()
        If DataGrid.SelectedRows.Count = 1 Then
            Try
                Abrir()
                Dim cmd As MySqlCommand
                Dim sqls As String
                Dim stat As String
                Dim cod As String
                stat = "Inativo"
                cod = DataGrid.CurrentRow.Cells(0).Value

                If MsgBox("Deseja inativar esse cliente?", vbYesNo, "Inativar Cliente") = vbYes Then

                    sqls = "UPDATE tbl_cad_clientes SET status =  '" & stat & "' WHERE id = '" & cod & "' "
                    cmd = New MySqlCommand(sqls, con)
                    cmd.ExecuteNonQuery()

                    Carregar_DataGrid()
                End If

            Catch ex As Exception
                MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnCopiar_Click(sender As Object, e As EventArgs) Handles BtnCopiar.Click
        Copirar_Cliente()
    End Sub

    Sub Copirar_Cliente()
        If DataGrid.SelectedRows.Count = 1 Then
            Dim form = New Frm_cad_addClientes()
            form.TxtNome.Text = DataGrid.CurrentRow.Cells(2).Value
            form.TxtSexo.Text = DataGrid.CurrentRow.Cells(3).Value

            form.TxtCep.Text = DataGrid.CurrentRow.Cells(5).Value
            form.TxtEndereco.Text = DataGrid.CurrentRow.Cells(6).Value
            form.TxtNum.Text = DataGrid.CurrentRow.Cells(7).Value
            form.TxtComp.Text = DataGrid.CurrentRow.Cells(8).Value
            form.TxtEstado.Text = DataGrid.CurrentRow.Cells(9).Value
            form.TxtBairro.Text = DataGrid.CurrentRow.Cells(10).Value
            form.TxtCidade.Text = DataGrid.CurrentRow.Cells(11).Value
            form.TxtTel.Text = DataGrid.CurrentRow.Cells(12).Value
            form.TxtEmail.Text = DataGrid.CurrentRow.Cells(13).Value
            form.TxtLimiteCredito.Text = DataGrid.CurrentRow.Cells(16).Value

            '//TIPO DE PESSOA
            If DataGrid.CurrentRow.Cells(1).Value = "Pessoa Física" Then
                form.RbPessoaFisica.Checked = True
                form.TxtCpf.Text = DataGrid.CurrentRow.Cells(4).Value
            End If
            If DataGrid.CurrentRow.Cells(1).Value = "Pessoa Jurídica" Then
                form.RbPessoaJuridica.Checked = True
                form.TxtCnpj.Text = DataGrid.CurrentRow.Cells(4).Value
            End If

            '
            '//LIMITE DEBITO
            If DataGrid.CurrentRow.Cells(15).Value = 1 Then
                form.RbLimitePadrao.Checked = True
                form.TxtLimiteCredito.Text = ""
            End If
            If DataGrid.CurrentRow.Cells(15).Value = 2 Then
                form.RbSemDebito.Checked = True
                form.TxtLimiteCredito.Text = ""
            End If
            If DataGrid.CurrentRow.Cells(15).Value = 3 Then
                form.RbLimiteDiff.Checked = True
                form.TxtLimiteCredito.Text = DataGrid.CurrentRow.Cells(16).Value
            End If


            '//SATUS
            If DataGrid.CurrentRow.Cells(14).Value = "Ativo" Then
                form.RbAtivo.Checked = True
            End If
            If DataGrid.CurrentRow.Cells(14).Value = "Inativo" Then
                form.RbInativo.Checked = True
            End If

            form.ShowDialog()
        End If
    End Sub

    Private Sub TxtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisar.TextChanged

        Try
            Abrir()
            Dim dt As New DataTable
            Dim sql As String
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM tbl_cad_clientes order by id asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            dt.DefaultView.RowFilter = "nome LIKE " & "'%" & TxtPesquisar.Text & "%'"
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

            sql = "SELECT * FROM tbl_cad_clientes order by id asc"
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

            sql = "SELECT * FROM tbl_cad_clientes order by id asc"
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

        Inativar_cliente()

    End Sub

    Private Sub DataGrid_SelectionChanged(sender As Object, e As EventArgs) Handles DataGrid.SelectionChanged
        'Stop
        Dim status As String

        If DataGrid.SelectedRows.Count > 0 Then

            status = DataGrid.CurrentRow.Cells(14).Value

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
End Class