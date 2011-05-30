Public Class IQBoxForm

    'Dim sTorPath As String = "C:\Program Files\TortoiseSVN\bin\TortoiseProc.exe"
    Dim svnPath As String = "bin\svn.exe"
    Dim DestF As String
    Dim PCSig As String = ""
    Dim RemoteRepo, Username As String
    Dim UseTrunk As Boolean = False
    Dim doSync As Boolean = False
    Dim lastSyncTime As Date
    Dim defCheckInterval As Long = 45000
    Dim Password As String
    Dim nextsync As Date = Now

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadSettings()

        ComboBox1.Text = DestF
        'DestF = My.Settings.DestFolder

        lastSyncTime = Now

        svnPath = """" + App_Path() + "bin\svn.exe" + """"

        If Command() = "start" Then
            SendToTray()
            But_SyncStart_Click(Nothing, Nothing)
        End If

        If PCSig <> GetPCSigniture() Then
            SetupWizard.ShowDialog()
            SaveSettings()
        End If

        'Dim s As String = ShellInput(App_Path() + "bin\svn.exe", "--help", App_Path() + "bin")

       
        ' add the handler to each event 
        AddHandler FileSystemWatcher1.Changed, AddressOf logchange
        AddHandler FileSystemWatcher1.Created, AddressOf logchange
        AddHandler FileSystemWatcher1.Deleted, AddressOf logchange

        AddHandler FileSystemWatcher1.Renamed, AddressOf logRename



    End Sub
    Sub SaveSettings()
        Dim ini As New IniFile(App_Path() + "Settings.ini")
        ini.WriteString("General", "IQBoxFolder", DestF)
        ini.WriteString("General", "Server", RemoteRepo)
        ini.WriteString("General", "PCSig", GetPCSigniture)

        ini.WriteString("General", "Username", Username)
        ini.WriteString("General", "Password", Password)

    End Sub

    Sub LoadSettings()
        Dim f As String = App_Path() + "Settings.ini"
        DestF = GetVar("General", "IQBoxFolder", f)
        RemoteRepo = GetVar("General", "Server", f)
        Username = GetVar("General", "Username", f)
        PCSig = GetVar("General", "PCSig", f)
        Password = GetVar("General", "Password", f)

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Update()
    End Sub
    Sub SetStatus(ByVal msg As String)
        'StatusStrip1.Items.Clear()
        'StatusStrip1.Items.Add(msg)
        Label_MainStatus.Text = msg
        NotifyIcon.Text = msg
    End Sub

    Function GetCPUPercent(Optional ByVal takeBigSample As Boolean = False) As Integer
        Dim myCounter As System.Diagnostics.PerformanceCounter = New System.Diagnostics.PerformanceCounter()

        myCounter.CategoryName = "Processor"
        myCounter.CounterName = "% Processor Time"
        myCounter.InstanceName = "_Total"
        Dim ret1 As Integer = CInt(myCounter.NextValue())

        Dim retf As Integer = ret1
        If takeBigSample Then
            System.Threading.Thread.Sleep(100)
            Application.DoEvents()
            System.Threading.Thread.Sleep(100)
            Application.DoEvents()
            System.Threading.Thread.Sleep(100)
            Application.DoEvents()
            System.Threading.Thread.Sleep(100)
            Application.DoEvents()
            System.Threading.Thread.Sleep(100)
            Application.DoEvents()

            Dim ret2 As Integer = CInt(myCounter.NextValue())
            retf = CInt((ret1 + ret2) / 2)
        End If

        Return retf 'cpu usage
    End Function

    Sub Update()



    End Sub

    Sub Setup(ByVal user As String, ByVal pass As String, ByVal server As String, ByVal iqbPath As String)
        'svn checkout http://tortoisesvn.googlecode.com/svn/trunk/ tortoisesvn-read-only
        'RunSVN("/command:checkout /path:https://subversion.assembla.com/svn/simonpersonal/")
        'RunSVN("checkout --username  --password shipit svn://opteron1/svn-repo")
        'filaprize https://subversion.assembla.com/svn/simonpersonal/

        'My.Settings.DestFolder = ComboBox1.Text
        'My.Settings.Save()

        Activate()
        Application.DoEvents()

        Dim ini As New IniFile(App_Path() + "Settings.ini")
        ini.WriteString("General", "IQBoxFolder", iqbPath)
        ini.WriteString("General", "Server", server)
        ini.WriteString("General", "Username", user)
        DestF = iqbPath

        If DestF = "" Then
            MsgBox("Folder name is blank. Please run the setup wizard again!")
            Exit Sub
        End If
        
        Try
            MkDir(DestF)
        Catch ex As Exception
            Dim res As Integer
            res = MsgBox("Couldn't create the folder. It may exist. If so, when you sync, any files in that folder may be replaced or deleted if they exist in your IQBox already. (If this is a new, empty IQBox, don't worry.) Are you sure you want to continue?", vbYesNoCancel)
            If res <> vbYes Then
                Exit Sub
            End If
        End Try

        'Dot specifies to checkout to current dir
        Dim cc As String = "checkout --username " + user + " --password " + pass + " " + server + " ."
        If UseTrunk Then
            cc += "trunk/"
        End If
        Log(">>> Initial sync in progress...")
        SetStatus("Performing your initial sync. This could take time.")
        Dim res2 As String = RunSVN(cc, False)
        If res2.Contains("access to") And res2.Contains(" forbidden") Then
            SetStatus("FAILED to sync: Bad username, password or server.")
            Log(">>> FAILED to sync: Bad username, password or server.")
        Else
            SetStatus("Finished initial sync at " + Date.Now.ToLongTimeString)
            Log(">>> Completed initial sync!")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        'Setup()
    End Sub



    Public Function RunSVN(ByVal cmd As String, Optional ByVal fromTrunk As Boolean = True) As String
        If fromTrunk AndAlso UseTrunk Then
            ChDir(DestF + "/trunk")
        Else
            ChDir(DestF)
        End If
        'Dim s As String
        Dim ccc As String = vbCrLf + svnPath + " " + cmd + vbCrLf

        Dim outBat As String = WriteBatchFileUnique(ccc)
        Dim res As String = ShellInput(outBat, "", DestF, True, ProcessPriorityClass.BelowNormal)
        Try
            System.IO.File.Delete(outBat)
        Catch ex As Exception

        End Try

        
        Return res
    End Function

    Public Function WriteBatchFileUnique(ByVal BatchfileContentsString As String) As String
        Dim fn As String = GetTempFileWithExt("bat")
        My.Computer.FileSystem.WriteAllText(fn, BatchfileContentsString, False)
        Return fn
    End Function

    Public Function GetTempFileWithExt(ByVal ext As String) As String
        Dim filename As String
        Do
            Randomize()
            filename = System.IO.Path.Combine(System.IO.Path.GetTempPath, "tmp" + CInt(Rnd() * 2147483647).ToString + CInt(Rnd() * 2147483647).ToString + "." + ext)
        Loop While System.IO.File.Exists(filename)

        Return filename

    End Function

    Public Function GetTempDirectory() As String
        Dim mpath As String
        Do
            mpath = System.IO.Path.Combine(System.IO.Path.GetTempPath, System.IO.Path.GetRandomFileName)
        Loop While System.IO.Directory.Exists(mpath) Or System.IO.File.Exists(mpath)
        System.IO.Directory.CreateDirectory(mpath)
        Return mpath
    End Function


    Private Sub OpenFolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFolderToolStripMenuItem.Click
        OpenFolder()
    End Sub

    Private Sub OpenFolder()
        Shell("explorer.exe /e, " + DestF + "\", vbNormalFocus)
    End Sub


    Sub ResetTimer(ByVal interval As Integer)
        Timer1.Enabled = False
        'Timer1.Interval = 0
        Timer1.Interval = interval
        Timer1.Enabled = True
        Timer_Counter.Enabled = False
        Timer_Counter.Enabled = True
        nextSync = DateAdd(DateInterval.Second, interval / 1000, Now)
    End Sub

    Private Sub But_SyncStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_SyncStart.Click
        If doSync Then
            Timer1.Enabled = False
            Timer_Counter.Enabled = False
            FileSystemWatcher1.EnableRaisingEvents = False
            doSync = False
            But_SyncStart.Text = "Turn On Automatic Synchronization"
            But_SyncStart.Image = Image.FromFile(App_Path() + "images\syncoff.png")
            Exit Sub
        End If

        But_SyncStart.Image = Image.FromFile(App_Path() + "images\syncon.png")

        ResetTimer(Timer1.Interval)

        FileSystemWatcher1.Path = DestF + "\"
        ' add the rename handler as the signature is different AddHandler FileSystemWatcher1.Renamed, AddressOf logrename

        'you use OR for each Filter as we need to all of those
        FileSystemWatcher1.NotifyFilter = IO.NotifyFilters.DirectoryName
        FileSystemWatcher1.NotifyFilter = FileSystemWatcher1.NotifyFilter Or IO.NotifyFilters.FileName
        FileSystemWatcher1.NotifyFilter = FileSystemWatcher1.NotifyFilter Or IO.NotifyFilters.DirectoryName
        FileSystemWatcher1.NotifyFilter = FileSystemWatcher1.NotifyFilter Or IO.NotifyFilters.Attributes

        FileSystemWatcher1.EnableRaisingEvents = True
        doSync = True
        But_SyncStart.Text = "Synchronization ON. Click to turn it off."

    End Sub

    Function ShellInput(ByVal cmd As String, ByVal args As String, ByVal workingDir As String, _
                        Optional ByVal doAddStdErr As Boolean = False, _
                        Optional ByVal PriorityLevel As ProcessPriorityClass = ProcessPriorityClass.Normal)
        Dim sh As New ShellProcessClass
        sh.Setup(cmd, args, workingDir, doAddStdErr, PriorityLevel)
        Dim th As New System.Threading.Thread(AddressOf sh.Begin)

        th.Start()
        Dim output As String = ""
        Dim nextText As String = ""
        Do
            Application.DoEvents()
            nextText = sh.ReadMoreOutput
            If nextText <> "" Then Log(nextText, False)
            output += nextText
            Application.DoEvents()
        Loop Until sh.isFinished

        output += sh.ReadMoreOutput
        Return output

    End Function
    Private Sub logRename(ByVal Source As Object, ByVal e As System.IO.RenamedEventArgs)


        If e.FullPath.Contains(".svn") Then
            Exit Sub
        End If
        ActivateAfterFileChange()

        Dim relPathOld As String = getRelPathFromFullPath(e.FullPath)
        Dim relPathNew As String = getRelPathFromFullPath(e.OldFullPath)
        'RunSVN("copy ""file://" + relPathOld + """ ""file://" + relPathNew + """ -m --force-log")
        'RunSVN("move """ + relPathOld + """ """ + relPathNew + """")
        'RunSVN("-m --force-log """ + relPathNew + """")
        'RunSVN("-m --force-log """ + relPathOld + """")

    End Sub

    Private Function getRelPathFromFullPath(ByVal fullPath) As String
        Dim relPath As String
        relPath = Replace(fullPath, DestF + "\", "", 1, 1)
        Return relPath
    End Function

    Private Sub ActivateAfterFileChange()
        If doSync And Timer1.Enabled Then

            Label_ChangeDetected.Text = "Files have changes. Syncing shortly..."

            Dim newTime As Date = Now

            ' You can also determine the difference in times in other units.
            Dim differenceInSeconds As Long = DateDiff(DateInterval.Second, lastSyncTime, newTime)

            'Our goal is to sync 10 seconds after a change to the file system.
            'In the event there are more and more changes, we keep delaying until the changes
            'are completed (ex: copying 1 large file in chunks means we get several change notices)
            'But if it keeps changing for 25 mins, we are going to start
            'syncing anyhow
            If differenceInSeconds < 60 * 25 Then
                ResetTimer(30000)
                'Timer1.Enabled = False
                'Timer1.Interval = 30000
                'Timer1.Start()
                'Timer1.Enabled = True

            End If
        End If
    End Sub

    Private Sub logchange(ByVal source As Object, ByVal e As  _
                          System.IO.FileSystemEventArgs)

        If e.FullPath.Contains(".svn") Then
            Exit Sub
        End If
        ActivateAfterFileChange()


        Dim relPath As String = getRelPathFromFullPath(e.FullPath)
        If e.ChangeType = IO.WatcherChangeTypes.Changed Then
            'txt_folderactivity.Text &= "File " & e.FullPath & _
            '                               " has been modified" & vbCrLf
        End If
        If e.ChangeType = IO.WatcherChangeTypes.Created Then
            'txt_folderactivity.Text &= "File " & e.FullPath & _
            '                                     " has been created" & vbCrLf
        End If
        If e.ChangeType = IO.WatcherChangeTypes.Deleted Then
            'RunSVN("delete --keep-local --force """ + relPath + """")
            ' txt_folderactivity.Text &= "File " & e.FullPath & _
            '                                                 " has been deleted" & vbCrLf
        End If
    End Sub

    Shared Function App_Path() As String
        Return System.AppDomain.CurrentDomain.BaseDirectory()
    End Function

    Public Sub Log(ByVal msg As String, Optional ByVal addNewLine As Boolean = True)
        If Text_Log.TextLength > 15000 Then
            Text_Log.Text = "(Log truncated to fit in window.)" + vbCrLf + Microsoft.VisualBasic.Left(Text_Log.Text, 10000)
        End If
        Text_Log.AppendText(msg)
        If addNewLine Then
            Text_Log.AppendText(vbCrLf)
        End If
        Text_Log.SelectionStart = Text_Log.TextLength
        Text_Log.ScrollToCaret()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim Skips As Integer = 0

        If GetCPUPercent(False) > 75 Then
            If Skips >= 250 Then
                'If you are playing a game then you want utmost performance... Skip the sync
                'But after doing this 250 times, (about 2 hours) it is clear that we
                'need to sync at least once.
                Skips = 0
            Else
                Log("High CPU, skipping sync")
                Skips += 1
                Exit Sub
            End If
        End If


        Timer1.Enabled = False
        Timer_Counter.Enabled = False

        lastSyncTime = Now

        Label_ChangeDetected.Text = ""

        SetStatus("Processing new files...")
        Log(">>> Processing new files...")
        RunSVN("add --username=" + Username + " --password=" + Password + " --force *")

        If UseTrunk Then
            ChDir(DestF + "/trunk")
        Else
            ChDir(DestF)
        End If

        SetStatus("Processing deleted files...")
        Log(">>> Processing deleted files...")
        Dim p As String = App_Path() + "genDel.bat"
        Dim batFile As System.Text.StringBuilder = New System.Text.StringBuilder(My.Computer.FileSystem.ReadAllText(p))
        batFile.Replace("!!!SVN!!!", svnPath)
        batFile.Replace("!!!AWK!!!", App_Path() + "bin\awk.exe")
        batFile.Replace("!!!USERNAME!!!", Username)
        batFile.Replace("!!!PASSWORD!!!", Password)

        Dim batText As String = batFile.ToString

        Dim outBat As String = System.IO.Path.GetTempPath() + "genDel.bat"
        My.Computer.FileSystem.WriteAllText(outBat, batText, False)

        Dim res As String = ShellInput(outBat, "", DestF, True, ProcessPriorityClass.BelowNormal)

        Dim fileContents As String
        Dim pa = System.IO.Path.GetTempPath() + "toDeleteSVN.txt"
        fileContents = My.Computer.FileSystem.ReadAllText(pa)
        Dim ar() As String = Split(fileContents, vbCrLf)

        For Each l In ar
            l = Trim(l)
            If l = "" Then Continue For
            If l = "." Then Continue For
            RunSVN("delete --keep-local --force """ + l + """")
        Next

        SetStatus("Uploading and syncing online files...")
        Log(">>> Uploading and syncing online files...")
        RunSVN("commit -m --force-log --username=" + Username + " --password=" + Password)

        SetStatus("Checking and downloading new files and changes...")
        Log(">>> Checking and downloading new files and changes...")
        RunSVN("update --username=" + Username + " --password=" + Password)

        SetStatus("A sync operation ended at " + Date.Now.ToLongTimeString())

        If doSync Then
            ResetTimer(defCheckInterval)
        End If


    End Sub

    Private Sub SyncNowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SyncNowToolStripMenuItem.Click
        Timer1_Tick(Nothing, Nothing)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

    End Sub

    Private Sub OpenIQBoxProgramFolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenIQBoxProgramFolderToolStripMenuItem.Click
        Shell("explorer.exe /e, " + App_Path(), vbNormalFocus)
    End Sub

    Private Sub LinkViewLog_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkViewLog.LinkClicked
        If LinkViewLog.Text.Contains("View") Then
            Me.Height = 357
            LinkViewLog.Text = "Hide Log <<"
            Label_SyncLog.Visible = True
            Link_ClearLog.Visible = True
            Link_CopyLog.Visible = True
        Else
            Me.Height = 222
            LinkViewLog.Text = "View Log >>"
            Label_SyncLog.Visible = False
            Link_ClearLog.Visible = False
            Link_CopyLog.Visible = False
        End If

    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            'Me.Hide()
            'NotifyIcon.Visible = True
        End If
    End Sub

    Private Sub NotifyIcon_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon.MouseClick
        Me.Show()
        NotifyIcon.Visible = False
        Me.Activate()
    End Sub

    Private Sub NotifyIcon_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon.MouseDoubleClick

    End Sub

    Sub SendToTray()
        Me.Hide()
        NotifyIcon.Visible = True
    End Sub

    Private Sub SendToTrayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendToTrayToolStripMenuItem.Click
        SendToTray()
    End Sub

    Private Sub Link_ClearLog_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Link_ClearLog.LinkClicked
        Text_Log.Clear()
    End Sub

    Private Sub Link_CopyLog_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Link_CopyLog.LinkClicked
        Clipboard.SetText(Text_Log.Text)
    End Sub

    Private Sub SetupWizardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetupWizardToolStripMenuItem.Click
        SetupWizard.ShowDialog()
    End Sub

    Private Sub But_StartSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_StartSetup.Click
        SetupWizard.ShowDialog()
    End Sub

    Private Sub CleanupFromInterruptedSyncSVNCleanupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CleanupFromInterruptedSyncSVNCleanupToolStripMenuItem.Click
        RunSVN("cleanup")
    End Sub

    Private Sub OpenSettingsINIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenSettingsINIToolStripMenuItem.Click
        Shell("inieditor """ + App_Path() + "\Settings.ini""", vbNormalFocus)
    End Sub

    Private Sub Label_LogClickTarget_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label_LogClickTarget.Click
        LinkViewLog_LinkClicked(Nothing, Nothing)
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Counter.Tick

        Dim secToSync = DateDiff(DateInterval.Second, nextsync, Now)
        Label_SecToSync.Text = "Sync in " + secToSync.ToString + "s"

    End Sub
End Class
