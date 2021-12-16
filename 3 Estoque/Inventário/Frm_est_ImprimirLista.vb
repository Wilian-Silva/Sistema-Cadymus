Public Class Frm_est_ImprimirLista
    Private Sub Frm_est_listaInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DataSet_lista_invetario1.query_cabecalho'. Você pode movê-la ou removê-la conforme necessário.
        Me.Query_cabecalhoTableAdapter.Fill(Me.DataSet_lista_invetario1.query_cabecalho)


        'TODO: esta linha de código carrega dados na tabela 'DataSet_lista_invetario.query_lista_inventario'. Você pode movê-la ou removê-la conforme necessário.
        Me.query_lista_inventarioTableAdapter.Fill(Me.DataSet_lista_invetario.query_lista_inventario)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class