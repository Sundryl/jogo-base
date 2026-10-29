using UnityEngine;

[RequireComponent(typeof(SvgIconRenderer))]
public class NavySvgRenderer : MonoBehaviour
{
	[SerializeField]
	private TextAsset m_SvgAsset;

	[SerializeField]
	private TextAsset m_SvgSeaAsset;

	[Range(0.1f, 3f)]
	[SerializeField]
	private float m_StrokeThicknessScale;

	private SvgIconRenderer m_Renderer;

	private void Awake()
	{
	}

	public void SetColor(Color color)
	{
	}

	public void SetIsSea(bool isSea)
	{
	}

	public void SetSvgAssets(TextAsset svgAsset, TextAsset svgSeaAsset = null)
	{
	}

	private void ApplyAssets()
	{
	}
}
