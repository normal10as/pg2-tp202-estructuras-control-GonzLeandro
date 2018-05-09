Module dosuno

    Sub Main()
        Dim a, b As Int16
        Console.WriteLine("Ingrese el Primer numero: ")
        a = Console.ReadLine()
        Console.WriteLine("Ingrese el Segundo numero: ")
        b = Console.ReadLine()
        If a > b Then
            Console.WriteLine("El Numero {0} es mayor que el Numero {1}", a, b)
        ElseIf b > a Then
            Console.WriteLine("El Numero {0} es mayor que el Numero {1}", b, a)
        Else
            Console.WriteLine("Los numeros son iguales.")
        End If
        Console.ReadKey()
    End Sub

End Module
