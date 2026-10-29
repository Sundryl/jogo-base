using System.Collections.Generic;
using UnityEngine;

public sealed class BattleFxSystem
{
	private static BattleFxSystem s_Instance;

	private readonly Dictionary<long, BattleFxRuntime> m_ActiveFxByKey;

	private readonly List<long> m_RemoveBuffer;

	private Transform m_FxRoot;

	private bool m_IsVisible;

	private const float c_ZPosition = -0.1f;

	private const float c_LandHoldDuration = 2.6f;

	private const float c_SeaHoldDuration = 1.4f;

	private const float c_PortHoldDuration = 1.8f;

	public static BattleFxSystem Instance => null;

	public bool IsVisible => false;

	private BattleFxSystem()
	{
	}

	public void Update(float _deltaTime)
	{
	}

	public void Reset()
	{
	}

	public void SetVisible(bool _isVisible)
	{
	}

	public void ReportLandBattle(int _provinceId, Vector3 _worldPosition, float _intensity = 1f)
	{
	}

	public void ClearLandBattle(int _provinceId)
	{
	}

	public void ReportSeaBattle(int _seaProvinceId, Vector3 _worldPosition, float _intensity = 1f)
	{
	}

	public void ClearSeaBattle(int _seaProvinceId)
	{
	}

	public void ReportPortBattle(int _portProvinceId, Vector3 _worldPosition, float _intensity = 1f)
	{
	}

	public void ClearPortBattle(int _portProvinceId)
	{
	}

	private void Upsert(BattleFxChannel _channel, int _sourceId, Vector3 _worldPosition, float _holdDuration, float _intensity)
	{
	}

	private void Remove(BattleFxChannel _channel, int _sourceId)
	{
	}

	private static void ReleaseRuntime(BattleFxRuntime _runtime)
	{
	}

	private Transform EnsureRoot()
	{
		return null;
	}

	private static long ComposeKey(BattleFxChannel _channel, int _sourceId)
	{
		return 0L;
	}
}
