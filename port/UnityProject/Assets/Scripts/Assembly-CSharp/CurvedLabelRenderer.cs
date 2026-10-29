using System.Collections.Generic;
using TMPro;
using UnityEngine;

public sealed class CurvedLabelRenderer : MonoBehaviour
{
	[SerializeField]
	private List<Vector3> m_ControlPoints;

	[SerializeField]
	private float m_CurveAmount;

	[SerializeField]
	private float m_LabelZ;

	private TextMeshPro m_Template;

	private string m_Text;

	private Color m_Color;

	private Color m_OutlineColor;

	private float m_OutlineWidth;

	[SerializeField]
	private TextOrientation m_Orientation;

	[SerializeField]
	private bool m_IsItalic;

	[SerializeField]
	private bool m_IsBold;

	private FontStyles m_BaseFontStyle;

	private bool m_DefaultStyleCaptured;

	private bool m_GeometryCached;

	private readonly List<Vector3[]> m_OriginalVertices;

	private bool m_TemplateAutoSizing;

	private float m_TemplateFontSize;

	private float m_TemplateFontSizeMin;

	private float m_TemplateFontSizeMax;

	private float m_TemplateCharacterSpacing;

	private FontStyles m_TemplateFontStyle;

	private TextAlignmentOptions m_TemplateAlignment;

	public void ApplyFromData(string _text, Color _color, Color _outlineColor, float _outlineWidth, IReadOnlyList<Vector3> _controlPoints, TextOrientation _orientation, bool _italic, bool _bold)
	{
	}

	private void EnsureTemplate()
	{
	}

	private void UpdateTemplateState()
	{
	}

	private void CacheGeometry()
	{
	}

	private void EnsureCacheCapacity()
	{
	}

	private void RebuildGeometry()
	{
	}

	private List<Vector3> BuildPath()
	{
		return null;
	}

	private void RestoreOriginalGeometry(TMP_TextInfo textInfo)
	{
	}

	private void CopyOriginalVertices(TMP_TextInfo textInfo)
	{
	}

	private void ApplyCurve(TMP_TextInfo textInfo, List<Vector3> path)
	{
	}

	private void UpdateMeshes(TMP_TextInfo textInfo)
	{
	}
}
