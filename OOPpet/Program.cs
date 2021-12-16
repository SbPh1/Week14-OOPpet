using System;

namespace OOPpet
{
    class Program
    {
        class Pet
        {
            string name;
            int age;
            double weight;

            public Pet(string _name)
            {
                name = _name;
                age = 0;
                weight = 0.1;
                Console.WriteLine($"Pet {name} aged has been created");
            }

            public double Weight
            {
                get { return weight; }
            }
            public string Name
            {
                get { return name; }
            }
            public int Age
            {
                get { return age; }
            }
            public void ShowPetData()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"weight: {weight}");
            }
            public void Eat()
            {
                Console.WriteLine("nom nom");
                weight += 0.2;
            }
            public void Run()
            {
                Console.WriteLine("*Runs");
                weight -= 0.1;
            }
        }
        static void Main(string[] args)
        {
            Pet myPet = new Pet("Hamster");
            for (int i = 0; i > 11; i++)
            {
                while (myPet.Weight > 0.7)
                {
                    myPet.Run();

                }
                myPet.Eat();
                i++;
                Console.WriteLine("sorry your hamster dead");
            }


        } 
        
       
    }
}
