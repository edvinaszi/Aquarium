namespace Akvarium;

//Lag en C# konsollapplikasjon som imiterer et akvarium, med masse instanser av fisker. Hver "art" av fisk skal arve fra en felles klasse Fisk. Interface, Arv og Enum. INNKAPSLING 

class Program
{
    static void Main(string[] args)
    {
        Aqvarium aqvarium = new Aqvarium();
        MainMenu(aqvarium);
    }

    static void MainMenu(Aqvarium aqvarium)
    {
        bool atMenu = true;

        while (atMenu)
        {
            Console.Clear();

            Console.WriteLine("1. Display info of fishes");
            Console.WriteLine("2. Add fish");
            Console.WriteLine("3. Look at the aquarium");
            Console.WriteLine("4. Exit");

            var choice = Console.ReadKey().KeyChar;

            switch (choice)
            {
                case '1':
                    DisplayFishInfo(aqvarium);
                    break;
                case '2':
                    Add(aqvarium);
                    break;
                case '3':
                    Console.Clear();
                    aqvarium.Simulate();
                    Console.ReadKey();
                    break;
                case '4':
                    Console.Clear();
                    Console.WriteLine("Bye.");
                    atMenu = false;
                    break;
                default:
                    break;
            }
        }
    }

    static void DisplayFishInfo(Aqvarium aqvarium)
    {
        Console.Clear();

        Console.WriteLine("Here are the fishes that are in the aquarium: \n");

        aqvarium.DisplayFishes();

        BackToMenu();
    }

    static void BackToMenu()
    {
        Console.WriteLine("\nPress any key to go back to the main menu");
        Console.ReadKey();
    }

    static void Add(Aqvarium aqvarium)
    {
        string type;
        string name;
        FishType fishType;

        Console.Clear();

        while (true)
        {
            Console.Write("Enter the type of fish: ");
            type = Console.ReadLine();


            bool isType = Enum.TryParse(type, true, out fishType);

            if (string.IsNullOrWhiteSpace(type))
            {
                Console.WriteLine("Type cannot be empty");
            }
            else if (!isType)
            {
                Console.WriteLine("Can't find this type of fish");
            }
            else
            {
                break;
            }
            
        }

        while (true)
        {
            Console.Write("Enter the name of the fish: ");
            name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty");
            }
            else
            {
                break;
            }
        }


        Console.Write("Enter the weight of the fish: ");

        int weight;

        while (true)
        {
            bool parseWeight = int.TryParse(Console.ReadLine(), out weight);
            if (!parseWeight)
            {
                Console.WriteLine("Enter a valid weight.");
            }
            else if (weight <= 0)
            {
                Console.WriteLine("The fish cannot be less than 1 gram.");
            }
            else
            {
                break;
            }
        }

        Console.Write("Add the look of the fish example '>< (((º >' : ");

        string looks;

        while (true)
        {
            looks = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(looks))
            {
                Console.WriteLine("Looks cannot be empty");
            }
            else
            {
                break;
            }
        }

        Fish fish = new Fish(name, fishType, weight, looks);

        aqvarium.Add(fish);

        Console.WriteLine($"\n{name} was added to the aquarium.");

        BackToMenu();
       
    }
}

