Namespace Classes.Funcionarios
    Public Class Gerente
        Inherits Funcionario
#Region "Property"

#End Region

#Region "Constructos"
        Public Sub New(_cpf As String, _salario As Double)
            MyBase.New(_cpf, _salario)
        End Sub
#End Region

#Region "Metodos"
        Public Overrides Function GetBonificacao() As Double
            Return salario * 0.1
        End Function
#End Region
    End Class
End Namespace
