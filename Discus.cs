using System;
namespace Akvarium
{
	public class Discus : Fish, IFishBehavior
    {
		public Discus(string name, int weight, string looks = "<º((><") : base(name, FishType.Discus, weight, looks)
        {
		}
	}
}

