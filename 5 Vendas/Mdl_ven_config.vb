Imports MySql.Data.MySqlClient
Module Mdl_ven_config
    '//STRING DE CONEXÃO COM O BANCO DE DADOS
    Public con As New MySqlConnection("server=localhost; userid=root; password=; database=sistema_pdv; port=; SslMode=none;")
    Sub Abrir()
        'Stop
        If con.State = 0 Then
            con.Open()
        End If

    End Sub

    Sub Fechar()
        If con.State = 1 Then
            con.Close()
        End If
    End Sub

    Public Sub Permitir_Numeros(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 44 Then
            e.Handled = True
        End If
    End Sub

    Public Function CorTxtBox(nomeCampo As Control, codCor As String)

        If codCor = "Am" Then
            nomeCampo.BackColor = Color.LightGoldenrodYellow
            nomeCampo.ForeColor = Color.RoyalBlue

        ElseIf codCor = "Br" Then
            nomeCampo.BackColor = Color.White
            nomeCampo.ForeColor = Color.Black
        Else
            nomeCampo.BackColor = Color.White
            nomeCampo.ForeColor = Color.Black
        End If

#Disable Warning BC42105 ' A função não retorna um valor em todos os caminhos de código
    End Function
#Enable Warning BC42105 ' A função não retorna um valor em todos os caminhos de código


End Module
