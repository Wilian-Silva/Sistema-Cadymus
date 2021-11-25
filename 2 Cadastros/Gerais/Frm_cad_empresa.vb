Imports MySql.Data.MySqlClient

Public Class Frm_cad_empresa
    Dim codEmpresa As Integer
    Private Sub Frm_cad_empresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IdEmpresa_pesquisar()
        Listar_Empresa()

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

    Sub Salvar_Cad_Empresa()
        'Stop

        If TxtRazaoSocial.Text <> "" And RbPessoaFisica.Checked = True Or RbPessoaJuridica.Checked = True Then

            Try
                'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO
                TxtRazaoSocial.BackColor = Color.White
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

                sqls = "INSERT INTO tbl_cad_empresas (tipo, nome, nome_fantasia, cpf_cnpj, cep, endereco, numero, comp, estado, bairro, cidade, telefone, email, status, data_inclusao )" _
            & "VALUES('" & tipo & "', '" & TxtRazaoSocial.Text & "', '" & TxtNomeFatasia.Text & "', '" & cod & "','" & TxtCep.Text & "', '" & TxtEndereco.Text & "', '" & TxtNum.Text & "', '" & TxtComp.Text & "'," _
            & "'" & TxtEstado.Text & "', '" & TxtBairro.Text & "','" & TxtCidade.Text & "','" & TxtTel.Text & "', '" & TxtEmail.Text & "','" & situacao & "', '" & data & "')"

                cmd = New MySqlCommand(sqls, con)
                cmd.ExecuteNonQuery()

                MsgBox("Cadastro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar")

                Limpar_campos()
                Bloquear_campos()
                IdEmpresa_pesquisar()
                Listar_Empresa()

                Exit Sub

            Catch ex As Exception
                MessageBox.Show("Erro:" & ex.Message)
            End Try

        Else
            TxtRazaoSocial.BackColor = Color.Salmon
            RbPessoaFisica.BackColor = Color.Salmon
            RbPessoaJuridica.BackColor = Color.Salmon
            MsgBox("Campos vazios!!", MsgBoxStyle.Information, "Dados inválidos")
            TxtRazaoSocial.Focus()

        End If
    End Sub
    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Salvar_Empresa()
    End Sub

    Sub Salvar_Empresa()
        'Stop
        If editarEmpresa = "True" Then

            If MsgBox("Deseja salvar edição? ", vbYesNo, "Editar") = vbYes Then
                Editar_Cad_Empresa()
                editarEmpresa = ""
                Exit Sub
            Else
                editarEmpresa = ""
                Exit Sub
            End If

        Else

            If MsgBox("Deseja salvar registro? ", vbYesNo, "Salvar") = vbYes Then
                Salvar_Cad_Empresa()
                Exit Sub
            Else
                Exit Sub
            End If

        End If

    End Sub
    Private Sub Editar_Cad_Empresa()
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

            sqls = "UPDATE tbl_cad_empresas SET tipo = '" & tipo & "', nome='" & TxtRazaoSocial.Text & "' , nome_fantasia='" & TxtNomeFatasia.Text & "', cpf_cnpj = '" & cod & "', cep = " _
            & "  '" & TxtCep.Text & "', endereco = '" & TxtEndereco.Text & "', numero = '" & TxtNum.Text & "', comp = '" & TxtComp.Text & "', estado = '" & TxtEstado.Text & "', bairro =" _
            & " '" & TxtBairro.Text & "', cidade ='" & TxtCidade.Text & "' , telefone ='" & TxtTel.Text & "' , email = '" & TxtEmail.Text & "', status ='" & situacao & "' WHERE id = '" & TxtCod.Text & "'"

            cmd = New MySqlCommand(sqls, con)
            cmd.ExecuteNonQuery()

            MsgBox("Cadastro editado com Sucesso!!", MsgBoxStyle.Information, "Editar")

            Limpar_campos()
            Bloquear_campos()
            IdEmpresa_pesquisar()
            Listar_Empresa()

            Exit Sub

        Catch ex As Exception
            MessageBox.Show("Erro:" & ex.Message)
        End Try
    End Sub
    Private Sub TxtNome_Enter(sender As Object, e As EventArgs) Handles TxtRazaoSocial.Enter
        CorTxtBox(TxtRazaoSocial, "Am")
    End Sub
    Private Sub TxtNome_Leave(sender As Object, e As EventArgs) Handles TxtRazaoSocial.Leave
        CorTxtBox(TxtRazaoSocial, "Br")
    End Sub
    Private Sub TxtCpf_Enter(sender As Object, e As EventArgs) Handles TxtCpf.Enter
        CorTxtBox(TxtCpf, "Am")
    End Sub
    Private Sub TxtCpf_Leave(sender As Object, e As EventArgs) Handles TxtCpf.Leave
        CorTxtBox(TxtCpf, "Br")
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
    Private Sub TxtNomeFatasia_Enter(sender As Object, e As EventArgs) Handles TxtNomeFatasia.Enter
        CorTxtBox(TxtNomeFatasia, "Am")
    End Sub

    Private Sub TxtNomeFatasia_Leave(sender As Object, e As EventArgs) Handles TxtNomeFatasia.Leave
        CorTxtBox(TxtNomeFatasia, "Br")
    End Sub


    Private Sub RbPessoaFisica_CheckedChanged(sender As Object, e As EventArgs) Handles RbPessoaFisica.CheckedChanged
        If incluirEmpresa = "True" Then
            If RbPessoaFisica.Checked = True Then
                TxtCpf.Text = ""
                TxtCnpj.Text = ""
                TxtCpf.Enabled = True
                TxtCnpj.Enabled = False

            End If
        End If
    End Sub

    Private Sub RbPessoaJuridica_CheckedChanged(sender As Object, e As EventArgs) Handles RbPessoaJuridica.CheckedChanged
        If incluirEmpresa = "True" Then

            If RbPessoaJuridica.Checked = True Then
                TxtCpf.Text = ""
                TxtCnpj.Text = ""
                TxtCpf.Enabled = False
                TxtCnpj.Enabled = True

            End If
        End If
    End Sub

    Private Sub Frm_cad_clientesIncluir_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        If e.KeyCode = Keys.F3 Then
            Salvar_Empresa()
        End If

    End Sub

    Private Sub TxtCpf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCpf.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtCnpj_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub BtnIncluir_Click(sender As Object, e As EventArgs) Handles BtnIncluir.Click

        Limpar_campos()
        Habilitar_campos()
        TxtRazaoSocial.Focus()
        TxtRazaoSocial.Select()
        RbAtivo.Checked = True
        incluirEmpresa = "True"
    End Sub
    Sub Habilitar_campos()

        TxtRazaoSocial.Enabled = True
        TxtNomeFatasia.Enabled = True
        TxtCpf.Enabled = True
        TxtCnpj.Enabled = True
        TxtCep.Enabled = True
        TxtEndereco.Enabled = True
        TxtNum.Enabled = True
        TxtComp.Enabled = True
        TxtEstado.Enabled = True
        TxtBairro.Enabled = True
        TxtCidade.Enabled = True
        TxtTel.Enabled = True
        TxtEmail.Enabled = True
        RbAtivo.Enabled = True
        RbInativo.Enabled = True
        RbPessoaFisica.Enabled = True
        RbPessoaJuridica.Enabled = True
    End Sub
    Sub Bloquear_campos()
        TxtRazaoSocial.Enabled = False
        TxtNomeFatasia.Enabled = False
        TxtCpf.Enabled = False
        TxtCnpj.Enabled = False
        TxtCep.Enabled = False
        TxtEndereco.Enabled = False
        TxtNum.Enabled = False
        TxtComp.Enabled = False
        TxtEstado.Enabled = False
        TxtBairro.Enabled = False
        TxtCidade.Enabled = False
        TxtTel.Enabled = False
        TxtEmail.Enabled = False
        RbAtivo.Enabled = False
        RbInativo.Enabled = False
        RbPessoaFisica.Enabled = False
        RbPessoaJuridica.Enabled = False
    End Sub

    Sub Limpar_campos()
        TxtCod.Text = ""
        TxtRazaoSocial.Text = ""
        TxtNomeFatasia.Text = ""
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
        RbPessoaJuridica.Checked = False
        RbPessoaFisica.Checked = False
        incluirEmpresa = ""
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Limpar_campos()
        IdEmpresa_pesquisar()
        Listar_Empresa()
        Bloquear_campos()

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        If TxtCod.Text <> "" Then
            Habilitar_campos()
            editarEmpresa = "True"
            incluirEmpresa = "True"
            TxtCnpj.Enabled = False
            TxtCpf.Enabled = False
            RbPessoaFisica.Enabled = False
            RbPessoaJuridica.Enabled = False
        End If
    End Sub


    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click


        If TxtCod.Text <> "" Then

            If MsgBox("Deseja excluir empresa " & TxtRazaoSocial.Text & "?", vbYesNo, "Exclusão") = vbYes Then

                Try
                    Abrir()

                    'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                    Dim cmd As MySqlCommand
                    Dim sql As String

                    sql = "DELETE FROM tbl_cad_empresas where id = '" & TxtCod.Text & "' "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    MsgBox("Registro excluído com Sucesso!!", MsgBoxStyle.Information, "Exlusão")

                    Limpar_campos()
                    Bloquear_campos()
                    Listar_Empresa()

                Catch ex As Exception
                    MsgBox("Erro ao excluir!!" + ex.Message)
                End Try
            End If
        Else

            MsgBox("Selecione um registro para excluir!!", MsgBoxStyle.Information, "Exlusão")
        End If

    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click

        Try
            If TxtCod.Text <> "" Then
                codEmpresa = TxtCod.Text - 1
            Else
                codEmpresa = 1
            End If
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sqlp As String
Line1:
            If codEmpresa = 0 Then

                Exit Sub
            End If

            sqlp = "SELECT id  FROM tbl_cad_empresas WHERE id = '" & codEmpresa & "' "
            cmd = New MySqlCommand(sqlp, con)
            reader = cmd.ExecuteReader

            If reader.Read = True Then
                reader.Close()

                Listar_Empresa()

                Exit Sub
            Else
                reader.Close()
                codEmpresa -= 1
                GoTo Line1
            End If

        Catch ex As Exception
            MsgBox("Erro:" + ex.Message)
        End Try


    End Sub

    Private Sub BtnProximo_Click(sender As Object, e As EventArgs) Handles BtnProximo.Click

        Dim maximo As Integer
        Try

            Try
                Abrir()

                'VERIFICAR ULTIMO ID NO BANCO 
                Dim cmdp As MySqlCommand
                Dim sql As String
                Dim reader1 As MySqlDataReader

                sql = "SELECT MAX(id) as id FROM tbl_cad_empresas "
                cmdp = New MySqlCommand(sql, con)
                reader1 = cmdp.ExecuteReader()
                reader1.Read()

                If Not IsDBNull(reader1("id")) Then
                    maximo = reader1("id")
                    reader1.Close()
                Else
                    reader1.Close()
                End If

            Catch ex As Exception
                MsgBox("Erro: " + ex.Message)
            End Try
            '.........................................................................................................

            If TxtCod.Text <> "" Then
                codEmpresa = TxtCod.Text + 1
            Else
                codEmpresa = 1
            End If

            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sqlp As String

Line1:
            If codEmpresa > maximo Then
                Exit Sub
            End If

            sqlp = "SELECT id FROM tbl_cad_empresas WHERE id = '" & codEmpresa & "' "
            cmd = New MySqlCommand(sqlp, con)
            reader = cmd.ExecuteReader

            If reader.Read = True Then
                reader.Close()

                Listar_Empresa()

                Exit Sub
            Else
                reader.Close()
                codEmpresa += 1
                GoTo Line1
            End If

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message)
        End Try

    End Sub
    Sub IdEmpresa_pesquisar()
        Try
            Abrir()

            '//SELECIONANDO A ULTIMA EMPRESA CADASTRADA
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql As String
            sql = "Select MAX(id) As id FROM tbl_cad_empresas"
            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader
            reader.Read()
            If Not IsDBNull(reader("id")) Then
                codEmpresa = reader("id")
                reader.Close()
            Else
                reader.Close()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Erro:" & ex.Message)
        End Try
    End Sub
    Sub Listar_Empresa()

        Try
            Abrir()

            Dim cmd3 As MySqlCommand
            Dim reader3 As MySqlDataReader
            Dim sql3 As String
            Dim situacao As String
            Dim pessoa As String
            sql3 = "SELECT id, tipo, nome, nome_fantasia, cpf_cnpj, cep, endereco, numero, comp, estado, bairro, cidade, telefone, email, status FROM tbl_cad_empresas WHERE id = '" & codEmpresa & "' "
            cmd3 = New MySqlCommand(sql3, con)
            reader3 = cmd3.ExecuteReader
            If reader3.Read = True Then

                TxtCod.Text = reader3("id")
                TxtRazaoSocial.Text = reader3("nome")
                TxtNomeFatasia.Text = reader3("nome_fantasia")
                TxtCep.Text = reader3("cep")
                TxtEndereco.Text = reader3("endereco")
                TxtNum.Text = reader3("numero")
                TxtComp.Text = reader3("comp")
                TxtEstado.Text = reader3("estado")
                TxtBairro.Text = reader3("bairro")
                TxtCidade.Text = reader3("cidade")
                TxtTel.Text = reader3("telefone")
                TxtEmail.Text = reader3("email")

                situacao = reader3("status")
                pessoa = reader3("tipo")

                If pessoa = "Pessoa Física" Then
                    TxtCpf.Text = reader3("cpf_cnpj")
                    RbPessoaFisica.Checked = True
                End If

                If pessoa = "Pessoa Jurídica" Then
                    TxtCnpj.Text = reader3("cpf_cnpj")
                    RbPessoaJuridica.Checked = True
                End If

                If situacao = "Ativo" Then
                    RbAtivo.Checked = True
                End If
                If situacao = "Inativo" Then
                    RbInativo.Checked = True
                End If

                reader3.Close()
                Exit Sub

            Else
                reader3.Close()
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show("Erro:" & ex.Message)
        End Try

    End Sub

End Class