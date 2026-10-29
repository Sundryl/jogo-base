using System;

[Serializable]
public struct SliderSettings
{
	public float DefaultValue;

	public float MinValue;

	public float MaxValue;

	public SliderSettings(float minValue, float maxValue, float defaultValue)
	{
		DefaultValue = 0f;
		MinValue = 0f;
		MaxValue = 0f;
	}
}
