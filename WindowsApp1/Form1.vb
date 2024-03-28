Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class Form1

    Sub Encoding()
        Dim plaintext As String = txtEncrypt.Text
        Dim password As String = InputBox("Protect with password: ")

        Dim wrapper As New EncryptDecryptVB(password)
        Dim ciphertext As String = wrapper.EncryptData(plaintext)

        txtEncryptResult.Text = ciphertext
        My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\ciphertext.txt", ciphertext, False)

    End Sub

    Sub Decoding()
        Dim cipertext As String = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\ciphertext.txt")
        Dim password As String = InputBox("Enter password: ")
        Dim wripper As New EncryptDecryptVB(password)

        Try
            Dim plaintext As String = wripper.DecryptData(cipertext)

            txtDecryptResult.Text = plaintext
        Catch ex As Exception
            MsgBox("The data could not be decrypted witout the password!")
        End Try
    End Sub

    Private Sub EncryptData()
        Dim plaintext As String = txtEncrypt.Text
        Dim password As String = GetPassword("Protect with password:")

        If Not String.IsNullOrEmpty(password) Then
            Try
                Dim ciphertext As String = EncryptStringAES(plaintext, password)
                txtEncryptResult.Text = ciphertext
                SaveToFile(ciphertext)
            Catch ex As Exception
                MessageBox.Show("Encryption failed: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub DecryptData()
        Dim ciphertext As String = ReadFromFile()
        If String.IsNullOrEmpty(ciphertext) Then
            MessageBox.Show("No ciphertext found.")
            Return
        End If

        Dim password As String = GetPassword("Enter password:")

        If Not String.IsNullOrEmpty(password) Then
            Try
                Dim plaintext As String = DecryptStringAES(ciphertext, password)
                txtDecryptResult.Text = plaintext
            Catch ex As Exception
                MessageBox.Show("Decryption failed: " & ex.Message)
            End Try
        End If
    End Sub

    Private Function GetPassword(prompt As String) As String
        Using passwordForm As New PasswordForm(prompt)
            If passwordForm.ShowDialog() = DialogResult.OK Then
                Return passwordForm.Password
            End If
        End Using
        Return ""
    End Function

    Private Sub SaveToFile(data As String)
        Dim filePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ciphertext.txt")
        File.WriteAllText(filePath, data)
    End Sub

    Private Function ReadFromFile() As String
        Dim filePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ciphertext.txt")
        If File.Exists(filePath) Then
            Return File.ReadAllText(filePath)
        End If
        Return ""
    End Function

    Private Function EncryptStringAES(plainText As String, password As String) As String
        Using aesAlg As New AesCryptoServiceProvider()
            ' Generate a random salt (you should store this along with the ciphertext)
            Dim salt As Byte() = New Byte(7) {} ' 8 bytes for the salt
            Using rng As New RNGCryptoServiceProvider()
                rng.GetBytes(salt)
            End Using

            aesAlg.Key = DeriveKeyFromPassword(password, salt, aesAlg.KeySize)
            aesAlg.Mode = CipherMode.CFB

            Using encryptor As ICryptoTransform = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV)
                Using msEncrypt As New MemoryStream()
                    ' Write the salt to the beginning of the ciphertext
                    msEncrypt.Write(salt, 0, salt.Length)
                    msEncrypt.Write(aesAlg.IV, 0, aesAlg.IV.Length)
                    Using csEncrypt As New CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)
                        Using swEncrypt As New StreamWriter(csEncrypt)
                            swEncrypt.Write(plainText)
                        End Using
                    End Using
                    Return Convert.ToBase64String(msEncrypt.ToArray())
                End Using
            End Using
        End Using
    End Function

    Private Function DecryptStringAES(cipherText As String, password As String) As String
        Using aesAlg As New AesCryptoServiceProvider()
            Dim saltSize As Integer = 8 ' Assume 8 bytes for the salt
            Dim fullCipherText = Convert.FromBase64String(cipherText)
            Dim salt = fullCipherText.Take(saltSize).ToArray()
            aesAlg.Key = DeriveKeyFromPassword(password, salt, aesAlg.KeySize)
            aesAlg.Mode = CipherMode.CFB

            Using msDecrypt As New MemoryStream(fullCipherText, saltSize, fullCipherText.Length - saltSize)
                Dim iv(aesAlg.IV.Length - 1) As Byte
                msDecrypt.Read(iv, 0, iv.Length)

                Using decryptor As ICryptoTransform = aesAlg.CreateDecryptor(aesAlg.Key, iv)
                    Using csDecrypt As New CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)
                        Using srDecrypt As New StreamReader(csDecrypt)
                            Return srDecrypt.ReadToEnd()
                        End Using
                    End Using
                End Using
            End Using
        End Using
    End Function

    Private Function DeriveKeyFromPassword(password As String, salt As Byte(), keySize As Integer) As Byte()
        Using deriveBytes As New Rfc2898DeriveBytes(password, salt, 10000) ' You can adjust the iteration count (10000 is just an example)
            Return deriveBytes.GetBytes(keySize \ 8) ' Divide by 8 to convert bits to bytes
        End Using
    End Function

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btnEncrypt_Click(sender As Object, e As EventArgs) Handles btnEncrypt.Click
        EncryptData()
    End Sub

    Private Sub btnDecrypt_Click(sender As Object, e As EventArgs) Handles btnDecrypt.Click
        DecryptData()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtEncryptResult_TextChanged(sender As Object, e As EventArgs) Handles txtEncryptResult.TextChanged

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub
End Class

Public Class PasswordForm
    Inherits Form

    Private WithEvents btnOK As New Button() With {.Text = "OK", .DialogResult = DialogResult.OK, .Dock = DockStyle.Top, .Margin = New Padding(3)}
    Private WithEvents btnCancel As New Button() With {.Text = "Cancel", .DialogResult = DialogResult.Cancel, .Dock = DockStyle.Top, .Margin = New Padding(3)}
    Private WithEvents txtPassword As New TextBox() With {.PasswordChar = "*"c, .Dock = DockStyle.Top}

    Public ReadOnly Property Password As String
        Get
            Return txtPassword.Text
        End Get
    End Property

    Public Sub New(prompt As String)
        Me.Text = prompt
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.ShowInTaskbar = False
        Me.StartPosition = FormStartPosition.CenterParent

        ' Create a Panel with padding
        Dim panel As New TableLayoutPanel With {.Padding = New Padding(20), .Dock = DockStyle.Fill}
        panel.RowStyles.Add(New RowStyle(SizeType.Percent, 10)) ' Top row for the text box
        panel.RowStyles.Add(New RowStyle(SizeType.AutoSize)) ' Bottom row for the buttons
        panel.Controls.AddRange({txtPassword, btnOK, btnCancel})

        ' Add the Panel to the Form
        Me.Controls.Add(panel)
    End Sub
End Class


