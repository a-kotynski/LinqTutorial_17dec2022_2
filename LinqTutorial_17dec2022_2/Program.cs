namespace LinqTutorial_17dec2022_2;

internal class Program
{
    static void Main(string[] args)
    {
        var pets = new[]
        {
            new Pet(1, "Hannibal", PetType.Fish, 1.1f),
            new Pet(2, "Anthony", PetType.Cat, 2f),
            new Pet(3, "Ed", PetType.Cat, 0.7f),
            new Pet(4, "Taiga", PetType.Dog, 35f),
            new Pet(5, "Rex", PetType.Dog, 40f),
            new Pet(6, "Lucky", PetType.Dog, 5f),
            new Pet(7, "Storm", PetType.Cat, 0.9f),
            new Pet(8, "Nyan", PetType.Cat, 2.2f)
        };

        var countOfDogs = pets.Count(pet => pet.Type == PetType.Dog);
        Console.WriteLine($"{nameof(countOfDogs)}: {countOfDogs}");

        var countOfPetsNamedBruce = pets.LongCount(pet => pet.Name == "Bruce");
        Console.WriteLine($"{nameof(countOfPetsNamedBruce)}: {countOfPetsNamedBruce}");

        var countOfAllSmallDogs = pets.LongCount(pet => pet.Weight < 10 && pet.Type == PetType.Dog);
        Console.WriteLine($"{nameof(countOfAllSmallDogs)}: {countOfAllSmallDogs}");

        var allPetsCount = pets.Count();
        Console.WriteLine($"{nameof(allPetsCount)}: {allPetsCount}");

    }
}