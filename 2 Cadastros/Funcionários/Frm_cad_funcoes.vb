Imports MySql.Data.MySqlClient

Public Class Frm_cad_funcoes
    Private Sub Frm_cad_funcoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If PesqFuncao = "True" Then
            BtnSelecionar.Enabled = True

            BtnIncluir.Enabled = False
            BtnEditar.Enabled = False
            BtnExcuir.Enabled = False

        End If
        Carregar_DataGrid()
        FormatarGrid()
    End Sub
    Private Sub BtnIncluir_Click(sender As Object, e As EventArgs) Handles BtnIncluir.Click
        Dim frm As New Frm_cad_addFuncoes
        frm.ShowDialog()
    End Sub
    Sub Carregar_DataGrid()

        Try
            Abrir()
            Dim dt As New DataTable
            Dim sql As String
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM tbl_cad_funcoes order by id asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub
    Private Sub FormatarGrid()

        DataGrid.Columns(0).HeaderText = "Código"
        DataGrid.Columns(1).HeaderText = "Função"
        DataGrid.Columns(2).HeaderText = "Data Inclusão"
        DataGrid.Columns(3).HeaderText = "Descrição"

        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        PanelB.Height = 0

    End Sub

    Private Sub Frm_cad_categorias_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Carregar_DataGrid()
    End Sub
    Sub Excluir_Funcao()

        If DataGrid.SelectedRows.Count = 1 Then
            Dim produto As String
            Dim cod As String

            cod = DataGrid.CurrentRow.Cells(0).Value
            produto = DataGrid.CurrentRow.Cells(1).Value

            If cod <> "" Then

                If MsgBox("Deseja excluir o cargo/função: " & produto & "?", vbYesNo, "Exclusão") = vbYes Then

                    Try
                        Abrir()

                        'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                        Dim cmd As MySqlCommand
                        Dim sql As String

                        sql = "DELETE FROM tbl_cad_funcoes where id = '" & cod & "' "
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



    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnEditar_Click_1(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Editar_Dados()
    End Sub

    Private Sub Editar_Dados()
        If DataGrid.SelectedRows.Count = 1 Then
            Dim form = New Frm_cad_addFuncoes

            form.TxtCod.Text = DataGrid.CurrentRow.Cells(0).Value
            form.TxtFuncao.Text = DataGrid.CurrentRow.Cells(1).Value
            form.TxtDescricao.Text = DataGrid.CurrentRow.Cells(3).Value

            form.ShowDialog()
        End If
    End Sub

    Private Sub Frm_cad_categorias_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim frm As New Frm_cad_addFuncoes
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

        If e.KeyCode = Keys.Enter And PesqFuncao = "True" Then
            SelecionarFuncao()
            Me.Close()
        End If

    End Sub

    Sub SelecionarFuncao()
        If DataGrid.SelectedRows.Count = 1 Then

            Funcao = DataGrid.CurrentRow.Cells(1).Value
            IdFuncaoFunc = DataGrid.CurrentRow.Cells(0).Value
            BtnSelecionar.Enabled = False

        End If
    End Sub
    Private Sub BtnSelecionar_Click(sender As Object, e As EventArgs) Handles BtnSelecionar.Click
        SelecionarFuncao()
        Me.Close()
    End Sub


    Private Sub DataGrid_DoubleClick(sender As Object, e As EventArgs) Handles DataGrid.DoubleClick
        SelecionarFuncao()
        Me.Close()

    End Sub

    Private Sub Btnfiltro_Click(sender As Object, e As EventArgs) Handles Btnfiltro.Click
        Try
            Abrir()
            Dim dt As New DataTable
            Dim sql As String
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM tbl_cad_funcoes order by id asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            dt.DefaultView.RowFilter = "funcao LIKE " & "'%" & Txtnome.Text & "%'"
            DataGrid.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub

    Private Sub LbFiltro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LbFiltro.LinkClicked
        Dim heig As String
        heig = PanelB.Height
        Txtnome.Text = ""
        Txtnome.Focus()

        If heig <> 65 Or heig = 0 Then

            PanelB.Height = 65
        Else
            PanelB.Height = 0
            Carregar_DataGrid()

        End If
    End Sub
End Class