Module doscuatro
    Sub main()
        Dim cant As Int16
        Dim pre, total As Single

        Console.WriteLine("Ingrese la Cantidad del producto: ")
        cant = Console.ReadLine()
        Console.WriteLine("Ingrese el Precio unitario del producto: ")
        pre = Console.ReadLine()

        total = (cant * pre) - (cant * pre)

        If cant >= 10 And cant <= 50 Then
            Console.WriteLine("El precio total es: " & total * 0.05)
        ElseIf cant >= 51 And cant <= 250 Then
            Console.WriteLine("El precio total es: " & total * 0.1)
        ElseIf cant >= 251 Then
            Console.WriteLine("El precio total es: " & total * 0.2)
        Else
            total = (cant * pre)
            Console.WriteLine("El precio total es: " & total)
        End If

        Console.ReadKey()
    End Sub
End Module
