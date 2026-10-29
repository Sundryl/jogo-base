using System.Globalization;

public static class NumberParsingUtility
{
	private static readonly NumberStyles s_NumberStyles;

	public static bool TryParseFloatFlexible(string _text, out float _value)
	{
		_value = default;
		return false;
	}

	public static bool TryParseDoubleFlexible(string _text, out double _value)
	{
		_value = default;
		return false;
	}
}
