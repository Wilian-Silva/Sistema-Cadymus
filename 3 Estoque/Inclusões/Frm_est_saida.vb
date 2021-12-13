Imports MySql.Data.MySqlClient

Public Class Frm_est_saida
    Dim total As String
    Dim LogUsuario As String
    Private Sub Frm_est_saida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Gerar_IdMvto()
        TxtCodBarras.Focus()
        TxtCodBarras.Select()
        LogUsuario = Stringpass
    End Sub

    Public Property Stringpass As String

    '\\ MOVER FORM PELO CORPO
    Private ReadOnly WM_NCHITTEST As Integer = &H84
    Private ReadOnly HTCLIENT As Integer = &H1
    Private ReadOnly HTCAPTION As Integer = &H2

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)

        Select Case m.Msg
            Case WM_NCHITTEST
                If m.Result = New IntPtr(HTCLIENT) Then
                    m.Result = New IntPtr(HTCAPTION)
                End If
        End Select
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click, BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnProduto_Click(sender As Object, e As EventArgs) Handles BtnProduto.Click

        PesqProd = "True"
        Dim frm As New Frm_est_consultaProdutos
        frm.ShowDialog()
    End Sub

    Private Sub Frm_est_entrada_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            PesqProd = "True"
            Dim frm As New Frm_est_consultaProdutos
            frm.ShowDialog()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        If e.KeyCode = Keys.Space Then
            AdicionarProduto_DataGrid()
        End If

        If e.KeyCode = Keys.Delete Then
            ExcluirProduto_DataGrid()
        End If
    End Sub

    Private Sub ExcluirProduto_DataGrid()

        If DataGrid.SelectedRows.Count = 1 Then
            If MsgBox("Deseja remover o item " & DataGrid.CurrentRow.Cells(1).Value & ": " & DataGrid.CurrentRow.Cells(2).Value & "?", vbYesNo, "Remover Item") = vbYes Then
                DataGrid.Rows.Remove(DataGrid.CurrentRow)
                TxtCodBarras.Select()
                TxtCodBarras.Focus()
            End If
        End If
    End Sub

    Private Sub Frm_est_entrada_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        If PesqProd = "True" Then
            TxtCod.Text = IdProd

            PesqProd = ""
            IdProd = ""
            NomeProd = ""
            PrecoVenda = ""
            PrecoCusto = ""
            Markup = ""
        End If
    End Sub

    Sub Consultar_DadosProduto()
        '\\ CONSULTAR DADOS PRODUTO 
        'Stop
        If RbCodBarras.Checked = True Then
            Abrir()

            Dim cmd1 As MySqlCommand
            Dim reader1 As MySqlDataReader
            Dim sql1 As String

            sql1 = "SELECT * FROM tbl_cad_produtos WHERE cod_barras = '" & TxtCodBarras.Text & "' "
            cmd1 = New MySqlCommand(sql1, con)
            reader1 = cmd1.ExecuteReader
            If reader1.Read = True Then

                TxtCod.Text = reader1("id")
                TxtDescricao.Text = reader1("descricao")
                TxtCustoUnit.Text = reader1("preco_custo")
                reader1.Close()
                Exit Sub

            Else
                reader1.Close()
                TxtCod.Text = ""
                TxtDescricao.Text = ""
                TxtCustoUnit.Text = ""

                Exit Sub
            End If
            reader1.Close()
        Else

            If RbCodProduto.Checked = True Then
                Abrir()

                Dim cmd2 As MySqlCommand
                Dim reader2 As MySqlDataReader
                Dim sql2 As String

                sql2 = "SELECT * FROM tbl_cad_produtos WHERE id = '" & TxtCod.Text & "' "
                cmd2 = New MySqlCommand(sql2, con)
                reader2 = cmd2.ExecuteReader
                If reader2.Read = True Then

                    TxtDescricao.Text = reader2("descricao")
                    TxtCodBarras.Text = reader2("cod_barras")
                    TxtCustoUnit.Text = reader2("preco_custo")
                    reader2.Close()
                    Exit Sub

                Else
                    TxtDescricao.Text = ""
                    TxtCodBarras.Text = ""
                    TxtCustoUnit.Text = ""
                    reader2.Close()

                    Exit Sub
                End If
                reader2.Close()

            End If

        End If

    End Sub


    Private Sub TxtCodBarras_Enter(sender As Object, e As EventArgs) Handles TxtCodBarras.Enter
        TxtCodBarras.ReadOnly = False
        CorTxtBox(TxtCodBarras, "Am")
    End Sub

    Private Sub TxtCodBarras_Leave(sender As Object, e As EventArgs) Handles TxtCodBarras.Leave
        CorTxtBox(TxtCodBarras, "Br")
        TxtCodBarras.ReadOnly = True
    End Sub

    Private Sub TxtPcusto_Enter(sender As Object, e As EventArgs) Handles TxtCustoUnit.Enter
        CorTxtBox(TxtCustoUnit, "Am")
    End Sub

    Private Sub TxtPcusto_Leave(sender As Object, e As EventArgs) Handles TxtCustoUnit.Leave
        CorTxtBox(TxtCustoUnit, "Br")
    End Sub

    Private Sub TxtCod_Enter(sender As Object, e As EventArgs) Handles TxtCod.Enter

        CorTxtBox(TxtCod, "Am")
    End Sub

    Private Sub TxtCod_Leave(sender As Object, e As EventArgs) Handles TxtCod.Leave
        CorTxtBox(TxtCod, "Br")

    End Sub

    Private Sub TxtSaldoProd_Enter(sender As Object, e As EventArgs) Handles TxtQtd.Enter
        CorTxtBox(TxtQtd, "Am")
    End Sub

    Private Sub TxtSaldoProd_Leave(sender As Object, e As EventArgs) Handles TxtQtd.Leave
        CorTxtBox(TxtQtd, "Br")
    End Sub

    Private Sub TxtCodBarras_TextChanged(sender As Object, e As EventArgs) Handles TxtCodBarras.TextChanged
        If RbCodBarras.Checked = True And TxtCodBarras.Text <> "" Then
            Consultar_DadosProduto()
        Else
            If RbCodBarras.Checked = True Then
                TxtCod.Text = ""
                TxtDescricao.Text = ""
            End If

        End If
    End Sub

    Private Sub TxtCod_TextChanged(sender As Object, e As EventArgs) Handles TxtCod.TextChanged
        If RbCodProduto.Checked = True And TxtCod.Text <> "" Then
            Consultar_DadosProduto()
        Else
            If RbCodProduto.Checked = True Then
                TxtCodBarras.Text = ""
                TxtDescricao.Text = ""
            End If
        End If

    End Sub

    Private Sub RbCodBarras_CheckedChanged(sender As Object, e As EventArgs) Handles RbCodBarras.CheckedChanged
        If RbCodBarras.Checked = True Then
            TxtCodBarras.Enabled = True
            TxtCod.Enabled = False
            BtnProduto.Enabled = False
            TxtCodBarras.Text = ""
            TxtCod.Text = ""
            TxtDescricao.Text = ""
            TxtCodBarras.Focus()
            TxtCodBarras.Select()
        End If
    End Sub

    Private Sub RbCodProduto_CheckedChanged(sender As Object, e As EventArgs) Handles RbCodProduto.CheckedChanged
        If RbCodProduto.Checked = True Then
            TxtCodBarras.Enabled = False
            TxtCod.Enabled = True
            BtnProduto.Enabled = True
            TxtCodBarras.Text = ""
            TxtCod.Text = ""
            TxtDescricao.Text = ""
            TxtCodBarras.Focus()
            TxtCod.Select()
        End If
    End Sub

    Private Sub TxtSaldoProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtQtd.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtPcusto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCustoUnit.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtCod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCod.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtCodBarras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodBarras.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click

        AdicionarProduto_DataGrid()

    End Sub

    Sub Gerar_IdMvto()
        Try
            Abrir()
            'VERIFICAR ULTIMO ID NO BANCO E GERAR PROXIMO
            Dim cmd1 As MySqlCommand
            Dim sql1 As String
            Dim reader1 As MySqlDataReader

            sql1 = "SELECT MAX(id_mvto) AS id_mvto FROM tbl_est_transacoes "
            cmd1 = New MySqlCommand(sql1, con)
            reader1 = cmd1.ExecuteReader
            reader1.Read()
            If Not IsDBNull(reader1("id_mvto")) Then
                TxtIdReg.Text = reader1("id_mvto") + 1
                reader1.Close()
            Else

                reader1.Close()
                TxtIdReg.Text = 1
            End If

        Catch ex As Exception
            MsgBox("Erro GerarIdRegistro! " + ex.Message)
        End Try
    End Sub

    Sub AdicionarProduto_DataGrid()
        'Stop
        If TxtCod.Text <> "" And TxtQtd.Text <> "" And TxtCustoUnit.Text <> "" Then

            DataGrid.Rows.Add(TxtCodBarras.Text, TxtCod.Text, TxtDescricao.Text, TxtQtd.Text, TxtCustoUnit.Text, total)
            TxtCod.Text = ""
            TxtCodBarras.Text = ""
            TxtDescricao.Text = ""
            TxtQtd.Text = ""
            TxtCustoUnit.Text = ""
            TxtCustoTotal.Text = ""

            If RbCodBarras.Checked = True Then
                TxtCodBarras.Select()
                TxtCodBarras.Focus()
            Else
                TxtCod.Select()
                TxtCod.Focus()
            End If

        Else
            MsgBox("Campos obrigatórios em branco!", MsgBoxStyle.Information, "Adicionar item")

            If RbCodBarras.Checked = True Then
                TxtCodBarras.Select()
                TxtCodBarras.Focus()
            Else
                TxtCod.Select()
                TxtCod.Focus()
            End If
        End If

    End Sub

    Private Sub BtnMax_Click(sender As Object, e As EventArgs) Handles BtnMax.Click
        Me.WindowState = FormWindowState.Maximized
        BtnMax.Visible = False
        BtnNormal.Visible = True
    End Sub

    Private Sub BtnNormal_Click(sender As Object, e As EventArgs) Handles BtnNormal.Click
        Me.WindowState = FormWindowState.Normal
        BtnMax.Visible = True
        BtnNormal.Visible = False
    End Sub

    Private Sub BtnRemover_Click(sender As Object, e As EventArgs) Handles BtnRemover.Click
        ExcluirProduto_DataGrid()
    End Sub

    Private Sub TxtQtd_TextChanged(sender As Object, e As EventArgs) Handles TxtQtd.TextChanged
        Total_Item()
    End Sub

    Sub Total_Item()
        Dim qtd As Double
        Dim vlrunit As Double


        If TxtQtd.Text = "" Then
            Dim dbl3 As Double = 0
            qtd = dbl3
        Else
            qtd = TxtQtd.Text
        End If

        If TxtCustoUnit.Text = "" Then
            Dim dbl3 As Double = 0
            vlrunit = dbl3
        Else
            vlrunit = TxtCustoUnit.Text
        End If

        TxtCustoTotal.Text = Format(qtd * vlrunit, "R$ #,###0.00")
        total = qtd * vlrunit


    End Sub

    Private Sub TxtCustoUnit_TextChanged(sender As Object, e As EventArgs) Handles TxtCustoUnit.TextChanged
        Total_Item()
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click

        If DataGrid.Rows.Count > 0 Then

            If MsgBox("Deseja salvar resgistros?", MsgBoxStyle.YesNo, "Salvar") = vbYes Then
                Atualizar_SaldoEstoque()
                Salvar_Movimentacao()
                Limpar()
                Gerar_IdMvto()

            End If

        Else
            MsgBox("Adicione itens para salvar", MsgBoxStyle.Information, "Salvar")

        End If

    End Sub

    Private Sub Limpar()

        TxtCod.Text = ""
        TxtCodBarras.Text = ""
        TxtDescricao.Text = ""
        TxtQtd.Text = ""
        TxtCustoUnit.Text = ""
        TxtCustoTotal.Text = ""
        TxtIdReg.Text = ""
        DataGrid.Rows.Clear()

    End Sub

    Sub Atualizar_SaldoEstoque()
        'Stop
        Dim novoSaldo As String
        Dim saldoAtual As String = 0
        Dim codProd As String
        Dim qtdEntrada As String

        Abrir()

        For i = 0 To DataGrid.Rows.Count - 1
            codProd = DataGrid.Rows(i).Cells(1).Value
            qtdEntrada = DataGrid.Rows(i).Cells(3).Value

            '\\CONSULTAR SALDO ATUAL EM ESTOQUE
            Try
                Dim cmd2 As MySqlCommand
                Dim reader2 As MySqlDataReader
                Dim sql2 As String

                sql2 = "SELECT saldo from tbl_cad_produtos WHERE id = '" & codProd & "' "
                cmd2 = New MySqlCommand(sql2, con)
                reader2 = cmd2.ExecuteReader
                If reader2.Read = True Then
                    saldoAtual = reader2("saldo")
                    reader2.Close()
                Else
                    reader2.Close()
                    saldoAtual = 0
                End If

            Catch ex As Exception
                MessageBox.Show("Erro ao consultar saldo estoque " & ex.Message)
            End Try

            novoSaldo = CDbl(saldoAtual) + CDbl(qtdEntrada)

            Try
                Dim cmd As MySqlCommand
                Dim sqls As String
                sqls = "UPDATE tbl_cad_produtos SET saldo = '" & novoSaldo.Replace(",", ".") & "' WHERE id  = '" & codProd & "' "
                cmd = New MySqlCommand(sqls, con)
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show("Erro: Atualizar_SaldoEstoque - " & ex.Message)
            End Try

        Next

    End Sub

    Sub Salvar_Movimentacao()
        'Stop


        Try
            Dim tipo_mvto As String
            Dim esp As String
            Dim data As String

            tipo_mvto = "Saída"
            esp = "DIV"
            data = Now().ToString("yyyy-MM-dd")

            Abrir()

            For i = 0 To DataGrid.Rows.Count - 1
                Dim cmd As MySqlCommand
                Dim sqls As String
                sqls = "INSERT INTO tbl_est_transacoes (id_mvto, tipo, especie, cod_barras, id_produto, descricao, data_mvto, quantidade, custo_unitario, custo_total, usuario )" _
                    & "VALUES('" & TxtIdReg.Text & "', '" & tipo_mvto & "','" & esp & "',  @cod_barras, @id_produto, @descricao,'" & data & "',  @quantidade, @custo_unitario, @custo_total,'" & LogUsuario & "')"

                cmd = New MySqlCommand(sqls, con)
                With cmd
                    .Parameters.AddWithValue("@cod_barras", DataGrid.Rows(i).Cells(0).Value.ToString)
                    .Parameters.AddWithValue("@id_produto", CInt(DataGrid.Rows(i).Cells(1).Value.ToString))
                    .Parameters.AddWithValue("@descricao", DataGrid.Rows(i).Cells(2).Value.ToString)
                    .Parameters.AddWithValue("@quantidade", CDbl(DataGrid.Rows(i).Cells(3).Value.ToString))
                    .Parameters.AddWithValue("@custo_unitario", CDbl(DataGrid.Rows(i).Cells(4).Value.ToString))
                    .Parameters.AddWithValue("@custo_total", CDbl(DataGrid.Rows(i).Cells(5).Value.ToString))
                    cmd.ExecuteNonQuery()
                End With
            Next

            If RbCodBarras.Checked = True Then
                TxtCodBarras.Select()
                TxtCodBarras.Focus()
            Else
                TxtCod.Select()
                TxtCod.Focus()
            End If

            MsgBox("Movimentação salva com sucesso!!", MsgBoxStyle.Information, "Salvar")
        Catch ex As Exception
            MessageBox.Show("Erro Salvar_Movimentacao " & ex.Message)
        End Try

    End Sub

End Class