using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Pathfinding
{
	public static class ArmyPathfinding
	{
		private struct PathCacheEntry
		{
			public List<int> path;

			public double timeStamp;

			public int maskVersion;
		}

		private struct CacheNode
		{
			public long key;

			public PathCacheEntry value;

			public int prev;

			public int next;
		}

		private struct BinaryHeap
		{
			private int[] m_cells;

			private float[] m_priorities;

			private int m_count;

			public int Count => 0;

			public BinaryHeap(int capacity)
			{
				m_cells = null;
				m_priorities = null;
				m_count = 0;
			}

			public void Enqueue(int cell, float priority)
			{
			}

			public int Dequeue()
			{
				return 0;
			}

			public void Clear()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CPrecomputeProvinceNeighborDistancesRoutine_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private int _003CprovinceCount_003E5__2;

			private List<Vector2> _003Ccoord_003E5__3;

			private int _003CprocessedCount_003E5__4;

			private int _003Ci_003E5__5;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CPrecomputeProvinceNeighborDistancesRoutine_003Ed__47(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private static World world;

		private static Coroutine s_provincePrecomputeCoroutine;

		private const double PATH_CACHE_TIMEOUT = 60.0;

		private const int MAX_CACHE_SIZE = 1000;

		private const float NON_PORT_CELL_TRANSITION_PENALTY = 450f;

		private const float NON_PORT_PROVINCE_TRANSITION_PENALTY = 450f;

		private const float SEA_ROUTE_CELL_COST_MULTIPLIER = 0.02f;

		private const float SEA_ROUTE_PROVINCE_COST_MULTIPLIER = 0.05f;

		private const float COASTAL_PROVINCE_COST_MULTIPLIER = 0.2f;

		private const float MIN_WEIGHTED_MOVE_COST = 0.05f;

		private static Dictionary<long, int> s_cacheMap;

		private static List<CacheNode> s_cacheNodes;

		private static int s_cacheHead;

		private static int s_cacheTail;

		private static Stack<int> s_freeNodeIndices;

		private static int[] s_parentArray;

		private static float[] s_gArray;

		private static float[] s_fArray;

		private static int[] s_openVersionArray;

		private static int[] s_provinceMaskVer;

		private static int s_maskVersion;

		private static byte[] s_closedArray;

		private static int s_currentVersion;

		private static int[] s_provinceParentArray;

		private static float[] s_provinceGArray;

		private static float[] s_provinceFArray;

		private static int[] s_provinceOpenVersionArray;

		private static byte[] s_provinceClosedArray;

		private static int s_provinceVersion;

		private static List<List<float>> s_neighborDistances;

		private static List<Dictionary<int, float>> s_provinceNeighborDistances;

		private static float s_avgCellSpacing;

		private static float s_avgNeighborDistance;

		private static bool s_useSimplifiedCellDistances;

		private static BinaryHeap s_cellHeap;

		private static BinaryHeap s_provinceHeap;

		private static List<List<int>> s_cachedOceanRoutes;

		private static HashSet<int> s_oceanRouteCellSet;

		private static HashSet<int> s_oceanRouteProvinceSet;

		private static HashSet<int> s_coastalSeaProvinceSet;

		public static void Initialize(World worldInstance)
		{
		}

		public static void RecalculateNeighborDistances()
		{
		}

		private static void InitializePathfindingArrays()
		{
		}

		private static void PrecomputeNeighborDistances()
		{
		}

		public static void RecalculateProvinceNeighborDistancesAsync()
		{
		}

		[IteratorStateMachine(typeof(_003CPrecomputeProvinceNeighborDistancesRoutine_003Ed__47))]
		private static IEnumerator PrecomputeProvinceNeighborDistancesRoutine()
		{
			return null;
		}

		public static void OnProvinceCountChanged()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float GetNeighborDistance(Vector2 currentCoord, Vector2 neighborCoord)
		{
			return 0f;
		}

		public static void SetUseSimplifiedDistances(bool useSimplified)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float CalcOctileDistance(float dx, float dy, float D, float D2)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ProvinceAllowed(int pid)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsSeaCellInAnyPort(int seaCell, Dictionary<int, bool> portSeaCellCache)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsProvincePortCity(int provinceId)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float GetPortTransitionPenaltyForCells(int currentCell, int neighborCell, bool preferPortTransition, Dictionary<int, bool> portSeaCellCache)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float GetPortTransitionPenaltyForProvinces(int currentProvinceId, int neighborProvinceId, Province currentProvince, Province neighborProvince, bool preferPortTransition)
		{
			return 0f;
		}

		private static void InvalidateSeaRoutePreferenceCaches()
		{
		}

		private static void EnsureSeaRoutePreferenceCaches()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float GetSeaRouteCellCostMultiplier(int cell, bool enableSeaRoutePreference, HashSet<int> oceanRouteCellSet)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float GetSeaRouteProvinceCostMultiplier(int provinceId, bool enableSeaRoutePreference, HashSet<int> oceanRouteProvinceSet, HashSet<int> coastalSeaProvinceSet)
		{
			return 0f;
		}

		private static void PrepareSeaRoutePreferenceSets(bool enableSeaRoutePreference, out HashSet<int> oceanRouteCellSet, out HashSet<int> oceanRouteProvinceSet, out HashSet<int> coastalSeaProvinceSet)
		{
			oceanRouteCellSet = null;
			oceanRouteProvinceSet = null;
			coastalSeaProvinceSet = null;
		}

		private static long GetPathCacheKey(int start, int end, HashSet<int> provincePath, bool preferPortTransition, bool enableSeaRoutePreference)
		{
			return 0L;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void TouchNode(int idx)
		{
		}

		private static void EvictNode(int idx)
		{
		}

		private static void EvictTail()
		{
		}

		private static void InsertOrUpdateCache(long key, List<int> path, double now)
		{
		}

		private static void CleanupCache(double now)
		{
		}

		private static void ClearPathCache()
		{
		}

		public static List<int> FindCellPathInProvinces(int start, int end, HashSet<int> provincePath, bool preferPortTransition = false, bool enableSeaRoutePreference = true)
		{
			return null;
		}

		public static List<int> FindProvincePath(int startProvinceID, int endProvinceID, State armyState, bool isCheckPassable = false, bool preferPortTransition = false, bool allowLand = true, bool allowSea = true, bool enableSeaRoutePreference = true)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float CalcCellDistance(Vector2 coord1, Vector2 coord2)
		{
			return 0f;
		}

		public static void PerformanceTest()
		{
		}

		public static List<int> FindPathInsideProvince(int start, int end, int province)
		{
			return null;
		}

		public static List<int> FindPathBetweenCells(int start, int end, bool preferPortTransition = false, bool enableSeaRoutePreference = true)
		{
			return null;
		}

		public static List<int> FindPathBetweenCellsByTerrain(int start, int end, bool allowLand, bool allowSea)
		{
			return null;
		}
	}
}
