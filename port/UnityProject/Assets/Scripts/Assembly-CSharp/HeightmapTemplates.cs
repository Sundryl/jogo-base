using System.Collections.Generic;

public static class HeightmapTemplates
{
	public class HeightmapTemplate
	{
		public string Name { get; private set; }

		public string Template { get; private set; }

		public int Probability { get; private set; }

		public HeightmapTemplate(string name, string template, int probability)
		{
		}
	}

	private static List<HeightmapTemplate> templates;

	public static IReadOnlyList<HeightmapTemplate> Templates => null;
}
