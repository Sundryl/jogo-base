using UnityEngine;

public class TranslationInitializer : MonoBehaviour
{
	[SerializeField]
	private GameObject m_TranslationManagerPrefab;

	[Tooltip("是否在启动时自动初始化翻译系统")]
	[SerializeField]
	private bool m_InitializeOnAwake;

	[Header("测试用")]
	[SerializeField]
	private bool m_RunTest;

	[SerializeField]
	private string m_TestText;

	[SerializeField]
	private string m_SourceLanguage;

	[SerializeField]
	private string m_TargetLanguage;

	private void Awake()
	{
	}

	public void InitializeTranslationSystem()
	{
	}
}
