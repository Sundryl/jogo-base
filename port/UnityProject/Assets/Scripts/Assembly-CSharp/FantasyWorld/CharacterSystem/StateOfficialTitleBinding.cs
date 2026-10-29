using System;
using Newtonsoft.Json;

namespace FantasyWorld.CharacterSystem
{
	[Serializable]
	public sealed class StateOfficialTitleBinding
	{
		[JsonProperty]
		public StateOfficialTitleBindingMode Mode { get; set; }

		[JsonProperty]
		public OfficialTitleProfile CustomOfficialTitleProfile { get; set; }

		public static StateOfficialTitleBinding CreateInheritCulture()
		{
			return null;
		}

		public void EnsureInitialized()
		{
		}

		public StateOfficialTitleBinding Clone()
		{
			return null;
		}
	}
}
