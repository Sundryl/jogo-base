public struct CustomMapImageLayerInfo
{
	public CustomMapImageLayer Layer;

	public string LocalizationKey;

	public float BackZ;

	public float FrontZ;

	public CustomMapImageLayerInfo(CustomMapImageLayer _layer, string _localizationKey, float _backZ, float _frontZ)
	{
		Layer = CustomMapImageLayer.OceanOverlay;
		LocalizationKey = null;
		BackZ = 0f;
		FrontZ = 0f;
	}
}
