using UnityEngine;

[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class StencilBlurPostProcess : MonoBehaviour
{
	public Material blurMaterial;

	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}
}
