using System;
namespace Akvarium
{
	public class Goldfish : Fish, IFishBehavior
	{

		public Goldfish(string name, int weight, string looks = "><(((º>") : base(name, FishType.Goldfish, weight, looks)	
		{
		}

	}
}

