using Newtonsoft.Json.Linq;

public class VassalState
{
	public State vassalState;

	public State overlordState;

	public double vassalizationTime;

	public float tributeRate;

	public float armyCapMultiplier;

	public int updateDayInMonth;

	public string rebellionReason;

	public VassalState(State vassal, State overlord, double time)
	{
	}

	public JObject Serialize()
	{
		return null;
	}

	public static VassalState Deserialize(JObject jObject)
	{
		return null;
	}
}
