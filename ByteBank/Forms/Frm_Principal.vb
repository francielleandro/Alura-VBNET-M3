Imports ByteBank.Classes.Bibliotecas
Imports ByteBank.Classes.Funcionarios

Public Class Frm_Principal
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Principal"
        Lbl_Principal.Text = "Principal"
        Btn_Click.Text = "Clique aqui"
        Btn_InstanciarFuncionario.Text = "Instancia funcionario"
        Btn_getTotalFuncionario.Text = "Total de funcionarios"
        Btn_exibirSalarios.Text = "Exibir salarios de funcionarios"
    End Sub

    Private Sub Btn_Click_Click(sender As Object, e As EventArgs) Handles Btn_Click.Click
        Dim gerenciadorBonificacao As New GerenciadorBonificacao

        Dim Carlos As New Diretor("524.445.434-00", 3000)
        Carlos.nome = "Carlos"

        gerenciadorBonificacao.Registrar(Carlos)

        Dim Bia As New Gerente("524.445.414-01", 2000)
        Bia.nome = "Bia"

        MsgBox("O sálario do " + Carlos.nome + " é " + Carlos.salario.ToString)
        MsgBox("A bonificação de " + Carlos.nome + " é " + Carlos.GetBonificacao.ToString)

        MsgBox("O sálario do " + Bia.nome + " é " + Bia.salario.ToString)
        MsgBox("A bonificação de " + Bia.nome + " é " + Bia.GetBonificacao.ToString)

        gerenciadorBonificacao.Registrar(Bia)

        Dim totalBonificacao As Double

        totalBonificacao += Carlos.GetBonificacao
        totalBonificacao += Bia.GetBonificacao

        MsgBox("O total da bonificação a ser pago é " + totalBonificacao.ToString _
               + " o valor calculado pela biblioteca foi de " + gerenciadorBonificacao.getBonificacao.ToString)

    End Sub

    Private Sub Btn_InstanciarFuncionario_Click(sender As Object, e As EventArgs) Handles Btn_InstanciarFuncionario.Click
        Dim funcionario As New Auxiliar("524.445.434-00", 1000)
        MsgBox("Funcionario instanciado")
    End Sub

    Private Sub Btn_getTotalFuncionario_Click(sender As Object, e As EventArgs) Handles Btn_getTotalFuncionario.Click
        MsgBox("O número total de funcionarios instanciados é de " + Funcionario.TotalDeFuncionario.ToString)
    End Sub

    Private Sub Btn_exibirSalarios_Click(sender As Object, e As EventArgs) Handles Btn_exibirSalarios.Click
        Dim Carlos As New Diretor("524.445.434-00", 3000)
        Carlos.nome = "Carlos"

        Dim Bia As New Gerente("524.445.414-01", 2000)
        Bia.nome = "Bia"

        Dim Carolina As New Auxiliar("212.123.125-24", 1000)
        Bia.nome = "Carolina"

        MsgBox("O salario atual do " + Carlos.nome + " é " + Carlos.salario.ToString)
        Carlos.AumentarSalario()
        MsgBox("Com aumento de 15% é " + Carlos.salario.ToString)
    End Sub
End Class
