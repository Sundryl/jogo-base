using UnityEngine;
using UnityEngine.Events;

public class SDFTextureGeneratorExample : MonoBehaviour
{
	[SerializeField]
	private Texture _sourceTexture;

	[SerializeField]
	private float _sourceValueThreshold;

	[SerializeField]
	private SDFTextureGenerator.DownSampling _downSampling;

	[SerializeField]
	private SDFTextureGenerator.Precision _precision;

	[SerializeField]
	[Header("Output")]
	private UnityEvent<RenderTexture> _sdfTextureEvent;

	public SDFTextureGenerator _generator;

	public bool isNeedUpdate;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public void UpdateTexture()
	{
	}
}
