﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadCliente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadCliente))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbNovo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbGravar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbLocalizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAlterar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbExcluir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSair = New System.Windows.Forms.ToolStripButton()
        Me.mskCEP = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEst = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBai = New System.Windows.Forms.TextBox()
        Me.txtCom = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpDat = New System.Windows.Forms.DateTimePicker()
        Me.txtEma = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mskTel = New System.Windows.Forms.MaskedTextBox()
        Me.mskCel = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mskCPF = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtLocalizar = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.grpLoc = New System.Windows.Forms.GroupBox()
        Me.txtcid = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chkPJ = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1.SuspendLayout()
        Me.grpLoc.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNovo, Me.ToolStripSeparator1, Me.tsbGravar, Me.ToolStripSeparator2, Me.tsbLocalizar, Me.ToolStripSeparator6, Me.tsbAlterar, Me.ToolStripSeparator3, Me.tsbExcluir, Me.ToolStripSeparator4, Me.tsbCancelar, Me.ToolStripSeparator5, Me.tsbSair})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(996, 47)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbNovo
        '
        Me.tsbNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbNovo.Image = CType(resources.GetObject("tsbNovo.Image"), System.Drawing.Image)
        Me.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNovo.Name = "tsbNovo"
        Me.tsbNovo.Size = New System.Drawing.Size(44, 44)
        Me.tsbNovo.Text = "Novo Cadastro"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 47)
        '
        'tsbGravar
        '
        Me.tsbGravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGravar.Image = CType(resources.GetObject("tsbGravar.Image"), System.Drawing.Image)
        Me.tsbGravar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGravar.Name = "tsbGravar"
        Me.tsbGravar.Size = New System.Drawing.Size(44, 44)
        Me.tsbGravar.Text = "Gravar Cadastro"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 47)
        '
        'tsbLocalizar
        '
        Me.tsbLocalizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbLocalizar.Image = CType(resources.GetObject("tsbLocalizar.Image"), System.Drawing.Image)
        Me.tsbLocalizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLocalizar.Name = "tsbLocalizar"
        Me.tsbLocalizar.Size = New System.Drawing.Size(44, 44)
        Me.tsbLocalizar.Text = "Localizar"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 47)
        '
        'tsbAlterar
        '
        Me.tsbAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAlterar.Image = CType(resources.GetObject("tsbAlterar.Image"), System.Drawing.Image)
        Me.tsbAlterar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAlterar.Name = "tsbAlterar"
        Me.tsbAlterar.Size = New System.Drawing.Size(44, 44)
        Me.tsbAlterar.Text = "Alterar Cadastro"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 47)
        '
        'tsbExcluir
        '
        Me.tsbExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbExcluir.Image = CType(resources.GetObject("tsbExcluir.Image"), System.Drawing.Image)
        Me.tsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExcluir.Name = "tsbExcluir"
        Me.tsbExcluir.Size = New System.Drawing.Size(44, 44)
        Me.tsbExcluir.Text = "Excluir Cadastro"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 47)
        '
        'tsbCancelar
        '
        Me.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCancelar.Image = CType(resources.GetObject("tsbCancelar.Image"), System.Drawing.Image)
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(44, 44)
        Me.tsbCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 47)
        '
        'tsbSair
        '
        Me.tsbSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSair.Image = CType(resources.GetObject("tsbSair.Image"), System.Drawing.Image)
        Me.tsbSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSair.Name = "tsbSair"
        Me.tsbSair.Size = New System.Drawing.Size(44, 44)
        Me.tsbSair.Text = "Sair"
        '
        'mskCEP
        '
        Me.mskCEP.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCEP.Location = New System.Drawing.Point(15, 288)
        Me.mskCEP.Mask = "00000-000"
        Me.mskCEP.Name = "mskCEP"
        Me.mskCEP.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mskCEP.Size = New System.Drawing.Size(86, 26)
        Me.mskCEP.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 266)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 19)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "CEP:"
        '
        'txtEst
        '
        Me.txtEst.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEst.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEst.Location = New System.Drawing.Point(220, 360)
        Me.txtEst.Name = "txtEst"
        Me.txtEst.Size = New System.Drawing.Size(187, 26)
        Me.txtEst.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(216, 338)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 19)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Estado:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(603, 266)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 19)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Bairro:"
        '
        'txtBai
        '
        Me.txtBai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBai.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBai.Location = New System.Drawing.Point(604, 288)
        Me.txtBai.Name = "txtBai"
        Me.txtBai.Size = New System.Drawing.Size(194, 26)
        Me.txtBai.TabIndex = 11
        '
        'txtCom
        '
        Me.txtCom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCom.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCom.Location = New System.Drawing.Point(441, 288)
        Me.txtCom.Name = "txtCom"
        Me.txtCom.Size = New System.Drawing.Size(157, 26)
        Me.txtCom.TabIndex = 10
        Me.txtCom.Tag = "x"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(437, 266)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 19)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Complemento:"
        '
        'txtEnd
        '
        Me.txtEnd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEnd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnd.Location = New System.Drawing.Point(107, 288)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(328, 26)
        Me.txtEnd.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(103, 266)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 19)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Endereço:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(658, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 19)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Data do Cadastro:"
        '
        'dtpDat
        '
        Me.dtpDat.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDat.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDat.Location = New System.Drawing.Point(662, 202)
        Me.dtpDat.Name = "dtpDat"
        Me.dtpDat.Size = New System.Drawing.Size(121, 26)
        Me.dtpDat.TabIndex = 7
        '
        'txtEma
        '
        Me.txtEma.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEma.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEma.Location = New System.Drawing.Point(245, 202)
        Me.txtEma.Name = "txtEma"
        Me.txtEma.Size = New System.Drawing.Size(411, 26)
        Me.txtEma.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(241, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 19)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Email:"
        '
        'mskTel
        '
        Me.mskTel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskTel.Location = New System.Drawing.Point(149, 202)
        Me.mskTel.Mask = "0000-0000"
        Me.mskTel.Name = "mskTel"
        Me.mskTel.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mskTel.Size = New System.Drawing.Size(90, 26)
        Me.mskTel.TabIndex = 5
        '
        'mskCel
        '
        Me.mskCel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCel.Location = New System.Drawing.Point(15, 202)
        Me.mskCel.Mask = "(99) 00000-0000"
        Me.mskCel.Name = "mskCel"
        Me.mskCel.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mskCel.Size = New System.Drawing.Size(128, 26)
        Me.mskCel.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(145, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 19)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Telefone:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 19)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Celular:"
        '
        'txtNom
        '
        Me.txtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNom.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(121, 123)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(485, 26)
        Me.txtNom.TabIndex = 2
        '
        'txtCod
        '
        Me.txtCod.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCod.Location = New System.Drawing.Point(15, 123)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(100, 26)
        Me.txtCod.TabIndex = 1
        Me.txtCod.Tag = "x"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 19)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Nome:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 19)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Código:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(608, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 19)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "CPF:"
        '
        'mskCPF
        '
        Me.mskCPF.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCPF.Location = New System.Drawing.Point(612, 123)
        Me.mskCPF.Mask = "000,000,000-00"
        Me.mskCPF.Name = "mskCPF"
        Me.mskCPF.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mskCPF.Size = New System.Drawing.Size(186, 26)
        Me.mskCPF.TabIndex = 3
        Me.mskCPF.Tag = "x"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(680, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(220, 24)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "Cadastro de Clientes"
        '
        'txtLocalizar
        '
        Me.txtLocalizar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLocalizar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalizar.Location = New System.Drawing.Point(6, 22)
        Me.txtLocalizar.Name = "txtLocalizar"
        Me.txtLocalizar.Size = New System.Drawing.Size(328, 26)
        Me.txtLocalizar.TabIndex = 0
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(340, 22)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(44, 26)
        Me.btnOk.TabIndex = 57
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'grpLoc
        '
        Me.grpLoc.Controls.Add(Me.txtLocalizar)
        Me.grpLoc.Controls.Add(Me.btnOk)
        Me.grpLoc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLoc.Location = New System.Drawing.Point(508, 338)
        Me.grpLoc.Name = "grpLoc"
        Me.grpLoc.Size = New System.Drawing.Size(391, 54)
        Me.grpLoc.TabIndex = 58
        Me.grpLoc.TabStop = False
        Me.grpLoc.Text = "Localizar Cliente"
        '
        'txtcid
        '
        Me.txtcid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcid.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcid.Location = New System.Drawing.Point(15, 360)
        Me.txtcid.Name = "txtcid"
        Me.txtcid.Size = New System.Drawing.Size(187, 26)
        Me.txtcid.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(11, 338)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 19)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Cidade:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.KanzenPTI.My.Resources.Resources.LogoKanzen__1___1_
        Me.PictureBox1.Location = New System.Drawing.Point(894, 399)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 61
        Me.PictureBox1.TabStop = False
        '
        'chkPJ
        '
        Me.chkPJ.AutoSize = True
        Me.chkPJ.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPJ.Location = New System.Drawing.Point(15, 63)
        Me.chkPJ.Name = "chkPJ"
        Me.chkPJ.Size = New System.Drawing.Size(150, 23)
        Me.chkPJ.TabIndex = 0
        Me.chkPJ.Text = "Pessoa Jurídica"
        Me.chkPJ.UseVisualStyleBackColor = True
        '
        'FrmCadCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(996, 474)
        Me.Controls.Add(Me.chkPJ)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtcid)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.grpLoc)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.mskCEP)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtEst)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtBai)
        Me.Controls.Add(Me.txtCom)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtEnd)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpDat)
        Me.Controls.Add(Me.txtEma)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.mskTel)
        Me.Controls.Add(Me.mskCel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mskCPF)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCadCliente"
        Me.Text = "S"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grpLoc.ResumeLayout(False)
        Me.grpLoc.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbNovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGravar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbAlterar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbExcluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSair As System.Windows.Forms.ToolStripButton
    Friend WithEvents mskCEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtEst As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtBai As System.Windows.Forms.TextBox
    Friend WithEvents txtCom As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtEnd As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpDat As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtEma As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents mskTel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskCel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mskCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tsbLocalizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtLocalizar As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents grpLoc As System.Windows.Forms.GroupBox
    Friend WithEvents txtcid As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents chkPJ As System.Windows.Forms.CheckBox
End Class
