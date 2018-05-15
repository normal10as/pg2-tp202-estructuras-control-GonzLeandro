Module dosonce
    Sub main()
        Dim num As Integer = 1
        Dim par As Integer = 0
        Dim impar As Integer = 0
        Dim cont As Integer = 0

        Do While num <> 0
            Console.WriteLine("ingrese un numero")
            num = Console.ReadLine()

            If num > 0 Then
                cont += 1
                If num Mod 2 = 0 Then
                    par += 1
                    Console.WriteLine("el numero es par")
                Else
                    impar += 1
                    Console.WriteLine("el numero es impar")
                End If
            End If
        Loop

        Console.ReadKey()
    End Sub

End Module
