﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConClientes))
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtCampo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgdGrade
        '
        Me.DgdGrade.AllowUserToAddRows = False
        Me.DgdGrade.AllowUserToDeleteRows = False
        Me.DgdGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column14, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column13, Me.Column11, Me.Column12})
        Me.DgdGrade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGrade.Location = New System.Drawing.Point(11, 112)
        Me.DgdGrade.Margin = New System.Windows.Forms.Padding(2)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.RowTemplate.Height = 24
        Me.DgdGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGrade.Size = New System.Drawing.Size(659, 263)
        Me.DgdGrade.TabIndex = 58
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "codcli"
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 65
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "nomcli"
        Me.Column2.HeaderText = "Nome"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 60
        '
        'Column14
        '
        Me.Column14.DataPropertyName = "celcli"
        Me.Column14.HeaderText = "Celular"
        Me.Column14.Name = "Column14"
        Me.Column14.Width = 64
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "telcli"
        Me.Column3.HeaderText = "Telefone"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 74
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "endcli"
        Me.Column4.HeaderText = "Endereço"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 78
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "comcli"
        Me.Column5.HeaderText = "Complemento"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 96
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "baicli"
        Me.Column6.HeaderText = "Bairro"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 59
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "CEPcli"
        Me.Column7.HeaderText = "CEP"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 53
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "cidcli"
        Me.Column8.HeaderText = "Cidade"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 65
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "estcli"
        Me.Column9.HeaderText = "Estado"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 65
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "emacli"
        Me.Column10.HeaderText = "Email"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 57
        '
        'Column13
        '
        Me.Column13.DataPropertyName = "pjpfcli"
        Me.Column13.HeaderText = "PjPf"
        Me.Column13.Name = "Column13"
        Me.Column13.Width = 51
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "cpfcli"
        Me.Column11.HeaderText = "CPF"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 52
        '
        'Column12
        '
        Me.Column12.DataPropertyName = "datcli"
        Me.Column12.HeaderText = "Data"
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 55
        '
        'TxtCampo
        '
        Me.TxtCampo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCampo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCampo.Location = New System.Drawing.Point(235, 58)
        Me.TxtCampo.Name = "TxtCampo"
        Me.TxtCampo.Size = New System.Drawing.Size(367, 26)
        Me.TxtCampo.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 19)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Digite o Nome ou Código"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.KanzenPTI.My.Resources.Resources.LogoKanzen__1___1_
        Me.PictureBox1.Location = New System.Drawing.Point(605, 389)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(707, 47)
        Me.ToolStrip1.TabIndex = 63
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCancelar.Image = CType(resources.GetObject("tsbCancelar.Image"), System.Drawing.Image)
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(44, 44)
        Me.tsbCancelar.Text = "Cancelar"
        '
        'FrmConClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 459)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgdGrade)
        Me.Controls.Add(Me.TxtCampo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmConClientes"
        Me.Text = "FrmConClientes"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents TxtCampo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
