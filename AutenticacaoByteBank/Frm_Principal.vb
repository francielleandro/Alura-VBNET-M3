Imports AutenticacaoByteBank.Classes.Funcionarios
Imports AutenticacaoByteBank.Classes.Bibliotecas

Public Class Frm_Principal
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Autenticação ByteBank"
        Lbl_Principal.Text = "Autenticação ByteBank"

        Btn_Autentica.Text = "Autenticar"
    End Sub

    Private Sub Btn_Autentica_Click(sender As Object, e As EventArgs) Handles Btn_Autentica.Click
        Dim vLoga As Boolean
        Dim SistemaInterno As New SistemaInterno

        Dim pedro As New Diretor("123.456.789-10", 200)
        pedro.senha = "12345"
        pedro.nome = "Pedro"



        vLoga = SistemaInterno.Logar(pedro, "123456")

        MsgBox("A tentativa de logar no sistema resultou em " + vLoga.ToString)


        Dim Lucia As New Gerente("123.456.189-10", 2000)
        Lucia.senha = "12345"
        Lucia.nome = "Lucia"


        vLoga = SistemaInterno.Logar(Lucia, "12345")

        MsgBox("A tentativa de logar no sistema resultou em " + vLoga.ToString)
    End Sub
End Class
