Module dostrece
    Sub main()
        Dim n, i As Integer
        Dim b As Boolean
        For n = 1 To 1000
            b = True
            For i = 2 To Math.Sqrt(n)
                If n Mod i = 0 Then
                    b = False
                    Exit For
                End If
            Next
            If b And n <> 1 Then
                Console.WriteLine(n)
            End If
        Next
        Console.ReadKey()
    End Sub
End Module

