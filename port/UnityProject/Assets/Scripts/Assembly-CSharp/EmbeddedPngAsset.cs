using System;

[Serializable]
public class EmbeddedPngAsset
{
	public string AssetKey { get; set; }

	public string DisplayName { get; set; }

	public string Format { get; set; }

	public string BytesBase64 { get; set; }

	public EmbeddedPngAsset Clone()
	{
		return null;
	}

	public bool HasData()
	{
		return false;
	}
}
