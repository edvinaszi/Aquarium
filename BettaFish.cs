using System;
namespace Akvarium
{
	public class BettaFish : Fish, IFishBehavior
	{
		public BettaFish(string name, int weight, string looks = "><(((o>") : base(name, FishType.BettaFish, weight, looks)
        {
		}
	}
}

