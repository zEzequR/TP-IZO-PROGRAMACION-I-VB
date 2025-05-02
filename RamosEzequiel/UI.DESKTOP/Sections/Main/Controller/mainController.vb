Imports Entidades
Imports Negocio

Public Class mainController

    Public Shared Sub showAbout()
        Dim aboutForm As New frmAbout()
        aboutForm.user = frmMain.user
        aboutForm.ShowDialog()
    End Sub

    Public Shared Sub showLogin()
        Dim loginForm As New frmLogin()
        loginForm.user = frmMain.user
        loginForm.ShowDialog()
    End Sub

    Public Shared Sub exitApp()
        Dim result As DialogResult = MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Public Function validUserState(user As User) As String
        Dim response As Boolean
        response = userService.validUserState(user)
        If response = False Then
            Return "Sesión cerrada"
        Else
            Return "Bienvenido " & user.username
        End If
    End Function
End Class
