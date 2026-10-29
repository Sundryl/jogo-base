using System.Collections.Generic;
using UnityEngine;

public sealed class CustomMapImageManager
{
	private const float c_ImageZ = -0.41f;

	private const float c_MinZ = -1f;

	private const float c_MaxZ = 0f;

	private const float c_DefaultZ = -0.41f;

	private const int c_DataVersion = 5;

	private const float c_DefaultMaxWorldSize = 12f;

	private const float c_MinScale = 0f;

	private const float c_MaxScale = 60f;

	private const float c_MinAlpha = 0.05f;

	private const float c_MaxAlpha = 1f;

	private const float c_MinRotation = -180f;

	private const float c_MaxRotation = 180f;

	private const int c_MinLayerOrder = 0;

	private const int c_MaxLayerOrder = 999;

	private const CustomMapImageLayer c_DefaultLayer = CustomMapImageLayer.ArmyOverlay;

	private const string c_DefaultImageNameKey = "CustomImageDefaultName";

	private const string c_CopyNameFormatKey = "CustomImageCopyNameFormat";

	private const float c_DuplicateOffset = 0.5f;

	private static readonly CustomMapImageLayerInfo[] s_LayerInfos;

	private static CustomMapImageManager s_Instance;

	private readonly Dictionary<string, CustomMapImageData> m_Datas;

	private readonly List<CustomMapImageData> m_OrderedImageDatas;

	private readonly Dictionary<string, GameObject> m_Views;

	private readonly Dictionary<string, Sprite> m_RuntimeSprites;

	private string m_ActiveEditingId;

	private bool m_IsCustomImageEditingModeActive;

	public static CustomMapImageManager Instance => null;

	public IReadOnlyList<CustomMapImageData> GetAll()
	{
		return null;
	}

	public Vector2 GetScaleRange()
	{
		return default;
	}

	public Vector2 GetAlphaRange()
	{
		return default;
	}

	public Vector2 GetRotationRange()
	{
		return default;
	}

	public Vector2 GetZRange()
	{
		return default;
	}

	public IReadOnlyList<CustomMapImageLayerInfo> GetLayerInfos()
	{
		return null;
	}

	public int GetLayerOrderMin()
	{
		return 0;
	}

	public int GetLayerOrderMax()
	{
		return 0;
	}

	public CustomMapImageLayer GetLayerFromDropdownIndex(int _index)
	{
		return CustomMapImageLayer.OceanOverlay;
	}

	public int GetDropdownIndexForLayer(CustomMapImageLayer _layer)
	{
		return 0;
	}

	public CustomMapImageData CreateImageAt(string _displayName, byte[] _imageBytes, string _format, Vector2 _screenPos01)
	{
		return null;
	}

	public bool ReplaceImage(string _id, byte[] _imageBytes, string _format, string _displayName = null)
	{
		return false;
	}

	public CustomMapImageData DuplicateImage(string _id)
	{
		return null;
	}

	public bool SetDisplayName(string _id, string _displayName)
	{
		return false;
	}

	public bool SetLocalPosition(string _id, Vector2 _localPosition)
	{
		return false;
	}

	public bool SetScale(string _id, float _scale)
	{
		return false;
	}

	public bool SetRotation(string _id, float _rotationZ)
	{
		return false;
	}

	public bool SetZ(string _id, float _z)
	{
		return false;
	}

	public bool SetLayer(string _id, CustomMapImageLayer _layer)
	{
		return false;
	}

	public bool SetLayerOrder(string _id, int _order)
	{
		return false;
	}

	public bool SetAlpha(string _id, float _alpha)
	{
		return false;
	}

	public bool SetVisible(string _id, bool _visible)
	{
		return false;
	}

	public float GetScale(string _id)
	{
		return 0f;
	}

	public float GetRotation(string _id)
	{
		return 0f;
	}

	public float GetAlpha(string _id)
	{
		return 0f;
	}

	public bool IsVisible(string _id)
	{
		return false;
	}

	public string GetDisplayName(string _id)
	{
		return null;
	}

	public Sprite GetPreviewSprite(string _id)
	{
		return null;
	}

	public bool TryGetData(string _id, out CustomMapImageData _data)
	{
		_data = null;
		return false;
	}

	public void SetActiveEditingImage(string _id)
	{
	}

	public void SetCustomImageEditingModeActive(bool _isActive)
	{
	}

	public void ClearActiveEditingImage()
	{
	}

	public bool TryHandleEditModePointerDown(Vector2 _screenPosition)
	{
		return false;
	}

	public void Remove(string _id)
	{
	}

	public void ClearAll()
	{
	}

	public string Serialize()
	{
		return null;
	}

	public void Deserialize(string _json)
	{
	}

	public void RebuildViews()
	{
	}

	private void EnsureView(CustomMapImageData _data)
	{
	}

	private void ApplyToView(string _id, CustomMapImageData _data)
	{
	}

	private void ApplyTransform(string _id, CustomMapImageData _data)
	{
	}

	private void ApplyVisual(string _id, CustomMapImageData _data)
	{
	}

	private void RefreshEditingState()
	{
	}

	private bool CanEditImage(CustomMapImageData _data)
	{
		return false;
	}

	private bool TryGetEditableImageDragHandlerAtScreenPosition(Vector2 _screenPosition, out CustomMapImageDragHandler _dragHandler)
	{
		_dragHandler = null;
		return false;
	}

	private void RefreshLayerZValues(bool _applyTransforms = true)
	{
	}

	private int GetNextLayerOrder(CustomMapImageLayer _layer)
	{
		return 0;
	}

	private static float CalculateLayerZ(CustomMapImageLayerInfo _layerInfo, int _indexInLayer, int _count)
	{
		return 0f;
	}

	private static CustomMapImageLayer NormalizeLayer(CustomMapImageLayer _layer)
	{
		return CustomMapImageLayer.OceanOverlay;
	}

	private static CustomMapImageLayer InferLayerFromZ(float _z)
	{
		return CustomMapImageLayer.OceanOverlay;
	}

	private Sprite GetOrCreateSprite(string _id, CustomMapImageData _data)
	{
		return null;
	}

	private static bool TryCreateSprite(byte[] _bytes, out Sprite _sprite, out string _encodedBytes)
	{
		_sprite = null;
		_encodedBytes = null;
		return false;
	}

	private static bool TryEncodeImageBytes(byte[] _bytes, out string _encodedBytes)
	{
		_encodedBytes = null;
		return false;
	}

	private void ReleaseRuntimeSprite(string _id)
	{
	}

	private void ClearAllViews()
	{
	}

	private void ClearAllRuntimeSprites()
	{
	}

	private static bool IsFinite(float _value)
	{
		return false;
	}

	private static CustomMapImageData CloneForSave(CustomMapImageData _data, string _imageHash)
	{
		return null;
	}

	private static Dictionary<string, CustomMapImageAssetData> BuildImageAssetLookup(List<CustomMapImageAssetData> _imageAssets)
	{
		return null;
	}

	private static bool TryResolveImageAsset(CustomMapImageData _data, Dictionary<string, CustomMapImageAssetData> _imageAssetsByHash)
	{
		return false;
	}

	private static string ComputeImageHash(byte[] _bytes)
	{
		return null;
	}

	private static string SanitizeDisplayName(string _displayName)
	{
		return null;
	}

	private static string GetResolvedDisplayName(CustomMapImageData _data)
	{
		return null;
	}

	private static string BuildCopyDisplayName(CustomMapImageData _source)
	{
		return null;
	}

	private static Vector3 Screen01ToWorld(Vector2 _screenPos01)
	{
		return default;
	}
}
