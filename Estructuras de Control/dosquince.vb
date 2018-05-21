Module dosquince
    Const interes As UShort = 36
    Sub main()
        Dim capital As Int16
        Dim meses As UShort
        Dim saldo As Int16
        Dim acum As Int16 = 1
        Dim intereses As Int16
        Console.WriteLine("Ingrese dinero a depositar: ")
        capital = Console.ReadLine()
        Console.WriteLine("Ingrese plazo en meses: ")
        meses = Console.ReadLine()

        Do While acum <= meses
            intereses = capital / interes
            saldo = capital + (capital * interes / 100)
            Console.WriteLine("Mes {0}     |El capital es: {1}|     |Intereses ganados {2}|      |Saldo {3}|", acum, capital, interes, saldo)
            capital = saldo
            acum += 1
        Loop
        Console.ReadKey()
    End Sub
End Module
