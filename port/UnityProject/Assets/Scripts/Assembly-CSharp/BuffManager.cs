using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class BuffManager
{
	public State m_OwnerState;

	private List<Buff> m_Buffs;

	private Dictionary<BuffType, BuffPropertyFloat> m_BuffProps;

	private bool m_IsDirty;

	public JObject Serialize()
	{
		return null;
	}

	public static BuffManager Deserialize(JObject jObject, State ownerState)
	{
		return null;
	}

	public void Init()
	{
	}

	public void Clear()
	{
	}

	public void AddBuff(Buff inNewBuff)
	{
	}

	public void RemoveBuff(string sInKey)
	{
	}

	public void RemoveBuff(Buff inBuff)
	{
	}

	public void UpdateBuffs()
	{
	}

	public float GetBuffPropertyValue(BuffType buffType)
	{
		return 0f;
	}
}
