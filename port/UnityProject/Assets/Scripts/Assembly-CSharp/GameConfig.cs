using System;
using System.Collections.Generic;

[Serializable]
public class GameConfig
{
	public const int CurrentVersion = 6;

	public int Version;

	public ColorData DeepSeaColor;

	public ColorData ShallowSeaColor;

	public ColorData SeaRouteColor;

	public ColorData StateLineColor;

	public ColorData CoastLineColor;

	public ColorData StateNameColor;

	public ColorData ProvinceBorderColor;

	public List<string> EnabledCultureIDs;

	public List<string> EnabledReligionIDs;

	public float StateBorderWidth;

	public float CoastBorderWidth;

	public float DarkBorderShadowWidth;

	public float StateNameScale;

	public float IconDisplayDistance;

	public float BurgCityLabelScale;

	public float ArmyLabelScale;

	public float StateMapTransparency;

	public bool DisplayBiomHeightMap;

	public bool DisplayArmy;

	public bool DisplayAttackArrow;

	public bool DisplayBurgName;

	public bool DisplayBurgObject;

	public bool DisplayParchment;

	public bool DisplayParchmentTexture;

	public bool DisplayDarkBorder;

	public bool DisplayFullName;

	public bool DisplayProvinceBorder;

	public bool DisplaySeaRoute;

	public float UseHeightMapBackground;

	public float UseGrayScale;

	public float IsEnableDarkBorder;

	public string LanguageIndex;

	public bool isAutoHideBottomPanel;

	public bool IsEnableRandomStyle;

	public float musicVolume;

	public int currentPresetIndex;

	public bool IsShowMajorMessage;

	public bool IsShowRiverEditWarning;

	public bool IsShowTime;

	public float AttackArrowDisplayDistance;

	public float cameraZoomSpeed;

	public bool IsShowDouyinAnnoucement;

	public bool IsEnableMapCoordinate;

	public bool IsEnableBiomeIcon;

	public bool isEnableMapEditDescription;

	public bool isEnableTooltips;

	public bool isPauseWhenEditing;

	public bool isAllowAutoDiplomacy;

	public bool isAllowRebel;

	public bool IsAssistAlliesOccupyLand;

	public bool isAllowVassalAutoRebel;

	public bool isEnableSnowCoveredLandAndDesert;

	public bool isAllowAlliance;

	public bool isEnableVassal;

	public bool IsAutoAbandonIsolatedProvinces;

	public bool isAllowCivilWar;

	public bool isAllowFamilyRebellion;

	public bool useWarSystemV2NewGame;

	public bool isEnableAutoSave;

	public int? autoSaveIntervalMinutes;

	public int? minMonthSinceLastProvinceRebellion;

	public int? minMonthSinceLastFamilyRebellion;

	public int? minMonthSinceLastCivilWar;

	public int? minMonthToBeginAnotherWar;

	public int? minMonthAfterPassiveWarToBeginNew;

	public int? maxMonthBeforeForceEndWar;

	public List<string> HistoryTimelineWorldFilterEventTypes;

	public List<string> HistoryTimelineStateFilterEventTypes;
}
