Imports MySql.Data.MySqlClient

Public Class Frm_cad_addPortadores
    Private Sub Frm_cad_addPortadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtPortador.Focus()
        TxtPortador.Select()
    End Sub
    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Salvar()

    End Sub

    Sub Salvar()
        If TxtCod.Text = "" Then
            If MsgBox("Deseja salvar registro? ", vbYesNo, "Salvar") = vbYes Then
                Salvar_Cad_Portador()
                Exit Sub
            Else
                Exit Sub
            End If

        End If

        If TxtCod.Text > 0 Then
            If MsgBox("Deseja salvar edição? ", vbYesNo, "Editar") = vbYes Then
                Editar_Cad_Portador()
                Exit Sub
            Else
                Exit Sub
            End If
        End If
    End Sub
    Sub Limpar_campos()
        TxtPortador.Text = ""
        TxtDescricao.Text = ""

    End Sub
    Private Sub Editar_Cad_Portador()
        Try
            Abrir()
            Dim cmd As MySqlCommand
            Dim sqls As String

            sqls = "UPDATE tbl_cad_portadores SET portador ='" & TxtPortador.Text & "' , descricao = '" & TxtDescricao.Text & "' WHERE id = '" & TxtCod.Text & "'"

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

    Private Sub Salvar_Cad_Portador()
        If TxtPortador.Text <> "" Then

            Try
                'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO
                TxtPortador.BackColor = Color.White
                Abrir()
                Dim cmd As MySqlCommand
                Dim sqls As String

                Dim data As String
                data = Now().ToString("yyyy-MM-dd")

                sqls = "INSERT INTO tbl_cad_portadores (portador, data_inclusao, descricao ) VALUES ('" & TxtPortador.Text & "', '" & data & "', '" & TxtDescricao.Text & "')"

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
            TxtPortador.BackColor = Color.Salmon
            MsgBox("Campos vazios!!", MsgBoxStyle.Information, "Dados inválidos")
            TxtPortador.Focus()

        End If
    End Sub

    Private Sub TxtCategoria_Enter(sender As Object, e As EventArgs) Handles TxtPortador.Enter
        CorTxtBox(TxtPortador, "Am")
    End Sub

    Private Sub TxtCategoria_Leave(sender As Object, e As EventArgs) Handles TxtPortador.Leave
        CorTxtBox(TxtPortador, "Br")
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

        If e.KeyCode = Keys.Enter Then
            Salvar()
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click, BtnClose.Click
        Me.Close()
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