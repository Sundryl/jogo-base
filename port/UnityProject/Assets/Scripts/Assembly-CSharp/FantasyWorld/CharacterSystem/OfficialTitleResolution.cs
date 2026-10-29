namespace FantasyWorld.CharacterSystem
{
	public sealed class OfficialTitleResolution
	{
		public string Title { get; }

		public OfficialTitleSourceKind SourceKind { get; }

		public string SourcePresetId { get; }

		public string SourceEntryKey { get; }

		public OfficialTitleResolution(string _title, OfficialTitleSourceKind _sourceKind, string _sourcePresetId, string _sourceEntryKey)
		{
		}
	}
}
