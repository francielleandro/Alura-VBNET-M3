Namespace Classes.Funcionarios
    Public MustInherit Class FuncionarioAutenticavel
        Inherits Funcionario
#Region "Property"

        Public Property senha As String

#End Region

#Region "Constructos"
        Public Sub New(_cpf As String, _salario As Double)
            MyBase.New(_cpf, _salario)
        End Sub
#End Region

#Region "Metodos"

        Public Function Autenticar(senhaTentativa As String) As Boolean

            If senha = senhaTentativa Then
                Return True
            End If
            Return False

        End Function

#End Region

    End Class
End Namespace

