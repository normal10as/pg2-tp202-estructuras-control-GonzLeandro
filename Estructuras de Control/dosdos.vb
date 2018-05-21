Module dosdos
    Sub main()
        Dim a, b, c As Int16
        Console.WriteLine("Ingrese un numero: ")
        a = Console.readline()
        Console.WriteLine("Ingrese un numero: ")
        b = Console.ReadLine()
        Console.WriteLine("Ingrese un numero: ")
        c = Console.ReadLine()

        If a < b And a < c Then
            Console.WriteLine("El numero {0} es el menor numero.", a)
        ElseIf b < c Then
            Console.WriteLine("El numero {0} es el menor numero.", b)
        ElseIf c Then
            Console.WriteLine("El numero {0} es el menor numero.", c)
        End If

        Console.ReadKey()
    End Sub
End Module
