Public Class Frm_est_digitarLista
    Private Sub BtnMax_Click(sender As Object, e As EventArgs) Handles BtnMax.Click
        Me.WindowState = FormWindowState.Maximized
        BtnMax.Visible = False
        BtnNormal.Visible = True
    End Sub

    Private Sub BtnNormal_Click(sender As Object, e As EventArgs) Handles BtnNormal.Click
        Me.WindowState = FormWindowState.Normal
        BtnMax.Visible = True
        BtnNormal.Visible = False
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub


End Class