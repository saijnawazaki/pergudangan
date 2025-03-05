Imports System.Security.Cryptography
Imports System.Text
Public Class frm_login
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = APP_TITLE
        'Debug.WriteLine(GetIniValue("APP", "name", My.Application.Info.DirectoryPath & "\pergudangan.ini"))

        'dg_test.DataSource = getDataToDataGrid("select * from [user]")

    End Sub


    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        
        Debug.WriteLine(tb_username.Text)
        Debug.WriteLine(tb_password.Text)
        Debug.WriteLine(GetHashMD5(tb_password.Text))
        Dim reader = getSoloRowData("select * from [user] where username = 'admin'")

        While reader.Read()
            Debug.WriteLine(reader("username").ToString())
        End While


        If tb_username.Text = "" Or tb_password.Text = "" Then
            MsgBox("Username / Password Empty", MsgBoxStyle.Critical, APP_TITLE)
        Else
            Dim row = getSoloData("select count(*) as jumlah from [user] where username = '" & tb_username.Text & "' and password = '" & GetHashMD5(tb_password.Text) & "'")
            If (row = 0) Then
                MsgBox("Username / Password Invalid", MsgBoxStyle.Critical, APP_TITLE)
            Else
                'MsgBox("OK", MsgBoxStyle.Information, APP_TITLE)
                main_menu.Show()
                Me.Close()
            End If
        End If
    End Sub
End Class
