using System;
using System.Collections.Generic;

[Serializable]
public class Trait
{
	public string name;

	public string description;

	public List<TraitEffect> effects;

	public void ApplyEffect(State state)
	{
	}
}
