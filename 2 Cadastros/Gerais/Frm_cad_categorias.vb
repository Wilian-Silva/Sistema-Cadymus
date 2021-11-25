Imports MySql.Data.MySqlClient

Public Class Frm_cad_categorias
    Private Sub Frm_cad_categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If PesqCategoria = "True" Then
            BtnSelecionar.Visible = True
        End If

        Carregar_DataGrid()
        FormatarGrid()
    End Sub
    Private Sub BtnIncluir_Click(sender As Object, e As EventArgs) Handles BtnIncluir.Click
        Dim frm As New Frm_cad_addCategorias
        frm.ShowDialog()
    End Sub

    Sub Carregar_DataGrid()

        Try
            Abrir()
            Dim dt As New DataTable
            Dim sql As String
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM tbl_cad_categorias order by id asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub
    Private Sub FormatarGrid()

        DataGrid.Columns(0).HeaderText = "Código"
        DataGrid.Columns(1).HeaderText = "Categoria"
        DataGrid.Columns(2).HeaderText = "Data Inclusão"
        DataGrid.Columns(3).HeaderText = "Descrição"

        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(0).Width = 80
        DataGrid.Columns(1).Width = 200
        DataGrid.Columns(2).Width = 100
        DataGrid.Columns(3).Width = 700

    End Sub

    Private Sub Frm_cad_categorias_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Carregar_DataGrid()
    End Sub
    Sub Excluir_Categoria()

        If DataGrid.SelectedRows.Count = 1 Then
            Dim produto As String
            Dim cod As String

            cod = DataGrid.CurrentRow.Cells(0).Value
            produto = DataGrid.CurrentRow.Cells(1).Value

            If cod <> "" Then

                If MsgBox("Deseja excluir categoria " & produto & "?", vbYesNo, "Exclusão") = vbYes Then

                    Try
                        Abrir()

                        'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                        Dim cmd As MySqlCommand
                        Dim sql As String

                        sql = "DELETE FROM tbl_cad_categorias where id = '" & cod & "' "
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
        Excluir_Categoria()
    End Sub

    Private Sub TxtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisar.TextChanged
        Try
            Abrir()
            Dim dt As New DataTable
            Dim sql As String
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM tbl_cad_categorias order by id asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            dt.DefaultView.RowFilter = "categoria LIKE " & "'%" & TxtPesquisar.Text & "%'"
            DataGrid.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnEditar_Click_1(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Editar_Dados_Categoria()
    End Sub

    Private Sub Editar_Dados_Categoria()
        If DataGrid.SelectedRows.Count = 1 Then
            Dim form = New Frm_cad_addCategorias

            form.TxtCod.Text = DataGrid.CurrentRow.Cells(0).Value
            form.TxtCategoria.Text = DataGrid.CurrentRow.Cells(1).Value
            form.TxtDescricao.Text = DataGrid.CurrentRow.Cells(3).Value

            form.ShowDialog()
        End If
    End Sub

    Private Sub Frm_cad_categorias_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim frm As New Frm_cad_addCategorias
            frm.ShowDialog()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        If e.KeyCode = Keys.F2 Then
            Editar_Dados_Categoria()
        End If

        If e.KeyCode = Keys.Delete Then
            Excluir_Categoria()
        End If

        If e.KeyCode = Keys.Enter And PesqCategoria = "True" Then
            Selcionar()
            Me.Close()
        End If
    End Sub

    Private Sub BtnSelecionar_Click(sender As Object, e As EventArgs) Handles BtnSelecionar.Click
        Selcionar()
        Me.Close()
    End Sub
    Sub Selcionar()
        If DataGrid.SelectedRows.Count = 1 Then
            Categoria = DataGrid.CurrentRow.Cells(1).Value
            IdCategoria = DataGrid.CurrentRow.Cells(0).Value
            BtnSelecionar.Visible = False

        End If
    End Sub
    Private Sub BtnCancelar_Click_1(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub DataGrid_DoubleClick(sender As Object, e As EventArgs) Handles DataGrid.DoubleClick
        Selcionar()
        Me.Close()

    End Sub
End Class