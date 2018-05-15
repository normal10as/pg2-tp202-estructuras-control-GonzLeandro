Module dosnueve
    Sub main()
        Dim medidas As UShort
        Dim val As Single
        Console.WriteLine("Pies = 1")
        Console.WriteLine("Pulgadas = 2")
        Console.WriteLine("Yardas = 3")
        Console.WriteLine("Metros = 4")
        Console.WriteLine("Centimetros = 5")
        Console.WriteLine("Seleccione la unidad de medida que desea convertir: ")
        medidas = Console.ReadLine()
        Console.WriteLine("")
        Console.WriteLine("Ingrese el valor a convertir: ")
        val = Console.ReadLine()

        Select Case medidas
            Case 1
                Console.WriteLine("Pulgadas= " & val * 12)
                Console.WriteLine("Yardas= " & val * 0.333333)
                Console.WriteLine("Metros= " & val * 0.3048)
                Console.WriteLine("Centimetros= " & val * 30.48)

            Case 2
                Console.WriteLine("Pie= " & val * 0.0833333)
                Console.WriteLine("Yardas= " & val * 0.0277778)
                Console.WriteLine("Metros= " & val * 0.0254)
                Console.WriteLine("Centimetros= " & val * 2.54)
            Case 3
                Console.WriteLine("Pie= " & val * 3)
                Console.WriteLine("Pulgadas= " & val * 36)
                Console.WriteLine("Metros= " & val * 0.9144)
                Console.WriteLine("Centimetros= " & val * 91.44)
            Case 4
                Console.WriteLine("Pie= " & val * 3.28084)
                Console.WriteLine("Pulgadas= " & val * 39.3701)
                Console.WriteLine("Yarda= " & val * 1.09361)
                Console.WriteLine("Centimetros= " & val * 100)
            Case 5
                Console.WriteLine("Pie= " & val * 0.0328084)
                Console.WriteLine("Pulgadas= " & val * 0.393701)
                Console.WriteLine("Yarda= " & val * 0.0109361)
                Console.WriteLine("Metros= " & val * 0.01)

        End Select
        Console.ReadKey()
    End Sub
End Module
