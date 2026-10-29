using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class MilitaryProfile
{
	private const string c_BuiltInVisualPrefix = "builtin:";

	private const string c_EmbeddedVisualPrefix = "embedded-icon:";

	public const string CultureDirectoryName = "military";

	public const string CultureProfileFileName = "MilitaryProfile.json";

	private const string c_BuiltInProfileStreamingRelativePath = "Base/Military/Default";

	private const string c_InfantrySpriteResourcePath = "Sprites/army-chess-pawn-icon";

	private const string c_ArcherSpriteResourcePath = "Sprites/recurve-bow-arrow-icon";

	private const string c_ShieldSpriteResourcePath = "Sprites/shield-cross-icon";

	private const string c_CavalrySpriteResourcePath = "Sprites/army-chess-knight-icon";

	private const string c_EliteSpriteResourcePath = "Sprites/gonfalon-knight-icon";

	private static readonly Dictionary<string, string> s_BuiltInVisualResourcePaths;

	private static readonly Dictionary<string, Sprite> s_BuiltInSpriteCache;

	private static MilitaryProfile s_BuiltInTemplate;

	[JsonIgnore]
	private Dictionary<string, MilitaryUnitDefinition> m_UnitDefinitionLookup;

	[JsonIgnore]
	private Dictionary<string, EmbeddedPngAsset> m_EmbeddedAssetLookup;

	[JsonIgnore]
	private Dictionary<string, Sprite> m_RuntimeEmbeddedSpriteCache;

	[JsonIgnore]
	private List<MilitaryUnitDefinition> m_AvailableUnitDefinitions;

	[JsonIgnore]
	private bool m_IsRuntimeReady;

	public MilitaryProfileMode Mode { get; set; }

	public List<MilitaryUnitDefinition> UnitDefinitions { get; set; }

	public Dictionary<string, string> VisualBindings { get; set; }

	public List<EmbeddedPngAsset> EmbeddedPngAssets { get; set; }

	public Dictionary<string, string> Metadata { get; set; }

	public static MilitaryProfile CreateBuiltInDefaultProfile()
	{
		return null;
	}

	public static MilitaryProfile CreateMapDefaultProfile()
	{
		return null;
	}

	public static MilitaryProfile CreateMapDefaultReferenceProfile()
	{
		return null;
	}

	public static MilitaryProfile GetSharedBuiltInDefaultProfile()
	{
		return null;
	}

	public MilitaryProfile Clone()
	{
		return null;
	}

	public void EnsureRuntimeReady()
	{
	}

	public void MarkRuntimeDirty()
	{
	}

	public void ClearRuntimeEmbeddedSpriteCache()
	{
	}

	public MilitaryUnitDefinition FindUnitDefinitionExact(string unitKey)
	{
		return null;
	}

	public bool ContainsUnitKey(string unitKey)
	{
		return false;
	}

	public string GenerateUniqueUnitKey(string preferredBaseKey = null)
	{
		return null;
	}

	public string GenerateUniqueEmbeddedAssetKey(string preferredBaseKey = null)
	{
		return null;
	}

	public static MilitaryUnitDefinition CreateCustomUnitDefinition(string unitKey, string displayName = null)
	{
		return null;
	}

	public string GetDisplayName(string _unitKey, string _language = null)
	{
		return null;
	}

	public MilitaryUnitDefinition GetUnitDefinition(string _unitKey)
	{
		return null;
	}

	public List<MilitaryUnitDefinition> GetAvailableUnitDefinitions()
	{
		return null;
	}

	public float GetUnitCombatModifier(string _unitKey, Province _province, bool _isAttacking)
	{
		return 0f;
	}

	public float GetUnitMovementSpeedMultiplier(string _unitKey)
	{
		return 0f;
	}

	public float GetUnitLandSpriteScaleMultiplier(string _unitKey)
	{
		return 0f;
	}

	public bool ShouldUseStateColorTint(string _unitKey)
	{
		return false;
	}

	public Sprite ResolveSprite(string _unitKey)
	{
		return null;
	}

	public Sprite ResolveVisualAssetSprite(string visualAssetKey)
	{
		return null;
	}

	public bool HasEmbeddedPngAsset(string assetKey)
	{
		return false;
	}

	public EmbeddedPngAsset GetEmbeddedPngAsset(string assetKey)
	{
		return null;
	}

	public List<EmbeddedPngAsset> GetEmbeddedPngAssets()
	{
		return null;
	}

	public void SetEmbeddedPngAsset(string assetKey, byte[] imageBytes, string format = "png", string displayName = null)
	{
	}

	public void RemoveEmbeddedPngAsset(string assetKey)
	{
	}

	public bool TryCopyEmbeddedPngAsset(string sourceAssetKey, string targetAssetKey)
	{
		return false;
	}

	public void SaveToCultureDirectory(string cultureDirectoryPath)
	{
	}

	public static MilitaryProfile LoadFromCultureDirectory(string cultureDirectoryPath)
	{
		return null;
	}

	public static string GetCultureMilitaryDirectoryPath(string cultureDirectoryPath)
	{
		return null;
	}

	private static MilitaryProfile GetBuiltInTemplate()
	{
		return null;
	}

	private static bool TryLoadBuiltInTemplateFromStreamingAssets(out MilitaryProfile _profile)
	{
		_profile = null;
		return false;
	}

	private static string GetBuiltInTemplateRootPath()
	{
		return null;
	}

	private static MilitaryProfile PrepareBuiltInTemplate(MilitaryProfile _profile)
	{
		return null;
	}

	private static bool HasValidUnitDefinitions(MilitaryProfile _profile)
	{
		return false;
	}

	private static Dictionary<string, float> ExpandBiomeGroupModifiersForTemplate(Dictionary<string, float> biomeGroupModifiers)
	{
		return null;
	}

	private static MilitaryProfile CreateHardcodedBuiltInTemplate()
	{
		return null;
	}

	private void ApplyBuiltInDefaults()
	{
	}

	private void RebuildCaches()
	{
	}

	private void InvalidateEmbeddedSpriteCache(string assetKey)
	{
	}

	private bool TryResolveBuiltInSprite(string _visualKey, out Sprite _sprite)
	{
		_sprite = null;
		return false;
	}

	private bool TryResolveEmbeddedSprite(string _visualKey, out Sprite _sprite)
	{
		_sprite = null;
		return false;
	}

	private static string ResolveBuiltInResourcePath(string _visualKey)
	{
		return null;
	}

	private static string BuildUniqueCultureAssetFileName(EmbeddedPngAsset embeddedPngAsset, HashSet<string> usedFileNames)
	{
		return null;
	}

	private static byte[] TryGetCultureExportPngBytes(EmbeddedPngAsset embeddedPngAsset)
	{
		return null;
	}
}
