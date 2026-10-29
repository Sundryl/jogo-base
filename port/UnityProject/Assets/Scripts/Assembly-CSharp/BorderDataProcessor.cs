using System;
using System.Collections.Generic;
using UnityEngine;
using csDelaunay;

public class BorderDataProcessor : MonoBehaviour
{
	public class UpdateStateLineParams
	{
		public int RequestId;

		public HashSet<int> StateNeedUpdate;

		public HashSet<int> ProvinceNeedUpdate;

		public bool IsCoastLineRecal;

		public bool isProvinceBorderLineNeedRecal;

		public double provinceBorderUpdateTimeStamp;

		public Dictionary<int, int[]> StateProvinceIdsSnapshot;

		public Dictionary<int, int[]> ProvinceCellsSnapshot;

		public Dictionary<int, int[]> ProvinceBorderCellsSnapshot;
	}

	public struct UpdateLineParams
	{
		public HashSet<int> NeedUpdateIds;

		public HashSet<string> NeedUpdateStrings;
	}

	private class StateLineTaskResult
	{
		public int RequestId;

		public HashSet<int> StateNeedUpdate;

		public HashSet<int> ProvinceNeedUpdate;

		public Dictionary<int, List<List<Vector3>>> StateLineCache;

		public Dictionary<int, List<List<Vector3>>> StateLineSampleCache;

		public Dictionary<int, List<List<Vector3>>> ProvinceLineCache;

		public Dictionary<int, List<int>> ProvinceBorderCellsCache;

		public Dictionary<int, Vector2f> StatePoleCache;
	}

	private class Vector2fComparer : IEqualityComparer<Vector2f>
	{
		private const float Epsilon = 0.01f;

		public bool Equals(Vector2f x, Vector2f y)
		{
			return false;
		}

		public int GetHashCode(Vector2f obj)
		{
			return 0;
		}
	}

	private static BorderDataProcessor s_Instance;

	private Dictionary<int, List<List<Vector3>>> m_StateLineCache;

	private Dictionary<int, List<List<Vector3>>> m_StateLineSampleCache;

	private Dictionary<int, List<List<Vector3>>> m_ProvinceLineCache;

	private Dictionary<string, List<List<Vector3>>> m_ReligionLineCache;

	private Dictionary<string, List<List<Vector3>>> m_CultureLineCache;

	private Dictionary<int, List<List<Vector3>>> m_DistrictLineCache;

	private Dictionary<int, List<List<Vector3>>> m_FamilyLineCache;

	private Dictionary<int, List<List<Vector3>>> m_AllianceLineCache;

	private List<List<Vector3>> m_CoastLineCache;

	private List<List<Vector3>> m_ShallowLineCache;

	private Dictionary<int, List<int>> m_ProvinceBorderCellsCache;

	private List<bool> m_CoastLineDirection;

	private Dictionary<int, Vector2f> m_StatePoleCache;

	private Dictionary<string, Vector2f> m_ReligionPoleCache;

	private Dictionary<string, Vector2f> m_CulturePoleCache;

	private Dictionary<int, Vector2f> m_DistrictPoleCache;

	private Dictionary<int, Vector2f> m_FamilyPoleCache;

	private Dictionary<int, Vector2f> m_AlliancePoleCache;

	private int[] m_stateCache;

	private int[] m_provinceCache;

	private string[] m_religionCache;

	private string[] m_cultureCache;

	private int[] m_districtCache;

	private int[] m_familyCache;

	private int[] m_allianceCache;

	private int[] m_elvationCache;

	private bool m_IsLineUpdateDone;

	private bool m_IsReligionLineUpdateDone;

	private bool m_IsCultureLineUpdateDone;

	private bool m_IsDistrictLineUpdateDone;

	private bool m_IsFamilyLineUpdateDone;

	private bool m_IsAllianceLineUpdateDone;

	private bool m_IsCoastLineNeedRecal;

	private bool m_IsProvinceBorderLineNeedRecal;

	private bool m_IsDropLastBorderCal;

	private bool m_IsUpdateStateLineTaskCompleted;

	private bool m_IsUpdateReligionLineTaskCompleted;

	private bool m_IsUpdateCultureLineTaskCompleted;

	private bool m_IsUpdateDistrictLineTaskCompleted;

	private bool m_IsUpdateFamilyLineTaskCompleted;

	private bool m_IsUpdateAllianceLineTaskCompleted;

	private int m_StateLineTaskRequestId;

	private readonly object m_StateLineTaskResultLock;

	private StateLineTaskResult m_PendingStateLineTaskResult;

	private double m_ProvinceBorderUpdateTimeStamp;

	public static BorderDataProcessor Instance => null;

	public bool IsCoastLineNeedRecal
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsProvinceBorderLineNeedRecal
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsDropLastBorderCal
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public void InitBorderDataCache()
	{
	}

	private static T[] EnsureCacheSize<T>(T[] cache, int cellCount)
	{
		return null;
	}

	public void UpdateBordersCal()
	{
	}

	private void UpdateStateLineTask(object stateObj)
	{
	}

	private void PublishPendingStateLineTaskResult()
	{
	}

	private bool IsStateLineTaskResultStale(StateLineTaskResult result)
	{
		return false;
	}

	private Dictionary<int, int[]> BuildStateProvinceIdsSnapshot(HashSet<int> stateNeedUpdate)
	{
		return null;
	}

	private Dictionary<int, int[]> BuildProvinceCellsSnapshot(HashSet<int> provinceNeedUpdate)
	{
		return null;
	}

	private Dictionary<int, int[]> BuildProvinceBorderCellsSnapshot(Dictionary<int, int[]> stateProvinceIdsSnapshot)
	{
		return null;
	}

	private StateLineTaskResult UpdateStateLine(UpdateStateLineParams param)
	{
		return null;
	}

	private void UpdateCoastLine()
	{
	}

	private void UpdateShallowLine()
	{
	}

	private void UpdateProvinceBorder(UpdateStateLineParams param, StateLineTaskResult result)
	{
	}

	public void UpdateReligionBordersCal()
	{
	}

	private void UpdateReligionLineTask(object religionObj)
	{
	}

	private void CalculateReligionBorders(HashSet<string> religionNeedUpdate)
	{
	}

	public void UpdateCultureBordersCal()
	{
	}

	private void UpdateCultureLineTask(object cultureObj)
	{
	}

	private void CalculateCultureBorders(HashSet<string> cultureNeedUpdate)
	{
	}

	public void UpdateDistrictBordersCal()
	{
	}

	public void UpdateFamilyBordersCal()
	{
	}

	public void UpdateAllianceBordersCal()
	{
	}

	private void UpdateDistrictLineTask(object districtObj)
	{
	}

	private void CalculateDistrictBorders(HashSet<int> districtNeedUpdate)
	{
	}

	private void UpdateFamilyLineTask(object familyObj)
	{
	}

	private void UpdateAllianceLineTask(object allianceObj)
	{
	}

	private void CalculateFamilyBorders(HashSet<int> familyNeedUpdate)
	{
	}

	private void CalculateAllianceBorders(HashSet<int> allianceNeedUpdate)
	{
	}

	public Vector3[] GetLineVertices(List<Vector2f> vertices, float z = -0.003f)
	{
		return null;
	}

	public static bool TriangleIsCCW(Vector2f a, Vector2f b, Vector2f c)
	{
		return false;
	}

	public List<Vector3> GetRiverLine(int i)
	{
		return null;
	}

	private bool IsCoastLineEdge(Edge edge)
	{
		return false;
	}

	public bool IsBorderLineUpdateDone()
	{
		return false;
	}

	public void ClearCache()
	{
	}

	private bool RemoveBorderLineGeneric<T>(Dictionary<T, List<List<Vector3>>> _cache, Dictionary<T, Vector2f> _poleCache, T _id, string _typeName, Action<T> _rendererCallback)
	{
		return false;
	}

	public bool RemoveCultureLine(string _cultureNameID)
	{
		return false;
	}

	public bool RemoveDistrictLine(int _districtId)
	{
		return false;
	}

	public bool RemoveReligionLine(string _religionId)
	{
		return false;
	}
}
