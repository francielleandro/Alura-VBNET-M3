﻿Imports ByteBank.Classes.Funcionarios

Public Class Frm_Principal
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Principal"
        Lbl_Principal.Text = "Principal"
        Btn_Click.Text = "Clique aqui"
    End Sub

    Private Sub Btn_Click_Click(sender As Object, e As EventArgs) Handles Btn_Click.Click
        Dim Carlos As New Diretor()
        Carlos.nome = "Carlos"
        Carlos.cpf = "524.445.434-00"
        Carlos.salario = 2000

        Dim Bia As New Gerente()
        Bia.nome = "Bia"
        Bia.cpf = "524.445.414-01"
        Bia.salario = 2000

        MsgBox("O sálario do " + Carlos.nome + " é " + Carlos.salario.ToString)
        MsgBox("A bonificação de " + Carlos.nome + " é " + Carlos.GetBonificacao.ToString)

        MsgBox("O sálario do " + Bia.nome + " é " + Bia.salario.ToString)
        MsgBox("A bonificação de " + Bia.nome + " é " + Bia.GetBonificacao.ToString)
    End Sub

End Class