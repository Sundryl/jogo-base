using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;

public class CustomLabelManager
{
	private const float c_LabelZ = -0.61f;

	private const int c_DataVersion = 3;

	private const float c_MinPathHalfLength = 6f;

	private const float c_MinFontSize = 10f;

	private const float c_MaxFontSize = 80f;

	private const float c_DefaultFontSize = 30f;

	private const float c_MinOutlineWidth = 0f;

	private const float c_MaxOutlineWidth = 0.5f;

	private const float c_DefaultOutlineWidth = 0.1f;

	private const string c_DefaultFontId = "";

	private static readonly Regex s_RichTextRegex;

	private static CustomLabelManager s_Instance;

	private bool m_IsQuitting;

	private readonly Dictionary<string, CustomLabelData> m_Datas;

	private readonly List<CustomLabelData> m_OrderedLabelDatas;

	private readonly Dictionary<string, GameObject> m_Views;

	private string m_ActiveEditingId;

	private bool m_IsPositionEditMode;

	private string m_CurrentPathEditingId;

	public static CustomLabelManager Instance => null;

	public bool IsPathEditing => false;

	private CustomLabelManager()
	{
	}

	public static string SanitizeLabelText(string _text)
	{
		return null;
	}

	public CustomLabelData CreateLabelAt(string _text, Vector2 _screenPos01)
	{
		return null;
	}

	public bool UpdateText(string _id, string _text)
	{
		return false;
	}

	public string GetDisplayText(string _id)
	{
		return null;
	}

	public Dictionary<string, string> GetLabelTranslations(string _id)
	{
		return null;
	}

	public bool SetLabelTranslations(string _id, Dictionary<string, string> _translations)
	{
		return false;
	}

	public bool SetLabelFont(string _id, string _fontId)
	{
		return false;
	}

	public bool SetLabelFontSize(string _id, float _fontSize)
	{
		return false;
	}

	public float GetLabelFontSize(string _id)
	{
		return 0f;
	}

	public Vector2 GetFontSizeRange()
	{
		return default;
	}

	public Vector2 GetOutlineWidthRange()
	{
		return default;
	}

	public Color GetLabelColor(string _id)
	{
		return default;
	}

	public Color GetLabelOutlineColor(string _id)
	{
		return default;
	}

	public float GetLabelOutlineWidth(string _id)
	{
		return 0f;
	}

	public bool Remove(string _id)
	{
		return false;
	}

	public IReadOnlyList<CustomLabelData> GetAll()
	{
		return null;
	}

	public void ClearAll()
	{
	}

	public bool TryGetData(string _id, out CustomLabelData _data)
	{
		_data = null;
		return false;
	}

	public bool TryGetViewObject(string _id, out GameObject _go)
	{
		_go = null;
		return false;
	}

	public string Serialize()
	{
		return null;
	}

	public void Deserialize(string _json)
	{
	}

	public void RebuildViews()
	{
	}

	private void EnsureView(CustomLabelData _data)
	{
	}

	private void ApplyToView(string _id, CustomLabelData _data)
	{
	}

	private static void ApplySanitizedText(TextMeshPro _tmp, CustomLabelData _data)
	{
	}

	private void ApplyFontAsset(TextMeshPro _tmp, CustomLabelData _data)
	{
	}

	private static void ApplyFontStyle(TextMeshPro _tmp, CustomLabelData _data)
	{
	}

	private bool CanUseFont(string _fontId)
	{
		return false;
	}

	private TMP_FontAsset ResolveFontAsset(string _fontId)
	{
		return null;
	}

	private static void ApplyCurvedLayout(CurvedLabelRenderer _curved, CustomLabelData _data, Color _labelColor, Color _outlineColor, float _outlineWidth)
	{
	}

	public bool SetUsePathLayout(string _id, bool _enabled)
	{
		return false;
	}

	public bool SetPathPoints(string _id, List<Vector2> _points)
	{
		return false;
	}

	public bool SetTextOrientation(string _id, TextOrientation _orientation)
	{
		return false;
	}

	public bool SetTextItalic(string _id, bool _italic)
	{
		return false;
	}

	public bool SetTextBold(string _id, bool _bold)
	{
		return false;
	}

	public bool SetLabelColor(string _id, Color _color)
	{
		return false;
	}

	public bool SetLabelOutlineColor(string _id, Color _color)
	{
		return false;
	}

	public bool SetLabelOutlineWidth(string _id, float _width)
	{
		return false;
	}

	public bool SetLabelLocalPosition(string _id, Vector2 _localPos)
	{
		return false;
	}

	public void SetActiveEditingLabel(string _id)
	{
	}

	public void ClearActiveEditingLabel()
	{
	}

	public bool IsActiveEditing(string _id)
	{
		return false;
	}

	public void SetPositionEditMode(bool enabled)
	{
	}

	public bool IsPositionEditModeEnabled()
	{
		return false;
	}

	private void ClearAllViews()
	{
	}

	private void HandleApplicationQuitting()
	{
	}

	private void HandleLanguageChanged()
	{
	}

	private static Vector2 Clamp01(Vector2 v)
	{
		return default;
	}

	public void RefreshView(string _id)
	{
	}

	private static Vector3 Screen01ToWorld(Vector2 screen01)
	{
		return default;
	}

	private void ApplyFontSize(TextMeshPro tmp, CustomLabelData data)
	{
	}

	private void EnsureDefaultPath(CustomLabelData data, TextMeshPro tmp)
	{
	}

	private static List<Vector2> BuildDefaultPath(Vector2 center, float halfWidth)
	{
		return null;
	}

	private static List<Vector2> NormalizePathPoints(CustomLabelData data, List<Vector2> incoming)
	{
		return null;
	}

	private static bool ArePathPointsEqual(List<Vector2> a, List<Vector2> b, float tolerance = 0.0001f)
	{
		return false;
	}

	private static string GetDisplayText(CustomLabelData data)
	{
		return null;
	}

	private static string GetBestTranslationForLanguage(Dictionary<string, string> translations, string preferredLanguage, string fallback)
	{
		return null;
	}

	private static bool TryGetValidTranslationForLanguage(Dictionary<string, string> translations, string language, out string translatedText)
	{
		translatedText = null;
		return false;
	}

	private static Dictionary<string, string> SanitizeTranslations(Dictionary<string, string> translations)
	{
		return null;
	}

	private static Color GetResolvedLabelColor(CustomLabelData _data)
	{
		return default;
	}

	private static Color GetResolvedOutlineColor(CustomLabelData _data)
	{
		return default;
	}

	private static float GetResolvedOutlineWidth(CustomLabelData _data)
	{
		return 0f;
	}

	public void BeginPathEdit(string labelId)
	{
	}

	public void EndPathEdit()
	{
	}

	public void OnSelectedLabelChangedForPathEdit(string newLabelId)
	{
	}
}
