using System;
namespace Akvarium
{
	public class NeonTetra : Fish, IFishBehavior
    {
		public NeonTetra(string name, int weight, string looks = "><{{{º>") : base(name, FishType.NeonTetra, weight, looks)
        {
		}
	}
}

