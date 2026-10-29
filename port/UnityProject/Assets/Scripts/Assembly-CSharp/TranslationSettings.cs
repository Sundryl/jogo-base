using UnityEngine;

[CreateAssetMenu(fileName = "TranslationSettings", menuName = "NextFantasyWorld/Translation Settings")]
public class TranslationSettings : ScriptableObject
{
	[Header("Azure API 配置")]
	[Tooltip("Azure Translator API 密钥")]
	[SerializeField]
	private string m_ApiKey;

	[Tooltip("Azure 资源区域（例如：eastasia, westus）")]
	[SerializeField]
	private string m_Region;

	[Tooltip("API 终结点，通常不需要修改")]
	[SerializeField]
	private string m_Endpoint;

	[SerializeField]
	[Header("缓存设置")]
	[Tooltip("是否启用翻译缓存")]
	private bool m_EnableCache;

	[SerializeField]
	[Tooltip("缓存条目的最大数量（超过将清除旧缓存）")]
	private int m_MaxCacheEntries;

	[Tooltip("是否启用调试日志")]
	[Header("调试设置")]
	[SerializeField]
	private bool m_EnableDebugLogging;

	public string ApiKey => null;

	public string Region => null;

	public string Endpoint => null;

	public bool EnableCache => false;

	public int MaxCacheEntries => 0;

	public bool EnableDebugLogging => false;

	public bool IsConfigured()
	{
		return false;
	}
}
