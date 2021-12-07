Imports MySql.Data.MySqlClient

Public Class Frm_cad_addGastosFunc


    Private Sub TxtSalario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSalario.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSalarioFamilia.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub Txt13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt13Salario.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtFerias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFerias.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtFgts_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFgts.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtInss_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtInss.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtVrVa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtVrVa.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtVt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtVt.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtSaude_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSaude.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtOdonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtOdonto.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtPrev_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPrev.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtPlr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPlr.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtOutros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtOutros.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub TxtFuncionario_Enter(sender As Object, e As EventArgs) Handles TxtFuncionario.Enter
        CorTxtBox(TxtFuncionario, "Am")
    End Sub

    Private Sub TxtFuncionario_Leave(sender As Object, e As EventArgs) Handles TxtFuncionario.Leave
        CorTxtBox(TxtFuncionario, "Br")
    End Sub

    Private Sub TxtSalario_Enter(sender As Object, e As EventArgs) Handles TxtSalario.Enter
        CorTxtBox(TxtSalario, "Am")
    End Sub

    Private Sub TxtSalario_Leave(sender As Object, e As EventArgs) Handles TxtSalario.Leave
        CorTxtBox(TxtSalario, "Br")
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TxtSalarioFamilia.Enter
        CorTxtBox(TxtSalarioFamilia, "Am")
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TxtSalarioFamilia.Leave
        CorTxtBox(TxtSalarioFamilia, "Br")
    End Sub

    Private Sub Txt13_Enter(sender As Object, e As EventArgs) Handles Txt13Salario.Enter
        CorTxtBox(Txt13Salario, "Am")
    End Sub

    Private Sub Txt13_Leave(sender As Object, e As EventArgs) Handles Txt13Salario.Leave
        CorTxtBox(Txt13Salario, "Br")
    End Sub

    Private Sub TxtFerias_Enter(sender As Object, e As EventArgs) Handles TxtFerias.Enter
        CorTxtBox(TxtFerias, "Am")
    End Sub

    Private Sub TxtFerias_Leave(sender As Object, e As EventArgs) Handles TxtFerias.Leave
        CorTxtBox(TxtFerias, "Br")
    End Sub

    Private Sub TxtFgts_Enter(sender As Object, e As EventArgs) Handles TxtFgts.Enter
        CorTxtBox(TxtFgts, "Am")
    End Sub

    Private Sub TxtFgts_Leave(sender As Object, e As EventArgs) Handles TxtFgts.Leave
        CorTxtBox(TxtFgts, "Br")
    End Sub

    Private Sub TxtInss_Enter(sender As Object, e As EventArgs) Handles TxtInss.Enter
        CorTxtBox(TxtInss, "Am")
    End Sub

    Private Sub TxtInss_Leave(sender As Object, e As EventArgs) Handles TxtInss.Leave
        CorTxtBox(TxtInss, "Br")
    End Sub

    Private Sub TxtVrVa_Enter(sender As Object, e As EventArgs) Handles TxtVrVa.Enter
        CorTxtBox(TxtVrVa, "Am")
    End Sub

    Private Sub TxtVrVa_Leave(sender As Object, e As EventArgs) Handles TxtVrVa.Leave
        CorTxtBox(TxtVrVa, "Br")
    End Sub

    Private Sub TxtVt_Enter(sender As Object, e As EventArgs) Handles TxtVt.Enter
        CorTxtBox(TxtVt, "Am")
    End Sub

    Private Sub TxtVt_Leave(sender As Object, e As EventArgs) Handles TxtVt.Leave
        CorTxtBox(TxtVt, "Br")
    End Sub

    Private Sub TxtSaude_Enter(sender As Object, e As EventArgs) Handles TxtSaude.Enter
        CorTxtBox(TxtSaude, "Am")
    End Sub

    Private Sub TxtSaude_Leave(sender As Object, e As EventArgs) Handles TxtSaude.Leave
        CorTxtBox(TxtSaude, "Br")
    End Sub

    Private Sub TxtOdonto_Enter(sender As Object, e As EventArgs) Handles TxtOdonto.Enter
        CorTxtBox(TxtOdonto, "Am")
    End Sub

    Private Sub TxtOdonto_Leave(sender As Object, e As EventArgs) Handles TxtOdonto.Leave
        CorTxtBox(TxtOdonto, "Br")
    End Sub

    Private Sub TxtPrev_Enter(sender As Object, e As EventArgs) Handles TxtPrev.Enter
        CorTxtBox(TxtPrev, "Am")
    End Sub

    Private Sub TxtPrev_Leave(sender As Object, e As EventArgs) Handles TxtPrev.Leave
        CorTxtBox(TxtPrev, "Br")
    End Sub

    Private Sub TxtPlr_Enter(sender As Object, e As EventArgs) Handles TxtPlr.Enter
        CorTxtBox(TxtPlr, "Am")
    End Sub

    Private Sub TxtPlr_Leave(sender As Object, e As EventArgs) Handles TxtPlr.Leave
        CorTxtBox(TxtPlr, "Br")
    End Sub

    Private Sub TxtOutros_Enter(sender As Object, e As EventArgs) Handles TxtOutros.Enter
        CorTxtBox(TxtOutros, "Am")
    End Sub

    Private Sub TxtOutros_Leave(sender As Object, e As EventArgs) Handles TxtOutros.Leave
        CorTxtBox(TxtOutros, "Br")
    End Sub

    Private Sub TxtDescricao_Enter(sender As Object, e As EventArgs) Handles TxtDescricao.Enter
        CorTxtBox(TxtDescricao, "Am")
    End Sub

    Private Sub TxtDescricao_Leave(sender As Object, e As EventArgs) Handles TxtDescricao.Leave
        CorTxtBox(TxtDescricao, "Br")
    End Sub

    Private Sub BtnPesqFunc_Click(sender As Object, e As EventArgs) Handles BtnPesqFunc.Click
        FrmPesqFunc = "True"
        Dim frm As New Frm_cad_funcionarios
        frm.ShowDialog()
    End Sub

    Private Sub Frm_cad_addGastosFunc_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        If e.KeyCode = Keys.Enter Then
            Salvar()
        End If

    End Sub


    Sub Salvar()
        If TxtCod.Text = "" Then
            If MsgBox("Deseja salvar registro? ", vbYesNo, "Salvar") = vbYes Then
                Salvar_Gastos()
                Exit Sub
            Else
                Exit Sub
            End If

        End If

        If TxtCod.Text > 0 Then
            If MsgBox("Deseja salvar edição? ", vbYesNo, "Editar") = vbYes Then
                Editar_Gastos()
                Exit Sub
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Editar_Gastos()
        Try
            Abrir()
            Dim cmd As MySqlCommand
            Dim sqls As String
            Dim situacao As String = ""

            '//VALIDAR CAMPOS VAZIOS
            Campos_vazio()
            sqls = "UPDATE tbl_cad_gastosfunc SET salario_base = '" & TxtSalario.Text.Replace(",", ".") & "' , salario_familia = '" & TxtSalarioFamilia.Text.Replace(",", ".") & "', 13_salario = '" & Txt13Salario.Text.Replace(",", ".") & "'," _
                & " ferias= '" & TxtFerias.Text.Replace(",", ".") & "', fgts= '" & TxtFgts.Text.Replace(",", ".") & "', inss_patronal = '" & TxtInss.Text.Replace(",", ".") & "', vale_ref_alim = '" & TxtVrVa.Text.Replace(",", ".") & "'," _
                & " vale_transporte= '" & TxtVt.Text.Replace(",", ".") & "', plano_saude= '" & TxtSaude.Text.Replace(",", ".") & "', plano_odonto= '" & TxtOdonto.Text.Replace(",", ".") & "', previdencia= '" & TxtPrev.Text.Replace(",", ".") & "'," _
                & " plr = '" & TxtPlr.Text.Replace(",", ".") & "' , outros = '" & TxtOutros.Text.Replace(",", ".") & "' , descricao_outros = '" & TxtDescricao.Text & "' WHERE id =  '" & TxtCod.Text & "' "
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
    Sub Limpar_campos()
        TxtCod.Text = ""
        TxtIdFunc.Text = ""
        TxtFuncionario.Text = ""
        TxtSalario.Text = ""
        TxtSalarioFamilia.Text = ""
        Txt13Salario.Text = ""
        TxtFerias.Text = ""
        TxtFgts.Text = ""
        TxtInss.Text = ""
        TxtVrVa.Text = ""
        TxtVt.Text = ""
        TxtOdonto.Text = ""
        TxtSaude.Text = ""
        TxtPrev.Text = ""
        TxtPlr.Text = ""
        TxtOutros.Text = ""
        TxtDescricao.Text = ""

    End Sub

    Sub Campos_vazio()

        If TxtSalario.Text = "" Then
            Dim dbl3 As Double = 0
            Double.TryParse(TxtSalario.Text, dbl3)
            TxtSalario.Text = dbl3
        End If

        If TxtSalarioFamilia.Text = "" Then
            Dim dbl3 As Double = 0
            Double.TryParse(TxtSalarioFamilia.Text, dbl3)
            TxtSalarioFamilia.Text = dbl3
        End If

        If Txt13Salario.Text = "" Then
            Dim dbl3 As Double = 0
            Double.TryParse(Txt13Salario.Text, dbl3)
            Txt13Salario.Text = dbl3
        End If

        If TxtFerias.Text = "" Then
            Dim dbl3 As Double = 0
            Double.TryParse(TxtFerias.Text, dbl3)
            TxtFerias.Text = dbl3
        End If

        If TxtFgts.Text = "" Then
            Dim dbl3 As Double = 0
            Double.TryParse(TxtFgts.Text, dbl3)
            TxtFgts.Text = dbl3
        End If

        If TxtInss.Text = "" Then
            Dim dbl3 As Double = 0
            Double.TryParse(TxtInss.Text, dbl3)
            TxtInss.Text = dbl3
        End If

        If TxtVrVa.Text = "" Then
            Dim dbl3 As Double = 0
            Double.TryParse(TxtVrVa.Text, dbl3)
            TxtVrVa.Text = dbl3
        End If

        If TxtVt.Text = "" Then
            Dim dbl3 As Double = 0
            Double.TryParse(TxtVt.Text, dbl3)
            TxtVt.Text = dbl3
        End If

        If TxtOdonto.Text = "" Then
            Dim dbl3 As Double = 0
            Double.TryParse(TxtOdonto.Text, dbl3)
            TxtOdonto.Text = dbl3
        End If

        If TxtSaude.Text = "" Then
            Dim dbl3 As Double = 0
            Double.TryParse(TxtSaude.Text, dbl3)
            TxtSaude.Text = dbl3
        End If
        If TxtPrev.Text = "" Then
            Dim dbl3 As Double = 0
            Double.TryParse(TxtPrev.Text, dbl3)
            TxtPrev.Text = dbl3
        End If
        If TxtPlr.Text = "" Then
            Dim dbl3 As Double = 0
            Double.TryParse(TxtPlr.Text, dbl3)
            TxtPlr.Text = dbl3
        End If
        If TxtOutros.Text = "" Then
            Dim dbl3 As Double = 0
            Double.TryParse(TxtOutros.Text, dbl3)
            TxtOutros.Text = dbl3
        End If

    End Sub
    Private Sub Salvar_Gastos()
        If TxtFuncionario.Text <> "" Then
            'Stop
            Try
                'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO
                TxtFuncionario.BackColor = Color.White

                Abrir()

                'VALIDANDO SE JA EXITE GASTO CADASTRADO PARA FUNCIONARIO 

                Dim cmd3 As MySqlCommand
                Dim reader3 As MySqlDataReader
                Dim sql3 As String

                sql3 = "SELECT id_funcionario FROM tbl_cad_gastosfunc WHERE id_funcionario = '" & TxtIdFunc.Text & "' "
                cmd3 = New MySqlCommand(sql3, con)
                reader3 = cmd3.ExecuteReader
                If reader3.Read = True Then
                    MsgBox("Gastos já cadastrados para esse funcionário!!", MsgBoxStyle.Information, "Gastos Funcionário")

                    reader3.Close()
                    Exit Sub

                Else
                    reader3.Close()
                End If

                '//VALIDAÇÃO DOS CAMPOS ZERADOS
                Campos_vazio()

                Dim cmd As MySqlCommand
                Dim sqls As String
                Dim data As String
                Dim situacao As String = ""


                data = Now().ToString("yyyy-MM-dd")

                sqls = "INSERT INTO tbl_cad_gastosfunc ( id_funcionario, id_funcao, salario_base, salario_familia, 13_salario, ferias, fgts, inss_patronal," _
                    & "vale_ref_alim, vale_transporte, plano_saude, plano_odonto, previdencia, plr, outros, descricao_outros, data_inclusao) " _
                    & "VALUES ('" & TxtIdFunc.Text & "','" & TxtIdFuncao.Text & "', '" & TxtSalario.Text.Replace(",", ".") & "', '" & TxtSalarioFamilia.Text.Replace(",", ".") & "', '" & Txt13Salario.Text.Replace(",", ".") & "'," _
                    & " '" & TxtFerias.Text.Replace(",", ".") & "', '" & TxtFgts.Text.Replace(",", ".") & "', '" & TxtInss.Text.Replace(",", ".") & "', '" & TxtVrVa.Text.Replace(",", ".") & "'," _
                    & " '" & TxtVt.Text.Replace(",", ".") & "', '" & TxtOdonto.Text.Replace(",", ".") & "', '" & TxtSaude.Text.Replace(",", ".") & "', '" & TxtPrev.Text.Replace(",", ".") & "'," _
                    & " '" & TxtPlr.Text.Replace(",", ".") & "', '" & TxtOutros.Text.Replace(",", ".") & "', '" & TxtDescricao.Text & "', '" & data & "')"

                cmd = New MySqlCommand(sqls, con)
                cmd.ExecuteNonQuery()

                Limpar_campos()

                MsgBox("Cadastro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar")

                Me.Close()
                Exit Sub
            Catch ex As Exception
                MessageBox.Show("Erro:" & ex.Message)
            End Try

        Else

            TxtFuncionario.BackColor = Color.Salmon
            MsgBox("Campos vazios!!", MsgBoxStyle.Information, "Dados inválidos")
            TxtFuncionario.Focus()

        End If
    End Sub

    Private Sub Frm_cad_addGastosFunc_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        If PesqFunc = "True" Then

            TxtIdFunc.Text = IdFunc
            TxtFuncionario.Text = NomeFunc
            TxtIdFuncao.Text = IdFuncaoFunc
            TxtFuncao.Text = FuncaoFunc

        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click, BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Salvar()
    End Sub

    Private Sub Frm_cad_addGastosFunc_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        PesqFunc = ""
    End Sub

    Private Sub TxtFuncionario_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFuncionario.KeyDown

        If e.KeyCode = Keys.F5 Then
            FrmPesqFunc = "True"
            Dim frm As New Frm_cad_funcionarios
            frm.ShowDialog()
        End If
    End Sub

    Private Sub TxtSalario_TextChanged(sender As Object, e As EventArgs) Handles TxtSalario.TextChanged
        If CboxAutomatico.Checked = True Then

            Dim dbl1 As Double = 0
            Double.TryParse(TxtSalario.Text, dbl1)

            Txt13Salario.Text = (dbl1 * 0.10667) '.ToString("n")
            TxtFerias.Text = (dbl1 * 0.14222) '.ToString("n")
            TxtFgts.Text = (dbl1 * 0.08) '.ToString("n")
            TxtInss.Text = (dbl1 * 0.2) '.ToString("n")

        End If

    End Sub

    Private Sub CboxAutomatico_CheckedChanged(sender As Object, e As EventArgs) Handles CboxAutomatico.CheckedChanged
        Dim dbl1 As Double = 0
        Double.TryParse(TxtSalario.Text, dbl1)


        Txt13Salario.Text = (dbl1 * 0.10667) '.ToString("n")
        TxtFerias.Text = (dbl1 * 0.14222) '.ToString("n")
        TxtFgts.Text = (dbl1 * 0.08) '.ToString("n")
        TxtInss.Text = (dbl1 * 0.2) '.ToString("n")

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