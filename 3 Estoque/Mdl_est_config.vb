Imports MySql.Data.MySqlClient

Module Mdl_est_config

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

    '//FUÇÕES UTILIZADAS NO PROJETO
    Public Sub Permitir_Numeros(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 44 Then
            e.Handled = True
        End If
    End Sub
    Public Function CorTxtBox(nomeCampo As Control, codCor As String)

        If codCor = "Am" Then
            nomeCampo.BackColor = Color.FromArgb(255, 255, 185) 'AMARELO MAIS CLARO
            ' nomeCampo.BackColor = Color.FromArgb(255, 238, 168)
            nomeCampo.ForeColor = Color.FromArgb(11, 84, 119)
            nomeCampo.Font = New Font(nomeCampo.Font, FontStyle.Bold)

        ElseIf codCor = "Br" Then
            'nomeCampo.BackColor = Color.FromArgb(236, 239, 246) 'COR FUNDO FORM
            nomeCampo.BackColor = Color.White
            nomeCampo.ForeColor = Color.FromArgb(65, 65, 65)
            nomeCampo.Font = New Font(nomeCampo.Font, FontStyle.Regular)
        Else
            nomeCampo.BackColor = Color.White
            'nomeCampo.BackColor = Color.FromArgb(236, 239, 246) 'COR FUNDO FORM
            nomeCampo.ForeColor = Color.FromArgb(65, 65, 65)
        End If

#Disable Warning BC42105 ' A função não retorna um valor em todos os caminhos de código
    End Function
#Enable Warning BC42105 ' A função não retorna um valor em todos os caminhos de código

    Public PesqProd As String
    Public IdProd As String
    Public NomeProd As String
    Public PrecoVenda As String
    Public PrecoCusto As String
    Public Markup As String

End Module
