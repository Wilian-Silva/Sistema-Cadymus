<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_est_ImprimirLista
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.query_lista_inventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_lista_invetario = New _3_Estoque.DataSet_lista_invetario()
        Me.query_lista_inventarioTableAdapter = New _3_Estoque.DataSet_lista_invetarioTableAdapters.query_lista_inventarioTableAdapter()
        Me.DataSet_lista_invetario1 = New _3_Estoque.DataSet_lista_invetario()
        Me.QuerycabecalhoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Query_cabecalhoTableAdapter = New _3_Estoque.DataSet_lista_invetarioTableAdapters.query_cabecalhoTableAdapter()
        CType(Me.query_lista_inventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_lista_invetario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_lista_invetario1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuerycabecalhoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet_inventario"
        ReportDataSource1.Value = Me.query_lista_inventarioBindingSource
        ReportDataSource2.Name = "titulo"
        ReportDataSource2.Value = Me.QuerycabecalhoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "_3_Estoque.Report_est_listaInvent.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(863, 664)
        Me.ReportViewer1.TabIndex = 0
        '
        'query_lista_inventarioBindingSource
        '
        Me.query_lista_inventarioBindingSource.DataMember = "query_lista_inventario"
        Me.query_lista_inventarioBindingSource.DataSource = Me.DataSet_lista_invetario
        '
        'DataSet_lista_invetario
        '
        Me.DataSet_lista_invetario.DataSetName = "DataSet_lista_invetario"
        Me.DataSet_lista_invetario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'query_lista_inventarioTableAdapter
        '
        Me.query_lista_inventarioTableAdapter.ClearBeforeFill = True
        '
        'DataSet_lista_invetario1
        '
        Me.DataSet_lista_invetario1.DataSetName = "DataSet_lista_invetario"
        Me.DataSet_lista_invetario1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QuerycabecalhoBindingSource
        '
        Me.QuerycabecalhoBindingSource.DataMember = "query_cabecalho"
        Me.QuerycabecalhoBindingSource.DataSource = Me.DataSet_lista_invetario1
        '
        'Query_cabecalhoTableAdapter
        '
        Me.Query_cabecalhoTableAdapter.ClearBeforeFill = True
        '
        'Frm_est_ImprimirLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 664)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MinimizeBox = False
        Me.Name = "Frm_est_ImprimirLista"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista contagem de inventário"
        CType(Me.query_lista_inventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_lista_invetario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_lista_invetario1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuerycabecalhoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents query_lista_inventarioBindingSource As BindingSource
    Friend WithEvents DataSet_lista_invetario As DataSet_lista_invetario
    Friend WithEvents query_lista_inventarioTableAdapter As DataSet_lista_invetarioTableAdapters.query_lista_inventarioTableAdapter
    Friend WithEvents DataSet_lista_invetario1 As DataSet_lista_invetario
    Friend WithEvents QuerycabecalhoBindingSource As BindingSource
    Friend WithEvents Query_cabecalhoTableAdapter As DataSet_lista_invetarioTableAdapters.query_cabecalhoTableAdapter
End Class
