using System;
using Newtonsoft.Json;

namespace FantasyWorld.CharacterSystem
{
	[Serializable]
	[JsonConverter(typeof(RoleJsonConverter))]
	public abstract class Role
	{
		public int holderId;

		public double startTime;

		public string roleType;

		[JsonIgnore]
		public Character Holder => null;

		public Role()
		{
		}

		public virtual bool IsValid()
		{
			return false;
		}

		public abstract float GetPowerScore();
	}
}
