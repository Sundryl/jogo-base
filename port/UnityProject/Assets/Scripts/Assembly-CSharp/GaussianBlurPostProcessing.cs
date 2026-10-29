using UnityEngine;

[RequireComponent(typeof(Camera))]
public class GaussianBlurPostProcessing : MonoBehaviour
{
	public Shader gaussianBlurShader;

	public float blurSize;

	private Material gaussianBlurMaterial;

	public static GaussianBlurPostProcessing Instance { get; private set; }

	private void Start()
	{
	}

	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	public void CaptureImage()
	{
	}
}
