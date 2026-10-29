using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class SDFTextureGenerator
{
	[SerializeField]
	public enum DownSampling
	{
		None = 0,
		Half = 1,
		Quater = 2
	}

	[SerializeField]
	public enum Precision
	{
		_16 = 0,
		_32 = 1
	}

	private static class ShaderIDs
	{
		public static readonly int seedTexRead;

		public static readonly int sdfTex;

		public static readonly int floodTex;

		public static readonly int floodTexRead;

		public static readonly int resolution;

		public static readonly int stepSize;

		public static readonly int seedThreshold;

		public static readonly int texelSize;
	}

	public RenderTexture _sdfTexture;

	private RenderTexture _jfaTexture;

	private ComputeShader _computeShader;

	private int _seedKernel;

	private int _floodKernel;

	private int _distKernel;

	private int _showSeedsKernel;

	private Vector2Int _groupThreadCount;

	private const int threadGroupWidth = 8;

	public RenderTexture sdfTexture => null;

	public void Update(Texture sourceTexture, float sourceValueThreshold, DownSampling downSampling = DownSampling.None, Precision precision = Precision._32, bool _showSource = false)
	{
	}

	private static RenderTexture CreateTexture(string name, Vector2Int resolution, GraphicsFormat format)
	{
		return null;
	}

	public void Release()
	{
	}
}
