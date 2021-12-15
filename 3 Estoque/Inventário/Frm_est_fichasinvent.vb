
Imports MySql.Data.MySqlClient

Public Class Frm_est_fichasinvent
    Dim listNumber As Integer = 0
    Dim listName As String

    Public Property StringCateg As String

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
    Private Sub Apenas_Numeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtIdLocalInicial.KeyPress, TxtIdLocalFinal.KeyPress, TxtIdCodInicial.KeyPress, TxtIdCodFinal.KeyPress, TxtIdCategoriaInicial.KeyPress, TxtIdCategoriaFinal.KeyPress
        Permitir_Numeros(sender, e)
    End Sub

    Private Sub Form_Close(sender As Object, e As EventArgs) Handles BtnClose.Click, BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub Frm_est_fichasinvent_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click

        If MsgBox("Deseja gerar lista de inventário?", vbYesNo, "Lista de Inventário") = vbYes Then
            GerarIdLista()
        End If

    End Sub

    Sub GerarIdLista()

        Dim countlist As Integer
        Try
            Abrir()

            'VERIFICAR ULTIMO ID NO BANCO E GERAR PROXIMO
            Dim cmd As MySqlCommand
            Dim sql As String
            Dim reader As MySqlDataReader

            sql = "SELECT COUNT(id_lista) AS id_lista, MAX(id_lista) as n_Id_lista FROM tbl_est_inventario "
            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader
            reader.Read()
            If Not IsDBNull(reader("id_lista")) And Not IsDBNull(reader("n_Id_lista")) Then
                countlist = reader("id_lista")
                listNumber = reader("n_Id_lista")
                reader.Close()
            Else
                countlist = 0
                listNumber = 0
                reader.Close()
            End If

            If countlist > 0 Then
                If MsgBox("Já existe uma lista de inventário criada, deseja excluí-la para prosseguir!", vbYesNo, "Lista de Inventário") = vbYes Then

                    Dim cmd2 As MySqlCommand
                    Dim sql2 As String
                    sql2 = "TRUNCATE  tbl_est_inventario "
                    cmd2 = New MySqlCommand(sql2, con)
                    cmd2.ExecuteNonQuery()

                    listNumber += 1
                    listName = "Inventário - Data: " & DataInv.Text
                    Gerar_tblListaInvetario()
                Else
                    Exit Sub
                End If
            Else
                listNumber += 1
                listName = "Inventário - Data: " & DataInv.Text
                Gerar_tblListaInvetario()
            End If

        Catch ex As Exception
            MsgBox("Erro GerarIdRegistro! " + ex.Message)
        End Try
    End Sub

    Sub Gerar_tblListaInvetario()


        Try
            Abrir()

            Dim cmd1 As MySqlCommand
            Dim sql1 As String

            If CboxSaldoZero.Checked = True Then

                sql1 = "INSERT INTO tbl_est_inventario (id_produto, id_categoria, id_marca, id_local, id_undmedida, saldo_estoque, controle_estoque, status) " _
                & " SELECT id, id_categoria, id_marca, id_local, id_undmedida, saldo, controle_estoque, status FROM tbl_cad_produtos " _
                & " WHERE id BETWEEN  '" & TxtIdCodInicial.Text & "' AND '" & TxtIdCodFinal.Text & "' AND " _
                & " id_categoria BETWEEN  '" & TxtIdCategoriaInicial.Text & "' AND '" & TxtIdCategoriaFinal.Text & "' AND " _
                & " id_local BETWEEN  '" & TxtIdLocalInicial.Text & "' AND '" & TxtIdLocalFinal.Text & "' "

            Else
                sql1 = "INSERT INTO tbl_est_inventario (id_produto, id_categoria, id_marca, id_local, id_undmedida, saldo_estoque, controle_estoque, status) " _
                 & " SELECT id, id_categoria, id_marca, id_local, id_undmedida, saldo, controle_estoque, status FROM tbl_cad_produtos " _
                 & " WHERE id BETWEEN  '" & TxtIdCodInicial.Text & "' AND '" & TxtIdCodFinal.Text & "' AND " _
                 & " id_categoria BETWEEN  '" & TxtIdCategoriaInicial.Text & "' AND '" & TxtIdCategoriaFinal.Text & "' AND " _
                 & " id_local BETWEEN  '" & TxtIdLocalInicial.Text & "' AND '" & TxtIdLocalFinal.Text & "'AND saldo > 0  "
            End If

            cmd1 = New MySqlCommand(sql1, con)
            cmd1.ExecuteNonQuery()

            Dim data As String
            data = DataInv.Value.ToString("yyyy-MM-dd")

            ''\\INSERINDO INFORMAÇÕES GERAIS
            Dim cmd As MySqlCommand
            Dim sql As String
            sql = "UPDATE tbl_est_inventario SET id_lista='" & listNumber & "', descricao='" & listName & "', data_inventario='" & data & "' "
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()

            MsgBox("Lista de inventário criada com sucesso!", MsgBoxStyle.Information, "Lista de Inventário")
        Catch ex As Exception
            MsgBox("Erro ao Copiar_Produtos-- " + ex.Message)
        End Try

    End Sub
    Private Sub BtnItemInic_Click(sender As Object, e As EventArgs) Handles BtnItemInic.Click
        Dim frm As New Frm_est_consultaProdutos
        PesqProd = "True"
        IdItemIncial = "True"
        frm.ShowDialog()
    End Sub

    Private Sub BtnItemFim_Click(sender As Object, e As EventArgs) Handles BtnItemFim.Click
        Dim frm As New Frm_est_consultaProdutos
        PesqProd = "True"
        IdItemFinal = "True"
        frm.ShowDialog()
    End Sub

    Private Sub Frm_est_fichasinvent_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If IdItemIncial = "True" Then
            TxtIdCodInicial.Text = IdProd
            IdItemIncial = ""
            PesqProd = ""
        End If

        If IdItemFinal = "True" Then
            TxtIdCodFinal.Text = IdProd
            IdItemFinal = ""
            PesqProd = ""
        End If

        If IdCategIncial = "True" Then
            TxtIdCategoriaInicial.Text = IdCategoria
            IdCategIncial = ""
            PesqCateg = ""
        End If

        If IdCategFinal = "True" Then
            TxtIdCategoriaFinal.Text = IdCategoria
            IdCategFinal = ""
            PesqCateg = ""
        End If

        If IdLocalIncial = "True" Then
            TxtIdLocalInicial.Text = IdLocal
            IdLocalIncial = ""
            PesqLocal = ""
        End If

        If IdLocalFinal = "True" Then
            TxtIdLocalFinal.Text = IdLocal
            IdLocalFinal = ""
            PesqLocal = ""
        End If
    End Sub

    Private Sub BtnCategInicial_Click(sender As Object, e As EventArgs) Handles BtnCategInicial.Click
        Dim frm As New Frm_est_consultaCategorias
        PesqCateg = "True"
        IdCategIncial = "True"
        frm.ShowDialog()
    End Sub

    Private Sub BtnCategFinal_Click(sender As Object, e As EventArgs) Handles BtnCategFinal.Click
        Dim frm As New Frm_est_consultaCategorias
        PesqCateg = "True"
        IdCategFinal = "True"
        frm.ShowDialog()
    End Sub

    Private Sub BtnLocalIncial_Click(sender As Object, e As EventArgs) Handles BtnLocalIncial.Click
        Dim frm As New Frm_est_consultaLocal
        PesqLocal = "True"
        IdLocalIncial = "True"
        frm.ShowDialog()
    End Sub

    Private Sub BtnLocalFinal_Click(sender As Object, e As EventArgs) Handles BtnLocalFinal.Click
        Dim frm As New Frm_est_consultaLocal
        PesqLocal = "True"
        IdLocalFinal = "True"
        frm.ShowDialog()
    End Sub
End Class