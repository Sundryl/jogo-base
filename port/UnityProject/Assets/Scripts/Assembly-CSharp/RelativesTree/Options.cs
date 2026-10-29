namespace RelativesTree
{
	public class Options
	{
		public string RootId { get; set; }

		public bool UsePlaceholders { get; set; }

		public float NodeWidth { get; set; }

		public float NodeHeight { get; set; }

		public float LevelHeight { get; set; }

		public float SpouseGap { get; set; }

		public float SiblingGap { get; set; }

		public Options(string rootId)
		{
		}
	}
}
