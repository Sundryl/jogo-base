using System.Collections.Generic;

public class UnitPresenceIndex
{
	private struct ArmySnapshot
	{
		public int currentProvinceId;

		public int targetProvinceId;
	}

	private struct NavySnapshot
	{
		public int currentProvinceId;
	}

	private readonly Dictionary<Army, ArmySnapshot> m_ArmySnapshots;

	private readonly Dictionary<Navy, NavySnapshot> m_NavySnapshots;

	private readonly HashSet<Army> m_DirtyArmies;

	private readonly HashSet<Navy> m_DirtyNavies;

	public void Clear()
	{
	}

	public void RebuildAllFromManagers()
	{
	}

	public void RegisterArmy(Army _army)
	{
	}

	public void UnregisterArmy(Army _army)
	{
	}

	public void MarkArmyDirty(Army _army)
	{
	}

	public void RegisterNavy(Navy _navy)
	{
	}

	public void UnregisterNavy(Navy _navy)
	{
	}

	public void MarkNavyDirty(Navy _navy)
	{
	}

	public void Flush()
	{
	}

	private void FlushArmies()
	{
	}

	private void FlushNavies()
	{
	}

	private static int ResolveProvinceIdFromCell(int _cell)
	{
		return 0;
	}

	private static int ResolveProvinceId(Province _province)
	{
		return 0;
	}

	private static bool IsProvinceIdInRange(int _provinceId)
	{
		return false;
	}

	private static void AddArmyToProvince(int _provinceId, Army _army)
	{
	}

	private static void RemoveArmyFromProvince(int _provinceId, Army _army)
	{
	}

	private static void AddArmyTargetToProvince(int _provinceId, Army _army)
	{
	}

	private static void RemoveArmyTargetFromProvince(int _provinceId, Army _army)
	{
	}

	private static void AddNavyToProvince(int _provinceId, Navy _navy)
	{
	}

	private static void RemoveNavyFromProvince(int _provinceId, Navy _navy)
	{
	}

	private static void ClearProvinceMappings()
	{
	}
}
