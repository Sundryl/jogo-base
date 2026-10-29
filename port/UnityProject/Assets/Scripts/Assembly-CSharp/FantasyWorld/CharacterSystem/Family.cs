using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;
using csDelaunay;

namespace FantasyWorld.CharacterSystem
{
	[Serializable]
	public class Family
	{
		public int id;

		public string surname;

		public string cultureName;

		public int patriarchId;

		public int heirId;

		public int founderId;

		public List<int> memberIds;

		public List<int> collateralMemberIds;

		public bool allowFemaleInheritance;

		public List<int> matrilinealSpouses;

		public Dictionary<int, float> historicalClaims;

		public int originalHomeProvinceId;

		public bool skipNextRedistribution;

		public float influence;

		public int wealth;

		public int homeProvinceId;

		public List<int> controlledProvinces;

		public int extendedMembers;

		public Dictionary<int, float> relations;

		public float totalEnemyDestroyed;

		public int totalProvincesConquered;

		public HashSet<int> historicalStateIds;

		public Dictionary<int, double> lastRulingTime;

		public Dictionary<int, float> rulingDuration;

		public Dictionary<int, float> stateResidenceMonths;

		public float rallyCooldownTime;

		public int stateId;

		public int updateDay;

		private bool m_IsRulingFamily;

		public string religionId;

		public double foundingTime;

		[JsonIgnore]
		public Color color;

		public string colorString;

		[JsonIgnore]
		public Vector2f polePos;

		[JsonIgnore]
		public int poleCellIndex;

		[JsonIgnore]
		public GameObject familyLabelObject;

		[JsonIgnore]
		public bool isNeedNameLabelUpdate;

		[JsonIgnore]
		public bool isNeedBorderLineUpdate;

		[JsonIgnore]
		public bool isLabelPlaced;

		public bool isRulingFamily
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[JsonIgnore]
		public Character Patriarch => null;

		[JsonIgnore]
		public Character Founder => null;

		[JsonIgnore]
		public Dictionary<int, List<HistoryEvent>> HistoryEventsByYear => null;

		public void AddMember(int characterId)
		{
		}

		public void RemoveMember(int characterId)
		{
		}

		public void AddControlledProvince(int provinceId)
		{
		}

		public void RemoveControlledProvince(int provinceId)
		{
		}

		public void SetRelation(int familyId, float value)
		{
		}

		public float GetRelation(int familyId)
		{
			return 0f;
		}

		public void ChangeRelation(int familyId, float delta)
		{
		}

		public float GetTotalRelation(Family otherFamily)
		{
			return 0f;
		}

		public float CalculateFamilyStrength()
		{
			return 0f;
		}

		public bool HasValidHeir()
		{
			return false;
		}

		public List<Character> GetLivingMembers()
		{
			return null;
		}

		public List<Character> GetUnmarriedAdults()
		{
			return null;
		}

		public void AddEnemyDestroyed(float enemyDestroyed)
		{
		}

		public void AddConqueredProvince(int provinceId)
		{
		}

		public float GetWarMerit()
		{
			return 0f;
		}

		public string GetLocalizedName()
		{
			return null;
		}

		public void SetNewName(string newName)
		{
		}

		public void GenerateRandomColor()
		{
		}

		public void UpdateColor(Color newColor)
		{
		}

		public void SetFamilyLabelTriggerCheck(bool enable)
		{
		}

		public void RecordHistoryEvent(HistoryEvent newEvent)
		{
		}

		public List<HistoryEvent> GetAllHistoryEvents()
		{
			return null;
		}

		public List<HistoryEvent> GetHistoryEventsByYearRange(int startYear, int endYear)
		{
			return null;
		}

		public List<HistoryEvent> GetHistoryEventsInYear(int year)
		{
			return null;
		}

		public Dictionary<int, List<HistoryEvent>> GetHistoryEventsByYear()
		{
			return null;
		}

		public Dictionary<int, List<HistoryEvent>> GetImportantHistoryEventsByYear()
		{
			return null;
		}

		private bool IsLeaderEventForThisFamily(HistoryEvent historyEvent)
		{
			return false;
		}

		private bool IsEventLeaderFromThisFamily(HistoryEvent historyEvent)
		{
			return false;
		}

		private bool IsImportantHistoryEvent(HistoryEvent historyEvent)
		{
			return false;
		}

		private bool IsImportantBirthForFamily(CharacterBirthEvent birthEvent)
		{
			return false;
		}

		public string GetHistoryInYear(double t, bool isNeedDefaultFont = true)
		{
			return null;
		}

		public void ClearHistoricalData()
		{
		}

		public void Clear()
		{
		}
	}
}
