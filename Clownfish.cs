using System;
namespace Akvarium
{
	public class Clownfish : Fish, IFishBehavior
	{
		public Clownfish(string name, int weight, string looks = "><((º>") : base(name, FishType.Clownfish, weight, looks)
		{
		}
	}
}

