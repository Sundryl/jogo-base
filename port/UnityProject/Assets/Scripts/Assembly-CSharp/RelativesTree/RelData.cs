using System.Collections.Generic;

namespace RelativesTree
{
	public class RelData
	{
		public CanvasSize Canvas { get; set; }

		public List<Family> Families { get; set; }

		public List<ExtNode> Nodes { get; set; }

		public List<Connector> Connectors { get; set; }
	}
}
