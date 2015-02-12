Module Module1

    Sub Main()


        Dim Niece As Person = New Person
        Niece.FirstName = "Claudia"
        Niece.LastName = "Reading"

        Dim Nephew As Person = New Person
        Nephew.FirstName = "John"
        Nephew.LastName = "Reading"

        Dim Pet1 As Pet = New Pet
        Pet1.Name = "Jezabelle"
        Pet1.Age = 17
        Pet1.Species = "Dog"
        Pet1.Owner = Niece

        Dim Pet2 As Pet = New Pet
        Pet1.Name = "Max"
        Pet1.Age = 16
        Pet1.Species = "Cat"
        Pet1.Owner = Nephew



    End Sub

End Module
