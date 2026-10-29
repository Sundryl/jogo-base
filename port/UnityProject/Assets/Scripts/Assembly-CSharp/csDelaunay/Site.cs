using System;
using System.Collections.Generic;

namespace csDelaunay
{
	public class Site : ICoord
	{
		private const float EPSILON = 0.005f;

		private static Queue<Site> pool;

		private static readonly Comparison<Site> s_YThenXComparer;

		public Vector2f coord;

		public List<LR> edgeOrientations;

		public List<Vector2f> region;

		public int SiteIndex { get; set; }

		public int Index { get; set; }

		public int CellIndex { get; set; }

		public List<Edge> Edges { get; private set; }

		public float Weigth { get; private set; }

		public Vector2f Coord
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public float X
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Y
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static Site Create(Vector2f p, int index, float weigth)
		{
			return null;
		}

		public static void SortSites(List<Site> sites)
		{
		}

		public Site(Vector2f p, int index, float weigth)
		{
		}

		public override string ToString()
		{
			return null;
		}

		private void Move(Vector2f p)
		{
		}

		public void Dispose()
		{
		}

		private void Clear()
		{
		}

		public void PrepForUpdate()
		{
		}

		public void AddEdge(Edge edge)
		{
		}

		public Edge NearestEdge()
		{
			return null;
		}

		public List<Site> NeighborSites()
		{
			return null;
		}

		public Dictionary<Site, Edge> NeighborSiteEdges()
		{
			return null;
		}

		public Site NeighborSite(Edge edge)
		{
			return null;
		}

		public List<Vector2f> Region(Rectf clippingBounds)
		{
			return null;
		}

		public float Dist(ICoord p)
		{
			return 0f;
		}

		public int Compare(Site s1, Site s2)
		{
			return 0;
		}

		public int CompareTo(Site s1)
		{
			return 0;
		}

		private static bool CloseEnough(Vector2f p0, Vector2f p1)
		{
			return false;
		}

		private Site Init(Vector2f p, int index, float weigth)
		{
			return null;
		}

		private static int CompareByYThenXThenIndex(Site s0, Site s1)
		{
			return 0;
		}

		private void ReorderEdges()
		{
		}

		private List<Vector2f> ClipToBounds(Rectf bounds)
		{
			return null;
		}

		private void Connect(ref List<Vector2f> points, int j, Rectf bounds, bool closingUp = false)
		{
		}
	}
}
