Module dosseis
    Sub Main()
        Dim desuento As Single
        Dim precio, cant, subtotal As Integer
        Console.WriteLine("Cantidad:")
        cant = Console.ReadLine()
        Console.WriteLine("Precio unitario:")
        precio = Console.ReadLine()
        Select Case cant
            Case 10 To 50
                descuento = 0.05
            Case 51 To 250
                descuento = 0.1
            Case Is > 251
                descuento = 0.2
            Case Else
                descuento = 0%
        End Select
        subtotal = cant * precio
        Console.WriteLine("El porcentaje de descuento aplicado es del:  " & descuento * 100 & "%")
        Console.WriteLine("Subtotal: " & subtotal)
        Console.WriteLine("Monto descontado: {0} ", subtotal * descuento)
        Console.WriteLine("Total a pagar: {0} ", subtotal - (subtotal * descuento))
        Console.ReadKey()
    End Sub
End Module
