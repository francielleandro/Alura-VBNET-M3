﻿Namespace Classes.Funcionarios

    Public Class Funcionario

#Region "Property"

        Public Property nome As String
        Public Property cpf As String
        Public Property salario As Double
        Public Property cargo As String

#End Region

#Region "Constructos"
        Public Sub New(_cargo As String)
            cargo = _cargo
        End Sub
#End Region

#Region "Functions"
        Public Function GetBonificacao() As Double
            If cargo = "1" Then
                Return salario * 0.1
            ElseIf cargo = "2" Then
                Return salario * 1
            End If
            Return 0
        End Function
#End Region

    End Class
End Namespace


