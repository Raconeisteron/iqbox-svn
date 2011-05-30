Public Class SetupWizard

    Private Sub Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_Next.Click

        Select Case TabControl1.SelectedIndex
            Case 3
                Dim path As String
                If Rad_Custom.Checked Then
                    path = Combo_IQBFolder.Text
                Else
                    path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\IQBox"
                End If
                IQBoxForm.Show()
                Me.Close()
                Application.DoEvents()
                Me.Hide()
                Application.DoEvents()
                Application.DoEvents()
                Application.DoEvents()
                IQBoxForm.Setup(TB_Username.Text, TB_Password.Text, TB_Server.Text, path)

            Case Else

        End Select


        Try
            TabControl1.SelectedIndex += 1
        Catch ex As Exception

        End Try

        
    End Sub

    Private Sub But_Prev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_Prev.Click
        Try
            TabControl1.SelectedIndex -= 1
        Catch ex As Exception

        End Try

    End Sub

    Private Sub But_TestConn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_TestConn.Click
        MsgBox("Not implemented")
        'MsgBox("Server response: " + IQBoxForm.RunSVN("status"))
    End Sub


    Private Sub SetupWizard_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub

  
    Private Sub SetupWizard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FolderBrowserDialog1.HelpRequest

    End Sub

    Private Sub But_Browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_Browse.Click
        FolderBrowserDialog1.ShowDialog()
        Combo_IQBFolder.Text = FolderBrowserDialog1.SelectedPath
        Rad_Custom.Checked = True
    End Sub

    Private Sub Combo_IQBFolder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combo_IQBFolder.Click
        Rad_Custom.Checked = True
    End Sub


    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub
End Class