Imports MySql.Data.MySqlClient

Public Class Frm_cad_precoVenda
    Private Sub Frm_cad_precoVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If PesProdTelaProd = "True" Then
            TxtPvenda.Focus()
            TxtPvenda.Select()
        Else
            TxtDescricao.Focus()
            TxtDescricao.Select()
        End If

    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click, BtnClose.Click
        Me.Close()
    End Sub

    Private Sub Frm_cad_precoVenda_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        If e.KeyCode = Keys.Enter Then
            Editar_Preço_Produto()
        End If


    End Sub

    Sub Editar_Preço_Produto()
        Try
            If MsgBox("Deseja salvar edição? ", vbYesNo, "Editar") = vbYes Then
                Abrir()
                Dim cmd As MySqlCommand
                Dim sqls As String
                Dim cod As String

                cod = TxtCod.Text

                If CboxAutomatico.Checked = True And TxtMarkup.Text = "" Then

                    MsgBox("% Markup vazio ou em branco!!", MsgBoxStyle.Information, "Markup")

                    Exit Sub
                End If


                Dim dbl1 As Double = 0
                Dim dbl2 As Double = 0
                Double.TryParse(TxtPvenda.Text, dbl1)
                Double.TryParse(TxtPcusto.Text, dbl2)

                If dbl1 < dbl2 Then
                    If MsgBox("Preço de venda está abaixo do preço de custo, deseja salvar mesmo assim? ", vbYesNo, "Preço Promocional") = vbYes Then


                        sqls = "UPDATE tbl_cad_produtos SET preco_venda= '" & TxtPvenda.Text.Replace(",", ".") & "', preco_custo ='" & TxtPcusto.Text.Replace(",", ".") & "', markup= '" & TxtMarkup.Text.Replace(",", ".") & "' WHERE id = '" & cod & "' "
                        cmd = New MySqlCommand(sqls, con)
                        cmd.ExecuteNonQuery()

                        MsgBox("Cadastro editado com Sucesso!!", MsgBoxStyle.Information, "Salvar")
                        Me.Close()
                    Else

                        Exit Sub

                    End If
                Else

                    sqls = "UPDATE tbl_cad_produtos SET preco_venda= '" & TxtPvenda.Text.Replace(",", ".") & "', preco_custo ='" & TxtPcusto.Text.Replace(",", ".") & "', markup= '" & TxtMarkup.Text.Replace(",", ".") & "' WHERE id = '" & cod & "' "
                    cmd = New MySqlCommand(sqls, con)
                    cmd.ExecuteNonQuery()

                    MsgBox("Cadastro editado com Sucesso!!", MsgBoxStyle.Information, "Salvar")
                    Me.Close()

                End If


            End If

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub

    Private Sub TxtPvenda_Enter(sender As Object, e As EventArgs) Handles TxtPvenda.Enter
        CorTxtBox(TxtPvenda, "Am")
    End Sub

    Private Sub TxtPvenda_Leave(sender As Object, e As EventArgs) Handles TxtPvenda.Leave
        CorTxtBox(TxtPvenda, "Br")
    End Sub

    Private Sub TxtPcusto_Enter(sender As Object, e As EventArgs) Handles TxtPcusto.Enter
        CorTxtBox(TxtPcusto, "Am")
    End Sub

    Private Sub TxtPcusto_Leave(sender As Object, e As EventArgs) Handles TxtPcusto.Leave
        CorTxtBox(TxtPcusto, "Br")
    End Sub

    Private Sub TxtMarkup_Enter(sender As Object, e As EventArgs) Handles TxtMarkup.Enter
        CorTxtBox(TxtMarkup, "Am")
    End Sub

    Private Sub TxtMarkup_Leave(sender As Object, e As EventArgs) Handles TxtMarkup.Leave
        CorTxtBox(TxtMarkup, "Br")
    End Sub
    Private Sub TxtDescricao_Enter(sender As Object, e As EventArgs) Handles TxtDescricao.Enter
        CorTxtBox(TxtDescricao, "Am")
    End Sub

    Private Sub TxtDescricao_Leave(sender As Object, e As EventArgs) Handles TxtDescricao.Leave
        CorTxtBox(TxtDescricao, "Br")
    End Sub
    Private Sub CboxAutomatico_CheckedChanged(sender As Object, e As EventArgs) Handles CboxAutomatico.CheckedChanged

        If CboxAutomatico.Checked = True Then
            TxtMarkup.Enabled = True
            TxtPvenda.Enabled = False
            TxtPcusto.Focus()
            LabelPercent.Visible = True

        End If

        If CboxAutomatico.Checked = False Then
            TxtMarkup.Enabled = False
            TxtPvenda.Enabled = True
            TxtPvenda.Focus()
            LabelPercent.Visible = False

        End If

    End Sub
    Sub Cal_Margem()

        Dim dbl1 As Double = 0
        Dim dbl2 As Double = 0

        Double.TryParse(TxtPvenda.Text, dbl1)
        Double.TryParse(TxtPcusto.Text, dbl2)

        TxtMarkup.Text = ((dbl1 - dbl2) / dbl1) '.ToString("n")

    End Sub
    Private Sub TxtPvenda_TextChanged(sender As Object, e As EventArgs) Handles TxtPvenda.TextChanged
        If CboxAutomatico.Checked = False Then

            Cal_Margem()

        End If
    End Sub
    Private Sub TxtPcusto_TextChanged(sender As Object, e As EventArgs) Handles TxtPcusto.TextChanged
        If CboxAutomatico.Checked = True Then

            Cal_Markup()
        End If

        If CboxAutomatico.Checked = False Then

            Cal_Margem()
        End If
    End Sub
    Sub Cal_Markup()

        Dim dbl1 As Double = 0
        Dim dbl2 As Double = 0

        Double.TryParse(TxtPcusto.Text, dbl1)
        Double.TryParse(TxtMarkup.Text, dbl2)

        TxtPvenda.Text = (dbl1 / (1 - dbl2)) '.ToString("n")

    End Sub
    Private Sub TxtMarkup_TextChanged(sender As Object, e As EventArgs) Handles TxtMarkup.TextChanged
        If CboxAutomatico.Checked = True Then

            Cal_Markup()
        End If
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Editar_Preço_Produto()
    End Sub

    Private Sub BtnPesquisarProd_Click(sender As Object, e As EventArgs) Handles BtnPesquisarProd.Click

        PesqProd = "True"
        Dim frm As New Frm_cad_consultaProdutos
        frm.ShowDialog()
    End Sub

    Private Sub Frm_cad_precoVenda_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If PesqProd = "True" Then
            TxtDescricao.Text = NomeProd
            TxtCod.Text = IdProd
            TxtPvenda.Text = PrecoVenda
            TxtPcusto.Text = PrecoCusto
            TxtMarkup.Text = Markup

            PrecoVenda = ""
            PrecoCusto = ""
            Markup = ""
            NomeProd = ""
            IdProd = ""
            PesqProd = ""
        End If
    End Sub

    Private Sub TxtDescricao_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtDescricao.KeyDown
        If e.KeyCode = Keys.F5 Then
            PesqProd = "True"
            Dim frm As New Frm_cad_consultaProdutos
            frm.ShowDialog()
        End If

    End Sub

    Private Sub TxtPvenda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPvenda.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtPcusto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPcusto.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

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
End Class