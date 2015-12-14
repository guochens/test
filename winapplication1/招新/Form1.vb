Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label_login.Text = "欢迎使用！"
        Button_login.Text = "登录"
    End Sub

    Private Sub Button_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_login.Click
        If TextBox_login.Text <> "" Then
            sql("select * from newmember where 学号=" & TextBox_login.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()

    End Sub
End Class
