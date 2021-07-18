Public Class FrmMenu

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        FrmCadCliente.MdiParent = Me
        FrmCadCliente.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        If MessageBox.Show("Deseja mesmo sair", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem.Click
        FrmCadFornecedor.MdiParent = Me
        FrmCadFornecedor.Show()
    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        FrmCadFuncionario.MdiParent = Me
        FrmCadFuncionario.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem1.Click
        FrmConClientes.MdiParent = Me
        FrmConClientes.Show()
    End Sub

    Private Sub FuncionáriosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FuncionáriosToolStripMenuItem1.Click
        FrmConFuncionarios.MdiParent = Me
        FrmConFuncionarios.Show()
    End Sub

    Private Sub FornecedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem1.Click
        FrmConFornecedor.MdiParent = Me
        FrmConFornecedor.Show()
    End Sub
End Class
