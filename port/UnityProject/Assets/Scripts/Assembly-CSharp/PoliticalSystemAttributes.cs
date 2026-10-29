using System;

[Serializable]
public class PoliticalSystemAttributes
{
	public float attackModifier;

	public float defenseModifier;

	public float armyMaintenanceCost;

	public float recruitmentSpeed;

	public float taxEfficiency;

	public float goldProductionModifier;

	public float tradeEfficiency;

	public float diplomaticPowerGain;

	public float vassalizationChance;

	public float allianceStability;

	public float loyaltyGain;

	public float rebellionResistance;

	public float coreProvinceLimit;

	public float corruptionGrowth;

	public float warExhaustionGain;

	public float armyLossThreshold;

	public float territoryLossThreshold;

	public float religiousUnityImportance;

	public float conversionStrength;

	public static PoliticalSystemAttributes GetDefaultForPoliticalSystem(PoliticalSystem politicalSystem)
	{
		return null;
	}
}
