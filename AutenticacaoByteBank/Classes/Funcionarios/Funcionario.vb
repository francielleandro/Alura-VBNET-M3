Namespace Classes.Funcionarios

    Public MustInherit Class Funcionario

#Region "Property"

        Public Property nome As String
        Private m_salario As Double
        Public Property salario As Double
            Get
                Return m_salario
            End Get
            Protected Set(value As Double)
                m_salario = value
            End Set
        End Property


        Private m_cpf As String
        Public ReadOnly Property cpf As String
            Get
                Return m_cpf
            End Get
        End Property



        Private Shared m_TotalDeFuncionarios As Integer
        Public Shared ReadOnly Property TotalDeFuncionario() As Integer
            Get
                Return m_TotalDeFuncionarios
            End Get
        End Property

        Public Property senha As String

#End Region

#Region "Constructos"
        Public Sub New(_cpf As String, _salario As Double)
            m_cpf = _cpf
            m_salario = _salario
            m_TotalDeFuncionarios += 1
        End Sub

#End Region

#Region "Metodos"
        Public MustOverride Function GetBonificacao() As Double

        Public MustOverride Sub AumentarSalario()

        Public Function Autenticar(senhaTentativa As String) As Boolean

            If senha = senhaTentativa Then
                Return True
            End If
            Return False

        End Function

#End Region

    End Class
End Namespace


