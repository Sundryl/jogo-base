using System.Collections.Generic;

public class ParsedDiplomacyData
{
	public List<StateRelation> StateRelations { get; set; }

	public List<string> SerializedAlliances { get; set; }

	public double LastRebelDesitinyRecalTimestamp { get; set; }

	public bool IsSuperSuperpowerExists { get; set; }

	public float StrengthSum { get; set; }
}
