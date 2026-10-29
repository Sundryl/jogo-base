public static class ArmyUnitKeys
{
	public const string Infantry = "Infantry";

	public const string Archer = "Archer";

	public const string Shield = "Shield";

	public const string Cavalry = "Cavalry";

	public const string Elite = "Elite";

	public const string CustomUnitPrefix = "CustomUnit";

	public static readonly string[] DefaultUnitKeys;

	public static bool IsValid(string _unitKey)
	{
		return false;
	}

	public static bool IsBuiltIn(string _unitKey)
	{
		return false;
	}

	public static string Normalize(string _unitKey, string fallback = "Infantry")
	{
		return null;
	}

	public static string Sanitize(string _unitKey)
	{
		return null;
	}

	public static string BuildKeySlug(string rawKey, string fallbackPrefix = "CustomUnit")
	{
		return null;
	}
}
