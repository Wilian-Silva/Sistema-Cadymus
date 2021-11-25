Imports MySql.Data.MySqlClient

Public Class Frm_cad_usuarios
    Private Sub Frm_cad_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar_DataGrid()
        FormatarGrid()
    End Sub

    Private Sub BtnIncluir_Click(sender As Object, e As EventArgs) Handles BtnIncluir.Click
        Dim frm As New Frm_cad_addUsuarios
        frm.ShowDialog()
    End Sub
    Sub Carregar_DataGrid()

        Try
            Abrir()
            Dim dt As New DataTable
            Dim sql As String
            Dim da As MySqlDataAdapter

            sql = "SELECT u.id, u.id_funcionario, f.nome, n.funcao, u.usuario, u.senha, f.status, u.data_inclusao, id_funcionario, f.id_funcao " _
            & " FROM tbl_cad_usuarios as u " _
            & "INNER JOIN tbl_cad_funcionarios as f ON u.id_funcionario = f.id " _
            & " INNER JOIN tbl_cad_funcoes as n ON f.id_funcao = n.id order by u.id asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub
    Private Sub FormatarGrid()

        DataGrid.Columns(0).HeaderText = "Código"
        DataGrid.Columns(1).HeaderText = "Matrícula"
        DataGrid.Columns(2).HeaderText = "Nome"
        DataGrid.Columns(3).HeaderText = "Cargo/Função"
        DataGrid.Columns(4).HeaderText = "Usuário"
        DataGrid.Columns(5).Visible = False
        DataGrid.Columns(6).HeaderText = "Status"
        DataGrid.Columns(7).HeaderText = "Data Inclusão"
        DataGrid.Columns(8).Visible = False
        DataGrid.Columns(9).Visible = False


        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(0).Width = 80
        DataGrid.Columns(1).Width = 120
        DataGrid.Columns(2).Width = 330
        DataGrid.Columns(3).Width = 200
        DataGrid.Columns(4).Width = 150
        DataGrid.Columns(6).Width = 100
        DataGrid.Columns(7).Width = 100

    End Sub

    Private Sub Frm_cad_categorias_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Carregar_DataGrid()
    End Sub
    Sub Excluir_Funcao()

        If DataGrid.SelectedRows.Count = 1 Then
            Dim produto As String
            Dim cod As String

            cod = DataGrid.CurrentRow.Cells(0).Value
            produto = DataGrid.CurrentRow.Cells(4).Value

            If cod <> "" Then

                If MsgBox("Deseja excluir usuario " & produto & "?", vbYesNo, "Exclusão") = vbYes Then

                    Try
                        Abrir()

                        'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                        Dim cmd As MySqlCommand
                        Dim sql As String

                        sql = "DELETE FROM tbl_cad_usuarios where id = '" & cod & "' "
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
        Excluir_Funcao()
    End Sub

    Private Sub TxtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisar.TextChanged
        Try
            Abrir()
            Dim dt As New DataTable
            Dim sql As String
            Dim da As MySqlDataAdapter

            sql = "SELECT u.id, u.id_funcionario, f.nome, n.funcao, u.usuario, u.senha, f.status, u.data_inclusao, id_funcionario, f.id_funcao " _
            & " FROM tbl_cad_usuarios as u " _
            & "INNER JOIN tbl_cad_funcionarios as f ON u.id_funcionario = f.id " _
            & " INNER JOIN tbl_cad_funcoes as n ON f.id_funcao = n.id order by u.id asc"

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
            EditarUsuario = "True"

            Dim form = New Frm_cad_addUsuarios
            form.TxtCod.Text = DataGrid.CurrentRow.Cells(0).Value
            form.TxtIdFunc.Text = DataGrid.CurrentRow.Cells(1).Value
            form.TxtFuncionario.Text = DataGrid.CurrentRow.Cells(2).Value
            form.TxtUsuario.Text = DataGrid.CurrentRow.Cells(4).Value
            form.TxtSenha.Text = DataGrid.CurrentRow.Cells(5).Value

            form.TxtIdFunc.Text = DataGrid.CurrentRow.Cells(8).Value

            form.TxtIdFuncao.Text = DataGrid.CurrentRow.Cells(9).Value
            form.TxtFuncao.Text = DataGrid.CurrentRow.Cells(3).Value

            form.BtnPesqFunc.Enabled = False
            form.ShowDialog()
        End If
    End Sub

    Private Sub Frm_cad_categorias_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim frm As New Frm_cad_addUsuarios
            frm.ShowDialog()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        If e.KeyCode = Keys.F2 Then
            Editar_Dados()
        End If

        If e.KeyCode = Keys.Delete Then
            Excluir_Funcao()
        End If

    End Sub

    Private Sub BtnCancelar_Click_1(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Frm_cad_usuarios_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        PesqFunc = ""
    End Sub
End Class