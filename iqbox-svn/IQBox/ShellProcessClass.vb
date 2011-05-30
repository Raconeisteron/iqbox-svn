Public Class ShellProcessClass

    Dim mcmd, margs, mworkingdir, mdoAddStdErr, mPriorityLevel, mProcessPriorityClass As String
    Dim output As String = ""
    Dim isdone As Boolean = False
    Dim lastPos As Long = 0

    Function isFinished() As Boolean
        Return isdone
    End Function

    Function GetEntireOutput()

        Do Until isFinished()
            Application.DoEvents()
        Loop

        Return output
    End Function

    Function ReadMoreOutput() As String
        Dim s As String = output
        Dim nextLast As Long = s.Length
        s = s.Substring(lastPos)
        lastPos = nextLast
        Return s
    End Function

    Sub Setup(ByVal cmd As String, ByVal args As String, ByVal workingDir As String, _
                        Optional ByVal doAddStdErr As Boolean = False, _
                        Optional ByVal PriorityLevel As ProcessPriorityClass = ProcessPriorityClass.Normal)

        mcmd = cmd
        margs = args
        mworkingdir = workingDir
        mdoAddStdErr = doAddStdErr
        mPriorityLevel = PriorityLevel
        mProcessPriorityClass = PriorityLevel

    End Sub

    Sub Begin()
        isdone = False
        Dim process As New Process()
        Dim FileName As String = mcmd
        Dim Arguments As String = margs
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.StartInfo.RedirectStandardError = True
        process.StartInfo.CreateNoWindow = True
        process.StartInfo.FileName = FileName
        process.StartInfo.Arguments = Arguments
        process.StartInfo.WorkingDirectory = mworkingdir
        'Dim output As String = ""

        Application.DoEvents()

        Try
            process.Start()
        Catch ex As Exception
            Dim ee = "Error: " + ex.Message
        End Try
        Try
            process.PriorityClass = mPriorityLevel
        Catch ex As Exception
            'Do nothing... Sometimes the process exits so fast that there's no time for this!
        End Try
        Application.DoEvents()
        Dim line As String
        Do Until process.StandardOutput.EndOfStream
            'Application.DoEvents()
            'System.Threading.Thread.Sleep(250)
            Application.DoEvents()
            Try
                Dim outS As String = ""
                Dim cc As Integer = 0
                Do Until process.StandardOutput.Peek < 0
                    outS += Chr(process.StandardOutput.Read)
                    cc += 1
                    If cc Mod 10 = 0 Then
                        Application.DoEvents()
                        If cc > 200000 Then cc = 0
                    End If
                Loop
                Application.DoEvents()
                'Log(outS, False)
                output += outS
            Catch ex As Exception

            End Try
            'Dim stderr As String = process.StandardError.ReadToEnd()
        Loop


        If mdoAddStdErr Then
            output += " {" + process.StandardError.ReadToEnd + "}"
        End If

        isdone = True
        'Return output
    End Sub
End Class
