public static class WorldSettings
{
	public static float minYearSinceLastWar;

	public static float simulateFactor;

	public static float minMonthSinceLastEmergencyMobilize;

	public static float maxDiplomacyPower;

	public static int monthLengthInSeconds;

	public static float dayLengthInSeconds;

	public static float foodComsumptionPerPerson;

	public static float armyCountDisplayFactor;

	public static int armyDisplayMinCount;

	public static int armyDisplayMedianCount;

	public static int armyDisplayMaxCount;

	public static int armyDisplayCountStep;

	public static float regularArmyPerProvinceCapRatio;

	public static float armyUnitCombatScale;

	public static float armyEliminatedFactor;

	public static int populationDisplayFactor;

	public static int foodProductionFactor;

	public static float populationGrowRate;

	public static int populationInitPercellFactor;

	public static int foodReserveInitMaxMonth;

	public const int c_DefaultMinMonthSinceLastRebel = 12;

	public const int c_DefaultMinMonthSinceLastFamilyRebellion = 18;

	public const int c_DefaultMinMonthSinceLastCivilWar = 36;

	public static int minMonthSinceLastRebel;

	public static int minMonthSinceLastFamilyRebellion;

	public static int minMonthToRebelSinceConquered;

	public static int minProvinceCanRebel;

	public static int minMonthProvinceCanRebelSinceStateBorn;

	public static int diplomacyEfficiencyFactor;

	public static int diplomacyPowerToStartWar;

	internal static float diplomacyPowerToJoinAlliance;

	public static int diplomacyPowerToStartAlliance;

	public static int diplomacyPowerToEndWar;

	public static int diplomacyPowerToEndAlliance;

	public static int diplomacyPowerToStartTrade;

	public static int diplomacyPowerToEndTrade;

	public static int minYearBeforeWarEnd;

	public const int c_DefaultMinMonthToBeginAnotherWar = 12;

	public static int minMonthToBeginAnotherWar;

	public const int c_DefaultMinMonthAfterPassiveWarToBeginNew = 12;

	public static int minMonthAfterPassiveWarToBeginNew;

	public const int c_DefaultMaxMonthBeforeForceEndWar = 240;

	public const int c_MaxMonthBeforeForceEndWarLimit = 480;

	public static int maxMonthBeforeForceEndWar;

	public static int maxArmyRatioBeforeWarEnd;

	public static bool useWarSystemV2;

	public static bool newGameUseWarSystemV2;

	public static bool warV2VerboseLog;

	internal static float populationFoodProductionEfficiencyFactor;

	public static int baseWarProbability;

	public static int baseWarProbabilityWhenAtWar;

	internal static float minYearsBeforeNewWar;

	internal static int minAgeForWar;

	internal static int minProvinceCanCivilWar;

	public static int minMonthSinceLastCivilWar;

	internal static float minDestinyCanCivilWar;

	internal static int civilWarChance;

	public static int navyBuildBaseMonths;

	public static int navalPortsPerNavy;

	public static int navalPortsPerMerchantShip;

	public static int navalPortCellSearchDepth;

	public static float navalPortMaxOccupationValue;

	public static float navalPortOccupationAttackPerSecond;

	public static float navalPortOccupationRecoverPerSecond;

	public static float navalPortOccupationDefendPerSecond;

	public static float landArmySeaCrossingPressureThreshold;

	public static float navalAttackDeployRatio;

	public static float merchantShipSpriteScale;

	public static float navySpriteScale;

	public static float navySvgSizeCorrection;

	public static bool enableNavalAIDebugLog;

	public static bool enablePortFeatureDebugLabel;

	public static float portFeatureDebugLabelScaleFactor;

	public static float portFeatureDebugLabelOffsetFactor;

	public static bool IsLegacyMixedWarCompatibility { get; set; }
}
