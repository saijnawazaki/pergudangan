Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Security.Cryptography
Module app
    Public APP_NAME As String = "Pergudangan"
    Public APP_VERSION As String = "V1.0 Beta"
    Public APP_TITLE As String = APP_NAME & " " & APP_VERSION

    <DllImport("kernel32")>
    Public Function GetPrivateProfileString(ByVal section As String, ByVal key As String, ByVal def As String, ByVal retVal As StringBuilder, ByVal size As Integer, ByVal filePath As String) As Integer
    End Function
    Public Function GetIniValue(section As String, key As String, filename As String, Optional defaultValue As String = "") As String
        Dim sb As New StringBuilder(500)
        If GetPrivateProfileString(section, key, defaultValue, sb, sb.Capacity, filename) > 0 Then
            Return sb.ToString
        Else
            Return defaultValue
        End If
    End Function
    Public Function GetHashMD5(theInput As String) As String

        Using hasher As MD5 = MD5.Create()    ' create hash object

            ' Convert to byte array and get hash
            Dim dbytes As Byte() =
                 hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))

            ' sb to create string from bytes
            Dim sBuilder As New StringBuilder()

            ' convert byte data to hex string
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n

            Return sBuilder.ToString().ToLower
        End Using

    End Function

    Public Function parsedate_now()
        Dim uTime As Int64
        uTime = (DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
        uTime += (3600 * 7)
        Return uTime
    End Function
    Public Function parsedate(v_input As String)
        Dim uTime As Int64
        uTime = (DateTime.UtcNow - New DateTime(1970, 1, 1, 7, 0, 0)).TotalSeconds
        Return uTime
    End Function
End Module
