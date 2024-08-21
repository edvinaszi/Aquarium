using System;
namespace Akvarium
{
	public class Fish
	{

		public string Name { get; private set; }
		public FishType Type { get; private set; }
		public int Weight { get; private set; }
		public string Looks { get; private set; }

		public Fish(string name, FishType type, int weight, string looks)
		{
			Name = name;
			Type = type;
			Weight = weight;
			Looks = looks;
		}

		public virtual void Swim()
		{
			Console.WriteLine($"{Name}, {Type} just swam by.");
		}
		
		public virtual void Eat()
		{
			Console.WriteLine($"{Name}, {Type} is eating");
		}

		public void DisplayInfo()
		{
			Console.WriteLine($"Name: {Name,-10} Type: {Type,-12} Weight: {Weight, 5}g");
		}

	}
}

