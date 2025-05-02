Imports Entidades

Public Class loginController

    Shared trys As Integer = 3

    Public Shared Function isUserValid(user As User, userInp As TextBox, passwrdInp As TextBox) As MsgBoxResult
        Dim userInput = userInp.Text
        Dim passwrdInput = passwrdInp.Text
        If userInput = user.username And passwrdInput = user.password And (Not String.IsNullOrEmpty(userInput) Or Not String.IsNullOrEmpty(passwrdInput)) Then
            MsgBox("Sesión Iniciada con éxito, bienvenido " & userInput & "!", MsgBoxStyle.MsgBoxRight, "Sesión iniciada")
            user.state = True
            Return MsgBoxResult.Ok
        ElseIf (String.IsNullOrEmpty(userInput) Or String.IsNullOrEmpty(passwrdInput)) Then
            MsgBox("Usuario y/o contraseña vacíos. Por favor, ingrese sus credenciales.", MsgBoxStyle.Critical, "Credencial/es vacías")
            userInp.Clear()
            passwrdInp.Clear()
            userInp.Focus()
            Return MsgBoxResult.Retry
        Else
            trys -= 1
            MsgBox("Usuario y/o contraseña invalido/s. Intentos restantes: " & trys, MsgBoxStyle.Critical, "Credenciales incorrectas")
            userInp.Clear()
            passwrdInp.Clear()
            userInp.Focus()
            If trys = 0 Then
                MsgBox("Número máximo de intentos, usuario bloqueado. Saliendo de la aplicación.", MsgBoxStyle.Exclamation, "Usuario bloqueado")
                Application.Exit()
            End If
            Return MsgBoxResult.Retry
        End If
    End Function

End Class
