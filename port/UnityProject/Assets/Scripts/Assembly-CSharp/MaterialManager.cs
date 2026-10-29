using System.Collections.Generic;
using UnityEngine;

public class MaterialManager : MonoBehaviour
{
	private static MaterialManager m_Instance;

	[SerializeField]
	private Material m_BaseMaterial;

	private Material m_CoreMaterial;

	private Material m_OceanMaterial;

	private Dictionary<Color, Material> m_ColorMaterialMap;

	public static MaterialManager Instance => null;

	public void SetBaseMaterial(Material _material)
	{
	}

	public Material GetMaterial(Color color)
	{
		return null;
	}

	public Material GetMaterialForProvince(Province province)
	{
		return null;
	}

	public Material GetCoreMaterial()
	{
		return null;
	}

	public void CleanupUnusedMaterials()
	{
	}

	public void CleanupAllMaterials()
	{
	}

	public void RefreshBlankUnConquerableProvincesForVisualOwnerState(int visualOwnerStateID)
	{
	}

	public void RefreshBlankUnConquerableProvincesAroundProvince(Province province)
	{
	}

	public void UpdateAllMaterialEdgeIntensity(float edgeIntensity)
	{
	}

	public void UpdateAllMaterialBorderDark(float borderDark)
	{
	}

	public void UpdateAllMaterialBorderDarkScale(float darkScale)
	{
	}

	public void UpdateAllMaterialTransparency(float transparency)
	{
	}

	private Material CreateMaterial(Color color)
	{
		return null;
	}

	private bool IsColorInUse(Color color)
	{
		return false;
	}

	private Color GetColorForViewMode(Province province, ColorViewMode viewMode)
	{
		return default;
	}

	private State GetEffectiveStateForProvince(Province province)
	{
		return null;
	}

	private Color GetFamilyColorForProvince(Province province, Color errorColor)
	{
		return default;
	}

	private void OnDestroy()
	{
	}

	public void UpdateStateColor(State state, Color newColor)
	{
	}

	private void UpdateMaterialProperties(Material material, Color color)
	{
	}
}
