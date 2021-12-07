Imports MySql.Data.MySqlClient

Public Class Frm_cad_promocao
    Private Sub Frm_cad_promocao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If PesProdTelaProd = "True" Then
            TxtPpromocao.Focus()
            TxtPpromocao.Select()
        Else
            TxtDescricao.Focus()
            TxtDescricao.Select()
        End If
    End Sub
    Private Sub BtnPesquisarProd_Click(sender As Object, e As EventArgs) Handles BtnPesquisarProd.Click
        PesqProd = "True"
        Dim frm As New Frm_cad_produtos
        frm.ShowDialog()
    End Sub
    Private Sub TxtPpromocao_Enter(sender As Object, e As EventArgs) Handles TxtPpromocao.Enter
        CorTxtBox(TxtPpromocao, "Am")
    End Sub

    Private Sub TxtPpromocao_Leave(sender As Object, e As EventArgs) Handles TxtPpromocao.Leave
        CorTxtBox(TxtPpromocao, "Br")
    End Sub
    Private Sub TxtDescricao_Enter(sender As Object, e As EventArgs) Handles TxtDescricao.Enter
        CorTxtBox(TxtDescricao, "Am")
    End Sub

    Private Sub TxtDescricao_Leave(sender As Object, e As EventArgs) Handles TxtDescricao.Leave
        CorTxtBox(TxtDescricao, "Br")
    End Sub
    Private Sub TxtPercDesc_Enter(sender As Object, e As EventArgs) Handles TxtPercDesc.Enter
        CorTxtBox(TxtPercDesc, "Am")
    End Sub

    Private Sub TxtPercDesc_Leave(sender As Object, e As EventArgs) Handles TxtPercDesc.Leave
        CorTxtBox(TxtPercDesc, "Br")
    End Sub
    Private Sub Frm_cad_promocao_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        If PesqProd = "True" Then
            TxtDescricao.Text = NomeProd
            TxtCod.Text = IdProd
            TxtPvenda.Text = PrecoVenda
            TxtPcusto.Text = PrecoCusto

            PrecoVenda = ""
            PrecoCusto = ""
            NomeProd = ""
            IdProd = ""
            PesqProd = ""
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click, BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Editar_Promocao()
    End Sub
    Sub Editar_Promocao()

        'Stop
        If MsgBox("Deseja salvar edicação? ", vbYesNo, "Editar") = vbYes Then

            Dim dbl1 As Double = 0
            Dim dbl2 As Double = 0
            Double.TryParse(TxtPpromocao.Text, dbl1)
            Double.TryParse(TxtPcusto.Text, dbl2)

            If dbl1 < dbl2 Then
                If MsgBox("Preço promocional está abaixo do preço de custo, deseja salvar mesmo assim? ", vbYesNo, "Preço Promocional") = vbYes Then

                    Salvar_Promocao()
                    Me.Close()
                Else

                    Exit Sub
                End If
            Else
                Salvar_Promocao()
                Me.Close()
            End If

        End If

    End Sub
    Sub Salvar_Promocao()
        Try
            Abrir()
            Dim cmd As MySqlCommand

            Dim dataI As String
            Dim dataF As String
            Dim prm As String
            prm = "Sim"

            dataI = DataInicio.Value.ToString("yyyy-MM-dd")
            dataF = DataFim.Value.ToString("yyyy-MM-dd")

            Dim sqls As String
            Dim cod As String

            cod = TxtCod.Text

            sqls = "UPDATE tbl_cad_produtos SET prm_promocao= '" & prm & "', prm_data_inicio='" & dataI & "', prm_data_fim='" & dataF & "', prm_preco='" & TxtPpromocao.Text.Replace(",", ".") & "' WHERE id = '" & cod & "' "
            cmd = New MySqlCommand(sqls, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub
    Private Sub Frm_cad_promocao_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        If e.KeyCode = Keys.Enter Then
            Editar_Promocao()
        End If
    End Sub

    Private Sub TxtPpromocao_TextChanged(sender As Object, e As EventArgs) Handles TxtPpromocao.TextChanged

        If RbValor.Checked = True Then

            TxtPercDesc.Enabled = False
            Dim dbl1 As Double = 0
            Dim dbl2 As Double = 0

            Double.TryParse(TxtPvenda.Text, dbl1)
            Double.TryParse(TxtPpromocao.Text, dbl2)

            TxtPercDesc.Text = Format(-((dbl1 - dbl2) / dbl1), "##.00%")
        End If


    End Sub

    Private Sub TxtPercDesc_TextChanged(sender As Object, e As EventArgs) Handles TxtPercDesc.TextChanged
        If RbPercent.Checked = True Then
            TxtPpromocao.Enabled = False
            Dim dbl1 As Double = 0
            Dim dbl2 As Double = 0

            Double.TryParse(TxtPvenda.Text, dbl1)
            Double.TryParse(TxtPercDesc.Text, dbl2)

            TxtPpromocao.Text = ((dbl1 - (dbl1 * dbl2)))

        End If
    End Sub

    Private Sub RbValor_CheckedChanged(sender As Object, e As EventArgs) Handles RbValor.CheckedChanged

        If RbValor.Checked = True Then

            TxtPpromocao.Enabled = True
            TxtPercDesc.Enabled = False
            TxtPercDesc.Text = ""
            TxtPpromocao.Text = ""
            LabelPercent.Visible = False

        End If
    End Sub

    Private Sub RbPercent_CheckedChanged(sender As Object, e As EventArgs) Handles RbPercent.CheckedChanged
        If RbPercent.Checked = True Then

            TxtPpromocao.Enabled = False
            TxtPercDesc.Enabled = True
            TxtPpromocao.Text = ""
            TxtPercDesc.Text = ""
            LabelPercent.Visible = True

        End If
    End Sub

    Private Sub TxtDescricao_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtDescricao.KeyDown
        If e.KeyCode = Keys.F5 Then
            PesqProd = "True"
            Dim frm As New Frm_cad_produtos
            frm.ShowDialog()
        End If
    End Sub

    Private Sub TxtPvenda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPvenda.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtPcusto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPcusto.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtPpromocao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPpromocao.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtPercDesc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPercDesc.KeyPress
        Permitir_Numeros(sender, e)
    End Sub
End Class