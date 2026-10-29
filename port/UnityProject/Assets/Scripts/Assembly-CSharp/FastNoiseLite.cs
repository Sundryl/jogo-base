using System.Runtime.CompilerServices;

public class FastNoiseLite
{
	public enum NoiseType
	{
		OpenSimplex2 = 0,
		OpenSimplex2S = 1,
		Cellular = 2,
		Perlin = 3,
		ValueCubic = 4,
		Value = 5
	}

	public enum RotationType3D
	{
		None = 0,
		ImproveXYPlanes = 1,
		ImproveXZPlanes = 2
	}

	public enum FractalType
	{
		None = 0,
		FBm = 1,
		Ridged = 2,
		PingPong = 3,
		DomainWarpProgressive = 4,
		DomainWarpIndependent = 5
	}

	public enum CellularDistanceFunction
	{
		Euclidean = 0,
		EuclideanSq = 1,
		Manhattan = 2,
		Hybrid = 3
	}

	public enum CellularReturnType
	{
		CellValue = 0,
		Distance = 1,
		Distance2 = 2,
		Distance2Add = 3,
		Distance2Sub = 4,
		Distance2Mul = 5,
		Distance2Div = 6
	}

	public enum DomainWarpType
	{
		OpenSimplex2 = 0,
		OpenSimplex2Reduced = 1,
		BasicGrid = 2
	}

	private enum TransformType3D
	{
		None = 0,
		ImproveXYPlanes = 1,
		ImproveXZPlanes = 2,
		DefaultOpenSimplex2 = 3
	}

	private const short INLINE = 256;

	private const short OPTIMISE = 512;

	private int mSeed;

	private float mFrequency;

	private NoiseType mNoiseType;

	private RotationType3D mRotationType3D;

	private TransformType3D mTransformType3D;

	private FractalType mFractalType;

	private int mOctaves;

	private float mLacunarity;

	private float mGain;

	private float mWeightedStrength;

	private float mPingPongStrength;

	private float mFractalBounding;

	private CellularDistanceFunction mCellularDistanceFunction;

	private CellularReturnType mCellularReturnType;

	private float mCellularJitterModifier;

	private DomainWarpType mDomainWarpType;

	private TransformType3D mWarpTransformType3D;

	private float mDomainWarpAmp;

	private static readonly float[] Gradients2D;

	private static readonly float[] RandVecs2D;

	private static readonly float[] Gradients3D;

	private static readonly float[] RandVecs3D;

	private const int PrimeX = 501125321;

	private const int PrimeY = 1136930381;

	private const int PrimeZ = 1720413743;

	public FastNoiseLite(int seed = 1337)
	{
	}

	public void SetSeed(int seed)
	{
	}

	public void SetFrequency(float frequency)
	{
	}

	public void SetNoiseType(NoiseType noiseType)
	{
	}

	public void SetRotationType3D(RotationType3D rotationType3D)
	{
	}

	public void SetFractalType(FractalType fractalType)
	{
	}

	public void SetFractalOctaves(int octaves)
	{
	}

	public void SetFractalLacunarity(float lacunarity)
	{
	}

	public void SetFractalGain(float gain)
	{
	}

	public void SetFractalWeightedStrength(float weightedStrength)
	{
	}

	public void SetFractalPingPongStrength(float pingPongStrength)
	{
	}

	public void SetCellularDistanceFunction(CellularDistanceFunction cellularDistanceFunction)
	{
	}

	public void SetCellularReturnType(CellularReturnType cellularReturnType)
	{
	}

	public void SetCellularJitter(float cellularJitter)
	{
	}

	public void SetDomainWarpType(DomainWarpType domainWarpType)
	{
	}

	public void SetDomainWarpAmp(float domainWarpAmp)
	{
	}

	[MethodImpl((MethodImplOptions)512)]
	public float GetNoise(float x, float y)
	{
		return 0f;
	}

	[MethodImpl((MethodImplOptions)512)]
	public float GetNoise(float x, float y, float z)
	{
		return 0f;
	}

	[MethodImpl((MethodImplOptions)512)]
	public void DomainWarp(ref float x, ref float y)
	{
	}

	[MethodImpl((MethodImplOptions)512)]
	public void DomainWarp(ref float x, ref float y, ref float z)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static float FastMin(float a, float b)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static float FastMax(float a, float b)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static float FastAbs(float f)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static float FastSqrt(float f)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int FastFloor(float f)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int FastRound(float f)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static float Lerp(float a, float b, float t)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static float InterpHermite(float t)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static float InterpQuintic(float t)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static float CubicLerp(float a, float b, float c, float d, float t)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static float PingPong(float t)
	{
		return 0f;
	}

	private void CalculateFractalBounding()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int Hash(int seed, int xPrimed, int yPrimed)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int Hash(int seed, int xPrimed, int yPrimed, int zPrimed)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static float ValCoord(int seed, int xPrimed, int yPrimed)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static float ValCoord(int seed, int xPrimed, int yPrimed, int zPrimed)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static float GradCoord(int seed, int xPrimed, int yPrimed, float xd, float yd)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static float GradCoord(int seed, int xPrimed, int yPrimed, int zPrimed, float xd, float yd, float zd)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void GradCoordOut(int seed, int xPrimed, int yPrimed, out float xo, out float yo)
	{
		xo = default;
		yo = default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void GradCoordOut(int seed, int xPrimed, int yPrimed, int zPrimed, out float xo, out float yo, out float zo)
	{
		xo = default;
		yo = default;
		zo = default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void GradCoordDual(int seed, int xPrimed, int yPrimed, float xd, float yd, out float xo, out float yo)
	{
		xo = default;
		yo = default;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void GradCoordDual(int seed, int xPrimed, int yPrimed, int zPrimed, float xd, float yd, float zd, out float xo, out float yo, out float zo)
	{
		xo = default;
		yo = default;
		zo = default;
	}

	private float GenNoiseSingle(int seed, float x, float y)
	{
		return 0f;
	}

	private float GenNoiseSingle(int seed, float x, float y, float z)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void TransformNoiseCoordinate(ref float x, ref float y)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void TransformNoiseCoordinate(ref float x, ref float y, ref float z)
	{
	}

	private void UpdateTransformType3D()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void TransformDomainWarpCoordinate(ref float x, ref float y)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void TransformDomainWarpCoordinate(ref float x, ref float y, ref float z)
	{
	}

	private void UpdateWarpTransformType3D()
	{
	}

	private float GenFractalFBm(float x, float y)
	{
		return 0f;
	}

	private float GenFractalFBm(float x, float y, float z)
	{
		return 0f;
	}

	private float GenFractalRidged(float x, float y)
	{
		return 0f;
	}

	private float GenFractalRidged(float x, float y, float z)
	{
		return 0f;
	}

	private float GenFractalPingPong(float x, float y)
	{
		return 0f;
	}

	private float GenFractalPingPong(float x, float y, float z)
	{
		return 0f;
	}

	private float SingleSimplex(int seed, float x, float y)
	{
		return 0f;
	}

	private float SingleOpenSimplex2(int seed, float x, float y, float z)
	{
		return 0f;
	}

	private float SingleOpenSimplex2S(int seed, float x, float y)
	{
		return 0f;
	}

	private float SingleOpenSimplex2S(int seed, float x, float y, float z)
	{
		return 0f;
	}

	private float SingleCellular(int seed, float x, float y)
	{
		return 0f;
	}

	private float SingleCellular(int seed, float x, float y, float z)
	{
		return 0f;
	}

	private float SinglePerlin(int seed, float x, float y)
	{
		return 0f;
	}

	private float SinglePerlin(int seed, float x, float y, float z)
	{
		return 0f;
	}

	private float SingleValueCubic(int seed, float x, float y)
	{
		return 0f;
	}

	private float SingleValueCubic(int seed, float x, float y, float z)
	{
		return 0f;
	}

	private float SingleValue(int seed, float x, float y)
	{
		return 0f;
	}

	private float SingleValue(int seed, float x, float y, float z)
	{
		return 0f;
	}

	private void DoSingleDomainWarp(int seed, float amp, float freq, float x, float y, ref float xr, ref float yr)
	{
	}

	private void DoSingleDomainWarp(int seed, float amp, float freq, float x, float y, float z, ref float xr, ref float yr, ref float zr)
	{
	}

	private void DomainWarpSingle(ref float x, ref float y)
	{
	}

	private void DomainWarpSingle(ref float x, ref float y, ref float z)
	{
	}

	private void DomainWarpFractalProgressive(ref float x, ref float y)
	{
	}

	private void DomainWarpFractalProgressive(ref float x, ref float y, ref float z)
	{
	}

	private void DomainWarpFractalIndependent(ref float x, ref float y)
	{
	}

	private void DomainWarpFractalIndependent(ref float x, ref float y, ref float z)
	{
	}

	private void SingleDomainWarpBasicGrid(int seed, float warpAmp, float frequency, float x, float y, ref float xr, ref float yr)
	{
	}

	private void SingleDomainWarpBasicGrid(int seed, float warpAmp, float frequency, float x, float y, float z, ref float xr, ref float yr, ref float zr)
	{
	}

	private void SingleDomainWarpSimplexGradient(int seed, float warpAmp, float frequency, float x, float y, ref float xr, ref float yr, bool outGradOnly)
	{
	}

	private void SingleDomainWarpOpenSimplex2Gradient(int seed, float warpAmp, float frequency, float x, float y, float z, ref float xr, ref float yr, ref float zr, bool outGradOnly)
	{
	}
}
