Namespace Classes.Funcionarios
    Public Class Diretor
        Inherits Funcionario
#Region "Property"

#End Region

#Region "Constructos"

#End Region

#Region "Functions"
        Public Overrides Function GetBonificacao() As Double
            Return salario * 1 + MyBase.GetBonificacao
        End Function
#End Region
    End Class
End Namespace

