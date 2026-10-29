using System.Collections.Generic;

public static class CasusBelliServiceV2
{
	public const int CbTerritorialConquest = 1;

	public const int CbAnnexation = 2;

	public const int CbHegemony = 3;

	public const int CbGrudge = 4;

	public const int CbRaid = 5;

	public const int CbCulturalUnification = 6;

	public const int CbReligiousConversion = 7;

	public const int CbBlankOccupation = 8;

	public const float CulturalUnifyAdvantageFloor = 0.45f;

	public const int CbCivilWarSuccession = 10;

	public const int CbCivilWarReform = 11;

	public const int CbCivilWarIndependence = 12;

	public const int CbCivilWarOverthrow = 13;

	public const int CbProvinceRebellion = 14;

	public const int CbFamilyRebellion = 15;

	public const int CbVassalRevolt = 16;

	private static List<CasusBelliDefinitionV2> _catalog;

	public static IReadOnlyList<CasusBelliDefinitionV2> Catalog => null;

	public static CasusBelliDefinitionV2 GetById(int id)
	{
		return null;
	}

	internal static bool IsValidConversionReligion(string religionId)
	{
		return false;
	}

	internal static bool IsTheocraticAttackerReligiousConflict(State attacker, State defender)
	{
		return false;
	}

	public static List<CasusBelliDefinitionV2> GetUsableCasusBelli(State attacker, State defender)
	{
		return null;
	}

	public static WarDeclarationV2 TryBuildDeclaration(State attacker, State defender, CasusBelliDefinitionV2 cb)
	{
		return null;
	}

	public static WarDeclarationV2 BuildPlayerDeclaration(State attacker, State defender)
	{
		return null;
	}

	public static WarDeclarationV2 BuildRebellionSuppressionDeclaration(State mother, State rebel)
	{
		return null;
	}

	public static WarDeclarationV2 BuildInternalWarDeclaration(int attackerId, int defenderId, int rebelStateId, int motherStateId, WarGoalTypeV2 goalType, WarType legacyType, int cbId)
	{
		return null;
	}

	private static List<CasusBelliDefinitionV2> BuildCatalog()
	{
		return null;
	}
}
