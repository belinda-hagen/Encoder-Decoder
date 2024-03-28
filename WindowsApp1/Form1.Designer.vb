<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEncrypt = New System.Windows.Forms.TextBox()
        Me.txtEncryptResult = New System.Windows.Forms.TextBox()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.txtDecrypt = New System.Windows.Forms.TextBox()
        Me.txtDecryptResult = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEncrypt)
        Me.GroupBox1.ForeColor = System.Drawing.Color.LightBlue
        Me.GroupBox1.Location = New System.Drawing.Point(15, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 188)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "1. Encryption Message"
        '
        'txtEncrypt
        '
        Me.txtEncrypt.BackColor = System.Drawing.Color.Black
        Me.txtEncrypt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEncrypt.ForeColor = System.Drawing.SystemColors.Info
        Me.txtEncrypt.Location = New System.Drawing.Point(10, 16)
        Me.txtEncrypt.Multiline = True
        Me.txtEncrypt.Name = "txtEncrypt"
        Me.txtEncrypt.Size = New System.Drawing.Size(380, 160)
        Me.txtEncrypt.TabIndex = 0
        '
        'txtEncryptResult
        '
        Me.txtEncryptResult.BackColor = System.Drawing.Color.Black
        Me.txtEncryptResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEncryptResult.ForeColor = System.Drawing.SystemColors.Info
        Me.txtEncryptResult.Location = New System.Drawing.Point(10, 16)
        Me.txtEncryptResult.Multiline = True
        Me.txtEncryptResult.Name = "txtEncryptResult"
        Me.txtEncryptResult.ReadOnly = True
        Me.txtEncryptResult.Size = New System.Drawing.Size(250, 80)
        Me.txtEncryptResult.TabIndex = 2
        '
        'btnEncrypt
        '
        Me.btnEncrypt.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEncrypt.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncrypt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnEncrypt.Location = New System.Drawing.Point(9, 15)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(252, 52)
        Me.btnEncrypt.TabIndex = 1
        Me.btnEncrypt.Text = "ENCRYPT"
        Me.btnEncrypt.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDecrypt)
        Me.GroupBox2.ForeColor = System.Drawing.Color.LightBlue
        Me.GroupBox2.Location = New System.Drawing.Point(15, 326)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 77)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "2. Decryption Start"
        '
        'btnDecrypt
        '
        Me.btnDecrypt.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDecrypt.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnDecrypt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnDecrypt.Location = New System.Drawing.Point(10, 15)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(252, 52)
        Me.btnDecrypt.TabIndex = 1
        Me.btnDecrypt.Text = "DECRYPT"
        Me.btnDecrypt.UseVisualStyleBackColor = False
        '
        'txtDecrypt
        '
        Me.txtDecrypt.BackColor = System.Drawing.Color.Black
        Me.txtDecrypt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDecrypt.ForeColor = System.Drawing.SystemColors.Info
        Me.txtDecrypt.Location = New System.Drawing.Point(10, 16)
        Me.txtDecrypt.Multiline = True
        Me.txtDecrypt.Name = "txtDecrypt"
        Me.txtDecrypt.Size = New System.Drawing.Size(380, 163)
        Me.txtDecrypt.TabIndex = 0
        '
        'txtDecryptResult
        '
        Me.txtDecryptResult.BackColor = System.Drawing.Color.Black
        Me.txtDecryptResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDecryptResult.ForeColor = System.Drawing.SystemColors.Info
        Me.txtDecryptResult.Location = New System.Drawing.Point(11, 16)
        Me.txtDecryptResult.Multiline = True
        Me.txtDecryptResult.Name = "txtDecryptResult"
        Me.txtDecryptResult.ReadOnly = True
        Me.txtDecryptResult.Size = New System.Drawing.Size(250, 80)
        Me.txtDecryptResult.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnEncrypt)
        Me.GroupBox3.ForeColor = System.Drawing.Color.LightBlue
        Me.GroupBox3.Location = New System.Drawing.Point(425, 109)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(270, 77)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "2. Encryption Start"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.txtEncryptResult)
        Me.GroupBox4.ForeColor = System.Drawing.Color.LightBlue
        Me.GroupBox4.Location = New System.Drawing.Point(425, 189)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(270, 108)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "3. Encryption Result"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox5.Controls.Add(Me.txtDecrypt)
        Me.GroupBox5.ForeColor = System.Drawing.Color.LightBlue
        Me.GroupBox5.Location = New System.Drawing.Point(295, 326)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(400, 188)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "1. Decryption Message"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtDecryptResult)
        Me.GroupBox6.ForeColor = System.Drawing.Color.LightBlue
        Me.GroupBox6.Location = New System.Drawing.Point(15, 406)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(270, 108)
        Me.GroupBox6.TabIndex = 8
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "3. Decryption Result"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.EncryptorX.My.Resources.Resources.Stripe21
        Me.PictureBox3.Location = New System.Drawing.Point(0, 97)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(720, 3)
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.EncryptorX.My.Resources.Resources.Stripe2
        Me.PictureBox2.Location = New System.Drawing.Point(15, 314)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(680, 1)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EncryptorX.My.Resources.Resources.background4
        Me.PictureBox1.Location = New System.Drawing.Point(-97, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1074, 100)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(710, 528)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(726, 567)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(726, 567)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EncryptorX"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnEncrypt As Button
    Friend WithEvents txtEncrypt As TextBox
    Friend WithEvents txtEncryptResult As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtDecryptResult As TextBox
    Friend WithEvents btnDecrypt As Button
    Friend WithEvents txtDecrypt As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
