Module Module1

    Sub Main()
        Console.Write("How Many Adults?        :   ")
        Dim numAdults As Integer = Console.ReadLine()
        Console.Write("How Many Children?      :   ")
        Dim numChildren As Integer = Console.ReadLine()
        Console.Write("How Many Seniors?       :   ")
        Dim numSeniors As Integer = Console.ReadLine()

        Dim ticAdult As Single
        Dim ticChild As Single
        Dim ticSenior As Single

        Dim ttlTicAll As Single

        Console.Write("Matinee? y/n            :   ")
        Dim movieTime As String = Console.ReadLine()


        If movieTime = "y" Then
            ticChild = 3.99
            ticAdult = 5.99
            ticSenior = 4.5
        Else
            ticChild = 6.99
            ticAdult = 10.99
            ticSenior = 8.5
        End If


        ttlTicAll = ((ticAdult * numAdults) + (ticChild * numChildren) _
                     + (ticSenior * numSeniors))


        Console.Write("How Many Small Sodas?   :   ")
        Dim numSmallSodas As Integer = Console.ReadLine()
        Console.Write("How Many Large Sodas?   :   ")
        Dim numLargeSodas As Integer = Console.ReadLine()
        Console.Write("How Many Hot Dogs?      :   ")
        Dim numHotDog As Integer = Console.ReadLine()
        Console.Write("How Many Popcorns?      :   ")
        Dim numPopcorn As Integer = Console.ReadLine()
        Console.Write("How Many Candy?         :   ")
        Dim numCandy As Integer = Console.ReadLine()


        Dim ttlConAll As Single = ((numSmallSodas * 3.5) + (numLargeSodas * 5.99) _
                                   + (numHotDog * 3.99) + (numPopcorn * 4.5) + _
                                   (numCandy * 1.99))

        Dim ttlGrand As Single = (ttlTicAll + ttlConAll)



        Console.Write("Grand Total is         :   " & ttlGrand)



        Console.ReadKey()





    End Sub

End Module
