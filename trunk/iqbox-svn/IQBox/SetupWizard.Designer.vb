<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetupWizard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetupWizard))
        Me.But_Next = New System.Windows.Forms.Button
        Me.But_Prev = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.FinalPage = New System.Windows.Forms.TabPage
        Me.Label_sdfsd = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Combo_IQBFolder = New System.Windows.Forms.ComboBox
        Me.But_Browse = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Rad_MyDocs = New System.Windows.Forms.RadioButton
        Me.Rad_Custom = New System.Windows.Forms.RadioButton
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TB_Password = New System.Windows.Forms.TextBox
        Me.TB_Username = New System.Windows.Forms.TextBox
        Me.TB_Server = New System.Windows.Forms.TextBox
        Me.But_TestConn = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.FinalPage.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'But_Next
        '
        Me.But_Next.Location = New System.Drawing.Point(343, 329)
        Me.But_Next.Name = "But_Next"
        Me.But_Next.Size = New System.Drawing.Size(125, 23)
        Me.But_Next.TabIndex = 8
        Me.But_Next.Text = "Next >>"
        Me.But_Next.UseVisualStyleBackColor = True
        '
        'But_Prev
        '
        Me.But_Prev.Location = New System.Drawing.Point(212, 329)
        Me.But_Prev.Name = "But_Prev"
        Me.But_Prev.Size = New System.Drawing.Size(125, 23)
        Me.But_Prev.TabIndex = 9
        Me.But_Prev.Text = "<< Previous"
        Me.But_Prev.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.IQBox.My.Resources.Resources.socket
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 363)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FolderBrowserDialog1
        '
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label7)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(458, 296)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Intro"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(441, 211)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = resources.GetString("Label6.Text")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(128, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Disclaimer and Legal Notice"
        '
        'FinalPage
        '
        Me.FinalPage.Controls.Add(Me.PictureBox2)
        Me.FinalPage.Controls.Add(Me.Label_sdfsd)
        Me.FinalPage.Location = New System.Drawing.Point(4, 22)
        Me.FinalPage.Name = "FinalPage"
        Me.FinalPage.Padding = New System.Windows.Forms.Padding(3)
        Me.FinalPage.Size = New System.Drawing.Size(458, 296)
        Me.FinalPage.TabIndex = 2
        Me.FinalPage.Text = "Step 3"
        Me.FinalPage.UseVisualStyleBackColor = True
        '
        'Label_sdfsd
        '
        Me.Label_sdfsd.AutoSize = True
        Me.Label_sdfsd.Location = New System.Drawing.Point(17, 95)
        Me.Label_sdfsd.Name = "Label_sdfsd"
        Me.Label_sdfsd.Size = New System.Drawing.Size(422, 65)
        Me.Label_sdfsd.TabIndex = 0
        Me.Label_sdfsd.Text = resources.GetString("Label_sdfsd.Text")
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.IQBox.My.Resources.Resources.socket
        Me.PictureBox2.Location = New System.Drawing.Point(188, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 59)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Rad_Custom)
        Me.TabPage2.Controls.Add(Me.Rad_MyDocs)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.But_Browse)
        Me.TabPage2.Controls.Add(Me.Combo_IQBFolder)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(458, 296)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Step 2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Combo_IQBFolder
        '
        Me.Combo_IQBFolder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Combo_IQBFolder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories
        Me.Combo_IQBFolder.FormattingEnabled = True
        Me.Combo_IQBFolder.Location = New System.Drawing.Point(10, 118)
        Me.Combo_IQBFolder.Name = "Combo_IQBFolder"
        Me.Combo_IQBFolder.Size = New System.Drawing.Size(434, 21)
        Me.Combo_IQBFolder.TabIndex = 1
        Me.Combo_IQBFolder.Text = "C:\IQBox"
        '
        'But_Browse
        '
        Me.But_Browse.Location = New System.Drawing.Point(10, 144)
        Me.But_Browse.Name = "But_Browse"
        Me.But_Browse.Size = New System.Drawing.Size(75, 23)
        Me.But_Browse.TabIndex = 2
        Me.But_Browse.Text = "&Browse"
        Me.But_Browse.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(330, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Where do you want your IQBox shared folder to be kept?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(435, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "If you are unsure, just click Next. The folder will be stored under your My Docum" & _
            "ents folder."
        '
        'Rad_MyDocs
        '
        Me.Rad_MyDocs.AutoSize = True
        Me.Rad_MyDocs.Checked = True
        Me.Rad_MyDocs.Location = New System.Drawing.Point(10, 56)
        Me.Rad_MyDocs.Name = "Rad_MyDocs"
        Me.Rad_MyDocs.Size = New System.Drawing.Size(323, 17)
        Me.Rad_MyDocs.TabIndex = 5
        Me.Rad_MyDocs.TabStop = True
        Me.Rad_MyDocs.Text = "Put the shared folder in My Documents\IQBox (Recommended)"
        Me.Rad_MyDocs.UseVisualStyleBackColor = True
        '
        'Rad_Custom
        '
        Me.Rad_Custom.AutoSize = True
        Me.Rad_Custom.Location = New System.Drawing.Point(10, 95)
        Me.Rad_Custom.Name = "Rad_Custom"
        Me.Rad_Custom.Size = New System.Drawing.Size(272, 17)
        Me.Rad_Custom.TabIndex = 6
        Me.Rad_Custom.Text = "I want to store it in a different folder, specified below:"
        Me.Rad_Custom.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.But_TestConn)
        Me.TabPage1.Controls.Add(Me.TB_Server)
        Me.TabPage1.Controls.Add(Me.TB_Username)
        Me.TabPage1.Controls.Add(Me.TB_Password)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(458, 296)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Step 1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to IQBox!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(356, 78)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 65)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Server:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Username:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password:"
        '
        'TB_Password
        '
        Me.TB_Password.Location = New System.Drawing.Point(85, 202)
        Me.TB_Password.Name = "TB_Password"
        Me.TB_Password.Size = New System.Drawing.Size(125, 20)
        Me.TB_Password.TabIndex = 3
        '
        'TB_Username
        '
        Me.TB_Username.Location = New System.Drawing.Point(85, 176)
        Me.TB_Username.Name = "TB_Username"
        Me.TB_Username.Size = New System.Drawing.Size(125, 20)
        Me.TB_Username.TabIndex = 2
        '
        'TB_Server
        '
        Me.TB_Server.Location = New System.Drawing.Point(85, 150)
        Me.TB_Server.Name = "TB_Server"
        Me.TB_Server.Size = New System.Drawing.Size(192, 20)
        Me.TB_Server.TabIndex = 1
        '
        'But_TestConn
        '
        Me.But_TestConn.Location = New System.Drawing.Point(9, 238)
        Me.But_TestConn.Name = "But_TestConn"
        Me.But_TestConn.Size = New System.Drawing.Size(216, 24)
        Me.But_TestConn.TabIndex = 4
        Me.But_TestConn.Text = "Test my connection to my IQBox"
        Me.But_TestConn.UseVisualStyleBackColor = True
        Me.But_TestConn.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.FinalPage)
        Me.TabControl1.Location = New System.Drawing.Point(128, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(466, 322)
        Me.TabControl1.TabIndex = 1
        '
        'SetupWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 364)
        Me.Controls.Add(Me.But_Prev)
        Me.Controls.Add(Me.But_Next)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "SetupWizard"
        Me.Text = "IQBox Setup Wizard"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.FinalPage.ResumeLayout(False)
        Me.FinalPage.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents But_Next As System.Windows.Forms.Button
    Friend WithEvents But_Prev As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FinalPage As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label_sdfsd As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Rad_Custom As System.Windows.Forms.RadioButton
    Friend WithEvents Rad_MyDocs As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents But_Browse As System.Windows.Forms.Button
    Friend WithEvents Combo_IQBFolder As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents But_TestConn As System.Windows.Forms.Button
    Friend WithEvents TB_Server As System.Windows.Forms.TextBox
    Friend WithEvents TB_Username As System.Windows.Forms.TextBox
    Friend WithEvents TB_Password As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
End Class
