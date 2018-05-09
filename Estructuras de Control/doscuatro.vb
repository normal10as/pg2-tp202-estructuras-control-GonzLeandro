Module doscuatro
    Sub main()
        Dim cant As Int16
        Dim pre, total As Single

        Console.WriteLine("Ingrese la Cantidad del producto: ")
        cant = Console.ReadLine()
        Console.WriteLine("Ingrese el Precio unitario del producto: ")
        pre = Console.ReadLine()

        If cant >= 10 And cant <= 50 Then
            total = (cant * pre) - (cant * pre) * 0.05
            Console.WriteLine("El precio total es: " & total)
        ElseIf cant >= 51 And cant <= 250 Then
            total = (cant * pre) - (cant * pre) * 0.1
            Console.WriteLine("El precio total es: " & total)
        ElseIf cant >= 251 Then
            total = (cant * pre) - (cant * pre) * 0.2
            Console.WriteLine("El precio total es: " & total)
        Else
            total = (cant * pre)
            Console.WriteLine("El precio total es: " & total)
        End If

        Console.ReadKey()
    End Sub
End Module
