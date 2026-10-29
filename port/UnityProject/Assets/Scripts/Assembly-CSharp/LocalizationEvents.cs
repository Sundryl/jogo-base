using System;
using System.Runtime.CompilerServices;

public static class LocalizationEvents
{
	[CompilerGenerated]
	private static Action m_OnLanguageChanged;

	public static event Action OnLanguageChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static void LanguageChanged()
	{
	}
}
