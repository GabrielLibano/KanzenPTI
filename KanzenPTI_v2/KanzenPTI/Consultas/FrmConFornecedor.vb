Public Class FrmConFornecedor
    Dim objfor As New ClsFornecedor

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub

    Private Sub FrmConCliente_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        DgdGrade.DataSource = objfor.Localizar(TxtCampo.Text)
    End Sub

    Private Sub DgdGrade_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentDoubleClick

        If MdiParent Is FrmMenu Then
            FrmCadFornecedor.Show()
            FrmCadFornecedor.txtCod.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmCadFornecedor.txtNom.Text = DgdGrade.CurrentRow.Cells(1).Value
            FrmCadFornecedor.mskCNPJ.Text = DgdGrade.CurrentRow.Cells(2).Value
            FrmCadFornecedor.mskInsc.Text = DgdGrade.CurrentRow.Cells(3).Value
            FrmCadFornecedor.txtEnd.Text = DgdGrade.CurrentRow.Cells(4).Value
            FrmCadFornecedor.txtnum.Text = DgdGrade.CurrentRow.Cells(5).Value
            FrmCadFornecedor.txtCom.Text = DgdGrade.CurrentRow.Cells(6).Value
            FrmCadFornecedor.mskCEP.Text = DgdGrade.CurrentRow.Cells(7).Value
            FrmCadFornecedor.txtBai.Text = DgdGrade.CurrentRow.Cells(8).Value
            FrmCadFornecedor.txtcid.Text = DgdGrade.CurrentRow.Cells(9).Value
            FrmCadFornecedor.txtEst.Text = DgdGrade.CurrentRow.Cells(10).Value
            FrmCadFornecedor.mskTel.Text = DgdGrade.CurrentRow.Cells(11).Value
            FrmCadFornecedor.txtNomCont.Text = DgdGrade.CurrentRow.Cells(12).Value

            Me.Close()
        End If

    End Sub
End Class