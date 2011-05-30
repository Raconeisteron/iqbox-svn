Module ExtraCode
    Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer

    Private Declare Function GetVolumeInformation Lib "kernel32" Alias "GetVolumeInformationA" _
        (ByVal lpRootPathName As String, _
        ByVal lpVolumeNameBuffer As String, _
        ByVal nVolumeNameSize As Int32, _
        ByRef lpVolumeSerialNumber As System.UInt32, _
        ByRef lpMaximumComponentLength As Int32, _
        ByRef lpFileSystemFlags As Int32, _
        ByVal lpFileSystemNameBuffer As String, _
        ByVal nFileSystemNameSize As Int32) As Int32


    Function GetVar(ByRef Section As String, ByRef KeyName As String, ByRef INIfile As String) As String

        Dim Valid, Size As Short
        Dim lpReturnString, lpKeyName, lpAppName, lpDefault, lpFileName As String

        lpFileName = INIfile
        lpAppName = Section
        lpKeyName = KeyName
        lpDefault = ""
        'Changed here to let it return a higher value.
        lpReturnString = Space(2048)
        Size = Len(lpReturnString)

        Valid = GetPrivateProfileString(lpAppName, lpKeyName, lpDefault, lpReturnString, Size, lpFileName)

        lpReturnString = Trim(lpReturnString)
        lpReturnString = Mid(lpReturnString, 1, Len(lpReturnString) - 1)

        'Check if no value was found. If so return ""
        'If InStr(1, lpReturnString$, Chr(0)) <> 0 Then
        '   GetVar = ""
        'Else
        GetVar = lpReturnString
        'End If


    End Function

    Function GetPCSigniture() As String
        Dim drvserial As System.UInt32
        Dim mydrvlabel As String = Space$(200)
        Dim myfilesys As String = Space$(200)
        Dim i As Int32
        Dim j As Int32
        Dim x As Int32

        Try
            x = GetVolumeInformation("C:\", mydrvlabel, 200, drvserial, i, j, myfilesys, 200)
        Catch ex As Exception
            drvserial = "9090909"
        End Try
        Return drvserial
        'MsgBox(myfilesys)

    End Function

End Module
