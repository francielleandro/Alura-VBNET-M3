Imports AutenticacaoByteBank.Classes.Funcionarios

Namespace Classes.Bibliotecas
    Public Class SistemaInterno

#Region "Metodos"
        Public Function Logar(Funcionario As Funcionario, senhaTentativa As String)
            Dim vRetorno As Boolean

            vRetorno = Funcionario.Autenticar(senhaTentativa)

            Return vRetorno
        End Function
#End Region

    End Class
End Namespace
