using System;
using Newtonsoft.Json;

namespace FantasyWorld.CharacterSystem
{
	[Serializable]
	public class PastRole
	{
		private const int c_TimestampDecimalPlaces = 2;

		[JsonProperty("t", NullValueHandling = NullValueHandling.Ignore)]
		public string roleType;

		[JsonProperty("n", NullValueHandling = NullValueHandling.Ignore)]
		public string roleTitle;

		[JsonProperty("s", DefaultValueHandling = DefaultValueHandling.Ignore)]
		public int stateId;

		[JsonProperty("f", DefaultValueHandling = DefaultValueHandling.Ignore)]
		public int familyId;

		[JsonProperty("b", DefaultValueHandling = DefaultValueHandling.Ignore)]
		public double startTime;

		[JsonProperty("e", DefaultValueHandling = DefaultValueHandling.Ignore)]
		public double endTime;

		[JsonProperty("r", NullValueHandling = NullValueHandling.Ignore)]
		public string endReason;

		[JsonProperty("o", NullValueHandling = NullValueHandling.Ignore)]
		public string OfficeId;

		[JsonProperty("sk", DefaultValueHandling = DefaultValueHandling.Ignore)]
		public GovernmentOfficeScopeKind OfficeScopeKind;

		[JsonProperty("si", DefaultValueHandling = DefaultValueHandling.Ignore)]
		public int OfficeScopeId;

		[JsonProperty("wk", DefaultValueHandling = DefaultValueHandling.Ignore)]
		public GovernmentOfficeWarSystemKind OfficeWarSystemKind;

		[JsonProperty("ps", DefaultValueHandling = DefaultValueHandling.Ignore)]
		public PoliticalSystem PoliticalSystemAtAppointment;

		public PastRole()
		{
		}

		public PastRole(Role role, double endTime, string endReason)
		{
		}

		public static double NormalizeTimestamp(double _timestamp)
		{
			return 0.0;
		}

		public static bool HasSameStartTime(double _firstTimestamp, double _secondTimestamp)
		{
			return false;
		}
	}
}
