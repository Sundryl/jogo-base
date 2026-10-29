public static class StateNamingInheritanceUtility
{
	public static CustomNamingInheritanceMode GetProvinceRebelNamingMode(bool _isReestablished)
	{
		return CustomNamingInheritanceMode.None;
	}

	public static CustomNamingInheritanceMode GetCivilWarNamingMode(WarType _warType, bool _isRestoration)
	{
		return CustomNamingInheritanceMode.None;
	}

	public static CustomNamingInheritanceMode GetFamilyRebellionNamingMode(bool _isRestoration)
	{
		return CustomNamingInheritanceMode.None;
	}

	public static void ApplyCustomNamingByMode(State _targetState, State _sourceState, CustomNamingInheritanceMode _mode)
	{
	}
}
