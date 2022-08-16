Imports System.Text
Imports System.Security.Cryptography

' Classe para encapsular os métodos de criptografia e descriptografia.
Public NotInheritable Class Criptografia

    ' Adicione um campo particular para armazenar o provedor de serviços criptográficos 3DES.
    Private TripleDes As New TripleDESCryptoServiceProvider
    Sub New(ByVal key As String)
        ' Inicializar o provedor de serviços criptográficos 3DES.
        ' O key parâmetro controla os EncryptData DecryptData métodos.
        TripleDes.Key = TruncateHash(key, TripleDes.KeySize \ 8)
        TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
    End Sub

    ' Método privado que cria uma matriz de bytes de um comprimento especificado a partir do hash da chave especificada.
    Private Function TruncateHash(
    ByVal key As String,
    ByVal length As Integer) As Byte()

        Dim sha1 As New SHA1CryptoServiceProvider

        ' Chave hash.
        Dim keyBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = sha1.ComputeHash(keyBytes)

        ' Truncar ou preencher o hash.
        ReDim Preserve hash(length - 1)
        Return hash
    End Function

    ' Método público que criptografa uma cadeia de caracteres.
    Public Function EncryptData(
    ByVal plaintext As String) As String

        ' Converta a string de texto simples em uma matriz de bytes.
        Dim plaintextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plaintext)

        ' Crie o fluxo.
        Dim ms As New System.IO.MemoryStream
        'Crie o codificador para gravar no fluxo.
        Dim encStream As New CryptoStream(ms,
            TripleDes.CreateEncryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use o fluxo de criptografia para gravar a matriz de bytes no fluxo.
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        ' Converta o fluxo criptografado em uma string imprimível.
        Return Convert.ToBase64String(ms.ToArray)
    End Function

    ' Método público que descriptografa uma cadeia de caracteres.
    Public Function DecryptData(ByVal encryptedtext As String) As String
        Try
            ' Converta a string de texto criptografada em uma matriz de bytes.
            Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)

            ' Crie o fluxo.
            Dim ms As New IO.MemoryStream
            ' Create the decoder to write to the stream.
            Dim decStream As New CryptoStream(ms,
            TripleDes.CreateDecryptor(),
            CryptoStreamMode.Write)

            'Use o fluxo de criptografia para gravar a matriz de bytes no fluxo.
            decStream.Write(encryptedBytes, 0, encryptedBytes.Length)


            decStream.FlushFinalBlock()

            Return Encoding.Unicode.GetString(ms.ToArray) ' Converta o fluxo de texto simples em uma string.
        Catch e As Exception
            Return e.Message
        End Try



    End Function
End Class
