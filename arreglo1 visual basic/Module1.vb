Module Module1

    Sub Main()
        Dim valores As Integer() = New Integer() {2, 4, 6, 8, 10, 12, 14, 16, 18, 20}
        Dim suma As Integer = 0

        For i As Integer = 0 To valores.Length - 1
            suma += valores(i)
        Next

        Console.WriteLine("La suma de los valores del arreglo es: {0}", suma)
        Console.ReadKey()
    End Sub

End Module
