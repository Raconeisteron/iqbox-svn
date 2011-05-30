<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IQBoxForm
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IQBoxForm))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SetupWizardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdvancedOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CleanupFromInterruptedSyncSVNCleanupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenSettingsINIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SyncNowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenIQBoxProgramFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SendToTrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button5 = New System.Windows.Forms.Button
        Me.LinkViewLog = New System.Windows.Forms.LinkLabel
        Me.Text_Log = New System.Windows.Forms.TextBox
        Me.Timer_Counter = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Label_SyncLog = New System.Windows.Forms.Label
        Me.Link_ClearLog = New System.Windows.Forms.LinkLabel
        Me.Link_CopyLog = New System.Windows.Forms.LinkLabel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label_LogClickTarget = New System.Windows.Forms.Label
        Me.But_StartSetup = New System.Windows.Forms.Button
        Me.But_SyncStart = New System.Windows.Forms.Button
        Me.Label_MainStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.Label_SecToSync = New System.Windows.Forms.ToolStripStatusLabel
        Me.Label_ChangeDetected = New System.Windows.Forms.ToolStripStatusLabel
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(790, 45)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(558, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = "C:\IQBox"
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(787, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Folder to Watch"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(712, 113)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(712, 55)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Commit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(712, 84)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Set it up"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.OpenFolderToolStripMenuItem, Me.SyncNowToolStripMenuItem, Me.OpenIQBoxProgramFolderToolStripMenuItem, Me.SendToTrayToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(671, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetupWizardToolStripMenuItem, Me.AdvancedOptionsToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'SetupWizardToolStripMenuItem
        '
        Me.SetupWizardToolStripMenuItem.Name = "SetupWizardToolStripMenuItem"
        Me.SetupWizardToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.SetupWizardToolStripMenuItem.Text = "Setup Wizard"
        '
        'AdvancedOptionsToolStripMenuItem
        '
        Me.AdvancedOptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CleanupFromInterruptedSyncSVNCleanupToolStripMenuItem, Me.OpenSettingsINIToolStripMenuItem})
        Me.AdvancedOptionsToolStripMenuItem.Name = "AdvancedOptionsToolStripMenuItem"
        Me.AdvancedOptionsToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.AdvancedOptionsToolStripMenuItem.Text = "Advanced Options"
        '
        'CleanupFromInterruptedSyncSVNCleanupToolStripMenuItem
        '
        Me.CleanupFromInterruptedSyncSVNCleanupToolStripMenuItem.Name = "CleanupFromInterruptedSyncSVNCleanupToolStripMenuItem"
        Me.CleanupFromInterruptedSyncSVNCleanupToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.CleanupFromInterruptedSyncSVNCleanupToolStripMenuItem.Text = "Cleanup from Interrupted Sync (SVN Cleanup)"
        '
        'OpenSettingsINIToolStripMenuItem
        '
        Me.OpenSettingsINIToolStripMenuItem.Name = "OpenSettingsINIToolStripMenuItem"
        Me.OpenSettingsINIToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.OpenSettingsINIToolStripMenuItem.Text = "Open Settings Editor"
        '
        'OpenFolderToolStripMenuItem
        '
        Me.OpenFolderToolStripMenuItem.Name = "OpenFolderToolStripMenuItem"
        Me.OpenFolderToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.OpenFolderToolStripMenuItem.Text = "Open IQBox Folder"
        '
        'SyncNowToolStripMenuItem
        '
        Me.SyncNowToolStripMenuItem.Name = "SyncNowToolStripMenuItem"
        Me.SyncNowToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.SyncNowToolStripMenuItem.Text = "Sync Now"
        '
        'OpenIQBoxProgramFolderToolStripMenuItem
        '
        Me.OpenIQBoxProgramFolderToolStripMenuItem.Name = "OpenIQBoxProgramFolderToolStripMenuItem"
        Me.OpenIQBoxProgramFolderToolStripMenuItem.Size = New System.Drawing.Size(167, 20)
        Me.OpenIQBoxProgramFolderToolStripMenuItem.Text = "Open IQBox Program Folder"
        '
        'SendToTrayToolStripMenuItem
        '
        Me.SendToTrayToolStripMenuItem.Name = "SendToTrayToolStripMenuItem"
        Me.SendToTrayToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.SendToTrayToolStripMenuItem.Text = "Send to Tray"
        '
        'Timer1
        '
        Me.Timer1.Interval = 45000
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1221, 43)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Set"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'LinkViewLog
        '
        Me.LinkViewLog.AutoSize = True
        Me.LinkViewLog.Location = New System.Drawing.Point(588, 143)
        Me.LinkViewLog.Name = "LinkViewLog"
        Me.LinkViewLog.Size = New System.Drawing.Size(66, 13)
        Me.LinkViewLog.TabIndex = 8
        Me.LinkViewLog.TabStop = True
        Me.LinkViewLog.Text = "View Log >>"
        '
        'Text_Log
        '
        Me.Text_Log.Location = New System.Drawing.Point(0, 183)
        Me.Text_Log.Multiline = True
        Me.Text_Log.Name = "Text_Log"
        Me.Text_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Text_Log.Size = New System.Drawing.Size(671, 113)
        Me.Text_Log.TabIndex = 9
        '
        'Timer_Counter
        '
        Me.Timer_Counter.Interval = 900
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Label_MainStatus, Me.Label_SecToSync, Me.Label_ChangeDetected})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 162)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(671, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'NotifyIcon
        '
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "IQBox - Idle"
        '
        'Label_SyncLog
        '
        Me.Label_SyncLog.AutoSize = True
        Me.Label_SyncLog.Location = New System.Drawing.Point(0, 170)
        Me.Label_SyncLog.Name = "Label_SyncLog"
        Me.Label_SyncLog.Size = New System.Drawing.Size(91, 13)
        Me.Label_SyncLog.TabIndex = 11
        Me.Label_SyncLog.Text = "Sync Engine Log:"
        Me.Label_SyncLog.Visible = False
        '
        'Link_ClearLog
        '
        Me.Link_ClearLog.AutoSize = True
        Me.Link_ClearLog.Location = New System.Drawing.Point(117, 169)
        Me.Link_ClearLog.Name = "Link_ClearLog"
        Me.Link_ClearLog.Size = New System.Drawing.Size(45, 13)
        Me.Link_ClearLog.TabIndex = 12
        Me.Link_ClearLog.TabStop = True
        Me.Link_ClearLog.Text = "Clear All"
        Me.Link_ClearLog.Visible = False
        '
        'Link_CopyLog
        '
        Me.Link_CopyLog.AutoSize = True
        Me.Link_CopyLog.Location = New System.Drawing.Point(182, 169)
        Me.Link_CopyLog.Name = "Link_CopyLog"
        Me.Link_CopyLog.Size = New System.Drawing.Size(90, 13)
        Me.Link_CopyLog.TabIndex = 13
        Me.Link_CopyLog.TabStop = True
        Me.Link_CopyLog.Text = "Copy to Clipboard"
        Me.Link_CopyLog.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-17, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(763, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "_________________________________________________________________________________" & _
            "_____________________________________________"
        '
        'Label_LogClickTarget
        '
        Me.Label_LogClickTarget.Location = New System.Drawing.Point(572, 136)
        Me.Label_LogClickTarget.Name = "Label_LogClickTarget"
        Me.Label_LogClickTarget.Size = New System.Drawing.Size(99, 26)
        Me.Label_LogClickTarget.TabIndex = 16
        '
        'But_StartSetup
        '
        Me.But_StartSetup.Image = Global.IQBox.My.Resources.Resources.amor_3
        Me.But_StartSetup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.But_StartSetup.Location = New System.Drawing.Point(12, 53)
        Me.But_StartSetup.Name = "But_StartSetup"
        Me.But_StartSetup.Size = New System.Drawing.Size(116, 78)
        Me.But_StartSetup.TabIndex = 15
        Me.But_StartSetup.Text = "Setup IQBox for the First Time"
        Me.But_StartSetup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.But_StartSetup.UseVisualStyleBackColor = True
        '
        'But_SyncStart
        '
        Me.But_SyncStart.Image = Global.IQBox.My.Resources.Resources.network
        Me.But_SyncStart.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.But_SyncStart.Location = New System.Drawing.Point(156, 53)
        Me.But_SyncStart.Name = "But_SyncStart"
        Me.But_SyncStart.Size = New System.Drawing.Size(116, 78)
        Me.But_SyncStart.TabIndex = 2
        Me.But_SyncStart.Text = "Turn on Automatic Synchronization"
        Me.But_SyncStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.But_SyncStart.UseVisualStyleBackColor = True
        '
        'Label_MainStatus
        '
        Me.Label_MainStatus.Name = "Label_MainStatus"
        Me.Label_MainStatus.Size = New System.Drawing.Size(0, 17)
        '
        'Label_SecToSync
        '
        Me.Label_SecToSync.Name = "Label_SecToSync"
        Me.Label_SecToSync.Size = New System.Drawing.Size(0, 17)
        '
        'Label_ChangeDetected
        '
        Me.Label_ChangeDetected.Name = "Label_ChangeDetected"
        Me.Label_ChangeDetected.Size = New System.Drawing.Size(0, 17)
        '
        'IQBoxForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 184)
        Me.Controls.Add(Me.But_StartSetup)
        Me.Controls.Add(Me.Link_CopyLog)
        Me.Controls.Add(Me.Link_ClearLog)
        Me.Controls.Add(Me.Label_SyncLog)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Text_Log)
        Me.Controls.Add(Me.LinkViewLog)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.But_SyncStart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label_LogClickTarget)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "IQBoxForm"
        Me.Text = "IQBox"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents But_SyncStart As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpenFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SyncNowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents OpenIQBoxProgramFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Text_Log As System.Windows.Forms.TextBox
    Friend WithEvents LinkViewLog As System.Windows.Forms.LinkLabel
    Friend WithEvents Timer_Counter As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents SendToTrayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Link_CopyLog As System.Windows.Forms.LinkLabel
    Friend WithEvents Link_ClearLog As System.Windows.Forms.LinkLabel
    Friend WithEvents Label_SyncLog As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetupWizardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents But_StartSetup As System.Windows.Forms.Button
    Friend WithEvents AdvancedOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CleanupFromInterruptedSyncSVNCleanupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenSettingsINIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label_LogClickTarget As System.Windows.Forms.Label
    Friend WithEvents Label_MainStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label_SecToSync As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label_ChangeDetected As System.Windows.Forms.ToolStripStatusLabel

End Class
