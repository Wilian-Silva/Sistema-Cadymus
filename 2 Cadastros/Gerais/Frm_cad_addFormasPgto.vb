Imports MySql.Data.MySqlClient

Public Class Frm_cad_addFormasPgto
    Private Sub Frm_cad_addFormasPgto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtPgto.Focus()
        TxtPgto.Select()
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Salvar()

    End Sub

    Sub Salvar()
        If TxtCod.Text = "" Then
            If MsgBox("Deseja salvar registro? ", vbYesNo, "Salvar") = vbYes Then
                Salvar_Cad_Pgto()
                Exit Sub
            Else
                Exit Sub
            End If

        End If

        If TxtCod.Text > 0 Then
            If MsgBox("Deseja salvar edição? ", vbYesNo, "Editar") = vbYes Then
                Editar_Cad_Pgto()
                Exit Sub
            Else
                Exit Sub
            End If
        End If
    End Sub
    Sub Limpar_campos()
        TxtPgto.Text = ""
        TxtDescricao.Text = ""

    End Sub
    Private Sub Editar_Cad_Pgto()
        Try
            Abrir()
            Dim cmd As MySqlCommand
            Dim sqls As String

            sqls = "UPDATE tbl_cad_formaspgto SET tipo_pgto ='" & TxtPgto.Text & "' , descricao = '" & TxtDescricao.Text & "' WHERE id = '" & TxtCod.Text & "'"

            cmd = New MySqlCommand(sqls, con)
            cmd.ExecuteNonQuery()

            MsgBox("Cadastro editado com Sucesso!!", MsgBoxStyle.Information, "Editar")

            Limpar_campos()
            Me.Close()
            Exit Sub

        Catch ex As Exception
            MessageBox.Show("Erro:" & ex.Message)
        End Try
    End Sub

    Private Sub Salvar_Cad_Pgto()
        If TxtPgto.Text <> "" Then

            Try
                'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO
                TxtPgto.BackColor = Color.White
                Abrir()
                Dim cmd As MySqlCommand
                Dim sqls As String

                Dim data As String
                data = Now().ToString("yyyy-MM-dd")

                sqls = "INSERT INTO tbl_cad_formaspgto (tipo_pgto, data_inclusao, descricao ) VALUES ('" & TxtPgto.Text & "', '" & data & "', '" & TxtDescricao.Text & "')"

                cmd = New MySqlCommand(sqls, con)
                cmd.ExecuteNonQuery()

                MsgBox("Cadastro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar")

                Limpar_campos()

                Me.Close()
                Exit Sub
            Catch ex As Exception
                MessageBox.Show("Erro:" & ex.Message)
            End Try

        Else
            TxtPgto.BackColor = Color.Salmon
            MsgBox("Campos vazios!!", MsgBoxStyle.Information, "Dados inválidos")
            TxtPgto.Focus()

        End If
    End Sub

    Private Sub TxtCategoria_Enter(sender As Object, e As EventArgs) Handles TxtPgto.Enter
        CorTxtBox(TxtPgto, "Am")
    End Sub

    Private Sub TxtCategoria_Leave(sender As Object, e As EventArgs) Handles TxtPgto.Leave
        CorTxtBox(TxtPgto, "Br")
    End Sub

    Private Sub TxtDescricao_Enter(sender As Object, e As EventArgs) Handles TxtDescricao.Enter
        CorTxtBox(TxtDescricao, "Am")
    End Sub

    Private Sub TxtDescricao_Leave(sender As Object, e As EventArgs) Handles TxtDescricao.Leave
        CorTxtBox(TxtDescricao, "Br")
    End Sub

    Private Sub Frm_cad_categoriasIncluir_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        If e.KeyCode = Keys.F3 Then
            Salvar()
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub


End Class