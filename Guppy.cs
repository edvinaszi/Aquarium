using System;
namespace Akvarium
{
	public class Guppy : Fish, IFishBehavior
    {
		public Guppy(string name, int weight, string looks = "><((°>") : base(name, FishType.Guppy, weight, looks)
        {
		}
	}
}

