using System.Collections.Generic;
using NodaTime;
using Unity.Profiling;

public class ProvinceManager
{
	private static readonly ProfilerMarker s_UpdateProfilerMarker;

	private static readonly ProfilerMarker s_FlushUnitPresenceProfilerMarker;

	private static readonly ProfilerMarker s_BatchUpdateProfilerMarker;

	private static readonly ProfilerMarker s_BatchUpdateProvinceProfilerMarker;

	private static readonly ProfilerMarker s_BatchUpdateBattleSwordProfilerMarker;

	public int updateBatchSize;

	private int updateIndex;

	private readonly UnitPresenceIndex m_UnitPresenceIndex;

	private readonly List<int> m_WorldPopulationMedianBuffer;

	private int m_WorldMedianProvincePopulation;

	public Dictionary<int, List<Province>> provinceFeatureDict;

	private int m_BurgNameMismatchCount;

	private readonly List<string> m_BurgNameMismatchDetails;

	private int m_ProvinceNameMismatchCount;

	private readonly List<string> m_ProvinceNameMismatchDetails;

	private bool m_IsBurgNameValidationEnabled;

	private bool m_IsBurgOverrideProvinceEnabled;

	private static ProvinceManager _instance;

	public List<Province> provinces;

	internal bool IsBurgNameValidationEnabled => false;

	internal bool IsBurgOverrideProvinceEnabled => false;

	public static ProvinceManager Instance => null;

	public int WorldMedianProvincePopulation => 0;

	public UnitPresenceIndex UnitPresenceIndex => null;

	public string Serialize()
	{
		return null;
	}

	public void Deserialize(string json)
	{
	}

	public static ParsedProvinceData ParseJsonOnly(string json)
	{
		return null;
	}

	public void ApplyParsedData(ParsedProvinceData data)
	{
	}

	public void PostLoadSaveData()
	{
	}

	private void ResetBurgNameMismatchStats()
	{
	}

	private void ResetProvinceNameMismatchStats()
	{
	}

	internal void RecordBurgNameMismatch(Province province, BurgData burg, string provinceDisplayName, string previousBurgName, Dictionary<string, string> previousTranslations)
	{
	}

	internal void RecordProvinceNameMismatch(Province province, BurgData burg, string provinceDisplayName, string previousProvinceName, Dictionary<string, string> previousTranslations, Dictionary<string, string> currentTranslations)
	{
	}

	public void SetBurgNameValidationEnabled(bool isEnabled)
	{
	}

	public void SetBurgOverrideProvinceEnabled(bool isEnabled)
	{
	}

	internal static bool IsBurgPlaceholderName(string value)
	{
		return false;
	}

	public void RecalculateFeatureDict()
	{
	}

	public Province FindNearestSeaProvince(Province province)
	{
		return null;
	}

	public void Update()
	{
	}

	public bool IsProvinceIdValid(int _provinceId)
	{
		return false;
	}

	public void SetProvinces(List<Province> provinces)
	{
	}

	public void InitProvinceStateRelation()
	{
	}

	public void Start()
	{
	}

	public void RefreshWorldPopulationMedian()
	{
	}

	public float GetAverageProvinceBattleScore()
	{
		return 0f;
	}

	public void AssignRandomUpdateDays(LocalDate currentDate)
	{
	}

	public void UpdateProvinces(LocalDate currentDate)
	{
	}

	public Province GetProvince(int id)
	{
		return null;
	}

	public void CaptureHistory(long t)
	{
	}

	public void Clear()
	{
	}

	public void FlushUnitPresenceMapping()
	{
	}

	public void BatchUpdate()
	{
	}

	internal int GetTotalPopulation()
	{
		return 0;
	}

	internal int GetMaxPopulation()
	{
		return 0;
	}

	public void CheckProvinceBurgVisibility()
	{
	}

	internal void RefreshProvinceName()
	{
	}
}
