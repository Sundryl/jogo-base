using System;
using System.Collections.Generic;

[Serializable]
public class DiplomacySerializationData
{
	public List<StateRelation> StateRelations { get; set; }

	public List<string> SerializedAlliances { get; set; }

	public double LastRebelDesitinyRecalTimestamp { get; set; }

	public bool IsSuperSuperpowerExists { get; set; }

	public float StrengthSum { get; set; }
}
