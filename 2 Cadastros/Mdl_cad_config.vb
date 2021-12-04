Imports MySql.Data.MySqlClient

Module Mdl_cad_config

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



    '//VARIÁVEIS UNIVERSAIS UTILIZADAS NO PROJETO

    '//Variáveis utilizadas no cadastro de proudutos
    Public PesqFornec As String
    Public IdFornec As String
    Public NomeFornec As String
    Public PesqCategoria As String
    Public PesqMarca As String


    Public Categoria As String
    Public IdCategoria As String
    Public Marca As String
    Public IdMarca As String
    Public Local As String
    Public IdLocal As String


    Public PesqFuncao As String
    Public Funcao As String
    Public PesqLocal As String



    '//Variáveis utilizadas na atualizaçao do preço de venda
    Public PesqProd As String
    Public IdProd As String
    Public NomeProd As String
    Public PrecoVenda As String
    Public PrecoCusto As String
    Public Markup As String
    Public PesProdTelaProd As String



    '//Variáveis utilizadas no cadastro de usuário
    Public PesqFunc As String
    Public IdFunc As String
    Public NomeFunc As String
    Public IdFuncaoFunc As String
    Public FuncaoFunc As String
    Public FrmPesqFunc As String
    Public EditarUsuario As String

    '//variavel utilizada no cadastro empresa
    Public editarEmpresa As String
    Public incluirEmpresa As String


    '//varivel utilizada para o frm tipo de gasto
    Public PesqTipoGasto As String
    Public IdTipoGasto As String
    Public TipoGasto As String

    '//varivel utilizada para o frm tipo de pagamento
    Public PesqTipoPgto As String
    Public IdTipoPgto As String
    Public TipoPgto As String

    '//varivel utilizada para os portadores
    Public PesqPortador As String
    Public IdPortador As String
    Public Portador As String
End Module
