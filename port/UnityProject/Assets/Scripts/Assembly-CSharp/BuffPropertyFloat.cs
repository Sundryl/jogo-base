using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

[Serializable]
public class BuffPropertyFloat
{
	private float fPropBase;

	private float fPropFinal;

	private Dictionary<ComputeArea, float> m_propValues;

	public void FromJson(JObject jObject)
	{
	}

	public JObject ToJson()
	{
		return null;
	}

	public void Reset(float fInVal = 1f)
	{
	}

	public void SetProperty(ComputeArea eInArea, float fInValue)
	{
	}

	public float GetProperty()
	{
		return 0f;
	}

	public void UpdateProperty()
	{
	}
}
