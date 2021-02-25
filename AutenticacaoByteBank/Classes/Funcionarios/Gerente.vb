Namespace Classes.Funcionarios
    Public Class Gerente
        Inherits FuncionarioAutenticavel
#Region "Property"

#End Region

#Region "Constructos"
        Public Sub New(_cpf As String, _salario As Double)
            MyBase.New(_cpf, _salario)
        End Sub
#End Region

#Region "Metodos"
        Public Overrides Function GetBonificacao() As Double
            Return salario * 0.5
        End Function


        Public Overrides Sub AumentarSalario()
            salario = salario * 1.1
        End Sub
#End Region
    End Class
End Namespace
