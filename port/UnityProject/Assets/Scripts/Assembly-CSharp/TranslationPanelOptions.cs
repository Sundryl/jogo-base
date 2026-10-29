using System;

public class TranslationPanelOptions
{
	public bool isFormatTemplateMode;

	public Func<string, string> preprocessSourceText;

	public Func<string, string> preprocessLanguageDetectionText;

	public Func<string, string, string> postprocessTranslatedText;

	public Func<string, string, bool> validateTranslatedText;

	public string invalidTranslationFallback;

	public string requestTextType;
}
