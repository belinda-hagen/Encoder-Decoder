Imports System.Security.Cryptography
Public NotInheritable Class EncryptDecryptVB
    Private TriplesDes As New TripleDESCryptoServiceProvider

    Private Function TruncateHas(ByVal key As String, ByVal length As Integer) As Byte()

        Dim shal As New SHA1CryptoServiceProvider

        Dim keyBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = shal.ComputeHash(keyBytes)

        ReDim Preserve hash(length - 1)
        Return hash
    End Function

    Sub New(ByVal key As String)

        TriplesDes.Key = TruncateHas(key, TriplesDes.KeySize \ 8)
        TriplesDes.IV = TruncateHas("", TriplesDes.BlockSize \ 8)
    End Sub

    Public Function EncryptData(ByVal plaintext As String) As String

        Dim plaintextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)

        Dim ms As New System.IO.MemoryStream

        Dim encSteam As New CryptoStream(ms, TriplesDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

        encSteam.Write(plaintextBytes, 0, plaintextBytes.Length)
        encSteam.FlushFinalBlock()

        Return Convert.ToBase64String(ms.ToArray)

    End Function

    Public Function DecryptData(ByVal encryptedtext As String) As String

        Dim encryptBytes() As Byte = Convert.FromBase64String(encryptedtext)

        Dim ms As New System.IO.MemoryStream

        Dim decSteam As New CryptoStream(ms, TriplesDes.CreateDecryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

        decSteam.Write(encryptBytes, 0, encryptBytes.Length)
        decSteam.FlushFinalBlock()

        Return System.Text.Encoding.Unicode.GetString(ms.ToArray)

    End Function
End Class