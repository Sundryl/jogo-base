using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class SvgIconRenderer : MonoBehaviour
{
	private bool m_IsSea;

	[Header("SVG 渲染")]
	[SerializeField]
	private TextAsset m_SvgAsset;

	[SerializeField]
	private TextAsset m_SvgSeaAsset;

	[SerializeField]
	private Shader m_SvgShader;

	[SerializeField]
	private bool m_RebuildSvgOnEnable;

	[SerializeField]
	[Range(0.5f, 2f)]
	private float m_SvgAaWidth;

	[SerializeField]
	private bool m_EnableStroke;

	[SerializeField]
	[Range(0.1f, 3f)]
	private float m_StrokeThicknessScale;

	private static readonly int s_PartColor0Id;

	private static readonly int s_PartEnableId;

	private static readonly int s_AAWidthId;

	private static readonly Dictionary<TextAsset, Mesh> s_SvgMeshCache;

	private static readonly Dictionary<Shader, Material> s_SvgMaterialCache;

	private static readonly Dictionary<TextAsset, bool> s_SvgHasStrokeCache;

	private MeshRenderer m_Renderer;

	private MeshFilter m_Filter;

	private MaterialPropertyBlock m_PropertyBlock;

	private TextAsset m_CurrentSvgAsset;

	private Color m_CurrentMainColor;

	private bool m_RegisteredStroke;

	private void EnsureRendererComponents()
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void UnregisterStrokeWithoutCreatingManager()
	{
	}

	public void SetColor(Color mainColor)
	{
	}

	public void SetSvgAssets(TextAsset svgAsset, TextAsset svgSeaAsset = null)
	{
	}

	public bool RebuildSvg(bool forceRebuild = false)
	{
		return false;
	}

	public void SetIsSea(bool isSea)
	{
	}

	private void ApplyInstancingSettings()
	{
	}

	private TextAsset ResolveSvgAsset()
	{
		return null;
	}

	private bool ShouldBuildStroke(TextAsset svgAsset)
	{
		return false;
	}

	public bool TryBuildSvg(bool forceRebuild)
	{
		return false;
	}

	private void AssignSvgMaterial()
	{
	}

	private void ApplyColorToRenderer()
	{
	}
}
