Imports MySql.Data.MySqlClient

Public Class Frm_ven_rejaustePreco

    Private Sub TxtReajustePreco_Enter(sender As Object, e As EventArgs) Handles TxtReajustePreco.Enter
        CorTxtBox(TxtReajustePreco, "Am")
    End Sub

    Private Sub TxtReajustePreco_Leave(sender As Object, e As EventArgs) Handles TxtReajustePreco.Leave
        CorTxtBox(TxtReajustePreco, "Br")
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles Button2.Click, BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TxtReajustePreco.Text <> "" Then

            If MsgBox("Atenção: essa rotina irá reajustar os preços de venda de todos os proutos cadastrados em " & (TxtReajustePreco.Text - 1) * 100 & "% , deseja continuar?", vbYesNo, "Atualizar Preço de Venda") = vbYes Then

                ReajustePreco()

            End If

        Else
            MsgBox("Informe o percentual de reajuste de preço!!", MsgBoxStyle.Information, "Reajuste Preço Venda")
            Exit Sub
        End If

    End Sub
    Sub ReajustePreco()
        Try

            Abrir()
            '//ATUALIZANDO OS NOVOS VALORES NO BANCO DE DADOS
            ' Stop
            Dim cmds As MySqlCommand
            Dim sqls As String

            sqls = "UPDATE tbl_cad_produtos SET preco_venda = preco_venda *  " & TxtReajustePreco.Text.Replace(",", ".") & ", markup = ( preco_venda - preco_custo ) / preco_venda "
            cmds = New MySqlCommand(sqls, con)
            cmds.ExecuteNonQuery()

            MsgBox("Preço de venda atualizado com Sucesso!!", MsgBoxStyle.Information, "Preço Venda")

            TxtReajustePreco.Text = ""
            Me.Close()
        Catch ex As Exception
            MsgBox("Erro ---- " + ex.Message)
        End Try
    End Sub

    Private Sub TxtReajustePreco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtReajustePreco.KeyPress
        Permitir_Numeros(sender, e)
    End Sub
End Class