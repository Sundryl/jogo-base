using System;

namespace FantasyWorld.CharacterSystem
{
	[Serializable]
	public class CharacterTrait
	{
		public string name;

		public string description;

		public TraitType type;

		public float charismaModifier;

		public float militaryModifier;

		public float diplomaticModifier;

		public float administrativeModifier;

		public float taxEfficiencyModifier;

		public float rebellionResistanceModifier;

		public float emergencyMobilizationModifier;

		public bool canEmergencyMobilization;

		public float combatModifierPerEnemy;

		public float navalCombatModifier;

		public float warshipBuildTimeMultiplier;

		public bool isReformer;

		public float relationshipBonus;

		public float familyInfluenceModifier;

		public bool isCongenital;

		public bool isLifestyle;

		public bool isPersonality;

		public string[] incompatibleTraits;

		public void ApplyToCharacter(Character character)
		{
		}

		public void RemoveFromCharacter(Character character)
		{
		}

		public bool IsIncompatibleWith(CharacterTrait otherTrait)
		{
			return false;
		}

		public CharacterTrait Clone()
		{
			return null;
		}

		public string GetLocalizedName()
		{
			return null;
		}

		public string GetLocalizedDescription()
		{
			return null;
		}
	}
}
