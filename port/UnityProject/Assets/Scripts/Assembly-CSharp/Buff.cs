using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

[Serializable]
public class Buff
{
	[Serializable]
	public class BuffContainer
	{
		public List<Buff> buffs;
	}

	public string sDisplayName;

	public string sDescription;

	public string sKey;

	public BuffType eType;

	public float fDuration;

	public bool isPermanent;

	public ComputeArea eComputeArea;

	public float fValue;

	public JObject Serialize()
	{
		return null;
	}

	public static Buff Deserialize(JObject jObject)
	{
		return null;
	}

	public void LoadBuffFromJson(string sInKey)
	{
	}
}
