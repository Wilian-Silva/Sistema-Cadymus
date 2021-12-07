Imports MySql.Data.MySqlClient

Public Class Frm_cad_portadores
    Private Sub Frm_cad_portadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If PesqPortador = "True" Then
            BtnSelecionar.Enabled = True
            BtnIncluir.Enabled = False
            BtnEditar.Enabled = False
            BtnExcuir.Enabled = False
        End If

        Carregar_DataGrid()
        FormatarGrid()
    End Sub
    Private Sub BtnIncluir_Click(sender As Object, e As EventArgs) Handles BtnIncluir.Click
        Dim frm As New Frm_cad_addPortadores
        frm.ShowDialog()
    End Sub

    Sub Carregar_DataGrid()

        Try
            Abrir()
            Dim dt As New DataTable
            Dim sql As String
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM tbl_cad_portadores order by id asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub
    Private Sub FormatarGrid()

        DataGrid.Columns(0).HeaderText = "Código"
        DataGrid.Columns(1).HeaderText = "Portador"
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
    Sub Excluir_Portador()

        If DataGrid.SelectedRows.Count = 1 Then
            Dim produto As String
            Dim cod As String

            cod = DataGrid.CurrentRow.Cells(0).Value
            produto = DataGrid.CurrentRow.Cells(1).Value

            If cod <> "" Then

                If MsgBox("Deseja excluir local " & produto & "?", vbYesNo, "Exclusão") = vbYes Then

                    Try
                        Abrir()

                        'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                        Dim cmd As MySqlCommand
                        Dim sql As String

                        sql = "DELETE FROM tbl_cad_portadores where id = '" & cod & "' "
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
        Excluir_Portador()
    End Sub



    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnEditar_Click_1(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Editar_Portador()
    End Sub

    Private Sub Editar_Portador()
        If DataGrid.SelectedRows.Count = 1 Then
            Dim form = New Frm_cad_addPortadores

            form.TxtCod.Text = DataGrid.CurrentRow.Cells(0).Value
            form.TxtPortador.Text = DataGrid.CurrentRow.Cells(1).Value
            form.TxtDescricao.Text = DataGrid.CurrentRow.Cells(3).Value

            form.ShowDialog()
        End If
    End Sub

    Private Sub Frm_cad_categorias_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim frm As New Frm_cad_addPortadores
            frm.ShowDialog()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        If e.KeyCode = Keys.F2 Then
            Editar_Portador()
        End If

        If e.KeyCode = Keys.Delete Then
            Excluir_Portador()
        End If

        If e.KeyCode = Keys.Enter And PesqLocal = "True" Then
            Selecionar()
            Me.Close()
        End If
    End Sub

    Private Sub BtnSelecionar_Click(sender As Object, e As EventArgs) Handles BtnSelecionar.Click
        Selecionar()
        Me.Close()
    End Sub
    Sub Selecionar()
        If DataGrid.SelectedRows.Count = 1 Then
            Portador = DataGrid.CurrentRow.Cells(1).Value
            IdPortador = DataGrid.CurrentRow.Cells(0).Value
            BtnSelecionar.Enabled = False

        End If
    End Sub


    Private Sub DataGrid_DoubleClick(sender As Object, e As EventArgs) Handles DataGrid.DoubleClick
        Selecionar()
        Me.Close()

    End Sub

    Private Sub Btnfiltro_Click(sender As Object, e As EventArgs) Handles Btnfiltro.Click
        Try
            Abrir()
            Dim dt As New DataTable
            Dim sql As String
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM tbl_cad_portadores order by id asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            dt.DefaultView.RowFilter = "portador LIKE " & "'%" & TxtCategoria.Text & "%'"
            DataGrid.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro Btnfiltro_Click--- " + ex.Message)
        End Try
    End Sub

    Private Sub LbFiltro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LbFiltro.LinkClicked
        Dim heig As String
        heig = PanelB.Height

        TxtCategoria.Text = ""
        TxtCategoria.Focus()

        If heig <> 65 Or heig = 0 Then

            PanelB.Height = 65
        Else
            PanelB.Height = 0
            Carregar_DataGrid()

        End If
    End Sub
End Class