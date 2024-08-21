using System;
namespace Akvarium
{
	public class MandarinFish : Fish, IFishBehavior
    {
		public MandarinFish(string name, int weight, string looks = "<o(((><") : base(name, FishType.Mandarinfish, weight, looks)
        {
		}
	}
}

