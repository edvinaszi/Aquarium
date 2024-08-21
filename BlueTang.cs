using System;
namespace Akvarium
{
	public class BlueTang : Fish, IFishBehavior
    {
		public BlueTang(string name, int weight, string looks = "<°((><") : base(name, FishType.BlueTang, weight, looks)
        {
		}
	}
}

