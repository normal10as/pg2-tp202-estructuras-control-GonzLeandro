Module doscatorce
    Sub main()
        Dim cant As Int16
        Dim pre, total As Single

        Console.WriteLine("Ingrese la Cantidad del producto: ")
        cant = Console.ReadLine()
        Console.WriteLine("Ingrese el Precio unitario del producto: ")
        pre = Console.ReadLine()

        If cant >= 10 And cant <= 50 Then
            total = (cant * pre) - (cant * pre) * 0.05
            Console.WriteLine("El precio de cada unidad es: {0}$", pre)
            Console.WriteLine("El subtotal es de: {0}", cant * pre)
            Console.WriteLine("El descuento aplicado es de: {0}$", (cant * pre) * 0.05)
            Console.WriteLine("El precio total es: {0}$", total)

        ElseIf cant >= 51 And cant <= 250 Then
            total = (cant * pre) - (cant * pre) * 0.1
            Console.WriteLine("El precio de cada unidad es: {0}$", pre)
            Console.WriteLine("El subtotal es de: {0}", cant * pre)
            Console.WriteLine("El descuento aplicado es de: {0}$", (cant * pre) * 0.1)
            Console.WriteLine("El precio total es: {0}$", total)
        ElseIf cant >= 251 Then
            total = (cant * pre) - (cant * pre) * 0.2
            Console.WriteLine("El precio de cada unidad es: {0}$", pre)
            Console.WriteLine("El subtotal es de: {0}", cant * pre)
            Console.WriteLine("El descuento aplicado es de: {0}$", (cant * pre) * 0.2)
            Console.WriteLine("El precio total es: {0}$", total)
        Else
            total = (cant * pre)
            Console.WriteLine("El precio de cada unidad es: {0}$", pre)
            Console.WriteLine("El subtotal es de: {0}", cant * pre)
            Console.WriteLine("El precio total es: " & total)
        End If

        Console.ReadKey()

    End Sub
End Module
