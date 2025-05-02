Imports System.ComponentModel
Imports Entidades

Public Class frmAbout
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property user As User
    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctrller = New mainController()
        Dim response As String
        response = ctrller.validUserState(user)
        If response = "Sesión cerrada" Then
            statusTxt.Text = response
        Else
            statusTxt.Text = response
        End If
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub
End Class