Public Class FrmCadFuncionario
    Dim objcontrole As New ClsControle
    Dim objfun As New ClsFuncionario
    Dim novo As Boolean
    Private Sub tsbNovo_Click(sender As Object, e As EventArgs) Handles tsbNovo.Click
        objcontrole.Limpar_tela(Me)
        objcontrole.Habilitar_tela(Me, True)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, False)
        txtCod.Enabled = False
        txtNom.Focus()
        novo = True
    End Sub

    Private Sub tsbGravar_Click(sender As Object, e As EventArgs) Handles tsbGravar.Click
        If objcontrole.Testar_vazio(Me) = False Then
            objfun.Codigo = Val(txtCod.Text)
            objfun.Nome = txtNom.Text
            objfun.RG = mskRG.Text
            objfun.CPF = mskCPF.Text
            objfun.Endereco = txtEnd.Text
            objfun.Numero = txtnum.Text
            objfun.Complemento = txtCom.Text
            objfun.Bairro = txtBai.Text
            objfun.Cidade = txtcid.Text
            objfun.Estado = txtEst.Text
            objfun.CEP = mskCEP.Text
            objfun.Telefone = mskTel.Text
            objfun.Data = dtpDat.Text
            objfun.Ativo = chkatv.Checked

            objfun.gravar(novo)
            txtCod.Text = objfun.Codigo
            tsbAlterar.Enabled = True
            tsbExcluir.Enabled = True
            objcontrole.Habilitar_tela(Me, False)
            objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, True)
        Else
            txtNom.Focus()
        End If
    End Sub

    Private Sub FrmCadFuncionario_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub FrmCadFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objcontrole.Limpar_tela(Me)
        objcontrole.Habilitar_tela(Me, False)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, True)
        tsbAlterar.Enabled = False
        tsbExcluir.Enabled = False
        grpLoc.Visible = False
    End Sub

    Private Sub tsbLocalizar_Click(sender As Object, e As EventArgs)
        tsbLocalizar.Enabled = False
        grpLoc.Visible = True
        tsbCancelar.Enabled = True
        txtLocalizar.Focus()
    End Sub

    Private Sub tsbAlterar_Click(sender As Object, e As EventArgs)
        objcontrole.Habilitar_tela(Me, True)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, False)
        txtCod.Enabled = False
        txtNom.Focus()
        novo = False
        tsbGravar.Enabled = True
    End Sub

    Private Sub tsbExcluir_Click(sender As Object, e As EventArgs)
        If objfun.excluir(txtCod.Text) Then
            objcontrole.Limpar_tela(Me)
            tsbExcluir.Enabled = False
            tsbAlterar.Enabled = False
        End If
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs)
        Call FrmCadFuncionario_Load(Nothing, Nothing)
    End Sub

    Private Sub tsbSair_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub tsbLocalizar_Click_1(sender As Object, e As EventArgs) Handles tsbLocalizar.Click
        tsbLocalizar.Enabled = False
        grpLoc.Visible = True
        tsbCancelar.Enabled = True
        txtLocalizar.Focus()
    End Sub

    Private Sub tsbAlterar_Click_1(sender As Object, e As EventArgs) Handles tsbAlterar.Click
        objcontrole.Habilitar_tela(Me, True)
        objcontrole.Habilitar_botoesEsp(Me.ToolStrip1, False)
        txtCod.Enabled = False
        txtNom.Focus()
        novo = False
        tsbGravar.Enabled = True
    End Sub

    Private Sub tsbExcluir_Click_1(sender As Object, e As EventArgs) Handles tsbExcluir.Click
        If objfun.excluir(txtCod.Text) Then
            objcontrole.Limpar_tela(Me)
            tsbExcluir.Enabled = False
            tsbAlterar.Enabled = False
        End If
    End Sub

    Private Sub tsbCancelar_Click_1(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Call FrmCadFuncionario_Load(Nothing, Nothing)
    End Sub

    Private Sub tsbSair_Click_1(sender As Object, e As EventArgs) Handles tsbSair.Click
        Me.Close()
    End Sub

    Private Sub mostrar_dadosDaClasse()
        txtCod.Text = objfun.Codigo
        txtNom.Text = objfun.Nome
        mskRG.Text = objfun.RG
        mskCPF.Text = objfun.CPF
        txtEnd.Text = objfun.Endereco
        txtnum.Text = objfun.Numero
        txtCom.Text = objfun.Complemento
        txtBai.Text = objfun.Bairro
        txtcid.Text = objfun.Cidade
        txtEst.Text = objfun.Estado
        mskCEP.Text = objfun.CEP
        mskTel.Text = objfun.Telefone
        dtpDat.Text = objfun.Data
        chkatv.Checked = objfun.Ativo

        tsbAlterar.Enabled = True
        tsbExcluir.Enabled = True
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If objfun.localizarComFiltro(txtLocalizar.Text) = True Then
            Call mostrar_dadosDaClasse()
            txtLocalizar.Clear()
            grpLoc.Visible = False
            tsbLocalizar.Enabled = True
        Else
            txtLocalizar.Clear()
            txtLocalizar.Focus()
        End If
    End Sub
End Class