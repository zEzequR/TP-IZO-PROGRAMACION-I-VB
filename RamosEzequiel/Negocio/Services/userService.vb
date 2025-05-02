Imports Entidades

Public Class userService

    Public Shared Function validUserState(user As User) As Boolean
        If user.state = False Then
            Return False
        Else
            Return True
        End If
    End Function
End Class
