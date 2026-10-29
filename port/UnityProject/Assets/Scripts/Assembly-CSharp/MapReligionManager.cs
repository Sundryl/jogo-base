using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class MapReligionManager
{
	private static MapReligionManager m_Instance;

	public int updateBatchSize;

	private int updateIndex;

	public Dictionary<string, MapReligion> religions;

	private HashSet<int> holyProvinces;

	[CompilerGenerated]
	private Action<MapReligion> m_HolyProvinceChanged;

	public static MapReligionManager Instance => null;

	public event Action<MapReligion> HolyProvinceChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void NotifyHolyProvinceChanged(MapReligion mapReligion)
	{
	}

	public string Serialize()
	{
		return null;
	}

	public void Deserialize(string json)
	{
	}

	private void PostDeserialize()
	{
	}

	public MapReligion GetReligion(string _religionId)
	{
		return null;
	}

	public void AddOrUpdateReligion(string _religionId, MapReligion _mapReligion)
	{
	}

	public bool RemoveReligion(string _religionId)
	{
		return false;
	}

	public void Start()
	{
	}

	public void Update()
	{
	}

	private void BatchUpdate()
	{
	}

	public void Clear()
	{
	}

	public void CreateAllReligionLabels()
	{
	}

	private void CreateReligionLabel(MapReligion religion)
	{
	}

	public void ForceUpdateReligionBorder()
	{
	}

	public void ForceUpdateReligionName()
	{
	}

	public void UpdateReligionName(MapReligion religion)
	{
	}

	public bool IsHolyProvince(int provinceID)
	{
		return false;
	}

	public List<string> GetAvailableMapReligionIds()
	{
		return null;
	}

	public string GetRandomMapReligionId(bool excludeAtheism = false)
	{
		return null;
	}

	public MapReligion EnsureMapReligionExists(string religionId)
	{
		return null;
	}

	public void CreateMapReligionsFromEnabledTemplates()
	{
	}

	public MapReligion CreateMapReligionFromTemplate(string templateId)
	{
		return null;
	}

	private void AssignHolyProvinceToReligion(MapReligion mapReligion)
	{
	}

	private List<Province> GetValidLandProvinces()
	{
		return null;
	}

	private Province SelectBestHolyProvince(string religionId, List<Province> candidates)
	{
		return null;
	}

	private bool TryValidateExistingHolyProvince(MapReligion mapReligion, string logPrefix, bool logIssues, out Province province)
	{
		province = null;
		return false;
	}

	private void RefreshHolyProvinces(string logPrefix, bool logIssues)
	{
	}

	public void SetHolyProvince(string religionId, int provinceId)
	{
	}

	public List<MapReligion> GetAllMapReligions()
	{
		return null;
	}

	public void AssignHolyProvincesToReligions()
	{
	}

	public void AssignReligionsToProvinces()
	{
	}

	private MapReligion FindNearestReligion(Province province)
	{
		return null;
	}

	private float CalculateDistance(Province province1, Province province2)
	{
		return 0f;
	}

	public void InitializeProvinceReligion(Province province, MapReligion mainReligion = null)
	{
	}

	public bool ReassignHolyProvince(string religionId, int excludeProvinceId = -1)
	{
		return false;
	}

	public void HandleHolyProvinceReligionChange(int provinceId, string newReligionId)
	{
	}

	public void MigrateFromLegacyVersion()
	{
	}

	public void ValidateAndAssignHolyProvinces()
	{
	}
}
