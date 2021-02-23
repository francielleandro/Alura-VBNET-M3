Namespace Classes.Funcionarios

    Public Class Funcionario

#Region "Property"

        Public Property nome As String
        Public Property salario As Double

        Private Property m_cpf As String
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

#End Region

#Region "Constructos"
        Public Sub New(_cpf As String)
            m_cpf = _cpf
            m_TotalDeFuncionarios += 1
        End Sub

#End Region

#Region "Functions"
        Public Overridable Function GetBonificacao() As Double
            Return salario * 0.1
        End Function
#End Region

    End Class
End Namespace


