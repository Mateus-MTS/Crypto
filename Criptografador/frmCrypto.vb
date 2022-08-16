Imports System.Text
Imports System.Security.Cryptography
Public Class frmCrypto
    Private Sub btnCriptografar_Click(sender As Object, e As EventArgs) Handles btnCriptografar.Click
        Dim objcrypto As New Criptografia(Me.txtChave.Text)
        Dim resultado As String

        resultado = objcrypto.EncryptData(Me.txtConteudo.Text)

        Me.txtResultado.Text = resultado
    End Sub

    Private Sub btnDescriptografar_Click(sender As Object, e As EventArgs) Handles btnDescriptografar.Click
        Dim objcrypto As New Criptografia(Me.txtChave.Text)
        Dim resultado As String

        resultado = objcrypto.DecryptData(Me.txtConteudo.Text)

        Me.txtResultado.Text = resultado
    End Sub
End Class