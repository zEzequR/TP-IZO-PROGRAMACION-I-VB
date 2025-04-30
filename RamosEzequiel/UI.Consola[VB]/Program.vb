Imports System
Imports System.Threading

Module Program
    Sub Main(args As String())
        Dim username As String = "admin"
        Dim password As String = "admin"
        Dim trys As Integer = 3
        Dim userInp As String
        Dim passwrdInp As String
        Dim retryOpc As Char

        Console.WriteLine("Sistema IZO")
        Console.WriteLine("Ingrese su usuario: ")
        userInp = Console.ReadLine()
        Console.WriteLine("Ingrese su contraseña: ")
        passwrdInp = Console.ReadLine()
        While (userInp <> username Or passwrdInp <> password) And trys > 0
            trys -= 1
            If trys = 0 Then
                Console.Clear()
                Console.WriteLine("No tiene más intentos, ¿Desea reintentar? (S/N)")
                retryOpc = Console.ReadKey().KeyChar
                While Char.ToUpper(retryOpc) <> "S" And Char.ToUpper(retryOpc) <> "N"
                    Console.Clear()
                    Console.WriteLine("Opción no válida, intente nuevamente (S/N)")
                    retryOpc = Console.ReadKey().KeyChar
                End While
                If Char.ToUpper(retryOpc) = "S" Then
                    trys = 3
                    Console.Clear()
                Else
                    Environment.Exit(0)
                End If
            End If
            Console.Clear()
            Console.WriteLine("Usuario o contraseña incorrectos, intente nuevamente. Intentos restantes: " & trys)
            Console.WriteLine("Ingrese su usuario: ")
            userInp = Console.ReadLine()
            Console.WriteLine("Ingrese su contraseña: ")
            passwrdInp = Console.ReadLine()
        End While
        Console.Clear()
        Console.WriteLine("Sesión iniciada con éxito, bienvenido " & userInp & "!")
        Environment.Exit(0)

    End Sub
End Module
