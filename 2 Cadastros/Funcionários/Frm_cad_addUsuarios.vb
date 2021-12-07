Imports MySql.Data.MySqlClient

Public Class Frm_cad_addUsuarios
    Private Sub Frm_cad_addUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtFuncionario.Focus()
        TxtFuncionario.Select()
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Salvar()

    End Sub

    Sub Salvar()
        If TxtCod.Text = "" Then
            If MsgBox("Deseja salvar registro? ", vbYesNo, "Salvar") = vbYes Then
                Salvar_Cad_Usuario()
                Exit Sub
            Else
                Exit Sub
            End If

        End If

        If TxtCod.Text > 0 Then
            If MsgBox("Deseja salvar edição? ", vbYesNo, "Editar") = vbYes Then
                Editar_Cad_Usuario()
                Exit Sub
            Else
                Exit Sub
            End If
        End If
    End Sub
    Sub Limpar_campos()

        TxtFuncionario.Text = ""
        TxtUsuario.Text = ""
        TxtSenha.Text = ""


    End Sub
    Private Sub Editar_Cad_Usuario()
        Try
            Abrir()
            Dim cmd As MySqlCommand
            Dim sqls As String
            Dim situacao As String = ""

            'VALIDANDO SE USUARIO NÃO É REPETIDO

            Dim cmd3 As MySqlCommand
            Dim reader3 As MySqlDataReader
            Dim sql3 As String

            sql3 = "SELECT usuario FROM tbl_cad_usuarios WHERE usuario = '" & TxtUsuario.Text & "' "
            cmd3 = New MySqlCommand(sql3, con)
            reader3 = cmd3.ExecuteReader
            If reader3.Read = True Then
                MsgBox("Usuário já cadastrado!!", MsgBoxStyle.Information, "Usuario/Senha")

                reader3.Close()
                Exit Sub

            Else
                reader3.Close()
            End If

            sqls = "UPDATE tbl_cad_usuarios SET  usuario ='" & TxtUsuario.Text & "', senha ='" & TxtSenha.Text & "'   WHERE id = '" & TxtCod.Text & "'"

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



    Private Sub Salvar_Cad_Usuario()

        If TxtUsuario.Text <> "" And TxtSenha.Text <> "" And TxtFuncionario.Text <> "" Then
            'Stop
            Try
                'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO
                TxtUsuario.BackColor = Color.White
                TxtFuncionario.BackColor = Color.White
                TxtSenha.BackColor = Color.White

                Abrir()

                'VALIDANDO SE FUNCIONÁRIOS NÃO É REPETIDO

                Dim cmd2 As MySqlCommand
                Dim reader2 As MySqlDataReader
                Dim sql2 As String

                sql2 = "SELECT id_funcionario FROM tbl_cad_usuarios WHERE id_funcionario = '" & TxtIdFunc.Text & "' "
                cmd2 = New MySqlCommand(sql2, con)
                reader2 = cmd2.ExecuteReader
                If reader2.Read = True Then
                    MsgBox("Funcionário já possui usuário e senha!!", MsgBoxStyle.Information, "Usuario/Senha")
                    reader2.Close()
                    Exit Sub

                Else
                    reader2.Close()
                End If

                'VALIDANDO SE USUARIO NÃO É REPETIDO

                Dim cmd3 As MySqlCommand
                Dim reader3 As MySqlDataReader
                Dim sql3 As String

                sql3 = "SELECT usuario FROM tbl_cad_usuarios WHERE usuario = '" & TxtUsuario.Text & "' "
                cmd3 = New MySqlCommand(sql3, con)
                reader3 = cmd3.ExecuteReader
                If reader3.Read = True Then
                    MsgBox("Usuário já cadastrado!!", MsgBoxStyle.Information, "Usuario/Senha")

                    reader3.Close()
                    Exit Sub

                Else
                    reader3.Close()
                End If

                Dim cmd As MySqlCommand
                Dim sqls As String
                Dim data As String
                Dim situacao As String = ""

                data = Now().ToString("yyyy-MM-dd")

                sqls = "INSERT INTO tbl_cad_usuarios (id_funcionario, id_funcao,  usuario, senha,  data_inclusao) VALUES ('" & TxtIdFunc.Text & "', '" & TxtIdFuncao.Text & "', '" & TxtUsuario.Text & "', '" & TxtSenha.Text & "','" & data & "')"

                cmd = New MySqlCommand(sqls, con)
                cmd.ExecuteNonQuery()

                MsgBox("Cadastro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar")

                Limpar_campos()

                Me.Close()
                Exit Sub
            Catch ex As Exception
                MessageBox.Show("Erro: " & ex.Message)
            End Try

        Else
            TxtUsuario.BackColor = Color.Salmon
            TxtSenha.BackColor = Color.Salmon
            TxtFuncionario.BackColor = Color.Salmon
            MsgBox("Campos vazios!!", MsgBoxStyle.Information, "Dados inválidos")
            TxtFuncionario.Focus()

        End If
    End Sub

    Private Sub Frm_cad_categoriasIncluir_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        If e.KeyCode = Keys.Enter Then
            Salvar()
        End If

        If e.KeyCode = Keys.F5 And EditarUsuario <> "True" Then
            FrmPesqFunc = "True"
            Dim frm As New Frm_cad_funcionarios
            frm.ShowDialog()
        End If

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click, BtnClose.Click
        Me.Close()
    End Sub

    Private Sub TxtFuncionario_Enter(sender As Object, e As EventArgs) Handles TxtFuncionario.Enter
        CorTxtBox(TxtFuncionario, "Am")
    End Sub

    Private Sub TxtFuncionario_Leave(sender As Object, e As EventArgs) Handles TxtFuncionario.Leave
        CorTxtBox(TxtFuncionario, "Br")
    End Sub

    Private Sub TxtUsuario_Enter(sender As Object, e As EventArgs) Handles TxtUsuario.Enter
        CorTxtBox(TxtUsuario, "Am")
    End Sub

    Private Sub TxtUsuario_Leave(sender As Object, e As EventArgs) Handles TxtUsuario.Leave
        CorTxtBox(TxtUsuario, "Br")
    End Sub

    Private Sub TxtSenha_Enter(sender As Object, e As EventArgs) Handles TxtSenha.Enter
        CorTxtBox(TxtSenha, "Am")
    End Sub

    Private Sub TxtSenha_Leave(sender As Object, e As EventArgs) Handles TxtSenha.Leave
        CorTxtBox(TxtSenha, "Br")
    End Sub

    Private Sub BtnPesqFunc_Click(sender As Object, e As EventArgs) Handles BtnPesqFunc.Click
        FrmPesqFunc = "True"
        Dim frm As New Frm_cad_funcionarios
        frm.ShowDialog()
    End Sub

    Private Sub Frm_cad_addUsuarios_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        If PesqFunc = "True" Then

            TxtIdFunc.Text = IdFunc
            TxtFuncionario.Text = NomeFunc
            TxtIdFuncao.Text = IdFuncaoFunc
            TxtFuncao.Text = FuncaoFunc

        End If
    End Sub

    Private Sub Frm_cad_addUsuarios_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        PesqFunc = ""
        EditarUsuario = ""
    End Sub

    '\\ MOVER FORM PELO CORPO
    Private WM_NCHITTEST As Integer = &H84
    Private HTCLIENT As Integer = &H1
    Private HTCAPTION As Integer = &H2

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