Imports Entidades

Public Class frmMain

    Public user As New User()
    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        mainController.showAbout()
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        mainController.showLogin()
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        mainController.exitApp()
    End Sub

    Private Sub RefrescarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefrescarToolStripMenuItem.Click
        Dim ctrller = New mainController()
        Dim response As String
        response = ctrller.validUserState(user)
        If response = "Sesión cerrada" Then
            statusTxt.Text = response
        Else
            statusTxt.Text = response
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctrller = New mainController()
        Dim response As String
        response = ctrller.validUserState(user)
        If response = "Sesión cerrada" Then
            statusTxt.Text = response
        Else
            statusTxt.Text = response
        End If
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        user.state = False
        Dim ctrller = New mainController()
        Dim response As String
        response = ctrller.validUserState(user)
        If response = "Sesión cerrada" Then
            statusTxt.Text = response
        Else
            statusTxt.Text = response
        End If
    End Sub
End Class
