using System;
namespace Akvarium
{
	public class Oscar : Fish, IFishBehavior
    {
		public Oscar(string name, int weight, string looks = "<º{{{><") : base(name, FishType.Oscar, weight, looks)
        {
		}
	}
}

