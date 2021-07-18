Public Class FrmConClientes
    Dim objcli As New ClsCliente

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub

    Private Sub FrmConCliente_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        DgdGrade.DataSource = objcli.Localizar(TxtCampo.Text)
    End Sub

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

    End Sub

    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick

        If MdiParent Is FrmMenu Then
            FrmCadCliente.Show()
            FrmCadCliente.txtCod.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmCadCliente.txtNom.Text = DgdGrade.CurrentRow.Cells(1).Value
            FrmCadCliente.mskCel.Text = DgdGrade.CurrentRow.Cells(2).Value
            FrmCadCliente.txtEnd.Text = DgdGrade.CurrentRow.Cells(3).Value
            FrmCadCliente.txtCom.Text = DgdGrade.CurrentRow.Cells(4).Value
            FrmCadCliente.txtBai.Text = DgdGrade.CurrentRow.Cells(5).Value
            FrmCadCliente.mskCEP.Text = DgdGrade.CurrentRow.Cells(6).Value
            FrmCadCliente.txtcid.Text = DgdGrade.CurrentRow.Cells(7).Value
            FrmCadCliente.txtEst.Text = DgdGrade.CurrentRow.Cells(8).Value
            FrmCadCliente.txtEma.Text = DgdGrade.CurrentRow.Cells(9).Value
            FrmCadCliente.mskCPF.Text = DgdGrade.CurrentRow.Cells(10).Value
            FrmCadCliente.dtpDat.Text = DgdGrade.CurrentRow.Cells(11).Value
            FrmCadCliente.chkPJ.Text = DgdGrade.CurrentRow.Cells(12).Value

            Me.Close()
        End If

    End Sub


    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class