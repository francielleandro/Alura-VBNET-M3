﻿Namespace Classes.Funcionarios
    Public Class Gerente
#Region "Property"

        Public Property nome As String
        Public Property cpf As String
        Public Property salario As Double

#End Region

#Region "Constructos"

#End Region

#Region "Functions"
        Public Function GetBonificacao() As Double
            Return salario * 0.1
        End Function
#End Region
    End Class
End Namespace