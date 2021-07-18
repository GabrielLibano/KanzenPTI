Public Class ClsFuncionario
    Dim m_cod As Integer
    Dim m_nom,
        m_rg,
        m_cpf,
        m_end,
        m_num,
        m_com,
        m_bai,
        m_cid,
        m_est,
        m_cep,
        m_tel As String
    Dim m_dat As Date
    Dim m_atv As Boolean

    Dim sql As String
    Dim objBanco As New ClsBanco
    Dim objDtLocal As New DataTable

    Public Property Codigo() As Integer
        Get
            Return m_cod
        End Get
        Set(value As Integer)
            m_cod = value
        End Set
    End Property

    Public Property Nome() As String
        Get
            Return m_nom
        End Get
        Set(value As String)
            m_nom = value
        End Set
    End Property

    Public Property RG() As String
        Get
            Return m_rg
        End Get
        Set(value As String)
            m_rg = value
        End Set
    End Property

    Public Property CPF() As String
        Get
            Return m_cpf
        End Get
        Set(value As String)
            m_cpf = value
        End Set
    End Property

    Public Property Endereco() As String
        Get
            Return m_end
        End Get
        Set(value As String)
            m_end = value
        End Set
    End Property

    Public Property Numero() As String
        Get
            Return m_num
        End Get
        Set(value As String)
            m_num = value
        End Set
    End Property

    Public Property Complemento() As String
        Get
            Return m_com
        End Get
        Set(value As String)
            m_com = value
        End Set
    End Property

    Public Property Bairro() As String
        Get
            Return m_bai
        End Get
        Set(value As String)
            m_bai = value
        End Set
    End Property

    Public Property Cidade() As String
        Get
            Return m_cid
        End Get
        Set(value As String)
            m_cid = value
        End Set
    End Property

    Public Property Estado() As String
        Get
            Return m_est
        End Get
        Set(value As String)
            m_est = value
        End Set
    End Property

    Public Property CEP() As String
        Get
            Return m_cep
        End Get
        Set(value As String)
            m_cep = value
        End Set
    End Property

    Public Property Telefone() As String
        Get
            Return m_tel
        End Get
        Set(value As String)
            m_tel = value
        End Set
    End Property

    Public Property Data() As Date
        Get
            Return m_dat
        End Get
        Set(value As Date)
            m_dat = value
        End Set
    End Property

    Public Property Ativo() As Boolean
        Get
            Return m_atv
        End Get
        Set(value As Boolean)
            m_atv = value
        End Set
    End Property

    Public Sub gravar(novo As Boolean)
        If novo Then
            sql = "insert into tabfuncionários " & _
                "( nomfun" & _
                ", rgfun" & _
                ", cpffun" & _
                ", endfun" & _
                ", numfun" & _
                ", comfun" & _
                ", baifun" & _
                ", cidfun" & _
                ", estfun" & _
                ", cepfun" & _
                ", celfun" & _
                ", datfun" & _
                ", atifun" & _
                ") values" & _
                "( '" & m_nom & "'" & _
                ", '" & m_rg & "'" & _
                ", '" & m_cpf & "'" & _
                ", '" & m_end & "'" & _
                ", '" & m_num & "'" & _
                ", '" & m_com & "'" & _
                ", '" & m_bai & "'" & _
                ", '" & m_cid & "'" & _
                ", '" & m_est & "'" & _
                ", '" & m_cep & "'" & _
                ", '" & m_tel & "'" & _
                ", '" & m_dat & "'" & _
                ", " & m_atv & " " & _
                ")"
            objBanco.executar_comando(sql)
            sql = " select max(codfun) as codigo from tabfuncionários"
            m_cod = objBanco.buscar_ultimoRegistro(sql)
        Else
            sql = " update tabfuncionários set " & _
                " nomfun='" & m_nom & "'" & _
                ", rgfun= '" & m_rg & "'" & _
                ", cpffun= '" & m_cpf & "'" & _
                ", endfun= '" & m_end & "'" & _
                ", numfun= '" & m_num & "'" & _
                ", comfun= '" & m_com & "'" & _
                ", baifun= '" & m_bai & "'" & _
                ", cidfun= '" & m_cid & "'" & _
                ", estfun= '" & m_est & "'" & _
                ", cepfun= '" & m_cep & "'" & _
                ", celfun= '" & m_tel & "'" & _
                ", datfun= '" & m_dat & "'" & _
                ", atifun= " & m_atv & "" & _
                " where codfun=" & m_cod
            objBanco.executar_comando(sql)
        End If
    End Sub

    Public Function localizarComFiltro(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from tabfuncionários where codfun=" & campo
        Else
            sql = "Select * from tabfuncionários where nomfun='" & campo & " '"
        End If
        objDtLocal = objBanco.localizar(sql)
        If objDtLocal.Rows.Count = 0 Then
            MessageBox.Show("Reegistro " & campo & " não foi encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Call mostrar_dadosVindosDoBanco()
            Return True
        End If
    End Function
    Public Sub mostrar_dadosVindosDoBanco()
        m_cod = objDtLocal.Rows(0).Item(0)
        m_nom = objDtLocal.Rows(0).Item(1)
        m_rg = objDtLocal.Rows(0).Item(2)
        m_cpf = objDtLocal.Rows(0).Item(3)
        m_end = objDtLocal.Rows(0).Item(4)
        m_num = objDtLocal.Rows(0).Item(5)
        m_com = objDtLocal.Rows(0).Item(6)
        m_bai = objDtLocal.Rows(0).Item(7)
        m_cid = objDtLocal.Rows(0).Item(8)
        m_est = objDtLocal.Rows(0).Item(9)
        m_cep = objDtLocal.Rows(0).Item(10)
        m_tel = objDtLocal.Rows(0).Item(11)
        m_dat = objDtLocal.Rows(0).Item(12)
        m_atv = objDtLocal.Rows(0).Item(13)
    End Sub

    Public Function excluir(chave As Integer) As Boolean
        If MessageBox.Show("Deseja excluir o registro " & chave & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabfuncionários where codfun=" & chave
            objBanco.executar_comando(sql)
            Return True
        End If
    End Function

    Public Function Localizar(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "Select * from tabfuncionários where codfun=" & campo
        Else
            sql = "Select  * from tabfuncionários where nomfun like '" & campo & "%' order by nomfun"
        End If
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function
End Class
