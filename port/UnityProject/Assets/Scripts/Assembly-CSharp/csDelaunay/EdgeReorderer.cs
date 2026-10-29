using System;
using System.Collections.Generic;

namespace csDelaunay
{
	public class EdgeReorderer
	{
		public List<Edge> Edges { get; private set; }

		public List<LR> EdgeOrientations { get; private set; }

		public EdgeReorderer(List<Edge> origEdges, Type criterion)
		{
		}

		public void Dispose()
		{
		}

		private List<Edge> ReorderEdges(List<Edge> origEdges, Type criterion)
		{
			return null;
		}
	}
}
