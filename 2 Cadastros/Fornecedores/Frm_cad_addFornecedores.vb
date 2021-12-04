Imports MySql.Data.MySqlClient

Public Class Frm_cad_addFornecedores
    Private Sub Frm_cad_addFornecedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtNome.Focus()
        TxtNome.Select()
    End Sub
    Sub Limpar_campos()
        TxtNome.Text = ""

        TxtCpf.Text = ""
        TxtCnpj.Text = ""
        TxtCep.Text = ""
        TxtEndereco.Text = ""
        TxtNum.Text = ""
        TxtComp.Text = ""
        TxtEstado.Text = ""
        TxtBairro.Text = ""
        TxtCidade.Text = ""
        TxtTel.Text = ""
        TxtEmail.Text = ""

    End Sub
    Private Sub TxtCep_Leave(sender As Object, e As EventArgs) Handles TxtCep.Leave

        If TxtCep.Text <> "     -" Then

            Try
                Dim ds As New DataSet
                Dim xml As String = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", TxtCep.Text)

                ds.ReadXml(xml)

                TxtBairro.Text = ds.Tables(0).Rows(0)("bairro")
                TxtCidade.Text = ds.Tables(0).Rows(0)("cidade")
                TxtEstado.Text = ds.Tables(0).Rows(0)("uf")
                TxtEndereco.Text = ds.Tables(0).Rows(0)("tipo_logradouro") & " " & ds.Tables(0).Rows(0)("logradouro")

            Catch ex As Exception

                MessageBox.Show("Erro:" & ex.Message)
            End Try
        End If

        CorTxtBox(TxtCep, "Br")
    End Sub



    Sub Salvar_Cad_Fornecedor()
        'Stop

        If TxtNome.Text <> "" And RbPessoaFisica.Checked = True Or RbPessoaJuridica.Checked = True Then

            Try
                'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO
                TxtNome.BackColor = Color.White
                RbPessoaFisica.BackColor = Color.White
                RbPessoaJuridica.BackColor = Color.White

                '//VALIDANDO TIPO DE PESSOAL, FISICA OU JURIDICA
                Dim tipo As String
                Dim cod As String
                Dim situacao As String
                tipo = ""
                cod = ""
                situacao = ""


                If RbPessoaFisica.Checked Then
                    tipo = "Pessoa Física"
                    cod = TxtCpf.Text
                End If

                If RbPessoaJuridica.Checked Then
                    tipo = "Pessoa Jurídica"
                    cod = TxtCnpj.Text
                End If

                '//VALIDANDO SITUAÇÃO CADASTRAL
                If RbAtivo.Checked Then
                    situacao = "Ativo"
                End If
                If RbInativo.Checked Then
                    situacao = "Inativo"
                End If
                Abrir()
                Dim cmd As MySqlCommand
                Dim sqls As String

                Dim data As String
                data = Now().ToString("yyyy-MM-dd")

                sqls = "INSERT INTO tbl_cad_fornecedores (tipo, nome, cpf_cnpj, cep, endereco, numero, comp, estado, bairro, cidade, telefone, email, status, data_inclusao )" _
            & "VALUES('" & tipo & "', '" & TxtNome.Text & "', '" & cod & "','" & TxtCep.Text & "', '" & TxtEndereco.Text & "', '" & TxtNum.Text & "', '" & TxtComp.Text & "'," _
            & "'" & TxtEstado.Text & "', '" & TxtBairro.Text & "','" & TxtCidade.Text & "','" & TxtTel.Text & "', '" & TxtEmail.Text & "','" & situacao & "', '" & data & "')"

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
            TxtNome.BackColor = Color.Salmon
            RbPessoaFisica.BackColor = Color.Salmon
            RbPessoaJuridica.BackColor = Color.Salmon
            MsgBox("Campos vazios!!", MsgBoxStyle.Information, "Dados inválidos")
            TxtNome.Focus()

        End If
    End Sub
    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Salvar_Forncedor()
    End Sub

    Sub Salvar_Forncedor()
        If TxtCod.Text = "" Then
            If MsgBox("Deseja salvar registro? ", vbYesNo, "Salvar") = vbYes Then
                Salvar_Cad_Fornecedor()
                Exit Sub
            Else
                Exit Sub
            End If


        End If

        If TxtCod.Text > 0 Then
            If MsgBox("Deseja salvar edição? ", vbYesNo, "Editar") = vbYes Then
                Editar_Cad_Fornecedor()
                Exit Sub
            Else
                Exit Sub
            End If

        End If

    End Sub
    Private Sub Editar_Cad_Fornecedor()
        'Stop
        Try
            Dim tipo As String
            Dim cod As String
            Dim situacao As String

            tipo = ""
            cod = ""
            situacao = ""


            If RbPessoaFisica.Checked Then
                tipo = "Pessoa Física"
                cod = TxtCpf.Text
            End If

            If RbPessoaJuridica.Checked Then
                tipo = "Pessoa Jurídica"
                cod = TxtCnpj.Text
            End If

            '//VALIDANDO SITUAÇÃO CADASTRAL
            If RbAtivo.Checked Then
                situacao = "Ativo"
            End If
            If RbInativo.Checked Then
                situacao = "Inativo"
            End If

            Abrir()
            Dim cmd As MySqlCommand
            Dim sqls As String

            sqls = "UPDATE tbl_cad_fornecedores SET tipo = '" & tipo & "', nome='" & TxtNome.Text & "' , cpf_cnpj = '" & cod & "', cep = " _
            & "  '" & TxtCep.Text & "', endereco = '" & TxtEndereco.Text & "', numero = '" & TxtNum.Text & "', comp = '" & TxtComp.Text & "', estado = '" & TxtEstado.Text & "', bairro =" _
            & " '" & TxtBairro.Text & "', cidade ='" & TxtCidade.Text & "' , telefone ='" & TxtTel.Text & "' , email = '" & TxtEmail.Text & "', status ='" & situacao & "' WHERE id = '" & TxtCod.Text & "'"

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
    Private Sub TxtNome_Enter(sender As Object, e As EventArgs) Handles TxtNome.Enter
        CorTxtBox(TxtNome, "Am")
    End Sub
    Private Sub TxtNome_Leave(sender As Object, e As EventArgs) Handles TxtNome.Leave
        CorTxtBox(TxtNome, "Br")
    End Sub
    Private Sub TxtCpf_Enter(sender As Object, e As EventArgs) Handles TxtCpf.Enter
        CorTxtBox(TxtCpf, "Am")
    End Sub
    Private Sub TxtCpf_Leave(sender As Object, e As EventArgs) Handles TxtCpf.Leave
        CorTxtBox(TxtCpf, "Br")
    End Sub
    Private Sub TxtCnpj_Enter(sender As Object, e As EventArgs) Handles TxtCnpj.Enter
        CorTxtBox(TxtCnpj, "Am")
    End Sub
    Private Sub TxtCnpj_Leave(sender As Object, e As EventArgs) Handles TxtCnpj.Leave
        CorTxtBox(TxtCnpj, "Br")
    End Sub
    Private Sub TxtCep_Enter(sender As Object, e As EventArgs) Handles TxtCep.Enter
        CorTxtBox(TxtCep, "Am")
    End Sub
    Private Sub TxtEndereco_Enter(sender As Object, e As EventArgs) Handles TxtEndereco.Enter
        CorTxtBox(TxtEndereco, "Am")
    End Sub
    Private Sub TxtEndereco_Leave(sender As Object, e As EventArgs) Handles TxtEndereco.Leave
        CorTxtBox(TxtEndereco, "Br")
    End Sub
    Private Sub TxtNum_Enter(sender As Object, e As EventArgs) Handles TxtNum.Enter
        CorTxtBox(TxtNum, "Am")
    End Sub

    Private Sub TxtNum_Leave(sender As Object, e As EventArgs) Handles TxtNum.Leave
        CorTxtBox(TxtNum, "Br")
    End Sub

    Private Sub TxtComp_Enter(sender As Object, e As EventArgs) Handles TxtComp.Enter
        CorTxtBox(TxtComp, "Am")
    End Sub

    Private Sub TxtComp_Leave(sender As Object, e As EventArgs) Handles TxtComp.Leave
        CorTxtBox(TxtComp, "Br")
    End Sub

    Private Sub TxtEstado_Enter(sender As Object, e As EventArgs) Handles TxtEstado.Enter
        CorTxtBox(TxtEstado, "Am")
    End Sub

    Private Sub TxtEstado_Leave(sender As Object, e As EventArgs) Handles TxtEstado.Leave
        CorTxtBox(TxtEstado, "Br")
    End Sub

    Private Sub TxtBairro_Enter(sender As Object, e As EventArgs) Handles TxtBairro.Enter
        CorTxtBox(TxtBairro, "Am")
    End Sub

    Private Sub TxtBairro_Leave(sender As Object, e As EventArgs) Handles TxtBairro.Leave
        CorTxtBox(TxtBairro, "Br")
    End Sub

    Private Sub TxtCidade_Enter(sender As Object, e As EventArgs) Handles TxtCidade.Enter
        CorTxtBox(TxtCidade, "Am")
    End Sub

    Private Sub TxtCidade_Leave(sender As Object, e As EventArgs) Handles TxtCidade.Leave
        CorTxtBox(TxtCidade, "Br")
    End Sub

    Private Sub TxtTel_Enter(sender As Object, e As EventArgs) Handles TxtTel.Enter
        CorTxtBox(TxtTel, "Am")
    End Sub

    Private Sub TxtTel_Leave(sender As Object, e As EventArgs) Handles TxtTel.Leave
        CorTxtBox(TxtTel, "Br")
    End Sub

    Private Sub TxtEmail_Enter(sender As Object, e As EventArgs) Handles TxtEmail.Enter
        CorTxtBox(TxtEmail, "Am")
    End Sub

    Private Sub TxtEmail_Leave(sender As Object, e As EventArgs) Handles TxtEmail.Leave
        CorTxtBox(TxtEmail, "Br")
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub RbPessoaFisica_CheckedChanged(sender As Object, e As EventArgs) Handles RbPessoaFisica.CheckedChanged
        If RbPessoaFisica.Checked = True Then
            TxtCpf.Text = ""
            TxtCnpj.Text = ""
            TxtCpf.Enabled = True
            TxtCnpj.Enabled = False

        End If
    End Sub

    Private Sub RbPessoaJuridica_CheckedChanged(sender As Object, e As EventArgs) Handles RbPessoaJuridica.CheckedChanged
        If RbPessoaJuridica.Checked = True Then
            TxtCpf.Text = ""
            TxtCnpj.Text = ""
            TxtCpf.Enabled = False
            TxtCnpj.Enabled = True

        End If
    End Sub

    Private Sub Frm_cad_clientesIncluir_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        If e.KeyCode = Keys.F3 Then
            Salvar_Forncedor()
        End If

    End Sub

    Private Sub TxtCpf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCpf.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtCnpj_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCnpj.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtCep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCep.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNum.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTel.KeyPress
        Permitir_Numeros(sender, e)
    End Sub


End Class