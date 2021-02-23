Namespace Classes.Funcionarios

    Public Class Funcionario

#Region "Property"

        Public Property nome As String
        Public Property cpf As String
        Public Property salario As Double

        Private Shared m_TotalDeFuncionarios As Integer

        Public Shared ReadOnly Property TotalDeFuncionario() As Integer
            Get
                Return m_TotalDeFuncionarios
            End Get
        End Property

#End Region

#Region "Constructos"
        Public Sub New()
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


