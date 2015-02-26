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
        Pet2.Name = "Max"
        Pet2.Age = 16
        Pet2.Species = "Cat"
        Pet2.Owner = Nephew

        Dim Pet3 As Pet = New Pet
        Pet3.Name = "Buddy"
        Pet3.Age = 3
        Pet3.Species = "Cat"
        Pet3.Owner = Niece

        Console.WriteLine(Pet1.Name)
        Console.WriteLine(Pet1.Age)
        Console.WriteLine(Pet1.Species)
        Console.WriteLine(Pet1.Owner.FullName)

        Console.WriteLine()

        Console.WriteLine(Pet2.Name)
        Console.WriteLine(Pet2.Age)
        Console.WriteLine(Pet2.Species)
        Console.WriteLine(Pet2.Owner.FullName)

        Console.WriteLine()

        Console.WriteLine(Pet3.Name)
        Console.WriteLine(Pet3.Age)
        Console.WriteLine(Pet3.Species)
        Console.WriteLine(Pet3.Owner.FullName)

        Console.ReadKey()

    End Sub

End Module
