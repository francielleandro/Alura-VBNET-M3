﻿Namespace Classes.Funcionarios
    Public Class Diretor
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
            Return salario * 1.5
        End Function

        Public Overrides Sub AumentarSalario()
            salario = salario * 1.5
        End Sub


#End Region
    End Class
End Namespace

