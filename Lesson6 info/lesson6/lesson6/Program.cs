using System;
using lesson6;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog(1,"Messi","Ovcharka");
            dog1.Bark();
            Dog dog2 = new Dog(105, "PressHotDog", "Booboo");
            dog2.Bark();
            Console.WriteLine($"{dog1.Name} can take part in competition:{dog1.CanTakePartInCompetition()}");
            Console.WriteLine($"{dog2.Name} can take part in competition:{dog2.CanTakePartInCompetition()}");
            Console.WriteLine($"name:{dog1.Name},age:{dog1.Age}");
            //ternarniy dog1.CanTakePartInCompetition() ? "yeah" : "nope"
            Console.WriteLine($"vozras do: {dog1.Age}");
            dog1.Age = -5;
            int age = dog1.Age;
            //dog3.Breed = "UTER";
            //set
            // esli . to get , esli = to set
            Console.WriteLine($"vozras posle: {dog1.Age}");
            Dog dog3 = new Dog(4, "Penya", "Gonchaya");
            Console.WriteLine($"{dog3.Breed},{dog2.Breed},{dog1.Breed}");

        }
    }
}