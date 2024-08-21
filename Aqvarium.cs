using System;
namespace Akvarium
{
	public class Aqvarium
	{
		private List<Fish> fishes = new List<Fish>()
		{
			new Goldfish("Goldie", 30),
			new Clownfish("Bubbles", 20),
			new BettaFish("Spike", 3),
			new Guppy("Gizmo", 2),
			new NeonTetra("Spark", 1),
			new AngelFish("Halo", 30),
			new Oscar("Rocky", 200),
			new Discus("Dot", 200),
			new MandarinFish("Tango", 20),
			new BlueTang("Bluey", 90)
		};

		public void DisplayFishes()
		{
			foreach(var fish in fishes)
			{
				fish.DisplayInfo();
			}
		}

		public void Add(Fish fish)
		{
			fishes.Add(fish);
		}

		public void Simulate()
		{
			Random random = new Random();


			while (true)
			{
                if (Console.KeyAvailable)
                {
                    break;
                }

                int randomTask = random.Next(2);
                int randomFish = random.Next(fishes.Count);

                    Console.Clear();

                    switch (randomTask)
                    {
                        case 0:
                            SimulateFishSwimming(fishes[randomFish].Looks);
                            Console.Clear();
                            fishes[randomFish].Swim();
                            break;
                        case 1:
                            fishes[random.Next(fishes.Count)].Eat();
                            break;
                        default:
                            break;
                    }

                Thread.Sleep(2000);

            }
        }


        public void SimulateFishSwimming(string randomFish )
        {
            Random random = new Random();
            int randomSpeed = random.Next(10, 50);
            int randomHeight = random.Next(0, 40);
            int windowWidth = Console.WindowWidth;

            bool isSwimmingRight = randomFish[0] == '>';

            if (isSwimmingRight)
            {
                for (int i = 0; i < windowWidth - randomFish.Length; i++)
                {
                    Console.Clear();

                    Console.SetCursorPosition(i, randomHeight);

                    Console.WriteLine(randomFish);

                    Thread.Sleep(randomSpeed);
                }
            }
            else
            {
                for (int i = windowWidth - randomFish.Length; i >= 0; i--)
                {
                    Console.Clear();

                    Console.SetCursorPosition(i, randomHeight);

                    Console.WriteLine(randomFish);

                    Thread.Sleep(randomSpeed);
                }
            }

        }

    }
}

