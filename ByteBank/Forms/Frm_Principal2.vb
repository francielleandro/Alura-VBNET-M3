Imports ByteBank.Classes.Bibliotecas
Imports ByteBank.Classes.Funcionarios

Public Class Frm_Principal2
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Cálculo Bonificação"
        Lbl_Principal.Text = "Cálculo Bonificação"
        Btn_Bonificacao.Text = "Cálcular Bonificação"
    End Sub

    Private Sub Btn_Bonificacao_Click(sender As Object, e As EventArgs) Handles Btn_Bonificacao.Click
        Dim TotalBonificacao As New GerenciadorBonificacao

        Dim Carlos As New Diretor("123.158.15-56", 5000)
        Dim Joao As New Designer("123.158.15-06", 3000)
        Dim Gabi As New Gerente("123.158.35-56", 4000)
        Dim Carla As New Auxiliar("133.128.15-56", 2000)

        TotalBonificacao.Registrar(Carlos)
        TotalBonificacao.Registrar(Joao)
        TotalBonificacao.Registrar(Gabi)
        TotalBonificacao.Registrar(Carla)

        MsgBox("O valor total da bonificação será de " + TotalBonificacao.getBonificacao.ToString)
    End Sub
End Class