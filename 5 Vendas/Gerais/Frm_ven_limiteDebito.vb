Imports MySql.Data.MySqlClient

Public Class Frm_ven_limiteDebito
    Private Sub Frm_ven_limiteDebito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsutlarLimiteDebito()
        TxtLimiteDebito.Select()
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click

        Try
            Abrir()
            Dim cmd As MySqlCommand
            Dim sqls As String
            Dim data As String

            data = Now().ToString("yyyy-MM-dd")

            sqls = "INSERT INTO tbl_limite_debito (data_inclusao, limite_debito) VALUES ( '" & data & "', '" & TxtLimiteDebito.Text.Replace(",", ".") & "')"
            cmd = New MySqlCommand(sqls, con)
            cmd.ExecuteNonQuery()


            '//ATUALIZANDO OS CADASTROS DOS CLIENTES
            Dim cmd1 As MySqlCommand
            Dim sqls1 As String


            sqls1 = "UPDATE tbl_cad_clientes SET limite_debito = '" & TxtLimiteDebito.Text.Replace(",", ".") & "' WHERE tipo_debito = 1 "
            cmd1 = New MySqlCommand(sqls1, con)
            cmd1.ExecuteNonQuery()

            MsgBox("Cadastro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar")
            Me.Close()
        Catch ex As Exception

            MsgBox("Erro: ---- " + ex.Message)
        End Try

    End Sub

    Sub ConsutlarLimiteDebito()
        Try

            Abrir()
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql As String

            sql = "SELECT  MAX(limite_debito) as limite_debito FROM tbl_limite_debito "
            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader
            reader.Read()

            If Not IsDBNull(reader("limite_debito")) Then
                TxtLimiteDebito.Text = reader("limite_debito")
                reader.Close()
            Else
                TxtLimiteDebito.Text = 0
                reader.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Erro:" & ex.Message)
        End Try

    End Sub

    Private Sub Frm_cad_limiteDebito_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtLimiteDebito_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtLimiteDebito.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub TxtLimiteDebito_Enter(sender As Object, e As EventArgs) Handles TxtLimiteDebito.Enter
        CorTxtBox(TxtLimiteDebito, "Am")
    End Sub

    Private Sub TxtLimiteDebito_Leave(sender As Object, e As EventArgs) Handles TxtLimiteDebito.Leave
        CorTxtBox(TxtLimiteDebito, "Br")
    End Sub
End Class