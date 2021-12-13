Imports _2_Cadastros
Imports _3_Estoque
Imports _5_Vendas

Public Class Frm_main
    Private Sub Frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Top = (Me.Height / 2) - (PictureBox1.Height / 2)
        PictureBox1.Left = (Me.Width / 2) - (PictureBox1.Width / 2)

    End Sub

    Private Sub LogoffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoffToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Frm_main_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        PictureBox1.Top = (Me.Height / 2) - (PictureBox1.Height / 2)
        PictureBox1.Left = (Me.Width / 2) - (PictureBox1.Width / 2)
    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem.Click
        Dim frm As New Frm_cad_fornecedores
        frm.ShowDialog()

    End Sub

    Private Sub CategoriaDeProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriaDeProdutosToolStripMenuItem.Click
        Dim frm As New Frm_cad_categorias
        frm.ShowDialog()
    End Sub

    Private Sub CadastrarMarcasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarMarcasToolStripMenuItem.Click
        Dim frm As New Frm_cad_marca
        frm.ShowDialog()
    End Sub

    Private Sub PreçoVendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreçoVendaToolStripMenuItem.Click
        Dim frm As New Frm_cad_precoVenda
        frm.ShowDialog()
    End Sub

    Private Sub PromoçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromoçãoToolStripMenuItem.Click

        Dim frm As New Frm_cad_promocao
        frm.ShowDialog()
    End Sub

    Private Sub ProdutosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem1.Click
        Dim frm As New Frm_cad_produtos
        frm.ShowDialog()
    End Sub

    Private Sub CadastrarFuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarFuncionáriosToolStripMenuItem.Click
        Dim frm As New Frm_cad_funcionarios
        frm.ShowDialog()
    End Sub

    Private Sub CadastrarFunçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarFunçõesToolStripMenuItem.Click
        Dim frm As New Frm_cad_funcoes
        frm.ShowDialog()
    End Sub

    Private Sub LocalizaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalizaçãoToolStripMenuItem.Click
        Dim frm As New Frm_cad_local
        frm.ShowDialog()
    End Sub

    Private Sub ReajustarPreçoVendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReajustarPreçoVendaToolStripMenuItem.Click
        Dim frm As New Frm_ven_rejaustePreco
        frm.ShowDialog()
    End Sub

    Private Sub UsuárioSenhaToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles UsuárioSenhaToolStripMenuItem.Click
        Dim frm As New Frm_cad_usuarios
        frm.ShowDialog()
    End Sub

    Private Sub GastosComFuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GastosComFuncionáriosToolStripMenuItem.Click
        Dim frm As New Frm_cad_gastosFunc
        frm.ShowDialog()
    End Sub

    Private Sub CadastrarEmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarEmpresaToolStripMenuItem.Click
        Dim frm As New Frm_cad_empresa
        frm.ShowDialog()
    End Sub

    Private Sub CadastroDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeClientesToolStripMenuItem.Click
        Dim frm As New Frm_cad_clientes
        frm.ShowDialog()
    End Sub

    Private Sub LimiteDeDébitosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimiteDeDébitosToolStripMenuItem.Click
        Dim frm As New Frm_ven_limiteDebito
        frm.ShowDialog()
    End Sub

    Private Sub TiposDeGastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeGastosToolStripMenuItem.Click
        Dim frm As New Frm_cad_tiposGastos
        frm.ShowDialog()
    End Sub

    Private Sub FormasDePagamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormasDePagamentoToolStripMenuItem.Click
        Dim frm As New Frm_cad_formasPgto
        frm.ShowDialog()
    End Sub

    Private Sub PortadoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PortadoresToolStripMenuItem.Click
        Dim frm As New Frm_cad_portadores
        frm.ShowDialog()
    End Sub

    Private Sub EntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasToolStripMenuItem.Click

        Dim frm As New Frm_est_entrada
        frm.Stringpass = TxtUsuario.Text
        frm.ShowDialog()
    End Sub

    Private Sub TesteToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Dim frm As New Frm_cad_consultaProdutos
        frm.ShowDialog()
    End Sub

    Private Sub UnidadeMedidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnidadeMedidaToolStripMenuItem.Click
        Dim frm As New Frm_cad_undmedidas
        frm.ShowDialog()
    End Sub

    Private Sub SaídasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaídasToolStripMenuItem.Click
        Dim frm As New Frm_est_saida
        frm.Stringpass = TxtUsuario.Text
        frm.ShowDialog()
    End Sub
End Class
