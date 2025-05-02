Imports System.ComponentModel
Imports Entidades

Public Class frmLogin

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property user As User

    Private Sub sumbitBtn_Click(sender As Object, e As EventArgs) Handles sumbitBtn.Click
        loginController.isUserValid(user, userInp, passwrdInp)
        If user.state = True Then
            Me.Close()
        End If
    End Sub
End Class