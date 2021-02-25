Namespace Classes.Funcionarios

    Public Class Designer
        Inherits Funcionario

#Region "PROPRIEDADES"

#End Region

#Region "CONSTRUTORES"
        Public Sub New(_cpf As String, _salario As Double)
            MyBase.New(_cpf, _salario)
        End Sub
#End Region
#Region "METODOS"
        Public Overrides Function GetBonificacao() As Double
            Return salario * 0.9
        End Function

        Public Overrides Sub AumentarSalario()
            salario = salario * 1.1
        End Sub
#End Region

    End Class

End Namespace
