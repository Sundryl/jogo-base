using System;
using System.Collections.Generic;

[Serializable]
public class BiomeData
{
	public string Name { get; set; }

	public List<BiomeResource> Resources { get; set; }
}
