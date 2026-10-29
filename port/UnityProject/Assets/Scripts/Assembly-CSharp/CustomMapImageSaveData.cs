using System;
using System.Collections.Generic;

[Serializable]
public class CustomMapImageSaveData
{
	public int Version;

	public List<CustomMapImageAssetData> ImageAssets;

	public List<CustomMapImageData> Images;
}
