using System;

[Serializable]
public class StateMilitaryBinding
{
	public StateMilitaryBindingMode Mode { get; set; }

	public MilitaryProfile CustomMilitaryProfile { get; set; }

	public static StateMilitaryBinding CreateInheritCulture()
	{
		return null;
	}

	public void EnsureInitialized()
	{
	}
}
