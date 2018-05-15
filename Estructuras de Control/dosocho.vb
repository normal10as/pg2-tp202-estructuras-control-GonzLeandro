Module dosocho
    Enum meses As Integer
        enero = 31
        abril = 30
    End Enum

    Dim febrero As Integer
    Sub main()
        Dim mes, anio As Integer

        Console.WriteLine("Ingrese un mes")
        mes = Console.ReadLine()

        Select Case mes
            Case 1, 3, 5, 7, 8, 10, 12
                Console.WriteLine("El mes tiene " & meses.enero & " dias.")
            Case 4, 6, 9, 11
                Console.WriteLine("El mes tiene " & meses.abril & " dias.")
            Case 2
                Console.WriteLine(esfebrero(anio, febrero))
            Case Else
                Console.WriteLine("ERROR...")
        End Select
        Console.ReadKey()
    End Sub
    Private Function esfebrero(ByRef anio, ByVal febrero) As Integer
        Console.WriteLine("Ingrese el anio: ")
        anio = Console.ReadLine()
        If (anio Mod 4 = 0 And anio Mod 100 <> 0 Or anio Mod 400 = 0) Then
            febrero = 29
        Else
            febrero = 28
        End If

        Return febrero


    End Function
End Module
