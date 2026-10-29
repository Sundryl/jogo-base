using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FantasyWorld.CharacterSystem
{
	[Serializable]
	public class Character
	{
		public int id;

		public string firstName;

		[JsonProperty]
		private string m_LastName;

		public int age;

		public Gender gender;

		[JsonProperty("BaseCharisma")]
		private float m_BaseCharisma;

		[JsonProperty("BaseMilitarySkill")]
		private float m_BaseMilitarySkill;

		[JsonProperty("BaseDiplomaticSkill")]
		private float m_BaseDiplomaticSkill;

		[JsonProperty("BaseAdministrativeSkill")]
		private float m_BaseAdministrativeSkill;

		[JsonIgnore]
		public List<CharacterTrait> traits;

		[JsonIgnore]
		private List<string> m_SerializedTraitNames;

		[JsonIgnore]
		private Dictionary<string, CharacterTrait> m_LegacySerializedTraits;

		public double birthTime;

		public double deathTime;

		public bool isAlive;

		public int familyId;

		public int stateId;

		public string cultureName;

		public string religionId;

		public int spouseId;

		public int fatherId;

		public int motherId;

		public List<int> childrenIds;

		public MarriageType marriageType;

		public int originalFamilyId;

		private List<Role> _roles;

		private List<PastRole> _pastRoles;

		public bool isHistoricallyImportant;

		public string LastName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string FullName => null;

		[JsonIgnore]
		public string fullName => null;

		[JsonIgnore]
		public float Charisma => 0f;

		[JsonIgnore]
		public float MilitarySkill => 0f;

		[JsonIgnore]
		public float DiplomaticSkill => 0f;

		[JsonIgnore]
		public float AdministrativeSkill => 0f;

		[JsonIgnore]
		public float BaseCharisma
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[JsonIgnore]
		public float BaseMilitarySkill
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[JsonIgnore]
		public float BaseDiplomaticSkill
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[JsonIgnore]
		public float BaseAdministrativeSkill
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[JsonProperty("traits")]
		private JArray SerializedTraits
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<Role> roles
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<PastRole> pastRoles
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private CultureData GetCultureDataForFullName()
		{
			return null;
		}

		internal void RestoreTraitsAfterLoad(IReadOnlyDictionary<string, CharacterTrait> _traitTemplatesByName)
		{
		}

		public string GetOriginalSurname()
		{
			return null;
		}

		public void ClearHistoricalData(ISet<int> removedHistoricalFamilyIds = null)
		{
		}

		public void Die()
		{
		}

		public void UpdateAge()
		{
		}

		public void AddTrait(CharacterTrait trait)
		{
		}

		public void RemoveTrait(CharacterTrait trait)
		{
		}

		public bool IsSpouseOf(int characterId)
		{
			return false;
		}

		public bool IsParentOf(int characterId)
		{
			return false;
		}

		public bool IsChildOf(int characterId)
		{
			return false;
		}

		private float CalculateFinalSkillValue(float baseValue, float totalModifiers)
		{
			return 0f;
		}

		private float GetCharismaModifiers()
		{
			return 0f;
		}

		private float GetMilitaryModifiers()
		{
			return 0f;
		}

		private float GetDiplomaticModifiers()
		{
			return 0f;
		}

		private float GetAdministrativeModifiers()
		{
			return 0f;
		}

		public float GetTaxEfficiencyModifier()
		{
			return 0f;
		}

		public float GetRebellionResistanceModifier()
		{
			return 0f;
		}

		public float GetNavalCombatModifier()
		{
			return 0f;
		}

		public float GetWarshipBuildTimeMultiplier()
		{
			return 0f;
		}

		public void SetBaseSkillValues(float charisma, float military, float diplomatic, float administrative)
		{
		}

		public bool HasTrait(string traitName)
		{
			return false;
		}

		public void AddTrait(string traitName)
		{
		}

		public void RemoveTrait(string traitName)
		{
		}

		public void ApplyTraitEffects()
		{
		}

		private void ResetTraitAffectedAttributes()
		{
		}

		private bool HasIncompatibleTraits(CharacterTrait newTrait)
		{
			return false;
		}

		private bool IsNationalLeader()
		{
			return false;
		}

		public List<CharacterTrait> GetAvailableTraits()
		{
			return null;
		}

		public void AddRandomTraits(int count)
		{
		}

		public void ClearAllTraits()
		{
		}

		public static string GetTraitDescription(CharacterTrait trait)
		{
			return null;
		}
	}
}
