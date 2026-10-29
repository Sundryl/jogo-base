using UnityEngine;

[ExecuteInEditMode]
public class ParchmentPostProcessing : MonoBehaviour
{
	public Material postProcessMaterial;

	[Range(0f, 2f)]
	public float brightness;

	[Range(0f, 2f)]
	public float saturation;

	private static ParchmentPostProcessing instance;

	public bool isEnabled;

	public static ParchmentPostProcessing Instance => null;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	public void SetUseGrayScale(float useGrayScale)
	{
	}

	public void SetParchmentStrength(float strength)
	{
	}
}
