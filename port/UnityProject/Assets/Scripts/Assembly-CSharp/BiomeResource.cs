using System;
using System.Collections.Generic;

[Serializable]
public class BiomeResource
{
	public string Name { get; set; }

	public float Probability { get; set; }

	public int BaseValue { get; set; }

	public List<EthnicAttribute> AffectedBy { get; set; }
}
