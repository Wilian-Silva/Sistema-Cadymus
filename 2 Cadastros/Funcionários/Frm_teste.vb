Imports MySql.Data.MySqlClient

Public Class Frm_teste
    Private Sub Frm_teste_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar_DataGrid()
        FormatarGrid()
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
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
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

        'DataGrid.Columns(0).Width = 50
        'DataGrid.Columns(1).Width = 80
        'DataGrid.Columns(2).Width = 250
        'DataGrid.Columns(3).Width = 100
        'DataGrid.Columns(4).Width = 70
        'DataGrid.Columns(5).Width = 80
        'DataGrid.Columns(6).Width = 250
        'DataGrid.Columns(7).Width = 60
        'DataGrid.Columns(8).Width = 90
        'DataGrid.Columns(9).Width = 80
        'DataGrid.Columns(10).Width = 150
        'DataGrid.Columns(11).Width = 150
        'DataGrid.Columns(12).Width = 100
        'DataGrid.Columns(13).Width = 200
        'DataGrid.Columns(14).Width = 100

    End Sub
End Class