using System;
using System.Collections.Generic;

[Serializable]
public class MilitaryProfileFileData
{
	public MilitaryProfileMode Mode { get; set; }

	public List<MilitaryUnitDefinition> UnitDefinitions { get; set; }

	public Dictionary<string, string> VisualBindings { get; set; }

	public List<MilitaryProfileFileAsset> FileAssets { get; set; }

	public Dictionary<string, string> Metadata { get; set; }
}
