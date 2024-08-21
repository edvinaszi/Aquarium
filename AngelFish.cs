using System;
namespace Akvarium
{
	public class AngelFish : Fish, IFishBehavior
    {
		public AngelFish(string name, int weight, string looks = "<º(((><") : base(name, FishType.Angelfish, weight, looks)
        {
		}
	}
}

