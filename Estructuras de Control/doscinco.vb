Module doscinco
    Enum meses As Integer
        enero
        febrero
        marzo
        abril
        mayo
        junio
        julio
        agosto
        septiembre
        octubre
        noviembre
        diciembre

    End Enum

    Sub main()
        Console.WriteLine("Ingrese un numero entre el 1 y el 12 segun su correspondiente mes: ")
        Dim mes As Integer = Console.ReadLine()

        Select Case mes
            Case 1
                Console.WriteLine(meses.enero.ToString)
            Case 2
                Console.WriteLine(meses.febrero.ToString)
            Case 3
                Console.WriteLine(meses.marzo.ToString)
            Case 4
                Console.WriteLine(meses.abril.ToString)
            Case 5
                Console.WriteLine(meses.mayo.ToString)
            Case 6
                Console.WriteLine(meses.junio.ToString)
            Case 7
                Console.WriteLine(meses.julio.ToString)
            Case 8
                Console.WriteLine(meses.agosto.ToString)
            Case 9
                Console.WriteLine(meses.septiembre.ToString)
            Case 10
                Console.WriteLine(meses.octubre.ToString)
            Case 11
                Console.WriteLine(meses.noviembre.ToString)
            Case 12
                Console.WriteLine(meses.diciembre.ToString)
            Case Else
                Console.WriteLine("Invalido")
        End Select
        Console.ReadKey()
    End Sub
End Module
