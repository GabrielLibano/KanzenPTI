Public Class FrmConFuncionarios
    Dim objfun As New ClsFuncionario

    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        DgdGrade.DataSource = objfun.Localizar(TxtCampo.Text)
    End Sub

    Private Sub FrmConCliente_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub

    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick

        If MdiParent Is FrmMenu Then
            FrmCadFuncionario.Show()
            FrmCadFuncionario.txtCod.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmCadFuncionario.txtNom.Text = DgdGrade.CurrentRow.Cells(1).Value
            FrmCadFuncionario.mskRG.Text = DgdGrade.CurrentRow.Cells(2).Value
            FrmCadFuncionario.mskCPF.Text = DgdGrade.CurrentRow.Cells(3).Value
            FrmCadFuncionario.txtEnd.Text = DgdGrade.CurrentRow.Cells(4).Value
            FrmCadFuncionario.txtnum.Text = DgdGrade.CurrentRow.Cells(5).Value
            FrmCadFuncionario.txtCom.Text = DgdGrade.CurrentRow.Cells(6).Value
            FrmCadFuncionario.txtBai.Text = DgdGrade.CurrentRow.Cells(7).Value
            FrmCadFuncionario.txtcid.Text = DgdGrade.CurrentRow.Cells(8).Value
            FrmCadFuncionario.txtEst.Text = DgdGrade.CurrentRow.Cells(9).Value
            FrmCadFuncionario.mskCEP.Text = DgdGrade.CurrentRow.Cells(10).Value
            FrmCadFuncionario.mskTel.Text = DgdGrade.CurrentRow.Cells(11).Value
            FrmCadFuncionario.dtpDat.Text = DgdGrade.CurrentRow.Cells(12).Value
            FrmCadFuncionario.chkatv.Text = DgdGrade.CurrentRow.Cells(13).Value

            Me.Close()
        End If

    End Sub

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

    End Sub
End Class