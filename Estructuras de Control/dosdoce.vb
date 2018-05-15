Module dosdoce
    Sub main()
        Dim a As Int16 = 0
        Dim b As Int16 = 1
        Dim c As Int16
        Console.WriteLine("la secuencia es: ")
        While c < 10000
            c = a + b
            a = b
            b = c
            Console.WriteLine(c)
        End While
        Console.ReadKey()
    End Sub
End Module
